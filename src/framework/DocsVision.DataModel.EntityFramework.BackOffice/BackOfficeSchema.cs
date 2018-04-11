using System;
using System.Collections.Generic;

using DocsVision.DataModel.Mappings;
using DocsVision.DataModel.Mappings.BackOffice;

namespace DocsVision.DataModel.Schema
{
	public static class BackOfficeSchema
	{
		public static IEnumerable<IEntityMapping> GetMappings()
		{
			yield return new DocumentMapping();
			yield return new DocumentMainInfoMapping();
			yield return new TaskMapping();
			yield return new TaskMainInfoMapping();
			yield break;
		}
	}
}