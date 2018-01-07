namespace RawSocket
{
	using System.Net;
	using System.Net.Sockets;
	using System.Collections.Generic;
	using System;

	class Program
	{
		private static PortDiscovery discovery;
		private static List<int> OpenPorts;
		static void Main(string[] args)
		{
			discovery = new PortDiscovery(1, 30, IPAddress.Parse("192.168.1.92"));
			OpenPorts = new List<int>();
			discovery.BeginScanPort(ref OpenPorts);
		}
	}
}
