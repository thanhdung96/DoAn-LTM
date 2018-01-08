namespace ProtocolHeaders
{
	public class IPMacPair
	{
		private string ip;
		private string mac;
		private string vendor;

		public string MAC
		{
			get { return mac; }
			set { mac = value.ToUpper(); }
		}

		public string IP
		{
			get { return ip; }
			set { ip = value; }
		}

		public string Vendor
		{
			get { return vendor; }
			set { vendor = value; }
		}
		
		public IPMacPair(string ip, string mac)
		{
			this.IP = ip;
			this.MAC = mac;
		}
	}
}
