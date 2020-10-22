
namespace CrewNodeLauncher.UI.Components
{
    partial class Launcher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Launcher));
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.rmPatchBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.patchBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.playBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.launcherTabs = new System.Windows.Forms.TabControl();
            this.playPanel = new System.Windows.Forms.TabPage();
            this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.launchGameBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.patchPanel = new System.Windows.Forms.TabPage();
            this.rmPatchPanel = new System.Windows.Forms.TabPage();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.launcherTabs.SuspendLayout();
            this.playPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.gunaPanel1.Controls.Add(this.rmPatchBtn);
            this.gunaPanel1.Controls.Add(this.patchBtn);
            this.gunaPanel1.Controls.Add(this.playBtn);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(864, 48);
            this.gunaPanel1.TabIndex = 0;
            // 
            // rmPatchBtn
            // 
            this.rmPatchBtn.AnimationHoverSpeed = 0.07F;
            this.rmPatchBtn.AnimationSpeed = 0.03F;
            this.rmPatchBtn.BackColor = System.Drawing.Color.Transparent;
            this.rmPatchBtn.BaseColor = System.Drawing.Color.Transparent;
            this.rmPatchBtn.BorderColor = System.Drawing.Color.Black;
            this.rmPatchBtn.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(71)))), ((int)(((byte)(92)))));
            this.rmPatchBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.rmPatchBtn.CheckedForeColor = System.Drawing.Color.White;
            this.rmPatchBtn.CheckedImage = null;
            this.rmPatchBtn.CheckedLineColor = System.Drawing.Color.Red;
            this.rmPatchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rmPatchBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.rmPatchBtn.FocusedColor = System.Drawing.Color.Empty;
            this.rmPatchBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rmPatchBtn.ForeColor = System.Drawing.Color.Gray;
            this.rmPatchBtn.Image = null;
            this.rmPatchBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.rmPatchBtn.LineBottom = 2;
            this.rmPatchBtn.LineColor = System.Drawing.Color.Transparent;
            this.rmPatchBtn.Location = new System.Drawing.Point(766, 0);
            this.rmPatchBtn.Name = "rmPatchBtn";
            this.rmPatchBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(71)))), ((int)(((byte)(92)))));
            this.rmPatchBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.rmPatchBtn.OnHoverForeColor = System.Drawing.Color.LightGray;
            this.rmPatchBtn.OnHoverImage = null;
            this.rmPatchBtn.OnHoverLineColor = System.Drawing.Color.Red;
            this.rmPatchBtn.OnPressedColor = System.Drawing.Color.Black;
            this.rmPatchBtn.Size = new System.Drawing.Size(98, 48);
            this.rmPatchBtn.TabIndex = 3;
            this.rmPatchBtn.Text = "Remove Patch";
            this.rmPatchBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rmPatchBtn.Click += new System.EventHandler(this.PanelTab_Click);
            // 
            // patchBtn
            // 
            this.patchBtn.AnimationHoverSpeed = 0.07F;
            this.patchBtn.AnimationSpeed = 0.03F;
            this.patchBtn.BackColor = System.Drawing.Color.Transparent;
            this.patchBtn.BaseColor = System.Drawing.Color.Transparent;
            this.patchBtn.BorderColor = System.Drawing.Color.Black;
            this.patchBtn.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(71)))), ((int)(((byte)(92)))));
            this.patchBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.patchBtn.CheckedForeColor = System.Drawing.Color.White;
            this.patchBtn.CheckedImage = null;
            this.patchBtn.CheckedLineColor = System.Drawing.Color.Red;
            this.patchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.patchBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.patchBtn.FocusedColor = System.Drawing.Color.Empty;
            this.patchBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.patchBtn.ForeColor = System.Drawing.Color.Gray;
            this.patchBtn.Image = null;
            this.patchBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.patchBtn.LineBottom = 2;
            this.patchBtn.LineColor = System.Drawing.Color.Transparent;
            this.patchBtn.Location = new System.Drawing.Point(72, 0);
            this.patchBtn.Name = "patchBtn";
            this.patchBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(71)))), ((int)(((byte)(92)))));
            this.patchBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.patchBtn.OnHoverForeColor = System.Drawing.Color.LightGray;
            this.patchBtn.OnHoverImage = null;
            this.patchBtn.OnHoverLineColor = System.Drawing.Color.Red;
            this.patchBtn.OnPressedColor = System.Drawing.Color.Black;
            this.patchBtn.Size = new System.Drawing.Size(107, 48);
            this.patchBtn.TabIndex = 2;
            this.patchBtn.Text = "Patch";
            this.patchBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.patchBtn.Click += new System.EventHandler(this.PanelTab_Click);
            // 
            // playBtn
            // 
            this.playBtn.AnimationHoverSpeed = 0.07F;
            this.playBtn.AnimationSpeed = 0.03F;
            this.playBtn.BackColor = System.Drawing.Color.Transparent;
            this.playBtn.BaseColor = System.Drawing.Color.Transparent;
            this.playBtn.BorderColor = System.Drawing.Color.Black;
            this.playBtn.Checked = true;
            this.playBtn.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(71)))), ((int)(((byte)(92)))));
            this.playBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.playBtn.CheckedForeColor = System.Drawing.Color.White;
            this.playBtn.CheckedImage = null;
            this.playBtn.CheckedLineColor = System.Drawing.Color.Red;
            this.playBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.playBtn.FocusedColor = System.Drawing.Color.Empty;
            this.playBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.playBtn.ForeColor = System.Drawing.Color.Gray;
            this.playBtn.Image = null;
            this.playBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.playBtn.LineBottom = 2;
            this.playBtn.LineColor = System.Drawing.Color.Transparent;
            this.playBtn.Location = new System.Drawing.Point(12, 0);
            this.playBtn.Name = "playBtn";
            this.playBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(71)))), ((int)(((byte)(92)))));
            this.playBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.playBtn.OnHoverForeColor = System.Drawing.Color.LightGray;
            this.playBtn.OnHoverImage = null;
            this.playBtn.OnHoverLineColor = System.Drawing.Color.Red;
            this.playBtn.OnPressedColor = System.Drawing.Color.Black;
            this.playBtn.Size = new System.Drawing.Size(60, 48);
            this.playBtn.TabIndex = 1;
            this.playBtn.Text = "Play";
            this.playBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.playBtn.Click += new System.EventHandler(this.PanelTab_Click);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPictureBox1.Location = new System.Drawing.Point(0, 48);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(864, 437);
            this.gunaPictureBox1.TabIndex = 1;
            this.gunaPictureBox1.TabStop = false;
            // 
            // launcherTabs
            // 
            this.launcherTabs.Controls.Add(this.playPanel);
            this.launcherTabs.Controls.Add(this.patchPanel);
            this.launcherTabs.Controls.Add(this.rmPatchPanel);
            this.launcherTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.launcherTabs.Location = new System.Drawing.Point(0, 48);
            this.launcherTabs.Name = "launcherTabs";
            this.launcherTabs.SelectedIndex = 0;
            this.launcherTabs.Size = new System.Drawing.Size(864, 437);
            this.launcherTabs.TabIndex = 2;
            // 
            // playPanel
            // 
            this.playPanel.Controls.Add(this.gunaAdvenceButton1);
            this.playPanel.Controls.Add(this.launchGameBtn);
            this.playPanel.Location = new System.Drawing.Point(4, 22);
            this.playPanel.Name = "playPanel";
            this.playPanel.Padding = new System.Windows.Forms.Padding(3);
            this.playPanel.Size = new System.Drawing.Size(856, 411);
            this.playPanel.TabIndex = 0;
            this.playPanel.Text = "Play";
            this.playPanel.UseVisualStyleBackColor = true;
            // 
            // gunaAdvenceButton1
            // 
            this.gunaAdvenceButton1.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton1.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.gunaAdvenceButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton1.CheckedImage")));
            this.gunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.gunaAdvenceButton1.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton1.Image")));
            this.gunaAdvenceButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaAdvenceButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.Location = new System.Drawing.Point(745, 360);
            this.gunaAdvenceButton1.Name = "gunaAdvenceButton1";
            this.gunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.OnHoverImage = null;
            this.gunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.Size = new System.Drawing.Size(49, 43);
            this.gunaAdvenceButton1.TabIndex = 3;
            // 
            // launchGameBtn
            // 
            this.launchGameBtn.AnimationHoverSpeed = 0.07F;
            this.launchGameBtn.AnimationSpeed = 0.03F;
            this.launchGameBtn.BaseColor = System.Drawing.Color.Green;
            this.launchGameBtn.BorderColor = System.Drawing.Color.Black;
            this.launchGameBtn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.launchGameBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.launchGameBtn.CheckedForeColor = System.Drawing.Color.White;
            this.launchGameBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("launchGameBtn.CheckedImage")));
            this.launchGameBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.launchGameBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.launchGameBtn.FocusedColor = System.Drawing.Color.Empty;
            this.launchGameBtn.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.launchGameBtn.ForeColor = System.Drawing.Color.White;
            this.launchGameBtn.Image = ((System.Drawing.Image)(resources.GetObject("launchGameBtn.Image")));
            this.launchGameBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.launchGameBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.launchGameBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.launchGameBtn.Location = new System.Drawing.Point(800, 360);
            this.launchGameBtn.Name = "launchGameBtn";
            this.launchGameBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.launchGameBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.launchGameBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.launchGameBtn.OnHoverImage = null;
            this.launchGameBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.launchGameBtn.OnPressedColor = System.Drawing.Color.Black;
            this.launchGameBtn.Size = new System.Drawing.Size(49, 43);
            this.launchGameBtn.TabIndex = 2;
            // 
            // patchPanel
            // 
            this.patchPanel.Location = new System.Drawing.Point(4, 22);
            this.patchPanel.Name = "patchPanel";
            this.patchPanel.Padding = new System.Windows.Forms.Padding(3);
            this.patchPanel.Size = new System.Drawing.Size(856, 411);
            this.patchPanel.TabIndex = 1;
            this.patchPanel.Text = "Patch";
            this.patchPanel.UseVisualStyleBackColor = true;
            // 
            // rmPatchPanel
            // 
            this.rmPatchPanel.Location = new System.Drawing.Point(4, 22);
            this.rmPatchPanel.Name = "rmPatchPanel";
            this.rmPatchPanel.Size = new System.Drawing.Size(856, 411);
            this.rmPatchPanel.TabIndex = 2;
            this.rmPatchPanel.Text = "Remove Patch";
            this.rmPatchPanel.UseVisualStyleBackColor = true;
            // 
            // Launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 485);
            this.Controls.Add(this.launcherTabs);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.gunaPanel1);
            this.Name = "Launcher";
            this.Text = "Launcher";
            this.Load += new System.EventHandler(this.Launcher_Load);
            this.gunaPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.launcherTabs.ResumeLayout(false);
            this.playPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaAdvenceButton rmPatchBtn;
        private Guna.UI.WinForms.GunaAdvenceButton patchBtn;
        private Guna.UI.WinForms.GunaAdvenceButton playBtn;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private System.Windows.Forms.TabControl launcherTabs;
        private System.Windows.Forms.TabPage playPanel;
        private System.Windows.Forms.TabPage patchPanel;
        private System.Windows.Forms.TabPage rmPatchPanel;
        private Guna.UI.WinForms.GunaAdvenceButton launchGameBtn;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;
    }
}