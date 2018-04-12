using System;

namespace DocsVision.DataModel
{
	public class UserInfo
	{
		public Guid Id { get; set; } // UserID

		public byte[] Timestamp { get; set; }

		public string AccountName { get; set; } // 64 max

		public Guid? UserRefID { get; set; }

		public string Sid { get; set; } // SID, 128 max
	}
}