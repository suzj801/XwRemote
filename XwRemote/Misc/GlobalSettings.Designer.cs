namespace XwRemote.Settings
{
    partial class GlobalSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GlobalSettings));
            this.dialogHeader1 = new XwMaxLib.UI.DialogHeader();
            this.dividerPanel1 = new DividerPanel.DividerPanel();
            this.butCancel = new System.Windows.Forms.Button();
            this.butOK = new System.Windows.Forms.Button();
            this.faTabStrip1 = new FarsiLibrary.Win.FATabStrip();
            this.tabSecurity = new FarsiLibrary.Win.FATabStripItem();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textPasswordRepeat = new System.Windows.Forms.TextBox();
            this.butRemovePass = new System.Windows.Forms.Button();
            this.butSetPassword = new System.Windows.Forms.Button();
            this.textMasterPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabFTP = new FarsiLibrary.Win.FATabStripItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBrowseFolder = new System.Windows.Forms.Button();
            this.textFixedFolder = new System.Windows.Forms.TextBox();
            this.radioFixed = new System.Windows.Forms.RadioButton();
            this.radioLastUsed = new System.Windows.Forms.RadioButton();
            this.radioMyComputer = new System.Windows.Forms.RadioButton();
            this.radioDesktop = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabSSH = new FarsiLibrary.Win.FATabStripItem();
            this.checkBoxCorrectFocus = new System.Windows.Forms.CheckBox();
            this.sshFontSize = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tabInterface = new FarsiLibrary.Win.FATabStripItem();
            this.checkCloseToTray = new System.Windows.Forms.CheckBox();
            this.checkMinimizeToTray = new System.Windows.Forms.CheckBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.dividerPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.faTabStrip1)).BeginInit();
            this.faTabStrip1.SuspendLayout();
            this.tabSecurity.SuspendLayout();
            this.tabFTP.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabSSH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sshFontSize)).BeginInit();
            this.tabInterface.SuspendLayout();
            this.SuspendLayout();
            // 
            // dialogHeader1
            // 
            this.dialogHeader1.HeaderDescription = "Here you can find some global settings. Few for now... it will grow!";
            this.dialogHeader1.HeaderTitle = "XwRemote settings";
            resources.ApplyResources(this.dialogHeader1, "dialogHeader1");
            this.dialogHeader1.Gradient1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.dialogHeader1.Gradient2 = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.dialogHeader1.Gradient3 = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.dialogHeader1.Gradient4 = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.dialogHeader1.HeaderImage = global::XwRemote.Properties.Resources.settings;
            this.dialogHeader1.Name = "dialogHeader1";
            // 
            // dividerPanel1
            // 
            resources.ApplyResources(this.dividerPanel1, "dividerPanel1");
            this.dividerPanel1.AllowDrop = true;
            this.dividerPanel1.BorderSide = System.Windows.Forms.Border3DSide.Top;
            this.dividerPanel1.Controls.Add(this.butCancel);
            this.dividerPanel1.Controls.Add(this.butOK);
            this.dividerPanel1.Name = "dividerPanel1";
            // 
            // butCancel
            // 
            resources.ApplyResources(this.butCancel, "butCancel");
            this.butCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butCancel.Name = "butCancel";
            this.butCancel.UseVisualStyleBackColor = true;
            // 
            // butOK
            // 
            resources.ApplyResources(this.butOK, "butOK");
            this.butOK.Name = "butOK";
            this.butOK.UseVisualStyleBackColor = true;
            this.butOK.Click += new System.EventHandler(this.butOK_Click);
            this.butOK.KeyDown += new System.Windows.Forms.KeyEventHandler(this.butOK_KeyDown);
            // 
            // faTabStrip1
            // 
            resources.ApplyResources(this.faTabStrip1, "faTabStrip1");
            this.faTabStrip1.AlwaysShowClose = false;
            this.faTabStrip1.AlwaysShowMenuGlyph = false;
            this.faTabStrip1.Items.AddRange(new FarsiLibrary.Win.FATabStripItem[] {
            this.tabSecurity,
            this.tabFTP,
            this.tabSSH,
            this.tabInterface});
            // 
            // tabSecurity
            //
            this.tabSecurity.Title = "Security";
            resources.ApplyResources(this.tabSecurity, "tabSecurity");
            this.tabSecurity.CanClose = false;
            this.tabSecurity.Controls.Add(this.label6);
            this.tabSecurity.Controls.Add(this.label5);
            this.tabSecurity.Controls.Add(this.label4);
            this.tabSecurity.Controls.Add(this.label3);
            this.tabSecurity.Controls.Add(this.textPasswordRepeat);
            this.tabSecurity.Controls.Add(this.butRemovePass);
            this.tabSecurity.Controls.Add(this.butSetPassword);
            this.tabSecurity.Controls.Add(this.textMasterPassword);
            this.tabSecurity.Controls.Add(this.label2);
            this.tabSecurity.IsDrawn = true;
            this.tabSecurity.Name = "tabSecurity";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // textPasswordRepeat
            // 
            resources.ApplyResources(this.textPasswordRepeat, "textPasswordRepeat");
            this.textPasswordRepeat.Name = "textPasswordRepeat";
            this.textPasswordRepeat.UseSystemPasswordChar = true;
            // 
            // butRemovePass
            // 
            resources.ApplyResources(this.butRemovePass, "butRemovePass");
            this.butRemovePass.Name = "butRemovePass";
            this.butRemovePass.UseVisualStyleBackColor = true;
            this.butRemovePass.Click += new System.EventHandler(this.butRemovePass_Click);
            // 
            // butSetPassword
            // 
            resources.ApplyResources(this.butSetPassword, "butSetPassword");
            this.butSetPassword.Name = "butSetPassword";
            this.butSetPassword.UseVisualStyleBackColor = true;
            this.butSetPassword.Click += new System.EventHandler(this.butSetPassword_Click);
            // 
            // textMasterPassword
            // 
            resources.ApplyResources(this.textMasterPassword, "textMasterPassword");
            this.textMasterPassword.Name = "textMasterPassword";
            this.textMasterPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // tabFTP
            // 
            this.tabFTP.Title = "File Location";
            resources.ApplyResources(this.tabFTP, "tabFTP");
            this.tabFTP.CanClose = false;
            this.tabFTP.Controls.Add(this.groupBox1);
            this.tabFTP.Controls.Add(this.textBox1);
            this.tabFTP.Image = global::XwRemote.Properties.Resources.ftp;
            this.tabFTP.IsDrawn = true;
            this.tabFTP.Name = "tabFTP";
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.btnBrowseFolder);
            this.groupBox1.Controls.Add(this.textFixedFolder);
            this.groupBox1.Controls.Add(this.radioFixed);
            this.groupBox1.Controls.Add(this.radioLastUsed);
            this.groupBox1.Controls.Add(this.radioMyComputer);
            this.groupBox1.Controls.Add(this.radioDesktop);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // btnBrowseFolder
            // 
            resources.ApplyResources(this.btnBrowseFolder, "btnBrowseFolder");
            this.btnBrowseFolder.Name = "btnBrowseFolder";
            this.btnBrowseFolder.UseVisualStyleBackColor = true;
            this.btnBrowseFolder.Click += new System.EventHandler(this.btnBrowseFolder_Click);
            // 
            // textFixedFolder
            // 
            resources.ApplyResources(this.textFixedFolder, "textFixedFolder");
            this.textFixedFolder.Name = "textFixedFolder";
            // 
            // radioFixed
            // 
            resources.ApplyResources(this.radioFixed, "radioFixed");
            this.radioFixed.Name = "radioFixed";
            this.radioFixed.TabStop = true;
            this.radioFixed.UseVisualStyleBackColor = true;
            this.radioFixed.CheckedChanged += new System.EventHandler(this.radioFixed_CheckedChanged);
            // 
            // radioLastUsed
            // 
            resources.ApplyResources(this.radioLastUsed, "radioLastUsed");
            this.radioLastUsed.Name = "radioLastUsed";
            this.radioLastUsed.TabStop = true;
            this.radioLastUsed.UseVisualStyleBackColor = true;
            // 
            // radioMyComputer
            // 
            resources.ApplyResources(this.radioMyComputer, "radioMyComputer");
            this.radioMyComputer.Name = "radioMyComputer";
            this.radioMyComputer.TabStop = true;
            this.radioMyComputer.UseVisualStyleBackColor = true;
            // 
            // radioDesktop
            // 
            resources.ApplyResources(this.radioDesktop, "radioDesktop");
            this.radioDesktop.Name = "radioDesktop";
            this.radioDesktop.TabStop = true;
            this.radioDesktop.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // tabSSH
            // 
            this.tabSSH.Title = "SSH";
            resources.ApplyResources(this.tabSSH, "tabSSH");
            this.tabSSH.CanClose = false;
            this.tabSSH.Controls.Add(this.checkBoxCorrectFocus);
            this.tabSSH.Controls.Add(this.sshFontSize);
            this.tabSSH.Controls.Add(this.label1);
            this.tabSSH.IsDrawn = true;
            this.tabSSH.Name = "tabSSH";
            // 
            // checkBoxCorrectFocus
            // 
            resources.ApplyResources(this.checkBoxCorrectFocus, "checkBoxCorrectFocus");
            this.checkBoxCorrectFocus.Checked = true;
            this.checkBoxCorrectFocus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCorrectFocus.Name = "checkBoxCorrectFocus";
            this.checkBoxCorrectFocus.UseVisualStyleBackColor = true;
            // 
            // sshFontSize
            // 
            resources.ApplyResources(this.sshFontSize, "sshFontSize");
            this.sshFontSize.Name = "sshFontSize";
            this.sshFontSize.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // tabInterface
            // 
            this.tabInterface.Title = "Interface";
            resources.ApplyResources(this.tabInterface, "tabInterface");
            this.tabInterface.CanClose = false;
            this.tabInterface.Controls.Add(this.checkCloseToTray);
            this.tabInterface.Controls.Add(this.checkMinimizeToTray);
            this.tabInterface.IsDrawn = true;
            this.tabInterface.Name = "tabInterface";
            // 
            // checkCloseToTray
            // 
            resources.ApplyResources(this.checkCloseToTray, "checkCloseToTray");
            this.checkCloseToTray.Checked = true;
            this.checkCloseToTray.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkCloseToTray.Name = "checkCloseToTray";
            this.checkCloseToTray.UseVisualStyleBackColor = true;
            // 
            // checkMinimizeToTray
            // 
            resources.ApplyResources(this.checkMinimizeToTray, "checkMinimizeToTray");
            this.checkMinimizeToTray.Checked = true;
            this.checkMinimizeToTray.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkMinimizeToTray.Name = "checkMinimizeToTray";
            this.checkMinimizeToTray.UseVisualStyleBackColor = true;
            // 
            // folderBrowserDialog1
            // 
            resources.ApplyResources(this.folderBrowserDialog1, "folderBrowserDialog1");
            // 
            // GlobalSettings
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.butCancel;
            this.Controls.Add(this.faTabStrip1);
            this.Controls.Add(this.dividerPanel1);
            this.Controls.Add(this.dialogHeader1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GlobalSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.dividerPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.faTabStrip1)).EndInit();
            this.faTabStrip1.ResumeLayout(false);
            this.tabSecurity.ResumeLayout(false);
            this.tabSecurity.PerformLayout();
            this.tabFTP.ResumeLayout(false);
            this.tabFTP.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabSSH.ResumeLayout(false);
            this.tabSSH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sshFontSize)).EndInit();
            this.tabInterface.ResumeLayout(false);
            this.tabInterface.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private XwMaxLib.UI.DialogHeader dialogHeader1;
        private DividerPanel.DividerPanel dividerPanel1;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.Button butOK;
        private FarsiLibrary.Win.FATabStrip faTabStrip1;
        private FarsiLibrary.Win.FATabStripItem tabFTP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBrowseFolder;
        private System.Windows.Forms.TextBox textFixedFolder;
        private System.Windows.Forms.RadioButton radioFixed;
        private System.Windows.Forms.RadioButton radioLastUsed;
        private System.Windows.Forms.RadioButton radioDesktop;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.RadioButton radioMyComputer;
        private FarsiLibrary.Win.FATabStripItem tabSSH;
        private System.Windows.Forms.NumericUpDown sshFontSize;
        private System.Windows.Forms.Label label1;
        private FarsiLibrary.Win.FATabStripItem tabSecurity;
        private System.Windows.Forms.TextBox textMasterPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butRemovePass;
        private System.Windows.Forms.Button butSetPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textPasswordRepeat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxCorrectFocus;
        private FarsiLibrary.Win.FATabStripItem tabInterface;
        private System.Windows.Forms.CheckBox checkCloseToTray;
        private System.Windows.Forms.CheckBox checkMinimizeToTray;
    }
}