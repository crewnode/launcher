using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Net;
using Newtonsoft.Json;
using CrewNodeLauncher.API.Models;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CrewNodeLauncher.API
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

        public static string getBuildVersion(string commitHash)
        {
            WebClient client = new WebClient();
            try
            {
                string rawData = client.DownloadString($"https://raw.githubusercontent.com/Impostor/Impostor/{commitHash}/appveyor.yml");

                // Find the "IMPOSTOR_VERSION" env var
                Match m = Regex.Match(rawData, @"^  IMPOSTOR_VERSION\: \'\d.\d.\d\'", RegexOptions.Multiline);
                if (m.Success)
                {
                    string v = m.Value;
                    int firstQuote = v.IndexOf("'");
                    int lastQuote = v.LastIndexOf("'");
                    client.Dispose();
                    return v.Substring(firstQuote + 1, (lastQuote - firstQuote) - 1);
                }
            } catch { }

            client.Dispose();
            return "";
        }

        public static string getBuildDownload(AppComboBoxItem build)
        {
            string buildVersion = getBuildVersion(build.Build.commitId);
            return $"https://ci.appveyor.com/api/projects/Impostor/Impostor/artifacts?fileName=build%2FImpostor-Server_{buildVersion}-ci.{build.Build.buildNumber}_win-x64.zip";
        }

        //public static string getLastJobId()
        //{
        //    WebClient client = new WebClient();
        //    client.Headers.Set("Content-Type", "application/json");
        //    try
        //    {
        //        //string url = "https://ci.appveyor.com/api/projects/Impostor/Impostor/artifacts?fileName=build%2FImpostor-Server_1.2.2-ci.97_win-x64.zip";
        //        string rawData = client.DownloadString(lastJobUrl);
        //        BuildJob.Item rawJob = JsonConvert.DeserializeObject<BuildJob.Item>(rawData);
        //        client.Dispose();
        //        return rawJob.build.jobs[0].jobId;
        //    } catch { }
        //    client.Dispose();
        //    return "";
        //}

        //public static List<BuildArtifact> getLastJobArtifacts()
        //{
        //    WebClient client = new WebClient();
        //    client.Headers.Set("Content-Type", "application/json");
        //    try
        //    {
        //        string rawData = client.DownloadString("https://ci.appveyor.com/api/buildjobs/" + getLastJobId() + "/artifacts");
        //        List<BuildArtifact> rawArtifacts = JsonConvert.DeserializeObject<List<BuildArtifact>>(rawData);
        //        client.Dispose();
        //        return rawArtifacts;
        //    }
        //    catch { }
        //    client.Dispose();
        //    return new List<BuildArtifact>();
        //}
    }
}
