
namespace CrewNode.Launcher.UI.Components
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
            this.welcomeLabel = new Guna.UI.WinForms.GunaLabel();
            this.settingsBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaLabel1 = new CrewNode.LabelX();
            this.upperPanel = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.updateDescriptionLbl = new Guna.UI.WinForms.GunaLabel();
            this.upperPanel.SuspendLayout();
            this.gunaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.welcomeLabel.ForeColor = System.Drawing.Color.White;
            this.welcomeLabel.Location = new System.Drawing.Point(14, 13);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(776, 31);
            this.welcomeLabel.TabIndex = 7;
            this.welcomeLabel.Text = "There is an update available!";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // settingsBtn
            // 
            this.settingsBtn.AnimationHoverSpeed = 0.07F;
            this.settingsBtn.AnimationSpeed = 0.03F;
            this.settingsBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.settingsBtn.BorderColor = System.Drawing.Color.Black;
            this.settingsBtn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.settingsBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.settingsBtn.CheckedForeColor = System.Drawing.Color.White;
            this.settingsBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("settingsBtn.CheckedImage")));
            this.settingsBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.settingsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.settingsBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.settingsBtn.FocusedColor = System.Drawing.Color.Empty;
            this.settingsBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.settingsBtn.ForeColor = System.Drawing.Color.White;
            this.settingsBtn.Image = null;
            this.settingsBtn.ImageOffsetX = 7;
            this.settingsBtn.ImageSize = new System.Drawing.Size(22, 22);
            this.settingsBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(81)))), ((int)(((byte)(102)))));
            this.settingsBtn.LineTop = 2;
            this.settingsBtn.Location = new System.Drawing.Point(0, 423);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(24)))), ((int)(((byte)(36)))));
            this.settingsBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.settingsBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.settingsBtn.OnHoverImage = null;
            this.settingsBtn.OnHoverLineColor = System.Drawing.Color.Red;
            this.settingsBtn.OnPressedColor = System.Drawing.Color.Black;
            this.settingsBtn.Size = new System.Drawing.Size(889, 59);
            this.settingsBtn.TabIndex = 24;
            this.settingsBtn.Text = "Update Launcher";
            this.settingsBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(18, 46);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(411, 15);
            this.gunaLabel1.TabIndex = 25;
            this.gunaLabel1.Text = "This latest version will update your client from {{ localVer }} to {{ remoteVer }" +
    "}.";
            // 
            // upperPanel
            // 
            this.upperPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(61)))), ((int)(((byte)(82)))));
            this.upperPanel.Controls.Add(this.welcomeLabel);
            this.upperPanel.Controls.Add(this.gunaLabel1);
            this.upperPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.upperPanel.Location = new System.Drawing.Point(0, 0);
            this.upperPanel.Name = "upperPanel";
            this.upperPanel.Size = new System.Drawing.Size(889, 77);
            this.upperPanel.TabIndex = 27;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.updateDescriptionLbl);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 77);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(889, 346);
            this.gunaPanel1.TabIndex = 30;
            // 
            // updateDescriptionLbl
            // 
            this.updateDescriptionLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updateDescriptionLbl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.updateDescriptionLbl.Location = new System.Drawing.Point(0, 0);
            this.updateDescriptionLbl.Name = "updateDescriptionLbl";
            this.updateDescriptionLbl.Padding = new System.Windows.Forms.Padding(10);
            this.updateDescriptionLbl.Size = new System.Drawing.Size(889, 346);
            this.updateDescriptionLbl.TabIndex = 0;
            this.updateDescriptionLbl.Text = "Fetching update details...";
            // 
            // Updater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(889, 482);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.upperPanel);
            this.Controls.Add(this.settingsBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Updater";
            this.Text = "Updater";
            this.Load += new System.EventHandler(this.Updater_Load);
            this.upperPanel.ResumeLayout(false);
            this.upperPanel.PerformLayout();
            this.gunaPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaLabel welcomeLabel;
        private Guna.UI.WinForms.GunaAdvenceButton settingsBtn;
        private LabelX gunaLabel1;
        private Guna.UI.WinForms.GunaPanel upperPanel;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaLabel updateDescriptionLbl;
    }
}