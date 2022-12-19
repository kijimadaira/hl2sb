// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Steam4NET
{

	[StructLayout(LayoutKind.Sequential,Pack=4)]
	public class IClientScreenshotsVTable
	{
		public IntPtr GetShortcutDisplayName0;
		public IntPtr SetShortcutDisplayName1;
		public IntPtr WriteScreenshot2;
		public IntPtr AddScreenshotToLibrary3;
		public IntPtr TriggerScreenshot4;
		public IntPtr HookScreenshots5;
		public IntPtr RequestScreenshotFromGame6;
		public IntPtr SetLocation7;
		public IntPtr TagUser8;
		public IntPtr ResolvePath9;
		public IntPtr GetFileSize10;
		public IntPtr IsPersisted11;
		public IntPtr GetNumGamesWithLocalScreenshots12;
		public IntPtr GetGameWithLocalScreenshots13;
		public IntPtr GetLocalScreenshotCount14;
		public IntPtr GetLocalScreenshot15;
		public IntPtr SetLocalScreenshotCaption16;
		public IntPtr SetLocalScreenshotPrivacy17;
		public IntPtr StartBatch18;
		public IntPtr AddToBatch19;
		public IntPtr UploadBatch20;
		public IntPtr DeleteBatch21;
		public IntPtr CancelBatch22;
		public IntPtr RecoverOldScreenshots23;
		public IntPtr GetTaggedUserCount24;
		public IntPtr GetTaggedUser25;
		public IntPtr GetLocation26;
		private IntPtr DTorIClientScreenshots27;
	};
	
	[InteropHelp.InterfaceVersion("CLIENTSCREENSHOTS_INTERFACE_VERSION001")]
	public class IClientScreenshots : InteropHelp.NativeWrapper<IClientScreenshotsVTable>
	{
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate string NativeGetShortcutDisplayNameC( IntPtr thisptr, UInt64 gameID );
		public string GetShortcutDisplayName( CGameID gameID ) 
		{
			return InteropHelp.DecodeANSIReturn( this.GetFunction<NativeGetShortcutDisplayNameC>( this.Functions.GetShortcutDisplayName0 )( this.ObjectAddress, gameID.ConvertToUint64() ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetShortcutDisplayNameCS( IntPtr thisptr, UInt64 arg0, string arg1 );
		public void SetShortcutDisplayName( CGameID arg0, string arg1 ) 
		{
			this.GetFunction<NativeSetShortcutDisplayNameCS>( this.Functions.SetShortcutDisplayName1 )( this.ObjectAddress, arg0.ConvertToUint64(), arg1 ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeWriteScreenshotCBUII( IntPtr thisptr, UInt64 arg0, Byte[] arg1, UInt32 arg2, Int32 arg3, Int32 arg4 );
		public UInt32 WriteScreenshot( CGameID arg0, Byte[] arg1, UInt32 arg2, Int32 arg3, Int32 arg4 ) 
		{
			return this.GetFunction<NativeWriteScreenshotCBUII>( this.Functions.WriteScreenshot2 )( this.ObjectAddress, arg0.ConvertToUint64(), arg1, arg2, arg3, arg4 ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeAddScreenshotToLibraryCSSII( IntPtr thisptr, UInt64 arg0, string arg1, string arg2, Int32 arg3, Int32 arg4 );
		public UInt32 AddScreenshotToLibrary( CGameID arg0, string arg1, string arg2, Int32 arg3, Int32 arg4 ) 
		{
			return this.GetFunction<NativeAddScreenshotToLibraryCSSII>( this.Functions.AddScreenshotToLibrary3 )( this.ObjectAddress, arg0.ConvertToUint64(), arg1, arg2, arg3, arg4 ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeTriggerScreenshotC( IntPtr thisptr, UInt64 arg0 );
		public void TriggerScreenshot( CGameID arg0 ) 
		{
			this.GetFunction<NativeTriggerScreenshotC>( this.Functions.TriggerScreenshot4 )( this.ObjectAddress, arg0.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeHookScreenshotsUB( IntPtr thisptr, UInt32 arg0, [MarshalAs(UnmanagedType.I1)] bool arg1 );
		public void HookScreenshots( UInt32 arg0, bool arg1 ) 
		{
			this.GetFunction<NativeHookScreenshotsUB>( this.Functions.HookScreenshots5 )( this.ObjectAddress, arg0, arg1 ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeRequestScreenshotFromGameU( IntPtr thisptr, UInt32 arg0 );
		public void RequestScreenshotFromGame( UInt32 arg0 ) 
		{
			this.GetFunction<NativeRequestScreenshotFromGameU>( this.Functions.RequestScreenshotFromGame6 )( this.ObjectAddress, arg0 ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSetLocationCUS( IntPtr thisptr, UInt64 arg0, UInt32 arg1, string arg2 );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool SetLocation( CGameID arg0, UInt32 arg1, string arg2 ) 
		{
			return this.GetFunction<NativeSetLocationCUS>( this.Functions.SetLocation7 )( this.ObjectAddress, arg0.ConvertToUint64(), arg1, arg2 ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeTagUserCUC( IntPtr thisptr, UInt64 arg0, UInt32 arg1, UInt64 arg2 );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool TagUser( CGameID arg0, UInt32 arg1, CSteamID arg2 ) 
		{
			return this.GetFunction<NativeTagUserCUC>( this.Functions.TagUser8 )( this.ObjectAddress, arg0.ConvertToUint64(), arg1, arg2.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeResolvePathCUBSU( IntPtr thisptr, UInt64 arg0, UInt32 arg1, [MarshalAs(UnmanagedType.I1)] bool arg2, StringBuilder arg3, UInt32 arg4 );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool ResolvePath( CGameID arg0, UInt32 arg1, bool arg2, StringBuilder arg3, UInt32 arg4 ) 
		{
			return this.GetFunction<NativeResolvePathCUBSU>( this.Functions.ResolvePath9 )( this.ObjectAddress, arg0.ConvertToUint64(), arg1, arg2, arg3, arg4 ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetFileSizeCU( IntPtr thisptr, UInt64 arg0, UInt32 arg1 );
		public UInt32 GetFileSize( CGameID arg0, UInt32 arg1 ) 
		{
			return this.GetFunction<NativeGetFileSizeCU>( this.Functions.GetFileSize10 )( this.ObjectAddress, arg0.ConvertToUint64(), arg1 ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeIsPersistedCU( IntPtr thisptr, UInt64 arg0, UInt32 arg1 );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool IsPersisted( CGameID arg0, UInt32 arg1 ) 
		{
			return this.GetFunction<NativeIsPersistedCU>( this.Functions.IsPersisted11 )( this.ObjectAddress, arg0.ConvertToUint64(), arg1 ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetNumGamesWithLocalScreenshots( IntPtr thisptr );
		public UInt32 GetNumGamesWithLocalScreenshots(  ) 
		{
			return this.GetFunction<NativeGetNumGamesWithLocalScreenshots>( this.Functions.GetNumGamesWithLocalScreenshots12 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeGetGameWithLocalScreenshotsI( IntPtr thisptr, ref UInt64 retarg, Int32 arg0 );
		public CGameID GetGameWithLocalScreenshots( Int32 arg0 ) 
		{
			UInt64 ret = 0; this.GetFunction<NativeGetGameWithLocalScreenshotsI>( this.Functions.GetGameWithLocalScreenshots13 )( this.ObjectAddress, ref ret, arg0 ); return new CGameID(ret);
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetLocalScreenshotCountC( IntPtr thisptr, UInt64 arg0 );
		public UInt32 GetLocalScreenshotCount( CGameID arg0 ) 
		{
			return this.GetFunction<NativeGetLocalScreenshotCountC>( this.Functions.GetLocalScreenshotCount14 )( this.ObjectAddress, arg0.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetLocalScreenshotCIUIIUEUSU( IntPtr thisptr, UInt64 arg0, Int32 arg1, ref UInt32 arg2, ref Int32 arg3, ref Int32 arg4, ref UInt32 arg5, ref EScreenshotPrivacyState arg6, ref UInt64 arg7, StringBuilder arg8, UInt32 arg9 );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool GetLocalScreenshot( CGameID arg0, Int32 arg1, ref UInt32 arg2, ref Int32 arg3, ref Int32 arg4, ref UInt32 arg5, ref EScreenshotPrivacyState arg6, ref UInt64 arg7, StringBuilder arg8, UInt32 arg9 ) 
		{
			return this.GetFunction<NativeGetLocalScreenshotCIUIIUEUSU>( this.Functions.GetLocalScreenshot15 )( this.ObjectAddress, arg0.ConvertToUint64(), arg1, ref arg2, ref arg3, ref arg4, ref arg5, ref arg6, ref arg7, arg8, arg9 ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSetLocalScreenshotCaptionCUS( IntPtr thisptr, UInt64 arg0, UInt32 arg1, string arg2 );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool SetLocalScreenshotCaption( CGameID arg0, UInt32 arg1, string arg2 ) 
		{
			return this.GetFunction<NativeSetLocalScreenshotCaptionCUS>( this.Functions.SetLocalScreenshotCaption16 )( this.ObjectAddress, arg0.ConvertToUint64(), arg1, arg2 ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSetLocalScreenshotPrivacyCUE( IntPtr thisptr, UInt64 arg0, UInt32 arg1, EScreenshotPrivacyState arg2 );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool SetLocalScreenshotPrivacy( CGameID arg0, UInt32 arg1, EScreenshotPrivacyState arg2 ) 
		{
			return this.GetFunction<NativeSetLocalScreenshotPrivacyCUE>( this.Functions.SetLocalScreenshotPrivacy17 )( this.ObjectAddress, arg0.ConvertToUint64(), arg1, arg2 ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeStartBatchC( IntPtr thisptr, UInt64 arg0 );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool StartBatch( CGameID arg0 ) 
		{
			return this.GetFunction<NativeStartBatchC>( this.Functions.StartBatch18 )( this.ObjectAddress, arg0.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeAddToBatchU( IntPtr thisptr, UInt32 arg0 );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool AddToBatch( UInt32 arg0 ) 
		{
			return this.GetFunction<NativeAddToBatchU>( this.Functions.AddToBatch19 )( this.ObjectAddress, arg0 ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeUploadBatchE( IntPtr thisptr, ref UInt64 retarg, EScreenshotPrivacyState arg0 );
		public UInt64 UploadBatch( EScreenshotPrivacyState arg0 ) 
		{
			UInt64 ret = 0; this.GetFunction<NativeUploadBatchE>( this.Functions.UploadBatch20 )( this.ObjectAddress, ref ret, arg0 ); return (UInt64)ret;
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeDeleteBatchB( IntPtr thisptr, ref UInt64 retarg, [MarshalAs(UnmanagedType.I1)] bool arg0 );
		public UInt64 DeleteBatch( bool arg0 ) 
		{
			UInt64 ret = 0; this.GetFunction<NativeDeleteBatchB>( this.Functions.DeleteBatch21 )( this.ObjectAddress, ref ret, arg0 ); return (UInt64)ret;
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeCancelBatch( IntPtr thisptr );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool CancelBatch(  ) 
		{
			return this.GetFunction<NativeCancelBatch>( this.Functions.CancelBatch22 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeRecoverOldScreenshots( IntPtr thisptr );
		public void RecoverOldScreenshots(  ) 
		{
			this.GetFunction<NativeRecoverOldScreenshots>( this.Functions.RecoverOldScreenshots23 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetTaggedUserCountCU( IntPtr thisptr, UInt64 arg0, UInt32 arg1 );
		public UInt32 GetTaggedUserCount( CGameID arg0, UInt32 arg1 ) 
		{
			return this.GetFunction<NativeGetTaggedUserCountCU>( this.Functions.GetTaggedUserCount24 )( this.ObjectAddress, arg0.ConvertToUint64(), arg1 ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeGetTaggedUserCUI( IntPtr thisptr, UInt64 arg0, UInt32 arg1, Int32 arg2 );
		public void GetTaggedUser( CGameID arg0, UInt32 arg1, Int32 arg2 ) 
		{
			this.GetFunction<NativeGetTaggedUserCUI>( this.Functions.GetTaggedUser25 )( this.ObjectAddress, arg0.ConvertToUint64(), arg1, arg2 ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetLocationCUSU( IntPtr thisptr, UInt64 arg0, UInt32 arg1, StringBuilder arg2, UInt32 arg3 );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool GetLocation( CGameID arg0, UInt32 arg1, StringBuilder arg2, UInt32 arg3 ) 
		{
			return this.GetFunction<NativeGetLocationCUSU>( this.Functions.GetLocation26 )( this.ObjectAddress, arg0.ConvertToUint64(), arg1, arg2, arg3 ); 
		}
		
	};
}
