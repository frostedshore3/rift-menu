using System;
using BepInEx;
using HarmonyLib;
using Loading;
using UnityEngine;

namespace ShibaGTTemplate
{
	// Token: 0x02000007 RID: 7
	[BepInPlugin("goldmenuyhippe", "org.shibagtiskinda.shiba.fun", "1.0.0")]
	public class Plugin : BaseUnityPlugin
	{
		// Token: 0x0600006D RID: 109 RVA: 0x000053F0 File Offset: 0x000035F0
		public Plugin()
		{
			int num = 5;
			int num2 = 5;
			num2 = 5;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,ShibaGTTemplate.Plugin), ref num, ref num2, ref num3, this, Plugin.getRestrictedMemberAccessIgnoreVisibility[num]);
			}
			num2 = 5;
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00005424 File Offset: 0x00003624
		private static void MuiResourceTypeIdIntStringIdsUtfXml(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Harmony A_4, Plugin A_5)
		{
			A_1 = 5;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x0000543C File Offset: 0x0000363C
		private void Awake()
		{
			int num = 0;
			int num2 = 0;
			num2 = 0;
			while (num2 != 5)
			{
				int num3;
				bool flag;
				Harmony harmony;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,HarmonyLib.Harmony&,ShibaGTTemplate.Plugin), ref num, ref num2, ref num3, ref flag, ref harmony, this, Plugin.getRestrictedMemberAccessIgnoreVisibility[num]);
			}
			num2 = 0;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00005474 File Offset: 0x00003674
		private static void OperandTypesetTag(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Harmony A_4, Plugin A_5)
		{
			int num = (A_5.patchedHarmony ? 1 : 0) * 1 + 1;
			A_0 = num;
		}

		// Token: 0x06000071 RID: 113 RVA: 0x000054BC File Offset: 0x000036BC
		private static void SetGetMethodRaiseMethod(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Harmony A_4, Plugin A_5)
		{
			Harmony harmony = new Harmony("org.shibagtiskinda.shiba.fun");
			A_4 = harmony;
			A_4.PatchAll();
			A_5.patchedHarmony = true;
			l.loaded = true;
			A_1 = 5;
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00005518 File Offset: 0x00003718
		private static void AmountTooLargeGetReplyMessage(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Harmony A_4, Plugin A_5)
		{
			bool flag = false;
			A_3 = flag;
			int num = ((!A_3) ? 1 : 0) * 1 + 3;
			A_0 = num;
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00005574 File Offset: 0x00003774
		private static void ParameterInfoDelegate(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Harmony A_4, Plugin A_5)
		{
			bool flag = !l.loaded;
			A_3 = flag;
			int num = ((!A_3) ? 1 : 0) * 1 + 3;
			A_0 = num;
		}

		// Token: 0x06000074 RID: 116 RVA: 0x000055DC File Offset: 0x000037DC
		private static void BuiltinAuthorizationAccessSidFileShare(ref int A_0, ref int A_1, ref int A_2, Plugin A_3)
		{
			A_3.patchedHarmony = false;
			A_3..ctor();
			A_1 = 0;
		}

		// Token: 0x06000075 RID: 117 RVA: 0x0000560C File Offset: 0x0000380C
		// Note: this type is marked as 'beforefieldinit'.
		static Plugin()
		{
			Plugin.RemainingIntegerIdsSize();
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00005620 File Offset: 0x00003820
		private static void RemainingIntegerIdsSize()
		{
			Plugin.getRestrictedMemberAccessIgnoreVisibility = new IntPtr[6];
			Plugin.getRestrictedMemberAccessIgnoreVisibility[0] = ldftn(OperandTypesetTag);
			Plugin.getRestrictedMemberAccessIgnoreVisibility[1] = ldftn(ParameterInfoDelegate);
			Plugin.getRestrictedMemberAccessIgnoreVisibility[2] = ldftn(AmountTooLargeGetReplyMessage);
			Plugin.getRestrictedMemberAccessIgnoreVisibility[3] = ldftn(SetGetMethodRaiseMethod);
			Plugin.getRestrictedMemberAccessIgnoreVisibility[4] = ldftn(MuiResourceTypeIdIntStringIdsUtfXml);
			Plugin.getRestrictedMemberAccessIgnoreVisibility[5] = ldftn(BuiltinAuthorizationAccessSidFileShare);
		}

		// Token: 0x0400001C RID: 28
		public const string Name = "goldmenuyhippe";

		// Token: 0x0400001D RID: 29
		public const string GUID = "org.shibagtiskinda.shiba.fun";

		// Token: 0x0400001E RID: 30
		public const string Version = "1.0.0";

		// Token: 0x0400001F RID: 31
		private bool patchedHarmony;

		// Token: 0x04000020 RID: 32
		private static GameObject Gameobject;

		// Token: 0x04000021 RID: 33
		private static IntPtr[] getRestrictedMemberAccessIgnoreVisibility;

		// Token: 0x02000008 RID: 8
		[Serializable]
		public class LoginData
		{
			// Token: 0x06000077 RID: 119 RVA: 0x000056A4 File Offset: 0x000038A4
			public LoginData()
			{
				int num = 0;
				int num2 = 0;
				num2 = 0;
				while (num2 != 1)
				{
					int num3;
					calli(System.Void(System.Int32&,System.Int32&,System.Int32&,ShibaGTTemplate.Plugin/LoginData), ref num, ref num2, ref num3, this, Plugin.LoginData.getKeyStoreMath[num]);
				}
				num2 = 0;
			}

			// Token: 0x06000078 RID: 120 RVA: 0x000056D8 File Offset: 0x000038D8
			private static void AllowCurrencySymbolFinal(ref int A_0, ref int A_1, ref int A_2, Plugin.LoginData A_3)
			{
				A_3..ctor();
				A_1 = 1;
			}

			// Token: 0x06000079 RID: 121 RVA: 0x000056FC File Offset: 0x000038FC
			// Note: this type is marked as 'beforefieldinit'.
			static LoginData()
			{
				Plugin.LoginData.FullReleaseAllResources();
			}

			// Token: 0x0600007A RID: 122 RVA: 0x00005710 File Offset: 0x00003910
			private static void FullReleaseAllResources()
			{
				Plugin.LoginData.getKeyStoreMath = new IntPtr[1];
				Plugin.LoginData.getKeyStoreMath[0] = ldftn(AllowCurrencySymbolFinal);
			}

			// Token: 0x04000022 RID: 34
			public string license;

			// Token: 0x04000023 RID: 35
			private static IntPtr[] getKeyStoreMath;
		}
	}
}
