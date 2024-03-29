﻿using CrewNode.Launcher.UI.Addons;
using CrewNode.Launcher.Utils;
using CrewNode.Launcher.Utils.Models;
using FontAwesome.Sharp;
using Guna.UI.Lib.ScrollBar;
using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Threading;
using System.Windows.Forms;

namespace CrewNode.Launcher
{
    public partial class MainScreen : Form, CrewNode.Updater.Utils.ILauncherUpdateable
    {
        // Updateable fields
        public string LauncherIdentifier { get { return "CrewNodeLauncher"; } }
        public Assembly LauncherAssembly { get { return Assembly.GetExecutingAssembly(); } }
        public System.Drawing.Icon LauncherIcon { get { return this.Icon; } }
        public Uri LauncherJson { get { return new Uri("https://crewnode.net/api/get/loader"); } }
        public Form LauncherUpdaterContext { get { return this; } }
        private Updater.LauncherUpdater updater;

        // MainScreen Form
        public MainScreen(string[] args)
        {
            InitializeComponent();
            Thread.Sleep(500);
            updater = new CrewNode.Updater.LauncherUpdater(this);
            updater.DoUpdate();



            if (args.Length > 0)
            {
                // TODO: Parse the arguments
                // Such as "--patch", or "--join <gameid>"
            }
        }

        PanelScrollHelper vScrollHelper;
        PanelScrollHelper hScrollHelper;
        private void MainScreen_Load(object sender, EventArgs e)
        {
            // Close splashscreen
            this.Activate();
            this.Show();
            this.BringToFront();

            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(navPanel, Color.Black, 40, 20, VerHorAlign.VerticalRight);
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(launcherBtn, Color.Black, 40, 20, VerHorAlign.VerticalRight);
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(pluginsBtn, Color.Black, 40, 20, VerHorAlign.VerticalRight);
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(leaderboardBtn, Color.Black, 40, 20, VerHorAlign.VerticalRight);
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(newsBtn, Color.Black, 40, 20, VerHorAlign.VerticalRight);
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));

            // Set icons
            launcherBtn.Image = IconChar.Home.ToBitmap(Color.White);
            pluginsBtn.Image = IconChar.Plug.ToBitmap(Color.White);
            leaderboardBtn.Image = IconChar.ChartBar.ToBitmap(Color.White);
            newsBtn.Image = IconChar.Newspaper.ToBitmap(Color.White);
            localServerBtn.Image = IconChar.Server.ToBitmap(Color.White);
            settingsBtn.Image = IconChar.Cogs.ToBitmap(Color.White);
            loginBtn.Image = IconChar.User.ToBitmap(Color.White);
            updateAvailableBtn.Image = IconChar.Download.ToBitmap(Color.White);

            // Get version
            cnLauncherVersion.Text = $"v{Utils.Updater.getLocalVersion()}";

            // Check for available update
            if (Utils.Updater.isUpdateAvailable())
            {
                updateAvailableBtn.Visible = true;
                loginBtn.Location = new Point(loginBtn.Location.X, loginBtn.Location.Y - updateAvailableBtn.Height);
            }

            // Setup content panel
            vScrollHelper = new PanelScrollHelper(contentPanel, gunaVScrollBar1, true);
            hScrollHelper = new PanelScrollHelper(contentPanel, gunaHScrollBar1, true);
            vScrollHelper.UpdateScrollBar();
            hScrollHelper.UpdateScrollBar();

            // Setup navigation handler
            this.setupNavigation();

            // Run workers
            authenticationWorker.RunWorkerAsync();
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );


        private void closeButton_Click(object sender, EventArgs e)
        {
            if ((new Startup()).IsTrayRunning()) Hide();
            else Application.Exit();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private bool relocatingForm = false;
        private Point offset, original;
        private void formDrag_MouseMove(object sender, MouseEventArgs e)
        {
            if (!relocatingForm) return;
            this.Location = new Point(
                original.X + MousePosition.X - offset.X,
                original.Y + MousePosition.Y - offset.Y
            );
        }

        private void formDrag_MouseUp(object sender, MouseEventArgs e)
        {
            relocatingForm = false;
            upperPanel.Capture = false;
        }
        private void formDrag_MouseDown(object sender, MouseEventArgs e)
        {
            relocatingForm = true;
            upperPanel.Capture = true;
            offset = MousePosition;
            original = this.Location;
        }

        private List<GunaAdvenceButton> navItems;
        private List<Form> navForms;
        private void setupNavigation()
        {
            navItems = new List<GunaAdvenceButton>()
            {
                launcherBtn,
                pluginsBtn,
                loginBtn,
                leaderboardBtn,
                newsBtn,
                localServerBtn,
                settingsBtn
            };

            navForms = new List<Form>()
            {
                new UI.Components.Launcher(),
                null,
                new UI.Components.Authenticate(),
                null,
                null,
                new UI.Components.LocalServer(),
                null
            };

            int i = 0;
            foreach (Form f in navForms)
            {
                if (f == null)
                {
                    i++;
                    continue;
                }

                f.TopLevel = false;
                f.FormBorderStyle = FormBorderStyle.None;
                f.BackColor = BackColor;
                f.Tag = i;
                navItems[i].Controls.Add(f);
                i++;
            }

            updateSelectedNav(navItems[0]);
        }

        private void updateSelectedNav(GunaAdvenceButton newSelection)
        {
            foreach (GunaAdvenceButton btn in navItems)
            {
                btn.BaseColor = Color.FromArgb(27, 38, 49);
                btn.LineColor = Color.FromArgb(56, 81, 102);
            }
            newSelection.BaseColor = Color.FromArgb(14, 24, 36);
            newSelection.LineColor = Color.Red;
            innerFormName.Text = newSelection.Text;

            // Reassign the controls back to their navigation item
            reassignControls();

            // Find our buttons form
            if (newSelection.Controls.Count > 0) {
                foreach (Control c in newSelection.Controls)
                {
                    c.Show();
                    contentPanel.Controls.Add(c);
                }
            }
            else
            {
                UI.Components.NotYetAdded notYetAdded = new UI.Components.NotYetAdded()
                    {
                        TopLevel = false,
                        Visible = true,
                        FormBorderStyle = FormBorderStyle.None,
                        BackColor = BackColor,
                        Anchor = AnchorStyles.None
                    };
                notYetAdded.gunaLabel1.Text = newSelection.Text + " is not yet available.";
                notYetAdded.Location = new Point((contentPanel.Width - notYetAdded.Width) / 2, (contentPanel.Height - notYetAdded.Height) / 2);
                contentPanel.Controls.Add(notYetAdded);
            }
        }

        private void reassignControls()
        {

            // Reassign the controls back to their navigation item
            foreach (Control c in contentPanel.Controls)
            {
                if (c.Tag is null)
                {
                    contentPanel.Controls.Remove(c);
                    continue;
                }
                c.Hide();
                navItems[(int)c.Tag].Controls.Add(c);
            }
        }

        private void launcherBtn_Click(object sender, EventArgs e)
        {
            updateSelectedNav((GunaAdvenceButton)sender);
        }

        private void pluginsBtn_Click(object sender, EventArgs e)
        {
            updateSelectedNav((GunaAdvenceButton)sender);
        }

        private void leaderboardBtn_Click(object sender, EventArgs e)
        {
            updateSelectedNav((GunaAdvenceButton)sender);
        }

        private void newsBtn_Click(object sender, EventArgs e)
        {
            updateSelectedNav((GunaAdvenceButton)sender);
        }

        ConfigFile.Server _selectedServer;
        private void localServerBtn_Click(object sender, EventArgs e)
        {
            if (_selectedServer != null)
            {
                updateSelectedNav((GunaAdvenceButton)sender);
                return;
            }

            using (LocalServerSelection selector = new LocalServerSelection())
            {
                Bitmap img = new Bitmap(this.ClientRectangle.Width, this.ClientRectangle.Height);
                using (Graphics g = Graphics.FromImage(img))
                {
                    g.CompositingMode = CompositingMode.SourceOver;
                    g.CopyFromScreen(this.PointToScreen(new Point(0, 0)), new Point(0, 0), this.ClientRectangle.Size);
                    double alpha = 0.65;
                    Color dark = Color.FromArgb((int)(255 * alpha), Color.Black);
                    using (Brush b = new SolidBrush(dark))
                        g.FillRectangle(b, this.ClientRectangle);
                }

                // Create our temporary "darken" panel
                using (Panel p = new Panel())
                {
                    p.Location = new Point(0, 0);
                    p.Size = this.ClientRectangle.Size;
                    p.BackgroundImage = img;
                    this.Controls.Add(p);
                    p.BringToFront();

                    // Disable server seletor
                    selector.ShowDialog();
                    if (selector.DialogResult == DialogResult.Cancel || selector.selectedServer == null)
                    {
                        return;
                    }

                    _selectedServer = selector.selectedServer;
                    localServerBtn.Text = $"Local Server ({_selectedServer.name})";
                    updateSelectedNav((GunaAdvenceButton)sender);
                }
            }
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            updateSelectedNav((GunaAdvenceButton)sender);
        }

        private void contentPanel_Resize(object sender, EventArgs e)
        {
            if (hScrollHelper != null) hScrollHelper.UpdateScrollBar();
            if (vScrollHelper != null) vScrollHelper.UpdateScrollBar();
        }

        private void updateAvailableBtn_Click(object sender, EventArgs e)
        {
            reassignControls();
            UI.Components.Updater notYetAdded = new UI.Components.Updater(this)
            {
                TopLevel = false,
                Visible = true,
                FormBorderStyle = FormBorderStyle.None,
                BackColor = BackColor,
                Anchor = AnchorStyles.None
            };
            notYetAdded.Location = new Point((contentPanel.Width - notYetAdded.Width) / 2, (contentPanel.Height - notYetAdded.Height) / 2);
            contentPanel.Controls.Add(notYetAdded);
        }

        private void loginRegisterBtn_Click(object sender, EventArgs e)
        {
            updateSelectedNav((GunaAdvenceButton)sender);
            innerFormName.Text = "Authenticate";
        }

        public static bool IsAdministrator =>
           new WindowsPrincipal(WindowsIdentity.GetCurrent())
               .IsInRole(WindowsBuiltInRole.Administrator);

        private enum authStates {
            USER_LOGGED_IN,
            USER_LOGGED_OUT,
        };

        private void authenticationWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = (BackgroundWorker)sender;
            while (!worker.CancellationPending)
            {
                // We don't want our worker running every interval, so we'll sleep here
                // NOTE: If any of the below calls require an API request, up this sleep
                Thread.Sleep(100);

                // Check our status
                if (API.Authentication.isLoggedIn())
                    worker.ReportProgress(0, authStates.USER_LOGGED_IN);

                if (API.Authentication.hasLoggedOut())
                    worker.ReportProgress(0, authStates.USER_LOGGED_OUT);
            }
        }

        private void authenticationWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            switch (e.UserState)
            {
                case authStates.USER_LOGGED_IN:
                    loginBtn.Text = API.Authentication.getUsername();
                    break;

                case authStates.USER_LOGGED_OUT:
                    loginBtn.Text = "Login";
                    break;
            }
        }

        private void MainScreen_Leave(object sender, EventArgs e)
        {
        }

        private void MainScreen_Enter(object sender, EventArgs e)
        {
        }

        private void contentPanel_ControlChanged(object sender, ControlEventArgs e)
        {
            if (hScrollHelper != null) hScrollHelper.UpdateScrollBar();
            if (vScrollHelper != null) vScrollHelper.UpdateScrollBar();
        }
    }
}
