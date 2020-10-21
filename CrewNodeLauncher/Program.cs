using CrewNodeLauncher.Utils;
using System;
using System.Windows.Forms;
using System.Threading;

namespace CrewNodeLauncher
{
    static class Program
    {
        internal static bool debug = true;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Splashscreen
            if (!debug)
            {
                Startup.ShowPreloader();
                Thread.Sleep(3000);
            }
            
            // Run application
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainScreen());
        }
    }
}
