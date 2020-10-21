using Semver;
using System.Diagnostics;

namespace CrewNodeLauncher.Utils
{
    static class Updater
    {
        public static bool runUpdate()
        {
            // TODO
            return false;
        }


        public static SemVersion getRemoteVersion()
        {
            return new SemVersion(0, 0, 2, "unknown");
        }

        public static SemVersion getLocalVersion()
        {
            return new SemVersion(0, 0, 1, "alpha1");
        }

        public static bool isUpdateAvailable()
        {
            return SemVersion.Compare(getLocalVersion(), getRemoteVersion()) == -1;
        }
    }
}
