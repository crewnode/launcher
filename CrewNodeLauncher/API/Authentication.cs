using CrewNodeLauncher.API.Models;
using CrewNodeLauncher.Utils;
using Microsoft.Win32;
using System;
using System.Net;
using System.Windows.Forms;

namespace CrewNodeLauncher.API
{
    class Authentication : Base
    {
        public static string clientLauncherId = Guid.NewGuid().ToString();
        private static bool isAuthenticated = false;
        private static bool userForcedLogout = false;
        private static bool userNeedsReauthentication = false;
        private static Base b = new Base();
        private static UserAuth user;

        public static bool getStatusReport()
        {
            bool isLoggedIn = false;
            dynamic currentStatus = b.queryApi($"/status/{clientLauncherId}");
            if (currentStatus.GetCode() == ((int)HttpStatusCode.OK))
            {
                isLoggedIn = true;
                user = currentStatus.ToUserAuth();
            }
            else if (currentStatus.GetCode() == ((int)HttpStatusCode.Forbidden))
                Authentication.requireReauth(true);

            // Update status and report back
            isAuthenticated = isLoggedIn;
            return isLoggedIn;
        }

        public static bool requireReauth(bool update = false)
        {
            if (!userNeedsReauthentication && update)
            {
                userNeedsReauthentication = true;
                RegistryUtil.GetClientLauncherId(true);
                Authentication.logoutUser();
                return true;
            }
            return userNeedsReauthentication;
        }

        public static bool isLoggedIn()
        {
            return isAuthenticated;
        }

        public static string getUsername()
        {
            if (!isAuthenticated) return null;
            return $"{user.discord.username}#{user.discord.discriminator}";
        }

        public static bool logoutUser()
        {
            if (!isAuthenticated) return false;
            // TODO: Send removal of authentication to server
            RegistryUtil.RemoveClientLauncherId();
            isAuthenticated = false;
            userForcedLogout = true;
            clientLauncherId = Guid.NewGuid().ToString();
            return true;
        }

        public static bool hasLoggedOut()
        {
            if (userForcedLogout)
            {
                userForcedLogout = false;
                return true;
            }
            return false;
        }
    }
}
