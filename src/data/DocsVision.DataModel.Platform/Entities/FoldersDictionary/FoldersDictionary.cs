using System;
using System.Collections.Generic;

namespace DocsVision.DataModel.Entities.Platform
{
	public class FoldersDictionary : BaseDictionaryCard
	{
		public virtual FoldersMainInfo MainInfo { get; set; }

		public virtual ICollection<Folder> Folders { get; set; }

		public virtual ICollection<FolderIcon> Icons { get; set; }
	}
}