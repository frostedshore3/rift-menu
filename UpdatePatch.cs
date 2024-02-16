using System;
using dark.efijiPOIWikjek;
using GorillaLocomotion;
using GTAG_NotificationLib;
using HarmonyLib;
using ShibaGTTemplate.Backend;
using ShibaGTTemplate.UI;
using UnityEngine;

namespace ShibaGTTemplate
{
	// Token: 0x02000009 RID: 9
	[HarmonyPatch(typeof(Player), "FixedUpdate")]
	internal class UpdatePatch
	{
		// Token: 0x0600007B RID: 123 RVA: 0x00005740 File Offset: 0x00003940
		private static void InternalModuleBuilderarray(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			bool flag = !UpdatePatch.alreadyInit;
			A_3 = flag;
			int num = ((!A_3) ? 1 : 0) * 1 + 1;
			A_0 = num;
		}

		// Token: 0x0600007C RID: 124 RVA: 0x000057A4 File Offset: 0x000039A4
		private static void getProcessIdNativeCalendarName(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			UpdatePatch.alreadyInit = true;
			UpdatePatch.Gameobject = new GameObject();
			UpdatePatch.Gameobject.AddComponent<Plugin>();
			UpdatePatch.Gameobject.AddComponent<buttons>();
			UpdatePatch.Gameobject.AddComponent<RigShit>();
			UpdatePatch.Gameobject.AddComponent<t>();
			UpdatePatch.Gameobject.AddComponent<c>();
			UpdatePatch.Gameobject.AddComponent<NotifiLib>();
			t.Load();
			Object.DontDestroyOnLoad(UpdatePatch.Gameobject);
			A_1 = 3;
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00005824 File Offset: 0x00003A24
		private static void DSAParametersPercentDecimalDigits(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			A_1 = 3;
		}

		// Token: 0x0600007E RID: 126 RVA: 0x0000583C File Offset: 0x00003A3C
		public UpdatePatch()
		{
			int num = 3;
			int num2 = 3;
			num2 = 3;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,ShibaGTTemplate.UpdatePatch), ref num, ref num2, ref num3, this, UpdatePatch.SyncStreamGetTypeHandle[num]);
			}
			num2 = 3;
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00005870 File Offset: 0x00003A70
		private static void Postfix()
		{
			int num = 0;
			int num2 = 0;
			num2 = 0;
			while (num2 != 3)
			{
				int num3;
				bool flag;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&), ref num, ref num2, ref num3, ref flag, UpdatePatch.SyncStreamGetTypeHandle[num]);
			}
			num2 = 0;
		}

		// Token: 0x06000080 RID: 128 RVA: 0x000058A4 File Offset: 0x00003AA4
		private static void TransformNamesRightToLeftOverride(ref int A_0, ref int A_1, ref int A_2, UpdatePatch A_3)
		{
			A_3..ctor();
			A_1 = 0;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x000058C8 File Offset: 0x00003AC8
		// Note: this type is marked as 'beforefieldinit'.
		static UpdatePatch()
		{
			UpdatePatch.UnSafeCharBufferDeleteSubKeyTree();
		}

		// Token: 0x06000082 RID: 130 RVA: 0x000058DC File Offset: 0x00003ADC
		private static void UnSafeCharBufferDeleteSubKeyTree()
		{
			UpdatePatch.SyncStreamGetTypeHandle = new IntPtr[4];
			UpdatePatch.SyncStreamGetTypeHandle[0] = ldftn(InternalModuleBuilderarray);
			UpdatePatch.SyncStreamGetTypeHandle[1] = ldftn(getProcessIdNativeCalendarName);
			UpdatePatch.SyncStreamGetTypeHandle[2] = ldftn(DSAParametersPercentDecimalDigits);
			UpdatePatch.SyncStreamGetTypeHandle[3] = ldftn(TransformNamesRightToLeftOverride);
		}

		// Token: 0x04000024 RID: 36
		private static bool alreadyInit;

		// Token: 0x04000025 RID: 37
		public static GameObject Gameobject;

		// Token: 0x04000026 RID: 38
		private static IntPtr[] SyncStreamGetTypeHandle;
	}
}
