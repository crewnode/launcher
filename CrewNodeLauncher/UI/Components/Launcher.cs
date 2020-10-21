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
        }

        private void tile_Click(object sender, EventArgs e)
        {
            GunaTileButton gtb = (GunaTileButton)sender;
            gtb.BaseColor = Color.Red;
        }
    }
}
