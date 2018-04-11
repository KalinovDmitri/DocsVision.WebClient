using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using DocsVision.DataModel.Entities;
using DocsVision.WebClient.DataModel;

namespace DocsVision.WebClient.DataModel.Tests
{
	[TestClass]
	public class DocsVisionContextTests
	{
		#region Test methods

		[TestMethod]
		public async Task IsDocsVisionContextModelBuildsSuccessfully()
		{
			var context = new DocsVisionContext(CreateOptions());

			var query = context.Set<BaseCard>().Select(x => new
			{
				x.Id,
				Type = x.Type.Alias,
				x.Description,
				x.Dates.CreationDateTime
			});

			var queryResults = await query.ToListAsync();

			Assert.IsNotNull(queryResults);
			Assert.IsTrue(queryResults.Count > 0);
		}
		#endregion

		#region Private class methods

		private const string ConnectionString = "Server=(local);Database=DocsVision5_MIH;User ID=sa;Password=saionara;MultipleActiveResultSets=True;";

		private static DbContextOptions CreateOptions()
		{
			var optionsBuilder = new DbContextOptionsBuilder<DocsVisionContext>();

			var loggerFactory = new LoggerFactory(new[] { new ConsoleLoggerProvider((_, __) => true, true) });

			optionsBuilder
				.UseLoggerFactory(loggerFactory)
				.UseSqlServer(ConnectionString, x =>
				{
					x.CommandTimeout(300);
					x.UseRelationalNulls();
					x.EnableRetryOnFailure(3);
				});

			var options = optionsBuilder.Options;
			return options;
		}
		#endregion
	}
}