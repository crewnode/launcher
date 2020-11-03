using CrewNodeLauncher.API;
using FontAwesome.Sharp;
using Guna.UI.WinForms;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading;
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

            // Check if we've been automatically logged in
            if (Authentication.isLoggedIn()) hasLoggedIn();
        }

        private void PanelTab_Click(object sender, EventArgs e)
        {
            // Verify button tag
            GunaAdvenceButton btn = (GunaAdvenceButton)sender;
            if (btn.Tag == null) return;

            // Check if we're clicking an authenticated tab
            if (authedTabs.Contains((string)btn.Tag) && !API.Authentication.isLoggedIn())
                return;
            // Or logged in already, but attempting to authorise again
            else if (!authedTabs.Contains((string)btn.Tag) && API.Authentication.isLoggedIn())
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
            Process.Start("https://crewno.de/api/auth/" + API.Authentication.clientLauncherId);

            // Start a timer for status checks
            // TODO: Use a BackgroundWorker instead of a shitty timer
            statusCheck.Start();

            // Update UI
            loginWithDiscordBtn.Visible = false;
            authErrorLabel.Visible = false;
            authTimerLabel.Visible = true;
        }

        private int timeRunning = 0;
        private const int timeoutMax = 60 * 5;
        private void statusCheck_Tick(object sender, EventArgs e)
        {
            // Every 10th second, perform a status check
            if (timeRunning % 5 == 0)
            {
                // TODO: Status check!
                if (API.Authentication.getStatusReport())
                {
                    // Stop the timer from running to avoid it running forever
                    statusCheck.Stop();

                    // UI Update
                    hasLoggedIn();
                    return;
                }

                if (API.Authentication.requireReauth())
                {
                    // Stop the timer from running to avoid it running forever
                    statusCheck.Stop();

                    // UI Update
                    authTimerLabel.Text = "05:00 remaining for authentication";
                    authTimerLabel.Visible = false;
                    authErrorLabel.Text = "Unable to authenticate with this session identifier. Please try again.";
                    authErrorLabel.Visible = true;
                    loginWithDiscordBtn.Visible = true;
                }
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

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            // Log the user out
            if (!API.Authentication.logoutUser()) return;

            // Update UI
            authBtn.Checked = true;
            dashboardBtn.Checked = false;
            settingsBtn.Checked = false;
            loginWithDiscordBtn.Visible = true;
            authTimerLabel.Visible = false;
            authTimerLabel.Text = "05:00 remaining for authentication";
            authTabs.SelectTab(authTabs.TabPages.IndexOfKey("authPanel"));
            timeRunning = 0;
        }

        private void hasLoggedIn()
        {
            authBtn.Checked = false;
            dashboardBtn.Checked = true;
            authTabs.SelectTab(authTabs.TabPages.IndexOfKey("dashPanel"));
            usernameLabel.Text = API.Authentication.getUsername();
        }
    }
}
