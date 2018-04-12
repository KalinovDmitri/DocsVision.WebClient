using System;

namespace DocsVision.DataModel.Entities.Platform
{
	public class FolderIcon : BaseCardSectionRow
	{
		public byte[] Icon { get; set; }

		public string Description { get; set; } // Unicode, 64 max
	}
}