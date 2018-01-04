namespace ProtocolHeaders
{
	using System;
	using System.Text;

	public class ICMPHeader
	{
		#region private variables
		private byte type;
		private byte code;
		private UInt16 checksum;
		private int messagesize;
		private const int headerLength = 8;
		private byte[] message;
		#endregion

		#region encapsulations
		public byte Type
		{
			get { return type; }
			set { type = value; }
		}
		public byte Code
		{
			get { return code; }
			set { code = value; }
		}
		public UInt16 Checksum
		{
			get { return checksum; }
			set { checksum = value; }
		}
		public int Messagesize
		{
			get { return messagesize; }
			set { messagesize = value; }
		}
		public byte[] Message
		{
			get { return message; }
			set { message = value; }
		}
		#endregion

		#region functions
		public ICMPHeader()
		{
			Message = new byte[1024];
		}
		public ICMPHeader(byte[] data, int size)
		{
			for (int i = 0; i < 20; i++)
			{
				//Console.Write(Encoding.ASCII.GetString(data,  + " ");
				Console.Write(data[i] + " ");
			}
			Console.WriteLine();
				Type = data[20];
			Code = data[21];
			Checksum = BitConverter.ToUInt16(data, 22);
			Messagesize = size - 24;
			Message = new byte[Messagesize];
			Buffer.BlockCopy(data, 24, Message, 0, Messagesize);
		}
		public byte[] getBytes()
		{
			byte[] data = new byte[Messagesize + 9];
			Buffer.BlockCopy(BitConverter.GetBytes(Type), 0, data, 0, 1);
			Buffer.BlockCopy(BitConverter.GetBytes(Code), 0, data, 1, 1);
			Buffer.BlockCopy(BitConverter.GetBytes(Checksum), 0, data, 2, 2);
			Buffer.BlockCopy(Message, 0, data, 4, Messagesize);
			return data;
		}
		public UInt16 getChecksum()
		{
			UInt32 chcksm = 0;
			byte[] data = getBytes();
			int packetsize = Messagesize + 8;
			int index = 0;

			while (index < packetsize)
			{
				chcksm += Convert.ToUInt32(BitConverter.ToUInt16(data, index));
				index += 2;
			}
			chcksm = (chcksm >> 16) + (chcksm & 0xffff);
			chcksm += (chcksm >> 16);
			return (UInt16)(~chcksm);
		}
		#endregion
	}
}
