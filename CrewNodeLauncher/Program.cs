using CrewNodeLauncher.Utils;
using System;
using System.Windows.Forms;
using System.Threading;
using CrewNodeLauncher.Properties;
using Semver;
using System.Threading.Tasks;
using CefSharp.WinForms;
using CefSharp;
using System.IO;

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

            // Setup Cef
            var settings = new CefSettings();
            settings.BrowserSubprocessPath = Path.Combine(AppDomain.CurrentDomain.SetupInformation.ApplicationBase,
                                               Environment.Is64BitProcess ? "x64" : "x86",
                                               "CefSharp.BrowserSubprocess.exe");
            Cef.Initialize(settings, performDependencyCheck: true, browserProcessHandler: null);

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
