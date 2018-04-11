using System;

namespace DocsVision.DataModel.Entities.BackOffice
{
	public class TaskMainInfo : BaseCardSectionRow
	{
		public string Name { get; set; }

		public string Content { get; set; }

		public Guid? AuthorID { get; set; }

		public DateTime? StartDate { get; set; }

		public DateTime? EndDate { get; set; }

		public DateTime? StartDateActual { get; set; }
	}
}