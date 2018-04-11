using System;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using DocsVision.DataModel.Entities;

namespace DocsVision.DataModel.Mappings
{
	public class CardSectionMapping : AbstractMapping<CardSection>
	{
		protected override void MapEntity(EntityTypeBuilder<CardSection> entityBuilder)
		{
			base.MapEntity(entityBuilder);

			entityBuilder.ToTable("dvsys_sectiondefs", "dbo");

			entityBuilder.Property(x => x.Id).HasColumnName("SectionTypeID");
			entityBuilder.Property(x => x.Alias).HasMaxLength(64);
			entityBuilder.Property(x => x.ParentSectionID);
			entityBuilder.Property(x => x.CardTypeID);
			entityBuilder.Property(x => x.SecurityType);
			entityBuilder.Property(x => x.UserDependent);
			entityBuilder.Property(x => x.NestLevel);
			entityBuilder.Property(x => x.Type);
			entityBuilder.Property(x => x.Flags);
			entityBuilder.Property(x => x.IsDynamic);
			entityBuilder.Property(x => x.Extended);
			entityBuilder.Property(x => x.New);

			entityBuilder.HasKey(x => x.Id)
				.ForSqlServerIsClustered(false)
				.HasName("dvsys_sectiondefs_pk_sectiontypeid");

			entityBuilder.HasIndex(x => x.CardTypeID)
				.ForSqlServerIsClustered(true)
				.HasName("dvsys_sectiondefs_idx_cardtypeid");
		}
	}
}