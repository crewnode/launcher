using CrewNodeLauncher.Utils;
using System;
using System.Windows.Forms;
using System.Threading;
using CrewNodeLauncher.Properties;
using Semver;
using System.Threading.Tasks;

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

            // Register Protocol for "crewnode://"
            // ProtocolHandler.Register();

            // Run application
            var startup = new Startup();
            Application.ApplicationExit += (object sender, EventArgs e) => startup.CloseSystemTray();
            startup
                .ShowPreloader()
                //.InitialiseSystemTray()
                .GetRemoteVersion()
                .SetupMainScreen(args)
                .Finalise();

            // Cleanup
            startup.GetMainThread().Join();
            Environment.Exit(0);
        }
    }
}
