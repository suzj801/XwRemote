namespace XwRemote
{
    partial class ServerManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerManager));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.treeServers = new System.Windows.Forms.TreeView();
            this.tabStrip1 = new Messir.Windows.Forms.TabStrip();
            this.FilterGrouped = new Messir.Windows.Forms.TabStripButton();
            this.FilterOrdered = new Messir.Windows.Forms.TabStripButton();
            this.FilterFavorites = new Messir.Windows.Forms.TabStripButton();
            this.contextGroup = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImportServer = new System.Windows.Forms.ToolStripMenuItem();
            this.ConnectBtn = new System.Windows.Forms.Button();
            this.NewFTP = new System.Windows.Forms.Button();
            this.NewRDP = new System.Windows.Forms.Button();
            this.NewVNC = new System.Windows.Forms.Button();
            this.newSSH = new System.Windows.Forms.Button();
            this.EditServer = new System.Windows.Forms.Button();
            this.DeleteServer = new System.Windows.Forms.Button();
            this.contextServer = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToFavoritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.makeCopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyAsRDP = new System.Windows.Forms.ToolStripMenuItem();
            this.copyAsSSH = new System.Windows.Forms.ToolStripMenuItem();
            this.copyAsFTP = new System.Windows.Forms.ToolStripMenuItem();
            this.copyAsSFTP = new System.Windows.Forms.ToolStripMenuItem();
            this.copyAsAWSS3 = new System.Windows.Forms.ToolStripMenuItem();
            this.copyAsAzureFile = new System.Windows.Forms.ToolStripMenuItem();
            this.copyAsVNC = new System.Windows.Forms.ToolStripMenuItem();
            this.copyAsIE = new System.Windows.Forms.ToolStripMenuItem();
            this.ExportServer = new System.Windows.Forms.ToolStripMenuItem();
            this.newIE = new System.Windows.Forms.Button();
            this.dialogHeader1 = new XwMaxLib.UI.DialogHeader();
            this.newSQL = new System.Windows.Forms.Button();
            this.NewSFTP = new System.Windows.Forms.Button();
            this.NewS3 = new System.Windows.Forms.Button();
            this.NewAzureFile = new System.Windows.Forms.Button();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.tabStrip1.SuspendLayout();
            this.contextGroup.SuspendLayout();
            this.contextServer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            resources.ApplyResources(this.toolStripContainer1, "toolStripContainer1");
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            resources.ApplyResources(this.toolStripContainer1.BottomToolStripPanel, "toolStripContainer1.BottomToolStripPanel");
            // 
            // toolStripContainer1.ContentPanel
            // 
            resources.ApplyResources(this.toolStripContainer1.ContentPanel, "toolStripContainer1.ContentPanel");
            this.toolStripContainer1.ContentPanel.Controls.Add(this.treeServers);
            // 
            // toolStripContainer1.LeftToolStripPanel
            // 
            resources.ApplyResources(this.toolStripContainer1.LeftToolStripPanel, "toolStripContainer1.LeftToolStripPanel");
            this.toolStripContainer1.Name = "toolStripContainer1";
            // 
            // toolStripContainer1.RightToolStripPanel
            // 
            resources.ApplyResources(this.toolStripContainer1.RightToolStripPanel, "toolStripContainer1.RightToolStripPanel");
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            resources.ApplyResources(this.toolStripContainer1.TopToolStripPanel, "toolStripContainer1.TopToolStripPanel");
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.tabStrip1);
            this.toolStripContainer1.TopToolStripPanel.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            // 
            // treeServers
            // 
            resources.ApplyResources(this.treeServers, "treeServers");
            this.treeServers.AllowDrop = true;
            this.treeServers.HideSelection = false;
            this.treeServers.LineColor = System.Drawing.Color.SkyBlue;
            this.treeServers.Name = "treeServers";
            this.treeServers.ShowNodeToolTips = true;
            this.treeServers.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.treeServers_AfterLabelEdit);
            this.treeServers.AfterCollapse += new System.Windows.Forms.TreeViewEventHandler(this.treeServers_AfterCollapse);
            this.treeServers.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.treeServers_AfterExpand);
            this.treeServers.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeServers_ItemDrag);
            this.treeServers.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeServers_AfterSelect);
            this.treeServers.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeServers_DragDrop);
            this.treeServers.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeServers_DragEnter);
            this.treeServers.DragOver += new System.Windows.Forms.DragEventHandler(this.treeServers_DragOver);
            this.treeServers.DragLeave += new System.EventHandler(this.treeServers_DragLeave);
            this.treeServers.DoubleClick += new System.EventHandler(this.treeServers_DoubleClick);
            this.treeServers.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeServers_MouseDown);
            this.treeServers.MouseUp += new System.Windows.Forms.MouseEventHandler(this.treeServers_MouseUp);
            // 
            // tabStrip1
            // 
            resources.ApplyResources(this.tabStrip1, "tabStrip1");
            this.tabStrip1.FlipButtons = false;
            this.tabStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.tabStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tabStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FilterGrouped,
            this.FilterOrdered,
            this.FilterFavorites});
            this.tabStrip1.Name = "tabStrip1";
            this.tabStrip1.RenderStyle = System.Windows.Forms.ToolStripRenderMode.System;
            this.tabStrip1.SelectedTab = this.FilterFavorites;
            this.tabStrip1.UseVisualStyles = false;
            // 
            // FilterGrouped
            // 
            resources.ApplyResources(this.FilterGrouped, "FilterGrouped");
            this.FilterGrouped.AutoToolTip = false;
            this.FilterGrouped.HotTextColor = System.Drawing.SystemColors.ControlText;
            this.FilterGrouped.Image = global::XwRemote.Properties.Resources.group;
            this.FilterGrouped.IsSelected = false;
            this.FilterGrouped.Margin = new System.Windows.Forms.Padding(0);
            this.FilterGrouped.Name = "FilterGrouped";
            this.FilterGrouped.Padding = new System.Windows.Forms.Padding(0);
            this.FilterGrouped.SelectedFont = new System.Drawing.Font("Segoe UI", 9F);
            this.FilterGrouped.SelectedTextColor = System.Drawing.SystemColors.ControlText;
            this.FilterGrouped.Click += new System.EventHandler(this.FilterGrouped_Click);
            // 
            // FilterOrdered
            // 
            resources.ApplyResources(this.FilterOrdered, "FilterOrdered");
            this.FilterOrdered.AutoToolTip = false;
            this.FilterOrdered.HotTextColor = System.Drawing.SystemColors.ControlText;
            this.FilterOrdered.Image = global::XwRemote.Properties.Resources.nogroup;
            this.FilterOrdered.IsSelected = false;
            this.FilterOrdered.Margin = new System.Windows.Forms.Padding(0);
            this.FilterOrdered.Name = "FilterOrdered";
            this.FilterOrdered.Padding = new System.Windows.Forms.Padding(0);
            this.FilterOrdered.SelectedFont = new System.Drawing.Font("Segoe UI", 9F);
            this.FilterOrdered.SelectedTextColor = System.Drawing.SystemColors.ControlText;
            this.FilterOrdered.Click += new System.EventHandler(this.FilterOrdered_Click);
            // 
            // FilterFavorites
            // 
            resources.ApplyResources(this.FilterFavorites, "FilterFavorites");
            this.FilterFavorites.AutoToolTip = false;
            this.FilterFavorites.Checked = true;
            this.FilterFavorites.HotTextColor = System.Drawing.SystemColors.ControlText;
            this.FilterFavorites.Image = global::XwRemote.Properties.Resources.favs;
            this.FilterFavorites.IsSelected = true;
            this.FilterFavorites.Margin = new System.Windows.Forms.Padding(0);
            this.FilterFavorites.Name = "FilterFavorites";
            this.FilterFavorites.Padding = new System.Windows.Forms.Padding(0);
            this.FilterFavorites.SelectedFont = new System.Drawing.Font("Segoe UI", 9F);
            this.FilterFavorites.SelectedTextColor = System.Drawing.SystemColors.ControlText;
            this.FilterFavorites.Click += new System.EventHandler(this.FilterFavorites_Click);
            // 
            // contextGroup
            // 
            resources.ApplyResources(this.contextGroup, "contextGroup");
            this.contextGroup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addGroupToolStripMenuItem,
            this.renameGroupToolStripMenuItem,
            this.deleteGroupToolStripMenuItem,
            this.ImportServer});
            this.contextGroup.Name = "contextMenuStrip1";
            // 
            // addGroupToolStripMenuItem
            // 
            resources.ApplyResources(this.addGroupToolStripMenuItem, "addGroupToolStripMenuItem");
            this.addGroupToolStripMenuItem.Image = global::XwRemote.Properties.Resources.folder;
            this.addGroupToolStripMenuItem.Name = "addGroupToolStripMenuItem";
            this.addGroupToolStripMenuItem.Click += new System.EventHandler(this.AddGroup_Click);
            // 
            // renameGroupToolStripMenuItem
            // 
            resources.ApplyResources(this.renameGroupToolStripMenuItem, "renameGroupToolStripMenuItem");
            this.renameGroupToolStripMenuItem.Image = global::XwRemote.Properties.Resources.pencil;
            this.renameGroupToolStripMenuItem.Name = "renameGroupToolStripMenuItem";
            this.renameGroupToolStripMenuItem.Click += new System.EventHandler(this.RenameGroup_Click);
            // 
            // deleteGroupToolStripMenuItem
            // 
            resources.ApplyResources(this.deleteGroupToolStripMenuItem, "deleteGroupToolStripMenuItem");
            this.deleteGroupToolStripMenuItem.Image = global::XwRemote.Properties.Resources.delete;
            this.deleteGroupToolStripMenuItem.Name = "deleteGroupToolStripMenuItem";
            this.deleteGroupToolStripMenuItem.Click += new System.EventHandler(this.DeleteGroup_Click);
            // 
            // ImportServer
            // 
            resources.ApplyResources(this.ImportServer, "ImportServer");
            this.ImportServer.Image = global::XwRemote.Properties.Resources.inout;
            this.ImportServer.Name = "ImportServer";
            this.ImportServer.Click += new System.EventHandler(this.ImportServer_Click);
            // 
            // ConnectBtn
            // 
            resources.ApplyResources(this.ConnectBtn, "ConnectBtn");
            this.ConnectBtn.Image = global::XwRemote.Properties.Resources.connect;
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.UseVisualStyleBackColor = true;
            this.ConnectBtn.Click += new System.EventHandler(this.Connect_Click);
            // 
            // NewFTP
            // 
            resources.ApplyResources(this.NewFTP, "NewFTP");
            this.NewFTP.Image = global::XwRemote.Properties.Resources.ftp;
            this.NewFTP.Name = "NewFTP";
            this.NewFTP.UseVisualStyleBackColor = true;
            this.NewFTP.Click += new System.EventHandler(this.NewFTP_Click);
            // 
            // NewRDP
            // 
            resources.ApplyResources(this.NewRDP, "NewRDP");
            this.NewRDP.Image = global::XwRemote.Properties.Resources.rdp;
            this.NewRDP.Name = "NewRDP";
            this.NewRDP.UseVisualStyleBackColor = true;
            this.NewRDP.Click += new System.EventHandler(this.NewRDP_Click);
            // 
            // NewVNC
            // 
            resources.ApplyResources(this.NewVNC, "NewVNC");
            this.NewVNC.Image = global::XwRemote.Properties.Resources.vnc;
            this.NewVNC.Name = "NewVNC";
            this.NewVNC.UseVisualStyleBackColor = true;
            this.NewVNC.Click += new System.EventHandler(this.NewVNC_Click);
            // 
            // newSSH
            // 
            resources.ApplyResources(this.newSSH, "newSSH");
            this.newSSH.Image = global::XwRemote.Properties.Resources.ssh;
            this.newSSH.Name = "newSSH";
            this.newSSH.UseVisualStyleBackColor = true;
            this.newSSH.Click += new System.EventHandler(this.newSSH_Click);
            // 
            // EditServer
            // 
            resources.ApplyResources(this.EditServer, "EditServer");
            this.EditServer.Image = global::XwRemote.Properties.Resources.pencil;
            this.EditServer.Name = "EditServer";
            this.EditServer.UseVisualStyleBackColor = true;
            this.EditServer.Click += new System.EventHandler(this.EditServer_Click);
            // 
            // DeleteServer
            // 
            resources.ApplyResources(this.DeleteServer, "DeleteServer");
            this.DeleteServer.Image = global::XwRemote.Properties.Resources.delete;
            this.DeleteServer.Name = "DeleteServer";
            this.DeleteServer.UseVisualStyleBackColor = true;
            this.DeleteServer.Click += new System.EventHandler(this.DeleteServer_Click);
            // 
            // contextServer
            // 
            resources.ApplyResources(this.contextServer, "contextServer");
            this.contextServer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editServerToolStripMenuItem,
            this.deleteServerToolStripMenuItem,
            this.addToFavoritesToolStripMenuItem,
            this.toolStripSeparator3,
            this.makeCopyToolStripMenuItem,
            this.ExportServer});
            this.contextServer.Name = "contextServer";
            // 
            // editServerToolStripMenuItem
            // 
            resources.ApplyResources(this.editServerToolStripMenuItem, "editServerToolStripMenuItem");
            this.editServerToolStripMenuItem.Image = global::XwRemote.Properties.Resources.pencil;
            this.editServerToolStripMenuItem.Name = "editServerToolStripMenuItem";
            this.editServerToolStripMenuItem.Click += new System.EventHandler(this.EditServer_Click);
            // 
            // deleteServerToolStripMenuItem
            // 
            resources.ApplyResources(this.deleteServerToolStripMenuItem, "deleteServerToolStripMenuItem");
            this.deleteServerToolStripMenuItem.Image = global::XwRemote.Properties.Resources.delete;
            this.deleteServerToolStripMenuItem.Name = "deleteServerToolStripMenuItem";
            this.deleteServerToolStripMenuItem.Click += new System.EventHandler(this.DeleteServer_Click);
            // 
            // addToFavoritesToolStripMenuItem
            // 
            resources.ApplyResources(this.addToFavoritesToolStripMenuItem, "addToFavoritesToolStripMenuItem");
            this.addToFavoritesToolStripMenuItem.Image = global::XwRemote.Properties.Resources.favs;
            this.addToFavoritesToolStripMenuItem.Name = "addToFavoritesToolStripMenuItem";
            this.addToFavoritesToolStripMenuItem.Click += new System.EventHandler(this.addToFavoritesToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            // 
            // makeCopyToolStripMenuItem
            // 
            resources.ApplyResources(this.makeCopyToolStripMenuItem, "makeCopyToolStripMenuItem");
            this.makeCopyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyAsRDP,
            this.copyAsSSH,
            this.copyAsFTP,
            this.copyAsSFTP,
            this.copyAsAWSS3,
            this.copyAsAzureFile,
            this.copyAsVNC,
            this.copyAsIE});
            this.makeCopyToolStripMenuItem.Image = global::XwRemote.Properties.Resources.copy;
            this.makeCopyToolStripMenuItem.Name = "makeCopyToolStripMenuItem";
            // 
            // copyAsRDP
            // 
            resources.ApplyResources(this.copyAsRDP, "copyAsRDP");
            this.copyAsRDP.Image = global::XwRemote.Properties.Resources.rdp;
            this.copyAsRDP.Name = "copyAsRDP";
            this.copyAsRDP.Click += new System.EventHandler(this.copyAsRDP_Click);
            // 
            // copyAsSSH
            // 
            resources.ApplyResources(this.copyAsSSH, "copyAsSSH");
            this.copyAsSSH.Image = global::XwRemote.Properties.Resources.ssh;
            this.copyAsSSH.Name = "copyAsSSH";
            this.copyAsSSH.Click += new System.EventHandler(this.copyAsSSH_Click);
            // 
            // copyAsFTP
            // 
            resources.ApplyResources(this.copyAsFTP, "copyAsFTP");
            this.copyAsFTP.Image = global::XwRemote.Properties.Resources.ftp;
            this.copyAsFTP.Name = "copyAsFTP";
            this.copyAsFTP.Click += new System.EventHandler(this.copyAsFTP_Click);
            // 
            // copyAsSFTP
            // 
            resources.ApplyResources(this.copyAsSFTP, "copyAsSFTP");
            this.copyAsSFTP.Image = global::XwRemote.Properties.Resources.sftp;
            this.copyAsSFTP.Name = "copyAsSFTP";
            this.copyAsSFTP.Click += new System.EventHandler(this.copyAsSFTP_Click);
            // 
            // copyAsAWSS3
            // 
            resources.ApplyResources(this.copyAsAWSS3, "copyAsAWSS3");
            this.copyAsAWSS3.Image = global::XwRemote.Properties.Resources.s3;
            this.copyAsAWSS3.Name = "copyAsAWSS3";
            this.copyAsAWSS3.Click += new System.EventHandler(this.copyAsAWSS3_Click);
            // 
            // copyAsAzureFile
            // 
            resources.ApplyResources(this.copyAsAzureFile, "copyAsAzureFile");
            this.copyAsAzureFile.Image = global::XwRemote.Properties.Resources.azure;
            this.copyAsAzureFile.Name = "copyAsAzureFile";
            this.copyAsAzureFile.Click += new System.EventHandler(this.copyAsAzureFile_Click);
            // 
            // copyAsVNC
            // 
            resources.ApplyResources(this.copyAsVNC, "copyAsVNC");
            this.copyAsVNC.Image = global::XwRemote.Properties.Resources.vnc;
            this.copyAsVNC.Name = "copyAsVNC";
            this.copyAsVNC.Click += new System.EventHandler(this.copyAsVNC_Click);
            // 
            // copyAsIE
            // 
            resources.ApplyResources(this.copyAsIE, "copyAsIE");
            this.copyAsIE.Image = global::XwRemote.Properties.Resources.IE;
            this.copyAsIE.Name = "copyAsIE";
            this.copyAsIE.Click += new System.EventHandler(this.copyAsIE_Click);
            // 
            // ExportServer
            // 
            resources.ApplyResources(this.ExportServer, "ExportServer");
            this.ExportServer.Image = global::XwRemote.Properties.Resources.inout;
            this.ExportServer.Name = "ExportServer";
            this.ExportServer.Click += new System.EventHandler(this.ExportServer_Click);
            // 
            // newIE
            // 
            resources.ApplyResources(this.newIE, "newIE");
            this.newIE.Image = global::XwRemote.Properties.Resources.IE;
            this.newIE.Name = "newIE";
            this.newIE.UseVisualStyleBackColor = true;
            this.newIE.Click += new System.EventHandler(this.newIE_Click);
            // 
            // dialogHeader1
            // 
            resources.ApplyResources(this.dialogHeader1, "dialogHeader1");
            this.dialogHeader1.Gradient1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.dialogHeader1.Gradient2 = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.dialogHeader1.Gradient3 = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.dialogHeader1.Gradient4 = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.dialogHeader1.HeaderDescription = "这里可以管理所有的服务器";
            this.dialogHeader1.HeaderImage = global::XwRemote.Properties.Resources.xwremote1;
            this.dialogHeader1.HeaderTitle = "服务器列表";
            this.dialogHeader1.Name = "dialogHeader1";
            // 
            // newSQL
            // 
            resources.ApplyResources(this.newSQL, "newSQL");
            this.newSQL.Image = global::XwRemote.Properties.Resources.database;
            this.newSQL.Name = "newSQL";
            this.newSQL.UseVisualStyleBackColor = true;
            this.newSQL.Click += new System.EventHandler(this.newSQL_Click);
            // 
            // NewSFTP
            // 
            resources.ApplyResources(this.NewSFTP, "NewSFTP");
            this.NewSFTP.Image = global::XwRemote.Properties.Resources.sftp;
            this.NewSFTP.Name = "NewSFTP";
            this.NewSFTP.UseVisualStyleBackColor = true;
            this.NewSFTP.Click += new System.EventHandler(this.NewSFTP_Click);
            // 
            // NewS3
            // 
            resources.ApplyResources(this.NewS3, "NewS3");
            this.NewS3.Image = global::XwRemote.Properties.Resources.s3;
            this.NewS3.Name = "NewS3";
            this.NewS3.UseVisualStyleBackColor = true;
            this.NewS3.Click += new System.EventHandler(this.NewS3_Click);
            // 
            // NewAzureFile
            // 
            resources.ApplyResources(this.NewAzureFile, "NewAzureFile");
            this.NewAzureFile.Image = global::XwRemote.Properties.Resources.azure;
            this.NewAzureFile.Name = "NewAzureFile";
            this.NewAzureFile.UseVisualStyleBackColor = true;
            this.NewAzureFile.Click += new System.EventHandler(this.NewAzureFile_Click);
            // 
            // textSearch
            // 
            resources.ApplyResources(this.textSearch, "textSearch");
            this.textSearch.Name = "textSearch";
            this.textSearch.TextChanged += new System.EventHandler(this.textSearch_TextChanged);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::XwRemote.Properties.Resources.magnifier;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // ServerManager
            // 
            this.AcceptButton = this.ConnectBtn;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.NewAzureFile);
            this.Controls.Add(this.NewS3);
            this.Controls.Add(this.NewSFTP);
            this.Controls.Add(this.newSQL);
            this.Controls.Add(this.dialogHeader1);
            this.Controls.Add(this.NewRDP);
            this.Controls.Add(this.newSSH);
            this.Controls.Add(this.NewVNC);
            this.Controls.Add(this.NewFTP);
            this.Controls.Add(this.newIE);
            this.Controls.Add(this.DeleteServer);
            this.Controls.Add(this.EditServer);
            this.Controls.Add(this.ConnectBtn);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "ServerManager";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Activated += new System.EventHandler(this.ServerManager_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ServerManager_FormClosing);
            this.Load += new System.EventHandler(this.OnLoad);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.tabStrip1.ResumeLayout(false);
            this.tabStrip1.PerformLayout();
            this.contextGroup.ResumeLayout(false);
            this.contextServer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.Button ConnectBtn;
        private System.Windows.Forms.Button NewFTP;
        private System.Windows.Forms.Button NewRDP;
        private System.Windows.Forms.Button NewVNC;
        private System.Windows.Forms.Button newSSH;
        private System.Windows.Forms.Button EditServer;
        private System.Windows.Forms.Button DeleteServer;
        private Messir.Windows.Forms.TabStrip tabStrip1;
        private Messir.Windows.Forms.TabStripButton FilterGrouped;
        private Messir.Windows.Forms.TabStripButton FilterOrdered;
        private Messir.Windows.Forms.TabStripButton FilterFavorites;
        private System.Windows.Forms.TreeView treeServers;
        private XwMaxLib.UI.DialogHeader dialogHeader1;
        private System.Windows.Forms.ContextMenuStrip contextGroup;
        private System.Windows.Forms.ToolStripMenuItem addGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteGroupToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextServer;
        private System.Windows.Forms.ToolStripMenuItem deleteServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToFavoritesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeCopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Button newIE;
        private System.Windows.Forms.ToolStripMenuItem copyAsFTP;
        private System.Windows.Forms.ToolStripMenuItem copyAsRDP;
        private System.Windows.Forms.ToolStripMenuItem copyAsVNC;
        private System.Windows.Forms.ToolStripMenuItem copyAsSSH;
        private System.Windows.Forms.ToolStripMenuItem copyAsIE;
        private System.Windows.Forms.Button newSQL;
        private System.Windows.Forms.Button NewSFTP;
        private System.Windows.Forms.Button NewS3;
        private System.Windows.Forms.Button NewAzureFile;
        private System.Windows.Forms.ToolStripMenuItem copyAsSFTP;
        private System.Windows.Forms.ToolStripMenuItem copyAsAWSS3;
        private System.Windows.Forms.ToolStripMenuItem copyAsAzureFile;
        private System.Windows.Forms.ToolStripMenuItem ImportServer;
        private System.Windows.Forms.ToolStripMenuItem ExportServer;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}