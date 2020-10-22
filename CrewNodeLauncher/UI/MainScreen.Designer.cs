namespace CrewNodeLauncher
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.navPanel = new Guna.UI.WinForms.GunaPanel();
            this.cnImage1 = new Guna.UI.WinForms.GunaImageButton();
            this.updateAvailableBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.loginRegisterBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.cnLauncherVersion = new Guna.UI.WinForms.GunaLabel();
            this.settingsBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.leaderboardBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.newsBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.pluginsBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.launcherBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.cnImage2 = new Guna.UI.WinForms.GunaPictureBox();
            this.upperPanel = new Guna.UI.WinForms.GunaPanel();
            this.innerFormName = new Guna.UI.WinForms.GunaLabel();
            this.headerPanel = new Guna.UI.WinForms.GunaPanel();
            this.formDragIndicator = new Guna.UI.WinForms.GunaPictureBox();
            this.exitButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.minimizeButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaVScrollBar1 = new Guna.UI.WinForms.GunaVScrollBar();
            this.contentPanel = new Guna.UI.WinForms.GunaPanel();
            this.gunaHScrollBar1 = new Guna.UI.WinForms.GunaHScrollBar();
            this.navPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cnImage2)).BeginInit();
            this.upperPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formDragIndicator)).BeginInit();
            this.SuspendLayout();
            // 
            // navPanel
            // 
            this.navPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.navPanel.Controls.Add(this.cnImage1);
            this.navPanel.Controls.Add(this.updateAvailableBtn);
            this.navPanel.Controls.Add(this.loginRegisterBtn);
            this.navPanel.Controls.Add(this.cnLauncherVersion);
            this.navPanel.Controls.Add(this.settingsBtn);
            this.navPanel.Controls.Add(this.leaderboardBtn);
            this.navPanel.Controls.Add(this.newsBtn);
            this.navPanel.Controls.Add(this.pluginsBtn);
            this.navPanel.Controls.Add(this.launcherBtn);
            this.navPanel.Controls.Add(this.cnImage2);
            this.navPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.navPanel.Location = new System.Drawing.Point(0, 0);
            this.navPanel.Name = "navPanel";
            this.navPanel.Size = new System.Drawing.Size(246, 578);
            this.navPanel.TabIndex = 0;
            this.navPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formDrag_MouseDown);
            this.navPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.formDrag_MouseMove);
            this.navPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.formDrag_MouseUp);
            // 
            // cnImage1
            // 
            this.cnImage1.BackColor = System.Drawing.Color.Transparent;
            this.cnImage1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cnImage1.Image = global::CrewNodeLauncher.Properties.Resources.crewnode;
            this.cnImage1.ImageSize = new System.Drawing.Size(64, 64);
            this.cnImage1.Location = new System.Drawing.Point(13, 14);
            this.cnImage1.Name = "cnImage1";
            this.cnImage1.OnHoverImage = null;
            this.cnImage1.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.cnImage1.Size = new System.Drawing.Size(56, 77);
            this.cnImage1.TabIndex = 5;
            this.cnImage1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formDrag_MouseDown);
            this.cnImage1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.formDrag_MouseMove);
            this.cnImage1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.formDrag_MouseUp);
            // 
            // updateAvailableBtn
            // 
            this.updateAvailableBtn.AnimationHoverSpeed = 0.07F;
            this.updateAvailableBtn.AnimationSpeed = 0.03F;
            this.updateAvailableBtn.BaseColor = System.Drawing.Color.Red;
            this.updateAvailableBtn.BorderColor = System.Drawing.Color.Black;
            this.updateAvailableBtn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.updateAvailableBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.updateAvailableBtn.CheckedForeColor = System.Drawing.Color.White;
            this.updateAvailableBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("updateAvailableBtn.CheckedImage")));
            this.updateAvailableBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.updateAvailableBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateAvailableBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.updateAvailableBtn.FocusedColor = System.Drawing.Color.Empty;
            this.updateAvailableBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.updateAvailableBtn.ForeColor = System.Drawing.Color.White;
            this.updateAvailableBtn.Image = ((System.Drawing.Image)(resources.GetObject("updateAvailableBtn.Image")));
            this.updateAvailableBtn.ImageOffsetX = 7;
            this.updateAvailableBtn.ImageSize = new System.Drawing.Size(22, 22);
            this.updateAvailableBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(81)))), ((int)(((byte)(102)))));
            this.updateAvailableBtn.LineTop = 2;
            this.updateAvailableBtn.Location = new System.Drawing.Point(0, 537);
            this.updateAvailableBtn.Name = "updateAvailableBtn";
            this.updateAvailableBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.updateAvailableBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.updateAvailableBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.updateAvailableBtn.OnHoverImage = null;
            this.updateAvailableBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.updateAvailableBtn.OnPressedColor = System.Drawing.Color.Black;
            this.updateAvailableBtn.Size = new System.Drawing.Size(247, 40);
            this.updateAvailableBtn.TabIndex = 9;
            this.updateAvailableBtn.Text = "An update is available!";
            this.updateAvailableBtn.Visible = false;
            this.updateAvailableBtn.Click += new System.EventHandler(this.updateAvailableBtn_Click);
            // 
            // loginRegisterBtn
            // 
            this.loginRegisterBtn.AnimationHoverSpeed = 0.07F;
            this.loginRegisterBtn.AnimationSpeed = 0.03F;
            this.loginRegisterBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.loginRegisterBtn.BorderColor = System.Drawing.Color.Black;
            this.loginRegisterBtn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.loginRegisterBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.loginRegisterBtn.CheckedForeColor = System.Drawing.Color.White;
            this.loginRegisterBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("loginRegisterBtn.CheckedImage")));
            this.loginRegisterBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.loginRegisterBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginRegisterBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.loginRegisterBtn.FocusedColor = System.Drawing.Color.Empty;
            this.loginRegisterBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.loginRegisterBtn.ForeColor = System.Drawing.Color.White;
            this.loginRegisterBtn.Image = ((System.Drawing.Image)(resources.GetObject("loginRegisterBtn.Image")));
            this.loginRegisterBtn.ImageOffsetX = 7;
            this.loginRegisterBtn.ImageSize = new System.Drawing.Size(22, 22);
            this.loginRegisterBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(81)))), ((int)(((byte)(102)))));
            this.loginRegisterBtn.LineTop = 2;
            this.loginRegisterBtn.Location = new System.Drawing.Point(0, 518);
            this.loginRegisterBtn.Name = "loginRegisterBtn";
            this.loginRegisterBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(24)))), ((int)(((byte)(36)))));
            this.loginRegisterBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.loginRegisterBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.loginRegisterBtn.OnHoverImage = null;
            this.loginRegisterBtn.OnHoverLineColor = System.Drawing.Color.Red;
            this.loginRegisterBtn.OnPressedColor = System.Drawing.Color.Black;
            this.loginRegisterBtn.Size = new System.Drawing.Size(247, 59);
            this.loginRegisterBtn.TabIndex = 8;
            this.loginRegisterBtn.Text = "Login or Register";
            this.loginRegisterBtn.Click += new System.EventHandler(this.loginRegisterBtn_Click);
            // 
            // cnLauncherVersion
            // 
            this.cnLauncherVersion.BackColor = System.Drawing.Color.Transparent;
            this.cnLauncherVersion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cnLauncherVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(89)))), ((int)(((byte)(96)))));
            this.cnLauncherVersion.Location = new System.Drawing.Point(152, 75);
            this.cnLauncherVersion.Name = "cnLauncherVersion";
            this.cnLauncherVersion.Size = new System.Drawing.Size(90, 15);
            this.cnLauncherVersion.TabIndex = 7;
            this.cnLauncherVersion.Text = "v0.0.1-alpha0";
            this.cnLauncherVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cnLauncherVersion.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formDrag_MouseDown);
            this.cnLauncherVersion.MouseMove += new System.Windows.Forms.MouseEventHandler(this.formDrag_MouseMove);
            this.cnLauncherVersion.MouseUp += new System.Windows.Forms.MouseEventHandler(this.formDrag_MouseUp);
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
            this.settingsBtn.FocusedColor = System.Drawing.Color.Empty;
            this.settingsBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.settingsBtn.ForeColor = System.Drawing.Color.White;
            this.settingsBtn.Image = ((System.Drawing.Image)(resources.GetObject("settingsBtn.Image")));
            this.settingsBtn.ImageOffsetX = 7;
            this.settingsBtn.ImageSize = new System.Drawing.Size(22, 22);
            this.settingsBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(81)))), ((int)(((byte)(102)))));
            this.settingsBtn.LineTop = 2;
            this.settingsBtn.Location = new System.Drawing.Point(0, 328);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(24)))), ((int)(((byte)(36)))));
            this.settingsBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.settingsBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.settingsBtn.OnHoverImage = null;
            this.settingsBtn.OnHoverLineColor = System.Drawing.Color.Red;
            this.settingsBtn.OnPressedColor = System.Drawing.Color.Black;
            this.settingsBtn.Size = new System.Drawing.Size(247, 59);
            this.settingsBtn.TabIndex = 4;
            this.settingsBtn.Text = "Settings";
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // leaderboardBtn
            // 
            this.leaderboardBtn.AnimationHoverSpeed = 0.07F;
            this.leaderboardBtn.AnimationSpeed = 0.03F;
            this.leaderboardBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.leaderboardBtn.BorderColor = System.Drawing.Color.Black;
            this.leaderboardBtn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.leaderboardBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.leaderboardBtn.CheckedForeColor = System.Drawing.Color.White;
            this.leaderboardBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("leaderboardBtn.CheckedImage")));
            this.leaderboardBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.leaderboardBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.leaderboardBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.leaderboardBtn.FocusedColor = System.Drawing.Color.Empty;
            this.leaderboardBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.leaderboardBtn.ForeColor = System.Drawing.Color.White;
            this.leaderboardBtn.Image = ((System.Drawing.Image)(resources.GetObject("leaderboardBtn.Image")));
            this.leaderboardBtn.ImageOffsetX = 7;
            this.leaderboardBtn.ImageSize = new System.Drawing.Size(22, 22);
            this.leaderboardBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(81)))), ((int)(((byte)(102)))));
            this.leaderboardBtn.LineTop = 2;
            this.leaderboardBtn.Location = new System.Drawing.Point(0, 210);
            this.leaderboardBtn.Name = "leaderboardBtn";
            this.leaderboardBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(24)))), ((int)(((byte)(36)))));
            this.leaderboardBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.leaderboardBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.leaderboardBtn.OnHoverImage = null;
            this.leaderboardBtn.OnHoverLineColor = System.Drawing.Color.Red;
            this.leaderboardBtn.OnPressedColor = System.Drawing.Color.Black;
            this.leaderboardBtn.Size = new System.Drawing.Size(247, 59);
            this.leaderboardBtn.TabIndex = 3;
            this.leaderboardBtn.Text = "Leaderboard";
            this.leaderboardBtn.Click += new System.EventHandler(this.leaderboardBtn_Click);
            // 
            // newsBtn
            // 
            this.newsBtn.AnimationHoverSpeed = 0.07F;
            this.newsBtn.AnimationSpeed = 0.03F;
            this.newsBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.newsBtn.BorderColor = System.Drawing.Color.Black;
            this.newsBtn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.newsBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.newsBtn.CheckedForeColor = System.Drawing.Color.White;
            this.newsBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("newsBtn.CheckedImage")));
            this.newsBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.newsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newsBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.newsBtn.FocusedColor = System.Drawing.Color.Empty;
            this.newsBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.newsBtn.ForeColor = System.Drawing.Color.White;
            this.newsBtn.Image = ((System.Drawing.Image)(resources.GetObject("newsBtn.Image")));
            this.newsBtn.ImageOffsetX = 7;
            this.newsBtn.ImageSize = new System.Drawing.Size(22, 22);
            this.newsBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(81)))), ((int)(((byte)(102)))));
            this.newsBtn.LineTop = 2;
            this.newsBtn.Location = new System.Drawing.Point(0, 269);
            this.newsBtn.Name = "newsBtn";
            this.newsBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(24)))), ((int)(((byte)(36)))));
            this.newsBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.newsBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.newsBtn.OnHoverImage = null;
            this.newsBtn.OnHoverLineColor = System.Drawing.Color.Red;
            this.newsBtn.OnPressedColor = System.Drawing.Color.Black;
            this.newsBtn.Size = new System.Drawing.Size(247, 59);
            this.newsBtn.TabIndex = 2;
            this.newsBtn.Text = "Announcements";
            this.newsBtn.Click += new System.EventHandler(this.newsBtn_Click);
            // 
            // pluginsBtn
            // 
            this.pluginsBtn.AnimationHoverSpeed = 0.07F;
            this.pluginsBtn.AnimationSpeed = 0.03F;
            this.pluginsBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.pluginsBtn.BorderColor = System.Drawing.Color.Black;
            this.pluginsBtn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.pluginsBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.pluginsBtn.CheckedForeColor = System.Drawing.Color.White;
            this.pluginsBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("pluginsBtn.CheckedImage")));
            this.pluginsBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.pluginsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pluginsBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.pluginsBtn.FocusedColor = System.Drawing.Color.Empty;
            this.pluginsBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.pluginsBtn.ForeColor = System.Drawing.Color.White;
            this.pluginsBtn.Image = ((System.Drawing.Image)(resources.GetObject("pluginsBtn.Image")));
            this.pluginsBtn.ImageOffsetX = 7;
            this.pluginsBtn.ImageSize = new System.Drawing.Size(22, 22);
            this.pluginsBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(81)))), ((int)(((byte)(102)))));
            this.pluginsBtn.LineTop = 2;
            this.pluginsBtn.Location = new System.Drawing.Point(0, 151);
            this.pluginsBtn.Name = "pluginsBtn";
            this.pluginsBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(24)))), ((int)(((byte)(36)))));
            this.pluginsBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.pluginsBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.pluginsBtn.OnHoverImage = null;
            this.pluginsBtn.OnHoverLineColor = System.Drawing.Color.Red;
            this.pluginsBtn.OnPressedColor = System.Drawing.Color.Black;
            this.pluginsBtn.Size = new System.Drawing.Size(247, 59);
            this.pluginsBtn.TabIndex = 1;
            this.pluginsBtn.Text = "Plugins";
            this.pluginsBtn.Click += new System.EventHandler(this.pluginsBtn_Click);
            // 
            // launcherBtn
            // 
            this.launcherBtn.AnimationHoverSpeed = 0.07F;
            this.launcherBtn.AnimationSpeed = 0.03F;
            this.launcherBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.launcherBtn.BorderColor = System.Drawing.Color.Black;
            this.launcherBtn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.launcherBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.launcherBtn.CheckedForeColor = System.Drawing.Color.White;
            this.launcherBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("launcherBtn.CheckedImage")));
            this.launcherBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.launcherBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.launcherBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.launcherBtn.FocusedColor = System.Drawing.Color.Empty;
            this.launcherBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.launcherBtn.ForeColor = System.Drawing.Color.White;
            this.launcherBtn.Image = ((System.Drawing.Image)(resources.GetObject("launcherBtn.Image")));
            this.launcherBtn.ImageOffsetX = 7;
            this.launcherBtn.ImageSize = new System.Drawing.Size(22, 22);
            this.launcherBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(81)))), ((int)(((byte)(102)))));
            this.launcherBtn.LineTop = 2;
            this.launcherBtn.Location = new System.Drawing.Point(0, 92);
            this.launcherBtn.Name = "launcherBtn";
            this.launcherBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(24)))), ((int)(((byte)(36)))));
            this.launcherBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.launcherBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.launcherBtn.OnHoverImage = null;
            this.launcherBtn.OnHoverLineColor = System.Drawing.Color.Red;
            this.launcherBtn.OnPressedColor = System.Drawing.Color.Black;
            this.launcherBtn.Size = new System.Drawing.Size(247, 59);
            this.launcherBtn.TabIndex = 0;
            this.launcherBtn.Text = "Launcher";
            this.launcherBtn.Click += new System.EventHandler(this.launcherBtn_Click);
            // 
            // cnImage2
            // 
            this.cnImage2.BackColor = System.Drawing.Color.Transparent;
            this.cnImage2.BackgroundImage = global::CrewNodeLauncher.Properties.Resources.crewnode_text;
            this.cnImage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cnImage2.BaseColor = System.Drawing.Color.White;
            this.cnImage2.Location = new System.Drawing.Point(63, 22);
            this.cnImage2.Name = "cnImage2";
            this.cnImage2.Size = new System.Drawing.Size(164, 58);
            this.cnImage2.TabIndex = 0;
            this.cnImage2.TabStop = false;
            this.cnImage2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formDrag_MouseDown);
            this.cnImage2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.formDrag_MouseMove);
            this.cnImage2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.formDrag_MouseUp);
            // 
            // upperPanel
            // 
            this.upperPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(81)))), ((int)(((byte)(102)))));
            this.upperPanel.Controls.Add(this.innerFormName);
            this.upperPanel.Controls.Add(this.headerPanel);
            this.upperPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.upperPanel.Location = new System.Drawing.Point(246, 0);
            this.upperPanel.Name = "upperPanel";
            this.upperPanel.Size = new System.Drawing.Size(881, 92);
            this.upperPanel.TabIndex = 1;
            this.upperPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formDrag_MouseDown);
            this.upperPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.formDrag_MouseMove);
            this.upperPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.formDrag_MouseUp);
            // 
            // innerFormName
            // 
            this.innerFormName.AutoSize = true;
            this.innerFormName.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.innerFormName.ForeColor = System.Drawing.Color.White;
            this.innerFormName.Location = new System.Drawing.Point(10, 50);
            this.innerFormName.Name = "innerFormName";
            this.innerFormName.Size = new System.Drawing.Size(100, 30);
            this.innerFormName.TabIndex = 3;
            this.innerFormName.Text = "Launcher";
            this.innerFormName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.innerFormName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formDrag_MouseDown);
            this.innerFormName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.formDrag_MouseMove);
            this.innerFormName.MouseUp += new System.Windows.Forms.MouseEventHandler(this.formDrag_MouseUp);
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
            this.headerPanel.Size = new System.Drawing.Size(881, 39);
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
            this.formDragIndicator.Size = new System.Drawing.Size(790, 15);
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
            this.exitButton.Location = new System.Drawing.Point(845, 7);
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
            this.exitButton.Click += new System.EventHandler(this.closeButton_Click);
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
            this.minimizeButton.Location = new System.Drawing.Point(816, 7);
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
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // gunaVScrollBar1
            // 
            this.gunaVScrollBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaVScrollBar1.BackColor = System.Drawing.Color.Transparent;
            this.gunaVScrollBar1.LargeChange = 10;
            this.gunaVScrollBar1.Location = new System.Drawing.Point(1111, 104);
            this.gunaVScrollBar1.Maximum = 100;
            this.gunaVScrollBar1.Name = "gunaVScrollBar1";
            this.gunaVScrollBar1.ScrollIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(101)))), ((int)(((byte)(122)))));
            this.gunaVScrollBar1.Size = new System.Drawing.Size(10, 462);
            this.gunaVScrollBar1.TabIndex = 1;
            this.gunaVScrollBar1.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(71)))), ((int)(((byte)(92)))));
            this.gunaVScrollBar1.ThumbHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(24)))), ((int)(((byte)(36)))));
            this.gunaVScrollBar1.ThumbPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.SystemColors.Control;
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(246, 92);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(881, 486);
            this.contentPanel.TabIndex = 2;
            this.contentPanel.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.contentPanel_ControlChanged);
            this.contentPanel.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.contentPanel_ControlChanged);
            this.contentPanel.Resize += new System.EventHandler(this.contentPanel_Resize);
            // 
            // gunaHScrollBar1
            // 
            this.gunaHScrollBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaHScrollBar1.BackColor = System.Drawing.Color.Transparent;
            this.gunaHScrollBar1.LargeChange = 10;
            this.gunaHScrollBar1.Location = new System.Drawing.Point(255, 556);
            this.gunaHScrollBar1.Margin = new System.Windows.Forms.Padding(50, 3, 50, 3);
            this.gunaHScrollBar1.Maximum = 100;
            this.gunaHScrollBar1.Name = "gunaHScrollBar1";
            this.gunaHScrollBar1.ScrollIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(101)))), ((int)(((byte)(122)))));
            this.gunaHScrollBar1.Size = new System.Drawing.Size(843, 10);
            this.gunaHScrollBar1.TabIndex = 3;
            this.gunaHScrollBar1.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(71)))), ((int)(((byte)(92)))));
            this.gunaHScrollBar1.ThumbHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(24)))), ((int)(((byte)(36)))));
            this.gunaHScrollBar1.ThumbPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1127, 578);
            this.Controls.Add(this.gunaHScrollBar1);
            this.Controls.Add(this.gunaVScrollBar1);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.upperPanel);
            this.Controls.Add(this.navPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = global::CrewNodeLauncher.Properties.Resources.CrewNodeLauncher;
            this.MaximizeBox = false;
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CrewNode";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.navPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cnImage2)).EndInit();
            this.upperPanel.ResumeLayout(false);
            this.upperPanel.PerformLayout();
            this.headerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.formDragIndicator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel navPanel;
        private Guna.UI.WinForms.GunaAdvenceButton pluginsBtn;
        private Guna.UI.WinForms.GunaAdvenceButton launcherBtn;
        private Guna.UI.WinForms.GunaPanel upperPanel;
        private Guna.UI.WinForms.GunaAdvenceButton settingsBtn;
        private Guna.UI.WinForms.GunaAdvenceButton leaderboardBtn;
        private Guna.UI.WinForms.GunaAdvenceButton newsBtn;
        private Guna.UI.WinForms.GunaAdvenceButton minimizeButton;
        private Guna.UI.WinForms.GunaImageButton cnImage1;
        private Guna.UI.WinForms.GunaPictureBox cnImage2;
        private Guna.UI.WinForms.GunaLabel cnLauncherVersion;
        private Guna.UI.WinForms.GunaAdvenceButton loginRegisterBtn;
        private Guna.UI.WinForms.GunaPanel headerPanel;
        private Guna.UI.WinForms.GunaAdvenceButton exitButton;
        private Guna.UI.WinForms.GunaLabel innerFormName;
        private Guna.UI.WinForms.GunaPictureBox formDragIndicator;
        private Guna.UI.WinForms.GunaVScrollBar gunaVScrollBar1;
        private Guna.UI.WinForms.GunaPanel contentPanel;
        private Guna.UI.WinForms.GunaHScrollBar gunaHScrollBar1;
        private Guna.UI.WinForms.GunaAdvenceButton updateAvailableBtn;
    }
}

