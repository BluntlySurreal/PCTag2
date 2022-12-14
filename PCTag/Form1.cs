using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;

namespace PCTag
{
    public partial class PCTag2MainForm : Form
    {
        private NotifyIcon TrayIcon;
        internal ContextMenu SysTrayMenu;
        private Color clr;
        private int Red, Green, Blue;
        public PCTag2MainForm()
        {
            InitializeComponent();
            SysTrayMenu = new ContextMenu();
            TrayIcon = new NotifyIcon();
            SysTrayMenu.MenuItems.Add("About", ShowAbout); //[1]
            SysTrayMenu.MenuItems.Add("-"); //Divider
            SysTrayMenu.MenuItems.Add("Close", Exit);//[2]
            TrayIcon.Text = "PC Tag, Bluntly";
            Icon ico = this.Icon;
            TrayIcon.Icon = new Icon(ico, 60, 60);
            TrayIcon.ContextMenu = SysTrayMenu;
            TrayIcon.Visible = true;
        }

        protected override void OnLoad(EventArgs e)
        {
            Visible = true; // Hide form window.
            ShowInTaskbar = false; // Remove from taskbar.
            base.OnLoad(e);
        }

        private void ShowAbout(object sender, EventArgs e)
        {
            AboutForm aboutform = new AboutForm();
            aboutform.ShowDialog();
        }
        private void Exit(object sender, EventArgs e)
        {
            this.Close();
        }

        private string hostName, domainName;

        private void PCTagMainForm_Load(object sender, EventArgs e)
        {
            clr = Color.White;
            Red = clr.R;
            Green = clr.G;
            Blue = clr.B;
            GetAllInfo();
        }

        private void GetAllInfo()
        {
            this.SendToBack();
            try
            {
                domainName = IPGlobalProperties.GetIPGlobalProperties().DomainName;
                hostName = Dns.GetHostName();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

            GetFQDN(FQDNLabel);
            GetIp(IP1Label);
            GetGateway(GatewayLabel);
            GetDns(DnsLabel);
            GetCurrentUser(UserLabel);
            RepositionWindow();
        }

        private void RepositionWindow()
        {
            Rectangle workingArea = Screen.GetWorkingArea(this);
            this.Location = new Point(workingArea.Right - Size.Width - 6, workingArea.Bottom - Size.Height - 6);
        }
        private void GetFQDN(Label FQDNlabel)
        {
            try
            {
                domainName = "." + domainName;
                if (!hostName.EndsWith(domainName)) // if hostname does not already include domain name
                {
                    hostName += domainName; // add the domain name part
                }

                if (hostName.EndsWith("."))
                { FQDNlabel.Text = hostName.Remove(hostName.Length - 1, 1); }
                else
                { FQDNlabel.Text = hostName; } // return the fully qualified domain name
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void GetCurrentUser(Label hostnamelabel)
        {
            try
            {
                hostnamelabel.Text = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void GetIp(Label iplabel)
        {
            try
            {
                IPHostEntry myIP = Dns.GetHostEntry(hostName);
                IPAddress[] address = myIP.AddressList;
                IPAddress ipAddress = myIP.AddressList.First(a => a.AddressFamily == AddressFamily.InterNetwork); // ipv4
                iplabel.Text = ipAddress.ToString();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void GetDns(Label dnslabel)
        {
            try
            {
                DnsLabel.Text = " ";
                foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
                {
                    if (ni.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
                    {

                        foreach (IPAddress dnsAdress in ni.GetIPProperties().DnsAddresses)
                        {
                            if (dnsAdress.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                            {
                                dnslabel.Text = dnsAdress.ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void PCTagMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            TrayIcon.Visible = false;
            TrayIcon.Dispose();
            TrayIcon = null;
        }

        private void GetGateway(Label gatewaylabel)
        {
            try
            {
                gatewaylabel.Text = NetworkInterface
                    .GetAllNetworkInterfaces()
                    .Where(n => n.OperationalStatus == OperationalStatus.Up)
                    .Where(n => n.NetworkInterfaceType != NetworkInterfaceType.Loopback)
                    .SelectMany(n => n.GetIPProperties()?.GatewayAddresses)
                    .Select(g => g?.Address)
                    .Where(a => a != null)
                    // .Where(a => a.AddressFamily == AddressFamily.InterNetwork)
                    // .Where(a => Array.FindIndex(a.GetAddressBytes(), b => b != 0) >= 0)
                    .FirstOrDefault()
                    .ToString();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void RefreshpictureBox_Click(object sender, EventArgs e)
        {
            GetAllInfo();
        }

        private void ShiftColors()
        {
            if (clr == Color.White)
            {
                clr = Color.FromArgb(255, 119, 119, 119);
                foreach (Control x in this.topTable.Controls)
                {
                    if (x is Label)
                    {
                        ((Label)x).ForeColor = clr;
                    }
                }

                foreach (Control x in this.bottomTable.Controls)
                {
                    if (x is Label)
                    {
                        ((Label)x).ForeColor = clr;
                    }
                }

                this.BackColor = Color.Black;
                RefreshpictureBox.Image = PCTag.Properties.Resources.Icon_ReloadGray;
                ColorpictureBox.Image = PCTag.Properties.Resources.Icon_ColorSwitchOnGray;
            }

            else if(clr == Color.FromArgb(255, 119, 119, 119))
            {
                clr = Color.Black;
                foreach (Control x in this.bottomTable.Controls)
                {
                    if (x is Label)
                    {
                        ((Label)x).ForeColor = clr;
                    }
                }

                foreach (Control x in this.topTable.Controls)
                {
                    if (x is Label)
                    {
                        ((Label)x).ForeColor = clr;
                    }
                }

                this.BackColor = Color.White;
                RefreshpictureBox.Image = PCTag.Properties.Resources.Icon_ReloadBlack;
                ColorpictureBox.Image = PCTag.Properties.Resources.Icon_ColorSwitchOnWhite;
            }

            else if(clr == Color.Black)
            {
                clr = Color.White;
                foreach (Control x in this.topTable.Controls)
                {
                    if (x is Label)
                    {
                        ((Label)x).ForeColor = clr;
                    }
                }

                foreach (Control x in this.bottomTable.Controls)
                {
                    if (x is Label)
                    {
                        ((Label)x).ForeColor = clr;
                    }
                }

                RefreshpictureBox.Image = PCTag.Properties.Resources.Icon_ReloadWhite;
                ColorpictureBox.Image = PCTag.Properties.Resources.Icon_ColorSwitchOnBlack;
                this.BackColor = Color.Black;
            }
        }

        private void ColorpictureBox_Click(object sender, EventArgs e)
        {
            ShiftColors();
        }

        private void Labels_Click(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            if (!string.IsNullOrEmpty(lbl.Text))
            { Clipboard.SetText(lbl.Text); }
            else { }
        }
    }
}