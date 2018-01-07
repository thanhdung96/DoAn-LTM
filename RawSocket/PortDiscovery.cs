﻿using System;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;

namespace RawSocket
{
	class ScanRange
	{
		UInt16 from;
		UInt16 to;

		public UInt16 From
		{
			get { return from; }
			set { from = value; }
		}
		public UInt16 To
		{
			get { return to; }
			set { to = value; }
		}

		public ScanRange(UInt16 from, UInt16 to)
		{
			this.From = from;
			this.To = to;
		}
	}

	public class PortDiscovery
	{
		private const int timeout = 10;
		private IPAddress remoteHost;
		private ScanRange range;
		private Socket socket;

		public PortDiscovery(UInt16 from, UInt16 to, IPAddress remoteHost)
		{
			this.remoteHost = remoteHost;
			this.range = new ScanRange(from, to);
			socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.DontLinger, false);
		}

		public void BeginScanPort(ref List<int> OpenPorts)
		{
			//whole operation will take about 11 mins for full scan
			for (int port = this.range.From; port < this.range.To; port++)
			{
				try
				{
					IAsyncResult result = socket.BeginConnect(this.remoteHost, port, null, null);
					bool ok = result.AsyncWaitHandle.WaitOne(timeout);	//wait for 10ms
					if (ok)
					{
						OpenPorts.Add(port);
					}
				}
				catch (SocketException)
				{
					throw null;
				}
				finally
				{
					socket.Disconnect(true);
				}
			}
		}
	}
}