using System;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using DocsVision.DataModel.Entities;

namespace DocsVision.DataModel.Mappings
{
	public abstract class BaseCardSectionRowMapping<TSectionRow> : IEntityMapping where TSectionRow : BaseCardSectionRow
	{
		protected readonly Guid _sectionID;

		protected internal BaseCardSectionRowMapping(Guid sectionID)
		{
			if (sectionID == Guid.Empty)
			{
				throw new ArgumentOutOfRangeException(nameof(sectionID), $"Section ID cannot be equal to '{Guid.Empty}'.");
			}

			_sectionID = sectionID;
		}

		public void Map(ModelBuilder modelBuilder)
		{
			var entityBuilder = modelBuilder.Entity<TSectionRow>();

			entityBuilder.ToTable(MakeTableName(), "dbo");

			entityBuilder.Property(x => x.Id).HasColumnName("RowID");
			entityBuilder.Property(x => x.Timestamp).HasColumnName("SysRowTimestamp").IsRowVersion();
			entityBuilder.Property(x => x.ChangeServerID);
			entityBuilder.Property(x => x.OwnServerID);
			entityBuilder.Property(x => x.InstanceID);
			entityBuilder.Property(x => x.ParentRowID);
			entityBuilder.Property(x => x.ParentTreeRowID);

			entityBuilder.HasKey(x => x.Id).ForSqlServerIsClustered(false);

			MapEntity(entityBuilder);
		}

		protected virtual void MapEntity(EntityTypeBuilder<TSectionRow> entityBuilder) { }

		private string MakeTableName() => string.Format("dvtable_{{{0}}}", _sectionID);
	}
}