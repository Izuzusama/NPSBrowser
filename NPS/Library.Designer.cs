namespace NPS
{
    partial class Library
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Library));
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Testowy item",
            "test",
            "test2"}, "High-Definition-Ultra-HD-Wallpaper-96262544.jpg");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("test", "(none)");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "Testowy item",
            "test",
            "test2"}, "High-Definition-Ultra-HD-Wallpaper-96262544.jpg");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("test", "(none)");
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_sync_selected = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_sync = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_remoteList_refresh = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_remote_refresh = new System.Windows.Forms.Button();
            this.btn_remote_delete = new System.Windows.Forms.Button();
            this.btn_remote_opendir = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "High-Definition-Ultra-HD-Wallpaper-96262544.jpg");
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_sync_selected);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btn_sync);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(611, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(78, 653);
            this.panel2.TabIndex = 2;
            // 
            // btn_sync_selected
            // 
            this.btn_sync_selected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_sync_selected.Location = new System.Drawing.Point(2, 289);
            this.btn_sync_selected.Name = "btn_sync_selected";
            this.btn_sync_selected.Size = new System.Drawing.Size(75, 43);
            this.btn_sync_selected.TabIndex = 14;
            this.btn_sync_selected.Text = "Transfer >>>";
            this.btn_sync_selected.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_sync_selected.UseVisualStyleBackColor = true;
            this.btn_sync_selected.Click += new System.EventHandler(this.Btn_sync_selected_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Image = global::NPS.Properties.Resources.opened_folder;
            this.button1.Location = new System.Drawing.Point(2, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "Open directory";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_sync
            // 
            this.btn_sync.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_sync.Location = new System.Drawing.Point(2, 343);
            this.btn_sync.Name = "btn_sync";
            this.btn_sync.Size = new System.Drawing.Size(75, 43);
            this.btn_sync.TabIndex = 13;
            this.btn_sync.Text = "Transfer All >>>";
            this.btn_sync.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_sync.UseVisualStyleBackColor = true;
            this.btn_sync.Click += new System.EventHandler(this.Btn_sync_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Image = global::NPS.Properties.Resources.menu_reload;
            this.button4.Location = new System.Drawing.Point(2, 186);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 43);
            this.button4.TabIndex = 5;
            this.button4.Text = "Refresh";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Enabled = false;
            this.button3.Image = global::NPS.Properties.Resources.menu_unpack;
            this.button3.Location = new System.Drawing.Point(2, 116);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 43);
            this.button3.TabIndex = 4;
            this.button3.Text = "Unpack PKG";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Image = global::NPS.Properties.Resources.menu_cancel;
            this.button2.Location = new System.Drawing.Point(2, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 39);
            this.button2.TabIndex = 3;
            this.button2.Text = "Delete";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(611, 27);
            this.panel6.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.FullRowSelect = true;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3,
            listViewItem4});
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(0, 27);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(608, 626);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 600;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(689, 653);
            this.panel1.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_remoteList_refresh);
            this.panel4.Controls.Add(this.comboBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(761, 30);
            this.panel4.TabIndex = 13;
            // 
            // btn_remoteList_refresh
            // 
            this.btn_remoteList_refresh.Location = new System.Drawing.Point(193, 7);
            this.btn_remoteList_refresh.Name = "btn_remoteList_refresh";
            this.btn_remoteList_refresh.Size = new System.Drawing.Size(75, 20);
            this.btn_remoteList_refresh.TabIndex = 8;
            this.btn_remoteList_refresh.Text = "Refresh";
            this.btn_remoteList_refresh.UseVisualStyleBackColor = true;
            this.btn_remoteList_refresh.Click += new System.EventHandler(this.Btn_remoteList_refresh_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(186, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btn_remote_refresh);
            this.panel5.Controls.Add(this.btn_remote_delete);
            this.panel5.Controls.Add(this.btn_remote_opendir);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(659, 30);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(102, 623);
            this.panel5.TabIndex = 14;
            // 
            // btn_remote_refresh
            // 
            this.btn_remote_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_remote_refresh.Image = global::NPS.Properties.Resources.menu_reload;
            this.btn_remote_refresh.Location = new System.Drawing.Point(3, 166);
            this.btn_remote_refresh.Name = "btn_remote_refresh";
            this.btn_remote_refresh.Size = new System.Drawing.Size(75, 43);
            this.btn_remote_refresh.TabIndex = 12;
            this.btn_remote_refresh.Text = "Refresh";
            this.btn_remote_refresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_remote_refresh.UseVisualStyleBackColor = true;
            this.btn_remote_refresh.Click += new System.EventHandler(this.Btn_remote_refresh_Click);
            // 
            // btn_remote_delete
            // 
            this.btn_remote_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_remote_delete.Image = global::NPS.Properties.Resources.menu_cancel;
            this.btn_remote_delete.Location = new System.Drawing.Point(3, 51);
            this.btn_remote_delete.Name = "btn_remote_delete";
            this.btn_remote_delete.Size = new System.Drawing.Size(75, 39);
            this.btn_remote_delete.TabIndex = 10;
            this.btn_remote_delete.Text = "Delete";
            this.btn_remote_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_remote_delete.UseVisualStyleBackColor = true;
            this.btn_remote_delete.Click += new System.EventHandler(this.Btn_remote_delete_Click);
            // 
            // btn_remote_opendir
            // 
            this.btn_remote_opendir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_remote_opendir.Image = global::NPS.Properties.Resources.opened_folder;
            this.btn_remote_opendir.Location = new System.Drawing.Point(3, 3);
            this.btn_remote_opendir.Name = "btn_remote_opendir";
            this.btn_remote_opendir.Size = new System.Drawing.Size(73, 42);
            this.btn_remote_opendir.TabIndex = 9;
            this.btn_remote_opendir.Text = "Open directory";
            this.btn_remote_opendir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_remote_opendir.UseVisualStyleBackColor = true;
            this.btn_remote_opendir.Click += new System.EventHandler(this.Btn_remote_opendir_Click);
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.listView2.Dock = System.Windows.Forms.DockStyle.Left;
            this.listView2.FullRowSelect = true;
            this.listView2.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem5,
            listViewItem6});
            this.listView2.LargeImageList = this.imageList1;
            this.listView2.Location = new System.Drawing.Point(0, 30);
            this.listView2.MultiSelect = false;
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(653, 623);
            this.listView2.SmallImageList = this.imageList1;
            this.listView2.TabIndex = 6;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "";
            this.columnHeader2.Width = 600;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.listView2);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(707, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(761, 653);
            this.panel3.TabIndex = 15;
            // 
            // Library
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1480, 683);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Library";
            this.Text = "Library";
            this.Load += new System.EventHandler(this.Library_Load);
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_sync;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_remoteList_refresh;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_remote_refresh;
        private System.Windows.Forms.Button btn_remote_delete;
        private System.Windows.Forms.Button btn_remote_opendir;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_sync_selected;
    }
}