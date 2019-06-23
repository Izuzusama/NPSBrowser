using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;

namespace NPS
{
    public partial class Library : Form
    {
        List<LibraryItem> localLib = new List<LibraryItem>();
        List<LibraryItem> remoteLib = new List<LibraryItem>();
        List<Item> db;

        public Library(List<Item> db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void Library_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listView2.Items.Clear();
            localLib.Clear();

            label1.Text = Settings.Instance.downloadDir;

            string[] apps = new string[0];
            string[] dlcs = new string[0];
            string[] files = Directory.GetFiles(Settings.Instance.downloadDir, "*.pkg");

            if (Directory.Exists(Settings.Instance.downloadDir + "\\packages"))
            {
                var lst = files.ToList();
                lst.AddRange(Directory.GetFiles(Settings.Instance.downloadDir + "\\packages", "*.pkg"));
                files = lst.ToArray();
            }

            if (Directory.Exists(Settings.Instance.downloadDir + "\\app"))
            {
                apps = Directory.GetDirectories(Settings.Instance.downloadDir + "\\app");
            }
            if (Directory.Exists(Settings.Instance.downloadDir + "\\addcont"))
            {
                dlcs = Directory.GetDirectories(Settings.Instance.downloadDir + "\\addcont");
            }

            List<string> imagesToLoad = new List<string>();

            foreach (string s in files)
            {
                var f = Path.GetFileNameWithoutExtension(s);

                bool found = false;
                foreach (var itm in db)
                {
                    if (f.Equals(itm.DownloadFileName))
                    {
                        ListViewItem lvi = new ListViewItem(itm.TitleName + " (PKG)" + " [" + itm.TitleId + "]");

                        listView1.Items.Add(lvi);

                        foreach (var r in NPCache.I.renasceneCache)
                            if (itm.Equals(r.itm))
                            {
                                imagesToLoad.Add(r.imgUrl);
                                lvi.ImageKey = r.imgUrl;
                                break;
                            }
                        LibraryItem library = new LibraryItem();
                        library.itm = itm;
                        library.path = s;
                        library.isPkg = true;
                        lvi.Tag = library;
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    ListViewItem lvi = new ListViewItem(f + " (UNKNOWN PKG)");

                    listView1.Items.Add(lvi);

                    LibraryItem library = new LibraryItem();
                    library.path = s;
                    library.isPkg = true;
                    lvi.Tag = library;
                }
            }

            foreach (string s in apps)
            {
                string d = Path.GetFullPath(s).TrimEnd(Path.DirectorySeparatorChar).Split(Path.DirectorySeparatorChar).Last();

                bool found = false;
                foreach (var itm in db)
                {
                    if (!itm.IsDLC)
                    {
                        if (itm.TitleId.Equals(d))
                        {
                            ListViewItem lvi = new ListViewItem($"({itm.Region}) {itm.TitleName}");

                            listView1.Items.Add(lvi);

                            foreach (var r in NPCache.I.renasceneCache)
                                if (itm.Equals(r.itm))
                                {
                                    imagesToLoad.Add(r.imgUrl);
                                    lvi.ImageKey = r.imgUrl;
                                    break;
                                }
                            LibraryItem library = new LibraryItem();
                            library.itm = itm;
                            library.path = s;
                            if (Directory.Exists(Path.Combine(Settings.Instance.downloadDir, "addcont", itm.TitleId)))
                            {
                                library.dlcPath = Path.Combine(Settings.Instance.downloadDir, "addcont", itm.TitleId);
                            }
                            if (Directory.Exists(Path.Combine(Settings.Instance.downloadDir, "patch", itm.TitleId)))
                            {
                                library.patchPath = Path.Combine(Settings.Instance.downloadDir, "patch", itm.TitleId);
                            }
                            library.isPkg = false;
                            lvi.Tag = library;
                            found = true;
                            localLib.Add(library);
                            break;
                        }
                    }
                }

                if (!found)
                {
                    ListViewItem lvi = new ListViewItem(d + " UNKNOWN");

                    listView1.Items.Add(lvi);

                    LibraryItem library = new LibraryItem();
                    library.path = s;
                    library.isPkg = false;
                    lvi.Tag = library;
                }
            }



            //foreach (string s in dlcs)
            //{
            //    string d = Path.GetFullPath(s).TrimEnd(Path.DirectorySeparatorChar).Split(Path.DirectorySeparatorChar).Last();
            //    foreach (var itm in db)
            //    {
            //        if (itm.IsDLC && itm.TitleId.Equals(d))
            //        {
            //            ListViewItem lvi = new ListViewItem(itm.TitleName);

            //            listView1.Items.Add(lvi);

            //            foreach (var r in NPCache.I.renasceneCache)
            //                if (itm == r.itm)
            //                {
            //                    imagesToLoad.Add(r.imgUrl);
            //                    lvi.ImageKey = r.imgUrl;
            //    break;
            //                }
            //            LibraryItem library = new LibraryItem();
            //            library.itm = itm;
            //            library.patch = s;
            //            library.isPkg = false;
            //            lvi.Tag = library;
            //break;
            //        }
            //    }
            //}


            Task.Run(() =>
            {
                foreach (string url in imagesToLoad)
                {
                    WebClient wc = new WebClient();
                    wc.Proxy = Settings.Instance.proxy;
                    wc.Encoding = Encoding.UTF8;
                    var img = wc.DownloadData(url);
                    using (var ms = new MemoryStream(img))
                    {
                        Image image = Image.FromStream(ms);
                        image = getThumb(image);
                        Invoke(new Action(() =>
                        {
                            imageList1.Images.Add(url, image);
                        }));
                    }
                }


            });
            SetupRemoteDirectory();
            UpdateRemoteDirectory();
        }

        void SetupRemoteDirectory()
        {
            comboBox1.Items.Clear();
            IList<DriveInfo> driveList = DriveInfo.GetDrives().Where(d => d.DriveType == DriveType.Removable).ToList();
            foreach (DriveInfo driveInfo in driveList)
            {
                comboBox1.Items.Add(driveInfo.RootDirectory.ToString());
            }

            if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = 0;
            }
        }

        void UpdateRemoteDirectory()
        {
            if (string.IsNullOrEmpty(comboBox1.Text)) return;
            listView2.Items.Clear();
            remoteLib.Clear();
            string appDir = Path.Combine(comboBox1.Text, "app");
            string dlcDir = Path.Combine(comboBox1.Text, "addcont");
            string patchDir = Path.Combine(comboBox1.Text, "patch");
            DirectoryInfo di = new DirectoryInfo(appDir);
            if (!di.Exists)
            {
                return;
            }
            List<string> imagesToLoad = new List<string>();
            foreach (DirectoryInfo directoryInfo in di.GetDirectories())
            {
                string folder = directoryInfo.Name;
                foreach (Item itm in db)
                {
                    if (itm.IsDLC) continue;
                    if (itm.TitleId == folder)
                    {
                        DirectoryInfo dlcDi = new DirectoryInfo(Path.Combine(dlcDir, itm.TitleId));
                        DirectoryInfo patchDi = new DirectoryInfo(Path.Combine(patchDir, itm.TitleId));
                        ListViewItem lvi = new ListViewItem($"({itm.Region}) {itm.TitleName}");
                        listView2.Items.Add(lvi);

                        foreach (var r in NPCache.I.renasceneCache)
                            if (itm.Equals(r.itm))
                            {
                                imagesToLoad.Add(r.imgUrl);
                                lvi.ImageKey = r.imgUrl;
                                break;
                            }
                        LibraryItem library = new LibraryItem();
                        library.itm = itm;
                        library.path = directoryInfo.FullName;
                        if (dlcDi.Exists)
                        {
                            library.dlcPath = dlcDi.FullName;
                        }

                        if (patchDi.Exists)
                        {
                            library.patchPath = patchDi.FullName;
                        }
                        library.isPkg = false;
                        lvi.Tag = library;
                        remoteLib.Add(library);
                        break;
                    }
                }

            }
            Task.Run(() =>
            {
                foreach (string url in imagesToLoad)
                {
                    WebClient wc = new WebClient();
                    wc.Proxy = Settings.Instance.proxy;
                    wc.Encoding = Encoding.UTF8;
                    var img = wc.DownloadData(url);
                    using (var ms = new MemoryStream(img))
                    {
                        Image image = Image.FromStream(ms);
                        image = getThumb(image);
                        Invoke(new Action(() =>
                        {
                            imageList1.Images.Add(url, image);
                        }));
                    }
                }
            });
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateRemoteDirectory();
        }

        public Bitmap getThumb(Image image)
        {
            int tw, th, tx, ty;
            int w = image.Width;
            int h = image.Height;
            double whRatio = (double)w / h;

            if (image.Width >= image.Height)
            {
                tw = 100;
                th = (int)(tw / whRatio);
            }
            else
            {
                th = 100;
                tw = (int)(th * whRatio);
            }
            tx = (100 - tw) / 2;
            ty = (100 - th) / 2;
            Bitmap thumb = new Bitmap(100, 100, PixelFormat.Format24bppRgb);
            Graphics g = Graphics.FromImage(thumb);
            g.Clear(Color.White);
            g.InterpolationMode = InterpolationMode.NearestNeighbor;
            g.DrawImage(image,
            new Rectangle(tx, ty, tw, th),
            new Rectangle(0, 0, w, h),
            GraphicsUnit.Pixel);
            return thumb;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;
            string path = (listView1.SelectedItems[0].Tag as LibraryItem).path;
            System.Diagnostics.Process.Start("explorer.exe", "/select, " + path);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;
            var itm = (listView1.SelectedItems[0].Tag as LibraryItem); ;

            try
            {
                if (itm.isPkg)
                    File.Delete(itm.path);
                else Directory.Delete(itm.path, true);

                Library_Load(null, null);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;
            var itm = (listView1.SelectedItems[0].Tag as LibraryItem);
            if (itm.isPkg == false) return;
            if (itm.itm == null)
            {
                MessageBox.Show("Can't unpack unknown pkg");
                return;
            }

            if (itm.itm.ItsPS3 && itm.path.ToLower().Contains("packages")) File.Move(itm.path, Settings.Instance.downloadDir + Path.DirectorySeparatorChar + Path.GetFileName(itm.path));

            DownloadWorker dw = new DownloadWorker(itm.itm, this);
            dw.Start();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;
            var itm = (listView1.SelectedItems[0].Tag as LibraryItem);
            button3.Enabled = itm.isPkg;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Library_Load(null, null);
        }

        private void Btn_remoteList_refresh_Click(object sender, EventArgs e)
        {
            SetupRemoteDirectory();
        }

        private void Btn_remote_opendir_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count == 0) return;
            string path = (listView2.SelectedItems[0].Tag as LibraryItem).path;
            System.Diagnostics.Process.Start("explorer.exe", "/select, " + path);
        }

        private void Btn_remote_delete_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count == 0) return;
            LibraryItem li = (listView2.SelectedItems[0].Tag as LibraryItem);
            DialogResult result = MessageBox.Show($"Are you sure you want to delete {li.itm.TitleName} in remote?"
                , "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                DirectoryInfo di = new DirectoryInfo(li.path);
                di.Delete(true);
                if (!string.IsNullOrEmpty(li.dlcPath))
                {
                    DirectoryInfo dlcDi = new DirectoryInfo(li.dlcPath);
                    dlcDi.Delete(true);
                }
                if (!string.IsNullOrEmpty(li.patchPath))
                {
                    DirectoryInfo patchDi = new DirectoryInfo(li.patchPath);
                    patchDi.Delete(true);
                }
                UpdateRemoteDirectory();
            }
        }

        private void Btn_remote_refresh_Click(object sender, EventArgs e)
        {
            Library_Load(null, null);
        }

        private void Btn_sync_Click(object sender, EventArgs e)
        {
            List<LibraryItem> itemToSync = new List<LibraryItem>();
            foreach (LibraryItem libraryItem in localLib)
            {
                var item = remoteLib.SingleOrDefault(x => x.itm.TitleId == libraryItem.itm.TitleId && !x.itm.IsDLC);
                if (item == null)
                {
                    itemToSync.Add(libraryItem);
                }
            }

            HandleFiles(itemToSync);
        }

        private void Btn_sync_selected_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;
            LibraryItem libItem = (listView1.SelectedItems[0].Tag as LibraryItem);
            HandleFiles(new List<LibraryItem>(new[] { libItem }));
        }

        private void HandleFiles(List<LibraryItem> itemToSync)
        {
            if (itemToSync.Count == 0)
            {
                MessageBox.Show("Nothing to sync.", "Sync", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }

            string msg = "The following game & dlc will sync. Continue?\n";
            foreach (LibraryItem libraryItem in itemToSync)
            {
                msg += $"({libraryItem.itm.Region}) {libraryItem.itm.TitleName}\n";
            }
            DialogResult result = MessageBox.Show(msg, "Sync", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                foreach (LibraryItem libraryItem in itemToSync)
                {
                    TransferFile(libraryItem);
                }
                UpdateRemoteDirectory();
            }

        }
        private void TransferFile(LibraryItem from)
        {
            string appDir = Path.Combine(comboBox1.Text, "app");
            string dlcDir = Path.Combine(comboBox1.Text, "addcont");
            string patchDir = Path.Combine(comboBox1.Text, "patch");
            LibraryItem libraryItem = from;
            string gameAppDir = Path.Combine(appDir, libraryItem.itm.TitleId);
            string gameDlcDir = Path.Combine(dlcDir, libraryItem.itm.TitleId);
            string gamePatchDir = Path.Combine(patchDir, libraryItem.itm.TitleId);
            try
            {
                FileSystem.CopyDirectory(libraryItem.path, gameAppDir, UIOption.AllDialogs);
                if (!string.IsNullOrEmpty(libraryItem.dlcPath))
                    FileSystem.CopyDirectory(libraryItem.dlcPath, gameDlcDir, UIOption.AllDialogs);
                if (!string.IsNullOrEmpty(libraryItem.patchPath))
                    FileSystem.CopyDirectory(libraryItem.patchPath, gamePatchDir, UIOption.AllDialogs);
            }
            catch (Exception exception)
            {
                if (Directory.Exists(gameAppDir))
                    FileSystem.DeleteDirectory(gameAppDir, UIOption.AllDialogs, RecycleOption.DeletePermanently);
                if (Directory.Exists(gameDlcDir))
                    FileSystem.DeleteDirectory(gameDlcDir, UIOption.AllDialogs, RecycleOption.DeletePermanently);
                if (Directory.Exists(gamePatchDir))
                    FileSystem.DeleteDirectory(gamePatchDir, UIOption.AllDialogs, RecycleOption.DeletePermanently);
                MessageBox.Show(exception.Message, "CopyFile", MessageBoxButtons.OK, MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
            }
        }
    }

    class LibraryItem
    {
        public Item itm;
        public bool isPkg = false;
        public string path;
        public string dlcPath;
        public string patchPath;
    }
}
