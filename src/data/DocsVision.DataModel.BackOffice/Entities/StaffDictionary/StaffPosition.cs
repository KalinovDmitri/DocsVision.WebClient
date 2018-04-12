using System;

namespace DocsVision.DataModel.Entities.BackOffice
{
	public class StaffPosition : BaseCardSectionRow
	{
		public string Name { get; set; } // Unicode, 128 max

		public int? Importance { get; set; }

		public string SyncTag { get; set; } // Unicode, 256 max

		public string Comments { get; set; } // Unicode, 1024 max

		public string ShortName { get; set; } // Unicode, 64 max
	}
}