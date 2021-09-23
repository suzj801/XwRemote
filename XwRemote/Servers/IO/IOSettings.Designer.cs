namespace XwRemote.Settings
{
    partial class IOSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IOSettings));
            this.dialogHeader1 = new XwMaxLib.UI.DialogHeader();
            this.dividerPanel1 = new DividerPanel.DividerPanel();
            this.butCancel = new System.Windows.Forms.Button();
            this.butOK = new System.Windows.Forms.Button();
            this.IsFavorite = new System.Windows.Forms.CheckBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.HostLabel = new System.Windows.Forms.Label();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.UserBox = new System.Windows.Forms.TextBox();
            this.HostBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PortLabel = new System.Windows.Forms.Label();
            this.PortBox = new System.Windows.Forms.TextBox();
            this.DefaultPort = new System.Windows.Forms.CheckBox();
            this.tabColorBox = new ColorComboTestApp.ColorComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.NotesBox = new System.Windows.Forms.TextBox();
            this.buttonOpenSshKey = new System.Windows.Forms.Button();
            this.SshKeyLabel = new System.Windows.Forms.Label();
            this.SshKeyBox = new System.Windows.Forms.TextBox();
            this.buttonShowPassword = new System.Windows.Forms.Button();
            this.FtpDataType = new System.Windows.Forms.ComboBox();
            this.FtpDataTypeLabel = new System.Windows.Forms.Label();
            this.UseTLS = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dividerPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dialogHeader1
            // 
            this.dialogHeader1.HeaderTitle = "FTP";
            this.dialogHeader1.HeaderDescription = "Connecting settings for FTP server";
            resources.ApplyResources(this.dialogHeader1, "dialogHeader1");
            this.dialogHeader1.Gradient1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.dialogHeader1.Gradient2 = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.dialogHeader1.Gradient3 = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.dialogHeader1.Gradient4 = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.dialogHeader1.HeaderImage = global::XwRemote.Properties.Resources.ftp;
            this.dialogHeader1.Name = "dialogHeader1";
            this.dialogHeader1.TabStop = false;
            // 
            // dividerPanel1
            // 
            this.dividerPanel1.AllowDrop = true;
            this.dividerPanel1.BorderSide = System.Windows.Forms.Border3DSide.Top;
            this.dividerPanel1.Controls.Add(this.butCancel);
            this.dividerPanel1.Controls.Add(this.butOK);
            this.dividerPanel1.Controls.Add(this.IsFavorite);
            resources.ApplyResources(this.dividerPanel1, "dividerPanel1");
            this.dividerPanel1.Name = "dividerPanel1";
            // 
            // butCancel
            // 
            this.butCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.butCancel, "butCancel");
            this.butCancel.Name = "butCancel";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // butOK
            // 
            resources.ApplyResources(this.butOK, "butOK");
            this.butOK.Name = "butOK";
            this.butOK.UseVisualStyleBackColor = true;
            this.butOK.Click += new System.EventHandler(this.butOK_Click);
            // 
            // IsFavorite
            // 
            resources.ApplyResources(this.IsFavorite, "IsFavorite");
            this.IsFavorite.Name = "IsFavorite";
            this.IsFavorite.UseVisualStyleBackColor = true;
            // 
            // PasswordLabel
            // 
            resources.ApplyResources(this.PasswordLabel, "PasswordLabel");
            this.PasswordLabel.Name = "PasswordLabel";
            // 
            // UsernameLabel
            // 
            resources.ApplyResources(this.UsernameLabel, "UsernameLabel");
            this.UsernameLabel.Name = "UsernameLabel";
            // 
            // HostLabel
            // 
            resources.ApplyResources(this.HostLabel, "HostLabel");
            this.HostLabel.Name = "HostLabel";
            // 
            // PassBox
            // 
            resources.ApplyResources(this.PassBox, "PassBox");
            this.PassBox.Name = "PassBox";
            this.PassBox.UseSystemPasswordChar = true;
            this.PassBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PassBox_KeyDown);
            // 
            // UserBox
            // 
            resources.ApplyResources(this.UserBox, "UserBox");
            this.UserBox.Name = "UserBox";
            // 
            // HostBox
            // 
            resources.ApplyResources(this.HostBox, "HostBox");
            this.HostBox.Name = "HostBox";
            // 
            // NameBox
            // 
            resources.ApplyResources(this.NameBox, "NameBox");
            this.NameBox.Name = "NameBox";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // PortLabel
            // 
            resources.ApplyResources(this.PortLabel, "PortLabel");
            this.PortLabel.Name = "PortLabel";
            // 
            // PortBox
            // 
            resources.ApplyResources(this.PortBox, "PortBox");
            this.PortBox.Name = "PortBox";
            // 
            // DefaultPort
            // 
            resources.ApplyResources(this.DefaultPort, "DefaultPort");
            this.DefaultPort.Checked = true;
            this.DefaultPort.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DefaultPort.Name = "DefaultPort";
            this.DefaultPort.UseVisualStyleBackColor = true;
            this.DefaultPort.CheckedChanged += new System.EventHandler(this.DefaultPort_CheckedChanged);
            // 
            // tabColorBox
            // 
            this.tabColorBox.Extended = true;
            this.tabColorBox.ForeColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.tabColorBox, "tabColorBox");
            this.tabColorBox.Name = "tabColorBox";
            this.tabColorBox.SelectedColor = System.Drawing.Color.LightSkyBlue;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // NotesBox
            // 
            this.NotesBox.AcceptsReturn = true;
            resources.ApplyResources(this.NotesBox, "NotesBox");
            this.NotesBox.Name = "NotesBox";
            // 
            // buttonOpenSshKey
            // 
            resources.ApplyResources(this.buttonOpenSshKey, "buttonOpenSshKey");
            this.buttonOpenSshKey.Name = "buttonOpenSshKey";
            this.buttonOpenSshKey.UseVisualStyleBackColor = true;
            this.buttonOpenSshKey.Click += new System.EventHandler(this.buttonOpenSshKey_Click);
            // 
            // SshKeyLabel
            // 
            resources.ApplyResources(this.SshKeyLabel, "SshKeyLabel");
            this.SshKeyLabel.Name = "SshKeyLabel";
            // 
            // SshKeyBox
            // 
            this.SshKeyBox.AcceptsReturn = true;
            resources.ApplyResources(this.SshKeyBox, "SshKeyBox");
            this.SshKeyBox.Name = "SshKeyBox";
            // 
            // buttonShowPassword
            // 
            this.buttonShowPassword.Image = global::XwRemote.Properties.Resources.eye;
            resources.ApplyResources(this.buttonShowPassword, "buttonShowPassword");
            this.buttonShowPassword.Name = "buttonShowPassword";
            this.buttonShowPassword.UseVisualStyleBackColor = true;
            this.buttonShowPassword.Click += new System.EventHandler(this.buttonShowPassword_Click);
            // 
            // FtpDataType
            // 
            this.FtpDataType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FtpDataType.FormattingEnabled = true;
            resources.ApplyResources(this.FtpDataType, "FtpDataType");
            this.FtpDataType.Name = "FtpDataType";
            // 
            // FtpDataTypeLabel
            // 
            resources.ApplyResources(this.FtpDataTypeLabel, "FtpDataTypeLabel");
            this.FtpDataTypeLabel.Name = "FtpDataTypeLabel";
            // 
            // UseTLS
            // 
            resources.ApplyResources(this.UseTLS, "UseTLS");
            this.UseTLS.Checked = true;
            this.UseTLS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.UseTLS.Name = "UseTLS";
            this.UseTLS.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // IOSettings
            // 
            this.AcceptButton = this.butOK;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.butCancel;
            this.Controls.Add(this.UseTLS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FtpDataTypeLabel);
            this.Controls.Add(this.FtpDataType);
            this.Controls.Add(this.buttonShowPassword);
            this.Controls.Add(this.buttonOpenSshKey);
            this.Controls.Add(this.SshKeyLabel);
            this.Controls.Add(this.SshKeyBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.NotesBox);
            this.Controls.Add(this.tabColorBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DefaultPort);
            this.Controls.Add(this.PortLabel);
            this.Controls.Add(this.PortBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.HostLabel);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.UserBox);
            this.Controls.Add(this.HostBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dividerPanel1);
            this.Controls.Add(this.dialogHeader1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IOSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.OnLoad);
            this.dividerPanel1.ResumeLayout(false);
            this.dividerPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XwMaxLib.UI.DialogHeader dialogHeader1;
        private DividerPanel.DividerPanel dividerPanel1;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.Button butOK;
        private System.Windows.Forms.CheckBox IsFavorite;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label HostLabel;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.TextBox UserBox;
        private System.Windows.Forms.TextBox HostBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label PortLabel;
        private System.Windows.Forms.TextBox PortBox;
        private System.Windows.Forms.CheckBox DefaultPort;
        private ColorComboTestApp.ColorComboBox tabColorBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox NotesBox;
        private System.Windows.Forms.Button buttonOpenSshKey;
        private System.Windows.Forms.Label SshKeyLabel;
        private System.Windows.Forms.TextBox SshKeyBox;
        private System.Windows.Forms.Button buttonShowPassword;
        private System.Windows.Forms.ComboBox FtpDataType;
        private System.Windows.Forms.Label FtpDataTypeLabel;
        private System.Windows.Forms.CheckBox UseTLS;
        private System.Windows.Forms.Label label3;
    }
}