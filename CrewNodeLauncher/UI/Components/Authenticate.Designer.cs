
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
            this.authHeaderPanel = new Guna.UI.WinForms.GunaPanel();
            this.settingsBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.dashboardBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.authBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.authTabs = new System.Windows.Forms.TabControl();
            this.authPanel = new System.Windows.Forms.TabPage();
            this.loginWithDiscordBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.authTimerLabel = new Guna.UI.WinForms.GunaLabel();
            this.authHelperLabel = new Guna.UI.WinForms.GunaLabel();
            this.dashPanel = new System.Windows.Forms.TabPage();
            this.usernameLabel = new Guna.UI.WinForms.GunaLabel();
            this.welcomeLabel = new Guna.UI.WinForms.GunaLabel();
            this.accountPanel = new System.Windows.Forms.TabPage();
            this.statusCheck = new System.Windows.Forms.Timer(this.components);
            this.logoutBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.authHeaderPanel.SuspendLayout();
            this.authTabs.SuspendLayout();
            this.authPanel.SuspendLayout();
            this.dashPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // authHeaderPanel
            // 
            this.authHeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.authHeaderPanel.Controls.Add(this.settingsBtn);
            this.authHeaderPanel.Controls.Add(this.dashboardBtn);
            this.authHeaderPanel.Controls.Add(this.authBtn);
            this.authHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.authHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.authHeaderPanel.Margin = new System.Windows.Forms.Padding(6);
            this.authHeaderPanel.Name = "authHeaderPanel";
            this.authHeaderPanel.Size = new System.Drawing.Size(1726, 92);
            this.authHeaderPanel.TabIndex = 3;
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
            this.authPanel.Controls.Add(this.authHelperLabel);
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
            // authHelperLabel
            // 
            this.authHelperLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.authHelperLabel.Location = new System.Drawing.Point(336, 302);
            this.authHelperLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.authHelperLabel.Name = "authHelperLabel";
            this.authHelperLabel.Size = new System.Drawing.Size(1038, 94);
            this.authHelperLabel.TabIndex = 4;
            this.authHelperLabel.Text = "In order to authenticate the launcher, you must authenticate your Discord account" +
    ".\r\nYou can start the process of logging into CrewNode by clicking the button bel" +
    "ow.";
            this.authHelperLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dashPanel
            // 
            this.dashPanel.Controls.Add(this.logoutBtn);
            this.dashPanel.Controls.Add(this.usernameLabel);
            this.dashPanel.Controls.Add(this.welcomeLabel);
            this.dashPanel.Location = new System.Drawing.Point(8, 39);
            this.dashPanel.Margin = new System.Windows.Forms.Padding(6);
            this.dashPanel.Name = "dashPanel";
            this.dashPanel.Size = new System.Drawing.Size(1710, 788);
            this.dashPanel.TabIndex = 1;
            this.dashPanel.Text = "Dashboard";
            this.dashPanel.UseVisualStyleBackColor = true;
            // 
            // usernameLabel
            // 
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.usernameLabel.ForeColor = System.Drawing.Color.Black;
            this.usernameLabel.Location = new System.Drawing.Point(217, 15);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(1472, 59);
            this.usernameLabel.TabIndex = 5;
            this.usernameLabel.Text = "username";
            this.usernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.welcomeLabel.ForeColor = System.Drawing.Color.Black;
            this.welcomeLabel.Location = new System.Drawing.Point(17, 15);
            this.welcomeLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(210, 59);
            this.welcomeLabel.TabIndex = 4;
            this.welcomeLabel.Text = "Welcome,";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // logoutBtn
            // 
            this.logoutBtn.AnimationHoverSpeed = 0.07F;
            this.logoutBtn.AnimationSpeed = 0.03F;
            this.logoutBtn.BackColor = System.Drawing.Color.Transparent;
            this.logoutBtn.BaseColor = System.Drawing.Color.Transparent;
            this.logoutBtn.BorderColor = System.Drawing.Color.Black;
            this.logoutBtn.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(71)))), ((int)(((byte)(92)))));
            this.logoutBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.logoutBtn.CheckedForeColor = System.Drawing.Color.White;
            this.logoutBtn.CheckedImage = null;
            this.logoutBtn.CheckedLineColor = System.Drawing.Color.Red;
            this.logoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.logoutBtn.FocusedColor = System.Drawing.Color.Empty;
            this.logoutBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.logoutBtn.ForeColor = System.Drawing.Color.Gray;
            this.logoutBtn.Image = null;
            this.logoutBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.logoutBtn.LineBottom = 2;
            this.logoutBtn.LineColor = System.Drawing.Color.Transparent;
            this.logoutBtn.Location = new System.Drawing.Point(1529, 689);
            this.logoutBtn.Margin = new System.Windows.Forms.Padding(6);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(71)))), ((int)(((byte)(92)))));
            this.logoutBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.logoutBtn.OnHoverForeColor = System.Drawing.Color.LightGray;
            this.logoutBtn.OnHoverImage = null;
            this.logoutBtn.OnHoverLineColor = System.Drawing.Color.Red;
            this.logoutBtn.OnPressedColor = System.Drawing.Color.Black;
            this.logoutBtn.Size = new System.Drawing.Size(174, 92);
            this.logoutBtn.TabIndex = 6;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // Authenticate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1726, 929);
            this.Controls.Add(this.authHeaderPanel);
            this.Controls.Add(this.authTabs);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Authenticate";
            this.Text = "Authenticate";
            this.Load += new System.EventHandler(this.Authenticate_Load);
            this.authHeaderPanel.ResumeLayout(false);
            this.authTabs.ResumeLayout(false);
            this.authPanel.ResumeLayout(false);
            this.dashPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaPanel authHeaderPanel;
        private System.Windows.Forms.TabControl authTabs;
        private System.Windows.Forms.TabPage authPanel;
        private Guna.UI.WinForms.GunaLabel authHelperLabel;
        private Guna.UI.WinForms.GunaAdvenceButton authBtn;
        private System.Windows.Forms.TabPage dashPanel;
        private System.Windows.Forms.TabPage accountPanel;
        private Guna.UI.WinForms.GunaAdvenceButton loginWithDiscordBtn;
        private Guna.UI.WinForms.GunaAdvenceButton settingsBtn;
        private Guna.UI.WinForms.GunaAdvenceButton dashboardBtn;
        private System.Windows.Forms.Timer statusCheck;
        private Guna.UI.WinForms.GunaLabel authTimerLabel;
        private Guna.UI.WinForms.GunaLabel usernameLabel;
        private Guna.UI.WinForms.GunaLabel welcomeLabel;
        private Guna.UI.WinForms.GunaAdvenceButton logoutBtn;
    }
}