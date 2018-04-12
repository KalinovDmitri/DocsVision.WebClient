using System;

namespace DocsVision.DataModel.Entities.BackOffice
{
	public class Document : BaseCard
	{
		public virtual DocumentMainInfo MainInfo { get; set; }
	}
}