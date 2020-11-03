using CrewNodeLauncher.Utils;
using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CrewNodeLauncher
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            // Initialise
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Support 4K Monitors
            SetProcessDpiAwareness((int)DpiAwareness.SystemAware);

            // Register Protocol for "crewnode://"
            // ProtocolHandler.Register();

            // Run application
            var startup = new Startup();
            Application.ApplicationExit += (object sender, EventArgs e) => startup.CloseSystemTray();
            startup
                .ShowPreloader()
                //.InitialiseSystemTray()
                .GetRemoteVersion()
                .InitialiseAuthentication()
                .SetupMainScreen(args)
                .Finalise();

            // Cleanup
            startup.GetMainThread().Join();
            Environment.Exit(0);
        }

        [DllImport("Shcore.dll")]
        static extern int SetProcessDpiAwareness(int PROCESS_DPI_AWARENESS);

        // According to https://msdn.microsoft.com/en-us/library/windows/desktop/dn280512(v=vs.85).aspx
        private enum DpiAwareness
        {
            None = 0,
            SystemAware = 1,
            PerMonitorAware = 2
        }
    }
}
