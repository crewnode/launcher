using System;
using System.Windows.Forms;
using CrewNodeLauncher.API;
using Microsoft.Win32;

namespace CrewNodeLauncher.Utils
{
    class RegistryUtil
    {
        public const string Protocol = "crewnode";

        public static bool ApplicationKeyExists()
        {
            return ((string)Registry.GetValue($"HKEY_CURRENT_USER\\Software\\{Protocol}", "LauncherId", null)) != null;
        }

        public static string GetClientLauncherId(bool generateNew = false)
        {
            string launcherId;
            if (!ApplicationKeyExists() || generateNew)
            {
                // Create our registry key
                launcherId = generateNew ? Guid.NewGuid().ToString() : Authentication.clientLauncherId;
                var regKey = Registry.CurrentUser.CreateSubKey(@"Software").CreateSubKey(Protocol);
                regKey.SetValue("LauncherId", launcherId);
                Authentication.clientLauncherId = launcherId;
                return launcherId;
            }

            launcherId = (string)Registry.GetValue($"HKEY_CURRENT_USER\\Software\\{Protocol}", "LauncherId", null);
            Authentication.clientLauncherId = launcherId;
            return launcherId;
        }

        public static void RemoveClientLauncherId()
        {
            RegistryKey regKey = Registry.CurrentUser.OpenSubKey($"Software\\{Protocol}");
            regKey.DeleteValue("LauncherId", false);
        }
    }
}
