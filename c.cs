using System;
using HarmonyLib;
using UnityEngine;

namespace ShibaGTTemplate.Backend
{
	// Token: 0x02000018 RID: 24
	[HarmonyPatch(typeof(VRRig), "OnDisable")]
	internal class c : MonoBehaviour
	{
		// Token: 0x06000607 RID: 1543 RVA: 0x00037CF8 File Offset: 0x00035EF8
		private static bool TaskExceptionHolderIsNotPublic(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, VRRig A_5)
		{
			bool flag = false;
			A_4 = flag;
			A_0 = 3;
			bool result;
			return result;
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x00037D2C File Offset: 0x00035F2C
		public c()
		{
			int num = 4;
			int num2 = 4;
			num2 = 4;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,ShibaGTTemplate.Backend.c), ref num, ref num2, ref num3, this, c.EncodingInfoSatelliteContractVersionAttribute[num]);
			}
			num2 = 4;
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x00037D60 File Offset: 0x00035F60
		private static bool GetObjectParamEnumUIntTypeInfo(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, VRRig A_5)
		{
			bool flag = A_5 == GorillaTagger.Instance.offlineVRRig;
			A_3 = flag;
			int num = ((!A_3) ? 1 : 0) * 1 + 1;
			A_0 = num;
			bool result;
			return result;
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x00037DD0 File Offset: 0x00035FD0
		public static bool Prefix(VRRig __instance)
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
				result = calli(System.Boolean(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,System.Boolean&,VRRig), ref num, ref num2, ref num3, ref flag, ref flag2, __instance, c.EncodingInfoSatelliteContractVersionAttribute[num]);
			}
			num2 = 0;
			return result;
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x00037E0C File Offset: 0x0003600C
		private static void CompatibleFrameworksMetadataEntryGetTransparentProxy(ref int A_0, ref int A_1, ref int A_2, c A_3)
		{
			A_3..ctor();
			A_1 = 0;
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x00037E30 File Offset: 0x00036030
		private static bool SafeHandleMinusOneIsInvalidTokenOwner(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, VRRig A_5)
		{
			bool result = A_4;
			A_1 = 4;
			return result;
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x00037E50 File Offset: 0x00036050
		private static bool getNewEnumInvalidOperationRegRemoveSubKey(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, VRRig A_5)
		{
			bool flag = true;
			A_4 = flag;
			A_0 = 3;
			bool result;
			return result;
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x00037E84 File Offset: 0x00036084
		// Note: this type is marked as 'beforefieldinit'.
		static c()
		{
			c.IsLetterTrackResurrection();
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x00037E98 File Offset: 0x00036098
		private static void IsLetterTrackResurrection()
		{
			c.EncodingInfoSatelliteContractVersionAttribute = new IntPtr[5];
			c.EncodingInfoSatelliteContractVersionAttribute[0] = ldftn(GetObjectParamEnumUIntTypeInfo);
			c.EncodingInfoSatelliteContractVersionAttribute[1] = ldftn(TaskExceptionHolderIsNotPublic);
			c.EncodingInfoSatelliteContractVersionAttribute[2] = ldftn(getNewEnumInvalidOperationRegRemoveSubKey);
			c.EncodingInfoSatelliteContractVersionAttribute[3] = ldftn(SafeHandleMinusOneIsInvalidTokenOwner);
			c.EncodingInfoSatelliteContractVersionAttribute[4] = ldftn(CompatibleFrameworksMetadataEntryGetTransparentProxy);
		}

		// Token: 0x0400008D RID: 141
		private static IntPtr[] EncodingInfoSatelliteContractVersionAttribute;
	}
}
