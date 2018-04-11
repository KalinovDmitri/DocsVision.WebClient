using System;
using System.Linq.Expressions;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using DocsVision.DataModel.Entities;

namespace DocsVision.DataModel.Mappings
{
	public sealed class BaseCardMapping : AbstractMapping<BaseCard>
	{
		protected override void MapEntity(EntityTypeBuilder<BaseCard> entityBuilder)
		{
			base.MapEntity(entityBuilder);

			entityBuilder.ToTable("dvsys_instances", "dbo");

			entityBuilder.Property(x => x.Id).HasColumnName("InstanceID");
			entityBuilder.Property(x => x.Timestamp).IsRowVersion();
			entityBuilder.Property(x => x.CardTypeID);
			entityBuilder.Property(x => x.Description);
			entityBuilder.Property(x => x.SecurityID).HasColumnName("SDID");
			entityBuilder.Property(x => x.Deleted);
			entityBuilder.Property(x => x.Template);
			entityBuilder.Property(x => x.TopicID);
			entityBuilder.Property(x => x.TopicIndex);
			entityBuilder.Property(x => x.ParentID);
			entityBuilder.Property(x => x.Order);
			entityBuilder.Property(x => x.ArchiveState);
			entityBuilder.Property(x => x.Barcode);
			entityBuilder.Property(x => x.IconID);
			entityBuilder.Property(x => x.Status);

			entityBuilder.HasKey(x => x.Id)
				.ForSqlServerIsClustered(false)
				.HasName("dvsys_instances_pk_instanceid");

			entityBuilder.HasOne(x => x.Dates).WithOne()
				.HasForeignKey<BaseCardDates>(x => x.Id)
				.HasPrincipalKey<BaseCard>(x => x.Id);

			entityBuilder.HasOne(x => x.Security).WithMany()
				.HasForeignKey(x => x.SecurityID)
				.HasPrincipalKey(x => x.Id)
				.HasConstraintName("dvsys_instances_fk_sdid");

			entityBuilder.HasOne(x => x.Type).WithMany()
				.HasForeignKey(x => x.CardTypeID)
				.HasPrincipalKey(x => x.Id)
				.HasConstraintName("dvsys_instances_fk_cardtypeid");
		}
	}

	public abstract class BaseCardMapping<TCard> : IEntityMapping where TCard : BaseCard
	{
		protected readonly Guid _cardTypeID;

		protected internal BaseCardMapping(Guid cardTypeID)
		{
			if (cardTypeID == Guid.Empty)
			{
				throw new ArgumentOutOfRangeException(nameof(cardTypeID), $"Card type ID cannot be equal to '{Guid.Empty}'.");
			}

			_cardTypeID = cardTypeID;
		}

		public void Map(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<BaseCard>()
				.HasDiscriminator(x => x.CardTypeID)
				.HasValue<TCard>(_cardTypeID);

			var entityBuilder = modelBuilder.Entity<TCard>();

			entityBuilder.HasBaseType<BaseCard>();

			MapEntity(entityBuilder);
		}

		protected virtual void MapEntity(EntityTypeBuilder<TCard> entityBuilder) { }
	}
}