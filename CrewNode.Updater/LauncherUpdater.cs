using CrewNode.Updater.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrewNode.Updater
{
    public class LauncherUpdater
    {

        private ILauncherUpdateable appInfo;
        private BackgroundWorker bgWorker;

        public LauncherUpdater(ILauncherUpdateable _appInfo)
        {
            this.appInfo = _appInfo;
            this.bgWorker = new BackgroundWorker();
            this.bgWorker.DoWork += BgWorker_DoWork;
            this.bgWorker.RunWorkerCompleted += BgWorker_RunWorkerCompleted;
        }

        public void DoUpdate()
        {
            if (!bgWorker.IsBusy)
                this.bgWorker.RunWorkerAsync(this.appInfo);
        }

        private void BgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            ILauncherUpdateable app = (ILauncherUpdateable)e.Argument;
            if (!LauncherUpdateJson.ExistsOnServer(app.LauncherJson))
            {
                Console.WriteLine("Update cancelled");
                e.Cancel = true;
            }
            else
            {
                Console.WriteLine("Parse");
                e.Result = LauncherUpdateJson.Parse(app.LauncherJson, app.LauncherIdentifier);
                Console.WriteLine("parsed");
            }
        }

        private void BgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Console.WriteLine("RunWorkerCompleted");
            if (!e.Cancelled)
            {
                LauncherUpdateJson update = (LauncherUpdateJson)e.Result;
                if (update != null && update.IsNewerVersion(this.appInfo.LauncherAssembly.GetName().Version))
                {
                    Console.WriteLine("DownloadUpdate");
                    this.DownloadUpdate(update);
                }
                else
                    Console.WriteLine("Online version: " + update.Version + ", local version: " + this.appInfo.LauncherAssembly.GetName().Version);
            }
            else
            {
                Console.WriteLine("Cancelled, piece of shit.");
            }
        }

        private void DownloadUpdate(LauncherUpdateJson update)
        {
            Updater form = new Updater(appInfo, update);
            DialogResult r = form.ShowDialog(this.appInfo.LauncherUpdaterContext);

            if (r == DialogResult.OK)
            {
                string curPath = this.appInfo.LauncherAssembly.Location;
                string newPath = Path.Combine(Path.GetDirectoryName(curPath), update.FileName);

                UpdateLauncher(form.tempFile, curPath, newPath, update.LaunchArgs);
                Application.Exit();
            }
            else if (r == DialogResult.Abort)
                MessageBox.Show("The update has been cancelled.", "Update Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                Console.WriteLine("Update failed: " + r.ToString());
                MessageBox.Show("The update failed.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateLauncher(string tempFilePath, string curPath, string newPath, string launchArgs)
        {
            // Rundown:
            // "/C Choice /C Y /N /D Y /T 4" - Pause for 4 seconds
            // "Del /F /Q \"{0}\"" - Delete original app file
            // "/C Choice /C Y /N /D Y /T 2" - Pause for 2 seconds
            // "Move /Y \"{1}\" \"{2}\"" - Moves our temp downloaded file where the old file was
            // "Start \"\" /D \"{3}\" \"{4}\" {5}" - Starts the new app with launch args
            string args = "/C Choice /C Y /N /D Y /T 4 & Del /F /Q \"{0}\" & /C Choice /C Y /N /D Y /T 2 & Move /Y \"{1}\" \"{2}\" & Start \"\" /D \"{3}\" \"{4}\" {5}";

            // Start our long winded shizzle
            ProcessStartInfo info = new ProcessStartInfo();
            info.Arguments = string.Format(args, curPath, tempFilePath, newPath, Path.GetDirectoryName(newPath), Path.GetFileName(newPath), launchArgs);
            info.WindowStyle = ProcessWindowStyle.Hidden;
            info.CreateNoWindow = true;
            info.FileName = "cmd.exe";
            Process.Start(info);
        }
    }
}
