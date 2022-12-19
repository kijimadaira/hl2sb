// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Steam4NET
{

	public enum ERemoteStorageFileRoot : int
	{
		k_ERemoteStorageFileRootInvalid = 0,
		k_ERemoteStorageFileRootDefault = 1,
		k_ERemoteStorageFileRootMax = 2,
	};
	
	public enum ERemoteStorageSyncState : int
	{
		k_ERemoteSyncStateUnknown = 0,
		k_ERemoteSyncStateSynchronized = 1,
		k_ERemoteSyncStateSyncInProgress = 2,
		k_ERemoteSyncStatePendingChangesInCloud = 3,
		k_ERemoteSyncStatePendingChangesLocally = 4,
		k_ERemoteSyncStatePendingChangesInCloudAndLocally = 5,
	};
	
	public enum EScreenshotPrivacyState : int
	{
		k_EScreenshotPrivacyStatePrivate = 2,
		k_EScreenshotPrivacyStateFriendsOnly = 4,
		k_EScreenshotPrivacyStatePublic = 8,
	};
	
	public enum ERemoteStoragePlatform : int
	{
		k_ERemoteStoragePlatformNone = 0,
		k_ERemoteStoragePlatformWindows = 1,
		k_ERemoteStoragePlatformOSX = 2,
		k_ERemoteStoragePlatformPS3 = 4,
		k_ERemoteStoragePlatformReserved1 = 8,
		k_ERemoteStoragePlatformReserved2 = 16,
		k_ERemoteStoragePlatformAll = -1,
	};
	
	public enum EResolveConflict : int
	{
		k_EResolveConflictKeepClient = 1,
		k_EResolveConflictKeepServer = 2,
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(1301)]
	public struct RemoteStorageAppSyncedClient_t
	{
		public const int k_iCallback = 1301;
		public UInt32 m_nAppID;
		public EResult m_eResult;
		public Int32 m_unNumDownloads;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(1302)]
	public struct RemoteStorageAppSyncedServer_t
	{
		public const int k_iCallback = 1302;
		public UInt32 m_nAppID;
		public EResult m_eResult;
		public Int32 m_unNumUploads;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(1303)]
	public struct RemoteStorageAppSyncProgress_t
	{
		public const int k_iCallback = 1303;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
		public string m_rgchCurrentFile;
		public UInt32 m_nAppID;
		public UInt32 m_uBytesTransferredThisChunk;
		public double m_dAppPercentComplete;
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bUploading;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(1306)]
	public struct RemoteStorageConflictResolution_t
	{
		public const int k_iCallback = 1306;
		public UInt32 m_nAppID;
		public EResult m_eResult;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(1307)]
	public struct RemoteStorageFileShareResult_t
	{
		public const int k_iCallback = 1307;
		public EResult m_eResult;
		public UInt64 m_hFile;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(1308)]
	public struct RemoteStorageDownloadUGCResult_t
	{
		public const int k_iCallback = 1308;
		public EResult m_eResult;
		public UInt64 m_hFile;
		public UInt32 m_nAppID;
		public Int32 m_nSizeInBytes;
		public string m_pchFileName;
		public UInt64 m_ulSteamIDOwner;
	};
	
}
