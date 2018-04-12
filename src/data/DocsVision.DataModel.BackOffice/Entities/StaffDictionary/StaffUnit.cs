using System;
using System.Collections.Generic;

namespace DocsVision.DataModel.Entities.BackOffice
{
	public class StaffUnit : BaseCardSectionRow
	{
		public string Name { get; set; } // Unicode, 255 max

		public virtual ICollection<StaffEmployee> Employees { get; set; }
	}
}