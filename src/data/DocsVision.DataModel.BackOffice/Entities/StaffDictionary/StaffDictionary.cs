using System;
using System.Collections.Generic;

namespace DocsVision.DataModel.Entities.BackOffice
{
	public class StaffDictionary : BaseDictionaryCard
	{
		public virtual ICollection<StaffUnit> Units { get; set; }

		public virtual ICollection<StaffPosition> Positions { get; set; }
	}
}