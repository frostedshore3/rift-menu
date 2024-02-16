using System;
using GTAG_NotificationLib;
using HarmonyLib;
using Photon.Pun;
using UnityEngine;

namespace ShibaGTTemplate.Backend
{
	// Token: 0x02000014 RID: 20
	[HarmonyPatch(typeof(GorillaNot), "SendReport")]
	internal class anticheatnotif : MonoBehaviour
	{
		// Token: 0x06000454 RID: 1108 RVA: 0x00026B3C File Offset: 0x00024D3C
		private static bool Prefix(string susReason, string susId, string susNick)
		{
			int num = 0;
			int num2 = 0;
			num2 = 0;
			bool result;
			while (num2 != 4)
			{
				int num3;
				bool flag;
				bool flag2;
				result = calli(System.Boolean(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,System.Boolean&,System.String,System.String), ref num, ref num2, ref num3, ref flag, ref flag2, susId, susReason, anticheatnotif.getInheritanceFlagsLdelemR[num]);
			}
			num2 = 0;
			return result;
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x00026B78 File Offset: 0x00024D78
		private static bool StartOfUserTypesTimeZoneKeyName(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, string A_5, string A_6)
		{
			bool result = A_4;
			A_1 = 4;
			return result;
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x00026B98 File Offset: 0x00024D98
		private static void AccountGuestSidgetCancel(ref int A_0, ref int A_1, ref int A_2, anticheatnotif A_3)
		{
			A_3..ctor();
			A_1 = 0;
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x00026BBC File Offset: 0x00024DBC
		private static bool ComponentCountLimitIStoreBindingResult(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, string A_5, string A_6)
		{
			NotifiLib.SendNotification("<color=red>[ANTICHEAT] REPORTED FOR: " + A_6 + "</color>");
			bool flag = false;
			A_4 = flag;
			A_0 = 3;
			bool result;
			return result;
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x00026C08 File Offset: 0x00024E08
		private static bool UnmgdWindowsIdentity(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, string A_5, string A_6)
		{
			bool flag = false;
			A_4 = flag;
			A_0 = 3;
			bool result;
			return result;
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x00026C3C File Offset: 0x00024E3C
		private static bool setDefaultThreadCurrentCultureSubject(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, string A_5, string A_6)
		{
			bool flag = A_5 == PhotonNetwork.LocalPlayer.UserId;
			A_3 = flag;
			int num = ((!A_3) ? 1 : 0) * 1 + 1;
			A_0 = num;
			bool result;
			return result;
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x00026CAC File Offset: 0x00024EAC
		public anticheatnotif()
		{
			int num = 4;
			int num2 = 4;
			num2 = 4;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,ShibaGTTemplate.Backend.anticheatnotif), ref num, ref num2, ref num3, this, anticheatnotif.getInheritanceFlagsLdelemR[num]);
			}
			num2 = 4;
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x00026CE0 File Offset: 0x00024EE0
		// Note: this type is marked as 'beforefieldinit'.
		static anticheatnotif()
		{
			anticheatnotif.LUNARETOROKUYOUNamedArguments();
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x00026CF4 File Offset: 0x00024EF4
		private static void LUNARETOROKUYOUNamedArguments()
		{
			anticheatnotif.getInheritanceFlagsLdelemR = new IntPtr[5];
			anticheatnotif.getInheritanceFlagsLdelemR[0] = ldftn(setDefaultThreadCurrentCultureSubject);
			anticheatnotif.getInheritanceFlagsLdelemR[1] = ldftn(ComponentCountLimitIStoreBindingResult);
			anticheatnotif.getInheritanceFlagsLdelemR[2] = ldftn(UnmgdWindowsIdentity);
			anticheatnotif.getInheritanceFlagsLdelemR[3] = ldftn(StartOfUserTypesTimeZoneKeyName);
			anticheatnotif.getInheritanceFlagsLdelemR[4] = ldftn(AccountGuestSidgetCancel);
		}

		// Token: 0x04000078 RID: 120
		private static IntPtr[] getInheritanceFlagsLdelemR;
	}
}
