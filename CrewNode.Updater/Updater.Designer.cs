
namespace CrewNode.Updater
{
    partial class Updater
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Updater));
            this.formDragIndicator = new Guna.UI.WinForms.GunaPictureBox();
            this.headerPanel = new Guna.UI.WinForms.GunaPanel();
            this.contentPanel = new Guna.UI.WinForms.GunaPanel();
            this.progressLbl = new Guna.UI.WinForms.GunaLabel();
            this.statusLbl = new Guna.UI.WinForms.GunaLabel();
            this.downloadProgressBar = new Guna.UI.WinForms.GunaProgressBar();
            this.upperPanel = new Guna.UI.WinForms.GunaPanel();
            this.innerFormName = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.formDragIndicator)).BeginInit();
            this.headerPanel.SuspendLayout();
            this.contentPanel.SuspendLayout();
            this.upperPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // formDragIndicator
            // 
            this.formDragIndicator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("formDragIndicator.BackgroundImage")));
            this.formDragIndicator.BaseColor = System.Drawing.Color.White;
            this.formDragIndicator.Location = new System.Drawing.Point(12, 12);
            this.formDragIndicator.Name = "formDragIndicator";
            this.formDragIndicator.Size = new System.Drawing.Size(428, 15);
            this.formDragIndicator.TabIndex = 0;
            this.formDragIndicator.TabStop = false;
            this.formDragIndicator.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formDrag_MouseDown);
            this.formDragIndicator.MouseMove += new System.Windows.Forms.MouseEventHandler(this.formDrag_MouseMove);
            this.formDragIndicator.MouseUp += new System.Windows.Forms.MouseEventHandler(this.formDrag_MouseUp);
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(71)))), ((int)(((byte)(92)))));
            this.headerPanel.Controls.Add(this.formDragIndicator);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(452, 39);
            this.headerPanel.TabIndex = 2;
            this.headerPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formDrag_MouseDown);
            this.headerPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.formDrag_MouseMove);
            this.headerPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.formDrag_MouseUp);
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.SystemColors.Control;
            this.contentPanel.Controls.Add(this.progressLbl);
            this.contentPanel.Controls.Add(this.statusLbl);
            this.contentPanel.Controls.Add(this.downloadProgressBar);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 94);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(452, 165);
            this.contentPanel.TabIndex = 4;
            // 
            // progressLbl
            // 
            this.progressLbl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.progressLbl.Location = new System.Drawing.Point(12, 81);
            this.progressLbl.Name = "progressLbl";
            this.progressLbl.Size = new System.Drawing.Size(428, 23);
            this.progressLbl.TabIndex = 6;
            this.progressLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusLbl
            // 
            this.statusLbl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.statusLbl.Location = new System.Drawing.Point(12, 58);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(428, 23);
            this.statusLbl.TabIndex = 5;
            this.statusLbl.Text = "Please wait, verifying installation.";
            this.statusLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // downloadProgressBar
            // 
            this.downloadProgressBar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.downloadProgressBar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(71)))), ((int)(((byte)(92)))));
            this.downloadProgressBar.BorderSize = 1;
            this.downloadProgressBar.ColorStyle = Guna.UI.WinForms.ColorStyle.Default;
            this.downloadProgressBar.IdleColor = System.Drawing.Color.Transparent;
            this.downloadProgressBar.Location = new System.Drawing.Point(-1, 136);
            this.downloadProgressBar.Name = "downloadProgressBar";
            this.downloadProgressBar.ProgressMaxColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(84)))), ((int)(((byte)(103)))));
            this.downloadProgressBar.ProgressMinColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.downloadProgressBar.Size = new System.Drawing.Size(454, 29);
            this.downloadProgressBar.TabIndex = 4;
            // 
            // upperPanel
            // 
            this.upperPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(81)))), ((int)(((byte)(102)))));
            this.upperPanel.Controls.Add(this.innerFormName);
            this.upperPanel.Controls.Add(this.headerPanel);
            this.upperPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.upperPanel.Location = new System.Drawing.Point(0, 0);
            this.upperPanel.Name = "upperPanel";
            this.upperPanel.Size = new System.Drawing.Size(452, 94);
            this.upperPanel.TabIndex = 3;
            this.upperPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formDrag_MouseDown);
            this.upperPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.formDrag_MouseMove);
            this.upperPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.formDrag_MouseUp);
            // 
            // innerFormName
            // 
            this.innerFormName.AutoSize = true;
            this.innerFormName.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.innerFormName.ForeColor = System.Drawing.Color.White;
            this.innerFormName.Location = new System.Drawing.Point(79, 51);
            this.innerFormName.Name = "innerFormName";
            this.innerFormName.Size = new System.Drawing.Size(295, 30);
            this.innerFormName.TabIndex = 3;
            this.innerFormName.Text = "CrewNode Launcher Updater";
            this.innerFormName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.innerFormName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formDrag_MouseDown);
            this.innerFormName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.formDrag_MouseMove);
            this.innerFormName.MouseUp += new System.Windows.Forms.MouseEventHandler(this.formDrag_MouseUp);
            // 
            // Updater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 259);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.upperPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Updater";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Updater_FormClosed);
            this.Load += new System.EventHandler(this.Updater_Load);
            ((System.ComponentModel.ISupportInitialize)(this.formDragIndicator)).EndInit();
            this.headerPanel.ResumeLayout(false);
            this.contentPanel.ResumeLayout(false);
            this.upperPanel.ResumeLayout(false);
            this.upperPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPictureBox formDragIndicator;
        private Guna.UI.WinForms.GunaPanel headerPanel;
        private Guna.UI.WinForms.GunaPanel contentPanel;
        private Guna.UI.WinForms.GunaPanel upperPanel;
        private Guna.UI.WinForms.GunaLabel innerFormName;
        private Guna.UI.WinForms.GunaProgressBar downloadProgressBar;
        private Guna.UI.WinForms.GunaLabel statusLbl;
        private Guna.UI.WinForms.GunaLabel progressLbl;
    }
}

