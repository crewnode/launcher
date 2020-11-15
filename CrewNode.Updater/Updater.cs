using CrewNode.Updater.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrewNode.Updater
{
    // https://www.youtube.com/watch?v=ld-Wcmv0ImI&list=PL3iOx6lykrwqc_KuJWIU3yAyTP2C7h_xE&index=8

    internal partial class Updater : Form
    {
        private WebClient webClient;
        private BackgroundWorker bgWorker;
        private string shaHash;
        
        internal string tempFile { get; }

        internal Updater(ILauncherUpdateable appInfo, LauncherUpdateJson updateInfo)
        {
            InitializeComponent();
            this.Text = $"CrewNode: Update to {updateInfo.Version}";
            this.statusLbl.Text = String.Format($"Updating from {appInfo.LauncherAssembly.GetName().Version.ToString()} to {updateInfo.Version}");

            if (appInfo.LauncherIcon != null)
                this.Icon = appInfo.LauncherIcon;

            this.shaHash = updateInfo.SHA;
            this.tempFile = Path.GetTempFileName();

            // Setup WebClient
            webClient = new WebClient();
            webClient.DownloadProgressChanged += WebClient_DownloadProgressChanged;
            webClient.DownloadFileCompleted += WebClient_DownloadFileCompleted;

            // Setup BackgroundWorker
            bgWorker = new BackgroundWorker();
            bgWorker.DoWork += BgWorker_DoWork;
            bgWorker.RunWorkerCompleted += BgWorker_RunWorkerCompleted;

            // Download file
            Console.WriteLine("Update URL: " + updateInfo.Uri);
            try { webClient.DownloadFileAsync(updateInfo.Uri, this.tempFile); }
            catch { this.DialogResult = DialogResult.No; this.Close(); }
        }

        private void WebClient_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            this.downloadProgressBar.Value = e.ProgressPercentage;
            this.progressLbl.Text = String.Format("Downloaded {0} of {1}", FormatBytes(e.BytesReceived, 1, true), FormatBytes(e.TotalBytesToReceive, 1, true));
        }

        private void WebClient_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                Console.WriteLine(e.Error.Message);
                this.DialogResult = DialogResult.No;
                this.Close();
                return;
            }
            else if (e.Cancelled)
            {
                this.DialogResult = DialogResult.Abort;
                this.Close();
                return;
            }
            else
            {
                progressLbl.Text = "Verifying";
                downloadProgressBar.Style = Guna.UI.WinForms.ProgressBarStyle.Marquee;
                bgWorker.RunWorkerAsync(new string[] { this.tempFile, this.shaHash });
            }
        }

        private void BgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            string file = ((string[])e.Argument)[0];
            string updateShaHash = ((string[])e.Argument)[1];

            if (Hasher.HashFile(file, HashType.SHA512) != updateShaHash)
                e.Result = DialogResult.No;
            else
                e.Result = DialogResult.OK;
        }

        private void BgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.DialogResult = (DialogResult)e.Result;
            this.Close();
        }

        private string FormatBytes(long bytes, int dp, bool showByteType)
        {
            double newBytes = bytes;
            string formatString = "{0";
            string byteType = "B";

            if (newBytes > 1024 && newBytes < 1048576)
            {
                newBytes /= 1024;
                byteType = "KB";
            }
            else if (newBytes > 1048576 && newBytes < 1073741824)
            {
                newBytes /= 1048576;
                byteType = "MB";
            }
            else
            {
                newBytes /= 1073741824;
                byteType = "GB";
            }

            if (dp > 0)
                formatString += ":0.";
            for (int i = 0; i < dp; i++)
                formatString += "0";
            formatString += "}" + (showByteType ? byteType : "");
            return String.Format(formatString, newBytes);
        }

        private void Updater_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (webClient.IsBusy)
            {
                webClient.CancelAsync();
            }

            if (bgWorker.IsBusy)
            {
                bgWorker.CancelAsync();
                this.DialogResult = DialogResult.Abort;
            }
        }

        private void Updater_Load(object sender, EventArgs e)
        {
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


        private bool relocatingForm = false;
        private Point offset, original;
        private void formDrag_MouseMove(object sender, MouseEventArgs e)
        {
            if (!relocatingForm) return;
            this.Location = new Point(
                original.X + MousePosition.X - offset.X,
                original.Y + MousePosition.Y - offset.Y
            );
        }

        private void formDrag_MouseUp(object sender, MouseEventArgs e)
        {
            relocatingForm = false;
            headerPanel.Capture = false;
        }
        private void formDrag_MouseDown(object sender, MouseEventArgs e)
        {
            relocatingForm = true;
            headerPanel.Capture = true;
            offset = MousePosition;
            original = this.Location;
        }
    }
}
