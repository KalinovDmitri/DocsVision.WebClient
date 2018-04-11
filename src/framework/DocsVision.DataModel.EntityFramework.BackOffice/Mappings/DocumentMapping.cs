using System;

using DocsVision.DataModel.CardDefs;
using DocsVision.DataModel.Entities.BackOffice;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DocsVision.DataModel.Mappings.BackOffice
{
	public abstract class DocumentMapping<TDocument> : BaseCardMapping<TDocument> where TDocument : Document
	{
		protected internal DocumentMapping() : base(CardDocument.ID) { }

		protected override void MapEntity(EntityTypeBuilder<TDocument> entityBuilder)
		{
			base.MapEntity(entityBuilder);

			entityBuilder.HasOne(x => x.MainInfo).WithOne()
				.HasForeignKey<DocumentMainInfo>(x => x.InstanceID)
				.HasPrincipalKey<Document>(x => x.Id);
		}
	}

	public sealed class DocumentMapping : DocumentMapping<Document>
	{
		public DocumentMapping() : base() { }
	}
}