using System;
using System.Collections.Generic;

using DocsVision.DataModel.Mappings;

namespace DocsVision.DataModel.Schema
{
	public static class CoreSchema
	{
		public static IEnumerable<IEntityMapping> GetMappings()
		{
			yield return new SecurityInfoMapping();
			yield return new CardTypeMapping();
			yield return new CardSectionMapping();
			yield return new BaseCardMapping();
			yield return new BaseCardDatesMapping();
			yield break;
		}
	}
}