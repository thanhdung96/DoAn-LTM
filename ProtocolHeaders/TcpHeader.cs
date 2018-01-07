using System;
using System.IO;
using System.Net;

namespace ProtocolHeaders
{
	public class TcpHeader
	{
		#region variables
		private UInt16 sourceport;
		private UInt16 destport;
		private UInt32 sequence;
		private UInt32 ack;
		private UInt16 offsetAndReservedAndFlags;
		private UInt16 windowsize;
		private UInt16 checksum;
		private UInt16 urgent;
		private byte[] data;
		#endregion

		#region getter/setter
		public byte[] Data
		{
			get { return data; }
			set { data = value; }
		}

		public UInt16 Urgent
		{
			get { return urgent; }
			set { urgent = value; }
		}

		public UInt16 Checksum
		{
			get { return checksum; }
			set { checksum = value; }
		}

		public UInt16 Windowsize
		{
			get { return windowsize; }
			set { windowsize = value; }
		}

		public UInt16 OffsetAndReservedAndFlags
		{
			get { return offsetAndReservedAndFlags; }
			set { offsetAndReservedAndFlags = value; }
		}

		public UInt32 Ack
		{
			get { return ack; }
			set { ack = value; }
		}

		public UInt32 Sequence
		{
			get { return sequence; }
			set { sequence = value; }
		}

		public UInt16 Destport
		{
			get { return destport; }
			set { destport = value; }
		}

		public UInt16 Sourceport
		{
			get { return sourceport; }
			set { sourceport = value; }
		}
		#endregion

		public TcpHeader()
		{
		}

		public TcpHeader(byte[] byBuffer, int nReceived)
		{

		}
	}
}
