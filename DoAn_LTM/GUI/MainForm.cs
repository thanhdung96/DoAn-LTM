using System.Windows.Forms;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;
using RawSocket;

namespace DoAn_LTM.GUI
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			GetLocalInfo();

			rbtnFullScan.CheckedChanged += rbtnFullScan_CheckedChanged;
			nudFrom.Enabled = false;
			nudTo.Enabled = false;
		}

		private void GetLocalInfo()
		{
			foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
			{
				if (nic.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 || nic.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
				{
					foreach (UnicastIPAddressInformation ip in nic.GetIPProperties().UnicastAddresses)
					{
						if (ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
						{
							cbxIP.Items.Add(ip.Address.ToString() + ";" + ip.IPv4Mask + ";" + nic.Name);
						}
					}
				}
			}
			//cbxIP.SelectedIndex = 0;
		}


		private void cbxIP_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			string[] selectedIP = cbxIP.SelectedItem.ToString().Split(';');
			lblNetmask.Text = selectedIP[1];
			lblNICName.Text = selectedIP[2];
			lblBroadcast.Text = GetBroadCast(IPAddress.Parse(selectedIP[0]), IPAddress.Parse(selectedIP[1])).ToString();
		}

		private IPAddress GetBroadCast(IPAddress host, IPAddress mask)
		{
			byte[] broadcastIPBytes = new byte[4];
			byte[] hostBytes = host.GetAddressBytes();
			byte[] maskBytes = mask.GetAddressBytes();
			for (int i = 0; i < 4; i++)
			{
				broadcastIPBytes[i] = (byte)(hostBytes[i] | (byte)~maskBytes[i]);
			}
			return new IPAddress(broadcastIPBytes);
		}

		void rbtnFullScan_CheckedChanged(object sender, System.EventArgs e)
		{
			if (rbtnFullScan.Checked)
			{
				nudFrom.Enabled = false;
				nudTo.Enabled = false;
			}
			else
			{
				nudFrom.Enabled = true;
				nudTo.Enabled = true;
			}
		}

		private void btnFindStations_Click(object sender, System.EventArgs e)
		{
			List<IPMacPair> hosts = new List<IPMacPair>();
			NetworkDiscovery discovery = new NetworkDiscovery(lblBroadcast.Text);
			hosts = discovery.getARP();
		}
	}
}
