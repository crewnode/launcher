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

namespace CrewNode.Launcher.API
{
    class AppVeyor
    {
        // https://stackoverflow.com/questions/415620/redirect-console-output-to-textbox-in-separate-program

        private const string impostorHistory = "https://ci.appveyor.com/api/projects/Impostor/Impostor/history?recordsNumber=20";
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
                    if (b.committerUsername != "AeonLucid" || b.branch != "dev")
                        continue;

                    builds.Add(new AppComboBoxItem() { Build = b, Text = b.version, Value = b.buildId });
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

        public static WebClient downloadBuild(string url, GunaAdvenceButton btn)
        {
            // TODO: Read configuration

            // Download directory
            string serversDirectory = Application.StartupPath + @"\servers";

            // TODO: Generate saving directory from id & create directory

            // TODO: Add to configuration

            WebClient client = new WebClient();
            client.DownloadFileAsync(new Uri(url), $"{serversDirectory}\\server.zip"); // TODO: update output path to new directory
            return client;
        }
    }
}
