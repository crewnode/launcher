
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
            this.exitButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.minimizeButton = new Guna.UI.WinForms.GunaAdvenceButton();
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
            this.headerPanel.Controls.Add(this.exitButton);
            this.headerPanel.Controls.Add(this.minimizeButton);
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
            this.formDragIndicator.Location = new System.Drawing.Point(15, 13);
            this.formDragIndicator.Name = "formDragIndicator";
            this.formDragIndicator.Size = new System.Drawing.Size(227, 15);
            this.formDragIndicator.TabIndex = 0;
            this.formDragIndicator.TabStop = false;
            this.formDragIndicator.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formDrag_MouseDown);
            this.formDragIndicator.MouseMove += new System.Windows.Forms.MouseEventHandler(this.formDrag_MouseMove);
            this.formDragIndicator.MouseUp += new System.Windows.Forms.MouseEventHandler(this.formDrag_MouseUp);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.AnimationHoverSpeed = 0.07F;
            this.exitButton.AnimationSpeed = 0.03F;
            this.exitButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(71)))), ((int)(((byte)(92)))));
            this.exitButton.BorderColor = System.Drawing.Color.Black;
            this.exitButton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.exitButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.exitButton.CheckedForeColor = System.Drawing.Color.White;
            this.exitButton.CheckedImage = ((System.Drawing.Image)(resources.GetObject("exitButton.CheckedImage")));
            this.exitButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.exitButton.FocusedColor = System.Drawing.Color.Empty;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Image = null;
            this.exitButton.ImageSize = new System.Drawing.Size(20, 20);
            this.exitButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(71)))), ((int)(((byte)(92)))));
            this.exitButton.LineTop = 2;
            this.exitButton.Location = new System.Drawing.Point(273, 7);
            this.exitButton.Name = "exitButton";
            this.exitButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.exitButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.exitButton.OnHoverForeColor = System.Drawing.Color.White;
            this.exitButton.OnHoverImage = null;
            this.exitButton.OnHoverLineColor = System.Drawing.Color.Red;
            this.exitButton.OnPressedColor = System.Drawing.Color.Black;
            this.exitButton.Size = new System.Drawing.Size(30, 26);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "X";
            this.exitButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formDrag_MouseDown);
            this.exitButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.formDrag_MouseMove);
            this.exitButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.formDrag_MouseUp);
            // 
            // minimizeButton
            // 
            this.minimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeButton.AnimationHoverSpeed = 0.07F;
            this.minimizeButton.AnimationSpeed = 0.03F;
            this.minimizeButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(71)))), ((int)(((byte)(92)))));
            this.minimizeButton.BorderColor = System.Drawing.Color.Black;
            this.minimizeButton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.minimizeButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.minimizeButton.CheckedForeColor = System.Drawing.Color.White;
            this.minimizeButton.CheckedImage = ((System.Drawing.Image)(resources.GetObject("minimizeButton.CheckedImage")));
            this.minimizeButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.minimizeButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.minimizeButton.FocusedColor = System.Drawing.Color.Empty;
            this.minimizeButton.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold);
            this.minimizeButton.ForeColor = System.Drawing.Color.White;
            this.minimizeButton.Image = null;
            this.minimizeButton.ImageSize = new System.Drawing.Size(20, 20);
            this.minimizeButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(71)))), ((int)(((byte)(92)))));
            this.minimizeButton.LineTop = 2;
            this.minimizeButton.Location = new System.Drawing.Point(244, 7);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.minimizeButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.minimizeButton.OnHoverForeColor = System.Drawing.Color.White;
            this.minimizeButton.OnHoverImage = null;
            this.minimizeButton.OnHoverLineColor = System.Drawing.Color.Red;
            this.minimizeButton.OnPressedColor = System.Drawing.Color.Black;
            this.minimizeButton.Size = new System.Drawing.Size(30, 26);
            this.minimizeButton.TabIndex = 1;
            this.minimizeButton.Text = "_";
            this.minimizeButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formDrag_MouseDown);
            this.minimizeButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.formDrag_MouseMove);
            this.minimizeButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.formDrag_MouseUp);
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
        private Guna.UI.WinForms.GunaAdvenceButton exitButton;
        private Guna.UI.WinForms.GunaAdvenceButton minimizeButton;
        private Guna.UI.WinForms.GunaCircleProgressBar gunaCircleProgressBar1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
    }
}