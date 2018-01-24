using ProtocolHeaders;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using NetTools;

namespace RawSocket
{
	public class NetworkDiscovery
	{
		#region variables
		private ICMPHeader packet;
		private Socket host;
		private string hostIP;
		private string subnet;
		private IPEndPoint iep;
		private EndPoint ep;

		private byte[] data;
		private const int BUFFER_SIZE = 1024;
		#endregion

		public NetworkDiscovery(string subnet, string toIP)
		{
			this.hostIP = toIP;
			this.subnet = subnet;
		}

		#region private functions
		private void Init()
		{
			data = new byte[BUFFER_SIZE];
			host = new Socket(AddressFamily.InterNetwork, SocketType.Raw, ProtocolType.Icmp);
			iep = new IPEndPoint(IPAddress.Parse(hostIP), 0);
			ep = (EndPoint)iep;
			packet = new ICMPHeader();

			packet.Type = 0x08;
			packet.Code = 0x00;
			packet.Checksum = 0;
			Buffer.BlockCopy(BitConverter.GetBytes((short)1), 0, packet.Message, 0, 2);
			Buffer.BlockCopy(BitConverter.GetBytes((short)1), 0, packet.Message, 2, 2);
			data = Encoding.ASCII.GetBytes("a");
			Buffer.BlockCopy(data, 0, packet.Message, 4, data.Length);
			packet.Messagesize = data.Length + 4;
			packet.Checksum = packet.getChecksum();

			host.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReceiveTimeout, 100);
		}

		private void StartPing()
		{
			host.SendTo(packet.getBytes(), packet.Messagesize + 4, SocketFlags.None, iep);
			host.Close();
		}

		private void StartPingManually()
		{
			IPAddressRange range = new IPAddressRange(IPAddress.Parse(subnet), IPAddress.Parse(this.hostIP));
			foreach (IPAddress ip in range)
			{
				IPEndPoint manualIEP = new IPEndPoint(ip,0);
				host.SendTo(packet.getBytes(), packet.Messagesize + 4, SocketFlags.None, (EndPoint)manualIEP);
				host.Close();
				host = new Socket(AddressFamily.InterNetwork, SocketType.Raw, ProtocolType.Icmp);
			}
		}
		#endregion

		public List<IPMacPair> getARP(bool manual)
		{
			Init();
			if (!manual)
				StartPing();
			else
				StartPingManually();

			List<IPMacPair> pair = new List<IPMacPair>();
			Process pProcess = new System.Diagnostics.Process();
			pProcess.StartInfo.FileName = "arp";
			pProcess.StartInfo.Arguments = "-a";
			pProcess.StartInfo.UseShellExecute = false;
			pProcess.StartInfo.RedirectStandardOutput = true;
			pProcess.StartInfo.CreateNoWindow = true;
			pProcess.Start();
			string cmdOutput = pProcess.StandardOutput.ReadToEnd();
			string pattern = @"(?<ip>([0-9]{1,3}\.?){4})\s*(?<mac>([a-f0-9]{2}-?){6})";

			foreach (Match m in Regex.Matches(cmdOutput, pattern, RegexOptions.IgnoreCase))
			{
				pair.Add(new IPMacPair(m.Groups["ip"].Value, m.Groups["mac"].Value));
			}
			return pair;
		}
	}
}
