namespace PCTag
{
    partial class PCTagMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PCTagMainForm));
            this.fqdntitle = new System.Windows.Forms.Label();
            this.iptitle = new System.Windows.Forms.Label();
            this.IP1Label = new System.Windows.Forms.Label();
            this.DnsLabel = new System.Windows.Forms.Label();
            this.GatewayLabel = new System.Windows.Forms.Label();
            this.UserLabel = new System.Windows.Forms.Label();
            this.usertitle = new System.Windows.Forms.Label();
            this.gatewaytitle = new System.Windows.Forms.Label();
            this.dnstitle = new System.Windows.Forms.Label();
            this.FQDNLabel = new System.Windows.Forms.Label();
            this.CopytoolTip = new System.Windows.Forms.ToolTip(this.components);
            this.topPanel = new System.Windows.Forms.Panel();
            this.topTable = new System.Windows.Forms.TableLayoutPanel();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.bottomTable = new System.Windows.Forms.TableLayoutPanel();
            this.MainFormElipse = new PCTag.ElipseControl();
            this.topPanel.SuspendLayout();
            this.topTable.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.bottomTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // fqdntitle
            // 
            this.fqdntitle.AutoSize = true;
            this.fqdntitle.BackColor = System.Drawing.Color.Transparent;
            this.fqdntitle.Dock = System.Windows.Forms.DockStyle.Right;
            this.fqdntitle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fqdntitle.ForeColor = System.Drawing.Color.White;
            this.fqdntitle.Location = new System.Drawing.Point(42, 2);
            this.fqdntitle.Name = "fqdntitle";
            this.fqdntitle.Padding = new System.Windows.Forms.Padding(6, 2, 0, 0);
            this.fqdntitle.Size = new System.Drawing.Size(55, 18);
            this.fqdntitle.TabIndex = 0;
            this.fqdntitle.Text = "FQDN:";
            this.fqdntitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // iptitle
            // 
            this.iptitle.AutoSize = true;
            this.iptitle.BackColor = System.Drawing.Color.Transparent;
            this.iptitle.Dock = System.Windows.Forms.DockStyle.Right;
            this.iptitle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iptitle.ForeColor = System.Drawing.Color.White;
            this.iptitle.Location = new System.Drawing.Point(15, 2);
            this.iptitle.Name = "iptitle";
            this.iptitle.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.iptitle.Size = new System.Drawing.Size(82, 17);
            this.iptitle.TabIndex = 1;
            this.iptitle.Text = "IP Address:";
            this.iptitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // IP1Label
            // 
            this.IP1Label.AutoSize = true;
            this.IP1Label.BackColor = System.Drawing.Color.Transparent;
            this.IP1Label.Dock = System.Windows.Forms.DockStyle.Left;
            this.IP1Label.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IP1Label.ForeColor = System.Drawing.Color.White;
            this.IP1Label.Location = new System.Drawing.Point(103, 2);
            this.IP1Label.Name = "IP1Label";
            this.IP1Label.Padding = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.IP1Label.Size = new System.Drawing.Size(109, 17);
            this.IP1Label.TabIndex = 2;
            this.IP1Label.Text = "000.000.000.000";
            this.IP1Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CopytoolTip.SetToolTip(this.IP1Label, "Click to copy to clipboard.");
            this.IP1Label.Click += new System.EventHandler(this.Labels_Click);
            // 
            // DnsLabel
            // 
            this.DnsLabel.AutoSize = true;
            this.DnsLabel.BackColor = System.Drawing.Color.Transparent;
            this.DnsLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.DnsLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DnsLabel.ForeColor = System.Drawing.Color.White;
            this.DnsLabel.Location = new System.Drawing.Point(103, 36);
            this.DnsLabel.Name = "DnsLabel";
            this.DnsLabel.Padding = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.DnsLabel.Size = new System.Drawing.Size(109, 17);
            this.DnsLabel.TabIndex = 3;
            this.DnsLabel.Text = "000.000.000.000";
            this.DnsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CopytoolTip.SetToolTip(this.DnsLabel, "Click to copy to clipboard.");
            this.DnsLabel.Click += new System.EventHandler(this.Labels_Click);
            // 
            // GatewayLabel
            // 
            this.GatewayLabel.AutoSize = true;
            this.GatewayLabel.BackColor = System.Drawing.Color.Transparent;
            this.GatewayLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.GatewayLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GatewayLabel.ForeColor = System.Drawing.Color.White;
            this.GatewayLabel.Location = new System.Drawing.Point(103, 19);
            this.GatewayLabel.Name = "GatewayLabel";
            this.GatewayLabel.Padding = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.GatewayLabel.Size = new System.Drawing.Size(109, 17);
            this.GatewayLabel.TabIndex = 4;
            this.GatewayLabel.Text = "000.000.000.000";
            this.GatewayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CopytoolTip.SetToolTip(this.GatewayLabel, "Click to copy to clipboard.");
            this.GatewayLabel.Click += new System.EventHandler(this.Labels_Click);
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.BackColor = System.Drawing.Color.Transparent;
            this.UserLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.UserLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLabel.ForeColor = System.Drawing.Color.White;
            this.UserLabel.Location = new System.Drawing.Point(103, 20);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Padding = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.UserLabel.Size = new System.Drawing.Size(86, 19);
            this.UserLabel.TabIndex = 9;
            this.UserLabel.Text = "usernaame";
            this.UserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CopytoolTip.SetToolTip(this.UserLabel, "Click to copy to clipboard.");
            this.UserLabel.Click += new System.EventHandler(this.Labels_Click);
            // 
            // usertitle
            // 
            this.usertitle.AutoSize = true;
            this.usertitle.BackColor = System.Drawing.Color.Transparent;
            this.usertitle.Dock = System.Windows.Forms.DockStyle.Right;
            this.usertitle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usertitle.ForeColor = System.Drawing.Color.White;
            this.usertitle.Location = new System.Drawing.Point(11, 20);
            this.usertitle.Name = "usertitle";
            this.usertitle.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.usertitle.Size = new System.Drawing.Size(86, 19);
            this.usertitle.TabIndex = 8;
            this.usertitle.Text = "Logged As:";
            this.usertitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gatewaytitle
            // 
            this.gatewaytitle.AutoSize = true;
            this.gatewaytitle.BackColor = System.Drawing.Color.Transparent;
            this.gatewaytitle.Dock = System.Windows.Forms.DockStyle.Right;
            this.gatewaytitle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gatewaytitle.ForeColor = System.Drawing.Color.White;
            this.gatewaytitle.Location = new System.Drawing.Point(53, 36);
            this.gatewaytitle.Name = "gatewaytitle";
            this.gatewaytitle.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.gatewaytitle.Size = new System.Drawing.Size(44, 17);
            this.gatewaytitle.TabIndex = 7;
            this.gatewaytitle.Text = "DNS:";
            this.gatewaytitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dnstitle
            // 
            this.dnstitle.AutoSize = true;
            this.dnstitle.BackColor = System.Drawing.Color.Transparent;
            this.dnstitle.Dock = System.Windows.Forms.DockStyle.Right;
            this.dnstitle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dnstitle.ForeColor = System.Drawing.Color.White;
            this.dnstitle.Location = new System.Drawing.Point(19, 19);
            this.dnstitle.Name = "dnstitle";
            this.dnstitle.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.dnstitle.Size = new System.Drawing.Size(78, 17);
            this.dnstitle.TabIndex = 6;
            this.dnstitle.Text = "Gateway:";
            this.dnstitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FQDNLabel
            // 
            this.FQDNLabel.AutoSize = true;
            this.FQDNLabel.BackColor = System.Drawing.Color.Transparent;
            this.FQDNLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.FQDNLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FQDNLabel.ForeColor = System.Drawing.Color.White;
            this.FQDNLabel.Location = new System.Drawing.Point(103, 2);
            this.FQDNLabel.Name = "FQDNLabel";
            this.FQDNLabel.Padding = new System.Windows.Forms.Padding(0, 2, 6, 0);
            this.FQDNLabel.Size = new System.Drawing.Size(85, 18);
            this.FQDNLabel.TabIndex = 5;
            this.FQDNLabel.Text = "FQDNLabel";
            this.FQDNLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CopytoolTip.SetToolTip(this.FQDNLabel, "Click to copy to clipboard.");
            this.FQDNLabel.Click += new System.EventHandler(this.Labels_Click);
            // 
            // CopytoolTip
            // 
            this.CopytoolTip.BackColor = System.Drawing.SystemColors.Highlight;
            this.CopytoolTip.ForeColor = System.Drawing.SystemColors.Info;
            // 
            // topPanel
            // 
            this.topPanel.AutoSize = true;
            this.topPanel.BackColor = System.Drawing.Color.DimGray;
            this.topPanel.Controls.Add(this.topTable);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(223, 41);
            this.topPanel.TabIndex = 13;
            // 
            // topTable
            // 
            this.topTable.AutoSize = true;
            this.topTable.ColumnCount = 2;
            this.topTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.topTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.topTable.Controls.Add(this.UserLabel, 1, 1);
            this.topTable.Controls.Add(this.usertitle, 0, 1);
            this.topTable.Controls.Add(this.FQDNLabel, 1, 0);
            this.topTable.Controls.Add(this.fqdntitle, 0, 0);
            this.topTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topTable.Location = new System.Drawing.Point(0, 0);
            this.topTable.Name = "topTable";
            this.topTable.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.topTable.RowCount = 2;
            this.topTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.topTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.topTable.Size = new System.Drawing.Size(223, 41);
            this.topTable.TabIndex = 0;
            // 
            // bottomPanel
            // 
            this.bottomPanel.AutoSize = true;
            this.bottomPanel.Controls.Add(this.bottomTable);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 41);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.bottomPanel.Size = new System.Drawing.Size(223, 57);
            this.bottomPanel.TabIndex = 14;
            // 
            // bottomTable
            // 
            this.bottomTable.AutoSize = true;
            this.bottomTable.ColumnCount = 2;
            this.bottomTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.bottomTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.bottomTable.Controls.Add(this.DnsLabel, 1, 2);
            this.bottomTable.Controls.Add(this.gatewaytitle, 0, 2);
            this.bottomTable.Controls.Add(this.GatewayLabel, 1, 1);
            this.bottomTable.Controls.Add(this.IP1Label, 1, 0);
            this.bottomTable.Controls.Add(this.iptitle, 0, 0);
            this.bottomTable.Controls.Add(this.dnstitle, 0, 1);
            this.bottomTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomTable.ForeColor = System.Drawing.Color.White;
            this.bottomTable.Location = new System.Drawing.Point(0, 0);
            this.bottomTable.Name = "bottomTable";
            this.bottomTable.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.bottomTable.RowCount = 3;
            this.bottomTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.bottomTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.bottomTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.bottomTable.Size = new System.Drawing.Size(223, 55);
            this.bottomTable.TabIndex = 0;
            // 
            // MainFormElipse
            // 
            this.MainFormElipse.CornerRadius = 15;
            this.MainFormElipse.TargetControl = this;
            // 
            // PCTagMainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(223, 98);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.bottomPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PCTagMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PC Tag";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PCTagMainForm_FormClosing);
            this.Load += new System.EventHandler(this.PCTagMainForm_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.topTable.ResumeLayout(false);
            this.topTable.PerformLayout();
            this.bottomPanel.ResumeLayout(false);
            this.bottomPanel.PerformLayout();
            this.bottomTable.ResumeLayout(false);
            this.bottomTable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fqdntitle;
        private System.Windows.Forms.Label iptitle;
        private System.Windows.Forms.Label IP1Label;
        private System.Windows.Forms.Label DnsLabel;
        private System.Windows.Forms.Label GatewayLabel;
        private System.Windows.Forms.Label FQDNLabel;
        private System.Windows.Forms.Label gatewaytitle;
        private System.Windows.Forms.Label dnstitle;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.Label usertitle;
        private System.Windows.Forms.ToolTip CopytoolTip;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.TableLayoutPanel bottomTable;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.TableLayoutPanel topTable;
        private ElipseControl MainFormElipse;
    }
}

