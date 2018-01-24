using DoAn_LTM.Network;
using ProtocolHeaders;
using RawSocket;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace DoAn_LTM.GUI
{
	public partial class MainForm// : Form
	{
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

		private void UpdateVendor()
		{
			VendorList vl = new VendorList();

			foreach (IPMacPair imp in hosts)
			{
				string[] mac = imp.MAC.Split('-');
				imp.Vendor = vl.FindVendorByMac(string.Join("", mac, 0, 3));
			}
		}

		private void ScanPort()
		{
			string IP;
			IPAddress remoteHost;
			PortDiscovery discovery;
			UInt16 from, to;

			if (dgvStations.SelectedCells.Count > 0)
			{
				int selectedrowindex = dgvStations.SelectedCells[1].RowIndex;
				DataGridViewRow selectedRow = dgvStations.Rows[selectedrowindex];
				IP = Convert.ToString(selectedRow.Cells["IP"].Value);

				remoteHost = IPAddress.Parse(IP);
				if (rbtnFullScan.Checked)
				{
					from = 1;
					to = 65535;
				}
				else
				{
					from = Convert.ToUInt16(nudFrom.Value);
					to = Convert.ToUInt16(nudTo.Value);
				}
				for (int i = 0; i < POOL_SIZE; i++)
				{
					discovery = new PortDiscovery(from, to, remoteHost);
					OpenPorts = new List<int>();

					discovery.BeginScanPort(ref OpenPorts);
				}

				foreach (int port in OpenPorts)
					lbxOpenports.Items.Add(port);
				lblStatus.Text = OpenPorts.Count + " port(s) are open";
			}

			pgbStatus.Style = ProgressBarStyle.Blocks;
			btnScan.Enabled = true;
		}
		#endregion
	}
}
