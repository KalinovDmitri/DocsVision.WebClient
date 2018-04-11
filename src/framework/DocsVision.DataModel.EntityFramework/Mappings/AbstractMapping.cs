using System;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DocsVision.DataModel.Mappings
{
	public interface IEntityMapping
	{
		void Map(ModelBuilder modelBuilder);
	}

	public abstract class AbstractMapping<TEntity> : IEntityMapping where TEntity : class
	{
		public void Map(ModelBuilder modelBuilder)
		{
			var entityBuilder = modelBuilder.Entity<TEntity>();

			MapEntity(entityBuilder);
		}

		protected virtual void MapEntity(EntityTypeBuilder<TEntity> entityBuilder) { }
	}
}