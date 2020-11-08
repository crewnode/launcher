﻿using CrewNodeLauncher.API;
using CrewNodeLauncher.API.Models;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Deployment.Application;
using System.Drawing;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace CrewNodeLauncher.UI.Addons
{
    public partial class LocalServerNew : Form
    {
        public LocalServerNew()
        {
            InitializeComponent();
        }

        private void LocalServerNew_Load(object sender, EventArgs e)
        {
            nameImg.BackgroundImage = IconChar.Server.ToBitmap(Color.Black);
            branchImg.BackgroundImage = IconChar.CodeBranch.ToBitmap(Color.Black);
            okBtn.Image = IconChar.Download.ToBitmap(Color.White);

            // Get AppVeyor builds
            List<AppComboBoxItem> builds = AppVeyor.getImpostorBuilds();
            foreach (AppComboBoxItem b in builds)
            {
                impostorVersionsCombo.Items.Add(b);
            }

            // Clipping
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        private void downloadBtn_Click(object sender, EventArgs e)
        {
            if (impostorVersionsCombo.SelectedItem == null) return;

            AppComboBoxItem buildItem = (AppComboBoxItem)impostorVersionsCombo.SelectedItem;
            string downloadLink = AppVeyor.getBuildDownload(buildItem);
            if (downloadLink.Length == 0)
            {
                using (CrewNodeMsgBox msg = new CrewNodeMsgBox("Invalid Build", "It looks like the build you requested does not have any valid artifacts.\nPlease try a different build."))
                    msg.ShowDialog();
                return;
            }

            // Download the ZIP file
            okBtn.Enabled = false;
            WebClient c = AppVeyor.downloadBuild(AppVeyor.getBuildDownload(buildItem), okBtn);
            c.DownloadProgressChanged += (object s2, System.Net.DownloadProgressChangedEventArgs e2) => Client_DownloadProgressChanged(s2, e2);
            c.DownloadFileCompleted += (object s3, AsyncCompletedEventArgs e3) => Client_DownloadFileCompleted(s3, e3);
        }

        private void Client_DownloadProgressChanged(object sender, System.Net.DownloadProgressChangedEventArgs e)
        {
            okBtn.Text = e.ProgressPercentage.ToString() + "%";
        }

        private void Client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            // TODO: Return new server via this.DialogResult
            // TODO: then update LocalServerSelection.cs to refresh the server list, and then auto select it
            this.Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
