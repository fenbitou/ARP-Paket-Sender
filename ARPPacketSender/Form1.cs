using System;
using SharpPcap;
using System.Windows.Forms;
using SharpPcap.LibPcap;
using PacketDotNet;
using System.Net;
using System.Net.NetworkInformation;

namespace ARPPacketSender
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadDevice();//加载窗体时加载网卡
        }

        ICaptureDevice device;// 定义设备
        int Count = 0;              //计数器

        private void loadDevice()// 获取网卡列表方法
        {
            try
            {
                foreach (var i in LibPcapLiveDeviceList.Instance)
                {
                    comDeviceList.Items.Add(i.Interface.FriendlyName);  //在下拉菜单中添加网卡信息
                }

                if (comDeviceList.Items.Count > 0)
                {
                    comDeviceList.SelectedIndex = 0;//自动选中第一个
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        //选择网卡
        private void comDeviceList_SelectedIndexChanged(object sender, EventArgs e)
        {
            device = CaptureDeviceList.Instance[comDeviceList.SelectedIndex];
            device.Open();
          
            string hostMAC=MacFormat( ((SharpPcap.WinPcap.WinPcapDevice)device).MacAddress.ToString() );
            string hostIP = ((SharpPcap.WinPcap.WinPcapDevice)device).Addresses[1].Addr.ipAddress.ToString();

            txtEhSourMac.Text = hostMAC;
            txtARPSourMac.Text = txtEhSourMac.Text;

            txtARPSourIP.Text = hostIP;

            txtInterval.Text = "5";
            rdoResp.Checked = true;
        }

        private EthernetPacket aARPPacket()
        {
            string strEthDestMAC = txtEhDestMac.Text; 
            string strEhSourMac = txtEhSourMac.Text;

            string strARPSourIP = txtARPSourIP.Text;
            string strARPSourMac = txtARPSourMac.Text;

            string strARPDestIP = txtARPDestIP.Text;
            string strARPDestMac = txtARPDestMac.Text;

            if (rdoReq.Checked)
            {
                ARPPacket arp = new ARPPacket(ARPOperation.Request, PhysicalAddress.Parse(strARPDestMac), IPAddress.Parse(strARPDestIP), PhysicalAddress.Parse(strARPSourMac), IPAddress.Parse(strARPSourIP));
                EthernetPacket eth = new EthernetPacket(PhysicalAddress.Parse(strEhSourMac), PhysicalAddress.Parse(strEthDestMAC), EthernetPacketType.Arp);
                eth.PayloadPacket = arp;

                return eth;
            }

            else
            {
                ARPPacket arp = new ARPPacket(ARPOperation.Response, PhysicalAddress.Parse(strARPDestMac), IPAddress.Parse(strARPDestIP), PhysicalAddress.Parse(strARPSourMac), IPAddress.Parse(strARPSourIP));
                EthernetPacket eth = new EthernetPacket(PhysicalAddress.Parse(strEhSourMac), PhysicalAddress.Parse(strEthDestMAC), EthernetPacketType.Arp);
                eth.PayloadPacket = arp;

                return eth;
            }
        }

        Timer myTimer = new Timer();
        private void btnSend_Click(object sender, EventArgs e)
        {
            Count = 0;
            myTimer.Tick += new EventHandler(SendPacket);
            myTimer.Enabled = true;
            myTimer.Interval = int.Parse(txtInterval.Text);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            myTimer.Stop();
            //device.Close();
        }

        private void SendPacket(object sender, EventArgs e)
        {
            EthernetPacket eth = aARPPacket();
            device.SendPacket(eth);
            Count++;
            txtCount.Text = Count.ToString();
        }

        private string MacFormat(string MacAddress)
        {
            for (int i = 10; i > 0; i = i - 2)
            {
                MacAddress = MacAddress.Insert(i, "-");
            }
            return MacAddress;
        }
    }
}
