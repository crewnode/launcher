
namespace CrewNodeLauncher.UI.Components
{
    partial class Authenticate
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authenticate));
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.settingsBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.dashboardBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.authBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.authTabs = new System.Windows.Forms.TabControl();
            this.authPanel = new System.Windows.Forms.TabPage();
            this.loginWithDiscordBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.dashPanel = new System.Windows.Forms.TabPage();
            this.accountPanel = new System.Windows.Forms.TabPage();
            this.statusCheck = new System.Windows.Forms.Timer(this.components);
            this.authTimerLabel = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel1.SuspendLayout();
            this.authTabs.SuspendLayout();
            this.authPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.gunaPanel1.Controls.Add(this.settingsBtn);
            this.gunaPanel1.Controls.Add(this.dashboardBtn);
            this.gunaPanel1.Controls.Add(this.authBtn);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1726, 92);
            this.gunaPanel1.TabIndex = 3;
            // 
            // settingsBtn
            // 
            this.settingsBtn.AnimationHoverSpeed = 0.07F;
            this.settingsBtn.AnimationSpeed = 0.03F;
            this.settingsBtn.BackColor = System.Drawing.Color.Transparent;
            this.settingsBtn.BaseColor = System.Drawing.Color.Transparent;
            this.settingsBtn.BorderColor = System.Drawing.Color.Black;
            this.settingsBtn.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(71)))), ((int)(((byte)(92)))));
            this.settingsBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.settingsBtn.CheckedForeColor = System.Drawing.Color.White;
            this.settingsBtn.CheckedImage = null;
            this.settingsBtn.CheckedLineColor = System.Drawing.Color.Red;
            this.settingsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.settingsBtn.FocusedColor = System.Drawing.Color.Empty;
            this.settingsBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.settingsBtn.ForeColor = System.Drawing.Color.Gray;
            this.settingsBtn.Image = null;
            this.settingsBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.settingsBtn.LineBottom = 2;
            this.settingsBtn.LineColor = System.Drawing.Color.Transparent;
            this.settingsBtn.Location = new System.Drawing.Point(159, 0);
            this.settingsBtn.Margin = new System.Windows.Forms.Padding(6);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(71)))), ((int)(((byte)(92)))));
            this.settingsBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.settingsBtn.OnHoverForeColor = System.Drawing.Color.LightGray;
            this.settingsBtn.OnHoverImage = null;
            this.settingsBtn.OnHoverLineColor = System.Drawing.Color.Red;
            this.settingsBtn.OnPressedColor = System.Drawing.Color.Black;
            this.settingsBtn.Size = new System.Drawing.Size(126, 92);
            this.settingsBtn.TabIndex = 7;
            this.settingsBtn.Text = "Settings";
            this.settingsBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.settingsBtn.Click += new System.EventHandler(this.PanelTab_Click);
            // 
            // dashboardBtn
            // 
            this.dashboardBtn.AnimationHoverSpeed = 0.07F;
            this.dashboardBtn.AnimationSpeed = 0.03F;
            this.dashboardBtn.BackColor = System.Drawing.Color.Transparent;
            this.dashboardBtn.BaseColor = System.Drawing.Color.Transparent;
            this.dashboardBtn.BorderColor = System.Drawing.Color.Black;
            this.dashboardBtn.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(71)))), ((int)(((byte)(92)))));
            this.dashboardBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.dashboardBtn.CheckedForeColor = System.Drawing.Color.White;
            this.dashboardBtn.CheckedImage = null;
            this.dashboardBtn.CheckedLineColor = System.Drawing.Color.Red;
            this.dashboardBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashboardBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.dashboardBtn.FocusedColor = System.Drawing.Color.Empty;
            this.dashboardBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dashboardBtn.ForeColor = System.Drawing.Color.Gray;
            this.dashboardBtn.Image = null;
            this.dashboardBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.dashboardBtn.LineBottom = 2;
            this.dashboardBtn.LineColor = System.Drawing.Color.Transparent;
            this.dashboardBtn.Location = new System.Drawing.Point(15, 0);
            this.dashboardBtn.Margin = new System.Windows.Forms.Padding(6);
            this.dashboardBtn.Name = "dashboardBtn";
            this.dashboardBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(71)))), ((int)(((byte)(92)))));
            this.dashboardBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.dashboardBtn.OnHoverForeColor = System.Drawing.Color.LightGray;
            this.dashboardBtn.OnHoverImage = null;
            this.dashboardBtn.OnHoverLineColor = System.Drawing.Color.Red;
            this.dashboardBtn.OnPressedColor = System.Drawing.Color.Black;
            this.dashboardBtn.Size = new System.Drawing.Size(144, 92);
            this.dashboardBtn.TabIndex = 6;
            this.dashboardBtn.Text = "Dashboard";
            this.dashboardBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dashboardBtn.Click += new System.EventHandler(this.PanelTab_Click);
            // 
            // authBtn
            // 
            this.authBtn.AnimationHoverSpeed = 0.07F;
            this.authBtn.AnimationSpeed = 0.03F;
            this.authBtn.BackColor = System.Drawing.Color.Transparent;
            this.authBtn.BaseColor = System.Drawing.Color.Transparent;
            this.authBtn.BorderColor = System.Drawing.Color.Black;
            this.authBtn.Checked = true;
            this.authBtn.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(71)))), ((int)(((byte)(92)))));
            this.authBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.authBtn.CheckedForeColor = System.Drawing.Color.White;
            this.authBtn.CheckedImage = null;
            this.authBtn.CheckedLineColor = System.Drawing.Color.Red;
            this.authBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.authBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.authBtn.FocusedColor = System.Drawing.Color.Empty;
            this.authBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.authBtn.ForeColor = System.Drawing.Color.Gray;
            this.authBtn.Image = null;
            this.authBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.authBtn.LineBottom = 2;
            this.authBtn.LineColor = System.Drawing.Color.Transparent;
            this.authBtn.Location = new System.Drawing.Point(1552, 0);
            this.authBtn.Margin = new System.Windows.Forms.Padding(6);
            this.authBtn.Name = "authBtn";
            this.authBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(71)))), ((int)(((byte)(92)))));
            this.authBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.authBtn.OnHoverForeColor = System.Drawing.Color.LightGray;
            this.authBtn.OnHoverImage = null;
            this.authBtn.OnHoverLineColor = System.Drawing.Color.Red;
            this.authBtn.OnPressedColor = System.Drawing.Color.Black;
            this.authBtn.Size = new System.Drawing.Size(174, 92);
            this.authBtn.TabIndex = 5;
            this.authBtn.Text = "Authenticate";
            this.authBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.authBtn.Click += new System.EventHandler(this.PanelTab_Click);
            // 
            // authTabs
            // 
            this.authTabs.Controls.Add(this.authPanel);
            this.authTabs.Controls.Add(this.dashPanel);
            this.authTabs.Controls.Add(this.accountPanel);
            this.authTabs.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.authTabs.Location = new System.Drawing.Point(0, 94);
            this.authTabs.Margin = new System.Windows.Forms.Padding(6);
            this.authTabs.Name = "authTabs";
            this.authTabs.SelectedIndex = 0;
            this.authTabs.Size = new System.Drawing.Size(1726, 835);
            this.authTabs.TabIndex = 4;
            // 
            // authPanel
            // 
            this.authPanel.Controls.Add(this.loginWithDiscordBtn);
            this.authPanel.Controls.Add(this.authTimerLabel);
            this.authPanel.Controls.Add(this.gunaLabel1);
            this.authPanel.Location = new System.Drawing.Point(8, 39);
            this.authPanel.Margin = new System.Windows.Forms.Padding(6);
            this.authPanel.Name = "authPanel";
            this.authPanel.Padding = new System.Windows.Forms.Padding(6);
            this.authPanel.Size = new System.Drawing.Size(1710, 788);
            this.authPanel.TabIndex = 0;
            this.authPanel.Text = "Authenticate";
            this.authPanel.UseVisualStyleBackColor = true;
            // 
            // loginWithDiscordBtn
            // 
            this.loginWithDiscordBtn.AnimationHoverSpeed = 0.07F;
            this.loginWithDiscordBtn.AnimationSpeed = 0.03F;
            this.loginWithDiscordBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.loginWithDiscordBtn.BorderColor = System.Drawing.Color.Black;
            this.loginWithDiscordBtn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.loginWithDiscordBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.loginWithDiscordBtn.CheckedForeColor = System.Drawing.Color.White;
            this.loginWithDiscordBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("loginWithDiscordBtn.CheckedImage")));
            this.loginWithDiscordBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.loginWithDiscordBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginWithDiscordBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.loginWithDiscordBtn.FocusedColor = System.Drawing.Color.Empty;
            this.loginWithDiscordBtn.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.loginWithDiscordBtn.ForeColor = System.Drawing.Color.White;
            this.loginWithDiscordBtn.Image = ((System.Drawing.Image)(resources.GetObject("loginWithDiscordBtn.Image")));
            this.loginWithDiscordBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.loginWithDiscordBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.loginWithDiscordBtn.LineColor = System.Drawing.Color.Transparent;
            this.loginWithDiscordBtn.LineTop = 2;
            this.loginWithDiscordBtn.Location = new System.Drawing.Point(336, 402);
            this.loginWithDiscordBtn.Margin = new System.Windows.Forms.Padding(6);
            this.loginWithDiscordBtn.Name = "loginWithDiscordBtn";
            this.loginWithDiscordBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(24)))), ((int)(((byte)(36)))));
            this.loginWithDiscordBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.loginWithDiscordBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.loginWithDiscordBtn.OnHoverImage = null;
            this.loginWithDiscordBtn.OnHoverLineColor = System.Drawing.Color.Red;
            this.loginWithDiscordBtn.OnPressedColor = System.Drawing.Color.Black;
            this.loginWithDiscordBtn.Size = new System.Drawing.Size(1038, 85);
            this.loginWithDiscordBtn.TabIndex = 6;
            this.loginWithDiscordBtn.Text = "Login with Discord";
            this.loginWithDiscordBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.loginWithDiscordBtn.Click += new System.EventHandler(this.loginWithDiscordBtn_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(336, 302);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(1038, 94);
            this.gunaLabel1.TabIndex = 4;
            this.gunaLabel1.Text = "In order to authenticate the launcher, you must authenticate your Discord account" +
    ".\r\nYou can start the process of logging into CrewNode by clicking the button bel" +
    "ow.";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dashPanel
            // 
            this.dashPanel.Location = new System.Drawing.Point(8, 39);
            this.dashPanel.Margin = new System.Windows.Forms.Padding(6);
            this.dashPanel.Name = "dashPanel";
            this.dashPanel.Size = new System.Drawing.Size(1710, 788);
            this.dashPanel.TabIndex = 1;
            this.dashPanel.Text = "Dashboard";
            this.dashPanel.UseVisualStyleBackColor = true;
            // 
            // accountPanel
            // 
            this.accountPanel.Location = new System.Drawing.Point(8, 39);
            this.accountPanel.Margin = new System.Windows.Forms.Padding(6);
            this.accountPanel.Name = "accountPanel";
            this.accountPanel.Size = new System.Drawing.Size(1710, 788);
            this.accountPanel.TabIndex = 2;
            this.accountPanel.Text = "Settings";
            this.accountPanel.UseVisualStyleBackColor = true;
            // 
            // statusCheck
            // 
            this.statusCheck.Interval = 1000;
            this.statusCheck.Tick += new System.EventHandler(this.statusCheck_Tick);
            // 
            // authTimerLabel
            // 
            this.authTimerLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.authTimerLabel.Location = new System.Drawing.Point(336, 402);
            this.authTimerLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.authTimerLabel.Name = "authTimerLabel";
            this.authTimerLabel.Size = new System.Drawing.Size(1038, 85);
            this.authTimerLabel.TabIndex = 7;
            this.authTimerLabel.Text = "05:00 remaining for authentication";
            this.authTimerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.authTimerLabel.Visible = false;
            // 
            // Authenticate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1726, 929);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.authTabs);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Authenticate";
            this.Text = "Authenticate";
            this.Load += new System.EventHandler(this.Authenticate_Load);
            this.gunaPanel1.ResumeLayout(false);
            this.authTabs.ResumeLayout(false);
            this.authPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private System.Windows.Forms.TabControl authTabs;
        private System.Windows.Forms.TabPage authPanel;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaAdvenceButton authBtn;
        private System.Windows.Forms.TabPage dashPanel;
        private System.Windows.Forms.TabPage accountPanel;
        private Guna.UI.WinForms.GunaAdvenceButton loginWithDiscordBtn;
        private Guna.UI.WinForms.GunaAdvenceButton settingsBtn;
        private Guna.UI.WinForms.GunaAdvenceButton dashboardBtn;
        private System.Windows.Forms.Timer statusCheck;
        private Guna.UI.WinForms.GunaLabel authTimerLabel;
    }
}