using System;

namespace DocsVision.DataModel.Entities.Platform
{
	[Flags]
	public enum FolderType : int
	{
		None = 0,
		Regular = 1,
		Virtual = 4,
		Delegate = 8,
		System = 16
	}
}