using System;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using DocsVision.DataModel.CardDefs;
using DocsVision.DataModel.Entities.BackOffice;

namespace DocsVision.DataModel.Mappings.BackOffice
{
	public abstract class DocumentMainInfoMapping<TDocumentMainInfo> : BaseCardSectionRowMapping<TDocumentMainInfo>
		where TDocumentMainInfo : DocumentMainInfo
	{
		protected internal DocumentMainInfoMapping() : base(CardDocument.MainInfo.ID) { }

		protected override void MapEntity(EntityTypeBuilder<TDocumentMainInfo> entityBuilder)
		{
			base.MapEntity(entityBuilder);

			entityBuilder.Property(x => x.Name).HasMaxLength(480).IsUnicode();
		}
	}

	public sealed class DocumentMainInfoMapping : DocumentMainInfoMapping<DocumentMainInfo>
	{
		public DocumentMainInfoMapping() : base() { }
	}
}