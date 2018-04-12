using System;

namespace DocsVision.DataModel.Entities.Platform
{
	[Flags]
	public enum FolderFlags : int
	{
		None = 0,
		VirtualWithSubfolders = 1,
		NoAutoRefresh = 2,
		NoUnreadCards = 4,
		CustomRefresh = 8,
		NoChangeFolderRefresh = 0x10
	}
}