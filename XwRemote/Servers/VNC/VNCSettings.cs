﻿using System;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;
using XwMaxLib.Extensions;
using XwMaxLib.Extentions;

namespace XwRemote.Settings
{
    public partial class VNCSettings : Form
    {
        private Server server = null;
        private ResourceManager rm = new ResourceManager(typeof(VNCSettings));

        //*************************************************************************************************************
        public VNCSettings(Server server)
        {
            InitializeComponent();
            this.server = server;
        }

        //*************************************************************************************************************
        private void OnLoad(object sender, EventArgs e)
        {
            server.Type = ServerType.VNC;
            NameBox.Text = server.Name;
            HostBox.Text = server.Host;
            PassBox.Text = server.Password;
            IsFavorite.Checked = server.IsFavorite;
            PortBox.Text = server.Port.ToString();
            checkAutoScale.Checked = server.AutoScale;
            tabColorBox.SelectedColor = Color.FromArgb(server.TabColor);
            NotesBox.Text = server.Notes;

            if (server.Port == 5900 || server.Port == 0)
            {
                DefaultPort.Checked = true;
                PortBox.Enabled = false;
                PortBox.Text = "5900";
            }
            else
            {
                DefaultPort.Checked = false;
                PortBox.Enabled = true;
            }
        }

        //*************************************************************************************************************
        private void butOK_Click(object sender, EventArgs e)
        {
            if (NameBox.Text.Trim() == string.Empty)
            {
                NameBox.ShowBalloon(ToolTipIcon.Warning, rm.GetString("msg_name"), rm.GetString("msg_not_empty"));
                return;
            }

            if (HostBox.Text.Trim() == string.Empty)
            {
                HostBox.ShowBalloon(ToolTipIcon.Warning, rm.GetString("msg_host"), rm.GetString("msg_not_empty"));
                return;
            }

            server.Name = NameBox.Text;
            server.Host = HostBox.Text;
            server.Password = PassBox.Text;
            server.IsFavorite = IsFavorite.Checked;
            server.AutoScale = checkAutoScale.Checked;
            server.Port = PortBox.Text.ToIntOrDefault(5900);
            server.TabColor = tabColorBox.SelectedColor.ToArgb();
            server.Notes = NotesBox.Text;
            Main.config.SaveServer(server);
            Close();
        }

        //*************************************************************************************************************
        private void butCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        //*************************************************************************************************************
        private void DefaultPort_CheckedChanged(object sender, EventArgs e)
        {
            if (DefaultPort.Checked)
            {
                PortBox.Enabled = false;
                PortBox.Text = "5900";
            }
            else
            {
                PortBox.Enabled = true;
            }
        }

        //*************************************************************************************************************
        private void PassBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
                PassBox.UseSystemPasswordChar = !PassBox.UseSystemPasswordChar;
        }

        //*************************************************************************************************************
        private void buttonShowPassword_Click(object sender, EventArgs e)
        {
            PassBox.UseSystemPasswordChar = !PassBox.UseSystemPasswordChar;
        }
    }
}
