using System;

namespace DocsVision.DataModel.Entities
{
	public class CardSection
	{
		public Guid Id { get; set; }

		public string Alias { get; set; }

		public Guid ParentSectionID { get; set; }

		public Guid CardTypeID { get; set; }

		public int SecurityType { get; set; }

		public bool UserDependent { get; set; }

		public int NestLevel { get; set; }

		public CardSectionType Type { get; set; }

		public CardSectionFlags Flags { get; set; }

		public bool IsDynamic { get; set; }

		public bool Extended { get; set; }

		public bool New { get; set; }
	}
}