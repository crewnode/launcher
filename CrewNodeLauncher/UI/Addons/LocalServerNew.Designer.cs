
namespace CrewNodeLauncher.UI.Addons
{
    partial class LocalServerNew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocalServerNew));
            this.branchImg = new Guna.UI.WinForms.GunaPictureBox();
            this.impostorVersionsCombo = new Guna.UI.WinForms.GunaComboBox();
            this.upperPanel = new Guna.UI.WinForms.GunaPanel();
            this.titleLbl = new System.Windows.Forms.Label();
            this.headerPanel = new Guna.UI.WinForms.GunaPanel();
            this.exitButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.formDragIndicator = new Guna.UI.WinForms.GunaPictureBox();
            this.okBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaTextBox1 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.nameImg = new Guna.UI.WinForms.GunaPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.branchImg)).BeginInit();
            this.upperPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formDragIndicator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameImg)).BeginInit();
            this.SuspendLayout();
            // 
            // branchImg
            // 
            this.branchImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.branchImg.BaseColor = System.Drawing.Color.White;
            this.branchImg.Location = new System.Drawing.Point(11, 194);
            this.branchImg.Name = "branchImg";
            this.branchImg.Size = new System.Drawing.Size(20, 20);
            this.branchImg.TabIndex = 11;
            this.branchImg.TabStop = false;
            // 
            // impostorVersionsCombo
            // 
            this.impostorVersionsCombo.BackColor = System.Drawing.Color.Transparent;
            this.impostorVersionsCombo.BaseColor = System.Drawing.Color.White;
            this.impostorVersionsCombo.BorderColor = System.Drawing.Color.Silver;
            this.impostorVersionsCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.impostorVersionsCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.impostorVersionsCombo.FocusedColor = System.Drawing.Color.Empty;
            this.impostorVersionsCombo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.impostorVersionsCombo.ForeColor = System.Drawing.Color.Black;
            this.impostorVersionsCombo.FormattingEnabled = true;
            this.impostorVersionsCombo.Location = new System.Drawing.Point(40, 190);
            this.impostorVersionsCombo.Name = "impostorVersionsCombo";
            this.impostorVersionsCombo.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.impostorVersionsCombo.OnHoverItemForeColor = System.Drawing.Color.White;
            this.impostorVersionsCombo.Size = new System.Drawing.Size(258, 26);
            this.impostorVersionsCombo.TabIndex = 10;
            // 
            // upperPanel
            // 
            this.upperPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.upperPanel.Controls.Add(this.titleLbl);
            this.upperPanel.Controls.Add(this.headerPanel);
            this.upperPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.upperPanel.Location = new System.Drawing.Point(0, 0);
            this.upperPanel.Name = "upperPanel";
            this.upperPanel.Size = new System.Drawing.Size(310, 96);
            this.upperPanel.TabIndex = 15;
            // 
            // titleLbl
            // 
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.Color.White;
            this.titleLbl.Location = new System.Drawing.Point(7, 42);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(298, 54);
            this.titleLbl.TabIndex = 18;
            this.titleLbl.Text = "New Server";
            this.titleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(71)))), ((int)(((byte)(92)))));
            this.headerPanel.Controls.Add(this.exitButton);
            this.headerPanel.Controls.Add(this.formDragIndicator);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(310, 39);
            this.headerPanel.TabIndex = 2;
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
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "X";
            this.exitButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // formDragIndicator
            // 
            this.formDragIndicator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("formDragIndicator.BackgroundImage")));
            this.formDragIndicator.BaseColor = System.Drawing.Color.White;
            this.formDragIndicator.Location = new System.Drawing.Point(12, 13);
            this.formDragIndicator.Name = "formDragIndicator";
            this.formDragIndicator.Size = new System.Drawing.Size(257, 15);
            this.formDragIndicator.TabIndex = 0;
            this.formDragIndicator.TabStop = false;
            // 
            // okBtn
            // 
            this.okBtn.AnimationHoverSpeed = 0.07F;
            this.okBtn.AnimationSpeed = 0.03F;
            this.okBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.okBtn.BorderColor = System.Drawing.Color.Black;
            this.okBtn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.okBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.okBtn.CheckedForeColor = System.Drawing.Color.White;
            this.okBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("okBtn.CheckedImage")));
            this.okBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.okBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.okBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.okBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.okBtn.FocusedColor = System.Drawing.Color.Empty;
            this.okBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.okBtn.ForeColor = System.Drawing.Color.White;
            this.okBtn.Image = null;
            this.okBtn.ImageOffsetX = 7;
            this.okBtn.ImageSize = new System.Drawing.Size(22, 22);
            this.okBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(81)))), ((int)(((byte)(102)))));
            this.okBtn.LineTop = 2;
            this.okBtn.Location = new System.Drawing.Point(0, 239);
            this.okBtn.Name = "okBtn";
            this.okBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(24)))), ((int)(((byte)(36)))));
            this.okBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.okBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.okBtn.OnHoverImage = null;
            this.okBtn.OnHoverLineColor = System.Drawing.Color.Red;
            this.okBtn.OnPressedColor = System.Drawing.Color.Black;
            this.okBtn.Size = new System.Drawing.Size(310, 44);
            this.okBtn.TabIndex = 20;
            this.okBtn.Text = "Create";
            this.okBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.okBtn.Click += new System.EventHandler(this.downloadBtn_Click);
            // 
            // gunaTextBox1
            // 
            this.gunaTextBox1.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox1.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBox1.Location = new System.Drawing.Point(40, 133);
            this.gunaTextBox1.Name = "gunaTextBox1";
            this.gunaTextBox1.PasswordChar = '\0';
            this.gunaTextBox1.SelectedText = "";
            this.gunaTextBox1.Size = new System.Drawing.Size(258, 30);
            this.gunaTextBox1.TabIndex = 21;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(39, 115);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(39, 15);
            this.gunaLabel1.TabIndex = 22;
            this.gunaLabel1.Text = "Name";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(39, 172);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(45, 15);
            this.gunaLabel2.TabIndex = 23;
            this.gunaLabel2.Text = "Version";
            // 
            // nameImg
            // 
            this.nameImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nameImg.BaseColor = System.Drawing.Color.White;
            this.nameImg.Location = new System.Drawing.Point(11, 138);
            this.nameImg.Name = "nameImg";
            this.nameImg.Size = new System.Drawing.Size(20, 20);
            this.nameImg.TabIndex = 24;
            this.nameImg.TabStop = false;
            // 
            // LocalServerNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 283);
            this.Controls.Add(this.nameImg);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.gunaTextBox1);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.branchImg);
            this.Controls.Add(this.impostorVersionsCombo);
            this.Controls.Add(this.upperPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LocalServerNew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LocalServerNew";
            this.Load += new System.EventHandler(this.LocalServerNew_Load);
            ((System.ComponentModel.ISupportInitialize)(this.branchImg)).EndInit();
            this.upperPanel.ResumeLayout(false);
            this.headerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.formDragIndicator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaPictureBox branchImg;
        private Guna.UI.WinForms.GunaComboBox impostorVersionsCombo;
        private Guna.UI.WinForms.GunaPanel upperPanel;
        private System.Windows.Forms.Label titleLbl;
        private Guna.UI.WinForms.GunaPanel headerPanel;
        private Guna.UI.WinForms.GunaAdvenceButton exitButton;
        private Guna.UI.WinForms.GunaPictureBox formDragIndicator;
        private Guna.UI.WinForms.GunaAdvenceButton okBtn;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaPictureBox nameImg;
    }
}