using System;

namespace CrewNodeLauncher.API
{
    static class Authentication
    {
        public static string clientLauncherId = Guid.NewGuid().ToString();
        private static bool isAuthenticated = false;
        private static bool userForcedLogout = false;

        public static bool getStatusReport()
        {
            bool isLoggedIn = true;
            // TODO: Get response from /api/launcher/status/{clientLauncherId}
            // TODO: (If logged in) Emit some kind of global event, so that the MainScreen GUI can update...?

            // Update status and report back
            isAuthenticated = isLoggedIn;
            return isLoggedIn;
        }

        public static bool isLoggedIn()
        {
            return isAuthenticated;
        }

        public static string getUsername()
        {
            if (!isAuthenticated) return null;
            // TODO: Get username
            return "Simple";
        }

        public static bool logoutUser()
        {
            if (!isAuthenticated) return false;
            // TODO: Send removal of authentication to server
            // TODO: Remove registry key from system
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
