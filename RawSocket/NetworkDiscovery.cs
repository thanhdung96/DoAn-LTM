﻿using ProtocolHeaders;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;

namespace RawSocket
{
	public class NetworkDiscovery
	{
		#region variables
		private ICMPHeader packet;
		private Socket host;
		private string hostIP;
		private IPEndPoint iep;
		private EndPoint ep;

		private byte[] data;
		private int recv;
		private const int BUFFER_SIZE = 1024;
		#endregion

		public NetworkDiscovery(string broadcastIP)
		{
			this.hostIP = broadcastIP;
		}

		#region private functions
		private void Init()
		{
			Console.WriteLine("Preparing ICMP packet");
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
			data = Encoding.ASCII.GetBytes("test packet");
			Buffer.BlockCopy(data, 0, packet.Message, 4, data.Length);
			packet.Messagesize = data.Length + 4;
			packet.Checksum = packet.getChecksum();

			host.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReceiveTimeout, 3000);
			Console.WriteLine("ICMP packet prepared");
		}

		private void StartPing()
		{
			Console.WriteLine("Sending ICMP packet");
			host.SendTo(packet.getBytes(), packet.Messagesize + 4, SocketFlags.None, iep);
			try
			{
				data = new byte[BUFFER_SIZE];
				recv = host.ReceiveFrom(data, ref ep);
				Console.WriteLine("ICMP response received");
			}
			catch (SocketException exc)
			{
				Console.WriteLine(exc.Message);
			}

			ICMPHeader response = new ICMPHeader(data, recv);
			Console.WriteLine("response from: {0}", ep.ToString());
			Console.WriteLine("  Type {0}", response.Type);
			Console.WriteLine("  Code: {0}", response.Code);
			int Identifier = BitConverter.ToInt16(response.Message, 0);
			int Sequence = BitConverter.ToInt16(response.Message, 2);
			Console.WriteLine("  Identifier: {0}", Identifier);
			Console.WriteLine("  Sequence: {0}", Sequence);
			string stringData = Encoding.ASCII.GetString(response.Message, 4, response.Messagesize - 4);
			Console.WriteLine("  data: {0}", stringData);
			host.Close();
		}
		#endregion

		public List<IPMacPair> getARP()
		{
			Init();
			StartPing();

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
				Console.Write(m.Groups["mac"].Value + " ");
				Console.Write(m.Groups["ip"].Value);
				pair.Add(new IPMacPair(m.Groups["mac"].Value, m.Groups["ip"].Value));
				Console.WriteLine();
			}
			return pair;
		}
	}
}
