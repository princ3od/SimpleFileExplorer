namespace GUI2_FileExplorer
{
    partial class frmMain
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.largeIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smallIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeviewMain = new System.Windows.Forms.TreeView();
            this.lbEmpty = new System.Windows.Forms.Label();
            this.listviewMain = new System.Windows.Forms.ListView();
            this.clmName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmCreated = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmModify = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tstripMain = new System.Windows.Forms.ToolStrip();
            this.tstripbtnUp = new System.Windows.Forms.ToolStripButton();
            this.tstripbtnRefresh = new System.Windows.Forms.ToolStripButton();
            this.tstripbtnCopy = new System.Windows.Forms.ToolStripButton();
            this.tstripbtnCut = new System.Windows.Forms.ToolStripButton();
            this.tstripbtnPaste = new System.Windows.Forms.ToolStripButton();
            this.tstripbtnDelete = new System.Windows.Forms.ToolStripButton();
            this.tstripbtnViews = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolstrLargeIcon = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstrSmallIcon = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstrList = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.txtAdresss = new System.Windows.Forms.TextBox();
            this.menuMain.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tstripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuMain.Size = new System.Drawing.Size(984, 25);
            this.menuMain.TabIndex = 0;
            this.menuMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renameToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.renameToolStripMenuItem.Text = "Rename";
            this.renameToolStripMenuItem.Click += new System.EventHandler(this.renameToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(135, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 19);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // viewsToolStripMenuItem
            // 
            this.viewsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.largeIconToolStripMenuItem,
            this.smallIconToolStripMenuItem,
            this.listsToolStripMenuItem,
            this.detailsToolStripMenuItem});
            this.viewsToolStripMenuItem.Name = "viewsToolStripMenuItem";
            this.viewsToolStripMenuItem.Size = new System.Drawing.Size(49, 19);
            this.viewsToolStripMenuItem.Text = "Views";
            // 
            // largeIconToolStripMenuItem
            // 
            this.largeIconToolStripMenuItem.Name = "largeIconToolStripMenuItem";
            this.largeIconToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.largeIconToolStripMenuItem.Text = "Large Icon";
            this.largeIconToolStripMenuItem.Click += new System.EventHandler(this.ChooseViewsType);
            // 
            // smallIconToolStripMenuItem
            // 
            this.smallIconToolStripMenuItem.Name = "smallIconToolStripMenuItem";
            this.smallIconToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.smallIconToolStripMenuItem.Text = "Small Icon";
            this.smallIconToolStripMenuItem.Click += new System.EventHandler(this.ChooseViewsType);
            // 
            // listsToolStripMenuItem
            // 
            this.listsToolStripMenuItem.Name = "listsToolStripMenuItem";
            this.listsToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.listsToolStripMenuItem.Text = "List";
            this.listsToolStripMenuItem.Click += new System.EventHandler(this.ChooseViewsType);
            // 
            // detailsToolStripMenuItem
            // 
            this.detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            this.detailsToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.detailsToolStripMenuItem.Text = "Details";
            this.detailsToolStripMenuItem.Click += new System.EventHandler(this.ChooseViewsType);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 19);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Location = new System.Drawing.Point(13, 85);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(962, 468);
            this.panel1.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeviewMain);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lbEmpty);
            this.splitContainer1.Panel2.Controls.Add(this.listviewMain);
            this.splitContainer1.Size = new System.Drawing.Size(962, 468);
            this.splitContainer1.SplitterDistance = 280;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // treeviewMain
            // 
            this.treeviewMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeviewMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeviewMain.LabelEdit = true;
            this.treeviewMain.Location = new System.Drawing.Point(0, 0);
            this.treeviewMain.Margin = new System.Windows.Forms.Padding(4);
            this.treeviewMain.Name = "treeviewMain";
            this.treeviewMain.Size = new System.Drawing.Size(279, 468);
            this.treeviewMain.TabIndex = 0;
            this.treeviewMain.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.treeviewMain_AfterLabelEdit);
            // 
            // lbEmpty
            // 
            this.lbEmpty.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbEmpty.AutoSize = true;
            this.lbEmpty.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmpty.Location = new System.Drawing.Point(277, 40);
            this.lbEmpty.Name = "lbEmpty";
            this.lbEmpty.Size = new System.Drawing.Size(136, 20);
            this.lbEmpty.TabIndex = 1;
            this.lbEmpty.Text = "This folder is empty.";
            this.lbEmpty.Visible = false;
            // 
            // listviewMain
            // 
            this.listviewMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listviewMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listviewMain.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmName,
            this.clmType,
            this.clmSize,
            this.clmCreated,
            this.clmModify});
            this.listviewMain.HideSelection = false;
            this.listviewMain.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.listviewMain.LabelEdit = true;
            this.listviewMain.LargeImageList = this.imageList2;
            this.listviewMain.Location = new System.Drawing.Point(0, 0);
            this.listviewMain.Margin = new System.Windows.Forms.Padding(4);
            this.listviewMain.Name = "listviewMain";
            this.listviewMain.Size = new System.Drawing.Size(678, 468);
            this.listviewMain.SmallImageList = this.imageList1;
            this.listviewMain.TabIndex = 0;
            this.listviewMain.UseCompatibleStateImageBehavior = false;
            this.listviewMain.View = System.Windows.Forms.View.Details;
            this.listviewMain.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.listviewMain_AfterLabelEdit);
            // 
            // clmName
            // 
            this.clmName.Text = "Name";
            this.clmName.Width = 272;
            // 
            // clmType
            // 
            this.clmType.Text = "Type";
            this.clmType.Width = 68;
            // 
            // clmSize
            // 
            this.clmSize.Text = "Size";
            this.clmSize.Width = 70;
            // 
            // clmCreated
            // 
            this.clmCreated.Text = "Created Date";
            this.clmCreated.Width = 124;
            // 
            // clmModify
            // 
            this.clmModify.Text = "Modified Date";
            this.clmModify.Width = 126;
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "computer.png");
            this.imageList2.Images.SetKeyName(1, "folder.png");
            this.imageList2.Images.SetKeyName(2, "hard-disk.png");
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "computer.png");
            this.imageList1.Images.SetKeyName(1, "folder.png");
            this.imageList1.Images.SetKeyName(2, "hard-disk.png");
            this.imageList1.Images.SetKeyName(3, "checked.png");
            // 
            // tstripMain
            // 
            this.tstripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstripbtnUp,
            this.tstripbtnRefresh,
            this.tstripbtnCopy,
            this.tstripbtnCut,
            this.tstripbtnPaste,
            this.tstripbtnDelete,
            this.tstripbtnViews});
            this.tstripMain.Location = new System.Drawing.Point(0, 25);
            this.tstripMain.Name = "tstripMain";
            this.tstripMain.Size = new System.Drawing.Size(984, 25);
            this.tstripMain.TabIndex = 2;
            this.tstripMain.Text = "toolStrip1";
            // 
            // tstripbtnUp
            // 
            this.tstripbtnUp.Image = ((System.Drawing.Image)(resources.GetObject("tstripbtnUp.Image")));
            this.tstripbtnUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstripbtnUp.Name = "tstripbtnUp";
            this.tstripbtnUp.Size = new System.Drawing.Size(42, 22);
            this.tstripbtnUp.Text = "Up";
            this.tstripbtnUp.Click += new System.EventHandler(this.tstripbtnUp_Click);
            // 
            // tstripbtnRefresh
            // 
            this.tstripbtnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tstripbtnRefresh.Image")));
            this.tstripbtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstripbtnRefresh.Name = "tstripbtnRefresh";
            this.tstripbtnRefresh.Size = new System.Drawing.Size(66, 22);
            this.tstripbtnRefresh.Text = "Refresh";
            this.tstripbtnRefresh.Click += new System.EventHandler(this.tstripbtnRefresh_Click);
            // 
            // tstripbtnCopy
            // 
            this.tstripbtnCopy.Image = ((System.Drawing.Image)(resources.GetObject("tstripbtnCopy.Image")));
            this.tstripbtnCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstripbtnCopy.Name = "tstripbtnCopy";
            this.tstripbtnCopy.Size = new System.Drawing.Size(55, 22);
            this.tstripbtnCopy.Text = "Copy";
            this.tstripbtnCopy.Click += new System.EventHandler(this.tstripbtnCopy_Click);
            // 
            // tstripbtnCut
            // 
            this.tstripbtnCut.Image = ((System.Drawing.Image)(resources.GetObject("tstripbtnCut.Image")));
            this.tstripbtnCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstripbtnCut.Name = "tstripbtnCut";
            this.tstripbtnCut.Size = new System.Drawing.Size(46, 22);
            this.tstripbtnCut.Text = "Cut";
            this.tstripbtnCut.Click += new System.EventHandler(this.tstripbtnCut_Click);
            // 
            // tstripbtnPaste
            // 
            this.tstripbtnPaste.Image = ((System.Drawing.Image)(resources.GetObject("tstripbtnPaste.Image")));
            this.tstripbtnPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstripbtnPaste.Name = "tstripbtnPaste";
            this.tstripbtnPaste.Size = new System.Drawing.Size(55, 22);
            this.tstripbtnPaste.Text = "Paste";
            this.tstripbtnPaste.Click += new System.EventHandler(this.tstripbtnPaste_Click);
            // 
            // tstripbtnDelete
            // 
            this.tstripbtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("tstripbtnDelete.Image")));
            this.tstripbtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstripbtnDelete.Name = "tstripbtnDelete";
            this.tstripbtnDelete.Size = new System.Drawing.Size(60, 22);
            this.tstripbtnDelete.Text = "Delete";
            this.tstripbtnDelete.Click += new System.EventHandler(this.tstripbtnDelete_Click);
            // 
            // tstripbtnViews
            // 
            this.tstripbtnViews.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstrLargeIcon,
            this.toolstrSmallIcon,
            this.toolstrList,
            this.toolStrDetails});
            this.tstripbtnViews.Image = ((System.Drawing.Image)(resources.GetObject("tstripbtnViews.Image")));
            this.tstripbtnViews.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstripbtnViews.Name = "tstripbtnViews";
            this.tstripbtnViews.Size = new System.Drawing.Size(66, 22);
            this.tstripbtnViews.Text = "Views";
            // 
            // toolstrLargeIcon
            // 
            this.toolstrLargeIcon.Name = "toolstrLargeIcon";
            this.toolstrLargeIcon.Size = new System.Drawing.Size(180, 22);
            this.toolstrLargeIcon.Text = "Large Icon";
            this.toolstrLargeIcon.Click += new System.EventHandler(this.ChooseViewsType);
            // 
            // toolstrSmallIcon
            // 
            this.toolstrSmallIcon.Name = "toolstrSmallIcon";
            this.toolstrSmallIcon.Size = new System.Drawing.Size(180, 22);
            this.toolstrSmallIcon.Text = "Small Icon";
            this.toolstrSmallIcon.Click += new System.EventHandler(this.ChooseViewsType);
            // 
            // toolstrList
            // 
            this.toolstrList.Name = "toolstrList";
            this.toolstrList.Size = new System.Drawing.Size(180, 22);
            this.toolstrList.Text = "List";
            this.toolstrList.Click += new System.EventHandler(this.ChooseViewsType);
            // 
            // toolStrDetails
            // 
            this.toolStrDetails.Name = "toolStrDetails";
            this.toolStrDetails.Size = new System.Drawing.Size(180, 22);
            this.toolStrDetails.Text = "Details";
            this.toolStrDetails.Click += new System.EventHandler(this.ChooseViewsType);
            // 
            // txtAdresss
            // 
            this.txtAdresss.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAdresss.Location = new System.Drawing.Point(12, 53);
            this.txtAdresss.Name = "txtAdresss";
            this.txtAdresss.Size = new System.Drawing.Size(965, 25);
            this.txtAdresss.TabIndex = 3;
            this.txtAdresss.TabStop = false;
            this.txtAdresss.Text = "Computer";
            this.txtAdresss.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAdresss_KeyDown);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.txtAdresss);
            this.Controls.Add(this.tstripMain);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuMain);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuMain;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Explorer";
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tstripMain.ResumeLayout(false);
            this.tstripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeviewMain;
        private System.Windows.Forms.ListView listviewMain;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem largeIconToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smallIconToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStrip tstripMain;
        private System.Windows.Forms.ToolStripButton tstripbtnUp;
        private System.Windows.Forms.ToolStripButton tstripbtnRefresh;
        private System.Windows.Forms.ToolStripButton tstripbtnCopy;
        private System.Windows.Forms.ToolStripButton tstripbtnCut;
        private System.Windows.Forms.ToolStripButton tstripbtnPaste;
        private System.Windows.Forms.ToolStripButton tstripbtnDelete;
        private System.Windows.Forms.ToolStripDropDownButton tstripbtnViews;
        private System.Windows.Forms.ToolStripMenuItem toolstrLargeIcon;
        private System.Windows.Forms.ToolStripMenuItem toolstrSmallIcon;
        private System.Windows.Forms.ToolStripMenuItem toolstrList;
        private System.Windows.Forms.ToolStripMenuItem toolStrDetails;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ColumnHeader clmName;
        private System.Windows.Forms.ColumnHeader clmSize;
        private System.Windows.Forms.ColumnHeader clmCreated;
        private System.Windows.Forms.ColumnHeader clmModify;
        private System.Windows.Forms.ColumnHeader clmType;
        private System.Windows.Forms.TextBox txtAdresss;
        private System.Windows.Forms.Label lbEmpty;
        private System.Windows.Forms.ImageList imageList2;
    }
}

