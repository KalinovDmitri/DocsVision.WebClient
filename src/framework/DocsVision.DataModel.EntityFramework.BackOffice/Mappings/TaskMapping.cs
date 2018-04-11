using System;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using DocsVision.DataModel.CardDefs;
using DocsVision.DataModel.Entities.BackOffice;

namespace DocsVision.DataModel.Mappings.BackOffice
{
	public class TaskMapping : BaseCardMapping<Task>
	{
		public TaskMapping() : base(CardTask.ID) { }

		protected override void MapEntity(EntityTypeBuilder<Task> entityBuilder)
		{
			base.MapEntity(entityBuilder);

			entityBuilder.HasOne(x => x.MainInfo).WithOne()
				.HasForeignKey<TaskMainInfo>(x => x.InstanceID)
				.HasPrincipalKey<Task>(x => x.Id);
		}
	}
}