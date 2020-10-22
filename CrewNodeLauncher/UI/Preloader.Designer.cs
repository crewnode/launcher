
namespace CrewNodeLauncher.UI
{
    partial class Preloader
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Preloader));
            this.cnLauncherVersion = new Guna.UI.WinForms.GunaLabel();
            this.cnImage1 = new Guna.UI.WinForms.GunaImageButton();
            this.cnImage2 = new Guna.UI.WinForms.GunaPictureBox();
            this.upperPanel = new Guna.UI.WinForms.GunaPanel();
            this.headerPanel = new Guna.UI.WinForms.GunaPanel();
            this.formDragIndicator = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaCircleProgressBar1 = new Guna.UI.WinForms.GunaCircleProgressBar();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.cnImage2)).BeginInit();
            this.upperPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formDragIndicator)).BeginInit();
            this.SuspendLayout();
            // 
            // cnLauncherVersion
            // 
            this.cnLauncherVersion.BackColor = System.Drawing.Color.Transparent;
            this.cnLauncherVersion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cnLauncherVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(89)))), ((int)(((byte)(96)))));
            this.cnLauncherVersion.Location = new System.Drawing.Point(1, 120);
            this.cnLauncherVersion.Name = "cnLauncherVersion";
            this.cnLauncherVersion.Size = new System.Drawing.Size(307, 28);
            this.cnLauncherVersion.TabIndex = 10;
            this.cnLauncherVersion.Text = "v0.1-alpha1";
            this.cnLauncherVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cnImage1
            // 
            this.cnImage1.BackColor = System.Drawing.Color.Transparent;
            this.cnImage1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cnImage1.Image = global::CrewNodeLauncher.Properties.Resources.crewnode;
            this.cnImage1.ImageSize = new System.Drawing.Size(64, 64);
            this.cnImage1.Location = new System.Drawing.Point(47, 51);
            this.cnImage1.Name = "cnImage1";
            this.cnImage1.OnHoverImage = null;
            this.cnImage1.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.cnImage1.Size = new System.Drawing.Size(56, 77);
            this.cnImage1.TabIndex = 9;
            // 
            // cnImage2
            // 
            this.cnImage2.BackColor = System.Drawing.Color.Transparent;
            this.cnImage2.BackgroundImage = global::CrewNodeLauncher.Properties.Resources.crewnode_text;
            this.cnImage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cnImage2.BaseColor = System.Drawing.Color.White;
            this.cnImage2.Location = new System.Drawing.Point(97, 59);
            this.cnImage2.Name = "cnImage2";
            this.cnImage2.Size = new System.Drawing.Size(164, 58);
            this.cnImage2.TabIndex = 8;
            this.cnImage2.TabStop = false;
            // 
            // upperPanel
            // 
            this.upperPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.upperPanel.Controls.Add(this.cnImage1);
            this.upperPanel.Controls.Add(this.headerPanel);
            this.upperPanel.Controls.Add(this.cnLauncherVersion);
            this.upperPanel.Controls.Add(this.cnImage2);
            this.upperPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.upperPanel.Location = new System.Drawing.Point(0, 0);
            this.upperPanel.Name = "upperPanel";
            this.upperPanel.Size = new System.Drawing.Size(309, 148);
            this.upperPanel.TabIndex = 11;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(71)))), ((int)(((byte)(92)))));
            this.headerPanel.Controls.Add(this.formDragIndicator);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(309, 39);
            this.headerPanel.TabIndex = 2;
            this.headerPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formDrag_MouseDown);
            this.headerPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.formDrag_MouseMove);
            this.headerPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.formDrag_MouseUp);
            // 
            // formDragIndicator
            // 
            this.formDragIndicator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("formDragIndicator.BackgroundImage")));
            this.formDragIndicator.BaseColor = System.Drawing.Color.White;
            this.formDragIndicator.Location = new System.Drawing.Point(12, 13);
            this.formDragIndicator.Name = "formDragIndicator";
            this.formDragIndicator.Size = new System.Drawing.Size(285, 15);
            this.formDragIndicator.TabIndex = 0;
            this.formDragIndicator.TabStop = false;
            this.formDragIndicator.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formDrag_MouseDown);
            this.formDragIndicator.MouseMove += new System.Windows.Forms.MouseEventHandler(this.formDrag_MouseMove);
            this.formDragIndicator.MouseUp += new System.Windows.Forms.MouseEventHandler(this.formDrag_MouseUp);
            // 
            // gunaCircleProgressBar1
            // 
            this.gunaCircleProgressBar1.Animated = true;
            this.gunaCircleProgressBar1.AnimationSpeed = 0.6F;
            this.gunaCircleProgressBar1.BaseColor = System.Drawing.Color.White;
            this.gunaCircleProgressBar1.IdleColor = System.Drawing.Color.Gainsboro;
            this.gunaCircleProgressBar1.IdleOffset = 20;
            this.gunaCircleProgressBar1.Image = null;
            this.gunaCircleProgressBar1.ImageSize = new System.Drawing.Size(52, 52);
            this.gunaCircleProgressBar1.Location = new System.Drawing.Point(89, 186);
            this.gunaCircleProgressBar1.Name = "gunaCircleProgressBar1";
            this.gunaCircleProgressBar1.ProgressMaxColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(71)))), ((int)(((byte)(92)))));
            this.gunaCircleProgressBar1.ProgressMinColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.gunaCircleProgressBar1.ProgressOffset = 20;
            this.gunaCircleProgressBar1.Size = new System.Drawing.Size(130, 130);
            this.gunaCircleProgressBar1.TabIndex = 12;
            this.gunaCircleProgressBar1.Value = 10;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(4, 326);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(299, 23);
            this.gunaLabel1.TabIndex = 13;
            this.gunaLabel1.Text = "Initialising...";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Preloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 368);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.gunaCircleProgressBar1);
            this.Controls.Add(this.upperPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Preloader";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preloader";
            this.Load += new System.EventHandler(this.Preloader_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cnImage2)).EndInit();
            this.upperPanel.ResumeLayout(false);
            this.headerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.formDragIndicator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel cnLauncherVersion;
        private Guna.UI.WinForms.GunaImageButton cnImage1;
        private Guna.UI.WinForms.GunaPictureBox cnImage2;
        private Guna.UI.WinForms.GunaPanel upperPanel;
        private Guna.UI.WinForms.GunaPanel headerPanel;
        private Guna.UI.WinForms.GunaPictureBox formDragIndicator;
        public Guna.UI.WinForms.GunaLabel gunaLabel1;
        public Guna.UI.WinForms.GunaCircleProgressBar gunaCircleProgressBar1;
    }
}