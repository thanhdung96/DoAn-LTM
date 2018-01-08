using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace DoAn_LTM.Network
{
	public class MACVendor
	{
		private string mac;
		private string vendor;

		public string Mac
		{
			get { return mac; }
			set { mac = value; }
		}
		public string Vendor
		{
			get { return vendor; }
			set { vendor = value; }
		}

		public MACVendor(string mac, string vendor)
		{
			this.Mac = mac;
			this.Vendor = vendor;
		}
		public MACVendor() { }
	}
}
