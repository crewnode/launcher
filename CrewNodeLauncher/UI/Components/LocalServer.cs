using CrewNodeLauncher.API;
using CrewNodeLauncher.API.Models;
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
    public partial class LocalServer : Form
    {
        public LocalServer()
        {
            InitializeComponent();
        }

        private void LocalServer_Load(object sender, EventArgs e)
        {
            // Set icons
            githubBtn.BackgroundImage = IconChar.Github.ToBitmap(Color.White);
            branchImg.BackgroundImage = IconChar.CodeBranch.ToBitmap(Color.White);

            // Get AppVeyor builds
            List< AppComboBoxItem> builds = AppVeyor.getImpostorBuilds();
            foreach (AppComboBoxItem b in builds)
            {
                impostorVersionsCombo.Items.Add(b);
            }
        }

        private void githubBtn_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Impostor/Impostor");
        }

        private void downloadBtn_Click(object sender, EventArgs e)
        {
            AppComboBoxItem buildItem = (AppComboBoxItem)impostorVersionsCombo.SelectedItem;
            Process.Start(AppVeyor.getBuildDownload(buildItem));
        }
    }
}
