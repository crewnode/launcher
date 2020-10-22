using CrewNodeLauncher.Properties;
using CrewNodeLauncher.Utils;
using System;
using System.Windows.Forms;

namespace CrewNodeLauncher.UI.Addons
{
    public class SystemTray : ApplicationContext
    {
        private NotifyIcon trayIcon;

        public SystemTray()
        {
            trayIcon = new NotifyIcon()
            {
                Icon = Resources.CrewNodeLauncher,
                ContextMenu = new ContextMenu(new MenuItem[]
                {
                        new MenuItem("Exit", (object sender, EventArgs e) => Environment.Exit(0))
                }),
                Visible = true,
                Text = Application.CompanyName,
                BalloonTipTitle = Application.CompanyName
            };

            trayIcon.Click += (object sender, EventArgs e) => (new Startup()).DisplayForm();
        }

        public void Hide()
        {
            trayIcon.Dispose();
        }
    }
}
