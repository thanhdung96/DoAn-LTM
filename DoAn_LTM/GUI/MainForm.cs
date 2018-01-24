using ProtocolHeaders;
using RawSocket;
using System.Collections.Generic;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace DoAn_LTM.GUI
{
	public partial class MainForm : Form
	{
		private List<IPMacPair> hosts;
		private List<int> OpenPorts;
		private List<Thread> ThreadPool;
		private const int POOL_SIZE = 4;

		#region events implements
		public MainForm()
		{
			InitializeComponent();
			pgbStatus.Style = ProgressBarStyle.Blocks;
		}

		private void MainForm_Shown(object sender, System.EventArgs e)
		{
			GetLocalInfo();

			hosts = new List<IPMacPair>();

			rbtnFullScan.CheckedChanged += rbtnFullScan_CheckedChanged;
		}

		private void btnFindStations_Click(object sender, System.EventArgs e)
		{
			NetworkDiscovery discovery = new NetworkDiscovery(lblSubnet.Text, lblBroadcast.Text);
			List<IPMacPair> temp = new List<IPMacPair>();
			temp = discovery.getARP(rbtnAgressively.Checked);

			//filtering ip in same subnet
			for (int i = 0; i < temp.Count; i++)
				if (CheckSameSubnet(IPAddress.Parse(temp[i].IP)))
					hosts.Add(temp[i]);
			temp.Clear();

			//update vendor from mac
			UpdateVendor();

			dgvStations.DataSource = null;
			dgvStations.DataSource = hosts;
		}

		private void btnScan_Click(object sender, System.EventArgs e)
		{
			/*ThreadStart childref = new ThreadStart(ScanPort);
			Thread childThread = new Thread(childref);
			childThread.Start();

			pgbStatus.Style = ProgressBarStyle.Marquee;
			btnScan.Enabled = false;*/
			pgbStatus.Style = ProgressBarStyle.Marquee;
			btnScan.Enabled = false;
			ScanPort();
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
	}
}
