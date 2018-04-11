using System;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using DocsVision.DataModel.Entities;

namespace DocsVision.DataModel.Mappings
{
	public sealed class BaseCardDatesMapping : AbstractMapping<BaseCardDates>
	{
		protected override void MapEntity(EntityTypeBuilder<BaseCardDates> entityBuilder)
		{
			base.MapEntity(entityBuilder);

			entityBuilder.ToTable("dvsys_instances_date", "dbo");

			entityBuilder.Property(x => x.Id).HasColumnName("InstanceID");
			entityBuilder.Property(x => x.Timestamp).IsRowVersion();
			entityBuilder.Property(x => x.CreationDateTime).HasColumnType("datetime");
			entityBuilder.Property(x => x.ChangeDateTime).HasColumnType("datetime");

			entityBuilder.HasKey(x => x.Id)
				.ForSqlServerIsClustered(false)
				.HasName("dvsys_instances_date_pk_instanceid");

			entityBuilder.HasIndex(x => new { x.CreationDateTime, x.Id })
				.ForSqlServerIsClustered(false)
				.HasName("dvsys_instances_date_idx_creationdatetime");
		}
	}
}