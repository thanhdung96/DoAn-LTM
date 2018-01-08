namespace DoAn_LTM.Network
{
	using System.Collections.Generic;
	using System.IO;
	using System;
	using System.Linq;

	public class VendorList
	{
		private List<MACVendor> vendorlist;

		public VendorList()
		{
			vendorlist = new List<MACVendor>();

			ParseDb();
		}

		private void ParseDb()
		{
			string line;
			using (StreamReader file = new StreamReader("mv.dat"))
			{
				while ((line = file.ReadLine()) != null)
				{
					string[] entry = line.Split('\t');
					vendorlist.Add(new MACVendor(entry[0], entry[1]));
				}
				file.Close();
			}
		}

		public string FindVendorByMac(string mac)
		{
			try{
				return vendorlist.Where(res => res.Mac == mac).First().Vendor;
			}
			catch (InvalidOperationException)
			{
				return "";
			}
		}
	}
}
