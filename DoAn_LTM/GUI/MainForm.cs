using System.Windows.Forms;
using System.Collections.Generic;
using RawSocket;

namespace DoAn_LTM.GUI
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			rbtnFullScan.CheckedChanged += rbtnFullScan_CheckedChanged;
			nudFrom.Enabled = false;
			nudTo.Enabled = false;
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
			NetworkDiscovery discovery = new NetworkDiscovery("172.17.255.255");
			hosts = discovery.getARP();
		}
	}
}
