using System;
using System.Collections.Generic;

namespace DocsVision.DataModel.Entities.BackOffice
{
	public class StaffUnit : BaseCardSectionRow
	{
		public string Name { get; set; } // Unicode, 255 max

		public string FullName { get; set; } // Unicode, 1024 max

		public StaffUnitType Type { get; set; }

		public Guid? ManagerID { get; set; } // Manager

		public string Comments { get; set; }

		public virtual ICollection<StaffEmployee> Employees { get; set; }

		public virtual StaffEmployee Manager { get; set; }
	}
}