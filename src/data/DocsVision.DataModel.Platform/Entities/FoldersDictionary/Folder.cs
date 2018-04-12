using System;
using System.Collections.Generic;

namespace DocsVision.DataModel.Entities.Platform
{
	public class Folder : BaseCardSectionRow
	{
		public string Name { get; set; } // Unicode, 256 max

		public FolderType Type { get; set; }

		public Guid? FolderCardID { get; set; }

		public string Url { get; set; } // Unicode, 512 max

		public int? DefaultStyle { get; set; }

		public int? AllowedStyles { get; set; }

		public bool? Deleted { get; set; }

		public Guid? IconID { get; set; }

		public int? Restrictions { get; set; }

		public Guid? DefaultViewID { get; set; }

		public Guid? ReferenceID { get; set; }

		public bool? ViewCyclingEnabled { get; set; }

		public int? ViewCycleCount { get; set; }

		public FolderFlags? Flags { get; set; }

		public Guid? DefaultTemplateID { get; set; }

		public int? RefreshTimeout { get; set; }

		public Guid? ExtendedTypeID { get; set; }

		public DateTime? CreatedAt { get; set; } // CreateDate

		public Guid? NameUniqueID { get; set; }

		public string CreatedBy { get; set; }

		public Guid? SecurityID { get; set; }

		public virtual SecurityInfo Security { get; set; }

		public virtual Folder ParentFolder { get; set; }

		public virtual ICollection<Folder> Folders { get; set; }

		public virtual ICollection<Shortcut> Shortcuts { get; set; }
	}
}