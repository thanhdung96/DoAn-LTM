namespace RawSocket
{
	public class IPMacPair
	{
		private string ip;
		private string mac;

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

		public IPMacPair(string ip, string mac)
		{
			this.IP = ip;
			this.MAC = mac;
		}
	}
}
