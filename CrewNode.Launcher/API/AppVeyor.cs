using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Net;
using Newtonsoft.Json;
using CrewNode.Launcher.API.Models;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.ComponentModel;
using Guna.UI.WinForms;
using CrewNode.Launcher.UI.Addons;
using System.IO;

namespace CrewNode.Launcher.API
{
    class AppVeyor
    {
        // https://stackoverflow.com/questions/415620/redirect-console-output-to-textbox-in-separate-program

        private const string impostorHistory = "https://ci.appveyor.com/api/projects/Impostor/Impostor/history?recordsNumber=50";
        private const string lastJobUrl = "https://ci.appveyor.com/api/projects/Impostor/Impostor/branch/dev";

        public static List<AppComboBoxItem> getImpostorBuilds()
        {
            List<AppComboBoxItem> builds = new List<AppComboBoxItem>();

            // Submit a GET request for the builds
            WebClient client = new WebClient();
            client.Headers.Set("Content-Type", "application/json");
            try
            {
                string rawData = client.DownloadString(impostorHistory);
                BuildHistory.Item rawBuilds = JsonConvert.DeserializeObject<BuildHistory.Item>(rawData);
                foreach (BuildHistory.Build b in rawBuilds.builds)
                {
                    //if (b.committerUsername != "AeonLucid" || b.branch != "dev")
                    //    continue;

                    builds.Add(new AppComboBoxItem()
                    {
                        Build = b,
                        Text = $"{b.version} ({b.branch}, by {b.committerUsername}) @ {b.commitId.Substring(0, 7)}",
                        Value = b.buildId,
                        Hash = b.commitId
                    }); ;
                }
            } catch { }
            client.Dispose();
            return builds;
        }

        public static string getBuildJobId(int buildId)
        {
            WebClient client = new WebClient();
            client.Headers.Set("Content-Type", "application/json");
            try
            {
                string rawData = client.DownloadString($"https://ci.appveyor.com/api/projects/Impostor/Impostor/builds/{buildId}");
                BuildInfo.Item rawInfo = JsonConvert.DeserializeObject<BuildInfo.Item>(rawData);
                client.Dispose();
                return rawInfo.build.jobs[0].jobId;
            }
            catch { MessageBox.Show("jobId not found"); }
            client.Dispose();
            return "";
        }

        public static List<BuildArtifact> getBuildArtifacts(string jobId)
        {
            WebClient client = new WebClient();
            client.Headers.Set("Content-Type", "application/json");
            try
            {
                string rawData = client.DownloadString($"https://ci.appveyor.com/api/buildjobs/{jobId}/artifacts");
                List<BuildArtifact> rawArtifacts = JsonConvert.DeserializeObject<List<BuildArtifact>>(rawData);
                client.Dispose();
                return rawArtifacts;
            }
            catch { MessageBox.Show("artifacts not found"); }
            client.Dispose();
            return new List<BuildArtifact>();
        }


        public static string getBuildDownload(AppComboBoxItem build)
        {
            string jobId = getBuildJobId(build.Build.buildId);
            if (jobId.Length == 0) return "";

            foreach (BuildArtifact artifact in getBuildArtifacts(jobId))
            {
                if (artifact.fileName.Contains("Impostor-Server") && artifact.fileName.Contains("_win-x64.zip"))
                {
                    return $"https://ci.appveyor.com/api/buildjobs/{jobId}/artifacts/{artifact.fileName}";
                }
            }
            return "";
        }

        public static string downloadBuild(LocalServerNew parent, string url, string commitHash)
        {
            // TODO: Read configuration

            // Download directory
            string serversDirectory = Application.StartupPath + @"\servers";
            if (!Directory.Exists(serversDirectory))
                Directory.CreateDirectory(serversDirectory);

            // TODO: Generate saving directory from id & create directory

            // TODO: Add to configuration

            // Check if we already have a ZIP with this hash
            // TODO: May need to go if outputting to temp directory
            string outputFile = Path.Combine(serversDirectory, $"{commitHash}.zip");
            if (File.Exists(outputFile))
                return outputFile;

            using (WebClient client = new WebClient())
            {
                client.DownloadProgressChanged += (object s2, DownloadProgressChangedEventArgs e2) => Client_DownloadProgressChanged(s2, e2, parent);
                client.DownloadFileCompleted += (object s3, AsyncCompletedEventArgs e3) => Client_DownloadFileCompleted(s3, e3, parent);
                // TODO: Should we output to "Directory.GetTempFileName()" and then extract ?
                client.DownloadFileAsync(new Uri(url), outputFile); // TODO: update output path to new directory
            }

            return outputFile;
        }

        private static void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e, LocalServerNew parent)
        {
            parent.Invoke((MethodInvoker)delegate ()
            {
                if (!parent.gunaProgressBar1.Visible)
                {
                    parent.gunaProgressBar1.Visible = true;
                    parent.gunaProgressBar1.BringToFront();
                }

                parent.okBtn.Text = e.ProgressPercentage.ToString() + "%";
                parent.gunaProgressBar1.Value = e.ProgressPercentage;
            });
        }

        private static void Client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e, LocalServerNew parent)
        {
            // TODO: Return new server via this.DialogResult
            // TODO: then update LocalServerSelection.cs to refresh the server list, and then auto select it
            parent.Invoke((MethodInvoker)delegate ()
            {
                parent.Close();
            });
        }
    }
}
