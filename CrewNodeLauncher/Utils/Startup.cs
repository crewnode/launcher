using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrewNodeLauncher.UI;
using CrewNodeLauncher.UI.Addons;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using CrewNodeLauncher.API;

namespace CrewNodeLauncher.Utils
{
    internal class Startup
    {
        protected static Preloader _preloader;
        protected static SystemTray _systemTray;
        protected static MainScreen _mainScreen;
        protected static Thread _loaderThread;
        protected static Thread _trayThread;
        protected static Thread _mainThread;

        public Startup ShowPreloader()
        {
            if (_preloader != null) return this;

            // Start our splash screen on a new thread
            _loaderThread = new Thread(
                new ThreadStart(() => {
                    _preloader = new Preloader();
                    Application.Run(_preloader);
                })
            );
            _loaderThread.IsBackground = true;
            _loaderThread.SetApartmentState(ApartmentState.STA);
            _loaderThread.Start();

            // Wait until the splash screen has been created
            while (_preloader == null || !_preloader.IsHandleCreated)
                Thread.Sleep(100);
            Thread.Sleep(250);
            return this;
        }

        public Startup InitialiseSystemTray()
        {
            if (_systemTray != null) return this;

            // Start our system tray on a new thread
            _trayThread = new Thread(
                new ThreadStart(() => {
                    _systemTray = new SystemTray();
                    Application.Run(_systemTray);
                }
            ));
            _trayThread.IsBackground = true;
            _trayThread.SetApartmentState(ApartmentState.STA);
            _trayThread.Start();
            SetLoaderText("System tray icon initialised");
            return this;
        }

        public Startup GetRemoteVersion()
        {
            SetLoaderText("Getting latest launcher information");
            Updater.getRemoteVersion();
            Thread.Sleep(1000);
            return this;
        }

        public Startup InitialiseAuthentication()
        {
            SetLoaderText("Verifying launcher");
            RegistryUtil.GetClientLauncherId();
            Authentication.getStatusReport();
            Thread.Sleep(200);
            return this;
        }

        public Startup InitialiseConfigFile()
        {
            SetLoaderText("Reading configuration");
            Configuration.instance();
            Thread.Sleep(100);
            return this;
        }

        private void SetLoaderText(string text)
        {
            while (_preloader == null || !_preloader.IsHandleCreated)
                Thread.Sleep(100);

            // Update text
            _preloader.Invoke((MethodInvoker)delegate () {
                _preloader.gunaLabel1.Text = text;
            });
        }

        public Startup SetupMainScreen(string[] args)
        {
            SetLoaderText("Loading CrewNode Launcher");
            _mainThread = new Thread(
                new ThreadStart(() => {
                    _mainScreen = new MainScreen(args);
                    _mainScreen.Visible = false;
                })
            );
            _mainThread.IsBackground = true;
            _mainThread.SetApartmentState(ApartmentState.STA);
            _mainThread.Start();

            // Wait until the splash screen has been created
            //while (_mainScreen == null || !_mainScreen.IsHandleCreated)
                Thread.Sleep(100);
            return this;
        }

        public Startup Finalise()
        {
            SetLoaderText("Ready!");
            _preloader.Invoke((MethodInvoker)delegate () {
                _preloader.Cursor = Cursors.Default;
                for (int i = _preloader.gunaCircleProgressBar1.Value; i <= 100; i++)
                {
                    _preloader.gunaCircleProgressBar1.Value++;
                    Thread.Sleep(5);
                    Application.DoEvents();
                }

                while (_preloader.Opacity > 0)
                {
                    _preloader.Opacity -= 0.05;
                    Thread.Sleep(5);
                    Application.DoEvents();
                }
            });

            // Hide Preloader
            Thread.Sleep(500);
            _preloader.Invoke((MethodInvoker)delegate() {
                _preloader.Close();
                _preloader = null;
            });

            // Kill preloader thread
            _loaderThread.Join();
            _loaderThread.Abort();

            // Setup Main Screen
            Application.Run(_mainScreen);
            return this;
        }
                
        public void CloseSystemTray()
        {
            if (_systemTray == null) return;
            _systemTray.Hide();
            _systemTray.ExitThread();
            _trayThread.Abort();

            // Closed before initialisation
            if (_mainScreen == null || !_mainScreen.IsHandleCreated)
                Environment.Exit(0);
        }

        public void DisplayForm()
        {
            if (_mainScreen == null) return;
            _mainScreen.Invoke((MethodInvoker)delegate ()
            {
                if (!_mainScreen.IsHandleCreated) return;
                _mainScreen.Show();
            });
        }

        public Thread GetMainThread() => _mainThread;
        public bool IsTrayRunning() => _systemTray != null;
    }
}
