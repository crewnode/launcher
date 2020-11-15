
namespace CrewNode.Launcher.UI.Addons
{
    partial class LocalServerSelection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocalServerSelection));
            this.upperPanel = new Guna.UI.WinForms.GunaPanel();
            this.newServerBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.titleLbl = new System.Windows.Forms.Label();
            this.headerPanel = new Guna.UI.WinForms.GunaPanel();
            this.exitButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.formDragIndicator = new Guna.UI.WinForms.GunaPictureBox();
            this.okBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gunaVScrollBar1 = new Guna.UI.WinForms.GunaVScrollBar();
            this.upperPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formDragIndicator)).BeginInit();
            this.SuspendLayout();
            // 
            // upperPanel
            // 
            this.upperPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.upperPanel.Controls.Add(this.newServerBtn);
            this.upperPanel.Controls.Add(this.titleLbl);
            this.upperPanel.Controls.Add(this.headerPanel);
            this.upperPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.upperPanel.Location = new System.Drawing.Point(0, 0);
            this.upperPanel.Name = "upperPanel";
            this.upperPanel.Size = new System.Drawing.Size(800, 96);
            this.upperPanel.TabIndex = 18;
            // 
            // newServerBtn
            // 
            this.newServerBtn.AnimationHoverSpeed = 0.07F;
            this.newServerBtn.AnimationSpeed = 0.03F;
            this.newServerBtn.BaseColor = System.Drawing.Color.Green;
            this.newServerBtn.BorderColor = System.Drawing.Color.Black;
            this.newServerBtn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.newServerBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.newServerBtn.CheckedForeColor = System.Drawing.Color.White;
            this.newServerBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("newServerBtn.CheckedImage")));
            this.newServerBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.newServerBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.newServerBtn.FocusedColor = System.Drawing.Color.Empty;
            this.newServerBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.newServerBtn.ForeColor = System.Drawing.Color.White;
            this.newServerBtn.Image = ((System.Drawing.Image)(resources.GetObject("newServerBtn.Image")));
            this.newServerBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.newServerBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.newServerBtn.Location = new System.Drawing.Point(673, 46);
            this.newServerBtn.Name = "newServerBtn";
            this.newServerBtn.OnHoverBaseColor = System.Drawing.Color.DarkGreen;
            this.newServerBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.newServerBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.newServerBtn.OnHoverImage = null;
            this.newServerBtn.OnHoverLineColor = System.Drawing.Color.Lime;
            this.newServerBtn.OnPressedColor = System.Drawing.Color.Black;
            this.newServerBtn.Size = new System.Drawing.Size(115, 42);
            this.newServerBtn.TabIndex = 19;
            this.newServerBtn.Text = "New Server";
            this.newServerBtn.Click += new System.EventHandler(this.newServerBtn_Click);
            // 
            // titleLbl
            // 
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.Color.White;
            this.titleLbl.Location = new System.Drawing.Point(7, 42);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(786, 54);
            this.titleLbl.TabIndex = 18;
            this.titleLbl.Text = "Select your server";
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
            this.headerPanel.Size = new System.Drawing.Size(800, 39);
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
            this.exitButton.Location = new System.Drawing.Point(763, 7);
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
            this.formDragIndicator.Size = new System.Drawing.Size(745, 15);
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
            this.okBtn.Location = new System.Drawing.Point(0, 406);
            this.okBtn.Name = "okBtn";
            this.okBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(24)))), ((int)(((byte)(36)))));
            this.okBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.okBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.okBtn.OnHoverImage = null;
            this.okBtn.OnHoverLineColor = System.Drawing.Color.Red;
            this.okBtn.OnPressedColor = System.Drawing.Color.Black;
            this.okBtn.Size = new System.Drawing.Size(800, 44);
            this.okBtn.TabIndex = 19;
            this.okBtn.Text = "OK";
            this.okBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 96);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 310);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // gunaVScrollBar1
            // 
            this.gunaVScrollBar1.BackColor = System.Drawing.Color.Transparent;
            this.gunaVScrollBar1.LargeChange = 10;
            this.gunaVScrollBar1.Location = new System.Drawing.Point(782, 99);
            this.gunaVScrollBar1.Maximum = 100;
            this.gunaVScrollBar1.Name = "gunaVScrollBar1";
            this.gunaVScrollBar1.ScrollIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(101)))), ((int)(((byte)(122)))));
            this.gunaVScrollBar1.Size = new System.Drawing.Size(16, 301);
            this.gunaVScrollBar1.TabIndex = 22;
            this.gunaVScrollBar1.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(71)))), ((int)(((byte)(92)))));
            this.gunaVScrollBar1.ThumbHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(24)))), ((int)(((byte)(36)))));
            this.gunaVScrollBar1.ThumbPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            // 
            // LocalServerSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gunaVScrollBar1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.upperPanel);
            this.Controls.Add(this.okBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LocalServerSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LocalServerSelection";
            this.Load += new System.EventHandler(this.LocalServerSelection_Load);
            this.upperPanel.ResumeLayout(false);
            this.headerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.formDragIndicator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaPanel upperPanel;
        private System.Windows.Forms.Label titleLbl;
        private Guna.UI.WinForms.GunaPanel headerPanel;
        private Guna.UI.WinForms.GunaPictureBox formDragIndicator;
        private Guna.UI.WinForms.GunaAdvenceButton okBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI.WinForms.GunaAdvenceButton exitButton;
        private Guna.UI.WinForms.GunaVScrollBar gunaVScrollBar1;
        private Guna.UI.WinForms.GunaAdvenceButton newServerBtn;
    }
}