using System;
using GTAG_NotificationLib;
using HarmonyLib;
using Photon.Realtime;

namespace ShibaGTTemplate.Backend
{
	// Token: 0x02000021 RID: 33
	[HarmonyPatch(typeof(GorillaNot))]
	[HarmonyPatch("OnPlayerEnteredRoom", 0)]
	internal class skidder : HarmonyPatch
	{
		// Token: 0x06000D31 RID: 3377 RVA: 0x000840AC File Offset: 0x000822AC
		private static void Prefix(Player newPlayer)
		{
			int num = 0;
			int num2 = 0;
			num2 = 0;
			while (num2 != 1)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,Photon.Realtime.Player), ref num, ref num2, ref num3, newPlayer, skidder.IsMailNewsDisplayUnadvise[num]);
			}
			num2 = 0;
		}

		// Token: 0x06000D32 RID: 3378 RVA: 0x000840E0 File Offset: 0x000822E0
		public skidder()
		{
			int num = 1;
			int num2 = 1;
			num2 = 1;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,ShibaGTTemplate.Backend.skidder), ref num, ref num2, ref num3, this, skidder.IsMailNewsDisplayUnadvise[num]);
			}
			num2 = 1;
		}

		// Token: 0x06000D33 RID: 3379 RVA: 0x00084114 File Offset: 0x00082314
		private static void FileIOPermissionAccessRemotingFieldCachedData(ref int A_0, ref int A_1, ref int A_2, Player A_3)
		{
			NotifiLib.SendNotification("<color=grey>[ROOM]:</color> " + A_3.NickName + " <color=green>[JOIN]</color>");
			A_1 = 1;
		}

		// Token: 0x06000D34 RID: 3380 RVA: 0x0008414C File Offset: 0x0008234C
		private static void AccessAllowedCompoundSecurityLogonType(ref int A_0, ref int A_1, ref int A_2, skidder A_3)
		{
			A_3..ctor();
			A_1 = 0;
		}

		// Token: 0x06000D35 RID: 3381 RVA: 0x00084170 File Offset: 0x00082370
		// Note: this type is marked as 'beforefieldinit'.
		static skidder()
		{
			skidder.RemoteAppEntryIVectorViewToIBindableVectorViewAdapter();
		}

		// Token: 0x06000D36 RID: 3382 RVA: 0x00084184 File Offset: 0x00082384
		private static void RemoteAppEntryIVectorViewToIBindableVectorViewAdapter()
		{
			skidder.IsMailNewsDisplayUnadvise = new IntPtr[2];
			skidder.IsMailNewsDisplayUnadvise[0] = ldftn(FileIOPermissionAccessRemotingFieldCachedData);
			skidder.IsMailNewsDisplayUnadvise[1] = ldftn(AccessAllowedCompoundSecurityLogonType);
		}

		// Token: 0x040000CC RID: 204
		private static IntPtr[] IsMailNewsDisplayUnadvise;
	}
}
