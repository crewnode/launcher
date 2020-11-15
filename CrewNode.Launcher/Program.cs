using CrewNode.Launcher.Utils;
using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Reflection;

namespace CrewNode.Launcher
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

            // Verify signatures
            // AppDomain.CurrentDomain.AssemblyLoad += CurrentDomain_AssemblyLoad;

            // Run application
            var startup = new Startup();
            Application.ApplicationExit += (object sender, EventArgs e) => startup.CloseSystemTray();
            startup
                .ShowPreloader()
                //.InitialiseSystemTray()
                .GetRemoteVersion()
                .InitialiseAuthentication()
                .InitialiseConfigFile()
                .SetupMainScreen(args)
                .Finalise();

            // Cleanup
            startup.GetMainThread().Join();
            Environment.Exit(0);
        }

        private static void CurrentDomain_AssemblyLoad(object sender, AssemblyLoadEventArgs args)
        {
            Assembly loadedAssembly = args.LoadedAssembly;
            if (!VerifyStrongNameSignature(loadedAssembly))
                Environment.Exit(-1);
        }

        private static bool VerifyStrongNameSignature(Assembly assembly)
        {
            byte wasVerified = 0;
            return NativeMethods.StrongNameSignatureVerificationEx(assembly.Location, 1, ref wasVerified);
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

        /// <summary>
        /// Strong Name Signature Verification
        /// </summary>
        private static class NativeMethods
        {
            [DllImport("mscoree.dll")]
            public static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string wszFilePath, byte dwInFlags, ref byte pdwOutFlags);
        }
    }
}
