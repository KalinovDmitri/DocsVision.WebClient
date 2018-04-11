using System;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using DocsVision.DataModel.CardDefs;
using DocsVision.DataModel.Entities.BackOffice;

namespace DocsVision.DataModel.Mappings.BackOffice
{
	public sealed class TaskMainInfoMapping : BaseCardSectionRowMapping<TaskMainInfo>
	{
		public TaskMainInfoMapping() : base(CardTask.MainInfo.ID) { }

		protected override void MapEntity(EntityTypeBuilder<TaskMainInfo> entityBuilder)
		{
			base.MapEntity(entityBuilder);

			entityBuilder.Property(x => x.Name).HasMaxLength(480).IsUnicode();
			entityBuilder.Property(x => x.Content).IsUnicode();
			entityBuilder.Property(x => x.AuthorID).HasColumnName("Author");
			entityBuilder.Property(x => x.StartDate);
			entityBuilder.Property(x => x.EndDate);
			entityBuilder.Property(x => x.StartDateActual);
		}
	}
}