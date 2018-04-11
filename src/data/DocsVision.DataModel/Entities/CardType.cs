using System;
using System.Collections.Generic;

namespace DocsVision.DataModel.Entities
{
	public class CardType
	{
		public Guid Id { get; set; }

		public byte[] Timestamp { get; set; }

		public string Alias { get; set; }

		public int? Version { get; set; }

		public int? SysVersion { get; set; }

		public Guid? LibraryID { get; set; }

		public string ControlInfo { get; set; }

		public CardTypeFlags? Options { get; set; }

		public CardTypeFetchMode? FetchMode { get; set; }

		public string XmlSchema { get; set; }

		public string XsdSchema { get; set; }

		public string Icon { get; set; }

		public Guid? SecurityID { get; set; }

		public string TypeName { get; set; }

		public virtual SecurityInfo Security { get; set; }

		public virtual ICollection<CardSection> Sections { get; set; }
	}
}