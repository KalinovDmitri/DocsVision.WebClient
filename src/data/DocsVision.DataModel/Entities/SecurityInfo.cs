using System;

namespace DocsVision.DataModel.Entities
{
	public class SecurityInfo
	{
		public Guid Id { get; set; }

		public int? Hash { get; set; }

		public string Descriptor { get; set; }
	}
}