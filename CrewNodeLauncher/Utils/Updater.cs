using Semver;
using System.Diagnostics;
using System.Net;
using System.Windows.Forms;

namespace CrewNodeLauncher.Utils
{
    static class Updater
    {
        private static SemVersion _localVersion;
        private static SemVersion _remoteVersion;

        public static bool runUpdate()
        {
            // TODO
            return false;
        }

        public static SemVersion getRemoteVersion()
        {
            if (_remoteVersion != null) return _remoteVersion;

            // Get the latest remote version
            WebClient client = new WebClient();
            try
            {
                var version = client.DownloadString("https://crewnode.net/version");
                SemVersion.TryParse(version, out _remoteVersion);
                if (_remoteVersion == null) return (_remoteVersion = new SemVersion(0, 0, 0, "unknown", "error"));
            }
            catch
            {
                _remoteVersion = new SemVersion(0, 0, 0, "unknown", "error");
            }
            return _remoteVersion;
        }

        public static SemVersion getLocalVersion()
        {
            if (_localVersion != null) return _localVersion;
            return (_localVersion = new SemVersion(0, 0, 1, "alpha1"));
        }

        public static bool isUpdateAvailable()
        {
            return SemVersion.Compare(getLocalVersion(), getRemoteVersion()) == -1;
        }
    }
}
