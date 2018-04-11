using System;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using DocsVision.DataModel.Entities;

namespace DocsVision.DataModel.Mappings
{
	public sealed class SecurityInfoMapping : AbstractMapping<SecurityInfo>
	{
		protected override void MapEntity(EntityTypeBuilder<SecurityInfo> entityBuilder)
		{
			base.MapEntity(entityBuilder);

			entityBuilder.ToTable("dvsys_security", "dbo");

			entityBuilder.Property(x => x.Id).HasColumnName("ID");
			entityBuilder.Property(x => x.Hash);
			entityBuilder.Property(x => x.Descriptor).HasColumnName("SecurityDesc");

			entityBuilder.HasKey(x => x.Id)
				.ForSqlServerIsClustered(false)
				.HasName("dvsys_security_pk_id");

			entityBuilder.HasIndex(x => x.Hash)
				.ForSqlServerIsClustered(false)
				.HasName("dvsys_security_idx_hash");
		}
	}
}