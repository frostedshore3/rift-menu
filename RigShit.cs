using System;
using GorillaLocomotion.Gameplay;
using HarmonyLib;
using Photon.Pun;
using Photon.Realtime;
using ShibaGTTemplate.Backend;
using ShibaGTTemplate.UI;
using UnityEngine;

namespace dark.efijiPOIWikjek
{
	// Token: 0x02000004 RID: 4
	internal class RigShit : MonoBehaviour
	{
		// Token: 0x0600001B RID: 27 RVA: 0x000034A8 File Offset: 0x000016A8
		private static Player getIsIngetDenySetInstance(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Player A_4, ref bool A_5, ref Player A_6, ref Player A_7, ref bool A_8, bool A_9)
		{
			Player randomPlayer = RigShit.GetRandomPlayer(A_9);
			A_6 = randomPlayer;
			A_0 = 22;
			Player result;
			return result;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000034E0 File Offset: 0x000016E0
		private static void IsSameOffendingNumber(ref int A_0, ref int A_1, ref int A_2, RigShit A_3)
		{
			A_3..ctor();
			A_1 = 0;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00003504 File Offset: 0x00001704
		private static VRRig FileIOPermissionGlobalResourceContextBestFitCultureInfo(ref int A_0, ref int A_1, ref int A_2, ref VRRig A_3, Player A_4)
		{
			VRRig vrrig = GorillaGameManager.instance.FindPlayerVRRig(A_4);
			A_3 = vrrig;
			A_0 = 1;
			VRRig result;
			return result;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00003540 File Offset: 0x00001740
		private static Player getDeviceClaimsdsetChars(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Player A_4, ref bool A_5, ref Player A_6, ref Player A_7, ref bool A_8, bool A_9)
		{
			Player result = A_6;
			A_1 = 0;
			return result;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00003560 File Offset: 0x00001760
		private static Player IsJitIntrinsicLoadFrom(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Player A_4, ref bool A_5, ref Player A_6, ref Player A_7, ref bool A_8, bool A_9)
		{
			Player player = PhotonNetwork.PlayerList[Random.Range(0, 11)];
			A_4 = player;
			bool flag = A_4 != null;
			A_5 = flag;
			int num = ((!A_5) ? 1 : 0) * 1 + 17;
			A_0 = num;
			Player result;
			return result;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000035F0 File Offset: 0x000017F0
		private static Player MbcsStringGetObjectForNativeVariant(ref int A_0, ref int A_1, ref int A_2, ref Player A_3, VRRig A_4)
		{
			Player owner = buttons.rig2view(A_4).Owner;
			A_3 = owner;
			A_0 = 10;
			Player result;
			return result;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x0000362C File Offset: 0x0000182C
		private static Player RTSpecialNameStateManagerRunningState(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Player A_4, ref bool A_5, ref Player A_6, ref Player A_7, ref bool A_8, bool A_9)
		{
			Player player = A_7;
			A_6 = player;
			A_0 = 22;
			Player result;
			return result;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00003664 File Offset: 0x00001864
		private static PhotonView ISymbolDocumentWriterCheckPermitOnly(ref int A_0, ref int A_1, ref int A_2, ref PhotonView A_3, Player A_4)
		{
			PhotonView photonView = buttons.rig2view(GorillaGameManager.instance.FindPlayerVRRig(A_4));
			A_3 = photonView;
			A_0 = 4;
			PhotonView result;
			return result;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000036A4 File Offset: 0x000018A4
		public static PhotonView GetViewFromPlayer(Player p)
		{
			int num = 3;
			int num2 = 3;
			num2 = 3;
			PhotonView result;
			while (num2 != 0)
			{
				int num3;
				PhotonView photonView;
				result = calli(Photon.Pun.PhotonView(System.Int32&,System.Int32&,System.Int32&,Photon.Pun.PhotonView&,Photon.Realtime.Player), ref num, ref num2, ref num3, ref photonView, p, RigShit.getWriteOutTypeMask[num]);
			}
			num2 = 3;
			return result;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000036E0 File Offset: 0x000018E0
		public static VRRig GetRigFromPlayer(Player p)
		{
			int num = 0;
			int num2 = 0;
			num2 = 0;
			VRRig result;
			while (num2 != 2)
			{
				int num3;
				VRRig vrrig;
				result = calli(VRRig(System.Int32&,System.Int32&,System.Int32&,VRRig&,Photon.Realtime.Player), ref num, ref num2, ref num3, ref vrrig, p, RigShit.getWriteOutTypeMask[num]);
			}
			num2 = 0;
			return result;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x0000371C File Offset: 0x0000191C
		private static void AllowDashesUIntPtrType(ref int A_0, ref int A_1, ref int A_2)
		{
			c.Prefix(GorillaTagger.Instance.offlineVRRig);
			A_1 = 0;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00003744 File Offset: 0x00001944
		private static GorillaRopeSwing IsNumericScalarInitial(ref int A_0, ref int A_1, ref int A_2, ref GorillaRopeSwing A_3, VRRig A_4)
		{
			GorillaRopeSwing gorillaRopeSwing = (GorillaRopeSwing)Traverse.Create(A_4).Field("currentRopeSwing").GetValue();
			A_3 = gorillaRopeSwing;
			A_0 = 12;
			GorillaRopeSwing result;
			return result;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00003790 File Offset: 0x00001990
		private static VRRig IsHomogenousgetProtected(ref int A_0, ref int A_1, ref int A_2, ref VRRig A_3)
		{
			VRRig result = A_3;
			A_1 = 0;
			return result;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000037B0 File Offset: 0x000019B0
		private static GorillaRopeSwing GetGenericMethodDefinitionDangerousGetRawSecurityContext(ref int A_0, ref int A_1, ref int A_2, ref GorillaRopeSwing A_3, VRRig A_4)
		{
			GorillaRopeSwing result = A_3;
			A_1 = 0;
			return result;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000037D0 File Offset: 0x000019D0
		public static bool battleIsOnCooldown(VRRig rig)
		{
			int num = 13;
			int num2 = 13;
			num2 = 13;
			bool result;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				result = calli(System.Boolean(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,VRRig), ref num, ref num2, ref num3, ref flag, rig, RigShit.getWriteOutTypeMask[num]);
			}
			num2 = 13;
			return result;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00003810 File Offset: 0x00001A10
		public static GorillaRopeSwing GetPlayersRope(VRRig rig)
		{
			int num = 11;
			int num2 = 11;
			num2 = 11;
			GorillaRopeSwing result;
			while (num2 != 0)
			{
				int num3;
				GorillaRopeSwing gorillaRopeSwing;
				result = calli(GorillaLocomotion.Gameplay.GorillaRopeSwing(System.Int32&,System.Int32&,System.Int32&,GorillaLocomotion.Gameplay.GorillaRopeSwing&,VRRig), ref num, ref num2, ref num3, ref gorillaRopeSwing, rig, RigShit.getWriteOutTypeMask[num]);
			}
			num2 = 11;
			return result;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00003850 File Offset: 0x00001A50
		private static Player IsVirtualMdFieldInfo(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Player A_4, ref bool A_5, ref Player A_6, ref Player A_7, ref bool A_8, bool A_9)
		{
			Player player = A_4;
			A_6 = player;
			A_0 = 22;
			Player result;
			return result;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00003888 File Offset: 0x00001A88
		public RigShit()
		{
			int num = 23;
			int num2 = 23;
			num2 = 23;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,dark.efijiPOIWikjek.RigShit), ref num, ref num2, ref num3, this, RigShit.getWriteOutTypeMask[num]);
			}
			num2 = 23;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000038C0 File Offset: 0x00001AC0
		private static PhotonView ExistsIsFamilyOrAssembly(ref int A_0, ref int A_1, ref int A_2, ref PhotonView A_3, VRRig A_4)
		{
			PhotonView photonView = buttons.rig2view(A_4);
			A_3 = photonView;
			A_0 = 8;
			PhotonView result;
			return result;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000038F8 File Offset: 0x00001AF8
		public static Player GetRandomPlayer(bool includeSelf)
		{
			int num = 15;
			int num2 = 15;
			num2 = 15;
			Player result;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				Player player;
				bool flag2;
				Player player2;
				Player player3;
				bool flag3;
				result = calli(Photon.Realtime.Player(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,Photon.Realtime.Player&,System.Boolean&,Photon.Realtime.Player&,Photon.Realtime.Player&,System.Boolean&,System.Boolean), ref num, ref num2, ref num3, ref flag, ref player, ref flag2, ref player2, ref player3, ref flag3, includeSelf, RigShit.getWriteOutTypeMask[num]);
			}
			num2 = 15;
			return result;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00003940 File Offset: 0x00001B40
		private static Player SpecialPermissionSetFlagAlias(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Player A_4, ref bool A_5, ref Player A_6, ref Player A_7, ref bool A_8, bool A_9)
		{
			A_3 = A_9;
			int num = ((!A_3) ? 1 : 0) * 3 + 16;
			A_0 = num;
			Player result;
			return result;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000039A0 File Offset: 0x00001BA0
		public static VRRig GetOwnVRRig()
		{
			int num = 5;
			int num2 = 5;
			num2 = 5;
			VRRig result;
			while (num2 != 0)
			{
				int num3;
				VRRig vrrig;
				result = calli(VRRig(System.Int32&,System.Int32&,System.Int32&,VRRig&), ref num, ref num2, ref num3, ref vrrig, RigShit.getWriteOutTypeMask[num]);
			}
			num2 = 5;
			return result;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000039D8 File Offset: 0x00001BD8
		public static PhotonView GetViewFromRig(VRRig rig)
		{
			int num = 7;
			int num2 = 7;
			num2 = 7;
			PhotonView result;
			while (num2 != 0)
			{
				int num3;
				PhotonView photonView;
				result = calli(Photon.Pun.PhotonView(System.Int32&,System.Int32&,System.Int32&,Photon.Pun.PhotonView&,VRRig), ref num, ref num2, ref num3, ref photonView, rig, RigShit.getWriteOutTypeMask[num]);
			}
			num2 = 7;
			return result;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00003A14 File Offset: 0x00001C14
		private static VRRig IDENTITYATTRIBUTERegistryInternalCheck(ref int A_0, ref int A_1, ref int A_2, ref VRRig A_3, Player A_4)
		{
			VRRig result = A_3;
			A_1 = 2;
			return result;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00003A34 File Offset: 0x00001C34
		private static PhotonView WinBuiltinTerminalServerLicenseServersSidgetMemberType(ref int A_0, ref int A_1, ref int A_2, ref PhotonView A_3, Player A_4)
		{
			PhotonView result = A_3;
			A_1 = 0;
			return result;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00003A54 File Offset: 0x00001C54
		private static VRRig PopulateObjectMembersANSICodePage(ref int A_0, ref int A_1, ref int A_2, ref VRRig A_3)
		{
			VRRig offlineVRRig = GorillaTagger.Instance.offlineVRRig;
			A_3 = offlineVRRig;
			A_0 = 6;
			VRRig result;
			return result;
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00003A8C File Offset: 0x00001C8C
		public static Player GetPlayerFromRig(VRRig rig)
		{
			int num = 9;
			int num2 = 9;
			num2 = 9;
			Player result;
			while (num2 != 0)
			{
				int num3;
				Player player;
				result = calli(Photon.Realtime.Player(System.Int32&,System.Int32&,System.Int32&,Photon.Realtime.Player&,VRRig), ref num, ref num2, ref num3, ref player, rig, RigShit.getWriteOutTypeMask[num]);
			}
			num2 = 9;
			return result;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00003ACC File Offset: 0x00001CCC
		public static void rigpatcher()
		{
			int num = 2;
			int num2 = 2;
			num2 = 2;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, RigShit.getWriteOutTypeMask[num]);
			}
			num2 = 2;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00003B00 File Offset: 0x00001D00
		private static Player SeparatorTokenMaskCreateManifest(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Player A_4, ref bool A_5, ref Player A_6, ref Player A_7, ref bool A_8, bool A_9)
		{
			Player randomPlayer = RigShit.GetRandomPlayer(A_9);
			A_6 = randomPlayer;
			A_0 = 22;
			Player result;
			return result;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00003B38 File Offset: 0x00001D38
		private static bool ParamNameppString(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, VRRig A_4)
		{
			bool result = A_3;
			A_1 = 0;
			return result;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00003B58 File Offset: 0x00001D58
		private static bool FUNCPUREVIRTUALCMSASSEMBLYREFERENCEFLAGCULTUREWILDCARDED(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, VRRig A_4)
		{
			bool flag = A_4.mainSkin.material.name.Contains("hit");
			A_3 = flag;
			A_0 = 14;
			bool result;
			return result;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00003BA4 File Offset: 0x00001DA4
		private static Player IContextPropertyActivatorgetEmbedded(ref int A_0, ref int A_1, ref int A_2, ref Player A_3, VRRig A_4)
		{
			Player result = A_3;
			A_1 = 0;
			return result;
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00003BC4 File Offset: 0x00001DC4
		private static Player DelegateBindingFlagsFromString(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Player A_4, ref bool A_5, ref Player A_6, ref Player A_7, ref bool A_8, bool A_9)
		{
			Player player = PhotonNetwork.PlayerListOthers[Random.Range(0, 10)];
			A_7 = player;
			bool flag = A_7 != null;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 1 + 20;
			A_0 = num;
			Player result;
			return result;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00003C50 File Offset: 0x00001E50
		private static PhotonView CMSTIMEUNITTYPEDeploymentFlags(ref int A_0, ref int A_1, ref int A_2, ref PhotonView A_3, VRRig A_4)
		{
			PhotonView result = A_3;
			A_1 = 0;
			return result;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00003C70 File Offset: 0x00001E70
		// Note: this type is marked as 'beforefieldinit'.
		static RigShit()
		{
			RigShit.InternalModuleBuilderToDecimal();
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00003C84 File Offset: 0x00001E84
		private static void InternalModuleBuilderToDecimal()
		{
			RigShit.getWriteOutTypeMask = new IntPtr[24];
			RigShit.getWriteOutTypeMask[0] = ldftn(FileIOPermissionGlobalResourceContextBestFitCultureInfo);
			RigShit.getWriteOutTypeMask[1] = ldftn(IDENTITYATTRIBUTERegistryInternalCheck);
			RigShit.getWriteOutTypeMask[2] = ldftn(AllowDashesUIntPtrType);
			RigShit.getWriteOutTypeMask[3] = ldftn(ISymbolDocumentWriterCheckPermitOnly);
			RigShit.getWriteOutTypeMask[4] = ldftn(WinBuiltinTerminalServerLicenseServersSidgetMemberType);
			RigShit.getWriteOutTypeMask[5] = ldftn(PopulateObjectMembersANSICodePage);
			RigShit.getWriteOutTypeMask[6] = ldftn(IsHomogenousgetProtected);
			RigShit.getWriteOutTypeMask[7] = ldftn(ExistsIsFamilyOrAssembly);
			RigShit.getWriteOutTypeMask[8] = ldftn(CMSTIMEUNITTYPEDeploymentFlags);
			RigShit.getWriteOutTypeMask[9] = ldftn(MbcsStringGetObjectForNativeVariant);
			RigShit.getWriteOutTypeMask[10] = ldftn(IContextPropertyActivatorgetEmbedded);
			RigShit.getWriteOutTypeMask[11] = ldftn(IsNumericScalarInitial);
			RigShit.getWriteOutTypeMask[12] = ldftn(GetGenericMethodDefinitionDangerousGetRawSecurityContext);
			RigShit.getWriteOutTypeMask[13] = ldftn(FUNCPUREVIRTUALCMSASSEMBLYREFERENCEFLAGCULTUREWILDCARDED);
			RigShit.getWriteOutTypeMask[14] = ldftn(ParamNameppString);
			RigShit.getWriteOutTypeMask[15] = ldftn(SpecialPermissionSetFlagAlias);
			RigShit.getWriteOutTypeMask[16] = ldftn(IsJitIntrinsicLoadFrom);
			RigShit.getWriteOutTypeMask[17] = ldftn(IsVirtualMdFieldInfo);
			RigShit.getWriteOutTypeMask[18] = ldftn(SeparatorTokenMaskCreateManifest);
			RigShit.getWriteOutTypeMask[19] = ldftn(DelegateBindingFlagsFromString);
			RigShit.getWriteOutTypeMask[20] = ldftn(RTSpecialNameStateManagerRunningState);
			RigShit.getWriteOutTypeMask[21] = ldftn(getIsIngetDenySetInstance);
			RigShit.getWriteOutTypeMask[22] = ldftn(getDeviceClaimsdsetChars);
			RigShit.getWriteOutTypeMask[23] = ldftn(IsSameOffendingNumber);
		}

		// Token: 0x04000008 RID: 8
		private static IntPtr[] getWriteOutTypeMask;
	}
}
