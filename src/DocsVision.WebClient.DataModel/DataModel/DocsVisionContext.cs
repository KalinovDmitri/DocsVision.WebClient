using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.EntityFrameworkCore;

using DocsVision.DataModel.Mappings;
using DocsVision.DataModel.Schema;

namespace DocsVision.WebClient.DataModel
{
	public class DocsVisionContext : DbContext
	{
		public DocsVisionContext(DbContextOptions options) : base(options) { }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			var mappings =
				CoreSchema.GetMappings()
				.Concat(BackOfficeSchema.GetMappings());

			foreach (var mapping in mappings)
			{
				mapping.Map(modelBuilder);
			}
		}
	}
}