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
            this.StatsTimer = new System.Windows.Forms.Timer(this.components);
            this.MainFormElipse = new PCTag.ElipseControl();
            this.mainTable = new System.Windows.Forms.TableLayoutPanel();
            this.upperMidTable = new System.Windows.Forms.TableLayoutPanel();
            this.bottomMidTable = new System.Windows.Forms.TableLayoutPanel();
            this.MainTableElipse = new PCTag.ElipseControl();
            this.mainTable.SuspendLayout();
            this.upperMidTable.SuspendLayout();
            this.bottomMidTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // fqdntitle
            // 
            this.fqdntitle.AutoSize = true;
            this.fqdntitle.BackColor = System.Drawing.Color.Transparent;
            this.fqdntitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fqdntitle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fqdntitle.ForeColor = System.Drawing.Color.White;
            this.fqdntitle.Location = new System.Drawing.Point(3, 0);
            this.fqdntitle.Name = "fqdntitle";
            this.fqdntitle.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.fqdntitle.Size = new System.Drawing.Size(86, 20);
            this.fqdntitle.TabIndex = 0;
            this.fqdntitle.Text = "FQDN:";
            this.fqdntitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // iptitle
            // 
            this.iptitle.AutoSize = true;
            this.iptitle.BackColor = System.Drawing.Color.Transparent;
            this.iptitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iptitle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iptitle.ForeColor = System.Drawing.Color.White;
            this.iptitle.Location = new System.Drawing.Point(3, 0);
            this.iptitle.Name = "iptitle";
            this.iptitle.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.iptitle.Size = new System.Drawing.Size(82, 20);
            this.iptitle.TabIndex = 1;
            this.iptitle.Text = "IP Address:";
            this.iptitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // IP1Label
            // 
            this.IP1Label.AutoSize = true;
            this.IP1Label.BackColor = System.Drawing.Color.Transparent;
            this.IP1Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IP1Label.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IP1Label.ForeColor = System.Drawing.Color.White;
            this.IP1Label.Location = new System.Drawing.Point(91, 0);
            this.IP1Label.Name = "IP1Label";
            this.IP1Label.Padding = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.IP1Label.Size = new System.Drawing.Size(109, 20);
            this.IP1Label.TabIndex = 2;
            this.IP1Label.Text = "000.000.000.000";
            this.IP1Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DnsLabel
            // 
            this.DnsLabel.AutoSize = true;
            this.DnsLabel.BackColor = System.Drawing.Color.Transparent;
            this.DnsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DnsLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DnsLabel.ForeColor = System.Drawing.Color.White;
            this.DnsLabel.Location = new System.Drawing.Point(91, 40);
            this.DnsLabel.Name = "DnsLabel";
            this.DnsLabel.Padding = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.DnsLabel.Size = new System.Drawing.Size(109, 20);
            this.DnsLabel.TabIndex = 3;
            this.DnsLabel.Text = "000.000.000.000";
            this.DnsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GatewayLabel
            // 
            this.GatewayLabel.AutoSize = true;
            this.GatewayLabel.BackColor = System.Drawing.Color.Transparent;
            this.GatewayLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GatewayLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GatewayLabel.ForeColor = System.Drawing.Color.White;
            this.GatewayLabel.Location = new System.Drawing.Point(91, 20);
            this.GatewayLabel.Name = "GatewayLabel";
            this.GatewayLabel.Padding = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.GatewayLabel.Size = new System.Drawing.Size(109, 20);
            this.GatewayLabel.TabIndex = 4;
            this.GatewayLabel.Text = "000.000.000.000";
            this.GatewayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.BackColor = System.Drawing.Color.Transparent;
            this.UserLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLabel.ForeColor = System.Drawing.Color.White;
            this.UserLabel.Location = new System.Drawing.Point(95, 20);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Padding = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.UserLabel.Size = new System.Drawing.Size(105, 22);
            this.UserLabel.TabIndex = 9;
            this.UserLabel.Text = "usernaame";
            this.UserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // usertitle
            // 
            this.usertitle.AutoSize = true;
            this.usertitle.BackColor = System.Drawing.Color.Transparent;
            this.usertitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usertitle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usertitle.ForeColor = System.Drawing.Color.White;
            this.usertitle.Location = new System.Drawing.Point(3, 20);
            this.usertitle.Name = "usertitle";
            this.usertitle.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.usertitle.Size = new System.Drawing.Size(86, 22);
            this.usertitle.TabIndex = 8;
            this.usertitle.Text = "Logged As:";
            this.usertitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gatewaytitle
            // 
            this.gatewaytitle.AutoSize = true;
            this.gatewaytitle.BackColor = System.Drawing.Color.Transparent;
            this.gatewaytitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gatewaytitle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gatewaytitle.ForeColor = System.Drawing.Color.White;
            this.gatewaytitle.Location = new System.Drawing.Point(3, 40);
            this.gatewaytitle.Name = "gatewaytitle";
            this.gatewaytitle.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.gatewaytitle.Size = new System.Drawing.Size(82, 20);
            this.gatewaytitle.TabIndex = 7;
            this.gatewaytitle.Text = "DNS:";
            this.gatewaytitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dnstitle
            // 
            this.dnstitle.AutoSize = true;
            this.dnstitle.BackColor = System.Drawing.Color.Transparent;
            this.dnstitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dnstitle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dnstitle.ForeColor = System.Drawing.Color.White;
            this.dnstitle.Location = new System.Drawing.Point(3, 20);
            this.dnstitle.Name = "dnstitle";
            this.dnstitle.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.dnstitle.Size = new System.Drawing.Size(82, 20);
            this.dnstitle.TabIndex = 6;
            this.dnstitle.Text = "Gateway:";
            this.dnstitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FQDNLabel
            // 
            this.FQDNLabel.AutoSize = true;
            this.FQDNLabel.BackColor = System.Drawing.Color.Transparent;
            this.FQDNLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FQDNLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FQDNLabel.ForeColor = System.Drawing.Color.White;
            this.FQDNLabel.Location = new System.Drawing.Point(95, 0);
            this.FQDNLabel.Name = "FQDNLabel";
            this.FQDNLabel.Padding = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.FQDNLabel.Size = new System.Drawing.Size(105, 20);
            this.FQDNLabel.TabIndex = 5;
            this.FQDNLabel.Text = "FQDNLabel";
            this.FQDNLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainFormElipse
            // 
            this.MainFormElipse.CornerRadius = 20;
            this.MainFormElipse.TargetControl = this;
            // 
            // mainTable
            // 
            this.mainTable.AutoSize = true;
            this.mainTable.ColumnCount = 1;
            this.mainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mainTable.Controls.Add(this.upperMidTable, 0, 0);
            this.mainTable.Controls.Add(this.bottomMidTable, 0, 1);
            this.mainTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTable.Location = new System.Drawing.Point(0, 0);
            this.mainTable.Name = "mainTable";
            this.mainTable.Padding = new System.Windows.Forms.Padding(4);
            this.mainTable.RowCount = 2;
            this.mainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.24324F));
            this.mainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.75676F));
            this.mainTable.Size = new System.Drawing.Size(216, 119);
            this.mainTable.TabIndex = 11;
            // 
            // upperMidTable
            // 
            this.upperMidTable.AutoSize = true;
            this.upperMidTable.BackColor = System.Drawing.Color.DimGray;
            this.upperMidTable.ColumnCount = 2;
            this.upperMidTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.upperMidTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.upperMidTable.Controls.Add(this.FQDNLabel, 1, 0);
            this.upperMidTable.Controls.Add(this.fqdntitle, 0, 0);
            this.upperMidTable.Controls.Add(this.usertitle, 0, 1);
            this.upperMidTable.Controls.Add(this.UserLabel, 1, 1);
            this.upperMidTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.upperMidTable.Location = new System.Drawing.Point(7, 7);
            this.upperMidTable.Name = "upperMidTable";
            this.upperMidTable.RowCount = 2;
            this.upperMidTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.upperMidTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.upperMidTable.Size = new System.Drawing.Size(203, 42);
            this.upperMidTable.TabIndex = 0;
            // 
            // bottomMidTable
            // 
            this.bottomMidTable.AutoSize = true;
            this.bottomMidTable.BackColor = System.Drawing.Color.Black;
            this.bottomMidTable.ColumnCount = 2;
            this.bottomMidTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.bottomMidTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.bottomMidTable.Controls.Add(this.DnsLabel, 1, 2);
            this.bottomMidTable.Controls.Add(this.GatewayLabel, 1, 1);
            this.bottomMidTable.Controls.Add(this.IP1Label, 1, 0);
            this.bottomMidTable.Controls.Add(this.gatewaytitle, 0, 2);
            this.bottomMidTable.Controls.Add(this.iptitle, 0, 0);
            this.bottomMidTable.Controls.Add(this.dnstitle, 0, 1);
            this.bottomMidTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomMidTable.Location = new System.Drawing.Point(7, 55);
            this.bottomMidTable.Name = "bottomMidTable";
            this.bottomMidTable.RowCount = 3;
            this.bottomMidTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.bottomMidTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.bottomMidTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.bottomMidTable.Size = new System.Drawing.Size(203, 57);
            this.bottomMidTable.TabIndex = 1;
            // 
            // MainTableElipse
            // 
            this.MainTableElipse.CornerRadius = 15;
            this.MainTableElipse.TargetControl = this.upperMidTable;
            // 
            // PCTagMainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(216, 119);
            this.Controls.Add(this.mainTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PCTagMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PC Tag";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PCTagMainForm_FormClosing);
            this.Load += new System.EventHandler(this.PCTagMainForm_Load);
            this.mainTable.ResumeLayout(false);
            this.mainTable.PerformLayout();
            this.upperMidTable.ResumeLayout(false);
            this.upperMidTable.PerformLayout();
            this.bottomMidTable.ResumeLayout(false);
            this.bottomMidTable.PerformLayout();
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
        private System.Windows.Forms.Timer StatsTimer;
        private ElipseControl MainFormElipse;
        private System.Windows.Forms.TableLayoutPanel mainTable;
        private System.Windows.Forms.TableLayoutPanel upperMidTable;
        private System.Windows.Forms.TableLayoutPanel bottomMidTable;
        private ElipseControl MainTableElipse;
    }
}

