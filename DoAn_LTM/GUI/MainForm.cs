using System.Windows.Forms;
using System.Collections.Generic;
using System.Net;
using System.Net.NetworkInformation;
using System.ComponentModel;
using RawSocket;

namespace DoAn_LTM.GUI
{
	public partial class MainForm : Form
	{
		private List<IPMacPair> hosts;

		#region events implements
		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Shown(object sender, System.EventArgs e)
		{
			GetLocalInfo();

			hosts = new List<IPMacPair>();

			dgvStations.DataSource = hosts;

			rbtnFullScan.CheckedChanged += rbtnFullScan_CheckedChanged;
			nudFrom.Enabled = false;
			nudTo.Enabled = false;
		}

		private void btnFindStations_Click(object sender, System.EventArgs e)
		{
			NetworkDiscovery discovery = new NetworkDiscovery(lblBroadcast.Text);
			hosts = discovery.getARP();

			//filtering ip in same subnet
			List<IPMacPair> temp = new List<IPMacPair>();
			for (int i = 0; i < hosts.Count; i++)
				if (CheckSameSubnet(IPAddress.Parse(hosts[i].IP)))
					temp.Add(hosts[i]);
			hosts.Clear();
			hosts = temp;

			dgvStations.DataSource = null;
			dgvStations.DataSource = hosts;
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

		private void cbxIP_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			string[] selectedIP = cbxIP.SelectedItem.ToString().Split(';');
			lblNetmask.Text = selectedIP[1];
			lblNICName.Text = selectedIP[2];
			lblBroadcast.Text = GetBroadCast(IPAddress.Parse(selectedIP[0]), IPAddress.Parse(selectedIP[1])).ToString();
			lblSubnet.Text = GetSubnet(IPAddress.Parse(lblNetmask.Text), IPAddress.Parse(selectedIP[0])).ToString();
		}


		#endregion

		#region customized functions

		private bool CheckSameSubnet(IPAddress iPAddress)
		{
			IPAddress subnet = IPAddress.Parse(lblSubnet.Text);
			IPAddress netmask = IPAddress.Parse(lblNetmask.Text);
			return subnet.Address == (iPAddress.Address & netmask.Address);
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
		}

		private IPAddress GetSubnet(IPAddress netmask, IPAddress IP)
		{
			byte[] subnet = new byte[4];
			byte[] netmaskByte = netmask.GetAddressBytes();
			byte[] ipByte = IP.GetAddressBytes();
			for (int i = 0; i < 4; i++)
			{
				subnet[i] = (byte)(netmaskByte[i] & ipByte[i]);
			}
			return new IPAddress(subnet);
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

		#endregion
	}
}
