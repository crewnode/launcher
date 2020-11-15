using CrewNode.Updater.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CrewNode.Updater.Utils
{
    internal class LauncherUpdateJson
    {
        private Version version;
        private Uri uri;
        private string fileName;
        private string sha;
        private string launchArgs;

        internal Version Version { get { return this.version; } }
        internal Uri Uri { get { return this.uri; } }
        internal string FileName { get { return this.fileName; } }
        internal string SHA { get { return this.sha; } }
        internal string LaunchArgs { get { return this.launchArgs; } }

        internal LauncherUpdateJson(Version _version, Uri _uri, string _fileName, string _sha, string _launchArgs)
        {
            this.version = _version;
            this.uri = _uri;
            this.fileName = _fileName;
            this.sha = _sha;
            this.launchArgs = _launchArgs;
        }

        internal bool IsNewerVersion(Version v)
        {
            return this.version > v;
        }

        internal static bool ExistsOnServer(Uri loc)
        {
            try
            {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(loc.AbsoluteUri);
                HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
                resp.Close();

                return resp.StatusCode == HttpStatusCode.OK;
            }
            catch { return false; }
        }

        internal static LauncherUpdateJson Parse(Uri location, string appId)
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    string d = client.DownloadString(location.AbsoluteUri);
                    UpdateResponse rawData = JsonConvert.DeserializeObject<UpdateResponse>(d);

                    // Check if a valid App ID exists
                    if (rawData.appId == null)
                        return null;
                    return new LauncherUpdateJson(Version.Parse(rawData.version), new Uri(rawData.versionUrl), rawData.fileName, rawData.shaHash, rawData.launchArgs);
                }
            }
            catch (Exception ex) {
                return null;
            }
        }
    }
}
