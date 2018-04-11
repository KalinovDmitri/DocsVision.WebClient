using System;

namespace DocsVision.DataModel.Entities
{
	public class BaseCardDates
	{
		public Guid Id { get; set; }

		public byte[] Timestamp { get; set; }

		public DateTime? CreationDateTime { get; set; }

		public DateTime? ChangeDateTime { get; set; }
	}
}