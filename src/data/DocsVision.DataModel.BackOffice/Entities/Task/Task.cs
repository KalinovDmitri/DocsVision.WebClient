using System;

namespace DocsVision.DataModel.Entities.BackOffice
{
	public class Task : BaseCard
	{
		public virtual TaskMainInfo MainInfo { get; set; }
	}
}