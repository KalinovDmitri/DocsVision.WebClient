using System;

namespace DocsVision.DataModel.Entities.Platform
{
	public class Shortcut : BaseCardSectionRow
	{
		public Guid? CardID { get; set; }

		public Guid? HardCardID { get; set; }

		public Guid? Mode { get; set; }

		public string Description { get; set; } // Unicode, 512 max

		public bool? Deleted { get; set; }

		public bool? Recalled { get; set; }

		public DateTime? CreatedAt { get; set; } // CreateDateTime
	}
}