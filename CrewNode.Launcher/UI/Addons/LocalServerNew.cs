using CrewNode.Launcher.API;
using CrewNode.Launcher.API.Models;
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

namespace CrewNode.Launcher.UI.Addons
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

            // Update dropdown height
            impostorVersionsCombo.DropDownStyle = ComboBoxStyle.Simple;
            impostorVersionsCombo.MaxDropDownItems = 10;

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
            AppVeyor.downloadBuild(this, AppVeyor.getBuildDownload(buildItem), buildItem.Hash);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
