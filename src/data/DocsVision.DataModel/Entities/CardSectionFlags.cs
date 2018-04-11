using System;

namespace DocsVision.DataModel.Entities
{
	[Flags]
	public enum CardSectionFlags : int
	{
		None = 0,
		ContainsProperties = 1,
		AllowsConcurrentAccess = 2,
		NoSearch = 4,
		ItemsSelectable = 8,
		LogOptional = 0x10,
		NonCopyable = 0x20,
		SimpleSecurity = 0x40,
		ItemsPinned = 0x80,
		Dynamic = 0x100
	}
}