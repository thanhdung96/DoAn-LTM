using System.Windows.Forms;
using System.Net;
using System.Threading;
using System.Net.NetworkInformation;
using System.Text;

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
			AutoResetEvent waiter = new AutoResetEvent(false);
			Ping pingSender = new Ping();
			pingSender.PingCompleted += new PingCompletedEventHandler(PingCompletedCallback);
			IPAddress address = IPAddress.Loopback;
			string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
			byte[] buffer = Encoding.ASCII.GetBytes(data);

			int timeout = 10000;
			PingOptions options = new PingOptions(64, true);
			options.DontFragment = true;
			pingSender.SendAsync(address, timeout, buffer, options, waiter);
			waiter.WaitOne();
		}

		private void PingCompletedCallback(object sender, PingCompletedEventArgs e)
		{
			lbxStatus.Items.Add("Ok");
			lbxStations.Items.Add(e.Reply.Address);
		}
	}
}
