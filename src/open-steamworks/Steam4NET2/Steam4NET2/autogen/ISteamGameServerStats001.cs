// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Steam4NET
{

	[StructLayout(LayoutKind.Sequential,Pack=4)]
	public class ISteamGameServerStats001VTable
	{
		public IntPtr RequestUserStats0;
		public IntPtr GetUserStat1;
		public IntPtr GetUserStat2;
		public IntPtr GetUserAchievement3;
		public IntPtr SetUserStat4;
		public IntPtr SetUserStat5;
		public IntPtr UpdateUserAvgRateStat6;
		public IntPtr SetUserAchievement7;
		public IntPtr ClearUserAchievement8;
		public IntPtr StoreUserStats9;
		private IntPtr DTorISteamGameServerStats00110;
	};
	
	[InteropHelp.InterfaceVersion("SteamGameServerStats001")]
	public class ISteamGameServerStats001 : InteropHelp.NativeWrapper<ISteamGameServerStats001VTable>
	{
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeRequestUserStatsC( IntPtr thisptr, ref UInt64 retarg, UInt64 steamIDUser );
		public UInt64 RequestUserStats( CSteamID steamIDUser ) 
		{
			UInt64 ret = 0; this.GetFunction<NativeRequestUserStatsC>( this.Functions.RequestUserStats0 )( this.ObjectAddress, ref ret, steamIDUser.ConvertToUint64() ); return (UInt64)ret;
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetUserStatCSI( IntPtr thisptr, UInt64 steamIDUser, string pchName, ref Int32 pData );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool GetUserStat( CSteamID steamIDUser, string pchName, ref Int32 pData ) 
		{
			return this.GetFunction<NativeGetUserStatCSI>( this.Functions.GetUserStat1 )( this.ObjectAddress, steamIDUser.ConvertToUint64(), pchName, ref pData ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetUserStatCSF( IntPtr thisptr, UInt64 steamIDUser, string pchName, ref float pData );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool GetUserStat( CSteamID steamIDUser, string pchName, ref float pData ) 
		{
			return this.GetFunction<NativeGetUserStatCSF>( this.Functions.GetUserStat2 )( this.ObjectAddress, steamIDUser.ConvertToUint64(), pchName, ref pData ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetUserAchievementCSB( IntPtr thisptr, UInt64 steamIDUser, string pchName, ref bool pbAchieved );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool GetUserAchievement( CSteamID steamIDUser, string pchName, ref bool pbAchieved ) 
		{
			return this.GetFunction<NativeGetUserAchievementCSB>( this.Functions.GetUserAchievement3 )( this.ObjectAddress, steamIDUser.ConvertToUint64(), pchName, ref pbAchieved ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSetUserStatCSI( IntPtr thisptr, UInt64 steamIDUser, string pchName, Int32 nData );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool SetUserStat( CSteamID steamIDUser, string pchName, Int32 nData ) 
		{
			return this.GetFunction<NativeSetUserStatCSI>( this.Functions.SetUserStat4 )( this.ObjectAddress, steamIDUser.ConvertToUint64(), pchName, nData ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSetUserStatCSF( IntPtr thisptr, UInt64 steamIDUser, string pchName, float fData );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool SetUserStat( CSteamID steamIDUser, string pchName, float fData ) 
		{
			return this.GetFunction<NativeSetUserStatCSF>( this.Functions.SetUserStat5 )( this.ObjectAddress, steamIDUser.ConvertToUint64(), pchName, fData ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeUpdateUserAvgRateStatCSFD( IntPtr thisptr, UInt64 steamIDUser, string pchName, float flCountThisSession, double dSessionLength );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool UpdateUserAvgRateStat( CSteamID steamIDUser, string pchName, float flCountThisSession, double dSessionLength ) 
		{
			return this.GetFunction<NativeUpdateUserAvgRateStatCSFD>( this.Functions.UpdateUserAvgRateStat6 )( this.ObjectAddress, steamIDUser.ConvertToUint64(), pchName, flCountThisSession, dSessionLength ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSetUserAchievementCS( IntPtr thisptr, UInt64 steamIDUser, string pchName );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool SetUserAchievement( CSteamID steamIDUser, string pchName ) 
		{
			return this.GetFunction<NativeSetUserAchievementCS>( this.Functions.SetUserAchievement7 )( this.ObjectAddress, steamIDUser.ConvertToUint64(), pchName ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeClearUserAchievementCS( IntPtr thisptr, UInt64 steamIDUser, string pchName );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool ClearUserAchievement( CSteamID steamIDUser, string pchName ) 
		{
			return this.GetFunction<NativeClearUserAchievementCS>( this.Functions.ClearUserAchievement8 )( this.ObjectAddress, steamIDUser.ConvertToUint64(), pchName ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeStoreUserStatsC( IntPtr thisptr, ref UInt64 retarg, UInt64 steamIDUser );
		public UInt64 StoreUserStats( CSteamID steamIDUser ) 
		{
			UInt64 ret = 0; this.GetFunction<NativeStoreUserStatsC>( this.Functions.StoreUserStats9 )( this.ObjectAddress, ref ret, steamIDUser.ConvertToUint64() ); return (UInt64)ret;
		}
		
	};
}
