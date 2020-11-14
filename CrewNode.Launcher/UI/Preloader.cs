using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;

namespace CrewNode.Launcher.UI
{
    public partial class Preloader : Form
    {
        public Preloader()
        {
            InitializeComponent();
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

        private void Preloader_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
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
            headerPanel.Capture = false;
        }
        private void formDrag_MouseDown(object sender, MouseEventArgs e)
        {
            relocatingForm = true;
            headerPanel.Capture = true;
            offset = MousePosition;
            original = this.Location;
        }
    }
}
