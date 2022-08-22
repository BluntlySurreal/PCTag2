namespace PCTag
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.AboutElipse = new PCTag.ElipseControl();
            this.WebsiteLinkLabel = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AppNameLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AboutCloseButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AboutElipse
            // 
            this.AboutElipse.CornerRadius = 30;
            this.AboutElipse.TargetControl = this;
            // 
            // WebsiteLinkLabel
            // 
            this.WebsiteLinkLabel.ActiveLinkColor = System.Drawing.Color.WhiteSmoke;
            this.WebsiteLinkLabel.AutoSize = true;
            this.WebsiteLinkLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.WebsiteLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.WebsiteLinkLabel.LinkColor = System.Drawing.Color.WhiteSmoke;
            this.WebsiteLinkLabel.Location = new System.Drawing.Point(30, 35);
            this.WebsiteLinkLabel.Name = "WebsiteLinkLabel";
            this.WebsiteLinkLabel.Size = new System.Drawing.Size(70, 13);
            this.WebsiteLinkLabel.TabIndex = 1;
            this.WebsiteLinkLabel.TabStop = true;
            this.WebsiteLinkLabel.Text = "© Bluntly.me";
            this.WebsiteLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.WebsiteLinkLabel.VisitedLinkColor = System.Drawing.Color.WhiteSmoke;
            this.WebsiteLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.WebsiteLinkLabel_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.AppNameLabel);
            this.panel1.Controls.Add(this.WebsiteLinkLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 139);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(130, 54);
            this.panel1.TabIndex = 2;
            // 
            // AppNameLabel
            // 
            this.AppNameLabel.AutoSize = true;
            this.AppNameLabel.ForeColor = System.Drawing.Color.White;
            this.AppNameLabel.Location = new System.Drawing.Point(36, 6);
            this.AppNameLabel.Name = "AppNameLabel";
            this.AppNameLabel.Size = new System.Drawing.Size(61, 26);
            this.AppNameLabel.TabIndex = 3;
            this.AppNameLabel.Text = "PC Tag 2\r\nVersion 2.0";
            this.AppNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::PCTag.Properties.Resources.Icon_SysInfoBlack;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // AboutCloseButton
            // 
            this.AboutCloseButton.BackColor = System.Drawing.Color.Silver;
            this.AboutCloseButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AboutCloseButton.Font = new System.Drawing.Font("DINOT-Regular", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutCloseButton.Location = new System.Drawing.Point(0, 120);
            this.AboutCloseButton.Name = "AboutCloseButton";
            this.AboutCloseButton.Size = new System.Drawing.Size(130, 19);
            this.AboutCloseButton.TabIndex = 3;
            this.AboutCloseButton.Text = "C L O S E";
            this.AboutCloseButton.UseVisualStyleBackColor = false;
            this.AboutCloseButton.Click += new System.EventHandler(this.AboutCloseButton_Click);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(130, 193);
            this.ControlBox = false;
            this.Controls.Add(this.AboutCloseButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AboutForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ElipseControl AboutElipse;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel WebsiteLinkLabel;
        private System.Windows.Forms.Label AppNameLabel;
        private System.Windows.Forms.Button AboutCloseButton;
    }
}