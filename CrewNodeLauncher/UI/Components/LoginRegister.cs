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
    public partial class LoginRegister : Form
    {
        public LoginRegister()
        {
            InitializeComponent();
            getKeyBtn.Tag = "keyPanel";
            loginTabBtn.Tag = "loginPanel";
            registerTabBtn.Tag = "registerPanel";
        }

        private void LoginRegister_Load(object sender, EventArgs e)
        {
            // Update TabControl
            loginRegTabs.Appearance = TabAppearance.FlatButtons;
            loginRegTabs.ItemSize = new Size(0, 1);
            loginRegTabs.SizeMode = TabSizeMode.Fixed;

            // FontAwesome Icons
            confirmKeyBtn.Image = IconChar.Save.ToBitmap(Color.White);
        }

        private void PanelTab_Click(object sender, EventArgs e)
        {
            GunaAdvenceButton btn = (GunaAdvenceButton)sender;
            if (btn.Tag == null) return;
            loginRegTabs.SelectTab(loginRegTabs.TabPages.IndexOfKey((string)btn.Tag));

            // Reset check states
            getKeyBtn.Checked = false;
            loginTabBtn.Checked = false;
            registerTabBtn.Checked = false;
            btn.Checked = true;
        }
    }
}
