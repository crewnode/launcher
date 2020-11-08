using CrewNodeLauncher.Utils;
using CrewNodeLauncher.Utils.Models;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;
using Guna.UI.Lib.ScrollBar;

namespace CrewNodeLauncher.UI.Addons
{
    public partial class LocalServerSelection : Form
    {
        public ConfigFile.Server selectedServer;

        public LocalServerSelection()
        {
            InitializeComponent();
        }

        private void LocalServerSelection_Load(object sender, EventArgs e)
        {
            // Load servers from configuration file
            var servers = Configuration.instance().getServers();
            foreach (ConfigFile.Server server in servers)
            {
                ServerPreview sp = new ServerPreview(server.name, server.instance);
                sp.Dock = DockStyle.Fill;
                sp.Click += (object spSender, EventArgs spEvents) => ServerPreview_Clicked(spSender, spEvents, sp, server);
                sp.label1.Click += (object spSender, EventArgs spEvents) => ServerPreview_Clicked(spSender, spEvents, sp, server);
                sp.label2.Click += (object spSender, EventArgs spEvents) => ServerPreview_Clicked(spSender, spEvents, sp, server);
                sp.BackColor = Color.Transparent;
                tableLayoutPanel1.Controls.Add(sp);
            }

            // Select the first server
            selectedServer = servers[0];
            tableLayoutPanel1.Controls[0].BackColor = Color.FromArgb(255, 100, 100, 100);

            // Clipping
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));

            // Scrollbar
            int vertScrollWidth = SystemInformation.VerticalScrollBarWidth;
            tableLayoutPanel1.Padding = new Padding(0, 0, vertScrollWidth, 0);
            PanelScrollHelper vScrollHelper = new PanelScrollHelper(tableLayoutPanel1, gunaVScrollBar1, false);
            vScrollHelper.UpdateScrollBar();
        }

        private void ServerPreview_Clicked(object sender, EventArgs e, ServerPreview sp, ConfigFile.Server server)
        {
            foreach (ServerPreview _sp in tableLayoutPanel1.Controls)
            {
                _sp.BackColor = Color.Transparent;
            }
            sp.BackColor = Color.FromArgb(255, 100, 100, 100);
            selectedServer = server;
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

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            if (this.selectedServer == null)
            {
                MessageBox.Show("Please select a server.");
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            using (LocalServerNew newServer = new LocalServerNew())
            {
                newServer.ShowDialog();
            }
        }
    }
}
