using System;
using GTAG_NotificationLib;
using HarmonyLib;
using Photon.Pun;
using Photon.Realtime;

namespace ShibaGTTemplate.Backend
{
	// Token: 0x02000022 RID: 34
	[HarmonyPatch(typeof(GorillaNot))]
	[HarmonyPatch("OnPlayerLeftRoom", 0)]
	internal class OnLeave : HarmonyPatch
	{
		// Token: 0x06000D37 RID: 3383 RVA: 0x000841C4 File Offset: 0x000823C4
		private static void AddAttributeUCOMIBindCtx(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, Player A_5)
		{
			bool flag = A_5 != PhotonNetwork.LocalPlayer;
			A_3 = flag;
			int num = ((!A_3) ? 1 : 0) * 3 + 1;
			A_0 = num;
		}

		// Token: 0x06000D38 RID: 3384 RVA: 0x00084230 File Offset: 0x00082430
		private static void getTagmdata(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, Player A_5)
		{
			A_1 = 5;
		}

		// Token: 0x06000D39 RID: 3385 RVA: 0x00084248 File Offset: 0x00082448
		public OnLeave()
		{
			int num = 5;
			int num2 = 5;
			num2 = 5;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,ShibaGTTemplate.Backend.OnLeave), ref num, ref num2, ref num3, this, OnLeave.CustomQueryInterfaceModeDesktopDirectory[num]);
			}
			num2 = 5;
		}

		// Token: 0x06000D3A RID: 3386 RVA: 0x0008427C File Offset: 0x0008247C
		private static void DefineInitializedDataGetNumericValue(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, Player A_5)
		{
			NotifiLib.SendNotification("<color=grey>[ROOM]:</color> " + A_5.NickName + " <color=red>[LEFT]</color>");
			bool isMasterClient = PhotonNetwork.IsMasterClient;
			A_4 = isMasterClient;
			int num = ((!A_4) ? 1 : 0) * 1 + 2;
			A_0 = num;
		}

		// Token: 0x06000D3B RID: 3387 RVA: 0x000842F8 File Offset: 0x000824F8
		private static void getRelativeSearchPathMngdNativeArrayMarshaler(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, Player A_5)
		{
			NotifiLib.SendNotification("<color=yellow>[ROOM]: YOU ARE NOW MASTER CLIENT!</color>");
			A_1 = 5;
		}

		// Token: 0x06000D3C RID: 3388 RVA: 0x00084320 File Offset: 0x00082520
		private static void Prefix(Player otherPlayer)
		{
			int num = 0;
			int num2 = 0;
			num2 = 0;
			while (num2 != 5)
			{
				int num3;
				bool flag;
				bool flag2;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,System.Boolean&,Photon.Realtime.Player), ref num, ref num2, ref num3, ref flag, ref flag2, otherPlayer, OnLeave.CustomQueryInterfaceModeDesktopDirectory[num]);
			}
			num2 = 0;
		}

		// Token: 0x06000D3D RID: 3389 RVA: 0x00084358 File Offset: 0x00082558
		private static void ContextPropertiesGetManifestResourceNames(ref int A_0, ref int A_1, ref int A_2, OnLeave A_3)
		{
			A_3..ctor();
			A_1 = 0;
		}

		// Token: 0x06000D3E RID: 3390 RVA: 0x0008437C File Offset: 0x0008257C
		private static void RawSecurityDescriptorFDefaultCollelem(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, Player A_5)
		{
			A_1 = 5;
		}

		// Token: 0x06000D3F RID: 3391 RVA: 0x00084394 File Offset: 0x00082594
		// Note: this type is marked as 'beforefieldinit'.
		static OnLeave()
		{
			OnLeave.ISurrogateSelectorConvRUn();
		}

		// Token: 0x06000D40 RID: 3392 RVA: 0x000843A8 File Offset: 0x000825A8
		private static void ISurrogateSelectorConvRUn()
		{
			OnLeave.CustomQueryInterfaceModeDesktopDirectory = new IntPtr[6];
			OnLeave.CustomQueryInterfaceModeDesktopDirectory[0] = ldftn(AddAttributeUCOMIBindCtx);
			OnLeave.CustomQueryInterfaceModeDesktopDirectory[1] = ldftn(DefineInitializedDataGetNumericValue);
			OnLeave.CustomQueryInterfaceModeDesktopDirectory[2] = ldftn(getRelativeSearchPathMngdNativeArrayMarshaler);
			OnLeave.CustomQueryInterfaceModeDesktopDirectory[3] = ldftn(getTagmdata);
			OnLeave.CustomQueryInterfaceModeDesktopDirectory[4] = ldftn(RawSecurityDescriptorFDefaultCollelem);
			OnLeave.CustomQueryInterfaceModeDesktopDirectory[5] = ldftn(ContextPropertiesGetManifestResourceNames);
		}

		// Token: 0x040000CD RID: 205
		private static IntPtr[] CustomQueryInterfaceModeDesktopDirectory;
	}
}
