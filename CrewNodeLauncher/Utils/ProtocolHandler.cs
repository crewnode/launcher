using System;
using System.Windows.Forms;
using Microsoft.Win32;

namespace CrewNodeLauncher.Utils
{
    internal static class ProtocolHandler
    {
        private const string _Protocol = "crewnode";
        private const string _ProtocolHandler = "url.crewnode";

        private static readonly string _launch = string.Format(
            "{0}{1}{0} {0}%1{0}", (char)34, Application.ExecutablePath);

        private static readonly Version _win8AndAboveVersion = new Version(6, 2, 9200, 0);

        private static readonly bool _isWin8OrAbove =
            Environment.OSVersion.Platform == PlatformID.Win32NT &&
            Environment.OSVersion.Version >= _win8AndAboveVersion;

        internal static void Register()
        {
            if (_isWin8OrAbove) RegisterWin8();
            else RegisterWin7();
        }

        private static void RegisterWin7()
        {
            var regKey = Registry.ClassesRoot.CreateSubKey(_Protocol);

            regKey.CreateSubKey("DefaultIcon")
                .SetValue(null, string.Format("{0}{1},1{0}", (char)34,
                    Application.ExecutablePath));

            regKey.SetValue(null, "URL:crewnode Protocol");
            regKey.SetValue("URL Protocol", "");

            regKey = regKey.CreateSubKey(@"shell\open\command");
            regKey.SetValue(null, _launch);
        }

        private static void RegisterWin8()
        {
            //RegisterWin7();

            var regKey = Registry.CurrentUser.CreateSubKey(@"Software\Classes")
                .CreateSubKey(_ProtocolHandler);

            regKey.SetValue(null, _Protocol);

            regKey.CreateSubKey("DefaultIcon")
                 .SetValue(null, string.Format("{0}{1},1{0}", (char)34,
                     Application.ExecutablePath));

            regKey.CreateSubKey(@"shell\open\command").SetValue(null, _launch);

            Registry.CurrentUser.CreateSubKey(string.Format(
                @"Software\{0}\{1}\Capabilities\ApplicationDescription\URLAssociations",
                Application.CompanyName, Application.ProductName))
                .SetValue(_Protocol, _ProtocolHandler);

            Registry.CurrentUser.CreateSubKey(@"Software\RegisteredApplications")
                .SetValue(Application.ProductName, string.Format(
                    @"Software\{0}\Capabilities", Application.ProductName));
        }

        internal static void Unregister()
        {
            // extra work required.
            Registry.CurrentUser.CreateSubKey(@"Software\Classes")
                .DeleteSubKeyTree(_ProtocolHandler, false);

            Registry.CurrentUser.DeleteSubKeyTree(string.Format(@"Software\{0}\{1}",
                Application.CompanyName, Application.ProductName));

            Registry.CurrentUser.CreateSubKey(@"Software\RegisteredApplications")
                .DeleteValue(Application.ProductName);
        }
    }
}
