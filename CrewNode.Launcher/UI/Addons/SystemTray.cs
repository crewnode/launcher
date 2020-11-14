using CrewNode.Launcher.Properties;
using CrewNode.Launcher.Utils;
using System;
using System.Windows.Forms;

namespace CrewNode.Launcher.UI.Addons
{
    public class SystemTray : ApplicationContext
    {
        private NotifyIcon trayIcon;

        public SystemTray()
        {
            trayIcon = new NotifyIcon()
            {
                Icon = Resources.CrewNodeLauncher,
                ContextMenu = new ContextMenu(new MenuItem[] {
                    new MenuItem("Exit", (object sender, EventArgs e) => Application.Exit())
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
