// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Steam4NET
{

	[StructLayout(LayoutKind.Sequential,Pack=4)]
	public class ISteamUser008VTable
	{
		public IntPtr GetHSteamUser0;
		public IntPtr BLoggedOn1;
		public IntPtr GetSteamID2;
		public IntPtr InitiateGameConnection3;
		public IntPtr TerminateGameConnection4;
		public IntPtr TrackAppUsageEvent5;
		public IntPtr RefreshSteam2Login6;
		private IntPtr DTorISteamUser0087;
	};
	
	[InteropHelp.InterfaceVersion("SteamUser008")]
	public class ISteamUser008 : InteropHelp.NativeWrapper<ISteamUser008VTable>
	{
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetHSteamUser( IntPtr thisptr );
		public Int32 GetHSteamUser(  ) 
		{
			return this.GetFunction<NativeGetHSteamUser>( this.Functions.GetHSteamUser0 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeBLoggedOn( IntPtr thisptr );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool BLoggedOn(  ) 
		{
			return this.GetFunction<NativeBLoggedOn>( this.Functions.BLoggedOn1 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeGetSteamID( IntPtr thisptr, ref UInt64 retarg );
		public CSteamID GetSteamID(  ) 
		{
			UInt64 ret = 0; this.GetFunction<NativeGetSteamID>( this.Functions.GetSteamID2 )( this.ObjectAddress, ref ret ); return new CSteamID(ret);
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeInitiateGameConnectionBICCUUBBI( IntPtr thisptr, Byte[] pBlob, Int32 cbMaxBlob, UInt64 steamID, UInt64 gameID, UInt32 unIPServer, UInt16 usPortServer, [MarshalAs(UnmanagedType.I1)] bool bSecure, Byte[] pvSteam2GetEncryptionKey, Int32 cbSteam2GetEncryptionKey );
		public Int32 InitiateGameConnection( Byte[] pBlob, CSteamID steamID, CGameID gameID, UInt32 unIPServer, UInt16 usPortServer, bool bSecure, Byte[] pvSteam2GetEncryptionKey ) 
		{
			return this.GetFunction<NativeInitiateGameConnectionBICCUUBBI>( this.Functions.InitiateGameConnection3 )( this.ObjectAddress, pBlob, (Int32) pBlob.Length, steamID.ConvertToUint64(), gameID.ConvertToUint64(), unIPServer, usPortServer, bSecure, pvSteam2GetEncryptionKey, (Int32) pvSteam2GetEncryptionKey.Length ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeTerminateGameConnectionUU( IntPtr thisptr, UInt32 unIPServer, UInt16 usPortServer );
		public void TerminateGameConnection( UInt32 unIPServer, UInt16 usPortServer ) 
		{
			this.GetFunction<NativeTerminateGameConnectionUU>( this.Functions.TerminateGameConnection4 )( this.ObjectAddress, unIPServer, usPortServer ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeTrackAppUsageEventCES( IntPtr thisptr, UInt64 gameID, EAppUsageEvent eAppUsageEvent, string pchExtraInfo );
		public void TrackAppUsageEvent( CGameID gameID, EAppUsageEvent eAppUsageEvent, string pchExtraInfo ) 
		{
			this.GetFunction<NativeTrackAppUsageEventCES>( this.Functions.TrackAppUsageEvent5 )( this.ObjectAddress, gameID.ConvertToUint64(), eAppUsageEvent, pchExtraInfo ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeRefreshSteam2Login( IntPtr thisptr );
		public void RefreshSteam2Login(  ) 
		{
			this.GetFunction<NativeRefreshSteam2Login>( this.Functions.RefreshSteam2Login6 )( this.ObjectAddress ); 
		}
		
	};
}
