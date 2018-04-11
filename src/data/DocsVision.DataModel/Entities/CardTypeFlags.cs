using System;

namespace DocsVision.DataModel.Entities
{
	[Flags]
	public enum CardTypeFlags : int
	{
		None = 0,
		Dictionary = 1,
		NonCreatable = 2,
		NonViewable = 4,
		NonSearchable = 8,
		ShowLinked = 0x10,
		NoLockOnOpen = 0x20,
		UIExtention = 0x40,
		NoHardShortcuts = 0x80,
		FolderCard = 0x100,
		AlwaysRead = 0x200,
		Copyable = 0x400,
		SimpleSecurity = 0x800,
		CanBeTemplate = 0x1000,
		NonDeletable = 0x2000,
		ItemsSelectable = 0x4000,
		CustomXmlExport = 0x8000,
		Restricted = 0x10000,
		DeleteRestricted = 0x20000,
		NonArchivable = 0x1000000,
		NonReplicable = 0x2000000,
		ReplicateTemplatesOnly = 0x4000000,
		ReplicationStatus = 0x8000000,
		UseExtensionInAccessCheck = 0x20000000,
		CachingRestricted = 0x40000000
	}
}