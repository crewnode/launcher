using FontAwesome.Sharp;
using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrewNodeLauncher.UI.Components
{
    public partial class Launcher : Form
    {
        public Launcher()
        {
            InitializeComponent();
            playBtn.Tag = "playPanel";
            patchBtn.Tag = "patchPanel";
            rmPatchBtn.Tag = "rmPatchPanel";
        }

        private void Launcher_Load(object sender, EventArgs e)
        {
            // Update TabControl
            launcherTabs.Appearance = TabAppearance.FlatButtons;
            launcherTabs.ItemSize = new Size(0, 1);
            launcherTabs.SizeMode = TabSizeMode.Fixed;

            // FontAwesome Icons
            launchGameBtn.Image = IconChar.Play.ToBitmap(Color.White);
        }

        private void PanelTab_Click(object sender, EventArgs e)
        {
            GunaAdvenceButton btn = (GunaAdvenceButton)sender;
            if (btn.Tag == null) { MessageBox.Show("no tag"); return; }
            launcherTabs.SelectTab(launcherTabs.TabPages.IndexOfKey((string)btn.Tag));

            // Reset check states
            playBtn.Checked = false;
            patchBtn.Checked = false;
            rmPatchBtn.Checked = false;
            btn.Checked = true;
        }
    }
}
