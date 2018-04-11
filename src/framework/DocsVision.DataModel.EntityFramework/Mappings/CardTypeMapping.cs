using System;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using DocsVision.DataModel.Entities;

namespace DocsVision.DataModel.Mappings
{
	public sealed class CardTypeMapping : AbstractMapping<CardType>
	{
		protected override void MapEntity(EntityTypeBuilder<CardType> entityBuilder)
		{
			base.MapEntity(entityBuilder);

			entityBuilder.ToTable("dvsys_carddefs", "dbo");

			entityBuilder.Property(x => x.Id).HasColumnName("CardTypeID");
			entityBuilder.Property(x => x.Alias).HasMaxLength(64);
			entityBuilder.Property(x => x.Version);
			entityBuilder.Property(x => x.SysVersion);
			entityBuilder.Property(x => x.LibraryID);
			entityBuilder.Property(x => x.ControlInfo).HasMaxLength(256);
			entityBuilder.Property(x => x.Options);
			entityBuilder.Property(x => x.FetchMode);
			entityBuilder.Property(x => x.XmlSchema).HasColumnName("XMLSchema");
			entityBuilder.Property(x => x.XsdSchema).HasColumnName("XSDSchema");
			entityBuilder.Property(x => x.Icon);
			entityBuilder.Property(x => x.SecurityID).HasColumnName("SDID");
			entityBuilder.Property(x => x.Timestamp).IsRowVersion();
			entityBuilder.Property(x => x.TypeName).HasMaxLength(2048);

			entityBuilder.HasKey(x => x.Id)
				.ForSqlServerIsClustered(true)
				.HasName("dvsys_carddefs_pk_cardtypeid");

			entityBuilder.HasOne(x => x.Security).WithMany()
				.HasForeignKey(x => x.SecurityID)
				.HasPrincipalKey(x => x.Id)
				.HasConstraintName("dvsys_carddefs_fk_sdid");

			entityBuilder.HasMany(x => x.Sections).WithOne()
				.HasForeignKey(x => x.CardTypeID)
				.HasPrincipalKey(x => x.Id);
		}
	}
}