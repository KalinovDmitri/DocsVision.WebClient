﻿using System;

namespace DocsVision.DataModel.Entities
{
	public abstract class BaseCard
	{
		public Guid Id { get; set; }

		public byte[] Timestamp { get; set; }

		public Guid? CardTypeID { get; set; }

		public string Description { get; set; }

		public Guid? SecurityID { get; set; }

		public bool Deleted { get; set; }

		public bool Template { get; set; }

		public Guid? TopicID { get; set; }

		public int TopicIndex { get; set; }

		public Guid ParentID { get; set; }

		public int Order { get; set; }

		public CardArchiveState? ArchiveState { get; set; }

		public string Barcode { get; set; }

		public Guid? IconID { get; set; }

		public int Status { get; set; }

		public virtual BaseCardDates Dates { get; set; }

		public virtual CardType Type { get; set; }

		public virtual SecurityInfo Security { get; set; }
	}
}