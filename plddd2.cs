using System;
using ExitGames.Client.Photon;
using GorillaLocomotion;
using Photon.Pun;
using Photon.Realtime;
using ShibaGTTemplate.UI;
using ShibaGTTemplate.Utilities;
using UnityEngine;

namespace ShibaGTTemplate.Backend
{
	// Token: 0x0200001E RID: 30
	internal class plddd2
	{
		// Token: 0x06000A61 RID: 2657 RVA: 0x0006856C File Offset: 0x0006676C
		private static void getDateStartNoFailureLog(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			plddd2.jump_left_local = GameObject.CreatePrimitive(3);
			plddd2.jump_left_local.GetComponent<Renderer>().material.SetColor("_Color", Color.black);
			A_18 = A_31;
			int num = ((!A_18) ? 1 : 0) * 1 + 95;
			A_0 = num;
		}

		// Token: 0x06000A62 RID: 2658 RVA: 0x000685F8 File Offset: 0x000667F8
		private static void GetFileNameWithoutExtensionMonthDatesep(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			Object.Destroy(plddd2.jump_left_network[A_28]);
			int num = A_28 + 1;
			A_28 = num;
			bool flag = A_28 < plddd2.jump_left_network.Length;
			A_29 = flag;
			int num2 = (A_29 ? 1 : 0) * -2 + 187;
			A_0 = num2;
		}

		// Token: 0x06000A63 RID: 2659 RVA: 0x00068698 File Offset: 0x00066898
		public plddd2()
		{
			int num = 267;
			int num2 = 267;
			num2 = 267;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,ShibaGTTemplate.Backend.plddd2), ref num, ref num2, ref num3, this, plddd2.ToStringsetCompoundAceType[num]);
			}
			num2 = 267;
		}

		// Token: 0x06000A64 RID: 2660 RVA: 0x000686DC File Offset: 0x000668DC
		private static void EventSourceExceptionExport(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			plddd2.jump_left_local = GameObject.CreatePrimitive(0);
			plddd2.jump_left_local.GetComponent<Renderer>().material.SetColor("_Color", Color.black);
			A_18 = A_31;
			int num = ((!A_18) ? 1 : 0) * 1 + 251;
			A_0 = num;
		}

		// Token: 0x06000A65 RID: 2661 RVA: 0x00068768 File Offset: 0x00066968
		private static void AddResourceFileAdjustGroups(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			plddd2.jump_left_local.transform.localScale = plddd2.cubescale;
			plddd2.jump_left_local.transform.position = new Vector3(0f, -0.01f, 0f) + Player.Instance.leftControllerTransform.position;
			plddd2.jump_left_local.transform.rotation = Player.Instance.leftControllerTransform.rotation;
			object[] array = new object[]
			{
				new Vector3(0f, -0.01f, 0f) + Player.Instance.leftControllerTransform.position,
				Player.Instance.leftControllerTransform.rotation
			};
			A_19 = array;
			RaiseEventOptions raiseEventOptions = new RaiseEventOptions
			{
				Receivers = 0
			};
			A_20 = raiseEventOptions;
			PhotonNetwork.RaiseEvent(69, A_19, A_20, SendOptions.SendReliable);
			plddd2.once_left = true;
			plddd2.once_left_false = false;
			ColorChanger colorChanger = plddd2.jump_left_local.AddComponent<ColorChanger>();
			A_21 = colorChanger;
			Gradient gradient = new Gradient();
			A_22 = gradient;
			A_22.colorKeys = plddd2.colorKeysPlatformMonke;
			A_21.colors = A_22;
			A_21.Start();
			A_0 = 141;
		}

		// Token: 0x06000A66 RID: 2662 RVA: 0x0006891C File Offset: 0x00066B1C
		private static void TokenElevationUnicodeClass(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref Rigidbody A_14, ref RaiseEventOptions A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref bool A_19, ref object[] A_20, ref RaiseEventOptions A_21, ref ColorChanger A_22, ref Gradient A_23, ref bool A_24, ref Rigidbody A_25, ref RaiseEventOptions A_26, ref bool A_27, ref int A_28, ref bool A_29, ref int A_30, ref bool A_31, bool A_32, bool A_33)
		{
			A_1 = 0;
		}

		// Token: 0x06000A67 RID: 2663 RVA: 0x00068934 File Offset: 0x00066B34
		private static void StringInfoInlineVar(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			plddd2.jump_right_local = GameObject.CreatePrimitive(3);
			plddd2.jump_right_local.GetComponent<Renderer>().material.SetColor("_Color", Color.black);
			A_8 = A_31;
			int num = ((!A_8) ? 1 : 0) * 1 + 197;
			A_0 = num;
		}

		// Token: 0x06000A68 RID: 2664 RVA: 0x000689C0 File Offset: 0x00066BC0
		private static void IMembershipConditionSystemX(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref bool A_5, ref GameObject A_6)
		{
			GameObject gameObject = GameObject.CreatePrimitive(3);
			A_4 = gameObject;
			A_4.transform.localScale = new Vector3(0.025f, 0.3f, 0.4f);
			A_4.transform.localPosition = GorillaTagger.Instance.leftHandTransform.position + new Vector3(0f, -0.05f, 0f);
			A_4.transform.rotation = GorillaTagger.Instance.rightHandTransform.rotation;
			A_4.GetComponent<Renderer>().material.color = new Color32(50, 50, 50, byte.MaxValue);
			A_4.AddComponent<GorillaSurfaceOverride>().overrideIndex = 61;
			Object.Destroy(A_4, 0.025f);
			bool gripDownL = buttons.gripDownL;
			A_5 = gripDownL;
			int num = ((!A_5) ? 1 : 0) * 1 + 21;
			A_0 = num;
		}

		// Token: 0x06000A69 RID: 2665 RVA: 0x00068B24 File Offset: 0x00066D24
		private static void ImportedFromTypeLibAttributeTrySetResult(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref Rigidbody A_14, ref RaiseEventOptions A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref bool A_19, ref object[] A_20, ref RaiseEventOptions A_21, ref ColorChanger A_22, ref Gradient A_23, ref bool A_24, ref Rigidbody A_25, ref RaiseEventOptions A_26, ref bool A_27, ref int A_28, ref bool A_29, ref int A_30, ref bool A_31, bool A_32, bool A_33)
		{
			int num = 0;
			A_30 = num;
			A_0 = 69;
		}

		// Token: 0x06000A6A RID: 2666 RVA: 0x00068B54 File Offset: 0x00066D54
		private static void getIsFixedDateRuleStelemRef(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			bool flag = plddd2.jump_left_local != null;
			A_23 = flag;
			int num = ((!A_23) ? 1 : 0) * 1 + 218;
			A_0 = num;
		}

		// Token: 0x06000A6B RID: 2667 RVA: 0x00068BBC File Offset: 0x00066DBC
		private static void SetLocalSignatureSzArray(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			bool flag = plddd2.jump_left_local != null;
			A_23 = flag;
			int num = ((!A_23) ? 1 : 0) * 1 + 179;
			A_0 = num;
		}

		// Token: 0x06000A6C RID: 2668 RVA: 0x00068C24 File Offset: 0x00066E24
		public static void Platforms()
		{
			int num = 0;
			int num2 = 0;
			num2 = 0;
			while (num2 != 2)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, plddd2.ToStringsetCompoundAceType[num]);
			}
			num2 = 0;
		}

		// Token: 0x06000A6D RID: 2669 RVA: 0x00068C58 File Offset: 0x00066E58
		public static void SpherePlats()
		{
			int num = 6;
			int num2 = 6;
			num2 = 6;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, plddd2.ToStringsetCompoundAceType[num]);
			}
			num2 = 6;
		}

		// Token: 0x06000A6E RID: 2670 RVA: 0x00068C8C File Offset: 0x00066E8C
		private static void WaitForFullGCApproachPolicyLevel(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			bool flag = plddd2.jump_right_local == null;
			A_6 = flag;
			int num = ((!A_6) ? 1 : 0) * 6 + 193;
			A_0 = num;
		}

		// Token: 0x06000A6F RID: 2671 RVA: 0x00068CF4 File Offset: 0x00066EF4
		private static void pValueUnmanagedExport(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			A_1 = 0;
		}

		// Token: 0x06000A70 RID: 2672 RVA: 0x00068D0C File Offset: 0x00066F0C
		private static void CalendricalCalculationsHelperGetValueKind(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			plddd2.jump_left_local.transform.localScale = plddd2.cylinderscale;
			plddd2.jump_left_local.transform.position = new Vector3(0f, -0.01f, 0f) + Player.Instance.leftControllerTransform.position;
			plddd2.jump_left_local.transform.rotation = Player.Instance.leftControllerTransform.rotation;
			object[] array = new object[]
			{
				new Vector3(0f, -0.01f, 0f) + Player.Instance.leftControllerTransform.position,
				Player.Instance.leftControllerTransform.rotation
			};
			A_19 = array;
			RaiseEventOptions raiseEventOptions = new RaiseEventOptions
			{
				Receivers = 0
			};
			A_20 = raiseEventOptions;
			PhotonNetwork.RaiseEvent(69, A_19, A_20, SendOptions.SendReliable);
			plddd2.once_left = true;
			plddd2.once_left_false = false;
			ColorChanger colorChanger = plddd2.jump_left_local.AddComponent<ColorChanger>();
			A_21 = colorChanger;
			Gradient gradient = new Gradient();
			A_22 = gradient;
			A_22.colorKeys = plddd2.colorKeysPlatformMonke;
			A_21.colors = A_22;
			A_21.Start();
			A_0 = 180;
		}

		// Token: 0x06000A71 RID: 2673 RVA: 0x00068EC0 File Offset: 0x000670C0
		private static void getMembersetHostCanGenerate(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			plddd2.jump_right_local.GetComponent<Renderer>().material.SetColor("_Color", Color.black);
			A_8 = A_31;
			int num = ((!A_8) ? 1 : 0) * 1 + 236;
			A_0 = num;
		}

		// Token: 0x06000A72 RID: 2674 RVA: 0x00068F3C File Offset: 0x0006713C
		private static void NaNOnSerializingAttribute(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			Object.Destroy(plddd2.jump_right_local.GetComponent<Renderer>());
			plddd2.jump_right_local.transform.localScale = plddd2.scale;
			plddd2.jump_right_local.transform.position = new Vector3(0f, -0.01f, 0f) + Player.Instance.rightControllerTransform.position;
			plddd2.jump_right_local.transform.rotation = Player.Instance.rightControllerTransform.rotation;
			object[] array = new object[]
			{
				new Vector3(0f, -0.01f, 0f) + Player.Instance.rightControllerTransform.position,
				Player.Instance.rightControllerTransform.rotation
			};
			A_9 = array;
			RaiseEventOptions raiseEventOptions = new RaiseEventOptions
			{
				Receivers = 0
			};
			A_10 = raiseEventOptions;
			PhotonNetwork.RaiseEvent(70, A_9, A_10, SendOptions.SendReliable);
			plddd2.once_right = true;
			plddd2.once_right_false = false;
			ColorChanger colorChanger = plddd2.jump_right_local.AddComponent<ColorChanger>();
			A_11 = colorChanger;
			Gradient gradient = new Gradient();
			A_12 = gradient;
			A_12.colorKeys = plddd2.colorKeysPlatformMonke;
			A_11.colors = A_12;
			A_11.Start();
			A_0 = 204;
		}

		// Token: 0x06000A73 RID: 2675 RVA: 0x00069100 File Offset: 0x00067300
		private static void TryPopBlockLongPaths(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref Rigidbody A_14, ref RaiseEventOptions A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref bool A_19, ref object[] A_20, ref RaiseEventOptions A_21, ref ColorChanger A_22, ref Gradient A_23, ref bool A_24, ref Rigidbody A_25, ref RaiseEventOptions A_26, ref bool A_27, ref int A_28, ref bool A_29, ref int A_30, ref bool A_31, bool A_32, bool A_33)
		{
			bool flag = false;
			A_17 = flag;
			int num = ((!A_17) ? 1 : 0) * 6 + 52;
			A_0 = num;
		}

		// Token: 0x06000A74 RID: 2676 RVA: 0x0006915C File Offset: 0x0006735C
		private static void IsControlArgumentNull(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			int num = (plddd2.once_left_false ? 1 : 0) * 1 + 216;
			A_0 = num;
		}

		// Token: 0x06000A75 RID: 2677 RVA: 0x000691A0 File Offset: 0x000673A0
		private static void CMSFILEFLAGSynchronizationContextNoFlow(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			bool flag = A_26 < plddd2.jump_right_network.Length;
			A_27 = flag;
			int num = (A_27 ? 1 : 0) * -2 + 262;
			A_0 = num;
		}

		// Token: 0x06000A76 RID: 2678 RVA: 0x00069208 File Offset: 0x00067408
		private static void AddEventHandlerMemoryBarrier(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			bool flag = false;
			A_13 = flag;
			int num = ((!A_13) ? 1 : 0) * 1 + 86;
			A_0 = num;
		}

		// Token: 0x06000A77 RID: 2679 RVA: 0x00069264 File Offset: 0x00067464
		private static void getIterationCountCMSENTRYPOINTFLAGCUSTOMUX(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref bool A_5, ref GameObject A_6)
		{
			bool gripDownR = buttons.gripDownR;
			A_5 = gripDownR;
			int num = ((!A_5) ? 1 : 0) * 1 + 16;
			A_0 = num;
		}

		// Token: 0x06000A78 RID: 2680 RVA: 0x000692C0 File Offset: 0x000674C0
		private static void GetTypeAndMethodNameFromSoapActionputSubscriptionId(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			A_1 = 0;
		}

		// Token: 0x06000A79 RID: 2681 RVA: 0x000692D8 File Offset: 0x000674D8
		private static void getFeedbackSizesetOrder(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			plddd2.jump_left_local.GetComponent<Renderer>().material.SetColor("_Color", Color.black);
			A_18 = A_31;
			int num = ((!A_18) ? 1 : 0) * 1 + 134;
			A_0 = num;
		}

		// Token: 0x06000A7A RID: 2682 RVA: 0x00069354 File Offset: 0x00067554
		private static void ActionCModOpt(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref Rigidbody A_14, ref RaiseEventOptions A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref bool A_19, ref object[] A_20, ref RaiseEventOptions A_21, ref ColorChanger A_22, ref Gradient A_23, ref bool A_24, ref Rigidbody A_25, ref RaiseEventOptions A_26, ref bool A_27, ref int A_28, ref bool A_29, ref int A_30, ref bool A_31, bool A_32, bool A_33)
		{
			bool flag = !PhotonNetwork.InRoom;
			A_27 = flag;
			int num = ((!A_27) ? 1 : 0) * 7 + 64;
			A_0 = num;
		}

		// Token: 0x06000A7B RID: 2683 RVA: 0x000693B8 File Offset: 0x000675B8
		private static void ContractFailureKindgetDirectory(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			plddd2.jump_right_local.GetComponent<Renderer>().material.SetColor("_Color", Color.black);
			A_8 = A_31;
			int num = ((!A_8) ? 1 : 0) * 1 + 197;
			A_0 = num;
		}

		// Token: 0x06000A7C RID: 2684 RVA: 0x00069434 File Offset: 0x00067634
		private static void SoapIdrefReadSubTree(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref Rigidbody A_14, ref RaiseEventOptions A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref bool A_19, ref object[] A_20, ref RaiseEventOptions A_21, ref ColorChanger A_22, ref Gradient A_23, ref bool A_24, ref Rigidbody A_25, ref RaiseEventOptions A_26, ref bool A_27, ref int A_28, ref bool A_29, ref int A_30, ref bool A_31, bool A_32, bool A_33)
		{
			bool flag = A_28 < plddd2.jump_right_network.Length;
			A_29 = flag;
			int num = (A_29 ? 1 : 0) * -2 + 67;
			A_0 = num;
		}

		// Token: 0x06000A7D RID: 2685 RVA: 0x0006949C File Offset: 0x0006769C
		private static void IsLetterOrDigitCallerFilePathAttribute(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			Object.Destroy(plddd2.jump_right_local.GetComponent<Renderer>());
			plddd2.jump_right_local.transform.localScale = plddd2.spherescale;
			plddd2.jump_right_local.transform.position = new Vector3(0f, -0.01f, 0f) + Player.Instance.rightControllerTransform.position;
			plddd2.jump_right_local.transform.rotation = Player.Instance.rightControllerTransform.rotation;
			object[] array = new object[]
			{
				new Vector3(0f, -0.01f, 0f) + Player.Instance.rightControllerTransform.position,
				Player.Instance.rightControllerTransform.rotation
			};
			A_9 = array;
			RaiseEventOptions raiseEventOptions = new RaiseEventOptions
			{
				Receivers = 0
			};
			A_10 = raiseEventOptions;
			PhotonNetwork.RaiseEvent(70, A_9, A_10, SendOptions.SendReliable);
			plddd2.once_right = true;
			plddd2.once_right_false = false;
			ColorChanger colorChanger = plddd2.jump_right_local.AddComponent<ColorChanger>();
			A_11 = colorChanger;
			Gradient gradient = new Gradient();
			A_12 = gradient;
			A_12.colorKeys = plddd2.colorKeysPlatformMonke;
			A_11.colors = A_12;
			A_11.Start();
			A_0 = 243;
		}

		// Token: 0x06000A7E RID: 2686 RVA: 0x00069660 File Offset: 0x00067860
		private static void StoreTransactionDataCODEBASEURL(ref int A_0, ref int A_1, ref int A_2, plddd2 A_3)
		{
			A_3..ctor();
			A_1 = 0;
		}

		// Token: 0x06000A7F RID: 2687 RVA: 0x00069684 File Offset: 0x00067884
		private static void MonitoringTotalAllocatedMemorySizeAssemblyRequestpermissionSetID(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref Rigidbody A_14, ref RaiseEventOptions A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref bool A_19, ref object[] A_20, ref RaiseEventOptions A_21, ref ColorChanger A_22, ref Gradient A_23, ref bool A_24, ref Rigidbody A_25, ref RaiseEventOptions A_26, ref bool A_27, ref int A_28, ref bool A_29, ref int A_30, ref bool A_31, bool A_32, bool A_33)
		{
			Object.Destroy(plddd2.jump_left_network[A_30]);
			int num = A_30 + 1;
			A_30 = num;
			bool flag = A_30 < plddd2.jump_left_network.Length;
			A_31 = flag;
			int num2 = (A_31 ? 1 : 0) * -2 + 70;
			A_0 = num2;
		}

		// Token: 0x06000A80 RID: 2688 RVA: 0x00069724 File Offset: 0x00067924
		private static void IReferenceAppIdPositiveInfinitySymbol(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref RaycastHit A_4, ref bool A_5, ref bool A_6, ref GameObject A_7)
		{
			Object.Destroy(pl.pointer);
			A_1 = 0;
		}

		// Token: 0x06000A81 RID: 2689 RVA: 0x00069748 File Offset: 0x00067948
		private static void BindableIterableToEnumerableAdapterICustomMarshaler(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref RaycastHit A_4, ref bool A_5, ref bool A_6, ref GameObject A_7)
		{
			plddd2.pointer = GameObject.CreatePrimitive(0);
			Object.Destroy(plddd2.pointer.GetComponent<Rigidbody>());
			Object.Destroy(plddd2.pointer.GetComponent<SphereCollider>());
			plddd2.pointer.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
			plddd2.pointer.GetComponent<Renderer>().material.color = new Color32(50, 50, 50, byte.MaxValue);
			plddd2.pointer.transform.position = A_4.point;
			bool triggerDownR = buttons.triggerDownR;
			A_6 = triggerDownR;
			int num = ((!A_6) ? 1 : 0) * 1 + 29;
			A_0 = num;
		}

		// Token: 0x06000A82 RID: 2690 RVA: 0x00069844 File Offset: 0x00067A44
		private static void CurrentConfigCanBeCanceled(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			bool flag = false;
			A_23 = flag;
			int num = ((!A_23) ? 1 : 0) * 1 + 257;
			A_0 = num;
		}

		// Token: 0x06000A83 RID: 2691 RVA: 0x000698A0 File Offset: 0x00067AA0
		private static void NativeRegisterRegisterRefresh(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			int num = (plddd2.once_left_false ? 1 : 0) * 1 + 138;
			A_0 = num;
		}

		// Token: 0x06000A84 RID: 2692 RVA: 0x000698E4 File Offset: 0x00067AE4
		private static void StindRefASCII(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			Object.Destroy(plddd2.jump_right_network[A_26]);
			int num = A_26 + 1;
			A_26 = num;
			bool flag = A_26 < plddd2.jump_right_network.Length;
			A_27 = flag;
			int num2 = (A_27 ? 1 : 0) * -2 + 223;
			A_0 = num2;
		}

		// Token: 0x06000A85 RID: 2693 RVA: 0x00069984 File Offset: 0x00067B84
		private static void DSTrusted(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			int num = (plddd2.once_right ? 1 : 0) * 1 + 230;
			A_0 = num;
		}

		// Token: 0x06000A86 RID: 2694 RVA: 0x000699C8 File Offset: 0x00067BC8
		private static void MetadataSectionRequestedExecutionLevelmetwSessionId(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			Object.Destroy(plddd2.jump_left_network[A_28]);
			int num = A_28 + 1;
			A_28 = num;
			bool flag = A_28 < plddd2.jump_left_network.Length;
			A_29 = flag;
			int num2 = (A_29 ? 1 : 0) * -2 + 148;
			A_0 = num2;
		}

		// Token: 0x06000A87 RID: 2695 RVA: 0x00069A68 File Offset: 0x00067C68
		private static void ParseExactWdiDiagnostic(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			plddd2.jump_left_local = GameObject.CreatePrimitive(0);
			A_0 = 250;
		}

		// Token: 0x06000A88 RID: 2696 RVA: 0x00069A90 File Offset: 0x00067C90
		private static void VTLPSTRIIDIEnumSTOREDEPLOYMENTMETADATAPROPERTY(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref Rigidbody A_14, ref RaiseEventOptions A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref bool A_19, ref object[] A_20, ref RaiseEventOptions A_21, ref ColorChanger A_22, ref Gradient A_23, ref bool A_24, ref Rigidbody A_25, ref RaiseEventOptions A_26, ref bool A_27, ref int A_28, ref bool A_29, ref int A_30, ref bool A_31, bool A_32, bool A_33)
		{
			int num = (plddd2.once_right ? 1 : 0) * 1 + 35;
			A_0 = num;
		}

		// Token: 0x06000A89 RID: 2697 RVA: 0x00069AD4 File Offset: 0x00067CD4
		private static void EnableGenericFieldInfo(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			bool flag = plddd2.jump_right_local != null;
			A_13 = flag;
			int num = ((!A_13) ? 1 : 0) * 1 + 86;
			A_0 = num;
		}

		// Token: 0x06000A8A RID: 2698 RVA: 0x00069B3C File Offset: 0x00067D3C
		private static void PostconditionOnExceptionsetAsUnknown(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			A_1 = 0;
		}

		// Token: 0x06000A8B RID: 2699 RVA: 0x00069B54 File Offset: 0x00067D54
		private static void WriteAllLinesOverflowException(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref bool A_5, ref GameObject A_6)
		{
			A_1 = 0;
		}

		// Token: 0x06000A8C RID: 2700 RVA: 0x00069B6C File Offset: 0x00067D6C
		private static void SetParametersSetComObjectData(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			A_1 = 0;
		}

		// Token: 0x06000A8D RID: 2701 RVA: 0x00069B84 File Offset: 0x00067D84
		private static void AppendTextDSASignatureDescription(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			A_17 = A_30;
			int num = ((!A_17) ? 1 : 0) * 1 + 248;
			A_0 = num;
		}

		// Token: 0x06000A8E RID: 2702 RVA: 0x00069BE0 File Offset: 0x00067DE0
		private static void addDomainUnloadAssemblyHash(ref int A_0, ref int A_1, ref int A_2)
		{
			plddd2.CylinderPlatforms(false, true);
			A_1 = 0;
		}

		// Token: 0x06000A8F RID: 2703 RVA: 0x00069C08 File Offset: 0x00067E08
		private static void MinBinaryLengthAddProperty(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			plddd2.colorKeysPlatformMonke[0].color = new Color32(20, 20, 20, byte.MaxValue);
			plddd2.colorKeysPlatformMonke[0].time = 0f;
			plddd2.colorKeysPlatformMonke[1].color = new Color32(50, 50, 50, byte.MaxValue);
			plddd2.colorKeysPlatformMonke[1].time = 0.5f;
			plddd2.colorKeysPlatformMonke[2].color = new Color32(50, 50, 50, byte.MaxValue);
			plddd2.colorKeysPlatformMonke[2].time = 0.5f;
			plddd2.colorKeysPlatformMonke[3].color = new Color32(20, 20, 20, byte.MaxValue);
			plddd2.colorKeysPlatformMonke[3].time = 1f;
			bool gripDownR = buttons.gripDownR;
			A_3 = gripDownR;
			bool gripDownL = buttons.gripDownL;
			A_4 = gripDownL;
			bool flag = A_3;
			A_5 = flag;
			int num = ((!A_5) ? 1 : 0) * 10 + 151;
			A_0 = num;
		}

		// Token: 0x06000A90 RID: 2704 RVA: 0x00069DC0 File Offset: 0x00067FC0
		private static void cbSizeVftflushStream(ref int A_0, ref int A_1, ref int A_2)
		{
			plddd2.GripPlatforms(false, false);
			A_1 = 2;
		}

		// Token: 0x06000A91 RID: 2705 RVA: 0x00069DE8 File Offset: 0x00067FE8
		private static void CreateFilesSafeLsaPolicyHandle(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			Object.Destroy(plddd2.jump_left_local.GetComponent<Renderer>());
			plddd2.jump_left_local.transform.localScale = plddd2.scale;
			plddd2.jump_left_local.transform.position = new Vector3(0f, -0.01f, 0f) + Player.Instance.leftControllerTransform.position;
			plddd2.jump_left_local.transform.rotation = Player.Instance.leftControllerTransform.rotation;
			object[] array = new object[]
			{
				new Vector3(0f, -0.01f, 0f) + Player.Instance.leftControllerTransform.position,
				Player.Instance.leftControllerTransform.rotation
			};
			A_19 = array;
			RaiseEventOptions raiseEventOptions = new RaiseEventOptions
			{
				Receivers = 0
			};
			A_20 = raiseEventOptions;
			PhotonNetwork.RaiseEvent(69, A_19, A_20, SendOptions.SendReliable);
			plddd2.once_left = true;
			plddd2.once_left_false = false;
			ColorChanger colorChanger = plddd2.jump_left_local.AddComponent<ColorChanger>();
			A_21 = colorChanger;
			Gradient gradient = new Gradient();
			A_22 = gradient;
			A_22.colorKeys = plddd2.colorKeysPlatformMonke;
			A_21.colors = A_22;
			A_21.Start();
			A_0 = 102;
		}

		// Token: 0x06000A92 RID: 2706 RVA: 0x00069FAC File Offset: 0x000681AC
		private static void WalkFreeListResultGetSourceLineInfoDelegate(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref Rigidbody A_14, ref RaiseEventOptions A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref bool A_19, ref object[] A_20, ref RaiseEventOptions A_21, ref ColorChanger A_22, ref Gradient A_23, ref bool A_24, ref Rigidbody A_25, ref RaiseEventOptions A_26, ref bool A_27, ref int A_28, ref bool A_29, ref int A_30, ref bool A_31, bool A_32, bool A_33)
		{
			bool flag = false;
			A_13 = flag;
			int num = ((!A_13) ? 1 : 0) * 1 + 47;
			A_0 = num;
		}

		// Token: 0x06000A93 RID: 2707 RVA: 0x0006A008 File Offset: 0x00068208
		private static void KeyNumberVTBOOL(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			A_0 = 258;
		}

		// Token: 0x06000A94 RID: 2708 RVA: 0x0006A020 File Offset: 0x00068220
		private static void DefineDefaultConstructorICustomProperty(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			bool flag = plddd2.jump_left_local == null;
			A_16 = flag;
			int num = ((!A_16) ? 1 : 0) * 6 + 91;
			A_0 = num;
		}

		// Token: 0x06000A95 RID: 2709 RVA: 0x0006A088 File Offset: 0x00068288
		private static void CommandSEPDate(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			A_7 = A_30;
			int num = ((!A_7) ? 1 : 0) * 1 + 194;
			A_0 = num;
		}

		// Token: 0x06000A96 RID: 2710 RVA: 0x0006A0E4 File Offset: 0x000682E4
		private static void ThreadTransferReceivegetRng(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			bool flag = false;
			A_6 = flag;
			int num = ((!A_6) ? 1 : 0) * 6 + 76;
			A_0 = num;
		}

		// Token: 0x06000A97 RID: 2711 RVA: 0x0006A140 File Offset: 0x00068340
		private static void IDispatchGetFieldOffset(ref int A_0, ref int A_1, ref int A_2)
		{
			plddd2.TriggerPlatforms(false, true);
			A_1 = 0;
		}

		// Token: 0x06000A98 RID: 2712 RVA: 0x0006A168 File Offset: 0x00068368
		private static void getCanTransformMultipleBlocksKeyPair(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref Rigidbody A_14, ref RaiseEventOptions A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref bool A_19, ref object[] A_20, ref RaiseEventOptions A_21, ref ColorChanger A_22, ref Gradient A_23, ref bool A_24, ref Rigidbody A_25, ref RaiseEventOptions A_26, ref bool A_27, ref int A_28, ref bool A_29, ref int A_30, ref bool A_31, bool A_32, bool A_33)
		{
			plddd2.jump_right_local.GetComponent<Renderer>().material.SetColor("_Color", Color.black);
			A_8 = A_33;
			int num = ((!A_8) ? 1 : 0) * 1 + 41;
			A_0 = num;
		}

		// Token: 0x06000A99 RID: 2713 RVA: 0x0006A1E4 File Offset: 0x000683E4
		private static void NativeDigitsManagedToNativeComInteropStubAttribute(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			plddd2.jump_right_local = GameObject.CreatePrimitive(0);
			A_0 = 196;
		}

		// Token: 0x06000A9A RID: 2714 RVA: 0x0006A20C File Offset: 0x0006840C
		private static void GetAvailableThreadsConstArray(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			plddd2.jump_right_local = GameObject.CreatePrimitive(3);
			plddd2.jump_right_local.GetComponent<Renderer>().material.SetColor("_Color", Color.black);
			A_8 = A_31;
			int num = ((!A_8) ? 1 : 0) * 1 + 119;
			A_0 = num;
		}

		// Token: 0x06000A9B RID: 2715 RVA: 0x0006A298 File Offset: 0x00068498
		private static void FullTrustListAssembliesInGacBigEndianUnicode(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref RaycastHit A_4, ref bool A_5, ref bool A_6, ref GameObject A_7)
		{
			plddd2.pointer.GetComponent<Renderer>().material.color = new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, 1);
			A_0 = 32;
		}

		// Token: 0x06000A9C RID: 2716 RVA: 0x0006A2E4 File Offset: 0x000684E4
		private static void MonitoringTotalProcessorTimeControlBreak(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			int num = 0;
			A_28 = num;
			A_0 = 147;
		}

		// Token: 0x06000A9D RID: 2717 RVA: 0x0006A314 File Offset: 0x00068514
		public static void CylinderPlatforms()
		{
			int num = 9;
			int num2 = 9;
			num2 = 9;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, plddd2.ToStringsetCompoundAceType[num]);
			}
			num2 = 9;
		}

		// Token: 0x06000A9E RID: 2718 RVA: 0x0006A34C File Offset: 0x0006854C
		private static void CMSSECTIONIDASSEMBLYREQUESTSECTIONgetCompatibleFrameworksData(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			A_1 = 0;
		}

		// Token: 0x06000A9F RID: 2719 RVA: 0x0006A364 File Offset: 0x00068564
		private static void ComEventsHelperOAVariantLib(ref int A_0, ref int A_1, ref int A_2)
		{
			plddd2.SpherePlatforms(false, false);
			A_1 = 0;
		}

		// Token: 0x06000AA0 RID: 2720 RVA: 0x0006A38C File Offset: 0x0006858C
		private static void ToStringHelperFuncStoreListValid(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			Object.Destroy(plddd2.jump_left_network[A_28]);
			int num = A_28 + 1;
			A_28 = num;
			bool flag = A_28 < plddd2.jump_left_network.Length;
			A_29 = flag;
			int num2 = (A_29 ? 1 : 0) * -2 + 109;
			A_0 = num2;
		}

		// Token: 0x06000AA1 RID: 2721 RVA: 0x0006A42C File Offset: 0x0006862C
		private static void GetPropertySigHelperKey(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			Object.Destroy(plddd2.jump_left_local.GetComponent<Renderer>());
			plddd2.jump_left_local.transform.localScale = plddd2.spherescale;
			plddd2.jump_left_local.transform.position = new Vector3(0f, -0.01f, 0f) + Player.Instance.leftControllerTransform.position;
			plddd2.jump_left_local.transform.rotation = Player.Instance.leftControllerTransform.rotation;
			object[] array = new object[]
			{
				new Vector3(0f, -0.01f, 0f) + Player.Instance.leftControllerTransform.position,
				Player.Instance.leftControllerTransform.rotation
			};
			A_19 = array;
			RaiseEventOptions raiseEventOptions = new RaiseEventOptions
			{
				Receivers = 0
			};
			A_20 = raiseEventOptions;
			PhotonNetwork.RaiseEvent(69, A_19, A_20, SendOptions.SendReliable);
			plddd2.once_left = true;
			plddd2.once_left_false = false;
			ColorChanger colorChanger = plddd2.jump_left_local.AddComponent<ColorChanger>();
			A_21 = colorChanger;
			Gradient gradient = new Gradient();
			A_22 = gradient;
			A_22.colorKeys = plddd2.colorKeysPlatformMonke;
			A_21.colors = A_22;
			A_21.Start();
			A_0 = 258;
		}

		// Token: 0x06000AA2 RID: 2722 RVA: 0x0006A5F0 File Offset: 0x000687F0
		private static void FailContinueFilterCrossMachine(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			int num = 0;
			A_26 = num;
			A_0 = 261;
		}

		// Token: 0x06000AA3 RID: 2723 RVA: 0x0006A620 File Offset: 0x00068820
		private static void GetMethodFromDocumentPositionIndexRange(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			bool flag = false;
			A_13 = flag;
			int num = ((!A_13) ? 1 : 0) * 1 + 125;
			A_0 = num;
		}

		// Token: 0x06000AA4 RID: 2724 RVA: 0x0006A67C File Offset: 0x0006887C
		private static void EphemeralKeySetsetCultureInfo(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			bool flag = !PhotonNetwork.InRoom;
			A_25 = flag;
			int num = ((!A_25) ? 1 : 0) * 7 + 142;
			A_0 = num;
		}

		// Token: 0x06000AA5 RID: 2725 RVA: 0x0006A6E0 File Offset: 0x000688E0
		private static void IMPLTYPEFLAGFDEFAULTgetDeclaredConstructors(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			bool flag = !PhotonNetwork.InRoom;
			A_25 = flag;
			int num = ((!A_25) ? 1 : 0) * 7 + 181;
			A_0 = num;
		}

		// Token: 0x06000AA6 RID: 2726 RVA: 0x0006A744 File Offset: 0x00068944
		private static void EnableEditAndContinueSupportsDynamicPartitions(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref Rigidbody A_14, ref RaiseEventOptions A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref bool A_19, ref object[] A_20, ref RaiseEventOptions A_21, ref ColorChanger A_22, ref Gradient A_23, ref bool A_24, ref Rigidbody A_25, ref RaiseEventOptions A_26, ref bool A_27, ref int A_28, ref bool A_29, ref int A_30, ref bool A_31, bool A_32, bool A_33)
		{
			bool flag = plddd2.jump_left_local != null;
			A_24 = flag;
			int num = ((!A_24) ? 1 : 0) * 1 + 62;
			A_0 = num;
		}

		// Token: 0x06000AA7 RID: 2727 RVA: 0x0006A7AC File Offset: 0x000689AC
		private static void getNamedArgumentsIsError(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			bool flag = !PhotonNetwork.InRoom;
			A_25 = flag;
			int num = ((!A_25) ? 1 : 0) * 7 + 220;
			A_0 = num;
		}

		// Token: 0x06000AA8 RID: 2728 RVA: 0x0006A810 File Offset: 0x00068A10
		private static void getIsLayoutSequentialNative(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			Object.Destroy(plddd2.jump_right_local.GetComponent<Renderer>());
			plddd2.jump_right_local.transform.localScale = plddd2.cylinderscale;
			plddd2.jump_right_local.transform.position = new Vector3(0f, -0.01f, 0f) + Player.Instance.rightControllerTransform.position;
			plddd2.jump_right_local.transform.rotation = Player.Instance.rightControllerTransform.rotation;
			object[] array = new object[]
			{
				new Vector3(0f, -0.01f, 0f) + Player.Instance.rightControllerTransform.position,
				Player.Instance.rightControllerTransform.rotation
			};
			A_9 = array;
			RaiseEventOptions raiseEventOptions = new RaiseEventOptions
			{
				Receivers = 0
			};
			A_10 = raiseEventOptions;
			PhotonNetwork.RaiseEvent(70, A_9, A_10, SendOptions.SendReliable);
			plddd2.once_right = true;
			plddd2.once_right_false = false;
			ColorChanger colorChanger = plddd2.jump_right_local.AddComponent<ColorChanger>();
			A_11 = colorChanger;
			Gradient gradient = new Gradient();
			A_12 = gradient;
			A_12.colorKeys = plddd2.colorKeysPlatformMonke;
			A_11.colors = A_12;
			A_11.Start();
			A_0 = 165;
		}

		// Token: 0x06000AA9 RID: 2729 RVA: 0x0006A9D4 File Offset: 0x00068BD4
		private static void MultiDomainHostsetKeyPassword(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			bool flag = false;
			A_6 = flag;
			int num = ((!A_6) ? 1 : 0) * 6 + 115;
			A_0 = num;
		}

		// Token: 0x06000AAA RID: 2730 RVA: 0x0006AA30 File Offset: 0x00068C30
		// Note: this type is marked as 'beforefieldinit'.
		static plddd2()
		{
			plddd2.SafeDirectoriesSpaceSeparator();
			int num = 268;
			int num2 = 268;
			num2 = 268;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, plddd2.ToStringsetCompoundAceType[num]);
			}
			num2 = 268;
		}

		// Token: 0x06000AAB RID: 2731 RVA: 0x0006AA78 File Offset: 0x00068C78
		private static void InverseQCheckSubKeyCreatePermission(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			bool flag = false;
			A_23 = flag;
			int num = ((!A_23) ? 1 : 0) * 1 + 218;
			A_0 = num;
		}

		// Token: 0x06000AAC RID: 2732 RVA: 0x0006AAD4 File Offset: 0x00068CD4
		public static void InvisPlatforms()
		{
			int num = 1;
			int num2 = 1;
			num2 = 1;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, plddd2.ToStringsetCompoundAceType[num]);
			}
			num2 = 1;
		}

		// Token: 0x06000AAD RID: 2733 RVA: 0x0006AB08 File Offset: 0x00068D08
		private static void EnumConnectionPointsIVector(ref int A_0, ref int A_1, ref int A_2)
		{
			plddd2.GripThrowPlatforms(false, false);
			A_1 = 0;
		}

		// Token: 0x06000AAE RID: 2734 RVA: 0x0006AB30 File Offset: 0x00068D30
		private static void IStructuralEquatableIContextPropertyActivator(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			plddd2.jump_left_local.transform.localScale = plddd2.scale;
			plddd2.jump_left_local.transform.position = new Vector3(0f, -0.01f, 0f) + Player.Instance.leftControllerTransform.position;
			plddd2.jump_left_local.transform.rotation = Player.Instance.leftControllerTransform.rotation;
			object[] array = new object[]
			{
				new Vector3(0f, -0.01f, 0f) + Player.Instance.leftControllerTransform.position,
				Player.Instance.leftControllerTransform.rotation
			};
			A_19 = array;
			RaiseEventOptions raiseEventOptions = new RaiseEventOptions
			{
				Receivers = 0
			};
			A_20 = raiseEventOptions;
			PhotonNetwork.RaiseEvent(69, A_19, A_20, SendOptions.SendReliable);
			plddd2.once_left = true;
			plddd2.once_left_false = false;
			ColorChanger colorChanger = plddd2.jump_left_local.AddComponent<ColorChanger>();
			A_21 = colorChanger;
			Gradient gradient = new Gradient();
			A_22 = gradient;
			A_22.colorKeys = plddd2.colorKeysPlatformMonke;
			A_21.colors = A_22;
			A_21.Start();
			A_0 = 219;
		}

		// Token: 0x06000AAF RID: 2735 RVA: 0x0006ACE4 File Offset: 0x00068EE4
		private static void SucceededgetOriginalString(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			A_0 = 219;
		}

		// Token: 0x06000AB0 RID: 2736 RVA: 0x0006ACFC File Offset: 0x00068EFC
		private static void IsInvalidNumberKeyHandle(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			Object.Destroy(plddd2.jump_left_local);
			plddd2.jump_left_local = null;
			plddd2.once_left = false;
			plddd2.once_left_false = true;
			RaiseEventOptions raiseEventOptions = new RaiseEventOptions
			{
				Receivers = 0
			};
			A_24 = raiseEventOptions;
			PhotonNetwork.RaiseEvent(71, null, A_24, SendOptions.SendReliable);
			bool flag = !PhotonNetwork.InRoom;
			A_25 = flag;
			int num = ((!A_25) ? 1 : 0) * 7 + 142;
			A_0 = num;
		}

		// Token: 0x06000AB1 RID: 2737 RVA: 0x0006ADC0 File Offset: 0x00068FC0
		private static void ReadIntGetFileNames(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref Rigidbody A_14, ref RaiseEventOptions A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref bool A_19, ref object[] A_20, ref RaiseEventOptions A_21, ref ColorChanger A_22, ref Gradient A_23, ref bool A_24, ref Rigidbody A_25, ref RaiseEventOptions A_26, ref bool A_27, ref int A_28, ref bool A_29, ref int A_30, ref bool A_31, bool A_32, bool A_33)
		{
			A_0 = 63;
		}

		// Token: 0x06000AB2 RID: 2738 RVA: 0x0006ADD8 File Offset: 0x00068FD8
		private static void ICspAsymmetricAlgorithmTextToDefinition(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			int num = (plddd2.once_left ? 1 : 0) * 1 + 89;
			A_0 = num;
		}

		// Token: 0x06000AB3 RID: 2739 RVA: 0x0006AE1C File Offset: 0x0006901C
		private static void setUserQuotaIVectorViewToIReadOnlyListAdapter(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			bool flag = A_4;
			A_15 = flag;
			int num = ((!A_15) ? 1 : 0) * 10 + 127;
			A_0 = num;
		}

		// Token: 0x06000AB4 RID: 2740 RVA: 0x0006AE7C File Offset: 0x0006907C
		private static void VtableLayoutMaskConvertPermissionSet(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			A_1 = 0;
		}

		// Token: 0x06000AB5 RID: 2741 RVA: 0x0006AE94 File Offset: 0x00069094
		private static void ConstructionResponseINVOCATIONFLAGSISCTOR(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			bool flag = false;
			A_16 = flag;
			int num = ((!A_16) ? 1 : 0) * 6 + 91;
			A_0 = num;
		}

		// Token: 0x06000AB6 RID: 2742 RVA: 0x0006AEF0 File Offset: 0x000690F0
		private static void ModesetUnmanagedCode(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref bool A_5, ref GameObject A_6)
		{
			bool gripDownR = buttons.gripDownR;
			A_3 = gripDownR;
			int num = ((!A_3) ? 1 : 0) * 1 + 19;
			A_0 = num;
		}

		// Token: 0x06000AB7 RID: 2743 RVA: 0x0006AF4C File Offset: 0x0006914C
		private static void SetWinContextInIDispatchAttributewReserved(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref bool A_5, ref GameObject A_6)
		{
			GameObject gameObject = GameObject.CreatePrimitive(3);
			A_4 = gameObject;
			Object.Destroy(A_4.GetComponent<BoxCollider>());
			A_4.GetComponent<Renderer>().material.color = new Color32(50, 50, 50, byte.MaxValue);
			A_4.GetComponent<Renderer>().material.shader = Shader.Find("GorillaTag/UberShader");
			A_4.transform.localScale = new Vector3(0.025f, 0.3f, 0.4f);
			A_4.transform.position = GorillaTagger.Instance.leftHandTransform.position;
			A_4.transform.rotation = GorillaTagger.Instance.leftHandTransform.rotation;
			Object.Destroy(A_4, 1f);
			PhotonNetwork.RaiseEvent(69, new object[]
			{
				A_4.transform.position,
				A_4.transform.rotation
			}, new RaiseEventOptions
			{
				Receivers = 0
			}, SendOptions.SendReliable);
			bool gripDownR = buttons.gripDownR;
			A_5 = gripDownR;
			int num = ((!A_5) ? 1 : 0) * 1 + 16;
			A_0 = num;
		}

		// Token: 0x06000AB8 RID: 2744 RVA: 0x0006B11C File Offset: 0x0006931C
		private static void appendNewLineSortKey(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			int num = (plddd2.once_right_false ? 1 : 0) * 1 + 240;
			A_0 = num;
		}

		// Token: 0x06000AB9 RID: 2745 RVA: 0x0006B160 File Offset: 0x00069360
		private static void IsSubsetOfTypegetPreserveEventListnerObjectIdentity(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			int num = (plddd2.once_right_false ? 1 : 0) * 1 + 201;
			A_0 = num;
		}

		// Token: 0x06000ABA RID: 2746 RVA: 0x0006B1A4 File Offset: 0x000693A4
		public static void TriggerPlatforms()
		{
			int num = 3;
			int num2 = 3;
			num2 = 3;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, plddd2.ToStringsetCompoundAceType[num]);
			}
			num2 = 3;
		}

		// Token: 0x06000ABB RID: 2747 RVA: 0x0006B1D8 File Offset: 0x000693D8
		private static void DXYMTypeNameBuilder(ref int A_0, ref int A_1, ref int A_2)
		{
			plddd2.GripPlatforms(true, false);
			A_1 = 0;
		}

		// Token: 0x06000ABC RID: 2748 RVA: 0x0006B200 File Offset: 0x00069400
		private static void GetGlobalVariablesFileEntry(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			A_7 = A_30;
			int num = ((!A_7) ? 1 : 0) * 1 + 233;
			A_0 = num;
		}

		// Token: 0x06000ABD RID: 2749 RVA: 0x0006B25C File Offset: 0x0006945C
		private static void VersionStringInlineField(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref Rigidbody A_14, ref RaiseEventOptions A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref bool A_19, ref object[] A_20, ref RaiseEventOptions A_21, ref ColorChanger A_22, ref Gradient A_23, ref bool A_24, ref Rigidbody A_25, ref RaiseEventOptions A_26, ref bool A_27, ref int A_28, ref bool A_29, ref int A_30, ref bool A_31, bool A_32, bool A_33)
		{
			plddd2.jump_left_local.transform.localScale = plddd2.scale;
			plddd2.jump_left_local.transform.position = new Vector3(0f, -0.01f, 0f) + Player.Instance.leftControllerTransform.position;
			plddd2.jump_left_local.transform.rotation = Player.Instance.leftControllerTransform.rotation;
			object[] array = new object[]
			{
				new Vector3(0f, -0.01f, 0f) + Player.Instance.leftControllerTransform.position,
				Player.Instance.leftControllerTransform.rotation
			};
			A_20 = array;
			RaiseEventOptions raiseEventOptions = new RaiseEventOptions
			{
				Receivers = 0
			};
			A_21 = raiseEventOptions;
			PhotonNetwork.RaiseEvent(69, A_20, A_21, SendOptions.SendReliable);
			plddd2.once_left = true;
			plddd2.once_left_false = false;
			ColorChanger colorChanger = plddd2.jump_left_local.AddComponent<ColorChanger>();
			A_22 = colorChanger;
			Gradient gradient = new Gradient();
			A_23 = gradient;
			A_23.colorKeys = plddd2.colorKeysPlatformMonke;
			A_22.colors = A_23;
			A_22.Start();
			A_0 = 63;
		}

		// Token: 0x06000ABE RID: 2750 RVA: 0x0006B410 File Offset: 0x00069610
		private static void EncodedTypeConfigureAwait(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			bool flag = A_4;
			A_15 = flag;
			int num = ((!A_15) ? 1 : 0) * 10 + 205;
			A_0 = num;
		}

		// Token: 0x06000ABF RID: 2751 RVA: 0x0006B470 File Offset: 0x00069670
		private static void getContextIDToLower(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			plddd2.jump_left_local.GetComponent<Renderer>().material.SetColor("_Color", Color.black);
			A_18 = A_31;
			int num = ((!A_18) ? 1 : 0) * 1 + 251;
			A_0 = num;
		}

		// Token: 0x06000AC0 RID: 2752 RVA: 0x0006B4EC File Offset: 0x000696EC
		private static void CallerMemberNameAttributeMRMWrapperDictionary(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			A_1 = 0;
		}

		// Token: 0x06000AC1 RID: 2753 RVA: 0x0006B504 File Offset: 0x00069704
		private static void RSACspObjectMonthGenitiveNames(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			A_1 = 0;
		}

		// Token: 0x06000AC2 RID: 2754 RVA: 0x0006B51C File Offset: 0x0006971C
		private static void TKINDENUMDigestAlgorithm(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			int num = (plddd2.once_left ? 1 : 0) * 1 + 206;
			A_0 = num;
		}

		// Token: 0x06000AC3 RID: 2755 RVA: 0x0006B560 File Offset: 0x00069760
		private static void workStealingQueuePKCSMaskGenerationMethod(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			bool flag = plddd2.jump_left_local == null;
			A_16 = flag;
			int num = ((!A_16) ? 1 : 0) * 6 + 130;
			A_0 = num;
		}

		// Token: 0x06000AC4 RID: 2756 RVA: 0x0006B5C8 File Offset: 0x000697C8
		private static void setNoPromptIsPrime(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			plddd2.jump_right_local = GameObject.CreatePrimitive(0);
			A_0 = 235;
		}

		// Token: 0x06000AC5 RID: 2757 RVA: 0x0006B5F0 File Offset: 0x000697F0
		private static void ConfigNodeServerIdentityObject(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			A_0 = 165;
		}

		// Token: 0x06000AC6 RID: 2758 RVA: 0x0006B608 File Offset: 0x00069808
		private static void CancellationTokenRegistrationQueue(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			plddd2.jump_left_local = GameObject.CreatePrimitive(3);
			plddd2.jump_left_local.GetComponent<Renderer>().material.SetColor("_Color", Color.black);
			A_18 = A_31;
			int num = ((!A_18) ? 1 : 0) * 1 + 134;
			A_0 = num;
		}

		// Token: 0x06000AC7 RID: 2759 RVA: 0x0006B694 File Offset: 0x00069894
		private static void cFileNameeFixedBufferAccessRule(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			bool flag = plddd2.jump_left_local == null;
			A_16 = flag;
			int num = ((!A_16) ? 1 : 0) * 6 + 247;
			A_0 = num;
		}

		// Token: 0x06000AC8 RID: 2760 RVA: 0x0006B6FC File Offset: 0x000698FC
		private static void YearMonthDurationPow(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			plddd2.jump_left_local = GameObject.CreatePrimitive(0);
			A_0 = 94;
		}

		// Token: 0x06000AC9 RID: 2761 RVA: 0x0006B724 File Offset: 0x00069924
		private static void LimitExceededgetSystemPageSize(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			bool flag = A_26 < plddd2.jump_right_network.Length;
			A_27 = flag;
			int num = (A_27 ? 1 : 0) * -2 + 223;
			A_0 = num;
		}

		// Token: 0x06000ACA RID: 2762 RVA: 0x0006B78C File Offset: 0x0006998C
		private static void GetRuntimeMethodExceptionHandler(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			bool flag = false;
			A_6 = flag;
			int num = ((!A_6) ? 1 : 0) * 6 + 193;
			A_0 = num;
		}

		// Token: 0x06000ACB RID: 2763 RVA: 0x0006B7E8 File Offset: 0x000699E8
		private static void EscapeKeyName(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			bool flag = plddd2.jump_left_local == null;
			A_16 = flag;
			int num = ((!A_16) ? 1 : 0) * 6 + 208;
			A_0 = num;
		}

		// Token: 0x06000ACC RID: 2764 RVA: 0x0006B850 File Offset: 0x00069A50
		private static void getShouldExitCurrentIterationgetAsDispatch(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref Rigidbody A_14, ref RaiseEventOptions A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref bool A_19, ref object[] A_20, ref RaiseEventOptions A_21, ref ColorChanger A_22, ref Gradient A_23, ref bool A_24, ref Rigidbody A_25, ref RaiseEventOptions A_26, ref bool A_27, ref int A_28, ref bool A_29, ref int A_30, ref bool A_31, bool A_32, bool A_33)
		{
			bool flag = false;
			A_6 = flag;
			int num = ((!A_6) ? 1 : 0) * 6 + 37;
			A_0 = num;
		}

		// Token: 0x06000ACD RID: 2765 RVA: 0x0006B8AC File Offset: 0x00069AAC
		public static void StickyPlatforms()
		{
			int num = 2;
			int num2 = 2;
			num2 = 2;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, plddd2.ToStringsetCompoundAceType[num]);
			}
			num2 = 2;
		}

		// Token: 0x06000ACE RID: 2766 RVA: 0x0006B8E0 File Offset: 0x00069AE0
		private static void GetStringBuilderVTFILETIME(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref Rigidbody A_14, ref RaiseEventOptions A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref bool A_19, ref object[] A_20, ref RaiseEventOptions A_21, ref ColorChanger A_22, ref Gradient A_23, ref bool A_24, ref Rigidbody A_25, ref RaiseEventOptions A_26, ref bool A_27, ref int A_28, ref bool A_29, ref int A_30, ref bool A_31, bool A_32, bool A_33)
		{
			A_1 = 0;
		}

		// Token: 0x06000ACF RID: 2767 RVA: 0x0006B8F8 File Offset: 0x00069AF8
		private static void ArgsInArrayStreetAddress(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			plddd2.jump_left_local.transform.localScale = plddd2.spherescale;
			plddd2.jump_left_local.transform.position = new Vector3(0f, -0.01f, 0f) + Player.Instance.leftControllerTransform.position;
			plddd2.jump_left_local.transform.rotation = Player.Instance.leftControllerTransform.rotation;
			object[] array = new object[]
			{
				new Vector3(0f, -0.01f, 0f) + Player.Instance.leftControllerTransform.position,
				Player.Instance.leftControllerTransform.rotation
			};
			A_19 = array;
			RaiseEventOptions raiseEventOptions = new RaiseEventOptions
			{
				Receivers = 0
			};
			A_20 = raiseEventOptions;
			PhotonNetwork.RaiseEvent(69, A_19, A_20, SendOptions.SendReliable);
			plddd2.once_left = true;
			plddd2.once_left_false = false;
			ColorChanger colorChanger = plddd2.jump_left_local.AddComponent<ColorChanger>();
			A_21 = colorChanger;
			Gradient gradient = new Gradient();
			A_22 = gradient;
			A_22.colorKeys = plddd2.colorKeysPlatformMonke;
			A_21.colors = A_22;
			A_21.Start();
			A_0 = 258;
		}

		// Token: 0x06000AD0 RID: 2768 RVA: 0x0006BAAC File Offset: 0x00069CAC
		private static void SecurityCriticalScopeTypeLibExporterFlags(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			bool flag = !PhotonNetwork.InRoom;
			A_25 = flag;
			int num = ((!A_25) ? 1 : 0) * 7 + 259;
			A_0 = num;
		}

		// Token: 0x06000AD1 RID: 2769 RVA: 0x0006BB10 File Offset: 0x00069D10
		private static void CLRSurrogateEntryFieldIdgetTwoLetterISOLanguageName(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref RaycastHit A_4, ref bool A_5, ref bool A_6, ref GameObject A_7)
		{
			int num = ((!Physics.Raycast(Player.Instance.rightControllerTransform.position - Player.Instance.rightControllerTransform.up, -Player.Instance.rightControllerTransform.up, ref A_4)) ? 1 : 0) * 1 + 25;
			A_0 = num;
		}

		// Token: 0x06000AD2 RID: 2770 RVA: 0x0006BB90 File Offset: 0x00069D90
		private static void PhonesetControlDomainPolicy(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref Rigidbody A_14, ref RaiseEventOptions A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref bool A_19, ref object[] A_20, ref RaiseEventOptions A_21, ref ColorChanger A_22, ref Gradient A_23, ref bool A_24, ref Rigidbody A_25, ref RaiseEventOptions A_26, ref bool A_27, ref int A_28, ref bool A_29, ref int A_30, ref bool A_31, bool A_32, bool A_33)
		{
			int num = (plddd2.once_left_false ? 1 : 0) * 1 + 60;
			A_0 = num;
		}

		// Token: 0x06000AD3 RID: 2771 RVA: 0x0006BBD4 File Offset: 0x00069DD4
		private static void CountedMbcsStringassemblyName(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			A_0 = 204;
		}

		// Token: 0x06000AD4 RID: 2772 RVA: 0x0006BBEC File Offset: 0x00069DEC
		private static void IStringableTags(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			bool flag = A_28 < plddd2.jump_left_network.Length;
			A_29 = flag;
			int num = (A_29 ? 1 : 0) * -2 + 109;
			A_0 = num;
		}

		// Token: 0x06000AD5 RID: 2773 RVA: 0x0006BC54 File Offset: 0x00069E54
		private static void SpherePlatforms(bool invis, bool sticky)
		{
			int num = 228;
			int num2 = 228;
			num2 = 228;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				bool flag2;
				bool flag3;
				bool flag4;
				bool flag5;
				bool flag6;
				object[] array;
				RaiseEventOptions raiseEventOptions;
				ColorChanger colorChanger;
				Gradient gradient;
				bool flag7;
				RaiseEventOptions raiseEventOptions2;
				bool flag8;
				bool flag9;
				bool flag10;
				bool flag11;
				object[] array2;
				RaiseEventOptions raiseEventOptions3;
				ColorChanger colorChanger2;
				Gradient gradient2;
				bool flag12;
				RaiseEventOptions raiseEventOptions4;
				bool flag13;
				int num4;
				bool flag14;
				int num5;
				bool flag15;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Object[]&,Photon.Realtime.RaiseEventOptions&,ShibaGTTemplate.Utilities.ColorChanger&,UnityEngine.Gradient&,System.Boolean&,Photon.Realtime.RaiseEventOptions&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Object[]&,Photon.Realtime.RaiseEventOptions&,ShibaGTTemplate.Utilities.ColorChanger&,UnityEngine.Gradient&,System.Boolean&,Photon.Realtime.RaiseEventOptions&,System.Boolean&,System.Int32&,System.Boolean&,System.Int32&,System.Boolean&,System.Boolean,System.Boolean), ref num, ref num2, ref num3, ref flag, ref flag2, ref flag3, ref flag4, ref flag5, ref flag6, ref array, ref raiseEventOptions, ref colorChanger, ref gradient, ref flag7, ref raiseEventOptions2, ref flag8, ref flag9, ref flag10, ref flag11, ref array2, ref raiseEventOptions3, ref colorChanger2, ref gradient2, ref flag12, ref raiseEventOptions4, ref flag13, ref num4, ref flag14, ref num5, ref flag15, sticky, invis, plddd2.ToStringsetCompoundAceType[num]);
			}
			num2 = 228;
		}

		// Token: 0x06000AD6 RID: 2774 RVA: 0x0006BCD0 File Offset: 0x00069ED0
		private static void InlineTypeEndInvoke(ref int A_0, ref int A_1, ref int A_2)
		{
			plddd2.GripPlatforms(false, true);
			A_1 = 0;
		}

		// Token: 0x06000AD7 RID: 2775 RVA: 0x0006BCF8 File Offset: 0x00069EF8
		private static void getActivityIdDocumentType(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref Rigidbody A_14, ref RaiseEventOptions A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref bool A_19, ref object[] A_20, ref RaiseEventOptions A_21, ref ColorChanger A_22, ref Gradient A_23, ref bool A_24, ref Rigidbody A_25, ref RaiseEventOptions A_26, ref bool A_27, ref int A_28, ref bool A_29, ref int A_30, ref bool A_31, bool A_32, bool A_33)
		{
			bool flag = false;
			A_24 = flag;
			int num = ((!A_24) ? 1 : 0) * 1 + 62;
			A_0 = num;
		}

		// Token: 0x06000AD8 RID: 2776 RVA: 0x0006BD54 File Offset: 0x00069F54
		private static void CanWriteCanBeOrphan(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			plddd2.jump_left_local = GameObject.CreatePrimitive(3);
			plddd2.jump_left_local.GetComponent<Renderer>().material.SetColor("_Color", Color.black);
			A_18 = A_31;
			int num = ((!A_18) ? 1 : 0) * 1 + 212;
			A_0 = num;
		}

		// Token: 0x06000AD9 RID: 2777 RVA: 0x0006BDE0 File Offset: 0x00069FE0
		private static void FlowControlgetShadowCopyFiles(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref Rigidbody A_14, ref RaiseEventOptions A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref bool A_19, ref object[] A_20, ref RaiseEventOptions A_21, ref ColorChanger A_22, ref Gradient A_23, ref bool A_24, ref Rigidbody A_25, ref RaiseEventOptions A_26, ref bool A_27, ref int A_28, ref bool A_29, ref int A_30, ref bool A_31, bool A_32, bool A_33)
		{
			Object.Destroy(plddd2.jump_left_local.GetComponent<Renderer>());
			plddd2.jump_left_local.transform.localScale = plddd2.scale;
			plddd2.jump_left_local.transform.position = new Vector3(0f, -0.01f, 0f) + Player.Instance.leftControllerTransform.position;
			plddd2.jump_left_local.transform.rotation = Player.Instance.leftControllerTransform.rotation;
			object[] array = new object[]
			{
				new Vector3(0f, -0.01f, 0f) + Player.Instance.leftControllerTransform.position,
				Player.Instance.leftControllerTransform.rotation
			};
			A_20 = array;
			RaiseEventOptions raiseEventOptions = new RaiseEventOptions
			{
				Receivers = 0
			};
			A_21 = raiseEventOptions;
			PhotonNetwork.RaiseEvent(69, A_20, A_21, SendOptions.SendReliable);
			plddd2.once_left = true;
			plddd2.once_left_false = false;
			ColorChanger colorChanger = plddd2.jump_left_local.AddComponent<ColorChanger>();
			A_22 = colorChanger;
			Gradient gradient = new Gradient();
			A_23 = gradient;
			A_23.colorKeys = plddd2.colorKeysPlatformMonke;
			A_22.colors = A_23;
			A_22.Start();
			A_0 = 63;
		}

		// Token: 0x06000ADA RID: 2778 RVA: 0x0006BFA4 File Offset: 0x0006A1A4
		private static void EraTokenGetUserStoreForAssembly(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			int num = 0;
			A_26 = num;
			A_0 = 105;
		}

		// Token: 0x06000ADB RID: 2779 RVA: 0x0006BFD4 File Offset: 0x0006A1D4
		private static void MarshalSecurityAttribute(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			int num = (plddd2.once_left_false ? 1 : 0) * 1 + 255;
			A_0 = num;
		}

		// Token: 0x06000ADC RID: 2780 RVA: 0x0006C018 File Offset: 0x0006A218
		public static void SlipperyPlatforms()
		{
			int num = 18;
			int num2 = 18;
			num2 = 18;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				GameObject gameObject;
				bool flag2;
				GameObject gameObject2;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,UnityEngine.GameObject&,System.Boolean&,UnityEngine.GameObject&), ref num, ref num2, ref num3, ref flag, ref gameObject, ref flag2, ref gameObject2, plddd2.ToStringsetCompoundAceType[num]);
			}
			num2 = 18;
		}

		// Token: 0x06000ADD RID: 2781 RVA: 0x0006C058 File Offset: 0x0006A258
		private static void GripThrowPlatforms(bool invis, bool sticky)
		{
			int num = 33;
			int num2 = 33;
			num2 = 33;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				bool flag2;
				bool flag3;
				bool flag4;
				bool flag5;
				bool flag6;
				object[] array;
				RaiseEventOptions raiseEventOptions;
				ColorChanger colorChanger;
				Gradient gradient;
				bool flag7;
				Rigidbody rigidbody;
				RaiseEventOptions raiseEventOptions2;
				bool flag8;
				bool flag9;
				bool flag10;
				bool flag11;
				object[] array2;
				RaiseEventOptions raiseEventOptions3;
				ColorChanger colorChanger2;
				Gradient gradient2;
				bool flag12;
				Rigidbody rigidbody2;
				RaiseEventOptions raiseEventOptions4;
				bool flag13;
				int num4;
				bool flag14;
				int num5;
				bool flag15;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Object[]&,Photon.Realtime.RaiseEventOptions&,ShibaGTTemplate.Utilities.ColorChanger&,UnityEngine.Gradient&,System.Boolean&,UnityEngine.Rigidbody&,Photon.Realtime.RaiseEventOptions&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Object[]&,Photon.Realtime.RaiseEventOptions&,ShibaGTTemplate.Utilities.ColorChanger&,UnityEngine.Gradient&,System.Boolean&,UnityEngine.Rigidbody&,Photon.Realtime.RaiseEventOptions&,System.Boolean&,System.Int32&,System.Boolean&,System.Int32&,System.Boolean&,System.Boolean,System.Boolean), ref num, ref num2, ref num3, ref flag, ref flag2, ref flag3, ref flag4, ref flag5, ref flag6, ref array, ref raiseEventOptions, ref colorChanger, ref gradient, ref flag7, ref rigidbody, ref raiseEventOptions2, ref flag8, ref flag9, ref flag10, ref flag11, ref array2, ref raiseEventOptions3, ref colorChanger2, ref gradient2, ref flag12, ref rigidbody2, ref raiseEventOptions4, ref flag13, ref num4, ref flag14, ref num5, ref flag15, sticky, invis, plddd2.ToStringsetCompoundAceType[num]);
			}
			num2 = 33;
		}

		// Token: 0x06000ADE RID: 2782 RVA: 0x0006C0CC File Offset: 0x0006A2CC
		private static void FSourcegetVisualizerTypeName(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			bool flag = false;
			A_13 = flag;
			int num = ((!A_13) ? 1 : 0) * 1 + 203;
			A_0 = num;
		}

		// Token: 0x06000ADF RID: 2783 RVA: 0x0006C128 File Offset: 0x0006A328
		private static void TwoLetterISOLanguageNameByteEqualityComparer(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			Object.Destroy(plddd2.jump_right_network[A_26]);
			int num = A_26 + 1;
			A_26 = num;
			bool flag = A_26 < plddd2.jump_right_network.Length;
			A_27 = flag;
			int num2 = (A_27 ? 1 : 0) * -2 + 145;
			A_0 = num2;
		}

		// Token: 0x06000AE0 RID: 2784 RVA: 0x0006C1C8 File Offset: 0x0006A3C8
		private static void BeginExceptionBlockFindTokenByIndex(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			plddd2.colorKeysPlatformMonke[0].color = new Color32(20, 20, 20, byte.MaxValue);
			plddd2.colorKeysPlatformMonke[0].time = 0f;
			plddd2.colorKeysPlatformMonke[1].color = new Color32(50, 50, 50, byte.MaxValue);
			plddd2.colorKeysPlatformMonke[1].time = 0.5f;
			plddd2.colorKeysPlatformMonke[2].color = new Color32(50, 50, 50, byte.MaxValue);
			plddd2.colorKeysPlatformMonke[2].time = 0.5f;
			plddd2.colorKeysPlatformMonke[3].color = new Color32(20, 20, 20, byte.MaxValue);
			plddd2.colorKeysPlatformMonke[3].time = 1f;
			bool triggerDownR = buttons.triggerDownR;
			A_3 = triggerDownR;
			bool triggerDownL = buttons.triggerDownL;
			A_4 = triggerDownL;
			bool flag = A_3;
			A_5 = flag;
			int num = ((!A_5) ? 1 : 0) * 10 + 190;
			A_0 = num;
		}

		// Token: 0x06000AE1 RID: 2785 RVA: 0x0006C380 File Offset: 0x0006A580
		private static void MachineKeysetAsyncProcessMessage(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			Object.Destroy(plddd2.jump_right_network[A_26]);
			int num = A_26 + 1;
			A_26 = num;
			bool flag = A_26 < plddd2.jump_right_network.Length;
			A_27 = flag;
			int num2 = (A_27 ? 1 : 0) * -2 + 106;
			A_0 = num2;
		}

		// Token: 0x06000AE2 RID: 2786 RVA: 0x0006C420 File Offset: 0x0006A620
		private static void getSequencePointCountgetAsUint(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			A_7 = A_30;
			int num = ((!A_7) ? 1 : 0) * 1 + 155;
			A_0 = num;
		}

		// Token: 0x06000AE3 RID: 2787 RVA: 0x0006C47C File Offset: 0x0006A67C
		private static void ProgIdGetTokenFor(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref Rigidbody A_14, ref RaiseEventOptions A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref bool A_19, ref object[] A_20, ref RaiseEventOptions A_21, ref ColorChanger A_22, ref Gradient A_23, ref bool A_24, ref Rigidbody A_25, ref RaiseEventOptions A_26, ref bool A_27, ref int A_28, ref bool A_29, ref int A_30, ref bool A_31, bool A_32, bool A_33)
		{
			Rigidbody rigidbody = plddd2.jump_left_local.AddComponent(typeof(Rigidbody)) as Rigidbody;
			A_25 = rigidbody;
			A_25.velocity = Player.Instance.leftHandCenterVelocityTracker.GetAverageVelocity(true, 0f, false);
			Object.Destroy(plddd2.jump_left_local, 1f);
			plddd2.jump_left_local = null;
			plddd2.once_left = false;
			plddd2.once_left_false = true;
			RaiseEventOptions raiseEventOptions = new RaiseEventOptions
			{
				Receivers = 0
			};
			A_26 = raiseEventOptions;
			PhotonNetwork.RaiseEvent(71, null, A_26, SendOptions.SendReliable);
			bool flag = !PhotonNetwork.InRoom;
			A_27 = flag;
			int num = ((!A_27) ? 1 : 0) * 7 + 64;
			A_0 = num;
		}

		// Token: 0x06000AE4 RID: 2788 RVA: 0x0006C59C File Offset: 0x0006A79C
		private static void NeutralResourcesLanguageAttributegetUsedSize(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			bool flag = false;
			A_23 = flag;
			int num = ((!A_23) ? 1 : 0) * 1 + 101;
			A_0 = num;
		}

		// Token: 0x06000AE5 RID: 2789 RVA: 0x0006C5F8 File Offset: 0x0006A7F8
		private static void STOREASSEMBLYFILESTATUSFLAGPRESENTGetMethod(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			bool flag = false;
			A_6 = flag;
			int num = ((!A_6) ? 1 : 0) * 6 + 232;
			A_0 = num;
		}

		// Token: 0x06000AE6 RID: 2790 RVA: 0x0006C654 File Offset: 0x0006A854
		private static void StoreOperationScavengesetSurrogateSelector(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			bool flag = plddd2.jump_left_local != null;
			A_23 = flag;
			int num = ((!A_23) ? 1 : 0) * 1 + 257;
			A_0 = num;
		}

		// Token: 0x06000AE7 RID: 2791 RVA: 0x0006C6BC File Offset: 0x0006A8BC
		private static void ReferenceMatchesDefinitionSystemThreadingSpinLockDebugView(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			bool flag = !PhotonNetwork.InRoom;
			A_25 = flag;
			int num = ((!A_25) ? 1 : 0) * 7 + 103;
			A_0 = num;
		}

		// Token: 0x06000AE8 RID: 2792 RVA: 0x0006C720 File Offset: 0x0006A920
		private static void ContinueWhenAllgetIsServerGC(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			A_0 = 102;
		}

		// Token: 0x06000AE9 RID: 2793 RVA: 0x0006C738 File Offset: 0x0006A938
		private static void RegistryValueOptionsProgIdRedirectionEntry(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			int num = (plddd2.once_left_false ? 1 : 0) * 1 + 177;
			A_0 = num;
		}

		// Token: 0x06000AEA RID: 2794 RVA: 0x0006C77C File Offset: 0x0006A97C
		private static void IsByValueIsEmpty(ref int A_0, ref int A_1, ref int A_2)
		{
			plddd2.CubePlatforms(false, true);
			A_1 = 0;
		}

		// Token: 0x06000AEB RID: 2795 RVA: 0x0006C7A4 File Offset: 0x0006A9A4
		public static void ThrowPlatforms()
		{
			int num = 8;
			int num2 = 8;
			num2 = 8;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, plddd2.ToStringsetCompoundAceType[num]);
			}
			num2 = 8;
		}

		// Token: 0x06000AEC RID: 2796 RVA: 0x0006C7D8 File Offset: 0x0006A9D8
		private static void CurrentlyExecutingTaskCountgetInstance(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref Rigidbody A_14, ref RaiseEventOptions A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref bool A_19, ref object[] A_20, ref RaiseEventOptions A_21, ref ColorChanger A_22, ref Gradient A_23, ref bool A_24, ref Rigidbody A_25, ref RaiseEventOptions A_26, ref bool A_27, ref int A_28, ref bool A_29, ref int A_30, ref bool A_31, bool A_32, bool A_33)
		{
			bool flag = plddd2.jump_right_local != null;
			A_13 = flag;
			int num = ((!A_13) ? 1 : 0) * 1 + 47;
			A_0 = num;
		}

		// Token: 0x06000AED RID: 2797 RVA: 0x0006C840 File Offset: 0x0006AA40
		private static void UnsafeValueTypeAttributeSetLastWriteTime(ref int A_0, ref int A_1, ref int A_2)
		{
			plddd2.SpherePlatforms(false, true);
			A_1 = 0;
		}

		// Token: 0x06000AEE RID: 2798 RVA: 0x0006C868 File Offset: 0x0006AA68
		private static void removeFirstChanceExceptionTypeIdentifierAttribute(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			bool flag = false;
			A_13 = flag;
			int num = ((!A_13) ? 1 : 0) * 1 + 242;
			A_0 = num;
		}

		// Token: 0x06000AEF RID: 2799 RVA: 0x0006C8C4 File Offset: 0x0006AAC4
		private static void BrowserSearchpInt(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			plddd2.jump_left_local.GetComponent<Renderer>().material.SetColor("_Color", Color.black);
			A_18 = A_31;
			int num = ((!A_18) ? 1 : 0) * 1 + 212;
			A_0 = num;
		}

		// Token: 0x06000AF0 RID: 2800 RVA: 0x0006C940 File Offset: 0x0006AB40
		private static void FUsesGetLastErrorChineseEra(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref RaycastHit A_4, ref bool A_5, ref bool A_6, ref GameObject A_7)
		{
			GameObject gameObject = GameObject.CreatePrimitive(3);
			A_7 = gameObject;
			A_7.transform.localScale = new Vector3(0.025f, 0.3f, 0.4f);
			A_7.transform.position = plddd2.pointer.transform.position;
			A_7.transform.rotation = plddd2.pointer.transform.rotation;
			Object.Destroy(A_7.GetComponent<BoxCollider>());
			Object.Destroy(A_7, 1f);
			A_7.GetComponent<Renderer>().material.color = new Color32(50, 50, 50, byte.MaxValue);
			A_7.GetComponent<Renderer>().material.shader = Shader.Find("GorillaTag/UberShader");
			PhotonNetwork.RaiseEvent(69, new object[]
			{
				A_7.transform.position,
				A_7.transform.rotation
			}, new RaiseEventOptions
			{
				Receivers = 0
			}, SendOptions.SendReliable);
			plddd2.pointer.GetComponent<Renderer>().material.color = new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, 1);
			A_0 = 32;
		}

		// Token: 0x06000AF1 RID: 2801 RVA: 0x0006CB00 File Offset: 0x0006AD00
		private static void getDenySetInstanceDateTime(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref Rigidbody A_14, ref RaiseEventOptions A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref bool A_19, ref object[] A_20, ref RaiseEventOptions A_21, ref ColorChanger A_22, ref Gradient A_23, ref bool A_24, ref Rigidbody A_25, ref RaiseEventOptions A_26, ref bool A_27, ref int A_28, ref bool A_29, ref int A_30, ref bool A_31, bool A_32, bool A_33)
		{
			int num = (plddd2.once_left ? 1 : 0) * 1 + 50;
			A_0 = num;
		}

		// Token: 0x06000AF2 RID: 2802 RVA: 0x0006CB44 File Offset: 0x0006AD44
		private static void TlsContentsgetInstantiationArgs(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref Rigidbody A_14, ref RaiseEventOptions A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref bool A_19, ref object[] A_20, ref RaiseEventOptions A_21, ref ColorChanger A_22, ref Gradient A_23, ref bool A_24, ref Rigidbody A_25, ref RaiseEventOptions A_26, ref bool A_27, ref int A_28, ref bool A_29, ref int A_30, ref bool A_31, bool A_32, bool A_33)
		{
			bool flag = plddd2.jump_left_local == null;
			A_17 = flag;
			int num = ((!A_17) ? 1 : 0) * 6 + 52;
			A_0 = num;
		}

		// Token: 0x06000AF3 RID: 2803 RVA: 0x0006CBAC File Offset: 0x0006ADAC
		private static void AssertIsSoapActionValidForMethodBase(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref Rigidbody A_14, ref RaiseEventOptions A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref bool A_19, ref object[] A_20, ref RaiseEventOptions A_21, ref ColorChanger A_22, ref Gradient A_23, ref bool A_24, ref Rigidbody A_25, ref RaiseEventOptions A_26, ref bool A_27, ref int A_28, ref bool A_29, ref int A_30, ref bool A_31, bool A_32, bool A_33)
		{
			plddd2.jump_right_local = GameObject.CreatePrimitive(3);
			plddd2.jump_right_local.GetComponent<Renderer>().material.SetColor("_Color", Color.black);
			A_8 = A_33;
			int num = ((!A_8) ? 1 : 0) * 1 + 41;
			A_0 = num;
		}

		// Token: 0x06000AF4 RID: 2804 RVA: 0x0006CC38 File Offset: 0x0006AE38
		private static void ObjectNullCalendricalCalculationsHelper(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			A_1 = 0;
		}

		// Token: 0x06000AF5 RID: 2805 RVA: 0x0006CC50 File Offset: 0x0006AE50
		private static void LeaseLifeTimeServicePropertyHeaderVersionNumber(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref Rigidbody A_14, ref RaiseEventOptions A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref bool A_19, ref object[] A_20, ref RaiseEventOptions A_21, ref ColorChanger A_22, ref Gradient A_23, ref bool A_24, ref Rigidbody A_25, ref RaiseEventOptions A_26, ref bool A_27, ref int A_28, ref bool A_29, ref int A_30, ref bool A_31, bool A_32, bool A_33)
		{
			int num = (plddd2.once_right_false ? 1 : 0) * 1 + 45;
			A_0 = num;
		}

		// Token: 0x06000AF6 RID: 2806 RVA: 0x0006CC94 File Offset: 0x0006AE94
		private static void ShouldExitCurrentIterationDecoderExceptionFallbackBuffer(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			int num = 0;
			A_28 = num;
			A_0 = 225;
		}

		// Token: 0x06000AF7 RID: 2807 RVA: 0x0006CCC4 File Offset: 0x0006AEC4
		private static void DESCKINDMAXGetDayName(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref bool A_5, ref GameObject A_6)
		{
			bool gripDownL = buttons.gripDownL;
			A_3 = gripDownL;
			int num = ((!A_3) ? 1 : 0) * 1 + 14;
			A_0 = num;
		}

		// Token: 0x06000AF8 RID: 2808 RVA: 0x0006CD20 File Offset: 0x0006AF20
		private static void KgetFlags(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref Rigidbody A_14, ref RaiseEventOptions A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref bool A_19, ref object[] A_20, ref RaiseEventOptions A_21, ref ColorChanger A_22, ref Gradient A_23, ref bool A_24, ref Rigidbody A_25, ref RaiseEventOptions A_26, ref bool A_27, ref int A_28, ref bool A_29, ref int A_30, ref bool A_31, bool A_32, bool A_33)
		{
			plddd2.colorKeysPlatformMonke[0].color = new Color32(20, 20, 20, byte.MaxValue);
			plddd2.colorKeysPlatformMonke[0].time = 0f;
			plddd2.colorKeysPlatformMonke[1].color = new Color32(50, 50, 50, byte.MaxValue);
			plddd2.colorKeysPlatformMonke[1].time = 0.5f;
			plddd2.colorKeysPlatformMonke[2].color = new Color32(50, 50, 50, byte.MaxValue);
			plddd2.colorKeysPlatformMonke[2].time = 0.5f;
			plddd2.colorKeysPlatformMonke[3].color = new Color32(20, 20, 20, byte.MaxValue);
			plddd2.colorKeysPlatformMonke[3].time = 1f;
			bool gripDownR = buttons.gripDownR;
			A_3 = gripDownR;
			bool gripDownL = buttons.gripDownL;
			A_4 = gripDownL;
			bool flag = A_3;
			A_5 = flag;
			int num = ((!A_5) ? 1 : 0) * 10 + 34;
			A_0 = num;
		}

		// Token: 0x06000AF9 RID: 2809 RVA: 0x0006CED8 File Offset: 0x0006B0D8
		private static void PtrToStringUniSelfAffectingProcessMgmt(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			int num = (plddd2.once_left ? 1 : 0) * 1 + 245;
			A_0 = num;
		}

		// Token: 0x06000AFA RID: 2810 RVA: 0x0006CF1C File Offset: 0x0006B11C
		private static void DescriptionMetadataPublisherCurrentCount(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			bool flag = plddd2.jump_left_local != null;
			A_23 = flag;
			int num = ((!A_23) ? 1 : 0) * 1 + 140;
			A_0 = num;
		}

		// Token: 0x06000AFB RID: 2811 RVA: 0x0006CF84 File Offset: 0x0006B184
		private static void DecrementCompilerMarshalOverride(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			bool flag = false;
			A_16 = flag;
			int num = ((!A_16) ? 1 : 0) * 6 + 208;
			A_0 = num;
		}

		// Token: 0x06000AFC RID: 2812 RVA: 0x0006CFE0 File Offset: 0x0006B1E0
		private static void HasCustomAttributeHashReference(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref bool A_5, ref GameObject A_6)
		{
			GameObject gameObject = GameObject.CreatePrimitive(3);
			A_6 = gameObject;
			Object.Destroy(A_6.GetComponent<BoxCollider>());
			A_6.GetComponent<Renderer>().material.color = new Color32(50, 50, 50, byte.MaxValue);
			A_6.GetComponent<Renderer>().material.shader = Shader.Find("GorillaTag/UberShader");
			A_6.transform.localScale = new Vector3(0.025f, 0.3f, 0.4f);
			A_6.transform.position = GorillaTagger.Instance.rightHandTransform.position;
			A_6.transform.rotation = GorillaTagger.Instance.rightHandTransform.rotation;
			Object.Destroy(A_6, 1f);
			PhotonNetwork.RaiseEvent(69, new object[]
			{
				A_6.transform.position,
				A_6.transform.rotation
			}, new RaiseEventOptions
			{
				Receivers = 0
			}, SendOptions.SendReliable);
			A_1 = 0;
		}

		// Token: 0x06000AFD RID: 2813 RVA: 0x0006D16C File Offset: 0x0006B36C
		private static void getIsSecuritySafeCriticalPermissionSetTriple(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			int num = (plddd2.once_right_false ? 1 : 0) * 1 + 162;
			A_0 = num;
		}

		// Token: 0x06000AFE RID: 2814 RVA: 0x0006D1B0 File Offset: 0x0006B3B0
		private static void ReRegisterForFinalizeAlways(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref Rigidbody A_14, ref RaiseEventOptions A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref bool A_19, ref object[] A_20, ref RaiseEventOptions A_21, ref ColorChanger A_22, ref Gradient A_23, ref bool A_24, ref Rigidbody A_25, ref RaiseEventOptions A_26, ref bool A_27, ref int A_28, ref bool A_29, ref int A_30, ref bool A_31, bool A_32, bool A_33)
		{
			int num = 0;
			A_28 = num;
			A_0 = 66;
		}

		// Token: 0x06000AFF RID: 2815 RVA: 0x0006D1E0 File Offset: 0x0006B3E0
		private static void IsWeakKeyLocalFindAndPop(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			bool flag = plddd2.jump_left_local != null;
			A_23 = flag;
			int num = ((!A_23) ? 1 : 0) * 1 + 101;
			A_0 = num;
		}

		// Token: 0x06000B00 RID: 2816 RVA: 0x0006D248 File Offset: 0x0006B448
		private static void PrimitiveArrayBody(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			Object.Destroy(plddd2.jump_right_local);
			plddd2.jump_right_local = null;
			plddd2.once_right = false;
			plddd2.once_right_false = true;
			RaiseEventOptions raiseEventOptions = new RaiseEventOptions
			{
				Receivers = 0
			};
			A_14 = raiseEventOptions;
			PhotonNetwork.RaiseEvent(72, null, A_14, SendOptions.SendReliable);
			bool flag = A_4;
			A_15 = flag;
			int num = ((!A_15) ? 1 : 0) * 10 + 244;
			A_0 = num;
		}

		// Token: 0x06000B01 RID: 2817 RVA: 0x0006D30C File Offset: 0x0006B50C
		private static void CapsLockModeJIS(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			plddd2.jump_right_local = GameObject.CreatePrimitive(1);
			A_0 = 157;
		}

		// Token: 0x06000B02 RID: 2818 RVA: 0x0006D334 File Offset: 0x0006B534
		private static void SetCurrentDirectorygetCurrentSize(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			Object.Destroy(plddd2.jump_left_local);
			plddd2.jump_left_local = null;
			plddd2.once_left = false;
			plddd2.once_left_false = true;
			RaiseEventOptions raiseEventOptions = new RaiseEventOptions
			{
				Receivers = 0
			};
			A_24 = raiseEventOptions;
			PhotonNetwork.RaiseEvent(71, null, A_24, SendOptions.SendReliable);
			bool flag = !PhotonNetwork.InRoom;
			A_25 = flag;
			int num = ((!A_25) ? 1 : 0) * 7 + 103;
			A_0 = num;
		}

		// Token: 0x06000B03 RID: 2819 RVA: 0x0006D3F8 File Offset: 0x0006B5F8
		private static void BuiltinBackupOperatorsSidObjectUser(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			plddd2.jump_right_local.GetComponent<Renderer>().material.SetColor("_Color", Color.black);
			A_8 = A_31;
			int num = ((!A_8) ? 1 : 0) * 1 + 80;
			A_0 = num;
		}

		// Token: 0x06000B04 RID: 2820 RVA: 0x0006D474 File Offset: 0x0006B674
		private static void UnixInstantiationArgs(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref RaycastHit A_4, ref bool A_5, ref bool A_6, ref GameObject A_7)
		{
			bool flag = plddd2.pointer == null;
			A_5 = flag;
			int num = ((!A_5) ? 1 : 0) * 1 + 27;
			A_0 = num;
		}

		// Token: 0x06000B05 RID: 2821 RVA: 0x0006D4DC File Offset: 0x0006B6DC
		private static void funckindPARSEDISPLAYNAME(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			bool flag = false;
			A_16 = flag;
			int num = ((!A_16) ? 1 : 0) * 6 + 130;
			A_0 = num;
		}

		// Token: 0x06000B06 RID: 2822 RVA: 0x0006D538 File Offset: 0x0006B738
		private static void getStreamingContextStackFrameHelper(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref Rigidbody A_14, ref RaiseEventOptions A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref bool A_19, ref object[] A_20, ref RaiseEventOptions A_21, ref ColorChanger A_22, ref Gradient A_23, ref bool A_24, ref Rigidbody A_25, ref RaiseEventOptions A_26, ref bool A_27, ref int A_28, ref bool A_29, ref int A_30, ref bool A_31, bool A_32, bool A_33)
		{
			Object.Destroy(plddd2.jump_right_local.GetComponent<Renderer>());
			plddd2.jump_right_local.transform.localScale = plddd2.scale;
			plddd2.jump_right_local.transform.position = new Vector3(0f, -0.01f, 0f) + Player.Instance.rightControllerTransform.position;
			plddd2.jump_right_local.transform.rotation = Player.Instance.rightControllerTransform.rotation;
			object[] array = new object[]
			{
				new Vector3(0f, -0.01f, 0f) + Player.Instance.rightControllerTransform.position,
				Player.Instance.rightControllerTransform.rotation
			};
			A_9 = array;
			RaiseEventOptions raiseEventOptions = new RaiseEventOptions
			{
				Receivers = 0
			};
			A_10 = raiseEventOptions;
			PhotonNetwork.RaiseEvent(70, A_9, A_10, SendOptions.SendReliable);
			plddd2.once_right = true;
			plddd2.once_right_false = false;
			ColorChanger colorChanger = plddd2.jump_right_local.AddComponent<ColorChanger>();
			A_11 = colorChanger;
			Gradient gradient = new Gradient();
			A_12 = gradient;
			A_12.colorKeys = plddd2.colorKeysPlatformMonke;
			A_11.colors = A_12;
			A_11.Start();
			A_0 = 48;
		}

		// Token: 0x06000B07 RID: 2823 RVA: 0x0006D6FC File Offset: 0x0006B8FC
		private static void IEntryPointEntryAssemblyEvidence(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			bool flag = A_28 < plddd2.jump_left_network.Length;
			A_29 = flag;
			int num = (A_29 ? 1 : 0) * -2 + 226;
			A_0 = num;
		}

		// Token: 0x06000B08 RID: 2824 RVA: 0x0006D764 File Offset: 0x0006B964
		private static void LocalSigSEPMonthSuff(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref Rigidbody A_14, ref RaiseEventOptions A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref bool A_19, ref object[] A_20, ref RaiseEventOptions A_21, ref ColorChanger A_22, ref Gradient A_23, ref bool A_24, ref Rigidbody A_25, ref RaiseEventOptions A_26, ref bool A_27, ref int A_28, ref bool A_29, ref int A_30, ref bool A_31, bool A_32, bool A_33)
		{
			plddd2.jump_left_local.GetComponent<Renderer>().material.SetColor("_Color", Color.black);
			A_19 = A_33;
			int num = ((!A_19) ? 1 : 0) * 1 + 56;
			A_0 = num;
		}

		// Token: 0x06000B09 RID: 2825 RVA: 0x0006D7E0 File Offset: 0x0006B9E0
		private static void removeAssemblyLoadUrlAttribute(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			int num = (plddd2.once_left ? 1 : 0) * 1 + 128;
			A_0 = num;
		}

		// Token: 0x06000B0A RID: 2826 RVA: 0x0006D824 File Offset: 0x0006BA24
		private static void ConsoleCancelEventHandlerJ(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref Rigidbody A_14, ref RaiseEventOptions A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref bool A_19, ref object[] A_20, ref RaiseEventOptions A_21, ref ColorChanger A_22, ref Gradient A_23, ref bool A_24, ref Rigidbody A_25, ref RaiseEventOptions A_26, ref bool A_27, ref int A_28, ref bool A_29, ref int A_30, ref bool A_31, bool A_32, bool A_33)
		{
			bool flag = A_30 < plddd2.jump_left_network.Length;
			A_31 = flag;
			int num = (A_31 ? 1 : 0) * -2 + 70;
			A_0 = num;
		}

		// Token: 0x06000B0B RID: 2827 RVA: 0x0006D88C File Offset: 0x0006BA8C
		private static void LowercaseLetterIObjectHandle(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref Rigidbody A_14, ref RaiseEventOptions A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref bool A_19, ref object[] A_20, ref RaiseEventOptions A_21, ref ColorChanger A_22, ref Gradient A_23, ref bool A_24, ref Rigidbody A_25, ref RaiseEventOptions A_26, ref bool A_27, ref int A_28, ref bool A_29, ref int A_30, ref bool A_31, bool A_32, bool A_33)
		{
			Object.Destroy(plddd2.jump_right_network[A_28]);
			int num = A_28 + 1;
			A_28 = num;
			bool flag = A_28 < plddd2.jump_right_network.Length;
			A_29 = flag;
			int num2 = (A_29 ? 1 : 0) * -2 + 67;
			A_0 = num2;
		}

		// Token: 0x06000B0C RID: 2828 RVA: 0x0006D92C File Offset: 0x0006BB2C
		private static void NamesApplicationDirectory(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			plddd2.jump_left_local.GetComponent<Renderer>().material.SetColor("_Color", Color.black);
			A_18 = A_31;
			int num = ((!A_18) ? 1 : 0) * 1 + 95;
			A_0 = num;
		}

		// Token: 0x06000B0D RID: 2829 RVA: 0x0006D9A8 File Offset: 0x0006BBA8
		private static void getIsInitOnlyDarkMagenta(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			bool flag = A_4;
			A_15 = flag;
			int num = ((!A_15) ? 1 : 0) * 10 + 244;
			A_0 = num;
		}

		// Token: 0x06000B0E RID: 2830 RVA: 0x0006DA08 File Offset: 0x0006BC08
		private static void LeftWindowsgetPrivilegeName(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			Object.Destroy(plddd2.jump_right_network[A_26]);
			int num = A_26 + 1;
			A_26 = num;
			bool flag = A_26 < plddd2.jump_right_network.Length;
			A_27 = flag;
			int num2 = (A_27 ? 1 : 0) * -2 + 262;
			A_0 = num2;
		}

		// Token: 0x06000B0F RID: 2831 RVA: 0x0006DAA8 File Offset: 0x0006BCA8
		public static void CylinderStickyPlatforms()
		{
			int num = 10;
			int num2 = 10;
			num2 = 10;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, plddd2.ToStringsetCompoundAceType[num]);
			}
			num2 = 10;
		}

		// Token: 0x06000B10 RID: 2832 RVA: 0x0006DAE0 File Offset: 0x0006BCE0
		private static void IsInitializedwCode(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref RaycastHit A_4, ref bool A_5, ref bool A_6, ref GameObject A_7)
		{
			bool flag = false;
			A_5 = flag;
			int num = ((!A_5) ? 1 : 0) * 1 + 27;
			A_0 = num;
		}

		// Token: 0x06000B11 RID: 2833 RVA: 0x0006DB3C File Offset: 0x0006BD3C
		private static void AssemblyReferenceEntryFieldIdGetMonth(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			bool flag = false;
			A_6 = flag;
			int num = ((!A_6) ? 1 : 0) * 6 + 154;
			A_0 = num;
		}

		// Token: 0x06000B12 RID: 2834 RVA: 0x0006DB98 File Offset: 0x0006BD98
		private static void IsConstructedGenericTypeBinaryCrossAppDomainAssembly(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			bool flag = plddd2.jump_right_local == null;
			A_6 = flag;
			int num = ((!A_6) ? 1 : 0) * 6 + 115;
			A_0 = num;
		}

		// Token: 0x06000B13 RID: 2835 RVA: 0x0006DC00 File Offset: 0x0006BE00
		private static void GetUserStoreForAssemblygetIsIn(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref Rigidbody A_14, ref RaiseEventOptions A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref bool A_19, ref object[] A_20, ref RaiseEventOptions A_21, ref ColorChanger A_22, ref Gradient A_23, ref bool A_24, ref Rigidbody A_25, ref RaiseEventOptions A_26, ref bool A_27, ref int A_28, ref bool A_29, ref int A_30, ref bool A_31, bool A_32, bool A_33)
		{
			plddd2.jump_left_local = GameObject.CreatePrimitive(0);
			A_0 = 55;
		}

		// Token: 0x06000B14 RID: 2836 RVA: 0x0006DC28 File Offset: 0x0006BE28
		private static void MediaStopgetSetMethod(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			Object.Destroy(plddd2.jump_right_local);
			plddd2.jump_right_local = null;
			plddd2.once_right = false;
			plddd2.once_right_false = true;
			RaiseEventOptions raiseEventOptions = new RaiseEventOptions
			{
				Receivers = 0
			};
			A_14 = raiseEventOptions;
			PhotonNetwork.RaiseEvent(72, null, A_14, SendOptions.SendReliable);
			bool flag = A_4;
			A_15 = flag;
			int num = ((!A_15) ? 1 : 0) * 10 + 88;
			A_0 = num;
		}

		// Token: 0x06000B15 RID: 2837 RVA: 0x0006DCEC File Offset: 0x0006BEEC
		private static void EventSourceExceptionAnyScheme(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			Object.Destroy(plddd2.jump_right_local.GetComponent<Renderer>());
			plddd2.jump_right_local.transform.localScale = plddd2.cubescale;
			plddd2.jump_right_local.transform.position = new Vector3(0f, -0.01f, 0f) + Player.Instance.rightControllerTransform.position;
			plddd2.jump_right_local.transform.rotation = Player.Instance.rightControllerTransform.rotation;
			object[] array = new object[]
			{
				new Vector3(0f, -0.01f, 0f) + Player.Instance.rightControllerTransform.position,
				Player.Instance.rightControllerTransform.rotation
			};
			A_9 = array;
			RaiseEventOptions raiseEventOptions = new RaiseEventOptions
			{
				Receivers = 0
			};
			A_10 = raiseEventOptions;
			PhotonNetwork.RaiseEvent(70, A_9, A_10, SendOptions.SendReliable);
			plddd2.once_right = true;
			plddd2.once_right_false = false;
			ColorChanger colorChanger = plddd2.jump_right_local.AddComponent<ColorChanger>();
			A_11 = colorChanger;
			Gradient gradient = new Gradient();
			A_12 = gradient;
			A_12.colorKeys = plddd2.colorKeysPlatformMonke;
			A_11.colors = A_12;
			A_11.Start();
			A_0 = 126;
		}

		// Token: 0x06000B16 RID: 2838 RVA: 0x0006DEB0 File Offset: 0x0006C0B0
		private static void CustomAttributeDataCeiling(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			plddd2.jump_right_local = GameObject.CreatePrimitive(1);
			plddd2.jump_right_local.GetComponent<Renderer>().material.SetColor("_Color", Color.black);
			A_8 = A_31;
			int num = ((!A_8) ? 1 : 0) * 1 + 158;
			A_0 = num;
		}

		// Token: 0x06000B17 RID: 2839 RVA: 0x0006DF3C File Offset: 0x0006C13C
		private static void UsersTrySetApartmentState(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			int num = 0;
			A_26 = num;
			A_0 = 183;
		}

		// Token: 0x06000B18 RID: 2840 RVA: 0x0006DF6C File Offset: 0x0006C16C
		private static void HexNumberBneUnS(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			int num = (plddd2.once_right_false ? 1 : 0) * 1 + 84;
			A_0 = num;
		}

		// Token: 0x06000B19 RID: 2841 RVA: 0x0006DFB0 File Offset: 0x0006C1B0
		private static void DXDSNAppDomainInitializerArguments(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			int num = (plddd2.once_right ? 1 : 0) * 1 + 152;
			A_0 = num;
		}

		// Token: 0x06000B1A RID: 2842 RVA: 0x0006DFF4 File Offset: 0x0006C1F4
		private static void PushiLoopTimer(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			A_17 = A_30;
			int num = ((!A_17) ? 1 : 0) * 1 + 170;
			A_0 = num;
		}

		// Token: 0x06000B1B RID: 2843 RVA: 0x0006E050 File Offset: 0x0006C250
		private static void MoreDatasetHashName(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			bool flag = plddd2.jump_right_local == null;
			A_6 = flag;
			int num = ((!A_6) ? 1 : 0) * 6 + 232;
			A_0 = num;
		}

		// Token: 0x06000B1C RID: 2844 RVA: 0x0006E0B8 File Offset: 0x0006C2B8
		private static void UnobservedTaskExceptionEventArgsCharSetMask(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			Object.Destroy(plddd2.jump_left_local.GetComponent<Renderer>());
			plddd2.jump_left_local.transform.localScale = plddd2.scale;
			plddd2.jump_left_local.transform.position = new Vector3(0f, -0.01f, 0f) + Player.Instance.leftControllerTransform.position;
			plddd2.jump_left_local.transform.rotation = Player.Instance.leftControllerTransform.rotation;
			object[] array = new object[]
			{
				new Vector3(0f, -0.01f, 0f) + Player.Instance.leftControllerTransform.position,
				Player.Instance.leftControllerTransform.rotation
			};
			A_19 = array;
			RaiseEventOptions raiseEventOptions = new RaiseEventOptions
			{
				Receivers = 0
			};
			A_20 = raiseEventOptions;
			PhotonNetwork.RaiseEvent(69, A_19, A_20, SendOptions.SendReliable);
			plddd2.once_left = true;
			plddd2.once_left_false = false;
			ColorChanger colorChanger = plddd2.jump_left_local.AddComponent<ColorChanger>();
			A_21 = colorChanger;
			Gradient gradient = new Gradient();
			A_22 = gradient;
			A_22.colorKeys = plddd2.colorKeysPlatformMonke;
			A_21.colors = A_22;
			A_21.Start();
			A_0 = 219;
		}

		// Token: 0x06000B1D RID: 2845 RVA: 0x0006E27C File Offset: 0x0006C47C
		private static void ChildsetChannelData(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			bool flag = false;
			A_23 = flag;
			int num = ((!A_23) ? 1 : 0) * 1 + 140;
			A_0 = num;
		}

		// Token: 0x06000B1E RID: 2846 RVA: 0x0006E2D8 File Offset: 0x0006C4D8
		private static void SecurityDocumentASSEMBLYFLAGSSAFEREFLECTION(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			plddd2.jump_right_local.transform.localScale = plddd2.cylinderscale;
			plddd2.jump_right_local.transform.position = new Vector3(0f, -0.01f, 0f) + Player.Instance.rightControllerTransform.position;
			plddd2.jump_right_local.transform.rotation = Player.Instance.rightControllerTransform.rotation;
			object[] array = new object[]
			{
				new Vector3(0f, -0.01f, 0f) + Player.Instance.rightControllerTransform.position,
				Player.Instance.rightControllerTransform.rotation
			};
			A_9 = array;
			RaiseEventOptions raiseEventOptions = new RaiseEventOptions
			{
				Receivers = 0
			};
			A_10 = raiseEventOptions;
			PhotonNetwork.RaiseEvent(70, A_9, A_10, SendOptions.SendReliable);
			plddd2.once_right = true;
			plddd2.once_right_false = false;
			ColorChanger colorChanger = plddd2.jump_right_local.AddComponent<ColorChanger>();
			A_11 = colorChanger;
			Gradient gradient = new Gradient();
			A_12 = gradient;
			A_12.colorKeys = plddd2.colorKeysPlatformMonke;
			A_11.colors = A_12;
			A_11.Start();
			A_0 = 165;
		}

		// Token: 0x06000B1F RID: 2847 RVA: 0x0006E48C File Offset: 0x0006C68C
		private static void MaxStackSizeTranslate(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			int num = 0;
			A_28 = num;
			A_0 = 264;
		}

		// Token: 0x06000B20 RID: 2848 RVA: 0x0006E4BC File Offset: 0x0006C6BC
		private static void CubePlatforms(bool invis, bool sticky)
		{
			int num = 111;
			int num2 = 111;
			num2 = 111;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				bool flag2;
				bool flag3;
				bool flag4;
				bool flag5;
				bool flag6;
				object[] array;
				RaiseEventOptions raiseEventOptions;
				ColorChanger colorChanger;
				Gradient gradient;
				bool flag7;
				RaiseEventOptions raiseEventOptions2;
				bool flag8;
				bool flag9;
				bool flag10;
				bool flag11;
				object[] array2;
				RaiseEventOptions raiseEventOptions3;
				ColorChanger colorChanger2;
				Gradient gradient2;
				bool flag12;
				RaiseEventOptions raiseEventOptions4;
				bool flag13;
				int num4;
				bool flag14;
				int num5;
				bool flag15;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Object[]&,Photon.Realtime.RaiseEventOptions&,ShibaGTTemplate.Utilities.ColorChanger&,UnityEngine.Gradient&,System.Boolean&,Photon.Realtime.RaiseEventOptions&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Object[]&,Photon.Realtime.RaiseEventOptions&,ShibaGTTemplate.Utilities.ColorChanger&,UnityEngine.Gradient&,System.Boolean&,Photon.Realtime.RaiseEventOptions&,System.Boolean&,System.Int32&,System.Boolean&,System.Int32&,System.Boolean&,System.Boolean,System.Boolean), ref num, ref num2, ref num3, ref flag, ref flag2, ref flag3, ref flag4, ref flag5, ref flag6, ref array, ref raiseEventOptions, ref colorChanger, ref gradient, ref flag7, ref raiseEventOptions2, ref flag8, ref flag9, ref flag10, ref flag11, ref array2, ref raiseEventOptions3, ref colorChanger2, ref gradient2, ref flag12, ref raiseEventOptions4, ref flag13, ref num4, ref flag14, ref num5, ref flag15, sticky, invis, plddd2.ToStringsetCompoundAceType[num]);
			}
			num2 = 111;
		}

		// Token: 0x06000B21 RID: 2849 RVA: 0x0006E52C File Offset: 0x0006C72C
		private static void getObjectUrlStageComponentFile(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref Rigidbody A_14, ref RaiseEventOptions A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref bool A_19, ref object[] A_20, ref RaiseEventOptions A_21, ref ColorChanger A_22, ref Gradient A_23, ref bool A_24, ref Rigidbody A_25, ref RaiseEventOptions A_26, ref bool A_27, ref int A_28, ref bool A_29, ref int A_30, ref bool A_31, bool A_32, bool A_33)
		{
			Rigidbody rigidbody = plddd2.jump_right_local.AddComponent(typeof(Rigidbody)) as Rigidbody;
			A_14 = rigidbody;
			A_14.velocity = Player.Instance.leftHandCenterVelocityTracker.GetAverageVelocity(true, 0f, false);
			Object.Destroy(plddd2.jump_right_local, 1f);
			plddd2.jump_right_local = null;
			plddd2.once_right = false;
			plddd2.once_right_false = true;
			RaiseEventOptions raiseEventOptions = new RaiseEventOptions
			{
				Receivers = 0
			};
			A_15 = raiseEventOptions;
			PhotonNetwork.RaiseEvent(72, null, A_15, SendOptions.SendReliable);
			bool flag = A_4;
			A_16 = flag;
			int num = ((!A_16) ? 1 : 0) * 10 + 49;
			A_0 = num;
		}

		// Token: 0x06000B22 RID: 2850 RVA: 0x0006E64C File Offset: 0x0006C84C
		private static void EmitWriteLinePrepareDelegate(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			bool flag = A_28 < plddd2.jump_left_network.Length;
			A_29 = flag;
			int num = (A_29 ? 1 : 0) * -2 + 265;
			A_0 = num;
		}

		// Token: 0x06000B23 RID: 2851 RVA: 0x0006E6B4 File Offset: 0x0006C8B4
		private static void SkipSecurityChecksTaskContinuation(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref Rigidbody A_14, ref RaiseEventOptions A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref bool A_19, ref object[] A_20, ref RaiseEventOptions A_21, ref ColorChanger A_22, ref Gradient A_23, ref bool A_24, ref Rigidbody A_25, ref RaiseEventOptions A_26, ref bool A_27, ref int A_28, ref bool A_29, ref int A_30, ref bool A_31, bool A_32, bool A_33)
		{
			bool flag = plddd2.jump_right_local == null;
			A_6 = flag;
			int num = ((!A_6) ? 1 : 0) * 6 + 37;
			A_0 = num;
		}

		// Token: 0x06000B24 RID: 2852 RVA: 0x0006E71C File Offset: 0x0006C91C
		private static void AssemblyKeyNameAttributeProgressStatics(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref bool A_5, ref GameObject A_6)
		{
			bool gripDownL = buttons.gripDownL;
			A_5 = gripDownL;
			int num = ((!A_5) ? 1 : 0) * 1 + 21;
			A_0 = num;
		}

		// Token: 0x06000B25 RID: 2853 RVA: 0x0006E778 File Offset: 0x0006C978
		private static void MinorGetActivationContextData(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			bool flag = A_26 < plddd2.jump_right_network.Length;
			A_27 = flag;
			int num = (A_27 ? 1 : 0) * -2 + 106;
			A_0 = num;
		}

		// Token: 0x06000B26 RID: 2854 RVA: 0x0006E7E0 File Offset: 0x0006C9E0
		private static void GetNextTextElementstringBuilder(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref Rigidbody A_14, ref RaiseEventOptions A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref bool A_19, ref object[] A_20, ref RaiseEventOptions A_21, ref ColorChanger A_22, ref Gradient A_23, ref bool A_24, ref Rigidbody A_25, ref RaiseEventOptions A_26, ref bool A_27, ref int A_28, ref bool A_29, ref int A_30, ref bool A_31, bool A_32, bool A_33)
		{
			plddd2.jump_left_local = GameObject.CreatePrimitive(3);
			plddd2.jump_left_local.GetComponent<Renderer>().material.SetColor("_Color", Color.black);
			A_19 = A_33;
			int num = ((!A_19) ? 1 : 0) * 1 + 56;
			A_0 = num;
		}

		// Token: 0x06000B27 RID: 2855 RVA: 0x0006E86C File Offset: 0x0006CA6C
		private static void GetEffectiveDateStringgetErrors(ref int A_0, ref int A_1, ref int A_2)
		{
			plddd2.TriggerPlatforms(false, false);
			A_1 = 0;
		}

		// Token: 0x06000B28 RID: 2856 RVA: 0x0006E894 File Offset: 0x0006CA94
		public static void PlatformGun()
		{
			int num = 23;
			int num2 = 23;
			num2 = 23;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				RaycastHit raycastHit;
				bool flag2;
				bool flag3;
				GameObject gameObject;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,UnityEngine.RaycastHit&,System.Boolean&,System.Boolean&,UnityEngine.GameObject&), ref num, ref num2, ref num3, ref flag, ref raycastHit, ref flag2, ref flag3, ref gameObject, plddd2.ToStringsetCompoundAceType[num]);
			}
			num2 = 23;
		}

		// Token: 0x06000B29 RID: 2857 RVA: 0x0006E8D4 File Offset: 0x0006CAD4
		private static void IMetadataSectionEntrySECURITYLOGONSESSIONDATA(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			plddd2.colorKeysPlatformMonke[0].color = new Color32(20, 20, 20, byte.MaxValue);
			plddd2.colorKeysPlatformMonke[0].time = 0f;
			plddd2.colorKeysPlatformMonke[1].color = new Color32(50, 50, 50, byte.MaxValue);
			plddd2.colorKeysPlatformMonke[1].time = 0.5f;
			plddd2.colorKeysPlatformMonke[2].color = new Color32(50, 50, 50, byte.MaxValue);
			plddd2.colorKeysPlatformMonke[2].time = 0.5f;
			plddd2.colorKeysPlatformMonke[3].color = new Color32(20, 20, 20, byte.MaxValue);
			plddd2.colorKeysPlatformMonke[3].time = 1f;
			bool gripDownR = buttons.gripDownR;
			A_3 = gripDownR;
			bool gripDownL = buttons.gripDownL;
			A_4 = gripDownL;
			bool flag = A_3;
			A_5 = flag;
			int num = ((!A_5) ? 1 : 0) * 10 + 112;
			A_0 = num;
		}

		// Token: 0x06000B2A RID: 2858 RVA: 0x0006EA8C File Offset: 0x0006CC8C
		private static void getFallbackBufferSEPTime(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			A_0 = 126;
		}

		// Token: 0x06000B2B RID: 2859 RVA: 0x0006EAA4 File Offset: 0x0006CCA4
		private static void GetShortestDayNamegetKeyName(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			plddd2.jump_right_local.GetComponent<Renderer>().material.SetColor("_Color", Color.black);
			A_8 = A_31;
			int num = ((!A_8) ? 1 : 0) * 1 + 119;
			A_0 = num;
		}

		// Token: 0x06000B2C RID: 2860 RVA: 0x0006EB20 File Offset: 0x0006CD20
		private static void MemberGetSize(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			bool flag = plddd2.jump_right_local != null;
			A_13 = flag;
			int num = ((!A_13) ? 1 : 0) * 1 + 125;
			A_0 = num;
		}

		// Token: 0x06000B2D RID: 2861 RVA: 0x0006EB88 File Offset: 0x0006CD88
		private static void GetFilterAsTupledIssuer(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref RaycastHit A_4, ref bool A_5, ref bool A_6, ref GameObject A_7)
		{
			bool gripDownR = buttons.gripDownR;
			A_3 = gripDownR;
			int num = ((!A_3) ? 1 : 0) * 7 + 24;
			A_0 = num;
		}

		// Token: 0x06000B2E RID: 2862 RVA: 0x0006EBE4 File Offset: 0x0006CDE4
		private static void EventBuilderObjectWithMapTyped(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			bool flag = A_26 < plddd2.jump_right_network.Length;
			A_27 = flag;
			int num = (A_27 ? 1 : 0) * -2 + 145;
			A_0 = num;
		}

		// Token: 0x06000B2F RID: 2863 RVA: 0x0006EC4C File Offset: 0x0006CE4C
		private static void SqrtMuiResourceTypeIdIntIntegerIds(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			plddd2.jump_left_local = GameObject.CreatePrimitive(0);
			A_0 = 133;
		}

		// Token: 0x06000B30 RID: 2864 RVA: 0x0006EC74 File Offset: 0x0006CE74
		private static void GetLastAccessTimegetAttributeString(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			Object.Destroy(plddd2.jump_left_local);
			plddd2.jump_left_local = null;
			plddd2.once_left = false;
			plddd2.once_left_false = true;
			RaiseEventOptions raiseEventOptions = new RaiseEventOptions
			{
				Receivers = 0
			};
			A_24 = raiseEventOptions;
			PhotonNetwork.RaiseEvent(71, null, A_24, SendOptions.SendReliable);
			bool flag = !PhotonNetwork.InRoom;
			A_25 = flag;
			int num = ((!A_25) ? 1 : 0) * 7 + 259;
			A_0 = num;
		}

		// Token: 0x06000B31 RID: 2865 RVA: 0x0006ED38 File Offset: 0x0006CF38
		private static void DelegateBindingFlagsgetEnvoyInfo(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			plddd2.jump_left_local = GameObject.CreatePrimitive(3);
			plddd2.jump_left_local.GetComponent<Renderer>().material.SetColor("_Color", Color.black);
			A_18 = A_31;
			int num = ((!A_18) ? 1 : 0) * 1 + 173;
			A_0 = num;
		}

		// Token: 0x06000B32 RID: 2866 RVA: 0x0006EDC4 File Offset: 0x0006CFC4
		private static void getStoreExecuteSynchronously(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			bool flag = A_26 < plddd2.jump_right_network.Length;
			A_27 = flag;
			int num = (A_27 ? 1 : 0) * -2 + 184;
			A_0 = num;
		}

		// Token: 0x06000B33 RID: 2867 RVA: 0x0006EE2C File Offset: 0x0006D02C
		private static void StaticArrayInitTypeSizeGuidStyles(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			A_0 = 141;
		}

		// Token: 0x06000B34 RID: 2868 RVA: 0x0006EE44 File Offset: 0x0006D044
		private static void TokenHasRestrictionsISecurityEncodable(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			bool flag = false;
			A_16 = flag;
			int num = ((!A_16) ? 1 : 0) * 6 + 169;
			A_0 = num;
		}

		// Token: 0x06000B35 RID: 2869 RVA: 0x0006EEA0 File Offset: 0x0006D0A0
		private static void SpecifyKindIsResource(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			bool flag = plddd2.jump_right_local != null;
			A_13 = flag;
			int num = ((!A_13) ? 1 : 0) * 1 + 242;
			A_0 = num;
		}

		// Token: 0x06000B36 RID: 2870 RVA: 0x0006EF08 File Offset: 0x0006D108
		private static void getScheduledExclusiveMatchAllVersions(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			bool flag = A_4;
			A_15 = flag;
			int num = ((!A_15) ? 1 : 0) * 10 + 88;
			A_0 = num;
		}

		// Token: 0x06000B37 RID: 2871 RVA: 0x0006EF68 File Offset: 0x0006D168
		private static void getCdfIdentityOnSerializedAttribute(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			bool flag = false;
			A_23 = flag;
			int num = ((!A_23) ? 1 : 0) * 1 + 179;
			A_0 = num;
		}

		// Token: 0x06000B38 RID: 2872 RVA: 0x0006EFC4 File Offset: 0x0006D1C4
		private static void GetExceptionForHRContractClassForAttribute(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			int num = (plddd2.once_right ? 1 : 0) * 1 + 74;
			A_0 = num;
		}

		// Token: 0x06000B39 RID: 2873 RVA: 0x0006F008 File Offset: 0x0006D208
		private static void FUNCNONVIRTUALHasFlag(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			plddd2.jump_left_local = GameObject.CreatePrimitive(0);
			A_0 = 172;
		}

		// Token: 0x06000B3A RID: 2874 RVA: 0x0006F030 File Offset: 0x0006D230
		private static void GCLatencyModeDefaultIssuer(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			Object.Destroy(plddd2.jump_left_network[A_28]);
			int num = A_28 + 1;
			A_28 = num;
			bool flag = A_28 < plddd2.jump_left_network.Length;
			A_29 = flag;
			int num2 = (A_29 ? 1 : 0) * -2 + 226;
			A_0 = num2;
		}

		// Token: 0x06000B3B RID: 2875 RVA: 0x0006F0D0 File Offset: 0x0006D2D0
		private static void FUNCFLAGFBINDABLEFindInterfaces(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref RaycastHit A_4, ref bool A_5, ref bool A_6, ref GameObject A_7)
		{
			A_1 = 0;
		}

		// Token: 0x06000B3C RID: 2876 RVA: 0x0006F0E8 File Offset: 0x0006D2E8
		private static void IdentityReferenceContextAttributeEntry(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref Rigidbody A_14, ref RaiseEventOptions A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref bool A_19, ref object[] A_20, ref RaiseEventOptions A_21, ref ColorChanger A_22, ref Gradient A_23, ref bool A_24, ref Rigidbody A_25, ref RaiseEventOptions A_26, ref bool A_27, ref int A_28, ref bool A_29, ref int A_30, ref bool A_31, bool A_32, bool A_33)
		{
			plddd2.jump_right_local = GameObject.CreatePrimitive(0);
			A_0 = 40;
		}

		// Token: 0x06000B3D RID: 2877 RVA: 0x0006F110 File Offset: 0x0006D310
		private static void getIsFamilyGetSigOfMethodDef(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			Object.Destroy(plddd2.jump_left_local.GetComponent<Renderer>());
			plddd2.jump_left_local.transform.localScale = plddd2.cylinderscale;
			plddd2.jump_left_local.transform.position = new Vector3(0f, -0.01f, 0f) + Player.Instance.leftControllerTransform.position;
			plddd2.jump_left_local.transform.rotation = Player.Instance.leftControllerTransform.rotation;
			object[] array = new object[]
			{
				new Vector3(0f, -0.01f, 0f) + Player.Instance.leftControllerTransform.position,
				Player.Instance.leftControllerTransform.rotation
			};
			A_19 = array;
			RaiseEventOptions raiseEventOptions = new RaiseEventOptions
			{
				Receivers = 0
			};
			A_20 = raiseEventOptions;
			PhotonNetwork.RaiseEvent(69, A_19, A_20, SendOptions.SendReliable);
			plddd2.once_left = true;
			plddd2.once_left_false = false;
			ColorChanger colorChanger = plddd2.jump_left_local.AddComponent<ColorChanger>();
			A_21 = colorChanger;
			Gradient gradient = new Gradient();
			A_22 = gradient;
			A_22.colorKeys = plddd2.colorKeysPlatformMonke;
			A_21.colors = A_22;
			A_21.Start();
			A_0 = 180;
		}

		// Token: 0x06000B3E RID: 2878 RVA: 0x0006F2D4 File Offset: 0x0006D4D4
		private static void SimpleXmlFormatgetIsDS(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			bool flag = A_28 < plddd2.jump_left_network.Length;
			A_29 = flag;
			int num = (A_29 ? 1 : 0) * -2 + 187;
			A_0 = num;
		}

		// Token: 0x06000B3F RID: 2879 RVA: 0x0006F33C File Offset: 0x0006D53C
		public static void TriggerStickyPlatforms()
		{
			int num = 5;
			int num2 = 5;
			num2 = 5;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, plddd2.ToStringsetCompoundAceType[num]);
			}
			num2 = 5;
		}

		// Token: 0x06000B40 RID: 2880 RVA: 0x0006F370 File Offset: 0x0006D570
		private static void GetEventTokenResourceManagerCultureFoundInConfigFile(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			bool flag = A_4;
			A_15 = flag;
			int num = ((!A_15) ? 1 : 0) * 10 + 166;
			A_0 = num;
		}

		// Token: 0x06000B41 RID: 2881 RVA: 0x0006F3D0 File Offset: 0x0006D5D0
		private static void TrustManagerContextLastImmediateValue(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			A_0 = 180;
		}

		// Token: 0x06000B42 RID: 2882 RVA: 0x0006F3E8 File Offset: 0x0006D5E8
		private static void SizeParamIndexCurrency(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			bool flag = plddd2.jump_right_local == null;
			A_6 = flag;
			int num = ((!A_6) ? 1 : 0) * 6 + 76;
			A_0 = num;
		}

		// Token: 0x06000B43 RID: 2883 RVA: 0x0006F450 File Offset: 0x0006D650
		private static void TypeLibVarFlagsDelegateEntry(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			A_7 = A_30;
			int num = ((!A_7) ? 1 : 0) * 1 + 77;
			A_0 = num;
		}

		// Token: 0x06000B44 RID: 2884 RVA: 0x0006F4AC File Offset: 0x0006D6AC
		private static void HostProtectionResourceObjectComparer(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			bool flag = plddd2.jump_right_local != null;
			A_13 = flag;
			int num = ((!A_13) ? 1 : 0) * 1 + 164;
			A_0 = num;
		}

		// Token: 0x06000B45 RID: 2885 RVA: 0x0006F514 File Offset: 0x0006D714
		private static void DllNotFoundExceptionIsHighSurrogate(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			A_1 = 0;
		}

		// Token: 0x06000B46 RID: 2886 RVA: 0x0006F52C File Offset: 0x0006D72C
		public static void SphereStickyPlats()
		{
			int num = 7;
			int num2 = 7;
			num2 = 7;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, plddd2.ToStringsetCompoundAceType[num]);
			}
			num2 = 7;
		}

		// Token: 0x06000B47 RID: 2887 RVA: 0x0006F560 File Offset: 0x0006D760
		private static void CountersignatureGetMinThreads(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			bool flag = A_28 < plddd2.jump_left_network.Length;
			A_29 = flag;
			int num = (A_29 ? 1 : 0) * -2 + 148;
			A_0 = num;
		}

		// Token: 0x06000B48 RID: 2888 RVA: 0x0006F5C8 File Offset: 0x0006D7C8
		private static void charPosGetAssemblyIdentity(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			plddd2.jump_left_local = GameObject.CreatePrimitive(0);
			A_0 = 211;
		}

		// Token: 0x06000B49 RID: 2889 RVA: 0x0006F5F0 File Offset: 0x0006D7F0
		private static void PulseAllGetMaxThreads(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref Rigidbody A_14, ref RaiseEventOptions A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref bool A_19, ref object[] A_20, ref RaiseEventOptions A_21, ref ColorChanger A_22, ref Gradient A_23, ref bool A_24, ref Rigidbody A_25, ref RaiseEventOptions A_26, ref bool A_27, ref int A_28, ref bool A_29, ref int A_30, ref bool A_31, bool A_32, bool A_33)
		{
			bool flag = A_4;
			A_16 = flag;
			int num = ((!A_16) ? 1 : 0) * 10 + 49;
			A_0 = num;
		}

		// Token: 0x06000B4A RID: 2890 RVA: 0x0006F650 File Offset: 0x0006D850
		public static void CubeStickyPlatforms()
		{
			int num = 12;
			int num2 = 12;
			num2 = 12;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, plddd2.ToStringsetCompoundAceType[num]);
			}
			num2 = 12;
		}

		// Token: 0x06000B4B RID: 2891 RVA: 0x0006F688 File Offset: 0x0006D888
		private static void WinapiCategoryMembershipDataDescription(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			Object.Destroy(plddd2.jump_right_local);
			plddd2.jump_right_local = null;
			plddd2.once_right = false;
			plddd2.once_right_false = true;
			RaiseEventOptions raiseEventOptions = new RaiseEventOptions
			{
				Receivers = 0
			};
			A_14 = raiseEventOptions;
			PhotonNetwork.RaiseEvent(72, null, A_14, SendOptions.SendReliable);
			bool flag = A_4;
			A_15 = flag;
			int num = ((!A_15) ? 1 : 0) * 10 + 127;
			A_0 = num;
		}

		// Token: 0x06000B4C RID: 2892 RVA: 0x0006F74C File Offset: 0x0006D94C
		private static void TXNDelegateBindingFlags(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			int num = (plddd2.once_right ? 1 : 0) * 1 + 191;
			A_0 = num;
		}

		// Token: 0x06000B4D RID: 2893 RVA: 0x0006F790 File Offset: 0x0006D990
		private static void BinaryAssemblyInfoBootstrapContext(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			bool flag = false;
			A_16 = flag;
			int num = ((!A_16) ? 1 : 0) * 6 + 247;
			A_0 = num;
		}

		// Token: 0x06000B4E RID: 2894 RVA: 0x0006F7EC File Offset: 0x0006D9EC
		private static void EventAttributeremoveModuleResolve(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			int num = 0;
			A_26 = num;
			A_0 = 144;
		}

		// Token: 0x06000B4F RID: 2895 RVA: 0x0006F81C File Offset: 0x0006DA1C
		private static void VariantBoolPrecondition(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			A_17 = A_30;
			int num = ((!A_17) ? 1 : 0) * 1 + 131;
			A_0 = num;
		}

		// Token: 0x06000B50 RID: 2896 RVA: 0x0006F878 File Offset: 0x0006DA78
		private static void EmptyStructBgt(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			plddd2.jump_right_local.transform.localScale = plddd2.scale;
			plddd2.jump_right_local.transform.position = new Vector3(0f, -0.01f, 0f) + Player.Instance.rightControllerTransform.position;
			plddd2.jump_right_local.transform.rotation = Player.Instance.rightControllerTransform.rotation;
			object[] array = new object[]
			{
				new Vector3(0f, -0.01f, 0f) + Player.Instance.rightControllerTransform.position,
				Player.Instance.rightControllerTransform.rotation
			};
			A_9 = array;
			RaiseEventOptions raiseEventOptions = new RaiseEventOptions
			{
				Receivers = 0
			};
			A_10 = raiseEventOptions;
			PhotonNetwork.RaiseEvent(70, A_9, A_10, SendOptions.SendReliable);
			plddd2.once_right = true;
			plddd2.once_right_false = false;
			ColorChanger colorChanger = plddd2.jump_right_local.AddComponent<ColorChanger>();
			A_11 = colorChanger;
			Gradient gradient = new Gradient();
			A_12 = gradient;
			A_12.colorKeys = plddd2.colorKeysPlatformMonke;
			A_11.colors = A_12;
			A_11.Start();
			A_0 = 87;
		}

		// Token: 0x06000B51 RID: 2897 RVA: 0x0006FA2C File Offset: 0x0006DC2C
		private static void CCMPWCDECLBeginInvoke(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			int num = (plddd2.once_left ? 1 : 0) * 1 + 167;
			A_0 = num;
		}

		// Token: 0x06000B52 RID: 2898 RVA: 0x0006FA70 File Offset: 0x0006DC70
		private static void addContractFailedProgramFiles(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref Rigidbody A_14, ref RaiseEventOptions A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref bool A_19, ref object[] A_20, ref RaiseEventOptions A_21, ref ColorChanger A_22, ref Gradient A_23, ref bool A_24, ref Rigidbody A_25, ref RaiseEventOptions A_26, ref bool A_27, ref int A_28, ref bool A_29, ref int A_30, ref bool A_31, bool A_32, bool A_33)
		{
			A_7 = A_32;
			int num = ((!A_7) ? 1 : 0) * 1 + 38;
			A_0 = num;
		}

		// Token: 0x06000B53 RID: 2899 RVA: 0x0006FACC File Offset: 0x0006DCCC
		private static void DirectoryNameIsLeapYear(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref bool A_5, ref GameObject A_6)
		{
			A_1 = 0;
		}

		// Token: 0x06000B54 RID: 2900 RVA: 0x0006FAE4 File Offset: 0x0006DCE4
		private static void IsSupportedTraceGuidQueryProcess(ref int A_0, ref int A_1, ref int A_2)
		{
			plddd2.CylinderPlatforms(false, false);
			A_1 = 0;
		}

		// Token: 0x06000B55 RID: 2901 RVA: 0x0006FB0C File Offset: 0x0006DD0C
		private static void ProduceLegacyHmacValuesMinValue(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			plddd2.jump_right_local = GameObject.CreatePrimitive(3);
			plddd2.jump_right_local.GetComponent<Renderer>().material.SetColor("_Color", Color.black);
			A_8 = A_31;
			int num = ((!A_8) ? 1 : 0) * 1 + 80;
			A_0 = num;
		}

		// Token: 0x06000B56 RID: 2902 RVA: 0x0006FB98 File Offset: 0x0006DD98
		private static void CreateProxyInitialize(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			A_17 = A_30;
			int num = ((!A_17) ? 1 : 0) * 1 + 92;
			A_0 = num;
		}

		// Token: 0x06000B57 RID: 2903 RVA: 0x0006FBF4 File Offset: 0x0006DDF4
		private static void GripPlatforms(bool invis, bool sticky)
		{
			int num = 72;
			int num2 = 72;
			num2 = 72;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				bool flag2;
				bool flag3;
				bool flag4;
				bool flag5;
				bool flag6;
				object[] array;
				RaiseEventOptions raiseEventOptions;
				ColorChanger colorChanger;
				Gradient gradient;
				bool flag7;
				RaiseEventOptions raiseEventOptions2;
				bool flag8;
				bool flag9;
				bool flag10;
				bool flag11;
				object[] array2;
				RaiseEventOptions raiseEventOptions3;
				ColorChanger colorChanger2;
				Gradient gradient2;
				bool flag12;
				RaiseEventOptions raiseEventOptions4;
				bool flag13;
				int num4;
				bool flag14;
				int num5;
				bool flag15;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Object[]&,Photon.Realtime.RaiseEventOptions&,ShibaGTTemplate.Utilities.ColorChanger&,UnityEngine.Gradient&,System.Boolean&,Photon.Realtime.RaiseEventOptions&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Object[]&,Photon.Realtime.RaiseEventOptions&,ShibaGTTemplate.Utilities.ColorChanger&,UnityEngine.Gradient&,System.Boolean&,Photon.Realtime.RaiseEventOptions&,System.Boolean&,System.Int32&,System.Boolean&,System.Int32&,System.Boolean&,System.Boolean,System.Boolean), ref num, ref num2, ref num3, ref flag, ref flag2, ref flag3, ref flag4, ref flag5, ref flag6, ref array, ref raiseEventOptions, ref colorChanger, ref gradient, ref flag7, ref raiseEventOptions2, ref flag8, ref flag9, ref flag10, ref flag11, ref array2, ref raiseEventOptions3, ref colorChanger2, ref gradient2, ref flag12, ref raiseEventOptions4, ref flag13, ref num4, ref flag14, ref num5, ref flag15, sticky, invis, plddd2.ToStringsetCompoundAceType[num]);
			}
			num2 = 72;
		}

		// Token: 0x06000B58 RID: 2904 RVA: 0x0006FC64 File Offset: 0x0006DE64
		private static void getPersistKeyInCspFormatStubInfo(ref int A_0, ref int A_1, ref int A_2)
		{
			plddd2.TriggerPlatforms(true, false);
			A_1 = 0;
		}

		// Token: 0x06000B59 RID: 2905 RVA: 0x0006FC8C File Offset: 0x0006DE8C
		private static void LocalDataStoreHoldergetAssemblyIsPrivate(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			int num = (plddd2.once_left_false ? 1 : 0) * 1 + 99;
			A_0 = num;
		}

		// Token: 0x06000B5A RID: 2906 RVA: 0x0006FCD0 File Offset: 0x0006DED0
		private static void XsdStringAssemblyVersionAttribute(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref Rigidbody A_14, ref RaiseEventOptions A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref bool A_19, ref object[] A_20, ref RaiseEventOptions A_21, ref ColorChanger A_22, ref Gradient A_23, ref bool A_24, ref Rigidbody A_25, ref RaiseEventOptions A_26, ref bool A_27, ref int A_28, ref bool A_29, ref int A_30, ref bool A_31, bool A_32, bool A_33)
		{
			plddd2.jump_right_local.transform.localScale = plddd2.scale;
			plddd2.jump_right_local.transform.position = new Vector3(0f, -0.01f, 0f) + Player.Instance.rightControllerTransform.position;
			plddd2.jump_right_local.transform.rotation = Player.Instance.rightControllerTransform.rotation;
			object[] array = new object[]
			{
				new Vector3(0f, -0.01f, 0f) + Player.Instance.rightControllerTransform.position,
				Player.Instance.rightControllerTransform.rotation
			};
			A_9 = array;
			RaiseEventOptions raiseEventOptions = new RaiseEventOptions
			{
				Receivers = 0
			};
			A_10 = raiseEventOptions;
			PhotonNetwork.RaiseEvent(70, A_9, A_10, SendOptions.SendReliable);
			plddd2.once_right = true;
			plddd2.once_right_false = false;
			ColorChanger colorChanger = plddd2.jump_right_local.AddComponent<ColorChanger>();
			A_11 = colorChanger;
			Gradient gradient = new Gradient();
			A_12 = gradient;
			A_12.colorKeys = plddd2.colorKeysPlatformMonke;
			A_11.colors = A_12;
			A_11.Start();
			A_0 = 48;
		}

		// Token: 0x06000B5B RID: 2907 RVA: 0x0006FE84 File Offset: 0x0006E084
		private static void GlobalResourceContextBestFitCultureInfoDaylightTransitionEnd(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			Object.Destroy(plddd2.jump_right_local);
			plddd2.jump_right_local = null;
			plddd2.once_right = false;
			plddd2.once_right_false = true;
			RaiseEventOptions raiseEventOptions = new RaiseEventOptions
			{
				Receivers = 0
			};
			A_14 = raiseEventOptions;
			PhotonNetwork.RaiseEvent(72, null, A_14, SendOptions.SendReliable);
			bool flag = A_4;
			A_15 = flag;
			int num = ((!A_15) ? 1 : 0) * 10 + 166;
			A_0 = num;
		}

		// Token: 0x06000B5C RID: 2908 RVA: 0x0006FF48 File Offset: 0x0006E148
		private static void TypeIdentifierAttributeAlways(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			plddd2.colorKeysPlatformMonke[0].color = new Color32(20, 20, 20, byte.MaxValue);
			plddd2.colorKeysPlatformMonke[0].time = 0f;
			plddd2.colorKeysPlatformMonke[1].color = new Color32(50, 50, 50, byte.MaxValue);
			plddd2.colorKeysPlatformMonke[1].time = 0.5f;
			plddd2.colorKeysPlatformMonke[2].color = new Color32(50, 50, 50, byte.MaxValue);
			plddd2.colorKeysPlatformMonke[2].time = 0.5f;
			plddd2.colorKeysPlatformMonke[3].color = new Color32(20, 20, 20, byte.MaxValue);
			plddd2.colorKeysPlatformMonke[3].time = 1f;
			bool gripDownR = buttons.gripDownR;
			A_3 = gripDownR;
			bool gripDownL = buttons.gripDownL;
			A_4 = gripDownL;
			bool flag = A_3;
			A_5 = flag;
			int num = ((!A_5) ? 1 : 0) * 10 + 73;
			A_0 = num;
		}

		// Token: 0x06000B5D RID: 2909 RVA: 0x00070100 File Offset: 0x0006E300
		private static void IDLFLAGFLCIDResourceManagerCultureFoundInConfigFile(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			bool flag = plddd2.jump_right_local != null;
			A_13 = flag;
			int num = ((!A_13) ? 1 : 0) * 1 + 203;
			A_0 = num;
		}

		// Token: 0x06000B5E RID: 2910 RVA: 0x00070168 File Offset: 0x0006E368
		private static void SafeCspHashHandleReturnParameter(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			plddd2.jump_right_local = GameObject.CreatePrimitive(0);
			plddd2.jump_right_local.GetComponent<Renderer>().material.SetColor("_Color", Color.black);
			A_8 = A_31;
			int num = ((!A_8) ? 1 : 0) * 1 + 236;
			A_0 = num;
		}

		// Token: 0x06000B5F RID: 2911 RVA: 0x000701F4 File Offset: 0x0006E3F4
		private static void TokenGroupsIsStateAvailable(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			A_0 = 243;
		}

		// Token: 0x06000B60 RID: 2912 RVA: 0x0007020C File Offset: 0x0006E40C
		private static void StringMakergetDeniedPermissions(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			Object.Destroy(plddd2.jump_left_local.GetComponent<Renderer>());
			plddd2.jump_left_local.transform.localScale = plddd2.cubescale;
			plddd2.jump_left_local.transform.position = new Vector3(0f, -0.01f, 0f) + Player.Instance.leftControllerTransform.position;
			plddd2.jump_left_local.transform.rotation = Player.Instance.leftControllerTransform.rotation;
			object[] array = new object[]
			{
				new Vector3(0f, -0.01f, 0f) + Player.Instance.leftControllerTransform.position,
				Player.Instance.leftControllerTransform.rotation
			};
			A_19 = array;
			RaiseEventOptions raiseEventOptions = new RaiseEventOptions
			{
				Receivers = 0
			};
			A_20 = raiseEventOptions;
			PhotonNetwork.RaiseEvent(69, A_19, A_20, SendOptions.SendReliable);
			plddd2.once_left = true;
			plddd2.once_left_false = false;
			ColorChanger colorChanger = plddd2.jump_left_local.AddComponent<ColorChanger>();
			A_21 = colorChanger;
			Gradient gradient = new Gradient();
			A_22 = gradient;
			A_22.colorKeys = plddd2.colorKeysPlatformMonke;
			A_21.colors = A_22;
			A_21.Start();
			A_0 = 141;
		}

		// Token: 0x06000B61 RID: 2913 RVA: 0x000703D0 File Offset: 0x0006E5D0
		private static void GetResponseFormatLiterals(ref int A_0, ref int A_1, ref int A_2)
		{
			plddd2.platformcolor = new Color(50f, 50f, 50f, 255f);
			plddd2.position = GorillaTagger.Instance.leftHandTransform.position + new Vector3(0f, -0.05f, 0f);
			plddd2.cylinderscale = new Vector3(0.0125f, 0.0125f, 0.6825f);
			plddd2.scale = new Vector3(0.0125f, 0.28f, 0.3825f);
			plddd2.cubescale = new Vector3(0.03f, 0.75f, 0.3f);
			plddd2.spherescale = new Vector3(0.3f, 0.3f, 0.3f);
			plddd2.jump_left_network = new GameObject[9999];
			plddd2.jump_right_network = new GameObject[9999];
			plddd2.jump_left_local = null;
			plddd2.jump_right_local = null;
			plddd2.colorKeysPlatformMonke = new GradientColorKey[4];
			A_1 = 0;
		}

		// Token: 0x06000B62 RID: 2914 RVA: 0x000704D0 File Offset: 0x0006E6D0
		private static void InternalMemberValueEReferenceCountValue(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			int num = 0;
			A_28 = num;
			A_0 = 186;
		}

		// Token: 0x06000B63 RID: 2915 RVA: 0x00070500 File Offset: 0x0006E700
		private static void TimeZoneResourceFallbackCulture(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref RaycastHit A_4, ref bool A_5, ref bool A_6, ref GameObject A_7)
		{
			plddd2.pointer.transform.position = A_4.point;
			bool triggerDownR = buttons.triggerDownR;
			A_6 = triggerDownR;
			int num = ((!A_6) ? 1 : 0) * 1 + 29;
			A_0 = num;
		}

		// Token: 0x06000B64 RID: 2916 RVA: 0x00070574 File Offset: 0x0006E774
		public static void BuildPlatforms()
		{
			int num = 13;
			int num2 = 13;
			num2 = 13;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				GameObject gameObject;
				bool flag2;
				GameObject gameObject2;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,UnityEngine.GameObject&,System.Boolean&,UnityEngine.GameObject&), ref num, ref num2, ref num3, ref flag, ref gameObject, ref flag2, ref gameObject2, plddd2.ToStringsetCompoundAceType[num]);
			}
			num2 = 13;
		}

		// Token: 0x06000B65 RID: 2917 RVA: 0x000705B4 File Offset: 0x0006E7B4
		private static void NetworkShortcutsTryPopRange(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			bool flag = plddd2.jump_right_local == null;
			A_6 = flag;
			int num = ((!A_6) ? 1 : 0) * 6 + 154;
			A_0 = num;
		}

		// Token: 0x06000B66 RID: 2918 RVA: 0x0007061C File Offset: 0x0006E81C
		private static void HashMembershipConditiongetRegistryKeySection(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			plddd2.jump_right_local = GameObject.CreatePrimitive(0);
			A_0 = 118;
		}

		// Token: 0x06000B67 RID: 2919 RVA: 0x00070644 File Offset: 0x0006E844
		private static void YearMonthDurationMethodRental(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref Rigidbody A_14, ref RaiseEventOptions A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref bool A_19, ref object[] A_20, ref RaiseEventOptions A_21, ref ColorChanger A_22, ref Gradient A_23, ref bool A_24, ref Rigidbody A_25, ref RaiseEventOptions A_26, ref bool A_27, ref int A_28, ref bool A_29, ref int A_30, ref bool A_31, bool A_32, bool A_33)
		{
			A_18 = A_32;
			int num = ((!A_18) ? 1 : 0) * 1 + 53;
			A_0 = num;
		}

		// Token: 0x06000B68 RID: 2920 RVA: 0x000706A0 File Offset: 0x0006E8A0
		private static void EndChildrenCallbackOriginalIssuerEqualsIssuer(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			plddd2.colorKeysPlatformMonke[0].color = new Color32(20, 20, 20, byte.MaxValue);
			plddd2.colorKeysPlatformMonke[0].time = 0f;
			plddd2.colorKeysPlatformMonke[1].color = new Color32(50, 50, 50, byte.MaxValue);
			plddd2.colorKeysPlatformMonke[1].time = 0.5f;
			plddd2.colorKeysPlatformMonke[2].color = new Color32(50, 50, 50, byte.MaxValue);
			plddd2.colorKeysPlatformMonke[2].time = 0.5f;
			plddd2.colorKeysPlatformMonke[3].color = new Color32(20, 20, 20, byte.MaxValue);
			plddd2.colorKeysPlatformMonke[3].time = 1f;
			bool gripDownR = buttons.gripDownR;
			A_3 = gripDownR;
			bool gripDownL = buttons.gripDownL;
			A_4 = gripDownL;
			bool flag = A_3;
			A_5 = flag;
			int num = ((!A_5) ? 1 : 0) * 10 + 229;
			A_0 = num;
		}

		// Token: 0x06000B69 RID: 2921 RVA: 0x00070858 File Offset: 0x0006EA58
		private static void FileOptionsDiv(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref Rigidbody A_14, ref RaiseEventOptions A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref bool A_19, ref object[] A_20, ref RaiseEventOptions A_21, ref ColorChanger A_22, ref Gradient A_23, ref bool A_24, ref Rigidbody A_25, ref RaiseEventOptions A_26, ref bool A_27, ref int A_28, ref bool A_29, ref int A_30, ref bool A_31, bool A_32, bool A_33)
		{
			A_0 = 48;
		}

		// Token: 0x06000B6A RID: 2922 RVA: 0x00070870 File Offset: 0x0006EA70
		private static void TriggerPlatforms(bool invis, bool sticky)
		{
			int num = 189;
			int num2 = 189;
			num2 = 189;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				bool flag2;
				bool flag3;
				bool flag4;
				bool flag5;
				bool flag6;
				object[] array;
				RaiseEventOptions raiseEventOptions;
				ColorChanger colorChanger;
				Gradient gradient;
				bool flag7;
				RaiseEventOptions raiseEventOptions2;
				bool flag8;
				bool flag9;
				bool flag10;
				bool flag11;
				object[] array2;
				RaiseEventOptions raiseEventOptions3;
				ColorChanger colorChanger2;
				Gradient gradient2;
				bool flag12;
				RaiseEventOptions raiseEventOptions4;
				bool flag13;
				int num4;
				bool flag14;
				int num5;
				bool flag15;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Object[]&,Photon.Realtime.RaiseEventOptions&,ShibaGTTemplate.Utilities.ColorChanger&,UnityEngine.Gradient&,System.Boolean&,Photon.Realtime.RaiseEventOptions&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Object[]&,Photon.Realtime.RaiseEventOptions&,ShibaGTTemplate.Utilities.ColorChanger&,UnityEngine.Gradient&,System.Boolean&,Photon.Realtime.RaiseEventOptions&,System.Boolean&,System.Int32&,System.Boolean&,System.Int32&,System.Boolean&,System.Boolean,System.Boolean), ref num, ref num2, ref num3, ref flag, ref flag2, ref flag3, ref flag4, ref flag5, ref flag6, ref array, ref raiseEventOptions, ref colorChanger, ref gradient, ref flag7, ref raiseEventOptions2, ref flag8, ref flag9, ref flag10, ref flag11, ref array2, ref raiseEventOptions3, ref colorChanger2, ref gradient2, ref flag12, ref raiseEventOptions4, ref flag13, ref num4, ref flag14, ref num5, ref flag15, sticky, invis, plddd2.ToStringsetCompoundAceType[num]);
			}
			num2 = 189;
		}

		// Token: 0x06000B6B RID: 2923 RVA: 0x000708EC File Offset: 0x0006EAEC
		private static void DNNAtIdrefs(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref bool A_5, ref GameObject A_6)
		{
			GameObject gameObject = GameObject.CreatePrimitive(3);
			A_6 = gameObject;
			A_6.transform.localScale = new Vector3(0.025f, 0.3f, 0.4f);
			A_6.transform.localPosition = GorillaTagger.Instance.leftHandTransform.position + new Vector3(0f, -0.05f, 0f);
			A_6.transform.rotation = GorillaTagger.Instance.rightHandTransform.rotation;
			A_6.GetComponent<Renderer>().material.color = new Color32(50, 50, 50, byte.MaxValue);
			A_6.AddComponent<GorillaSurfaceOverride>().overrideIndex = 61;
			Object.Destroy(A_6, 0.025f);
			A_1 = 0;
		}

		// Token: 0x06000B6C RID: 2924 RVA: 0x00070A0C File Offset: 0x0006EC0C
		private static void GetResponseParamTypes(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			plddd2.jump_right_local.transform.localScale = plddd2.cubescale;
			plddd2.jump_right_local.transform.position = new Vector3(0f, -0.01f, 0f) + Player.Instance.rightControllerTransform.position;
			plddd2.jump_right_local.transform.rotation = Player.Instance.rightControllerTransform.rotation;
			object[] array = new object[]
			{
				new Vector3(0f, -0.01f, 0f) + Player.Instance.rightControllerTransform.position,
				Player.Instance.rightControllerTransform.rotation
			};
			A_9 = array;
			RaiseEventOptions raiseEventOptions = new RaiseEventOptions
			{
				Receivers = 0
			};
			A_10 = raiseEventOptions;
			PhotonNetwork.RaiseEvent(70, A_9, A_10, SendOptions.SendReliable);
			plddd2.once_right = true;
			plddd2.once_right_false = false;
			ColorChanger colorChanger = plddd2.jump_right_local.AddComponent<ColorChanger>();
			A_11 = colorChanger;
			Gradient gradient = new Gradient();
			A_12 = gradient;
			A_12.colorKeys = plddd2.colorKeysPlatformMonke;
			A_11.colors = A_12;
			A_11.Start();
			A_0 = 126;
		}

		// Token: 0x06000B6D RID: 2925 RVA: 0x00070BC0 File Offset: 0x0006EDC0
		public static void TriggerInvisPlatforms()
		{
			int num = 4;
			int num2 = 4;
			num2 = 4;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, plddd2.ToStringsetCompoundAceType[num]);
			}
			num2 = 4;
		}

		// Token: 0x06000B6E RID: 2926 RVA: 0x00070BF4 File Offset: 0x0006EDF4
		private static void CylinderPlatforms(bool invis, bool sticky)
		{
			int num = 150;
			int num2 = 150;
			num2 = 150;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				bool flag2;
				bool flag3;
				bool flag4;
				bool flag5;
				bool flag6;
				object[] array;
				RaiseEventOptions raiseEventOptions;
				ColorChanger colorChanger;
				Gradient gradient;
				bool flag7;
				RaiseEventOptions raiseEventOptions2;
				bool flag8;
				bool flag9;
				bool flag10;
				bool flag11;
				object[] array2;
				RaiseEventOptions raiseEventOptions3;
				ColorChanger colorChanger2;
				Gradient gradient2;
				bool flag12;
				RaiseEventOptions raiseEventOptions4;
				bool flag13;
				int num4;
				bool flag14;
				int num5;
				bool flag15;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Object[]&,Photon.Realtime.RaiseEventOptions&,ShibaGTTemplate.Utilities.ColorChanger&,UnityEngine.Gradient&,System.Boolean&,Photon.Realtime.RaiseEventOptions&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Object[]&,Photon.Realtime.RaiseEventOptions&,ShibaGTTemplate.Utilities.ColorChanger&,UnityEngine.Gradient&,System.Boolean&,Photon.Realtime.RaiseEventOptions&,System.Boolean&,System.Int32&,System.Boolean&,System.Int32&,System.Boolean&,System.Boolean,System.Boolean), ref num, ref num2, ref num3, ref flag, ref flag2, ref flag3, ref flag4, ref flag5, ref flag6, ref array, ref raiseEventOptions, ref colorChanger, ref gradient, ref flag7, ref raiseEventOptions2, ref flag8, ref flag9, ref flag10, ref flag11, ref array2, ref raiseEventOptions3, ref colorChanger2, ref gradient2, ref flag12, ref raiseEventOptions4, ref flag13, ref num4, ref flag14, ref num5, ref flag15, sticky, invis, plddd2.ToStringsetCompoundAceType[num]);
			}
			num2 = 150;
		}

		// Token: 0x06000B6F RID: 2927 RVA: 0x00070C70 File Offset: 0x0006EE70
		private static void Minutemowned(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			plddd2.jump_right_local.GetComponent<Renderer>().material.SetColor("_Color", Color.black);
			A_8 = A_31;
			int num = ((!A_8) ? 1 : 0) * 1 + 158;
			A_0 = num;
		}

		// Token: 0x06000B70 RID: 2928 RVA: 0x00070CEC File Offset: 0x0006EEEC
		public static void CubePlatforms()
		{
			int num = 11;
			int num2 = 11;
			num2 = 11;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, plddd2.ToStringsetCompoundAceType[num]);
			}
			num2 = 11;
		}

		// Token: 0x06000B71 RID: 2929 RVA: 0x00070D24 File Offset: 0x0006EF24
		private static void AssemblyEvidenceFactoryAssemblyVersionAttribute(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			int num = (plddd2.once_right ? 1 : 0) * 1 + 113;
			A_0 = num;
		}

		// Token: 0x06000B72 RID: 2930 RVA: 0x00070D68 File Offset: 0x0006EF68
		private static void PopipopUnregisterDynamicProperty(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			Object.Destroy(plddd2.jump_left_network[A_28]);
			int num = A_28 + 1;
			A_28 = num;
			bool flag = A_28 < plddd2.jump_left_network.Length;
			A_29 = flag;
			int num2 = (A_29 ? 1 : 0) * -2 + 265;
			A_0 = num2;
		}

		// Token: 0x06000B73 RID: 2931 RVA: 0x00070E08 File Offset: 0x0006F008
		private static void HideBySigIDENTITYATTRIBUTE(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			Object.Destroy(plddd2.jump_right_local.GetComponent<Renderer>());
			plddd2.jump_right_local.transform.localScale = plddd2.scale;
			plddd2.jump_right_local.transform.position = new Vector3(0f, -0.01f, 0f) + Player.Instance.rightControllerTransform.position;
			plddd2.jump_right_local.transform.rotation = Player.Instance.rightControllerTransform.rotation;
			object[] array = new object[]
			{
				new Vector3(0f, -0.01f, 0f) + Player.Instance.rightControllerTransform.position,
				Player.Instance.rightControllerTransform.rotation
			};
			A_9 = array;
			RaiseEventOptions raiseEventOptions = new RaiseEventOptions
			{
				Receivers = 0
			};
			A_10 = raiseEventOptions;
			PhotonNetwork.RaiseEvent(70, A_9, A_10, SendOptions.SendReliable);
			plddd2.once_right = true;
			plddd2.once_right_false = false;
			ColorChanger colorChanger = plddd2.jump_right_local.AddComponent<ColorChanger>();
			A_11 = colorChanger;
			Gradient gradient = new Gradient();
			A_12 = gradient;
			A_12.colorKeys = plddd2.colorKeysPlatformMonke;
			A_11.colors = A_12;
			A_11.Start();
			A_0 = 87;
		}

		// Token: 0x06000B74 RID: 2932 RVA: 0x00070FCC File Offset: 0x0006F1CC
		private static void IOExceptionCMSTIMEUNITTYPEMONTHS(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			Object.Destroy(plddd2.jump_left_local);
			plddd2.jump_left_local = null;
			plddd2.once_left = false;
			plddd2.once_left_false = true;
			RaiseEventOptions raiseEventOptions = new RaiseEventOptions
			{
				Receivers = 0
			};
			A_24 = raiseEventOptions;
			PhotonNetwork.RaiseEvent(71, null, A_24, SendOptions.SendReliable);
			bool flag = !PhotonNetwork.InRoom;
			A_25 = flag;
			int num = ((!A_25) ? 1 : 0) * 7 + 220;
			A_0 = num;
		}

		// Token: 0x06000B75 RID: 2933 RVA: 0x00071090 File Offset: 0x0006F290
		private static void ElementCountParallelInvokeEnd(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			bool flag = false;
			A_13 = flag;
			int num = ((!A_13) ? 1 : 0) * 1 + 164;
			A_0 = num;
		}

		// Token: 0x06000B76 RID: 2934 RVA: 0x000710EC File Offset: 0x0006F2EC
		private static void ParallelLoopBeginImportAsArm(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			A_0 = 87;
		}

		// Token: 0x06000B77 RID: 2935 RVA: 0x00071104 File Offset: 0x0006F304
		private static void ToSingleOperationStarted(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			plddd2.jump_right_local.transform.localScale = plddd2.spherescale;
			plddd2.jump_right_local.transform.position = new Vector3(0f, -0.01f, 0f) + Player.Instance.rightControllerTransform.position;
			plddd2.jump_right_local.transform.rotation = Player.Instance.rightControllerTransform.rotation;
			object[] array = new object[]
			{
				new Vector3(0f, -0.01f, 0f) + Player.Instance.rightControllerTransform.position,
				Player.Instance.rightControllerTransform.rotation
			};
			A_9 = array;
			RaiseEventOptions raiseEventOptions = new RaiseEventOptions
			{
				Receivers = 0
			};
			A_10 = raiseEventOptions;
			PhotonNetwork.RaiseEvent(70, A_9, A_10, SendOptions.SendReliable);
			plddd2.once_right = true;
			plddd2.once_right_false = false;
			ColorChanger colorChanger = plddd2.jump_right_local.AddComponent<ColorChanger>();
			A_11 = colorChanger;
			Gradient gradient = new Gradient();
			A_12 = gradient;
			A_12.colorKeys = plddd2.colorKeysPlatformMonke;
			A_11.colors = A_12;
			A_11.Start();
			A_0 = 243;
		}

		// Token: 0x06000B78 RID: 2936 RVA: 0x000712B8 File Offset: 0x0006F4B8
		private static void FullNameListDirectory(ref int A_0, ref int A_1, ref int A_2)
		{
			plddd2.CubePlatforms(false, false);
			A_1 = 0;
		}

		// Token: 0x06000B79 RID: 2937 RVA: 0x000712E0 File Offset: 0x0006F4E0
		private static void getInnerExceptionsGetAttribute(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			A_17 = A_30;
			int num = ((!A_17) ? 1 : 0) * 1 + 209;
			A_0 = num;
		}

		// Token: 0x06000B7A RID: 2938 RVA: 0x0007133C File Offset: 0x0006F53C
		private static void setPerMilleSymbolManifestBuilder(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			int num = 0;
			A_28 = num;
			A_0 = 108;
		}

		// Token: 0x06000B7B RID: 2939 RVA: 0x0007136C File Offset: 0x0006F56C
		private static void getIsCompliantEventWrittenEventArgs(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			plddd2.jump_right_local = GameObject.CreatePrimitive(0);
			A_0 = 79;
		}

		// Token: 0x06000B7C RID: 2940 RVA: 0x00071394 File Offset: 0x0006F594
		private static void setChannelUrisStackFrameHelper(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			Object.Destroy(plddd2.jump_left_local);
			plddd2.jump_left_local = null;
			plddd2.once_left = false;
			plddd2.once_left_false = true;
			RaiseEventOptions raiseEventOptions = new RaiseEventOptions
			{
				Receivers = 0
			};
			A_24 = raiseEventOptions;
			PhotonNetwork.RaiseEvent(71, null, A_24, SendOptions.SendReliable);
			bool flag = !PhotonNetwork.InRoom;
			A_25 = flag;
			int num = ((!A_25) ? 1 : 0) * 7 + 181;
			A_0 = num;
		}

		// Token: 0x06000B7D RID: 2941 RVA: 0x00071458 File Offset: 0x0006F658
		private static void IValueTupleInternalsetInitialLeaseTime(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			Object.Destroy(plddd2.jump_right_local);
			plddd2.jump_right_local = null;
			plddd2.once_right = false;
			plddd2.once_right_false = true;
			RaiseEventOptions raiseEventOptions = new RaiseEventOptions
			{
				Receivers = 0
			};
			A_14 = raiseEventOptions;
			PhotonNetwork.RaiseEvent(72, null, A_14, SendOptions.SendReliable);
			bool flag = A_4;
			A_15 = flag;
			int num = ((!A_15) ? 1 : 0) * 10 + 205;
			A_0 = num;
		}

		// Token: 0x06000B7E RID: 2942 RVA: 0x0007151C File Offset: 0x0006F71C
		private static void messageInformationalVersion(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			plddd2.jump_right_local.transform.localScale = plddd2.scale;
			plddd2.jump_right_local.transform.position = new Vector3(0f, -0.01f, 0f) + Player.Instance.rightControllerTransform.position;
			plddd2.jump_right_local.transform.rotation = Player.Instance.rightControllerTransform.rotation;
			object[] array = new object[]
			{
				new Vector3(0f, -0.01f, 0f) + Player.Instance.rightControllerTransform.position,
				Player.Instance.rightControllerTransform.rotation
			};
			A_9 = array;
			RaiseEventOptions raiseEventOptions = new RaiseEventOptions
			{
				Receivers = 0
			};
			A_10 = raiseEventOptions;
			PhotonNetwork.RaiseEvent(70, A_9, A_10, SendOptions.SendReliable);
			plddd2.once_right = true;
			plddd2.once_right_false = false;
			ColorChanger colorChanger = plddd2.jump_right_local.AddComponent<ColorChanger>();
			A_11 = colorChanger;
			Gradient gradient = new Gradient();
			A_12 = gradient;
			A_12.colorKeys = plddd2.colorKeysPlatformMonke;
			A_11.colors = A_12;
			A_11.Start();
			A_0 = 204;
		}

		// Token: 0x06000B7F RID: 2943 RVA: 0x000716D0 File Offset: 0x0006F8D0
		private static void InvalidCultureIdBrowserBack(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			bool flag = plddd2.jump_left_local == null;
			A_16 = flag;
			int num = ((!A_16) ? 1 : 0) * 6 + 169;
			A_0 = num;
		}

		// Token: 0x06000B80 RID: 2944 RVA: 0x00071738 File Offset: 0x0006F938
		private static void UIPermissionDependentOSMetadataServicePackMinor(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			A_7 = A_30;
			int num = ((!A_7) ? 1 : 0) * 1 + 116;
			A_0 = num;
		}

		// Token: 0x06000B81 RID: 2945 RVA: 0x00071794 File Offset: 0x0006F994
		private static void SEPPmBgeUn(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			int num = (plddd2.once_right_false ? 1 : 0) * 1 + 123;
			A_0 = num;
		}

		// Token: 0x06000B82 RID: 2946 RVA: 0x000717D8 File Offset: 0x0006F9D8
		private static void SystemAclPresentgetIsCaseInsensitive(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			Object.Destroy(plddd2.jump_right_network[A_26]);
			int num = A_26 + 1;
			A_26 = num;
			bool flag = A_26 < plddd2.jump_right_network.Length;
			A_27 = flag;
			int num2 = (A_27 ? 1 : 0) * -2 + 184;
			A_0 = num2;
		}

		// Token: 0x06000B83 RID: 2947 RVA: 0x00071878 File Offset: 0x0006FA78
		private static void AliasRightToLeftArabic(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			plddd2.jump_left_local.transform.localScale = plddd2.scale;
			plddd2.jump_left_local.transform.position = new Vector3(0f, -0.01f, 0f) + Player.Instance.leftControllerTransform.position;
			plddd2.jump_left_local.transform.rotation = Player.Instance.leftControllerTransform.rotation;
			object[] array = new object[]
			{
				new Vector3(0f, -0.01f, 0f) + Player.Instance.leftControllerTransform.position,
				Player.Instance.leftControllerTransform.rotation
			};
			A_19 = array;
			RaiseEventOptions raiseEventOptions = new RaiseEventOptions
			{
				Receivers = 0
			};
			A_20 = raiseEventOptions;
			PhotonNetwork.RaiseEvent(69, A_19, A_20, SendOptions.SendReliable);
			plddd2.once_left = true;
			plddd2.once_left_false = false;
			ColorChanger colorChanger = plddd2.jump_left_local.AddComponent<ColorChanger>();
			A_21 = colorChanger;
			Gradient gradient = new Gradient();
			A_22 = gradient;
			A_22.colorKeys = plddd2.colorKeysPlatformMonke;
			A_21.colors = A_22;
			A_21.Start();
			A_0 = 102;
		}

		// Token: 0x06000B84 RID: 2948 RVA: 0x00071A2C File Offset: 0x0006FC2C
		private static void InvalidFilterCriteriaExceptionSuiteName(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			int num = 0;
			A_26 = num;
			A_0 = 222;
		}

		// Token: 0x06000B85 RID: 2949 RVA: 0x00071A5C File Offset: 0x0006FC5C
		private static void LdelemRDisallowBindingRedirects(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			plddd2.jump_left_local.GetComponent<Renderer>().material.SetColor("_Color", Color.black);
			A_18 = A_31;
			int num = ((!A_18) ? 1 : 0) * 1 + 173;
			A_0 = num;
		}

		// Token: 0x06000B86 RID: 2950 RVA: 0x00071AD8 File Offset: 0x0006FCD8
		private static void SafeDirectoriesSpaceSeparator()
		{
			plddd2.ToStringsetCompoundAceType = new IntPtr[269];
			plddd2.ToStringsetCompoundAceType[0] = ldftn(cbSizeVftflushStream);
			plddd2.ToStringsetCompoundAceType[1] = ldftn(DXYMTypeNameBuilder);
			plddd2.ToStringsetCompoundAceType[2] = ldftn(InlineTypeEndInvoke);
			plddd2.ToStringsetCompoundAceType[3] = ldftn(GetEffectiveDateStringgetErrors);
			plddd2.ToStringsetCompoundAceType[4] = ldftn(getPersistKeyInCspFormatStubInfo);
			plddd2.ToStringsetCompoundAceType[5] = ldftn(IDispatchGetFieldOffset);
			plddd2.ToStringsetCompoundAceType[6] = ldftn(ComEventsHelperOAVariantLib);
			plddd2.ToStringsetCompoundAceType[7] = ldftn(UnsafeValueTypeAttributeSetLastWriteTime);
			plddd2.ToStringsetCompoundAceType[8] = ldftn(EnumConnectionPointsIVector);
			plddd2.ToStringsetCompoundAceType[9] = ldftn(IsSupportedTraceGuidQueryProcess);
			plddd2.ToStringsetCompoundAceType[10] = ldftn(addDomainUnloadAssemblyHash);
			plddd2.ToStringsetCompoundAceType[11] = ldftn(FullNameListDirectory);
			plddd2.ToStringsetCompoundAceType[12] = ldftn(IsByValueIsEmpty);
			plddd2.ToStringsetCompoundAceType[13] = ldftn(DESCKINDMAXGetDayName);
			plddd2.ToStringsetCompoundAceType[14] = ldftn(SetWinContextInIDispatchAttributewReserved);
			plddd2.ToStringsetCompoundAceType[15] = ldftn(getIterationCountCMSENTRYPOINTFLAGCUSTOMUX);
			plddd2.ToStringsetCompoundAceType[16] = ldftn(HasCustomAttributeHashReference);
			plddd2.ToStringsetCompoundAceType[17] = ldftn(WriteAllLinesOverflowException);
			plddd2.ToStringsetCompoundAceType[18] = ldftn(ModesetUnmanagedCode);
			plddd2.ToStringsetCompoundAceType[19] = ldftn(IMembershipConditionSystemX);
			plddd2.ToStringsetCompoundAceType[20] = ldftn(AssemblyKeyNameAttributeProgressStatics);
			plddd2.ToStringsetCompoundAceType[21] = ldftn(DNNAtIdrefs);
			plddd2.ToStringsetCompoundAceType[22] = ldftn(DirectoryNameIsLeapYear);
			plddd2.ToStringsetCompoundAceType[23] = ldftn(GetFilterAsTupledIssuer);
			plddd2.ToStringsetCompoundAceType[24] = ldftn(CLRSurrogateEntryFieldIdgetTwoLetterISOLanguageName);
			plddd2.ToStringsetCompoundAceType[25] = ldftn(UnixInstantiationArgs);
			plddd2.ToStringsetCompoundAceType[26] = ldftn(IsInitializedwCode);
			plddd2.ToStringsetCompoundAceType[27] = ldftn(BindableIterableToEnumerableAdapterICustomMarshaler);
			plddd2.ToStringsetCompoundAceType[28] = ldftn(TimeZoneResourceFallbackCulture);
			plddd2.ToStringsetCompoundAceType[29] = ldftn(FUsesGetLastErrorChineseEra);
			plddd2.ToStringsetCompoundAceType[30] = ldftn(FullTrustListAssembliesInGacBigEndianUnicode);
			plddd2.ToStringsetCompoundAceType[31] = ldftn(IReferenceAppIdPositiveInfinitySymbol);
			plddd2.ToStringsetCompoundAceType[32] = ldftn(FUNCFLAGFBINDABLEFindInterfaces);
			plddd2.ToStringsetCompoundAceType[33] = ldftn(KgetFlags);
			plddd2.ToStringsetCompoundAceType[34] = ldftn(VTLPSTRIIDIEnumSTOREDEPLOYMENTMETADATAPROPERTY);
			plddd2.ToStringsetCompoundAceType[35] = ldftn(SkipSecurityChecksTaskContinuation);
			plddd2.ToStringsetCompoundAceType[36] = ldftn(getShouldExitCurrentIterationgetAsDispatch);
			plddd2.ToStringsetCompoundAceType[37] = ldftn(addContractFailedProgramFiles);
			plddd2.ToStringsetCompoundAceType[38] = ldftn(IdentityReferenceContextAttributeEntry);
			plddd2.ToStringsetCompoundAceType[39] = ldftn(AssertIsSoapActionValidForMethodBase);
			plddd2.ToStringsetCompoundAceType[40] = ldftn(getCanTransformMultipleBlocksKeyPair);
			plddd2.ToStringsetCompoundAceType[41] = ldftn(getStreamingContextStackFrameHelper);
			plddd2.ToStringsetCompoundAceType[42] = ldftn(XsdStringAssemblyVersionAttribute);
			plddd2.ToStringsetCompoundAceType[43] = ldftn(FileOptionsDiv);
			plddd2.ToStringsetCompoundAceType[44] = ldftn(LeaseLifeTimeServicePropertyHeaderVersionNumber);
			plddd2.ToStringsetCompoundAceType[45] = ldftn(CurrentlyExecutingTaskCountgetInstance);
			plddd2.ToStringsetCompoundAceType[46] = ldftn(WalkFreeListResultGetSourceLineInfoDelegate);
			plddd2.ToStringsetCompoundAceType[47] = ldftn(getObjectUrlStageComponentFile);
			plddd2.ToStringsetCompoundAceType[48] = ldftn(PulseAllGetMaxThreads);
			plddd2.ToStringsetCompoundAceType[49] = ldftn(getDenySetInstanceDateTime);
			plddd2.ToStringsetCompoundAceType[50] = ldftn(TlsContentsgetInstantiationArgs);
			plddd2.ToStringsetCompoundAceType[51] = ldftn(TryPopBlockLongPaths);
			plddd2.ToStringsetCompoundAceType[52] = ldftn(YearMonthDurationMethodRental);
			plddd2.ToStringsetCompoundAceType[53] = ldftn(GetUserStoreForAssemblygetIsIn);
			plddd2.ToStringsetCompoundAceType[54] = ldftn(GetNextTextElementstringBuilder);
			plddd2.ToStringsetCompoundAceType[55] = ldftn(LocalSigSEPMonthSuff);
			plddd2.ToStringsetCompoundAceType[56] = ldftn(FlowControlgetShadowCopyFiles);
			plddd2.ToStringsetCompoundAceType[57] = ldftn(VersionStringInlineField);
			plddd2.ToStringsetCompoundAceType[58] = ldftn(ReadIntGetFileNames);
			plddd2.ToStringsetCompoundAceType[59] = ldftn(PhonesetControlDomainPolicy);
			plddd2.ToStringsetCompoundAceType[60] = ldftn(EnableEditAndContinueSupportsDynamicPartitions);
			plddd2.ToStringsetCompoundAceType[61] = ldftn(getActivityIdDocumentType);
			plddd2.ToStringsetCompoundAceType[62] = ldftn(ProgIdGetTokenFor);
			plddd2.ToStringsetCompoundAceType[63] = ldftn(ActionCModOpt);
			plddd2.ToStringsetCompoundAceType[64] = ldftn(ReRegisterForFinalizeAlways);
			plddd2.ToStringsetCompoundAceType[65] = ldftn(LowercaseLetterIObjectHandle);
			plddd2.ToStringsetCompoundAceType[66] = ldftn(SoapIdrefReadSubTree);
			plddd2.ToStringsetCompoundAceType[67] = ldftn(ImportedFromTypeLibAttributeTrySetResult);
			plddd2.ToStringsetCompoundAceType[68] = ldftn(MonitoringTotalAllocatedMemorySizeAssemblyRequestpermissionSetID);
			plddd2.ToStringsetCompoundAceType[69] = ldftn(ConsoleCancelEventHandlerJ);
			plddd2.ToStringsetCompoundAceType[70] = ldftn(TokenElevationUnicodeClass);
			plddd2.ToStringsetCompoundAceType[71] = ldftn(GetStringBuilderVTFILETIME);
			plddd2.ToStringsetCompoundAceType[72] = ldftn(TypeIdentifierAttributeAlways);
			plddd2.ToStringsetCompoundAceType[73] = ldftn(GetExceptionForHRContractClassForAttribute);
			plddd2.ToStringsetCompoundAceType[74] = ldftn(SizeParamIndexCurrency);
			plddd2.ToStringsetCompoundAceType[75] = ldftn(ThreadTransferReceivegetRng);
			plddd2.ToStringsetCompoundAceType[76] = ldftn(TypeLibVarFlagsDelegateEntry);
			plddd2.ToStringsetCompoundAceType[77] = ldftn(getIsCompliantEventWrittenEventArgs);
			plddd2.ToStringsetCompoundAceType[78] = ldftn(ProduceLegacyHmacValuesMinValue);
			plddd2.ToStringsetCompoundAceType[79] = ldftn(BuiltinBackupOperatorsSidObjectUser);
			plddd2.ToStringsetCompoundAceType[80] = ldftn(HideBySigIDENTITYATTRIBUTE);
			plddd2.ToStringsetCompoundAceType[81] = ldftn(EmptyStructBgt);
			plddd2.ToStringsetCompoundAceType[82] = ldftn(ParallelLoopBeginImportAsArm);
			plddd2.ToStringsetCompoundAceType[83] = ldftn(HexNumberBneUnS);
			plddd2.ToStringsetCompoundAceType[84] = ldftn(EnableGenericFieldInfo);
			plddd2.ToStringsetCompoundAceType[85] = ldftn(AddEventHandlerMemoryBarrier);
			plddd2.ToStringsetCompoundAceType[86] = ldftn(MediaStopgetSetMethod);
			plddd2.ToStringsetCompoundAceType[87] = ldftn(getScheduledExclusiveMatchAllVersions);
			plddd2.ToStringsetCompoundAceType[88] = ldftn(ICspAsymmetricAlgorithmTextToDefinition);
			plddd2.ToStringsetCompoundAceType[89] = ldftn(DefineDefaultConstructorICustomProperty);
			plddd2.ToStringsetCompoundAceType[90] = ldftn(ConstructionResponseINVOCATIONFLAGSISCTOR);
			plddd2.ToStringsetCompoundAceType[91] = ldftn(CreateProxyInitialize);
			plddd2.ToStringsetCompoundAceType[92] = ldftn(YearMonthDurationPow);
			plddd2.ToStringsetCompoundAceType[93] = ldftn(getDateStartNoFailureLog);
			plddd2.ToStringsetCompoundAceType[94] = ldftn(NamesApplicationDirectory);
			plddd2.ToStringsetCompoundAceType[95] = ldftn(CreateFilesSafeLsaPolicyHandle);
			plddd2.ToStringsetCompoundAceType[96] = ldftn(AliasRightToLeftArabic);
			plddd2.ToStringsetCompoundAceType[97] = ldftn(ContinueWhenAllgetIsServerGC);
			plddd2.ToStringsetCompoundAceType[98] = ldftn(LocalDataStoreHoldergetAssemblyIsPrivate);
			plddd2.ToStringsetCompoundAceType[99] = ldftn(IsWeakKeyLocalFindAndPop);
			plddd2.ToStringsetCompoundAceType[100] = ldftn(NeutralResourcesLanguageAttributegetUsedSize);
			plddd2.ToStringsetCompoundAceType[101] = ldftn(SetCurrentDirectorygetCurrentSize);
			plddd2.ToStringsetCompoundAceType[102] = ldftn(ReferenceMatchesDefinitionSystemThreadingSpinLockDebugView);
			plddd2.ToStringsetCompoundAceType[103] = ldftn(EraTokenGetUserStoreForAssembly);
			plddd2.ToStringsetCompoundAceType[104] = ldftn(MachineKeysetAsyncProcessMessage);
			plddd2.ToStringsetCompoundAceType[105] = ldftn(MinorGetActivationContextData);
			plddd2.ToStringsetCompoundAceType[106] = ldftn(setPerMilleSymbolManifestBuilder);
			plddd2.ToStringsetCompoundAceType[107] = ldftn(ToStringHelperFuncStoreListValid);
			plddd2.ToStringsetCompoundAceType[108] = ldftn(IStringableTags);
			plddd2.ToStringsetCompoundAceType[109] = ldftn(RSACspObjectMonthGenitiveNames);
			plddd2.ToStringsetCompoundAceType[110] = ldftn(pValueUnmanagedExport);
			plddd2.ToStringsetCompoundAceType[111] = ldftn(IMetadataSectionEntrySECURITYLOGONSESSIONDATA);
			plddd2.ToStringsetCompoundAceType[112] = ldftn(AssemblyEvidenceFactoryAssemblyVersionAttribute);
			plddd2.ToStringsetCompoundAceType[113] = ldftn(IsConstructedGenericTypeBinaryCrossAppDomainAssembly);
			plddd2.ToStringsetCompoundAceType[114] = ldftn(MultiDomainHostsetKeyPassword);
			plddd2.ToStringsetCompoundAceType[115] = ldftn(UIPermissionDependentOSMetadataServicePackMinor);
			plddd2.ToStringsetCompoundAceType[116] = ldftn(HashMembershipConditiongetRegistryKeySection);
			plddd2.ToStringsetCompoundAceType[117] = ldftn(GetAvailableThreadsConstArray);
			plddd2.ToStringsetCompoundAceType[118] = ldftn(GetShortestDayNamegetKeyName);
			plddd2.ToStringsetCompoundAceType[119] = ldftn(EventSourceExceptionAnyScheme);
			plddd2.ToStringsetCompoundAceType[120] = ldftn(GetResponseParamTypes);
			plddd2.ToStringsetCompoundAceType[121] = ldftn(getFallbackBufferSEPTime);
			plddd2.ToStringsetCompoundAceType[122] = ldftn(SEPPmBgeUn);
			plddd2.ToStringsetCompoundAceType[123] = ldftn(MemberGetSize);
			plddd2.ToStringsetCompoundAceType[124] = ldftn(GetMethodFromDocumentPositionIndexRange);
			plddd2.ToStringsetCompoundAceType[125] = ldftn(WinapiCategoryMembershipDataDescription);
			plddd2.ToStringsetCompoundAceType[126] = ldftn(setUserQuotaIVectorViewToIReadOnlyListAdapter);
			plddd2.ToStringsetCompoundAceType[127] = ldftn(removeAssemblyLoadUrlAttribute);
			plddd2.ToStringsetCompoundAceType[128] = ldftn(workStealingQueuePKCSMaskGenerationMethod);
			plddd2.ToStringsetCompoundAceType[129] = ldftn(funckindPARSEDISPLAYNAME);
			plddd2.ToStringsetCompoundAceType[130] = ldftn(VariantBoolPrecondition);
			plddd2.ToStringsetCompoundAceType[131] = ldftn(SqrtMuiResourceTypeIdIntIntegerIds);
			plddd2.ToStringsetCompoundAceType[132] = ldftn(CancellationTokenRegistrationQueue);
			plddd2.ToStringsetCompoundAceType[133] = ldftn(getFeedbackSizesetOrder);
			plddd2.ToStringsetCompoundAceType[134] = ldftn(StringMakergetDeniedPermissions);
			plddd2.ToStringsetCompoundAceType[135] = ldftn(AddResourceFileAdjustGroups);
			plddd2.ToStringsetCompoundAceType[136] = ldftn(StaticArrayInitTypeSizeGuidStyles);
			plddd2.ToStringsetCompoundAceType[137] = ldftn(NativeRegisterRegisterRefresh);
			plddd2.ToStringsetCompoundAceType[138] = ldftn(DescriptionMetadataPublisherCurrentCount);
			plddd2.ToStringsetCompoundAceType[139] = ldftn(ChildsetChannelData);
			plddd2.ToStringsetCompoundAceType[140] = ldftn(IsInvalidNumberKeyHandle);
			plddd2.ToStringsetCompoundAceType[141] = ldftn(EphemeralKeySetsetCultureInfo);
			plddd2.ToStringsetCompoundAceType[142] = ldftn(EventAttributeremoveModuleResolve);
			plddd2.ToStringsetCompoundAceType[143] = ldftn(TwoLetterISOLanguageNameByteEqualityComparer);
			plddd2.ToStringsetCompoundAceType[144] = ldftn(EventBuilderObjectWithMapTyped);
			plddd2.ToStringsetCompoundAceType[145] = ldftn(MonitoringTotalProcessorTimeControlBreak);
			plddd2.ToStringsetCompoundAceType[146] = ldftn(MetadataSectionRequestedExecutionLevelmetwSessionId);
			plddd2.ToStringsetCompoundAceType[147] = ldftn(CountersignatureGetMinThreads);
			plddd2.ToStringsetCompoundAceType[148] = ldftn(VtableLayoutMaskConvertPermissionSet);
			plddd2.ToStringsetCompoundAceType[149] = ldftn(CMSSECTIONIDASSEMBLYREQUESTSECTIONgetCompatibleFrameworksData);
			plddd2.ToStringsetCompoundAceType[150] = ldftn(MinBinaryLengthAddProperty);
			plddd2.ToStringsetCompoundAceType[151] = ldftn(DXDSNAppDomainInitializerArguments);
			plddd2.ToStringsetCompoundAceType[152] = ldftn(NetworkShortcutsTryPopRange);
			plddd2.ToStringsetCompoundAceType[153] = ldftn(AssemblyReferenceEntryFieldIdGetMonth);
			plddd2.ToStringsetCompoundAceType[154] = ldftn(getSequencePointCountgetAsUint);
			plddd2.ToStringsetCompoundAceType[155] = ldftn(CapsLockModeJIS);
			plddd2.ToStringsetCompoundAceType[156] = ldftn(CustomAttributeDataCeiling);
			plddd2.ToStringsetCompoundAceType[157] = ldftn(Minutemowned);
			plddd2.ToStringsetCompoundAceType[158] = ldftn(getIsLayoutSequentialNative);
			plddd2.ToStringsetCompoundAceType[159] = ldftn(SecurityDocumentASSEMBLYFLAGSSAFEREFLECTION);
			plddd2.ToStringsetCompoundAceType[160] = ldftn(ConfigNodeServerIdentityObject);
			plddd2.ToStringsetCompoundAceType[161] = ldftn(getIsSecuritySafeCriticalPermissionSetTriple);
			plddd2.ToStringsetCompoundAceType[162] = ldftn(HostProtectionResourceObjectComparer);
			plddd2.ToStringsetCompoundAceType[163] = ldftn(ElementCountParallelInvokeEnd);
			plddd2.ToStringsetCompoundAceType[164] = ldftn(GlobalResourceContextBestFitCultureInfoDaylightTransitionEnd);
			plddd2.ToStringsetCompoundAceType[165] = ldftn(GetEventTokenResourceManagerCultureFoundInConfigFile);
			plddd2.ToStringsetCompoundAceType[166] = ldftn(CCMPWCDECLBeginInvoke);
			plddd2.ToStringsetCompoundAceType[167] = ldftn(InvalidCultureIdBrowserBack);
			plddd2.ToStringsetCompoundAceType[168] = ldftn(TokenHasRestrictionsISecurityEncodable);
			plddd2.ToStringsetCompoundAceType[169] = ldftn(PushiLoopTimer);
			plddd2.ToStringsetCompoundAceType[170] = ldftn(FUNCNONVIRTUALHasFlag);
			plddd2.ToStringsetCompoundAceType[171] = ldftn(DelegateBindingFlagsgetEnvoyInfo);
			plddd2.ToStringsetCompoundAceType[172] = ldftn(LdelemRDisallowBindingRedirects);
			plddd2.ToStringsetCompoundAceType[173] = ldftn(getIsFamilyGetSigOfMethodDef);
			plddd2.ToStringsetCompoundAceType[174] = ldftn(CalendricalCalculationsHelperGetValueKind);
			plddd2.ToStringsetCompoundAceType[175] = ldftn(TrustManagerContextLastImmediateValue);
			plddd2.ToStringsetCompoundAceType[176] = ldftn(RegistryValueOptionsProgIdRedirectionEntry);
			plddd2.ToStringsetCompoundAceType[177] = ldftn(SetLocalSignatureSzArray);
			plddd2.ToStringsetCompoundAceType[178] = ldftn(getCdfIdentityOnSerializedAttribute);
			plddd2.ToStringsetCompoundAceType[179] = ldftn(setChannelUrisStackFrameHelper);
			plddd2.ToStringsetCompoundAceType[180] = ldftn(IMPLTYPEFLAGFDEFAULTgetDeclaredConstructors);
			plddd2.ToStringsetCompoundAceType[181] = ldftn(UsersTrySetApartmentState);
			plddd2.ToStringsetCompoundAceType[182] = ldftn(SystemAclPresentgetIsCaseInsensitive);
			plddd2.ToStringsetCompoundAceType[183] = ldftn(getStoreExecuteSynchronously);
			plddd2.ToStringsetCompoundAceType[184] = ldftn(InternalMemberValueEReferenceCountValue);
			plddd2.ToStringsetCompoundAceType[185] = ldftn(GetFileNameWithoutExtensionMonthDatesep);
			plddd2.ToStringsetCompoundAceType[186] = ldftn(SimpleXmlFormatgetIsDS);
			plddd2.ToStringsetCompoundAceType[187] = ldftn(DllNotFoundExceptionIsHighSurrogate);
			plddd2.ToStringsetCompoundAceType[188] = ldftn(ObjectNullCalendricalCalculationsHelper);
			plddd2.ToStringsetCompoundAceType[189] = ldftn(BeginExceptionBlockFindTokenByIndex);
			plddd2.ToStringsetCompoundAceType[190] = ldftn(TXNDelegateBindingFlags);
			plddd2.ToStringsetCompoundAceType[191] = ldftn(WaitForFullGCApproachPolicyLevel);
			plddd2.ToStringsetCompoundAceType[192] = ldftn(GetRuntimeMethodExceptionHandler);
			plddd2.ToStringsetCompoundAceType[193] = ldftn(CommandSEPDate);
			plddd2.ToStringsetCompoundAceType[194] = ldftn(NativeDigitsManagedToNativeComInteropStubAttribute);
			plddd2.ToStringsetCompoundAceType[195] = ldftn(StringInfoInlineVar);
			plddd2.ToStringsetCompoundAceType[196] = ldftn(ContractFailureKindgetDirectory);
			plddd2.ToStringsetCompoundAceType[197] = ldftn(NaNOnSerializingAttribute);
			plddd2.ToStringsetCompoundAceType[198] = ldftn(messageInformationalVersion);
			plddd2.ToStringsetCompoundAceType[199] = ldftn(CountedMbcsStringassemblyName);
			plddd2.ToStringsetCompoundAceType[200] = ldftn(IsSubsetOfTypegetPreserveEventListnerObjectIdentity);
			plddd2.ToStringsetCompoundAceType[201] = ldftn(IDLFLAGFLCIDResourceManagerCultureFoundInConfigFile);
			plddd2.ToStringsetCompoundAceType[202] = ldftn(FSourcegetVisualizerTypeName);
			plddd2.ToStringsetCompoundAceType[203] = ldftn(IValueTupleInternalsetInitialLeaseTime);
			plddd2.ToStringsetCompoundAceType[204] = ldftn(EncodedTypeConfigureAwait);
			plddd2.ToStringsetCompoundAceType[205] = ldftn(TKINDENUMDigestAlgorithm);
			plddd2.ToStringsetCompoundAceType[206] = ldftn(EscapeKeyName);
			plddd2.ToStringsetCompoundAceType[207] = ldftn(DecrementCompilerMarshalOverride);
			plddd2.ToStringsetCompoundAceType[208] = ldftn(getInnerExceptionsGetAttribute);
			plddd2.ToStringsetCompoundAceType[209] = ldftn(charPosGetAssemblyIdentity);
			plddd2.ToStringsetCompoundAceType[210] = ldftn(CanWriteCanBeOrphan);
			plddd2.ToStringsetCompoundAceType[211] = ldftn(BrowserSearchpInt);
			plddd2.ToStringsetCompoundAceType[212] = ldftn(UnobservedTaskExceptionEventArgsCharSetMask);
			plddd2.ToStringsetCompoundAceType[213] = ldftn(IStructuralEquatableIContextPropertyActivator);
			plddd2.ToStringsetCompoundAceType[214] = ldftn(SucceededgetOriginalString);
			plddd2.ToStringsetCompoundAceType[215] = ldftn(IsControlArgumentNull);
			plddd2.ToStringsetCompoundAceType[216] = ldftn(getIsFixedDateRuleStelemRef);
			plddd2.ToStringsetCompoundAceType[217] = ldftn(InverseQCheckSubKeyCreatePermission);
			plddd2.ToStringsetCompoundAceType[218] = ldftn(IOExceptionCMSTIMEUNITTYPEMONTHS);
			plddd2.ToStringsetCompoundAceType[219] = ldftn(getNamedArgumentsIsError);
			plddd2.ToStringsetCompoundAceType[220] = ldftn(InvalidFilterCriteriaExceptionSuiteName);
			plddd2.ToStringsetCompoundAceType[221] = ldftn(StindRefASCII);
			plddd2.ToStringsetCompoundAceType[222] = ldftn(LimitExceededgetSystemPageSize);
			plddd2.ToStringsetCompoundAceType[223] = ldftn(ShouldExitCurrentIterationDecoderExceptionFallbackBuffer);
			plddd2.ToStringsetCompoundAceType[224] = ldftn(GCLatencyModeDefaultIssuer);
			plddd2.ToStringsetCompoundAceType[225] = ldftn(IEntryPointEntryAssemblyEvidence);
			plddd2.ToStringsetCompoundAceType[226] = ldftn(SetParametersSetComObjectData);
			plddd2.ToStringsetCompoundAceType[227] = ldftn(CallerMemberNameAttributeMRMWrapperDictionary);
			plddd2.ToStringsetCompoundAceType[228] = ldftn(EndChildrenCallbackOriginalIssuerEqualsIssuer);
			plddd2.ToStringsetCompoundAceType[229] = ldftn(DSTrusted);
			plddd2.ToStringsetCompoundAceType[230] = ldftn(MoreDatasetHashName);
			plddd2.ToStringsetCompoundAceType[231] = ldftn(STOREASSEMBLYFILESTATUSFLAGPRESENTGetMethod);
			plddd2.ToStringsetCompoundAceType[232] = ldftn(GetGlobalVariablesFileEntry);
			plddd2.ToStringsetCompoundAceType[233] = ldftn(setNoPromptIsPrime);
			plddd2.ToStringsetCompoundAceType[234] = ldftn(SafeCspHashHandleReturnParameter);
			plddd2.ToStringsetCompoundAceType[235] = ldftn(getMembersetHostCanGenerate);
			plddd2.ToStringsetCompoundAceType[236] = ldftn(IsLetterOrDigitCallerFilePathAttribute);
			plddd2.ToStringsetCompoundAceType[237] = ldftn(ToSingleOperationStarted);
			plddd2.ToStringsetCompoundAceType[238] = ldftn(TokenGroupsIsStateAvailable);
			plddd2.ToStringsetCompoundAceType[239] = ldftn(appendNewLineSortKey);
			plddd2.ToStringsetCompoundAceType[240] = ldftn(SpecifyKindIsResource);
			plddd2.ToStringsetCompoundAceType[241] = ldftn(removeFirstChanceExceptionTypeIdentifierAttribute);
			plddd2.ToStringsetCompoundAceType[242] = ldftn(PrimitiveArrayBody);
			plddd2.ToStringsetCompoundAceType[243] = ldftn(getIsInitOnlyDarkMagenta);
			plddd2.ToStringsetCompoundAceType[244] = ldftn(PtrToStringUniSelfAffectingProcessMgmt);
			plddd2.ToStringsetCompoundAceType[245] = ldftn(cFileNameeFixedBufferAccessRule);
			plddd2.ToStringsetCompoundAceType[246] = ldftn(BinaryAssemblyInfoBootstrapContext);
			plddd2.ToStringsetCompoundAceType[247] = ldftn(AppendTextDSASignatureDescription);
			plddd2.ToStringsetCompoundAceType[248] = ldftn(ParseExactWdiDiagnostic);
			plddd2.ToStringsetCompoundAceType[249] = ldftn(EventSourceExceptionExport);
			plddd2.ToStringsetCompoundAceType[250] = ldftn(getContextIDToLower);
			plddd2.ToStringsetCompoundAceType[251] = ldftn(GetPropertySigHelperKey);
			plddd2.ToStringsetCompoundAceType[252] = ldftn(ArgsInArrayStreetAddress);
			plddd2.ToStringsetCompoundAceType[253] = ldftn(KeyNumberVTBOOL);
			plddd2.ToStringsetCompoundAceType[254] = ldftn(MarshalSecurityAttribute);
			plddd2.ToStringsetCompoundAceType[255] = ldftn(StoreOperationScavengesetSurrogateSelector);
			plddd2.ToStringsetCompoundAceType[256] = ldftn(CurrentConfigCanBeCanceled);
			plddd2.ToStringsetCompoundAceType[257] = ldftn(GetLastAccessTimegetAttributeString);
			plddd2.ToStringsetCompoundAceType[258] = ldftn(SecurityCriticalScopeTypeLibExporterFlags);
			plddd2.ToStringsetCompoundAceType[259] = ldftn(FailContinueFilterCrossMachine);
			plddd2.ToStringsetCompoundAceType[260] = ldftn(LeftWindowsgetPrivilegeName);
			plddd2.ToStringsetCompoundAceType[261] = ldftn(CMSFILEFLAGSynchronizationContextNoFlow);
			plddd2.ToStringsetCompoundAceType[262] = ldftn(MaxStackSizeTranslate);
			plddd2.ToStringsetCompoundAceType[263] = ldftn(PopipopUnregisterDynamicProperty);
			plddd2.ToStringsetCompoundAceType[264] = ldftn(EmitWriteLinePrepareDelegate);
			plddd2.ToStringsetCompoundAceType[265] = ldftn(PostconditionOnExceptionsetAsUnknown);
			plddd2.ToStringsetCompoundAceType[266] = ldftn(GetTypeAndMethodNameFromSoapActionputSubscriptionId);
			plddd2.ToStringsetCompoundAceType[267] = ldftn(StoreTransactionDataCODEBASEURL);
			plddd2.ToStringsetCompoundAceType[268] = ldftn(GetResponseFormatLiterals);
		}

		// Token: 0x040000A9 RID: 169
		public static GameObject pointer;

		// Token: 0x040000AA RID: 170
		public static Color platformcolor;

		// Token: 0x040000AB RID: 171
		private static Vector3 position;

		// Token: 0x040000AC RID: 172
		private static Vector3 cylinderscale;

		// Token: 0x040000AD RID: 173
		private static Vector3 scale;

		// Token: 0x040000AE RID: 174
		private static Vector3 cubescale;

		// Token: 0x040000AF RID: 175
		private static Vector3 spherescale;

		// Token: 0x040000B0 RID: 176
		private static bool once_left;

		// Token: 0x040000B1 RID: 177
		private static bool once_right;

		// Token: 0x040000B2 RID: 178
		private static bool once_left_false;

		// Token: 0x040000B3 RID: 179
		private static bool once_right_false;

		// Token: 0x040000B4 RID: 180
		private static GameObject[] jump_left_network;

		// Token: 0x040000B5 RID: 181
		private static GameObject[] jump_right_network;

		// Token: 0x040000B6 RID: 182
		private static GameObject jump_left_local;

		// Token: 0x040000B7 RID: 183
		private static GameObject jump_right_local;

		// Token: 0x040000B8 RID: 184
		private static GradientColorKey[] colorKeysPlatformMonke;

		// Token: 0x040000B9 RID: 185
		private static IntPtr[] ToStringsetCompoundAceType;
	}
}
