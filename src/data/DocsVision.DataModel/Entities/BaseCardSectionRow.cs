using System;

namespace DocsVision.DataModel.Entities
{
	public class BaseCardSectionRow
	{
		public Guid Id { get; set; }

		public byte[] Timestamp { get; set; }

		public Guid OwnServerID { get; set; }

		public Guid? ChangeServerID { get; set; }

		public Guid InstanceID { get; set; }

		public Guid ParentRowID { get; set; }

		public Guid ParentTreeRowID { get; set; }
	}
}