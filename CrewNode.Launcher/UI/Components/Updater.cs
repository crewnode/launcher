using CrewNode.Updater;
using Guna.UI.Lib.ScrollBar;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CrewNode.Launcher.UI.Components
{
    public partial class Updater : Form
    {
        private MainScreen _m;

        public Updater(MainScreen m)
        {
            InitializeComponent();
            this._m = m;
        }

        private void Updater_Load(object sender, EventArgs e)
        {
            string localVer = Utils.Updater.getLocalVersion().ToString();
            string remoteVer = Utils.Updater.getRemoteVersion().ToString();
            gunaLabel1.Text = gunaLabel1.Text.Replace("{{ localVer }}", localVer).Replace("{{ remoteVer }}", remoteVer);
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            // Lets darken the rest of the app.. with a fucking screenshot
            Bitmap img = new Bitmap(this._m.ClientRectangle.Width, this._m.ClientRectangle.Height);
            using (Graphics g = Graphics.FromImage(img))
            {
                g.CompositingMode = CompositingMode.SourceOver;
                g.CopyFromScreen(this._m.PointToScreen(new Point(0, 0)), new Point(0, 0), this._m.ClientRectangle.Size);
                double alpha = 0.65;
                Color dark = Color.FromArgb((int)(255 * alpha), Color.Black);
                using (Brush b = new SolidBrush(dark))
                    g.FillRectangle(b, this._m.ClientRectangle);
            }

            // Create our temporary "darken" panel
            Panel p = new Panel();
            p.Location = new Point(0, 0);
            p.Size = this._m.ClientRectangle.Size;
            p.BackgroundImage = img;
            this._m.Controls.Add(p);
            p.BringToFront();

            // Display our updater dialog
            LauncherUpdater updater = new CrewNode.Updater.LauncherUpdater(this._m);
            updater.DoUpdate();
        }
    }
}
