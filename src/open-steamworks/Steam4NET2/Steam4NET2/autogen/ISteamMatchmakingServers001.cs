// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Steam4NET
{

	[StructLayout(LayoutKind.Sequential,Pack=4)]
	public class ISteamMatchmakingServers001VTable
	{
		public IntPtr RequestInternetServerList0;
		public IntPtr RequestLANServerList1;
		public IntPtr RequestFriendsServerList2;
		public IntPtr RequestFavoritesServerList3;
		public IntPtr RequestHistoryServerList4;
		public IntPtr RequestSpectatorServerList5;
		public IntPtr GetServerDetails6;
		public IntPtr CancelQuery7;
		public IntPtr RefreshQuery8;
		public IntPtr IsRefreshing9;
		public IntPtr GetServerCount10;
		public IntPtr RefreshServer11;
		public IntPtr PingServer12;
		public IntPtr PlayerDetails13;
		public IntPtr ServerRules14;
		public IntPtr CancelServerQuery15;
		private IntPtr DTorISteamMatchmakingServers00116;
	};
	
	[InteropHelp.InterfaceVersion("SteamMatchMakingServers001")]
	public class ISteamMatchmakingServers001 : InteropHelp.NativeWrapper<ISteamMatchmakingServers001VTable>
	{
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeRequestInternetServerListUMUI( IntPtr thisptr, UInt32 iApp, ref MatchMakingKeyValuePair_t ppchFilters, UInt32 nFilters, ref ISteamMatchmakingServerListResponse001 pRequestServersResponse );
		public void RequestInternetServerList( UInt32 iApp, ref MatchMakingKeyValuePair_t ppchFilters, UInt32 nFilters, ref ISteamMatchmakingServerListResponse001 pRequestServersResponse ) 
		{
			this.GetFunction<NativeRequestInternetServerListUMUI>( this.Functions.RequestInternetServerList0 )( this.ObjectAddress, iApp, ref ppchFilters, nFilters, ref pRequestServersResponse ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeRequestLANServerListUI( IntPtr thisptr, UInt32 iApp, ref ISteamMatchmakingServerListResponse001 pRequestServersResponse );
		public void RequestLANServerList( UInt32 iApp, ref ISteamMatchmakingServerListResponse001 pRequestServersResponse ) 
		{
			this.GetFunction<NativeRequestLANServerListUI>( this.Functions.RequestLANServerList1 )( this.ObjectAddress, iApp, ref pRequestServersResponse ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeRequestFriendsServerListUMUI( IntPtr thisptr, UInt32 iApp, ref MatchMakingKeyValuePair_t ppchFilters, UInt32 nFilters, ref ISteamMatchmakingServerListResponse001 pRequestServersResponse );
		public void RequestFriendsServerList( UInt32 iApp, ref MatchMakingKeyValuePair_t ppchFilters, UInt32 nFilters, ref ISteamMatchmakingServerListResponse001 pRequestServersResponse ) 
		{
			this.GetFunction<NativeRequestFriendsServerListUMUI>( this.Functions.RequestFriendsServerList2 )( this.ObjectAddress, iApp, ref ppchFilters, nFilters, ref pRequestServersResponse ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeRequestFavoritesServerListUMUI( IntPtr thisptr, UInt32 iApp, ref MatchMakingKeyValuePair_t ppchFilters, UInt32 nFilters, ref ISteamMatchmakingServerListResponse001 pRequestServersResponse );
		public void RequestFavoritesServerList( UInt32 iApp, ref MatchMakingKeyValuePair_t ppchFilters, UInt32 nFilters, ref ISteamMatchmakingServerListResponse001 pRequestServersResponse ) 
		{
			this.GetFunction<NativeRequestFavoritesServerListUMUI>( this.Functions.RequestFavoritesServerList3 )( this.ObjectAddress, iApp, ref ppchFilters, nFilters, ref pRequestServersResponse ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeRequestHistoryServerListUMUI( IntPtr thisptr, UInt32 iApp, ref MatchMakingKeyValuePair_t ppchFilters, UInt32 nFilters, ref ISteamMatchmakingServerListResponse001 pRequestServersResponse );
		public void RequestHistoryServerList( UInt32 iApp, ref MatchMakingKeyValuePair_t ppchFilters, UInt32 nFilters, ref ISteamMatchmakingServerListResponse001 pRequestServersResponse ) 
		{
			this.GetFunction<NativeRequestHistoryServerListUMUI>( this.Functions.RequestHistoryServerList4 )( this.ObjectAddress, iApp, ref ppchFilters, nFilters, ref pRequestServersResponse ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeRequestSpectatorServerListUMUI( IntPtr thisptr, UInt32 iApp, ref MatchMakingKeyValuePair_t ppchFilters, UInt32 nFilters, ref ISteamMatchmakingServerListResponse001 pRequestServersResponse );
		public void RequestSpectatorServerList( UInt32 iApp, ref MatchMakingKeyValuePair_t ppchFilters, UInt32 nFilters, ref ISteamMatchmakingServerListResponse001 pRequestServersResponse ) 
		{
			this.GetFunction<NativeRequestSpectatorServerListUMUI>( this.Functions.RequestSpectatorServerList5 )( this.ObjectAddress, iApp, ref ppchFilters, nFilters, ref pRequestServersResponse ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate gameserveritem_t NativeGetServerDetailsEI( IntPtr thisptr, EMatchMakingType eType, Int32 iServer );
		public gameserveritem_t GetServerDetails( EMatchMakingType eType, Int32 iServer ) 
		{
			return this.GetFunction<NativeGetServerDetailsEI>( this.Functions.GetServerDetails6 )( this.ObjectAddress, eType, iServer ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeCancelQueryE( IntPtr thisptr, EMatchMakingType eType );
		public void CancelQuery( EMatchMakingType eType ) 
		{
			this.GetFunction<NativeCancelQueryE>( this.Functions.CancelQuery7 )( this.ObjectAddress, eType ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeRefreshQueryE( IntPtr thisptr, EMatchMakingType eType );
		public void RefreshQuery( EMatchMakingType eType ) 
		{
			this.GetFunction<NativeRefreshQueryE>( this.Functions.RefreshQuery8 )( this.ObjectAddress, eType ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeIsRefreshingE( IntPtr thisptr, EMatchMakingType eType );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool IsRefreshing( EMatchMakingType eType ) 
		{
			return this.GetFunction<NativeIsRefreshingE>( this.Functions.IsRefreshing9 )( this.ObjectAddress, eType ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetServerCountE( IntPtr thisptr, EMatchMakingType eType );
		public Int32 GetServerCount( EMatchMakingType eType ) 
		{
			return this.GetFunction<NativeGetServerCountE>( this.Functions.GetServerCount10 )( this.ObjectAddress, eType ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeRefreshServerEI( IntPtr thisptr, EMatchMakingType eType, Int32 iServer );
		public void RefreshServer( EMatchMakingType eType, Int32 iServer ) 
		{
			this.GetFunction<NativeRefreshServerEI>( this.Functions.RefreshServer11 )( this.ObjectAddress, eType, iServer ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativePingServerUUI( IntPtr thisptr, UInt32 unIP, UInt16 usPort, ref ISteamMatchmakingPingResponse pRequestServersResponse );
		public Int32 PingServer( UInt32 unIP, UInt16 usPort, ref ISteamMatchmakingPingResponse pRequestServersResponse ) 
		{
			return this.GetFunction<NativePingServerUUI>( this.Functions.PingServer12 )( this.ObjectAddress, unIP, usPort, ref pRequestServersResponse ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativePlayerDetailsUUI( IntPtr thisptr, UInt32 unIP, UInt16 usPort, ref ISteamMatchmakingPlayersResponse pRequestServersResponse );
		public Int32 PlayerDetails( UInt32 unIP, UInt16 usPort, ref ISteamMatchmakingPlayersResponse pRequestServersResponse ) 
		{
			return this.GetFunction<NativePlayerDetailsUUI>( this.Functions.PlayerDetails13 )( this.ObjectAddress, unIP, usPort, ref pRequestServersResponse ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeServerRulesUUI( IntPtr thisptr, UInt32 unIP, UInt16 usPort, ref ISteamMatchmakingRulesResponse pRequestServersResponse );
		public Int32 ServerRules( UInt32 unIP, UInt16 usPort, ref ISteamMatchmakingRulesResponse pRequestServersResponse ) 
		{
			return this.GetFunction<NativeServerRulesUUI>( this.Functions.ServerRules14 )( this.ObjectAddress, unIP, usPort, ref pRequestServersResponse ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeCancelServerQueryI( IntPtr thisptr, Int32 hServerQuery );
		public void CancelServerQuery( Int32 hServerQuery ) 
		{
			this.GetFunction<NativeCancelServerQueryI>( this.Functions.CancelServerQuery15 )( this.ObjectAddress, hServerQuery ); 
		}
		
	};
}
