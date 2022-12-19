// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Steam4NET
{

	[StructLayout(LayoutKind.Sequential,Pack=4)]
	public class ISteamNetworking001VTable
	{
		public IntPtr CreateListenSocket0;
		public IntPtr CreateP2PConnectionSocket1;
		public IntPtr CreateConnectionSocket2;
		public IntPtr DestroySocket3;
		public IntPtr DestroyListenSocket4;
		public IntPtr SendDataOnSocket5;
		public IntPtr IsDataAvailableOnSocket6;
		public IntPtr RetrieveDataFromSocket7;
		public IntPtr IsDataAvailable8;
		public IntPtr RetrieveData9;
		public IntPtr GetSocketInfo10;
		public IntPtr GetListenSocketInfo11;
		private IntPtr DTorISteamNetworking00112;
	};
	
	[InteropHelp.InterfaceVersion("SteamNetworking001")]
	public class ISteamNetworking001 : InteropHelp.NativeWrapper<ISteamNetworking001VTable>
	{
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeCreateListenSocketIUU( IntPtr thisptr, Int32 nVirtualP2PPort, UInt32 nIP, UInt16 nPort );
		public UInt32 CreateListenSocket( Int32 nVirtualP2PPort, UInt32 nIP, UInt16 nPort ) 
		{
			return this.GetFunction<NativeCreateListenSocketIUU>( this.Functions.CreateListenSocket0 )( this.ObjectAddress, nVirtualP2PPort, nIP, nPort ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeCreateP2PConnectionSocketCII( IntPtr thisptr, UInt64 steamIDTarget, Int32 nVirtualPort, Int32 nTimeoutSec );
		public UInt32 CreateP2PConnectionSocket( CSteamID steamIDTarget, Int32 nVirtualPort, Int32 nTimeoutSec ) 
		{
			return this.GetFunction<NativeCreateP2PConnectionSocketCII>( this.Functions.CreateP2PConnectionSocket1 )( this.ObjectAddress, steamIDTarget.ConvertToUint64(), nVirtualPort, nTimeoutSec ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeCreateConnectionSocketUUI( IntPtr thisptr, UInt32 nIP, UInt16 nPort, Int32 nTimeoutSec );
		public UInt32 CreateConnectionSocket( UInt32 nIP, UInt16 nPort, Int32 nTimeoutSec ) 
		{
			return this.GetFunction<NativeCreateConnectionSocketUUI>( this.Functions.CreateConnectionSocket2 )( this.ObjectAddress, nIP, nPort, nTimeoutSec ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeDestroySocketUB( IntPtr thisptr, UInt32 hSocket, [MarshalAs(UnmanagedType.I1)] bool bNotifyRemoteEnd );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool DestroySocket( UInt32 hSocket, bool bNotifyRemoteEnd ) 
		{
			return this.GetFunction<NativeDestroySocketUB>( this.Functions.DestroySocket3 )( this.ObjectAddress, hSocket, bNotifyRemoteEnd ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeDestroyListenSocketUB( IntPtr thisptr, UInt32 hSocket, [MarshalAs(UnmanagedType.I1)] bool bNotifyRemoteEnd );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool DestroyListenSocket( UInt32 hSocket, bool bNotifyRemoteEnd ) 
		{
			return this.GetFunction<NativeDestroyListenSocketUB>( this.Functions.DestroyListenSocket4 )( this.ObjectAddress, hSocket, bNotifyRemoteEnd ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSendDataOnSocketUBUB( IntPtr thisptr, UInt32 hSocket, Byte[] pubData, UInt32 cubData, [MarshalAs(UnmanagedType.I1)] bool bReliable );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool SendDataOnSocket( UInt32 hSocket, Byte[] pubData, bool bReliable ) 
		{
			return this.GetFunction<NativeSendDataOnSocketUBUB>( this.Functions.SendDataOnSocket5 )( this.ObjectAddress, hSocket, pubData, (UInt32) pubData.Length, bReliable ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeIsDataAvailableOnSocketUU( IntPtr thisptr, UInt32 hSocket, ref UInt32 pcubMsgSize );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool IsDataAvailableOnSocket( UInt32 hSocket, ref UInt32 pcubMsgSize ) 
		{
			return this.GetFunction<NativeIsDataAvailableOnSocketUU>( this.Functions.IsDataAvailableOnSocket6 )( this.ObjectAddress, hSocket, ref pcubMsgSize ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeRetrieveDataFromSocketUBUU( IntPtr thisptr, UInt32 hSocket, Byte[] pubDest, UInt32 cubDest, ref UInt32 pcubMsgSize );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool RetrieveDataFromSocket( UInt32 hSocket, Byte[] pubDest, ref UInt32 pcubMsgSize ) 
		{
			return this.GetFunction<NativeRetrieveDataFromSocketUBUU>( this.Functions.RetrieveDataFromSocket7 )( this.ObjectAddress, hSocket, pubDest, (UInt32) pubDest.Length, ref pcubMsgSize ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeIsDataAvailableUUU( IntPtr thisptr, UInt32 hListenSocket, ref UInt32 pcubMsgSize, ref UInt32 phSocket );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool IsDataAvailable( UInt32 hListenSocket, ref UInt32 pcubMsgSize, ref UInt32 phSocket ) 
		{
			return this.GetFunction<NativeIsDataAvailableUUU>( this.Functions.IsDataAvailable8 )( this.ObjectAddress, hListenSocket, ref pcubMsgSize, ref phSocket ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeRetrieveDataUBUU( IntPtr thisptr, UInt32 hListenSocket, Byte[] pubDest, UInt32 cubDest, ref UInt32 pcubMsgSize );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool RetrieveData( UInt32 hListenSocket, Byte[] pubDest, ref UInt32 pcubMsgSize ) 
		{
			return this.GetFunction<NativeRetrieveDataUBUU>( this.Functions.RetrieveData9 )( this.ObjectAddress, hListenSocket, pubDest, (UInt32) pubDest.Length, ref pcubMsgSize ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetSocketInfoUCIUU( IntPtr thisptr, UInt32 hSocket, ref UInt64 pSteamIDRemote, ref Int32 peSocketStatus, ref UInt32 punIPRemote, ref UInt16 punPortRemote );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool GetSocketInfo( UInt32 hSocket, ref CSteamID pSteamIDRemote, ref Int32 peSocketStatus, ref UInt32 punIPRemote, ref UInt16 punPortRemote ) 
		{
			UInt64 s0 = 0; var result = this.GetFunction<NativeGetSocketInfoUCIUU>( this.Functions.GetSocketInfo10 )( this.ObjectAddress, hSocket, ref s0, ref peSocketStatus, ref punIPRemote, ref punPortRemote ); pSteamIDRemote = new CSteamID(s0); return result;
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetListenSocketInfoUUU( IntPtr thisptr, UInt32 hListenSocket, ref UInt32 pnIP, ref UInt16 pnPort );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool GetListenSocketInfo( UInt32 hListenSocket, ref UInt32 pnIP, ref UInt16 pnPort ) 
		{
			return this.GetFunction<NativeGetListenSocketInfoUUU>( this.Functions.GetListenSocketInfo11 )( this.ObjectAddress, hListenSocket, ref pnIP, ref pnPort ); 
		}
		
	};
}
