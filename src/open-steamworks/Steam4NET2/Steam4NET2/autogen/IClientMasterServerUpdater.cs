// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Steam4NET
{

	[StructLayout(LayoutKind.Sequential,Pack=4)]
	public class IClientMasterServerUpdaterVTable
	{
		public IntPtr SetActive0;
		public IntPtr SetHeartbeatInterval1;
		public IntPtr HandleIncomingPacket2;
		public IntPtr GetNextOutgoingPacket3;
		public IntPtr SetBasicServerData4;
		public IntPtr ClearAllKeyValues5;
		public IntPtr SetKeyValue6;
		public IntPtr NotifyShutdown7;
		public IntPtr WasRestartRequested8;
		public IntPtr ForceHeartbeat9;
		public IntPtr AddMasterServer10;
		public IntPtr RemoveMasterServer11;
		public IntPtr GetNumMasterServers12;
		public IntPtr GetMasterServerAddress13;
		private IntPtr DTorIClientMasterServerUpdater14;
	};
	
	[InteropHelp.InterfaceVersion("CLIENTMASTERSERVERUPDATER_INTERFACE_VERSION001")]
	public class IClientMasterServerUpdater : InteropHelp.NativeWrapper<IClientMasterServerUpdaterVTable>
	{
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetActiveB( IntPtr thisptr, [MarshalAs(UnmanagedType.I1)] bool bActive );
		public void SetActive( bool bActive ) 
		{
			this.GetFunction<NativeSetActiveB>( this.Functions.SetActive0 )( this.ObjectAddress, bActive ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetHeartbeatIntervalI( IntPtr thisptr, Int32 iHeartbeatInterval );
		public void SetHeartbeatInterval( Int32 iHeartbeatInterval ) 
		{
			this.GetFunction<NativeSetHeartbeatIntervalI>( this.Functions.SetHeartbeatInterval1 )( this.ObjectAddress, iHeartbeatInterval ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeHandleIncomingPacketBIUU( IntPtr thisptr, Byte[] pData, Int32 cbData, UInt32 srcIP, UInt16 srcPort );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool HandleIncomingPacket( Byte[] pData, UInt32 srcIP, UInt16 srcPort ) 
		{
			return this.GetFunction<NativeHandleIncomingPacketBIUU>( this.Functions.HandleIncomingPacket2 )( this.ObjectAddress, pData, (Int32) pData.Length, srcIP, srcPort ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetNextOutgoingPacketBIUU( IntPtr thisptr, Byte[] pOut, Int32 cbMaxOut, ref UInt32 pNetAdr, ref UInt16 pPort );
		public Int32 GetNextOutgoingPacket( Byte[] pOut, ref UInt32 pNetAdr, ref UInt16 pPort ) 
		{
			return this.GetFunction<NativeGetNextOutgoingPacketBIUU>( this.Functions.GetNextOutgoingPacket3 )( this.ObjectAddress, pOut, (Int32) pOut.Length, ref pNetAdr, ref pPort ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetBasicServerDataUBSSUBS( IntPtr thisptr, UInt16 nProtocolVersion, [MarshalAs(UnmanagedType.I1)] bool bDedicatedServer, string pRegionName, string pProductName, UInt16 nMaxReportedClients, [MarshalAs(UnmanagedType.I1)] bool bPasswordProtected, string pGameDescription );
		public void SetBasicServerData( UInt16 nProtocolVersion, bool bDedicatedServer, string pRegionName, string pProductName, UInt16 nMaxReportedClients, bool bPasswordProtected, string pGameDescription ) 
		{
			this.GetFunction<NativeSetBasicServerDataUBSSUBS>( this.Functions.SetBasicServerData4 )( this.ObjectAddress, nProtocolVersion, bDedicatedServer, pRegionName, pProductName, nMaxReportedClients, bPasswordProtected, pGameDescription ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeClearAllKeyValues( IntPtr thisptr );
		public void ClearAllKeyValues(  ) 
		{
			this.GetFunction<NativeClearAllKeyValues>( this.Functions.ClearAllKeyValues5 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetKeyValueSS( IntPtr thisptr, string pKey, string pValue );
		public void SetKeyValue( string pKey, string pValue ) 
		{
			this.GetFunction<NativeSetKeyValueSS>( this.Functions.SetKeyValue6 )( this.ObjectAddress, pKey, pValue ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeNotifyShutdown( IntPtr thisptr );
		public void NotifyShutdown(  ) 
		{
			this.GetFunction<NativeNotifyShutdown>( this.Functions.NotifyShutdown7 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeWasRestartRequested( IntPtr thisptr );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool WasRestartRequested(  ) 
		{
			return this.GetFunction<NativeWasRestartRequested>( this.Functions.WasRestartRequested8 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeForceHeartbeat( IntPtr thisptr );
		public void ForceHeartbeat(  ) 
		{
			this.GetFunction<NativeForceHeartbeat>( this.Functions.ForceHeartbeat9 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeAddMasterServerS( IntPtr thisptr, string pServerAddress );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool AddMasterServer( string pServerAddress ) 
		{
			return this.GetFunction<NativeAddMasterServerS>( this.Functions.AddMasterServer10 )( this.ObjectAddress, pServerAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeRemoveMasterServerS( IntPtr thisptr, string pServerAddress );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool RemoveMasterServer( string pServerAddress ) 
		{
			return this.GetFunction<NativeRemoveMasterServerS>( this.Functions.RemoveMasterServer11 )( this.ObjectAddress, pServerAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetNumMasterServers( IntPtr thisptr );
		public Int32 GetNumMasterServers(  ) 
		{
			return this.GetFunction<NativeGetNumMasterServers>( this.Functions.GetNumMasterServers12 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetMasterServerAddressISI( IntPtr thisptr, Int32 iServer, StringBuilder pOut, Int32 outBufferSize );
		public Int32 GetMasterServerAddress( Int32 iServer, StringBuilder pOut, Int32 outBufferSize ) 
		{
			return this.GetFunction<NativeGetMasterServerAddressISI>( this.Functions.GetMasterServerAddress13 )( this.ObjectAddress, iServer, pOut, outBufferSize ); 
		}
		
	};
}
