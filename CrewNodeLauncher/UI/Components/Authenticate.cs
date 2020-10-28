using FontAwesome.Sharp;
using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrewNodeLauncher.UI.Components
{
    public partial class Authenticate : Form
    {
        private static string[] authedTabs = new string[]
        {
            "dashPanel",
            "accountPanel"
        };

        public Authenticate()
        {
            InitializeComponent();
            authBtn.Tag = "keyPanel";
            dashboardBtn.Tag = "dashPanel";
            settingsBtn.Tag = "accountPanel";
        }

        private void Authenticate_Load(object sender, EventArgs e)
        {
            // Update TabControl
            authTabs.Appearance = TabAppearance.FlatButtons;
            authTabs.ItemSize = new Size(0, 1);
            authTabs.SizeMode = TabSizeMode.Fixed;

            // FontAwesome Icons
            loginWithDiscordBtn.Image = IconChar.Save.ToBitmap(Color.White);
        }

        private void PanelTab_Click(object sender, EventArgs e)
        {
            // Verify button tag
            GunaAdvenceButton btn = (GunaAdvenceButton)sender;
            if (btn.Tag == null) return;

            // Check if we're clicking an authenticated tab
            if (authedTabs.Contains((string)btn.Tag) && !API.Authentication.isAuthenticated)
                return;

            // Select our new tab from the selected button tag
            authTabs.SelectTab(authTabs.TabPages.IndexOfKey((string)btn.Tag));

            // Reset check states
            authBtn.Checked = false;
            settingsBtn.Checked = false;
            dashboardBtn.Checked = false;
            btn.Checked = true;
        }

        private void loginWithDiscordBtn_Click(object sender, EventArgs e)
        {
            // Generate a UUID
            string clientLauncherId = Guid.NewGuid().ToString();
            Process.Start("https://crewno.de/api/launcher/auth/" + clientLauncherId);

            // Start a timer for status checks
            // TODO: Use a BackgroundWorker instead of a shitty timer
            statusCheck.Start();

            // Update UI
            loginWithDiscordBtn.Visible = false;
            authTimerLabel.Visible = true;
        }

        private int timeRunning = 0;
        private const int timeoutMax = 60 * 5;
        private void statusCheck_Tick(object sender, EventArgs e)
        {
            // Every 10th second, perform a status check
            if (timeRunning % 10 == 0)
            {
                // TODO: Status check!
            }

            // Check if we have gone below our timeout
            if (timeoutMax - timeRunning < 0)
            {
                loginWithDiscordBtn.Visible = true;
                authTimerLabel.Visible = false;
                authTimerLabel.Text = "05:00 remaining for authentication";
                statusCheck.Stop();
                return;
            }

            // Get remaining time
            TimeSpan ts = TimeSpan.FromSeconds(timeoutMax - timeRunning);
            string timeLeft = ts.ToString(@"mm\:ss");

            // Update UI
            timeRunning++;
            authTimerLabel.Text = timeLeft + " remaining for authentication";
        }
    }
}
