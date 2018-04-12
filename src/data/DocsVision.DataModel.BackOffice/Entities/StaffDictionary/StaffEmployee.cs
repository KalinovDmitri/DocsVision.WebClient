using System;
using System.Collections.Generic;

using DocsVision.DataModel.Entities.Platform;

namespace DocsVision.DataModel.Entities.BackOffice
{
	public class StaffEmployee : BaseCardSectionRow
	{
		public string FirstName { get; set; } // Unicode, 32 max

		public string MiddleName { get; set; } // Unicode, 32 max

		public string LastName { get; set; } // Unicode, 32 max

		public Guid? PositionID { get; set; } // Position

		public string AccountName { get; set; } // Unicode, 128 max

		public Guid? ManagerID { get; set; } // Manager

		public string RoomNumber { get; set; } // Unicode, 64 max

		public string Phone { get; set; } // 64 max

		public string MobilePhone { get; set; } // 64 max

		public string HomePhone { get; set; } // 64 max

		public string Email { get; set; } // 64 max

		public Guid? PersonalFolderID { get; set; } // PersonalFolder

		public string Comments { get; set; } // Unicode, 1024 max

		public virtual StaffPosition Position { get; set; }

		public virtual StaffEmployee Manager { get; set; }

		public virtual Folder PersonalFolder { get; set; }
	}
}