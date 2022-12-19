// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Steam4NET
{

	[StructLayout(LayoutKind.Sequential,Pack=4)]
	public class ISteamGameStats001VTable
	{
		public IntPtr GetNewSession0;
		public IntPtr EndSession1;
		public IntPtr AddSessionAttributeInt2;
		public IntPtr AddSessionAttributeString3;
		public IntPtr AddSessionAttributeFloat4;
		public IntPtr AddNewRow5;
		public IntPtr CommitRow6;
		public IntPtr CommitOutstandingRows7;
		public IntPtr AddRowAttributeInt8;
		public IntPtr AddRowAtributeString9;
		public IntPtr AddRowAttributeFloat10;
		public IntPtr AddSessionAttributeInt6411;
		public IntPtr AddRowAttributeInt6412;
		private IntPtr DTorISteamGameStats00113;
	};
	
	[InteropHelp.InterfaceVersion("SteamGameStats001")]
	public class ISteamGameStats001 : InteropHelp.NativeWrapper<ISteamGameStats001VTable>
	{
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeGetNewSessionSUIU( IntPtr thisptr, ref UInt64 retarg, SByte nAccountType, UInt64 ulAccountID, Int32 nAppID, UInt32 rtTimeStarted );
		public UInt64 GetNewSession( SByte nAccountType, UInt64 ulAccountID, Int32 nAppID, UInt32 rtTimeStarted ) 
		{
			UInt64 ret = 0; this.GetFunction<NativeGetNewSessionSUIU>( this.Functions.GetNewSession0 )( this.ObjectAddress, ref ret, nAccountType, ulAccountID, nAppID, rtTimeStarted ); return (UInt64)ret;
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeEndSessionUUI( IntPtr thisptr, ref UInt64 retarg, UInt64 ulSessionID, UInt32 rtTimeEnded, Int32 nReasonCode );
		public UInt64 EndSession( UInt64 ulSessionID, UInt32 rtTimeEnded, Int32 nReasonCode ) 
		{
			UInt64 ret = 0; this.GetFunction<NativeEndSessionUUI>( this.Functions.EndSession1 )( this.ObjectAddress, ref ret, ulSessionID, rtTimeEnded, nReasonCode ); return (UInt64)ret;
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate EResult NativeAddSessionAttributeIntUSI( IntPtr thisptr, UInt64 ulSessionID, string pstrName, Int32 nData );
		public EResult AddSessionAttributeInt( UInt64 ulSessionID, string pstrName, Int32 nData ) 
		{
			return this.GetFunction<NativeAddSessionAttributeIntUSI>( this.Functions.AddSessionAttributeInt2 )( this.ObjectAddress, ulSessionID, pstrName, nData ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate EResult NativeAddSessionAttributeStringUSS( IntPtr thisptr, UInt64 ulSessionID, string pstrName, string pstrData );
		public EResult AddSessionAttributeString( UInt64 ulSessionID, string pstrName, string pstrData ) 
		{
			return this.GetFunction<NativeAddSessionAttributeStringUSS>( this.Functions.AddSessionAttributeString3 )( this.ObjectAddress, ulSessionID, pstrName, pstrData ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate EResult NativeAddSessionAttributeFloatUSF( IntPtr thisptr, UInt64 ulSessionID, string pstrName, float fData );
		public EResult AddSessionAttributeFloat( UInt64 ulSessionID, string pstrName, float fData ) 
		{
			return this.GetFunction<NativeAddSessionAttributeFloatUSF>( this.Functions.AddSessionAttributeFloat4 )( this.ObjectAddress, ulSessionID, pstrName, fData ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate EResult NativeAddNewRowUUS( IntPtr thisptr, ref UInt64 pulRowID, UInt64 ulSessionID, string pstrTableName );
		public EResult AddNewRow( ref UInt64 pulRowID, UInt64 ulSessionID, string pstrTableName ) 
		{
			return this.GetFunction<NativeAddNewRowUUS>( this.Functions.AddNewRow5 )( this.ObjectAddress, ref pulRowID, ulSessionID, pstrTableName ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate EResult NativeCommitRowU( IntPtr thisptr, UInt64 ulRowID );
		public EResult CommitRow( UInt64 ulRowID ) 
		{
			return this.GetFunction<NativeCommitRowU>( this.Functions.CommitRow6 )( this.ObjectAddress, ulRowID ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate EResult NativeCommitOutstandingRowsU( IntPtr thisptr, UInt64 ulSessionID );
		public EResult CommitOutstandingRows( UInt64 ulSessionID ) 
		{
			return this.GetFunction<NativeCommitOutstandingRowsU>( this.Functions.CommitOutstandingRows7 )( this.ObjectAddress, ulSessionID ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate EResult NativeAddRowAttributeIntUSI( IntPtr thisptr, UInt64 ulRowID, string pstrName, Int32 nData );
		public EResult AddRowAttributeInt( UInt64 ulRowID, string pstrName, Int32 nData ) 
		{
			return this.GetFunction<NativeAddRowAttributeIntUSI>( this.Functions.AddRowAttributeInt8 )( this.ObjectAddress, ulRowID, pstrName, nData ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate EResult NativeAddRowAtributeStringUSS( IntPtr thisptr, UInt64 ulRowID, string pstrName, string pstrData );
		public EResult AddRowAtributeString( UInt64 ulRowID, string pstrName, string pstrData ) 
		{
			return this.GetFunction<NativeAddRowAtributeStringUSS>( this.Functions.AddRowAtributeString9 )( this.ObjectAddress, ulRowID, pstrName, pstrData ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate EResult NativeAddRowAttributeFloatUSF( IntPtr thisptr, UInt64 ulRowID, string pstrName, float fData );
		public EResult AddRowAttributeFloat( UInt64 ulRowID, string pstrName, float fData ) 
		{
			return this.GetFunction<NativeAddRowAttributeFloatUSF>( this.Functions.AddRowAttributeFloat10 )( this.ObjectAddress, ulRowID, pstrName, fData ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate EResult NativeAddSessionAttributeInt64USI( IntPtr thisptr, UInt64 ulSessionID, string pstrName, Int64 llData );
		public EResult AddSessionAttributeInt64( UInt64 ulSessionID, string pstrName, Int64 llData ) 
		{
			return this.GetFunction<NativeAddSessionAttributeInt64USI>( this.Functions.AddSessionAttributeInt6411 )( this.ObjectAddress, ulSessionID, pstrName, llData ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate EResult NativeAddRowAttributeInt64USI( IntPtr thisptr, UInt64 ulRowID, string pstrName, Int64 llData );
		public EResult AddRowAttributeInt64( UInt64 ulRowID, string pstrName, Int64 llData ) 
		{
			return this.GetFunction<NativeAddRowAttributeInt64USI>( this.Functions.AddRowAttributeInt6412 )( this.ObjectAddress, ulRowID, pstrName, llData ); 
		}
		
	};
}
