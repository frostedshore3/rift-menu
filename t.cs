using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using BepInEx;
using ExitGames.Client.Photon;
using GorillaLocomotion;
using GorillaNetworking;
using Photon.Pun;
using Photon.Realtime;
using ShibaGTTemplate.UI;
using ShibaGTTemplate.Utilities;
using UnityEngine;

namespace ShibaGTTemplate.Backend
{
	// Token: 0x02000023 RID: 35
	internal class t : MonoBehaviour
	{
		// Token: 0x06000D41 RID: 3393 RVA: 0x0008442C File Offset: 0x0008262C
		public static void WASDMovement()
		{
			int num = 31;
			int num2 = 31;
			num2 = 31;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				bool flag2;
				bool flag3;
				bool flag4;
				bool flag5;
				bool flag6;
				bool flag7;
				bool flag8;
				bool flag9;
				bool flag10;
				bool flag11;
				bool flag12;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&), ref num, ref num2, ref num3, ref flag, ref flag2, ref flag3, ref flag4, ref flag5, ref flag6, ref flag7, ref flag8, ref flag9, ref flag10, ref flag11, ref flag12, t.setRoleReleaseTLibAttr[num]);
			}
			num2 = 31;
		}

		// Token: 0x06000D42 RID: 3394 RVA: 0x0008447C File Offset: 0x0008267C
		public static void DisableNetworkTriggers()
		{
			int num = 61;
			int num2 = 61;
			num2 = 61;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, t.setRoleReleaseTLibAttr[num]);
			}
			num2 = 61;
		}

		// Token: 0x06000D43 RID: 3395 RVA: 0x000844B4 File Offset: 0x000826B4
		private static void PrimitiveValueSandboxInterop(ref int A_0, ref int A_1, ref int A_2)
		{
			BetterDayNightManager.instance.SetTimeOfDay(2);
			A_1 = 0;
		}

		// Token: 0x06000D44 RID: 3396 RVA: 0x000844E0 File Offset: 0x000826E0
		public static void ReloadMenu()
		{
			int num = 12;
			int num2 = 12;
			num2 = 12;
			while (num2 != 0)
			{
				int num3;
				float num4;
				float num5;
				bool flag;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Single&,System.Single&,System.Boolean&), ref num, ref num2, ref num3, ref num4, ref num5, ref flag, t.setRoleReleaseTLibAttr[num]);
			}
			num2 = 12;
		}

		// Token: 0x06000D45 RID: 3397 RVA: 0x0008451C File Offset: 0x0008271C
		private static void ExportedTypesIntBitsToDouble(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14)
		{
			bool key = UnityInput.Current.GetKey(274);
			A_5 = key;
			int num = (UnityInput.Current.GetKey(100) ? 1 : 0) * 1 + 38;
			A_0 = num;
		}

		// Token: 0x06000D46 RID: 3398 RVA: 0x0008458C File Offset: 0x0008278C
		public static void RainbowSnowballs()
		{
			int num = 67;
			int num2 = 67;
			num2 = 67;
			while (num2 != 0)
			{
				int num3;
				SnowballThrowable[] array;
				int num4;
				SnowballThrowable snowballThrowable;
				bool flag;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,SnowballThrowable[]&,System.Int32&,SnowballThrowable&,System.Boolean&), ref num, ref num2, ref num3, ref array, ref num4, ref snowballThrowable, ref flag, t.setRoleReleaseTLibAttr[num]);
			}
			num2 = 67;
		}

		// Token: 0x06000D47 RID: 3399 RVA: 0x000845CC File Offset: 0x000827CC
		public static void TimeDay()
		{
			int num = 109;
			int num2 = 109;
			num2 = 109;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, t.setRoleReleaseTLibAttr[num]);
			}
			num2 = 109;
		}

		// Token: 0x06000D48 RID: 3400 RVA: 0x00084604 File Offset: 0x00082804
		private static void IAPPIDAUTHORITYAREDEFINITIONSEQUALFLAGSGetValueList(ref int A_0, ref int A_1, ref int A_2, ref Hashtable A_3)
		{
			PlayerPrefs.SetString("tutorial", "true");
			Hashtable hashtable = new Hashtable();
			A_3 = hashtable;
			A_3.Add("didTutorial", true);
			PhotonNetwork.LocalPlayer.SetCustomProperties(A_3, null, null);
			A_1 = 0;
		}

		// Token: 0x06000D49 RID: 3401 RVA: 0x00084678 File Offset: 0x00082878
		public static void LongArmsZ()
		{
			int num = 87;
			int num2 = 87;
			num2 = 87;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, t.setRoleReleaseTLibAttr[num]);
			}
			num2 = 87;
		}

		// Token: 0x06000D4A RID: 3402 RVA: 0x000846B0 File Offset: 0x000828B0
		public static void CrazySlideControl()
		{
			int num = 95;
			int num2 = 95;
			num2 = 95;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, t.setRoleReleaseTLibAttr[num]);
			}
			num2 = 95;
		}

		// Token: 0x06000D4B RID: 3403 RVA: 0x000846E8 File Offset: 0x000828E8
		private static void errgetApplicationActivator(ref int A_0, ref int A_1, ref int A_2)
		{
			BetterDayNightManager.instance.SetTimeOfDay(0);
			A_1 = 0;
		}

		// Token: 0x06000D4C RID: 3404 RVA: 0x00084714 File Offset: 0x00082914
		private static void IsApplicationTrustedToRunReflectionOnly(ref int A_0, ref int A_1, ref int A_2, ref float A_3, ref float A_4, ref bool A_5)
		{
			A_1 = 0;
		}

		// Token: 0x06000D4D RID: 3405 RVA: 0x0008472C File Offset: 0x0008292C
		private static void setBufferWidthforkJoinContextID(ref int A_0, ref int A_1, ref int A_2)
		{
			PhotonNetwork.ConnectToRegion("eu");
			A_1 = 0;
		}

		// Token: 0x06000D4E RID: 3406 RVA: 0x00084750 File Offset: 0x00082950
		private static void SetMarshalGREGORIANXLITENGLISH(ref int A_0, ref int A_1, ref int A_2)
		{
			Player.Instance.transform.localScale = new Vector3(1f, 1.75f, 1f);
			A_1 = 0;
		}

		// Token: 0x06000D4F RID: 3407 RVA: 0x0008478C File Offset: 0x0008298C
		private static void SegmentIMoniker(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14)
		{
			bool key = UnityInput.Current.GetKey(305);
			A_8 = key;
			bool flag = A_3;
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 1 + 44;
			A_0 = num;
		}

		// Token: 0x06000D50 RID: 3408 RVA: 0x00084810 File Offset: 0x00082A10
		public static void SlideControlWeak()
		{
			int num = 97;
			int num2 = 97;
			num2 = 97;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, t.setRoleReleaseTLibAttr[num]);
			}
			num2 = 97;
		}

		// Token: 0x06000D51 RID: 3409 RVA: 0x00084848 File Offset: 0x00082A48
		private static void GetBooleanArrayContextStaticAttribute(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<string> A_4, ref List<ButtonInfo>.Enumerator A_5, ref ButtonInfo A_6, ref bool? A_7, ref bool A_8, ref bool A_9)
		{
			int num = (A_5.MoveNext() ? 1 : 0) * -4 + 129;
			A_0 = num;
		}

		// Token: 0x06000D52 RID: 3410 RVA: 0x00084890 File Offset: 0x00082A90
		private static void BytereadLen(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14)
		{
			Player.Instance.GetComponent<Rigidbody>().velocity += Vector3.forward * Time.deltaTime * 45f;
			bool flag = A_4;
			A_10 = flag;
			int num = ((!A_10) ? 1 : 0) * 1 + 46;
			A_0 = num;
		}

		// Token: 0x06000D53 RID: 3411 RVA: 0x00084928 File Offset: 0x00082B28
		private static void KeyContainerNameMachineName(ref int A_0, ref int A_1, ref int A_2)
		{
			Player.Instance.slideControl = 1f;
			A_1 = 0;
		}

		// Token: 0x06000D54 RID: 3412 RVA: 0x00084950 File Offset: 0x00082B50
		private static void NativeRegisterMayCorruptAppDomain(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14)
		{
			bool key = UnityInput.Current.GetKey(273);
			A_3 = key;
			int num = (UnityInput.Current.GetKey(97) ? 1 : 0) * 1 + 34;
			A_0 = num;
		}

		// Token: 0x06000D55 RID: 3413 RVA: 0x000849C0 File Offset: 0x00082BC0
		public static void SuperLongArms()
		{
			int num = 84;
			int num2 = 84;
			num2 = 84;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, t.setRoleReleaseTLibAttr[num]);
			}
			num2 = 84;
		}

		// Token: 0x06000D56 RID: 3414 RVA: 0x000849F8 File Offset: 0x00082BF8
		private static void NotImpersonatedgetSecurityContext(ref int A_0, ref int A_1, ref int A_2, ref int A_3, ref bool A_4)
		{
			int num = 0;
			A_3 = num;
			A_0 = 2;
		}

		// Token: 0x06000D57 RID: 3415 RVA: 0x00084A28 File Offset: 0x00082C28
		private static void TokenOriginCausalityTraceLevel(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14)
		{
			Player.Instance.GetComponent<Rigidbody>().velocity += Vector3.up * Time.deltaTime * 75f;
			bool flag = A_8;
			A_14 = flag;
			int num = ((!A_14) ? 1 : 0) * 1 + 54;
			A_0 = num;
		}

		// Token: 0x06000D58 RID: 3416 RVA: 0x00084AC0 File Offset: 0x00082CC0
		private static void AddressOfMemberCMSSECTIONENTRYIDMETADATA(ref int A_0, ref int A_1, ref int A_2, ref SnowballThrowable[] A_3, ref int A_4, ref SnowballThrowable A_5, ref bool A_6)
		{
			int num = A_4 + 1;
			A_4 = num;
			int num2 = ((A_4 < A_3.Length) ? 1 : 0) * -4 + 78;
			A_0 = num2;
		}

		// Token: 0x06000D59 RID: 3417 RVA: 0x00084B20 File Offset: 0x00082D20
		private static void SuppressFinalizeRemoveMethod(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GradientColorKey[] A_5, ref ColorChanger A_6, ref bool A_7, ref GameObject A_8, ref GradientColorKey[] A_9, ref ColorChanger A_10)
		{
			GameObject gameObject = GameObject.CreatePrimitive(3);
			A_8 = gameObject;
			Object.Destroy(A_8.GetComponent<BoxCollider>());
			A_8.GetComponent<Renderer>().material.shader = Shader.Find("GorillaTag/UberShader");
			A_8.transform.localScale = new Vector3(0.1f, 0.5f, 0.5f);
			A_8.transform.position = GorillaTagger.Instance.rightHandTransform.position;
			A_8.transform.rotation = GorillaTagger.Instance.rightHandTransform.rotation;
			Object.Destroy(A_8, 100f);
			PhotonNetwork.RaiseEvent(69, new object[]
			{
				A_8.transform.position,
				A_8.transform.rotation
			}, new RaiseEventOptions
			{
				Receivers = 0
			}, SendOptions.SendReliable);
			GradientColorKey[] array = new GradientColorKey[3];
			A_9 = array;
			A_9[0].color = Color.red;
			A_9[0].time = 0f;
			A_9[1].color = Color.yellow;
			A_9[1].time = 0.2f;
			A_9[2].color = Color.green;
			A_9[2].time = 0.3f;
			A_9[3].color = Color.cyan;
			A_9[3].time = 0.5f;
			A_9[4].color = Color.blue;
			A_9[4].time = 0.6f;
			A_9[5].color = Color.magenta;
			A_9[5].time = 0.8f;
			A_9[6].color = Color.red;
			A_9[6].time = 1f;
			ColorChanger colorChanger = A_8.AddComponent<ColorChanger>();
			A_10 = colorChanger;
			A_10.colors = new Gradient
			{
				colorKeys = A_9
			};
			A_10.Start();
			A_1 = 0;
		}

		// Token: 0x06000D5A RID: 3418 RVA: 0x00084E78 File Offset: 0x00083078
		public static void fpcoff()
		{
			int num = 120;
			int num2 = 120;
			num2 = 120;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&), ref num, ref num2, ref num3, ref flag, t.setRoleReleaseTLibAttr[num]);
			}
			num2 = 120;
		}

		// Token: 0x06000D5B RID: 3419 RVA: 0x00084EB0 File Offset: 0x000830B0
		private static void ArrayTypeMismatchExceptionToLongDateString(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<string> A_4, ref List<ButtonInfo>.Enumerator A_5, ref ButtonInfo A_6, ref bool? A_7, ref bool A_8, ref bool A_9)
		{
			Directory.CreateDirectory("TemplatePrefs");
			File.WriteAllLines("TemplatePrefs\\templateSavedPrefs.txt", A_4);
			A_1 = 0;
		}

		// Token: 0x06000D5C RID: 3420 RVA: 0x00084EE8 File Offset: 0x000830E8
		private static void SymDocumentTypegetElementCount(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<string> A_4, ref List<ButtonInfo>.Enumerator A_5, ref ButtonInfo A_6, ref bool? A_7, ref bool A_8, ref bool A_9)
		{
			A_0 = 128;
		}

		// Token: 0x06000D5D RID: 3421 RVA: 0x00084F00 File Offset: 0x00083100
		public static void PencilDrawSphere()
		{
			int num = 16;
			int num2 = 16;
			num2 = 16;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				GameObject gameObject;
				GradientColorKey[] array;
				ColorChanger colorChanger;
				bool flag2;
				GameObject gameObject2;
				GradientColorKey[] array2;
				ColorChanger colorChanger2;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,UnityEngine.GameObject&,UnityEngine.GradientColorKey[]&,ShibaGTTemplate.Utilities.ColorChanger&,System.Boolean&,UnityEngine.GameObject&,UnityEngine.GradientColorKey[]&,ShibaGTTemplate.Utilities.ColorChanger&), ref num, ref num2, ref num3, ref flag, ref gameObject, ref array, ref colorChanger, ref flag2, ref gameObject2, ref array2, ref colorChanger2, t.setRoleReleaseTLibAttr[num]);
			}
			num2 = 16;
		}

		// Token: 0x06000D5E RID: 3422 RVA: 0x00084F48 File Offset: 0x00083148
		private static void GetRuntimeDirectorycharLen(ref int A_0, ref int A_1, ref int A_2)
		{
			Player.Instance.maxJumpSpeed = 8f;
			Player.Instance.jumpMultiplier = 1.3f;
			A_1 = 0;
		}

		// Token: 0x06000D5F RID: 3423 RVA: 0x00084F80 File Offset: 0x00083180
		private static void getInMVID(ref int A_0, ref int A_1, ref int A_2)
		{
			GameObject.Find("Environment Objects/TriggerZones_Prefab/JoinRoomTriggers_Prefab").SetActive(false);
			A_1 = 0;
		}

		// Token: 0x06000D60 RID: 3424 RVA: 0x00084FB0 File Offset: 0x000831B0
		private static void getParentIReference(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14)
		{
			bool flag = true;
			A_8 = flag;
			bool flag2 = A_3;
			A_9 = flag2;
			int num = ((!A_9) ? 1 : 0) * 1 + 44;
			A_0 = num;
		}

		// Token: 0x06000D61 RID: 3425 RVA: 0x00085028 File Offset: 0x00083228
		private static void TimeSpanTypeInfoObjectEnd(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4)
		{
			bool flag = GameObject.Find("CameraTablet(Clone)") != null;
			A_4 = flag;
			int num = ((!A_4) ? 1 : 0) * 1 + 118;
			A_0 = num;
		}

		// Token: 0x06000D62 RID: 3426 RVA: 0x00085090 File Offset: 0x00083290
		public static void OffQuitBox()
		{
			int num = 79;
			int num2 = 79;
			num2 = 79;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, t.setRoleReleaseTLibAttr[num]);
			}
			num2 = 79;
		}

		// Token: 0x06000D63 RID: 3427 RVA: 0x000850C8 File Offset: 0x000832C8
		private static void getIsThreadOwnerTrackingEnabledDynamicSecurityMethodAttribute(ref int A_0, ref int A_1, ref int A_2)
		{
			PhotonNetworkController.Instance.disableAFKKick = true;
			A_1 = 0;
		}

		// Token: 0x06000D64 RID: 3428 RVA: 0x000850F4 File Offset: 0x000832F4
		private static void continuationIdSecurityContextRunData(ref int A_0, ref int A_1, ref int A_2, ref SnowballThrowable[] A_3, ref int A_4, ref SnowballThrowable A_5, ref bool A_6)
		{
			A_5.randomizeColor = true;
			int num = A_4 + 1;
			A_4 = num;
			int num2 = ((A_4 < A_3.Length) ? 1 : 0) * -4 + 72;
			A_0 = num2;
		}

		// Token: 0x06000D65 RID: 3429 RVA: 0x00085168 File Offset: 0x00083368
		private static void UCOMIEnumerableAceQualifier(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref string[] A_4, ref string[] A_5, ref int A_6, ref string A_7, ref List<ButtonInfo>.Enumerator A_8, ref ButtonInfo A_9, ref bool A_10)
		{
			A_1 = 0;
		}

		// Token: 0x06000D66 RID: 3430 RVA: 0x00085180 File Offset: 0x00083380
		private static bool RecentMethodBody(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, VRRig A_5)
		{
			bool flag = true;
			A_4 = flag;
			A_0 = 107;
			bool result;
			return result;
		}

		// Token: 0x06000D67 RID: 3431 RVA: 0x000851B4 File Offset: 0x000833B4
		private static void UnobservedTaskExceptionEventArgsSoapServices(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GradientColorKey[] A_5, ref ColorChanger A_6, ref bool A_7, ref GameObject A_8, ref GradientColorKey[] A_9, ref ColorChanger A_10)
		{
			A_1 = 0;
		}

		// Token: 0x06000D68 RID: 3432 RVA: 0x000851CC File Offset: 0x000833CC
		private static void ParenthesisFormatNonUniqueAuthority(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref string[] A_4, ref string[] A_5, ref int A_6, ref string A_7, ref List<ButtonInfo>.Enumerator A_8, ref ButtonInfo A_9, ref bool A_10)
		{
			int num = A_6 + 1;
			A_6 = num;
			int num2 = ((A_6 < A_5.Length) ? 1 : 0) * -10 + 143;
			A_0 = num2;
		}

		// Token: 0x06000D69 RID: 3433 RVA: 0x0008522C File Offset: 0x0008342C
		public static void SteamLongArms()
		{
			int num = 83;
			int num2 = 83;
			num2 = 83;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, t.setRoleReleaseTLibAttr[num]);
			}
			num2 = 83;
		}

		// Token: 0x06000D6A RID: 3434 RVA: 0x00085264 File Offset: 0x00083464
		public static void FPSBoost()
		{
			int num = 81;
			int num2 = 81;
			num2 = 81;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, t.setRoleReleaseTLibAttr[num]);
			}
			num2 = 81;
		}

		// Token: 0x06000D6B RID: 3435 RVA: 0x0008529C File Offset: 0x0008349C
		private static void GetTagForElementSetAccessRuleProtection(ref int A_0, ref int A_1, ref int A_2)
		{
			buttons.settingsbuttons[1].enabled = new bool?(false);
			buttons.bbuttons[1].enabled = new bool?(false);
			t.inSettings = !t.inSettings;
			buttons.DestroyMenu();
			buttons.instance.Draw();
			A_1 = 0;
		}

		// Token: 0x06000D6C RID: 3436 RVA: 0x00085314 File Offset: 0x00083514
		private static void getEntryPointSecurityPermissionAttribute(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14)
		{
			bool flag = true;
			A_7 = flag;
			int num = (UnityInput.Current.GetKey(306) ? 1 : 0) * 1 + 42;
			A_0 = num;
		}

		// Token: 0x06000D6D RID: 3437 RVA: 0x00085378 File Offset: 0x00083578
		public static void ResetLength()
		{
			int num = 101;
			int num2 = 101;
			num2 = 101;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, t.setRoleReleaseTLibAttr[num]);
			}
			num2 = 101;
		}

		// Token: 0x06000D6E RID: 3438 RVA: 0x000853B0 File Offset: 0x000835B0
		private static void SecurityContextRunDataIsNewContextOK(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14)
		{
			bool key = UnityInput.Current.GetKey(276);
			A_4 = key;
			int num = (UnityInput.Current.GetKey(115) ? 1 : 0) * 1 + 36;
			A_0 = num;
		}

		// Token: 0x06000D6F RID: 3439 RVA: 0x00085420 File Offset: 0x00083620
		private static void WhenAllPromiseCopyToAsync(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<string> A_4, ref List<ButtonInfo>.Enumerator A_5, ref ButtonInfo A_6, ref bool? A_7, ref bool A_8, ref bool A_9)
		{
			((IDisposable)A_5).Dispose();
			A_1 = 2;
		}

		// Token: 0x06000D70 RID: 3440 RVA: 0x00085448 File Offset: 0x00083648
		private static void ReadBlockGetOrderableDynamicPartitions(ref int A_0, ref int A_1, ref int A_2)
		{
			GameObject.Find("Environment Objects/TriggerZones_Prefab/JoinRoomTriggers_Prefab").SetActive(true);
			A_1 = 0;
		}

		// Token: 0x06000D71 RID: 3441 RVA: 0x00085478 File Offset: 0x00083678
		private static void GetPreambleReplacementFallback(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref string[] A_4, ref string[] A_5, ref int A_6, ref string A_7, ref List<ButtonInfo>.Enumerator A_8, ref ButtonInfo A_9, ref bool A_10)
		{
			A_0 = 138;
		}

		// Token: 0x06000D72 RID: 3442 RVA: 0x00085490 File Offset: 0x00083690
		private static void KeyPasswordCausalityTracer(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4)
		{
			t.fpcc = true;
			bool flag = GameObject.Find("Third Person Camera") != null;
			A_3 = flag;
			int num = ((!A_3) ? 1 : 0) * 1 + 116;
			A_0 = num;
		}

		// Token: 0x06000D73 RID: 3443 RVA: 0x00085504 File Offset: 0x00083704
		private static void EnvoyInfoCustAttr(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref string[] A_4, ref string[] A_5, ref int A_6, ref string A_7, ref List<ButtonInfo>.Enumerator A_8, ref ButtonInfo A_9, ref bool A_10)
		{
			int num = ((A_6 < A_5.Length) ? 1 : 0) * -10 + 143;
			A_0 = num;
		}

		// Token: 0x06000D74 RID: 3444 RVA: 0x00085540 File Offset: 0x00083740
		public static void FixLongArms()
		{
			int num = 88;
			int num2 = 88;
			num2 = 88;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, t.setRoleReleaseTLibAttr[num]);
			}
			num2 = 88;
		}

		// Token: 0x06000D75 RID: 3445 RVA: 0x00085578 File Offset: 0x00083778
		private static void StrongNameErrorInfogetXmlTypeNamespace(ref int A_0, ref int A_1, ref int A_2, ref SnowballThrowable[] A_3, ref int A_4, ref SnowballThrowable A_5, ref bool A_6)
		{
			A_1 = 0;
		}

		// Token: 0x06000D76 RID: 3446 RVA: 0x00085590 File Offset: 0x00083790
		public unsafe static void Save()
		{
			int num = 1;
			int num2 = num * 4;
			int num3 = 123;
			int num4 = 123;
			num4 = 123;
			try
			{
				IL_1A:
				object[] array;
				int num5;
				int num6;
				int num7;
				int num8;
				int num9;
				Exception ex2;
				object[] array2;
				int num10;
				int num13;
				int num14;
				int num15;
				int num16;
				int num17;
				int num18;
				int num21;
				while (num4 != 0)
				{
					int num11;
					if (num4 == 2)
					{
						num4 = 123;
						if ((int)array[3] != 0)
						{
							num5 = (int)array[7];
							num6 = *(ref getSchemaVersionSTOREASSEMBLY.setShadowCopyFilesIsTokenProperlyAssigned + num5 + 24 + num2);
							for (num7 = *(ref getSchemaVersionSTOREASSEMBLY.setShadowCopyFilesIsTokenProperlyAssigned + *(ref getSchemaVersionSTOREASSEMBLY.setShadowCopyFilesIsTokenProperlyAssigned + (int)array[6] + 24 + num2) + 24 + num2); num7 != num6; num7 = *(ref getSchemaVersionSTOREASSEMBLY.setShadowCopyFilesIsTokenProperlyAssigned + num7 + 24 + num2))
							{
								num8 = *(ref getSchemaVersionSTOREASSEMBLY.setShadowCopyFilesIsTokenProperlyAssigned + num7 + 48 + num2);
								if (num8 != -1)
								{
									num9 = *(ref getSchemaVersionSTOREASSEMBLY.setShadowCopyFilesIsTokenProperlyAssigned + num8 + 40 + num2);
									array[6] = num8;
									array[4] = 1;
									num3 = *(ref getSchemaVersionSTOREASSEMBLY.setShadowCopyFilesIsTokenProperlyAssigned + num8 + 40 + num2);
									goto IL_1A;
								}
							}
							Exception ex = (Exception)array[0];
							num9 = *(ref getSchemaVersionSTOREASSEMBLY.setShadowCopyFilesIsTokenProperlyAssigned + num5 + 40 + num2);
							ex2 = ex;
							array = (object[])array[2];
							array2 = new object[8];
							array2[3] = 1;
							array2[2] = array;
							array2[0] = ex;
							array2[6] = num5;
							array2[4] = 2;
							array = array2;
							num3 = *(ref getSchemaVersionSTOREASSEMBLY.setShadowCopyFilesIsTokenProperlyAssigned + num5 + 40 + num2);
							continue;
						}
						num10 = (int)array[1];
						array = (object[])array[2];
						num11 = num10;
					}
					else
					{
						int num12;
						if (num4 != 4)
						{
							List<string> list;
							List<ButtonInfo>.Enumerator enumerator;
							ButtonInfo buttonInfo;
							bool? flag;
							bool flag2;
							bool flag3;
							calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Exception,System.Collections.Generic.List`1<System.String>&,System.Collections.Generic.List`1/Enumerator<ShibaGTTemplate.UI.ButtonInfo>&,ShibaGTTemplate.UI.ButtonInfo&,System.Nullable`1<System.Boolean>&,System.Boolean&,System.Boolean&), ref num3, ref num4, ref num12, ex2, ref list, ref enumerator, ref buttonInfo, ref flag, ref flag2, ref flag3, t.setRoleReleaseTLibAttr[num3]);
							continue;
						}
						num4 = 123;
						num8 = num12;
						num11 = num8;
					}
					num13 = num3;
					num6 = num13;
					num10 = 0;
					num14 = 2;
					for (;;)
					{
						num15 = (num10 + num14) / 2;
						num16 = *(ref getSchemaVersionSTOREASSEMBLY.setShadowCopyFilesIsTokenProperlyAssigned + 144 + num15 * 72 + 24 + num2);
						num17 = *(ref getSchemaVersionSTOREASSEMBLY.setShadowCopyFilesIsTokenProperlyAssigned + 144 + num15 * 72 + 32 + num2);
						if (num6 < num16 + num17)
						{
							if (num16 <= num6)
							{
								break;
							}
							num14 = num15 - 1;
						}
						else
						{
							num10 = num15 + 1;
						}
					}
					num7 = num15;
					num9 = *(ref getSchemaVersionSTOREASSEMBLY.setShadowCopyFilesIsTokenProperlyAssigned + 144 + num7 * 72 + 56 + num2);
					num18 = num9;
					num17 = num11;
					num16 = 0;
					num15 = 2;
					for (;;)
					{
						num14 = (num16 + num15) / 2;
						num10 = *(ref getSchemaVersionSTOREASSEMBLY.setShadowCopyFilesIsTokenProperlyAssigned + 144 + num14 * 72 + 24 + num2);
						num6 = *(ref getSchemaVersionSTOREASSEMBLY.setShadowCopyFilesIsTokenProperlyAssigned + 144 + num14 * 72 + 32 + num2);
						if (num17 < num10 + num6)
						{
							if (num10 <= num17)
							{
								break;
							}
							num15 = num14 - 1;
						}
						else
						{
							num16 = num14 + 1;
						}
					}
					num7 = num14;
					num8 = *(ref getSchemaVersionSTOREASSEMBLY.setShadowCopyFilesIsTokenProperlyAssigned + 144 + num7 * 72 + 56 + num2);
					num9 = num8;
					num6 = num11;
					num10 = 0;
					num14 = 2;
					for (;;)
					{
						num15 = (num10 + num14) / 2;
						num16 = *(ref getSchemaVersionSTOREASSEMBLY.setShadowCopyFilesIsTokenProperlyAssigned + 360 + num15 * 56 + 16 + num2);
						num17 = *(ref getSchemaVersionSTOREASSEMBLY.setShadowCopyFilesIsTokenProperlyAssigned + 360 + num15 * 56 + 24 + num2);
						if (num6 < num16 + num17)
						{
							if (num16 <= num6)
							{
								break;
							}
							num14 = num15 - 1;
						}
						else
						{
							num10 = num15 + 1;
						}
					}
					num7 = num15;
					num5 = *(ref getSchemaVersionSTOREASSEMBLY.setShadowCopyFilesIsTokenProperlyAssigned + 360 + num7 * 56 + 40 + num2);
					num8 = num5;
					for (;;)
					{
						IL_9C6:
						if (array == null || (int)array[3] == 0)
						{
							num6 = num9;
							while (num6 != num18)
							{
								if (num6 != -1)
								{
									num6 = *(ref getSchemaVersionSTOREASSEMBLY.setShadowCopyFilesIsTokenProperlyAssigned + num6 + 24 + num2);
								}
								else
								{
									num10 = *(ref getSchemaVersionSTOREASSEMBLY.setShadowCopyFilesIsTokenProperlyAssigned + num18 + 48 + num2);
									if (num10 != -1)
									{
										goto Block_58;
									}
									num18 = *(ref getSchemaVersionSTOREASSEMBLY.setShadowCopyFilesIsTokenProperlyAssigned + num18 + 24 + num2);
									goto IL_9C6;
								}
							}
							goto IL_B64;
						}
						int num19 = (int)array[6];
						int num20;
						if (num18 == -1)
						{
							num20 = -1;
						}
						else
						{
							num21 = *(ref getSchemaVersionSTOREASSEMBLY.setShadowCopyFilesIsTokenProperlyAssigned + num18 + 32 + num2);
							num17 = 0;
							num16 = 2;
							for (;;)
							{
								num15 = (num17 + num16) / 2;
								num14 = *(ref getSchemaVersionSTOREASSEMBLY.setShadowCopyFilesIsTokenProperlyAssigned + 360 + num15 * 56 + 16 + num2);
								num10 = *(ref getSchemaVersionSTOREASSEMBLY.setShadowCopyFilesIsTokenProperlyAssigned + 360 + num15 * 56 + 24 + num2);
								if (num21 < num14 + num10)
								{
									if (num14 <= num21)
									{
										break;
									}
									num16 = num15 - 1;
								}
								else
								{
									num17 = num15 + 1;
								}
							}
							num5 = num15;
							num7 = *(ref getSchemaVersionSTOREASSEMBLY.setShadowCopyFilesIsTokenProperlyAssigned + 360 + num5 * 56 + 40 + num2);
							num20 = num7;
						}
						if (num19 == num20)
						{
							num7 = num9;
							while (num7 != num18)
							{
								if (num7 != -1)
								{
									num7 = *(ref getSchemaVersionSTOREASSEMBLY.setShadowCopyFilesIsTokenProperlyAssigned + num7 + 24 + num2);
								}
								else
								{
									num5 = *(ref getSchemaVersionSTOREASSEMBLY.setShadowCopyFilesIsTokenProperlyAssigned + num18 + 48 + num2);
									if (num5 != -1)
									{
										goto Block_54;
									}
									num18 = *(ref getSchemaVersionSTOREASSEMBLY.setShadowCopyFilesIsTokenProperlyAssigned + num18 + 24 + num2);
									goto IL_9C6;
								}
							}
							break;
						}
						if ((int)array[6] == num8)
						{
							goto Block_55;
						}
						array = (object[])array[2];
					}
					num3 = num11;
					continue;
					Block_54:
					num6 = *(ref getSchemaVersionSTOREASSEMBLY.setShadowCopyFilesIsTokenProperlyAssigned + num5 + 40 + num2);
					array2 = new object[8];
					array2[3] = 0;
					array2[2] = array;
					array2[1] = num11;
					array2[6] = num5;
					array2[4] = 1;
					array = array2;
					num3 = *(ref getSchemaVersionSTOREASSEMBLY.setShadowCopyFilesIsTokenProperlyAssigned + num5 + 40 + num2);
					continue;
					Block_55:
					num3 = num11;
					continue;
					IL_B64:
					num3 = num11;
					continue;
					Block_58:
					num14 = *(ref getSchemaVersionSTOREASSEMBLY.setShadowCopyFilesIsTokenProperlyAssigned + num10 + 40 + num2);
					array2 = new object[8];
					array2[3] = 0;
					array2[2] = array;
					array2[1] = num11;
					array2[6] = num10;
					array2[4] = 1;
					array = array2;
					num3 = *(ref getSchemaVersionSTOREASSEMBLY.setShadowCopyFilesIsTokenProperlyAssigned + num10 + 40 + num2);
				}
				num4 = 123;
				return;
				IL_1B8:
				if (num6 != -1)
				{
					goto IL_1C3;
				}
				goto IL_3E7;
				IL_1C3:
				num7 = *(ref getSchemaVersionSTOREASSEMBLY.setShadowCopyFilesIsTokenProperlyAssigned + num6 + 32 + num2);
				if (1 == num7)
				{
					goto IL_1E2;
				}
				if (2 == num7)
				{
					goto IL_374;
				}
				goto IL_3E7;
				IL_1E2:
				num9 = *(ref getSchemaVersionSTOREASSEMBLY.setShadowCopyFilesIsTokenProperlyAssigned + num6 + 56 + num2);
				if (num9 == -1)
				{
					goto IL_230;
				}
				Type[] array3;
				Type type;
				if ((type = array3[num9]) != null)
				{
					goto IL_216;
				}
				RuntimeTypeHandle[] array4;
				array3[num9] = Type.GetTypeFromHandle(array4[num9]);
				type = array3[num9];
				IL_216:
				if (type.IsInstanceOfType(array2[0]))
				{
					goto IL_230;
				}
				num6 = *(ref getSchemaVersionSTOREASSEMBLY.setShadowCopyFilesIsTokenProperlyAssigned + num6 + 48 + num2);
				goto IL_1B8;
				IL_230:
				num5 = num6;
				num8 = *(ref getSchemaVersionSTOREASSEMBLY.setShadowCopyFilesIsTokenProperlyAssigned + *(ref getSchemaVersionSTOREASSEMBLY.setShadowCopyFilesIsTokenProperlyAssigned + num5 + 24 + num2) + 24 + num2);
				num13 = (int)array2[5];
				IL_254:
				if (num13 != num8)
				{
					goto IL_2D3;
				}
				int num22 = *(ref getSchemaVersionSTOREASSEMBLY.setShadowCopyFilesIsTokenProperlyAssigned + num5 + 40 + num2);
				ex2 = array2[0];
				array = (object[])array[2];
				object[] array5 = new object[8];
				array5[3] = 1;
				array5[2] = array;
				array5[0] = array2[0];
				array5[5] = (int)array2[5];
				array5[6] = num5;
				array5[4] = 2;
				array = array5;
				num3 = *(ref getSchemaVersionSTOREASSEMBLY.setShadowCopyFilesIsTokenProperlyAssigned + num5 + 40 + num2);
				goto IL_1A;
				IL_2D3:
				num18 = *(ref getSchemaVersionSTOREASSEMBLY.setShadowCopyFilesIsTokenProperlyAssigned + num13 + 48 + num2);
				if (num18 == -1)
				{
					goto IL_362;
				}
				num22 = *(ref getSchemaVersionSTOREASSEMBLY.setShadowCopyFilesIsTokenProperlyAssigned + num18 + 40 + num2);
				array = (object[])array[2];
				array5 = new object[8];
				array5[3] = 1;
				array5[2] = array;
				array5[0] = array2[0];
				array5[5] = (int)array2[5];
				array5[6] = num18;
				array5[7] = num5;
				array5[4] = 1;
				array = array5;
				num3 = *(ref getSchemaVersionSTOREASSEMBLY.setShadowCopyFilesIsTokenProperlyAssigned + num18 + 40 + num2);
				goto IL_1A;
				IL_362:
				num13 = *(ref getSchemaVersionSTOREASSEMBLY.setShadowCopyFilesIsTokenProperlyAssigned + num13 + 24 + num2);
				goto IL_254;
				IL_374:
				num22 = *(ref getSchemaVersionSTOREASSEMBLY.setShadowCopyFilesIsTokenProperlyAssigned + num6 + num2);
				ex2 = array2[0];
				array = (object[])array[2];
				array5 = new object[8];
				array5[3] = 1;
				array5[2] = array;
				array5[0] = array2[0];
				array5[5] = (int)array2[5];
				array5[6] = num6;
				array5[4] = 0;
				array = array5;
				num3 = *(ref getSchemaVersionSTOREASSEMBLY.setShadowCopyFilesIsTokenProperlyAssigned + num6 + num2);
				goto IL_1A;
				IL_3E7:
				array = (object[])array[2];
				Exception ex3 = array2[0];
				int num23 = (int)array2[5];
				IL_406:
				num6 = num3;
				num22 = num6;
				num21 = 0;
				num10 = 2;
				IL_414:
				num14 = (num21 + num10) / 2;
				num15 = *(ref getSchemaVersionSTOREASSEMBLY.setShadowCopyFilesIsTokenProperlyAssigned + 144 + num14 * 72 + 24 + num2);
				num16 = *(ref getSchemaVersionSTOREASSEMBLY.setShadowCopyFilesIsTokenProperlyAssigned + 144 + num14 * 72 + 32 + num2);
				if (num22 >= num15 + num16)
				{
					goto IL_45A;
				}
				if (num15 > num22)
				{
					goto IL_462;
				}
				num8 = num14;
				num5 = *(ref getSchemaVersionSTOREASSEMBLY.setShadowCopyFilesIsTokenProperlyAssigned + 144 + num8 * 72 + 56 + num2);
				num9 = num5;
				num13 = num9;
				goto IL_48A;
				IL_45A:
				num21 = num14 + 1;
				goto IL_414;
				IL_462:
				num10 = num14 - 1;
				goto IL_414;
				IL_48A:
				if (array != null)
				{
					goto IL_495;
				}
				goto IL_624;
				IL_495:
				if ((int)array[3] != 0)
				{
					goto IL_555;
				}
				int num24 = (int)array[6];
				if (num9 != -1)
				{
					goto IL_4B9;
				}
				int num25 = -1;
				goto IL_53C;
				IL_4B9:
				num17 = *(ref getSchemaVersionSTOREASSEMBLY.setShadowCopyFilesIsTokenProperlyAssigned + num9 + 32 + num2);
				num16 = 0;
				num15 = 2;
				IL_4CC:
				num14 = (num16 + num15) / 2;
				num10 = *(ref getSchemaVersionSTOREASSEMBLY.setShadowCopyFilesIsTokenProperlyAssigned + 360 + num14 * 56 + 16 + num2);
				num21 = *(ref getSchemaVersionSTOREASSEMBLY.setShadowCopyFilesIsTokenProperlyAssigned + 360 + num14 * 56 + 24 + num2);
				if (num17 >= num10 + num21)
				{
					goto IL_512;
				}
				if (num10 > num17)
				{
					goto IL_51A;
				}
				num5 = num14;
				num8 = *(ref getSchemaVersionSTOREASSEMBLY.setShadowCopyFilesIsTokenProperlyAssigned + 360 + num5 * 56 + 40 + num2);
				num25 = num8;
				goto IL_53C;
				IL_512:
				num16 = num14 + 1;
				goto IL_4CC;
				IL_51A:
				num15 = num14 - 1;
				goto IL_4CC;
				IL_53C:
				if (num24 != num25)
				{
					goto IL_544;
				}
				goto IL_624;
				IL_544:
				array = (object[])array[2];
				goto IL_48A;
				IL_555:
				num18 = (int)array[4];
				if (num18 == 2 || num18 == 1)
				{
					goto IL_576;
				}
				if (num18 != 0)
				{
					goto IL_575;
				}
				array2 = array;
				num6 = *(ref getSchemaVersionSTOREASSEMBLY.setShadowCopyFilesIsTokenProperlyAssigned + (int)array2[6] + 48 + num2);
				goto IL_1B8;
				IL_575:
				IL_576:
				int num26 = (int)array[6];
				if (num9 != -1)
				{
					goto IL_58B;
				}
				int num27 = -1;
				goto IL_60E;
				IL_58B:
				num22 = *(ref getSchemaVersionSTOREASSEMBLY.setShadowCopyFilesIsTokenProperlyAssigned + num9 + 32 + num2);
				num21 = 0;
				num10 = 2;
				IL_59E:
				num14 = (num21 + num10) / 2;
				num15 = *(ref getSchemaVersionSTOREASSEMBLY.setShadowCopyFilesIsTokenProperlyAssigned + 360 + num14 * 56 + 16 + num2);
				num16 = *(ref getSchemaVersionSTOREASSEMBLY.setShadowCopyFilesIsTokenProperlyAssigned + 360 + num14 * 56 + 24 + num2);
				if (num22 >= num15 + num16)
				{
					goto IL_5E4;
				}
				if (num15 > num22)
				{
					goto IL_5EC;
				}
				num8 = num14;
				num5 = *(ref getSchemaVersionSTOREASSEMBLY.setShadowCopyFilesIsTokenProperlyAssigned + 360 + num8 * 56 + 40 + num2);
				num27 = num5;
				goto IL_60E;
				IL_5E4:
				num21 = num14 + 1;
				goto IL_59E;
				IL_5EC:
				num10 = num14 - 1;
				goto IL_59E;
				IL_60E:
				if (num26 != num27)
				{
					goto IL_613;
				}
				goto IL_624;
				IL_613:
				array = (object[])array[2];
				goto IL_48A;
				IL_624:
				if (-1 != num9)
				{
					goto IL_630;
				}
				int num28 = 1;
				throw ex3;
				IL_630:
				num7 = *(ref getSchemaVersionSTOREASSEMBLY.setShadowCopyFilesIsTokenProperlyAssigned + num9 + 16 + num2);
				num10 = num7;
				IL_641:
				if (num10 != -1)
				{
					goto IL_658;
				}
				num9 = *(ref getSchemaVersionSTOREASSEMBLY.setShadowCopyFilesIsTokenProperlyAssigned + num9 + 24 + num2);
				goto IL_48A;
				IL_658:
				num15 = *(ref getSchemaVersionSTOREASSEMBLY.setShadowCopyFilesIsTokenProperlyAssigned + num10 + 32 + num2);
				if (1 == num15)
				{
					goto IL_683;
				}
				if (2 == num15)
				{
					goto IL_7F1;
				}
				num9 = *(ref getSchemaVersionSTOREASSEMBLY.setShadowCopyFilesIsTokenProperlyAssigned + num9 + 24 + num2);
				goto IL_48A;
				IL_683:
				num14 = *(ref getSchemaVersionSTOREASSEMBLY.setShadowCopyFilesIsTokenProperlyAssigned + num10 + 56 + num2);
				if (num14 == -1)
				{
					goto IL_6D2;
				}
				Type type2;
				if ((type2 = array3[num14]) != null)
				{
					goto IL_6B7;
				}
				array3[num14] = Type.GetTypeFromHandle(array4[num14]);
				type2 = array3[num14];
				IL_6B7:
				if (type2.IsInstanceOfType(ex3))
				{
					goto IL_6D2;
				}
				num10 = *(ref getSchemaVersionSTOREASSEMBLY.setShadowCopyFilesIsTokenProperlyAssigned + num10 + 48 + num2);
				goto IL_641;
				IL_6D2:
				num5 = num10;
				num8 = *(ref getSchemaVersionSTOREASSEMBLY.setShadowCopyFilesIsTokenProperlyAssigned + *(ref getSchemaVersionSTOREASSEMBLY.setShadowCopyFilesIsTokenProperlyAssigned + num5 + 24 + num2) + 24 + num2);
				num17 = (num13 - num23) * ((num23 == -1) ? 1 : 0) + num23;
				IL_6FB:
				if (num17 != num8)
				{
					goto IL_764;
				}
				num21 = *(ref getSchemaVersionSTOREASSEMBLY.setShadowCopyFilesIsTokenProperlyAssigned + num5 + 40 + num2);
				ex2 = ex3;
				array2 = new object[8];
				array2[3] = 1;
				array2[2] = array;
				array2[0] = ex3;
				array2[5] = num13;
				array2[6] = num5;
				array2[4] = 2;
				array = array2;
				num3 = *(ref getSchemaVersionSTOREASSEMBLY.setShadowCopyFilesIsTokenProperlyAssigned + num5 + 40 + num2);
				goto IL_1A;
				IL_764:
				num16 = *(ref getSchemaVersionSTOREASSEMBLY.setShadowCopyFilesIsTokenProperlyAssigned + num17 + 48 + num2);
				if (num16 == -1)
				{
					goto IL_7DF;
				}
				num21 = *(ref getSchemaVersionSTOREASSEMBLY.setShadowCopyFilesIsTokenProperlyAssigned + num16 + 40 + num2);
				array2 = new object[8];
				array2[3] = 1;
				array2[2] = array;
				array2[0] = ex3;
				array2[5] = num13;
				array2[6] = num16;
				array2[7] = num5;
				array2[4] = 1;
				array = array2;
				num3 = *(ref getSchemaVersionSTOREASSEMBLY.setShadowCopyFilesIsTokenProperlyAssigned + num16 + 40 + num2);
				goto IL_1A;
				IL_7DF:
				num17 = *(ref getSchemaVersionSTOREASSEMBLY.setShadowCopyFilesIsTokenProperlyAssigned + num17 + 24 + num2);
				goto IL_6FB;
				IL_7F1:
				num21 = *(ref getSchemaVersionSTOREASSEMBLY.setShadowCopyFilesIsTokenProperlyAssigned + num10 + num2);
				ex2 = ex3;
				array2 = new object[8];
				array2[3] = 1;
				array2[2] = array;
				array2[0] = ex3;
				array2[5] = num13;
				array2[6] = num10;
				array2[4] = 0;
				array = array2;
				num3 = *(ref getSchemaVersionSTOREASSEMBLY.setShadowCopyFilesIsTokenProperlyAssigned + num10 + num2);
				goto IL_1A;
			}
			catch (Exception ex4)
			{
				int num28;
				if (num28 != 1)
				{
					Exception ex3 = ex4;
					int num23 = -1;
					goto IL_406;
				}
				throw ex4;
			}
		}

		// Token: 0x06000D77 RID: 3447 RVA: 0x000861BC File Offset: 0x000843BC
		public static void ConnectToUSE()
		{
			int num = 66;
			int num2 = 66;
			num2 = 66;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, t.setRoleReleaseTLibAttr[num]);
			}
			num2 = 66;
		}

		// Token: 0x06000D78 RID: 3448 RVA: 0x000861F4 File Offset: 0x000843F4
		public static void SlideControl()
		{
			int num = 96;
			int num2 = 96;
			num2 = 96;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, t.setRoleReleaseTLibAttr[num]);
			}
			num2 = 96;
		}

		// Token: 0x06000D79 RID: 3449 RVA: 0x0008622C File Offset: 0x0008442C
		private static void FirstMatchCodeGroupOSVERSIONINFOEX(ref int A_0, ref int A_1, ref int A_2, ref SnowballThrowable[] A_3, ref int A_4, ref SnowballThrowable A_5, ref bool A_6)
		{
			SnowballThrowable snowballThrowable = A_3[A_4];
			A_5 = snowballThrowable;
			bool flag = A_5;
			A_6 = flag;
			int num = ((!A_6) ? 1 : 0) * 1 + 75;
			A_0 = num;
		}

		// Token: 0x06000D7A RID: 3450 RVA: 0x000862B8 File Offset: 0x000844B8
		private static void addUnobservedTaskExceptionTYPEFLAGFAPPOBJECT(ref int A_0, ref int A_1, ref int A_2)
		{
			GameObject.Find("Environment Objects/TriggerZones_Prefab/ZoneTransitions_Prefab/QuitBox").SetActive(false);
			A_1 = 0;
		}

		// Token: 0x06000D7B RID: 3451 RVA: 0x000862E8 File Offset: 0x000844E8
		private static void getAccountDomainSidNoResourceLookup(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14)
		{
			bool key = UnityInput.Current.GetKey(303);
			A_7 = key;
			int num = (UnityInput.Current.GetKey(306) ? 1 : 0) * 1 + 42;
			A_0 = num;
		}

		// Token: 0x06000D7C RID: 3452 RVA: 0x00086358 File Offset: 0x00084558
		private static void StructLayoutAttributeRootSetObjectData(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref string[] A_4, ref string[] A_5, ref int A_6, ref string A_7, ref List<ButtonInfo>.Enumerator A_8, ref ButtonInfo A_9, ref bool A_10)
		{
			ButtonInfo buttonInfo = A_8.Current;
			A_9 = buttonInfo;
			bool flag = A_9.buttonText == A_7;
			A_10 = flag;
			int num = ((!A_10) ? 1 : 0) * 1 + 136;
			A_0 = num;
		}

		// Token: 0x06000D7D RID: 3453 RVA: 0x000863E8 File Offset: 0x000845E8
		public static void ConnectToEU()
		{
			int num = 63;
			int num2 = 63;
			num2 = 63;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, t.setRoleReleaseTLibAttr[num]);
			}
			num2 = 63;
		}

		// Token: 0x06000D7E RID: 3454 RVA: 0x00086420 File Offset: 0x00084620
		private static void WriteLineAsyncMediaPlay(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14)
		{
			Player.Instance.GetComponent<Rigidbody>().velocity += Vector3.right * Time.deltaTime * 35f;
			bool flag = A_7;
			A_13 = flag;
			int num = ((!A_13) ? 1 : 0) * 1 + 52;
			A_0 = num;
		}

		// Token: 0x06000D7F RID: 3455 RVA: 0x000864B8 File Offset: 0x000846B8
		private static void PARAMDESCReadBlock(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14)
		{
			Player.Instance.GetComponent<Rigidbody>().velocity += Vector3.forward * Time.deltaTime * -45f;
			bool flag = A_6;
			A_12 = flag;
			int num = ((!A_12) ? 1 : 0) * 1 + 50;
			A_0 = num;
		}

		// Token: 0x06000D80 RID: 3456 RVA: 0x00086550 File Offset: 0x00084750
		private static void IsErrorRedirectedEraToken(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14)
		{
			bool flag = true;
			A_3 = flag;
			int num = (UnityInput.Current.GetKey(97) ? 1 : 0) * 1 + 34;
			A_0 = num;
		}

		// Token: 0x06000D81 RID: 3457 RVA: 0x000865B4 File Offset: 0x000847B4
		private static void OrderSetMethodBody(ref int A_0, ref int A_1, ref int A_2)
		{
			BetterDayNightManager.instance.SetTimeOfDay(7);
			A_1 = 0;
		}

		// Token: 0x06000D82 RID: 3458 RVA: 0x000865E0 File Offset: 0x000847E0
		private static void NonUniqueAuthorityStatic(ref int A_0, ref int A_1, ref int A_2)
		{
			PhotonNetworkController.Instance.disableAFKKick = false;
			A_1 = 0;
		}

		// Token: 0x06000D83 RID: 3459 RVA: 0x0008660C File Offset: 0x0008480C
		private static void IsBackgroundEnumInstallerDeploymentProperties(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GradientColorKey[] A_5, ref ColorChanger A_6, ref bool A_7, ref GameObject A_8, ref GradientColorKey[] A_9, ref ColorChanger A_10)
		{
			bool gripDownL = buttons.gripDownL;
			A_3 = gripDownL;
			int num = ((!A_3) ? 1 : 0) * 1 + 22;
			A_0 = num;
		}

		// Token: 0x06000D84 RID: 3460 RVA: 0x00086668 File Offset: 0x00084868
		private static void getParentIndexSetSource(ref int A_0, ref int A_1, ref int A_2, ref float A_3, ref float A_4, ref bool A_5)
		{
			bool flag = A_4 > 0f;
			A_5 = flag;
			int num = (A_5 ? 1 : 0) * -2 + 11;
			A_0 = num;
		}

		// Token: 0x06000D85 RID: 3461 RVA: 0x000866D0 File Offset: 0x000848D0
		private static void FileAssociationParameterOffsetLow(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			A_1 = 0;
		}

		// Token: 0x06000D86 RID: 3462 RVA: 0x000866E8 File Offset: 0x000848E8
		private static void BaseUtcOffsetgetIsDynamic(ref int A_0, ref int A_1, ref int A_2)
		{
			Player.Instance.maxJumpSpeed = 10f;
			Player.Instance.jumpMultiplier = 1.5f;
			A_1 = 0;
		}

		// Token: 0x06000D87 RID: 3463 RVA: 0x00086720 File Offset: 0x00084920
		public static void EnableNetworkTriggers()
		{
			int num = 62;
			int num2 = 62;
			num2 = 62;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, t.setRoleReleaseTLibAttr[num]);
			}
			num2 = 62;
		}

		// Token: 0x06000D88 RID: 3464 RVA: 0x00086758 File Offset: 0x00084958
		public static void ConnectToUSW()
		{
			int num = 65;
			int num2 = 65;
			num2 = 65;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, t.setRoleReleaseTLibAttr[num]);
			}
			num2 = 65;
		}

		// Token: 0x06000D89 RID: 3465 RVA: 0x00086790 File Offset: 0x00084990
		private static void TypeInformationIsNestedPublic(ref int A_0, ref int A_1, ref int A_2, ref int A_3, ref bool A_4)
		{
			buttons.settingsbuttons[0].enabled = new bool?(false);
			A_1 = 0;
		}

		// Token: 0x06000D8A RID: 3466 RVA: 0x000867C8 File Offset: 0x000849C8
		private static void IsFamilyITypeLibExporterNotifySink(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14)
		{
			bool flag = A_4;
			A_10 = flag;
			int num = ((!A_10) ? 1 : 0) * 1 + 46;
			A_0 = num;
		}

		// Token: 0x06000D8B RID: 3467 RVA: 0x00086828 File Offset: 0x00084A28
		private static void SecurityPermissionFlagSignatureDescription(ref int A_0, ref int A_1, ref int A_2, ref float A_3, ref float A_4, ref bool A_5, ref float A_6, ref Vector3 A_7)
		{
			A_1 = 0;
		}

		// Token: 0x06000D8C RID: 3468 RVA: 0x00086840 File Offset: 0x00084A40
		public static void FixFPSBoost()
		{
			int num = 82;
			int num2 = 82;
			num2 = 82;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, t.setRoleReleaseTLibAttr[num]);
			}
			num2 = 82;
		}

		// Token: 0x06000D8D RID: 3469 RVA: 0x00086878 File Offset: 0x00084A78
		private static void ReadOnlyCollectionSTOREASSEMBLY(ref int A_0, ref int A_1, ref int A_2)
		{
			PhotonNetwork.ConnectToRegion("use");
			A_1 = 0;
		}

		// Token: 0x06000D8E RID: 3470 RVA: 0x0008689C File Offset: 0x00084A9C
		public static void ConnectToUS()
		{
			int num = 64;
			int num2 = 64;
			num2 = 64;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, t.setRoleReleaseTLibAttr[num]);
			}
			num2 = 64;
		}

		// Token: 0x06000D8F RID: 3471 RVA: 0x000868D4 File Offset: 0x00084AD4
		private static void InTypeCountMaskGetValueList(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14)
		{
			bool flag = true;
			A_6 = flag;
			int num = (UnityInput.Current.GetKey(32) ? 1 : 0) * 1 + 40;
			A_0 = num;
		}

		// Token: 0x06000D90 RID: 3472 RVA: 0x00086938 File Offset: 0x00084B38
		private static void TicksRecent(ref int A_0, ref int A_1, ref int A_2)
		{
			Player.Instance.transform.localScale = new Vector3(1.75f, 1f, 1f);
			A_1 = 0;
		}

		// Token: 0x06000D91 RID: 3473 RVA: 0x00086974 File Offset: 0x00084B74
		// Note: this type is marked as 'beforefieldinit'.
		static t()
		{
			t.LeftArrowLocked();
			int num = 145;
			int num2 = 145;
			num2 = 145;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, t.setRoleReleaseTLibAttr[num]);
			}
			num2 = 145;
		}

		// Token: 0x06000D92 RID: 3474 RVA: 0x000869BC File Offset: 0x00084BBC
		private static void LongDatePatternIsSddlConversionSupported(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref string[] A_4, ref string[] A_5, ref int A_6, ref string A_7, ref List<ButtonInfo>.Enumerator A_8, ref ButtonInfo A_9, ref bool A_10)
		{
			int num = (A_8.MoveNext() ? 1 : 0) * -4 + 139;
			A_0 = num;
		}

		// Token: 0x06000D93 RID: 3475 RVA: 0x00086A04 File Offset: 0x00084C04
		private static void LockRecursionExceptionCMSHASHTRANSFORMMANIFESTINVARIANT(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GradientColorKey[] A_5, ref ColorChanger A_6, ref bool A_7, ref GameObject A_8, ref GradientColorKey[] A_9, ref ColorChanger A_10)
		{
			GameObject gameObject = GameObject.CreatePrimitive(3);
			A_8 = gameObject;
			Object.Destroy(A_8.GetComponent<BoxCollider>());
			A_8.GetComponent<Renderer>().material.shader = Shader.Find("GorillaTag/UberShader");
			A_8.transform.localScale = new Vector3(0.25f, 0.25f, 0.25f);
			A_8.transform.position = GorillaTagger.Instance.rightHandTransform.position;
			A_8.transform.rotation = GorillaTagger.Instance.rightHandTransform.rotation;
			Object.Destroy(A_8, 100f);
			PhotonNetwork.RaiseEvent(69, new object[]
			{
				A_8.transform.position,
				A_8.transform.rotation
			}, new RaiseEventOptions
			{
				Receivers = 0
			}, SendOptions.SendReliable);
			GradientColorKey[] array = new GradientColorKey[3];
			A_9 = array;
			A_9[0].color = Color.red;
			A_9[0].time = 0f;
			A_9[1].color = Color.yellow;
			A_9[1].time = 0.2f;
			A_9[2].color = Color.green;
			A_9[2].time = 0.3f;
			A_9[3].color = Color.cyan;
			A_9[3].time = 0.5f;
			A_9[4].color = Color.blue;
			A_9[4].time = 0.6f;
			A_9[5].color = Color.magenta;
			A_9[5].time = 0.8f;
			A_9[6].color = Color.red;
			A_9[6].time = 1f;
			ColorChanger colorChanger = A_8.AddComponent<ColorChanger>();
			A_10 = colorChanger;
			A_10.colors = new Gradient
			{
				colorKeys = A_9
			};
			A_10.Start();
			A_1 = 0;
		}

		// Token: 0x06000D94 RID: 3476 RVA: 0x00086D5C File Offset: 0x00084F5C
		private static void LocalPushEnhancedKeyUsage(ref int A_0, ref int A_1, ref int A_2, ref float A_3, ref float A_4, ref bool A_5)
		{
			A_1 = 0;
		}

		// Token: 0x06000D95 RID: 3477 RVA: 0x00086D74 File Offset: 0x00084F74
		public static void PencilDrawPlane()
		{
			int num = 26;
			int num2 = 26;
			num2 = 26;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				GameObject gameObject;
				GradientColorKey[] array;
				ColorChanger colorChanger;
				bool flag2;
				GameObject gameObject2;
				GradientColorKey[] array2;
				ColorChanger colorChanger2;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,UnityEngine.GameObject&,UnityEngine.GradientColorKey[]&,ShibaGTTemplate.Utilities.ColorChanger&,System.Boolean&,UnityEngine.GameObject&,UnityEngine.GradientColorKey[]&,ShibaGTTemplate.Utilities.ColorChanger&), ref num, ref num2, ref num3, ref flag, ref gameObject, ref array, ref colorChanger, ref flag2, ref gameObject2, ref array2, ref colorChanger2, t.setRoleReleaseTLibAttr[num]);
			}
			num2 = 26;
		}

		// Token: 0x06000D96 RID: 3478 RVA: 0x00086DBC File Offset: 0x00084FBC
		private static void SerialNumbergetFormatterAlgorithm(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14)
		{
			bool flag = true;
			A_4 = flag;
			int num = (UnityInput.Current.GetKey(115) ? 1 : 0) * 1 + 36;
			A_0 = num;
		}

		// Token: 0x06000D97 RID: 3479 RVA: 0x00086E20 File Offset: 0x00085020
		public unsafe static void Load()
		{
			int num = 1;
			int num2 = num * 4;
			int num3 = 132;
			int num4 = 132;
			num4 = 132;
			try
			{
				IL_23:
				object[] array;
				int num5;
				int num6;
				int num7;
				int num8;
				int num9;
				Exception ex2;
				object[] array2;
				int num10;
				int num14;
				int num15;
				int num16;
				int num17;
				int num18;
				int num19;
				int num22;
				while (num4 != 0)
				{
					int num11;
					if (num4 == 2)
					{
						num4 = 132;
						if ((int)array[1] != 0)
						{
							num5 = (int)array[0];
							num6 = *(ref TargetInvocationExceptionGetOneYearLocalFromUtc.TryUpdateoInst + num5 + 16 + num2);
							for (num7 = *(ref TargetInvocationExceptionGetOneYearLocalFromUtc.TryUpdateoInst + *(ref TargetInvocationExceptionGetOneYearLocalFromUtc.TryUpdateoInst + (int)array[2] + 16 + num2) + 8 + num2); num7 != num6; num7 = *(ref TargetInvocationExceptionGetOneYearLocalFromUtc.TryUpdateoInst + num7 + 8 + num2))
							{
								num8 = *(ref TargetInvocationExceptionGetOneYearLocalFromUtc.TryUpdateoInst + num7 + 16 + num2);
								if (num8 != -1)
								{
									num9 = *(ref TargetInvocationExceptionGetOneYearLocalFromUtc.TryUpdateoInst + num8 + 64 + num2);
									array[2] = num8;
									array[5] = 0;
									num3 = *(ref TargetInvocationExceptionGetOneYearLocalFromUtc.TryUpdateoInst + num8 + 64 + num2);
									goto IL_23;
								}
							}
							Exception ex = (Exception)array[7];
							num9 = *(ref TargetInvocationExceptionGetOneYearLocalFromUtc.TryUpdateoInst + num5 + 64 + num2);
							ex2 = ex;
							array = (object[])array[6];
							array2 = new object[]
							{
								null,
								1,
								null,
								null,
								null,
								null,
								array,
								ex
							};
							array2[2] = num5;
							array2[5] = 1;
							array = array2;
							num3 = *(ref TargetInvocationExceptionGetOneYearLocalFromUtc.TryUpdateoInst + num5 + 64 + num2);
							continue;
						}
						num10 = (int)array[4];
						array = (object[])array[6];
						num11 = num10;
					}
					else
					{
						int num12;
						if (num4 != 4)
						{
							string[] array3;
							string[] array4;
							int num13;
							string text;
							List<ButtonInfo>.Enumerator enumerator;
							ButtonInfo buttonInfo;
							bool flag;
							calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Exception,System.String[]&,System.String[]&,System.Int32&,System.String&,System.Collections.Generic.List`1/Enumerator<ShibaGTTemplate.UI.ButtonInfo>&,ShibaGTTemplate.UI.ButtonInfo&,System.Boolean&), ref num3, ref num4, ref num12, ex2, ref array3, ref array4, ref num13, ref text, ref enumerator, ref buttonInfo, ref flag, t.setRoleReleaseTLibAttr[num3]);
							continue;
						}
						num4 = 132;
						num8 = num12;
						num11 = num8;
					}
					num14 = num3;
					num6 = num14;
					num10 = 0;
					num15 = 2;
					for (;;)
					{
						num16 = (num10 + num15) / 2;
						num17 = *(ref TargetInvocationExceptionGetOneYearLocalFromUtc.TryUpdateoInst + 152 + num16 * 48 + 8 + num2);
						num18 = *(ref TargetInvocationExceptionGetOneYearLocalFromUtc.TryUpdateoInst + 152 + num16 * 48 + 32 + num2);
						if (num6 < num17 + num18)
						{
							if (num17 <= num6)
							{
								break;
							}
							num15 = num16 - 1;
						}
						else
						{
							num10 = num16 + 1;
						}
					}
					num7 = num16;
					num9 = *(ref TargetInvocationExceptionGetOneYearLocalFromUtc.TryUpdateoInst + 152 + num7 * 48 + num2);
					num19 = num9;
					num18 = num11;
					num17 = 0;
					num16 = 2;
					for (;;)
					{
						num15 = (num17 + num16) / 2;
						num10 = *(ref TargetInvocationExceptionGetOneYearLocalFromUtc.TryUpdateoInst + 152 + num15 * 48 + 8 + num2);
						num6 = *(ref TargetInvocationExceptionGetOneYearLocalFromUtc.TryUpdateoInst + 152 + num15 * 48 + 32 + num2);
						if (num18 < num10 + num6)
						{
							if (num10 <= num18)
							{
								break;
							}
							num16 = num15 - 1;
						}
						else
						{
							num17 = num15 + 1;
						}
					}
					num7 = num15;
					num8 = *(ref TargetInvocationExceptionGetOneYearLocalFromUtc.TryUpdateoInst + 152 + num7 * 48 + num2);
					num9 = num8;
					num6 = num11;
					num10 = 0;
					num15 = 2;
					for (;;)
					{
						num16 = (num10 + num15) / 2;
						num17 = *(ref TargetInvocationExceptionGetOneYearLocalFromUtc.TryUpdateoInst + 296 + num16 * 72 + 16 + num2);
						num18 = *(ref TargetInvocationExceptionGetOneYearLocalFromUtc.TryUpdateoInst + 296 + num16 * 72 + 56 + num2);
						if (num6 < num17 + num18)
						{
							if (num17 <= num6)
							{
								break;
							}
							num15 = num16 - 1;
						}
						else
						{
							num10 = num16 + 1;
						}
					}
					num7 = num16;
					num5 = *(ref TargetInvocationExceptionGetOneYearLocalFromUtc.TryUpdateoInst + 296 + num7 * 72 + 8 + num2);
					num8 = num5;
					for (;;)
					{
						IL_9CF:
						if (array == null || (int)array[1] == 0)
						{
							num6 = num9;
							while (num6 != num19)
							{
								if (num6 != -1)
								{
									num6 = *(ref TargetInvocationExceptionGetOneYearLocalFromUtc.TryUpdateoInst + num6 + 8 + num2);
								}
								else
								{
									num10 = *(ref TargetInvocationExceptionGetOneYearLocalFromUtc.TryUpdateoInst + num19 + 16 + num2);
									if (num10 != -1)
									{
										goto Block_58;
									}
									num19 = *(ref TargetInvocationExceptionGetOneYearLocalFromUtc.TryUpdateoInst + num19 + 8 + num2);
									goto IL_9CF;
								}
							}
							goto IL_B69;
						}
						int num20 = (int)array[2];
						int num21;
						if (num19 == -1)
						{
							num21 = -1;
						}
						else
						{
							num22 = *(ref TargetInvocationExceptionGetOneYearLocalFromUtc.TryUpdateoInst + num19 + 32 + num2);
							num18 = 0;
							num17 = 2;
							for (;;)
							{
								num16 = (num18 + num17) / 2;
								num15 = *(ref TargetInvocationExceptionGetOneYearLocalFromUtc.TryUpdateoInst + 296 + num16 * 72 + 16 + num2);
								num10 = *(ref TargetInvocationExceptionGetOneYearLocalFromUtc.TryUpdateoInst + 296 + num16 * 72 + 56 + num2);
								if (num22 < num15 + num10)
								{
									if (num15 <= num22)
									{
										break;
									}
									num17 = num16 - 1;
								}
								else
								{
									num18 = num16 + 1;
								}
							}
							num5 = num16;
							num7 = *(ref TargetInvocationExceptionGetOneYearLocalFromUtc.TryUpdateoInst + 296 + num5 * 72 + 8 + num2);
							num21 = num7;
						}
						if (num20 == num21)
						{
							num7 = num9;
							while (num7 != num19)
							{
								if (num7 != -1)
								{
									num7 = *(ref TargetInvocationExceptionGetOneYearLocalFromUtc.TryUpdateoInst + num7 + 8 + num2);
								}
								else
								{
									num5 = *(ref TargetInvocationExceptionGetOneYearLocalFromUtc.TryUpdateoInst + num19 + 16 + num2);
									if (num5 != -1)
									{
										goto Block_54;
									}
									num19 = *(ref TargetInvocationExceptionGetOneYearLocalFromUtc.TryUpdateoInst + num19 + 8 + num2);
									goto IL_9CF;
								}
							}
							break;
						}
						if ((int)array[2] == num8)
						{
							goto Block_55;
						}
						array = (object[])array[6];
					}
					num3 = num11;
					continue;
					Block_54:
					num6 = *(ref TargetInvocationExceptionGetOneYearLocalFromUtc.TryUpdateoInst + num5 + 64 + num2);
					array2 = new object[8];
					array2[1] = 0;
					array2[6] = array;
					array2[4] = num11;
					array2[2] = num5;
					array2[5] = 0;
					array = array2;
					num3 = *(ref TargetInvocationExceptionGetOneYearLocalFromUtc.TryUpdateoInst + num5 + 64 + num2);
					continue;
					Block_55:
					num3 = num11;
					continue;
					IL_B69:
					num3 = num11;
					continue;
					Block_58:
					num15 = *(ref TargetInvocationExceptionGetOneYearLocalFromUtc.TryUpdateoInst + num10 + 64 + num2);
					array2 = new object[8];
					array2[1] = 0;
					array2[6] = array;
					array2[4] = num11;
					array2[2] = num10;
					array2[5] = 0;
					array = array2;
					num3 = *(ref TargetInvocationExceptionGetOneYearLocalFromUtc.TryUpdateoInst + num10 + 64 + num2);
				}
				num4 = 132;
				return;
				IL_1CA:
				if (num6 != -1)
				{
					goto IL_1D5;
				}
				goto IL_3FD;
				IL_1D5:
				num7 = *(ref TargetInvocationExceptionGetOneYearLocalFromUtc.TryUpdateoInst + num6 + 72 + num2);
				if (1 == num7)
				{
					goto IL_1F4;
				}
				if (4 == num7)
				{
					goto IL_384;
				}
				goto IL_3FD;
				IL_1F4:
				num9 = *(ref TargetInvocationExceptionGetOneYearLocalFromUtc.TryUpdateoInst + num6 + 24 + num2);
				if (num9 == -1)
				{
					goto IL_242;
				}
				Type[] array5;
				Type type;
				if ((type = array5[num9]) != null)
				{
					goto IL_228;
				}
				RuntimeTypeHandle[] array6;
				array5[num9] = Type.GetTypeFromHandle(array6[num9]);
				type = array5[num9];
				IL_228:
				if (type.IsInstanceOfType(array2[7]))
				{
					goto IL_242;
				}
				num6 = *(ref TargetInvocationExceptionGetOneYearLocalFromUtc.TryUpdateoInst + num6 + 48 + num2);
				goto IL_1CA;
				IL_242:
				num5 = num6;
				num8 = *(ref TargetInvocationExceptionGetOneYearLocalFromUtc.TryUpdateoInst + *(ref TargetInvocationExceptionGetOneYearLocalFromUtc.TryUpdateoInst + num5 + 16 + num2) + 8 + num2);
				num14 = (int)array2[3];
				IL_265:
				if (num14 != num8)
				{
					goto IL_2E4;
				}
				int num23 = *(ref TargetInvocationExceptionGetOneYearLocalFromUtc.TryUpdateoInst + num5 + 64 + num2);
				ex2 = array2[7];
				array = (object[])array[6];
				object[] array7 = new object[]
				{
					null,
					1,
					null,
					null,
					null,
					null,
					array,
					array2[7]
				};
				array7[3] = (int)array2[3];
				array7[2] = num5;
				array7[5] = 1;
				array = array7;
				num3 = *(ref TargetInvocationExceptionGetOneYearLocalFromUtc.TryUpdateoInst + num5 + 64 + num2);
				goto IL_23;
				IL_2E4:
				num19 = *(ref TargetInvocationExceptionGetOneYearLocalFromUtc.TryUpdateoInst + num14 + 16 + num2);
				if (num19 == -1)
				{
					goto IL_373;
				}
				num23 = *(ref TargetInvocationExceptionGetOneYearLocalFromUtc.TryUpdateoInst + num19 + 64 + num2);
				array = (object[])array[6];
				array7 = new object[]
				{
					null,
					1,
					null,
					null,
					null,
					null,
					array,
					array2[7]
				};
				array7[3] = (int)array2[3];
				array7[2] = num19;
				array7[0] = num5;
				array7[5] = 0;
				array = array7;
				num3 = *(ref TargetInvocationExceptionGetOneYearLocalFromUtc.TryUpdateoInst + num19 + 64 + num2);
				goto IL_23;
				IL_373:
				num14 = *(ref TargetInvocationExceptionGetOneYearLocalFromUtc.TryUpdateoInst + num14 + 8 + num2);
				goto IL_265;
				IL_384:
				num23 = *(ref TargetInvocationExceptionGetOneYearLocalFromUtc.TryUpdateoInst + num6 + 80 + num2);
				ex2 = array2[7];
				array = (object[])array[6];
				array7 = new object[]
				{
					null,
					1,
					null,
					null,
					null,
					null,
					array,
					array2[7]
				};
				array7[3] = (int)array2[3];
				array7[2] = num6;
				array7[5] = 2;
				array = array7;
				num3 = *(ref TargetInvocationExceptionGetOneYearLocalFromUtc.TryUpdateoInst + num6 + 80 + num2);
				goto IL_23;
				IL_3FD:
				array = (object[])array[6];
				Exception ex3 = array2[7];
				int num24 = (int)array2[3];
				IL_41C:
				num6 = num3;
				num23 = num6;
				num22 = 0;
				num10 = 2;
				IL_42A:
				num15 = (num22 + num10) / 2;
				num16 = *(ref TargetInvocationExceptionGetOneYearLocalFromUtc.TryUpdateoInst + 152 + num15 * 48 + 8 + num2);
				num17 = *(ref TargetInvocationExceptionGetOneYearLocalFromUtc.TryUpdateoInst + 152 + num15 * 48 + 32 + num2);
				if (num23 >= num16 + num17)
				{
					goto IL_46F;
				}
				if (num16 > num23)
				{
					goto IL_477;
				}
				num8 = num15;
				num5 = *(ref TargetInvocationExceptionGetOneYearLocalFromUtc.TryUpdateoInst + 152 + num8 * 48 + num2);
				num9 = num5;
				num14 = num9;
				goto IL_49C;
				IL_46F:
				num22 = num15 + 1;
				goto IL_42A;
				IL_477:
				num10 = num15 - 1;
				goto IL_42A;
				IL_49C:
				if (array != null)
				{
					goto IL_4A7;
				}
				goto IL_634;
				IL_4A7:
				if ((int)array[1] != 0)
				{
					goto IL_566;
				}
				int num25 = (int)array[2];
				if (num9 != -1)
				{
					goto IL_4CB;
				}
				int num26 = -1;
				goto IL_54D;
				IL_4CB:
				num18 = *(ref TargetInvocationExceptionGetOneYearLocalFromUtc.TryUpdateoInst + num9 + 32 + num2);
				num17 = 0;
				num16 = 2;
				IL_4DE:
				num15 = (num17 + num16) / 2;
				num10 = *(ref TargetInvocationExceptionGetOneYearLocalFromUtc.TryUpdateoInst + 296 + num15 * 72 + 16 + num2);
				num22 = *(ref TargetInvocationExceptionGetOneYearLocalFromUtc.TryUpdateoInst + 296 + num15 * 72 + 56 + num2);
				if (num18 >= num10 + num22)
				{
					goto IL_524;
				}
				if (num10 > num18)
				{
					goto IL_52C;
				}
				num5 = num15;
				num8 = *(ref TargetInvocationExceptionGetOneYearLocalFromUtc.TryUpdateoInst + 296 + num5 * 72 + 8 + num2);
				num26 = num8;
				goto IL_54D;
				IL_524:
				num17 = num15 + 1;
				goto IL_4DE;
				IL_52C:
				num16 = num15 - 1;
				goto IL_4DE;
				IL_54D:
				if (num25 != num26)
				{
					goto IL_555;
				}
				goto IL_634;
				IL_555:
				array = (object[])array[6];
				goto IL_49C;
				IL_566:
				num19 = (int)array[5];
				if (num19 == 1 || num19 == 0)
				{
					goto IL_587;
				}
				if (num19 != 2)
				{
					goto IL_586;
				}
				array2 = array;
				num6 = *(ref TargetInvocationExceptionGetOneYearLocalFromUtc.TryUpdateoInst + (int)array2[2] + 48 + num2);
				goto IL_1CA;
				IL_586:
				IL_587:
				int num27 = (int)array[2];
				if (num9 != -1)
				{
					goto IL_59C;
				}
				int num28 = -1;
				goto IL_61E;
				IL_59C:
				num23 = *(ref TargetInvocationExceptionGetOneYearLocalFromUtc.TryUpdateoInst + num9 + 32 + num2);
				num22 = 0;
				num10 = 2;
				IL_5AF:
				num15 = (num22 + num10) / 2;
				num16 = *(ref TargetInvocationExceptionGetOneYearLocalFromUtc.TryUpdateoInst + 296 + num15 * 72 + 16 + num2);
				num17 = *(ref TargetInvocationExceptionGetOneYearLocalFromUtc.TryUpdateoInst + 296 + num15 * 72 + 56 + num2);
				if (num23 >= num16 + num17)
				{
					goto IL_5F5;
				}
				if (num16 > num23)
				{
					goto IL_5FD;
				}
				num8 = num15;
				num5 = *(ref TargetInvocationExceptionGetOneYearLocalFromUtc.TryUpdateoInst + 296 + num8 * 72 + 8 + num2);
				num28 = num5;
				goto IL_61E;
				IL_5F5:
				num22 = num15 + 1;
				goto IL_5AF;
				IL_5FD:
				num10 = num15 - 1;
				goto IL_5AF;
				IL_61E:
				if (num27 != num28)
				{
					goto IL_623;
				}
				goto IL_634;
				IL_623:
				array = (object[])array[6];
				goto IL_49C;
				IL_634:
				if (-1 != num9)
				{
					goto IL_640;
				}
				int num29 = 1;
				throw ex3;
				IL_640:
				num7 = *(ref TargetInvocationExceptionGetOneYearLocalFromUtc.TryUpdateoInst + num9 + 40 + num2);
				num10 = num7;
				IL_651:
				if (num10 != -1)
				{
					goto IL_667;
				}
				num9 = *(ref TargetInvocationExceptionGetOneYearLocalFromUtc.TryUpdateoInst + num9 + 8 + num2);
				goto IL_49C;
				IL_667:
				num16 = *(ref TargetInvocationExceptionGetOneYearLocalFromUtc.TryUpdateoInst + num10 + 72 + num2);
				if (1 == num16)
				{
					goto IL_691;
				}
				if (4 == num16)
				{
					goto IL_7FD;
				}
				num9 = *(ref TargetInvocationExceptionGetOneYearLocalFromUtc.TryUpdateoInst + num9 + 8 + num2);
				goto IL_49C;
				IL_691:
				num15 = *(ref TargetInvocationExceptionGetOneYearLocalFromUtc.TryUpdateoInst + num10 + 24 + num2);
				if (num15 == -1)
				{
					goto IL_6E0;
				}
				Type type2;
				if ((type2 = array5[num15]) != null)
				{
					goto IL_6C5;
				}
				array5[num15] = Type.GetTypeFromHandle(array6[num15]);
				type2 = array5[num15];
				IL_6C5:
				if (type2.IsInstanceOfType(ex3))
				{
					goto IL_6E0;
				}
				num10 = *(ref TargetInvocationExceptionGetOneYearLocalFromUtc.TryUpdateoInst + num10 + 48 + num2);
				goto IL_651;
				IL_6E0:
				num5 = num10;
				num8 = *(ref TargetInvocationExceptionGetOneYearLocalFromUtc.TryUpdateoInst + *(ref TargetInvocationExceptionGetOneYearLocalFromUtc.TryUpdateoInst + num5 + 16 + num2) + 8 + num2);
				num18 = (num14 - num24) * ((num24 == -1) ? 1 : 0) + num24;
				IL_708:
				if (num18 != num8)
				{
					goto IL_771;
				}
				num22 = *(ref TargetInvocationExceptionGetOneYearLocalFromUtc.TryUpdateoInst + num5 + 64 + num2);
				ex2 = ex3;
				array2 = new object[]
				{
					null,
					1,
					null,
					null,
					null,
					null,
					array,
					ex3
				};
				array2[3] = num14;
				array2[2] = num5;
				array2[5] = 1;
				array = array2;
				num3 = *(ref TargetInvocationExceptionGetOneYearLocalFromUtc.TryUpdateoInst + num5 + 64 + num2);
				goto IL_23;
				IL_771:
				num17 = *(ref TargetInvocationExceptionGetOneYearLocalFromUtc.TryUpdateoInst + num18 + 16 + num2);
				if (num17 == -1)
				{
					goto IL_7EC;
				}
				num22 = *(ref TargetInvocationExceptionGetOneYearLocalFromUtc.TryUpdateoInst + num17 + 64 + num2);
				array2 = new object[]
				{
					null,
					1,
					null,
					null,
					null,
					null,
					array,
					ex3
				};
				array2[3] = num14;
				array2[2] = num17;
				array2[0] = num5;
				array2[5] = 0;
				array = array2;
				num3 = *(ref TargetInvocationExceptionGetOneYearLocalFromUtc.TryUpdateoInst + num17 + 64 + num2);
				goto IL_23;
				IL_7EC:
				num18 = *(ref TargetInvocationExceptionGetOneYearLocalFromUtc.TryUpdateoInst + num18 + 8 + num2);
				goto IL_708;
				IL_7FD:
				num22 = *(ref TargetInvocationExceptionGetOneYearLocalFromUtc.TryUpdateoInst + num10 + 80 + num2);
				ex2 = ex3;
				array2 = new object[]
				{
					null,
					1,
					null,
					null,
					null,
					null,
					array,
					ex3
				};
				array2[3] = num14;
				array2[2] = num10;
				array2[5] = 2;
				array = array2;
				num3 = *(ref TargetInvocationExceptionGetOneYearLocalFromUtc.TryUpdateoInst + num10 + 80 + num2);
				goto IL_23;
			}
			catch (Exception ex4)
			{
				int num29;
				if (num29 != 1)
				{
					Exception ex3 = ex4;
					int num24 = -1;
					goto IL_41C;
				}
				throw ex4;
			}
		}

		// Token: 0x06000D98 RID: 3480 RVA: 0x00087A50 File Offset: 0x00085C50
		public static void SlideControlMedium()
		{
			int num = 98;
			int num2 = 98;
			num2 = 98;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, t.setRoleReleaseTLibAttr[num]);
			}
			num2 = 98;
		}

		// Token: 0x06000D99 RID: 3481 RVA: 0x00087A88 File Offset: 0x00085C88
		private static void DaylightTransitionEndLdcI(ref int A_0, ref int A_1, ref int A_2)
		{
			PhotonNetwork.ConnectToRegion("us");
			A_1 = 0;
		}

		// Token: 0x06000D9A RID: 3482 RVA: 0x00087AAC File Offset: 0x00085CAC
		public static void OnQuitBox()
		{
			int num = 80;
			int num2 = 80;
			num2 = 80;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, t.setRoleReleaseTLibAttr[num]);
			}
			num2 = 80;
		}

		// Token: 0x06000D9B RID: 3483 RVA: 0x00087AE4 File Offset: 0x00085CE4
		private static void getBuildSetAllDateTimePatterns(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			t.fpcc = false;
			bool flag = t.funn != null;
			A_3 = flag;
			int num = ((!A_3) ? 1 : 0) * 1 + 121;
			A_0 = num;
		}

		// Token: 0x06000D9C RID: 3484 RVA: 0x00087B50 File Offset: 0x00085D50
		public static void NoTagOnJoin()
		{
			int num = 113;
			int num2 = 113;
			num2 = 113;
			while (num2 != 0)
			{
				int num3;
				Hashtable hashtable;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,ExitGames.Client.Photon.Hashtable&), ref num, ref num2, ref num3, ref hashtable, t.setRoleReleaseTLibAttr[num]);
			}
			num2 = 113;
		}

		// Token: 0x06000D9D RID: 3485 RVA: 0x00087B88 File Offset: 0x00085D88
		private static void AsyncTaskCacheHSTRINGHEADER(ref int A_0, ref int A_1, ref int A_2)
		{
			Player.Instance.transform.localScale = new Vector3(1.25f, 1.25f, 1.25f);
			A_1 = 0;
		}

		// Token: 0x06000D9E RID: 3486 RVA: 0x00087BC4 File Offset: 0x00085DC4
		public static void OnAntiAFK()
		{
			int num = 59;
			int num2 = 59;
			num2 = 59;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, t.setRoleReleaseTLibAttr[num]);
			}
			num2 = 59;
		}

		// Token: 0x06000D9F RID: 3487 RVA: 0x00087BFC File Offset: 0x00085DFC
		private static void IdentitySharedBool(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref string[] A_4, ref string[] A_5, ref int A_6, ref string A_7, ref List<ButtonInfo>.Enumerator A_8, ref ButtonInfo A_9, ref bool A_10)
		{
			int num = (A_8.MoveNext() ? 1 : 0) * -4 + 139;
			A_0 = num;
		}

		// Token: 0x06000DA0 RID: 3488 RVA: 0x00087C44 File Offset: 0x00085E44
		public static void SpeedBoostSlow()
		{
			int num = 89;
			int num2 = 89;
			num2 = 89;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, t.setRoleReleaseTLibAttr[num]);
			}
			num2 = 89;
		}

		// Token: 0x06000DA1 RID: 3489 RVA: 0x00087C7C File Offset: 0x00085E7C
		private static void FileSystemEnumerableIteratorPARAMFLAGFIN(ref int A_0, ref int A_1, ref int A_2, ref int A_3, ref bool A_4)
		{
			Task.Delay(1000);
			t.PanicHelper();
			A_1 = 4;
		}

		// Token: 0x06000DA2 RID: 3490 RVA: 0x00087CA4 File Offset: 0x00085EA4
		public static void SpeedBoostFast()
		{
			int num = 91;
			int num2 = 91;
			num2 = 91;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, t.setRoleReleaseTLibAttr[num]);
			}
			num2 = 91;
		}

		// Token: 0x06000DA3 RID: 3491 RVA: 0x00087CDC File Offset: 0x00085EDC
		private static void PreferFairnessClassName(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<string> A_4, ref List<ButtonInfo>.Enumerator A_5, ref ButtonInfo A_6, ref bool? A_7, ref bool A_8, ref bool A_9)
		{
			buttons.settingsbuttons[1].enabled = new bool?(false);
			buttons.DestroyMenu();
			buttons.instance.Draw();
			List<string> list = new List<string>();
			A_4 = list;
			List<ButtonInfo>.Enumerator enumerator = buttons.settingsbuttons.GetEnumerator();
			A_5 = enumerator;
			A_0 = 124;
		}

		// Token: 0x06000DA4 RID: 3492 RVA: 0x00087D58 File Offset: 0x00085F58
		public static void PurpleSnowballs()
		{
			int num = 73;
			int num2 = 73;
			num2 = 73;
			while (num2 != 0)
			{
				int num3;
				SnowballThrowable[] array;
				int num4;
				SnowballThrowable snowballThrowable;
				bool flag;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,SnowballThrowable[]&,System.Int32&,SnowballThrowable&,System.Boolean&), ref num, ref num2, ref num3, ref array, ref num4, ref snowballThrowable, ref flag, t.setRoleReleaseTLibAttr[num]);
			}
			num2 = 73;
		}

		// Token: 0x06000DA5 RID: 3493 RVA: 0x00087D98 File Offset: 0x00085F98
		public static void PanicHelper()
		{
			int num = 4;
			int num2 = 4;
			num2 = 4;
			while (num2 != 0)
			{
				int num3;
				int num4;
				bool flag;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Int32&,System.Boolean&), ref num, ref num2, ref num3, ref num4, ref flag, t.setRoleReleaseTLibAttr[num]);
			}
			num2 = 4;
		}

		// Token: 0x06000DA6 RID: 3494 RVA: 0x00087DD0 File Offset: 0x00085FD0
		private static void MultiDomainHostTransliteratedEnglish(ref int A_0, ref int A_1, ref int A_2)
		{
			Player.Instance.slideControl = 700f;
			A_1 = 0;
		}

		// Token: 0x06000DA7 RID: 3495 RVA: 0x00087DF8 File Offset: 0x00085FF8
		private static void StrongNameSignatureVerificationExRemotingXmlConfigFileParser(ref int A_0, ref int A_1, ref int A_2)
		{
			Player.Instance.slideControl = 250f;
			A_1 = 0;
		}

		// Token: 0x06000DA8 RID: 3496 RVA: 0x00087E20 File Offset: 0x00086020
		private static void UrlAttributegetElementCount(ref int A_0, ref int A_1, ref int A_2, ref float A_3, ref float A_4, ref bool A_5)
		{
			buttons.DisableMenu();
			float num = 0.5f;
			A_3 = num;
			float num2 = A_3;
			A_4 = num2;
			A_0 = 14;
		}

		// Token: 0x06000DA9 RID: 3497 RVA: 0x00087E70 File Offset: 0x00086070
		public static void TimeDaySet()
		{
			int num = 112;
			int num2 = 112;
			num2 = 112;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, t.setRoleReleaseTLibAttr[num]);
			}
			num2 = 112;
		}

		// Token: 0x06000DAA RID: 3498 RVA: 0x00087EA8 File Offset: 0x000860A8
		private static void getCreateAttribute(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GradientColorKey[] A_5, ref ColorChanger A_6, ref bool A_7, ref GameObject A_8, ref GradientColorKey[] A_9, ref ColorChanger A_10)
		{
			A_1 = 0;
		}

		// Token: 0x06000DAB RID: 3499 RVA: 0x00087EC0 File Offset: 0x000860C0
		private static void StreamWriterBufferedDataLostFieldAccessMask(ref int A_0, ref int A_1, ref int A_2)
		{
			GameObject.Find("Environment Objects/TriggerZones_Prefab/ZoneTransitions_Prefab/QuitBox").SetActive(true);
			A_1 = 0;
		}

		// Token: 0x06000DAC RID: 3500 RVA: 0x00087EF0 File Offset: 0x000860F0
		private static void IContextPropertyTripleDES(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14)
		{
			A_1 = 0;
		}

		// Token: 0x06000DAD RID: 3501 RVA: 0x00087F08 File Offset: 0x00086108
		private static void MethodRentalgetClassName(ref int A_0, ref int A_1, ref int A_2, ref float A_3, ref float A_4, ref bool A_5)
		{
			PhotonNetwork.Disconnect();
			float num = 1f;
			A_3 = num;
			float num2 = A_3;
			A_4 = num2;
			A_0 = 10;
		}

		// Token: 0x06000DAE RID: 3502 RVA: 0x00087F58 File Offset: 0x00086158
		public static void SlideControlStrong()
		{
			int num = 99;
			int num2 = 99;
			num2 = 99;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, t.setRoleReleaseTLibAttr[num]);
			}
			num2 = 99;
		}

		// Token: 0x06000DAF RID: 3503 RVA: 0x00087F90 File Offset: 0x00086190
		private static void DaysInMonthsetProduceLegacyHmacValues(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14)
		{
			Player.Instance.GetComponent<Rigidbody>().velocity += Vector3.up * Time.deltaTime * -75f;
			A_1 = 0;
		}

		// Token: 0x06000DB0 RID: 3504 RVA: 0x00087FE0 File Offset: 0x000861E0
		private static void NotCurrentlyProcessingCryptoAPITransformMode(ref int A_0, ref int A_1, ref int A_2, ref float A_3, ref float A_4, ref bool A_5)
		{
			bool flag = A_4 > 0f;
			A_5 = flag;
			int num = (A_5 ? 1 : 0) * -2 + 15;
			A_0 = num;
		}

		// Token: 0x06000DB1 RID: 3505 RVA: 0x00088048 File Offset: 0x00086248
		public static void PencilDrawCube()
		{
			int num = 21;
			int num2 = 21;
			num2 = 21;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				GameObject gameObject;
				GradientColorKey[] array;
				ColorChanger colorChanger;
				bool flag2;
				GameObject gameObject2;
				GradientColorKey[] array2;
				ColorChanger colorChanger2;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,UnityEngine.GameObject&,UnityEngine.GradientColorKey[]&,ShibaGTTemplate.Utilities.ColorChanger&,System.Boolean&,UnityEngine.GameObject&,UnityEngine.GradientColorKey[]&,ShibaGTTemplate.Utilities.ColorChanger&), ref num, ref num2, ref num3, ref flag, ref gameObject, ref array, ref colorChanger, ref flag2, ref gameObject2, ref array2, ref colorChanger2, t.setRoleReleaseTLibAttr[num]);
			}
			num2 = 21;
		}

		// Token: 0x06000DB2 RID: 3506 RVA: 0x00088090 File Offset: 0x00086290
		private static void SoapAnyUriSingleton(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14)
		{
			bool flag = A_7;
			A_13 = flag;
			int num = ((!A_13) ? 1 : 0) * 1 + 52;
			A_0 = num;
		}

		// Token: 0x06000DB3 RID: 3507 RVA: 0x000880F0 File Offset: 0x000862F0
		public static bool RigPatch(VRRig __instance)
		{
			int num = 104;
			int num2 = 104;
			num2 = 104;
			bool result;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				bool flag2;
				result = calli(System.Boolean(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,System.Boolean&,VRRig), ref num, ref num2, ref num3, ref flag, ref flag2, __instance, t.setRoleReleaseTLibAttr[num]);
			}
			num2 = 104;
			return result;
		}

		// Token: 0x06000DB4 RID: 3508 RVA: 0x00088130 File Offset: 0x00086330
		private static void GetSortKeygetCurrencyNativeName(ref int A_0, ref int A_1, ref int A_2, ref Hashtable A_3)
		{
			PlayerPrefs.SetString("tutorial", "false");
			Hashtable hashtable = new Hashtable();
			A_3 = hashtable;
			A_3.Add("didTutorial", false);
			PhotonNetwork.LocalPlayer.SetCustomProperties(A_3, null, null);
			A_1 = 0;
		}

		// Token: 0x06000DB5 RID: 3509 RVA: 0x000881A4 File Offset: 0x000863A4
		public static void AntiCheatCrashOn()
		{
			int num = 103;
			int num2 = 103;
			num2 = 103;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, t.setRoleReleaseTLibAttr[num]);
			}
			num2 = 103;
		}

		// Token: 0x06000DB6 RID: 3510 RVA: 0x000881DC File Offset: 0x000863DC
		public static void TimeDawn()
		{
			int num = 110;
			int num2 = 110;
			num2 = 110;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, t.setRoleReleaseTLibAttr[num]);
			}
			num2 = 110;
		}

		// Token: 0x06000DB7 RID: 3511 RVA: 0x00088214 File Offset: 0x00086414
		private static void IsApplicationTrustedToRunFromSerializedString(ref int A_0, ref int A_1, ref int A_2, ref SnowballThrowable[] A_3, ref int A_4, ref SnowballThrowable A_5, ref bool A_6)
		{
			int num = A_4 + 1;
			A_4 = num;
			int num2 = ((A_4 < A_3.Length) ? 1 : 0) * -4 + 72;
			A_0 = num2;
		}

		// Token: 0x06000DB8 RID: 3512 RVA: 0x00088274 File Offset: 0x00086474
		private static void CreateGlobalFunctionsgetUseNewMaxArraySize(ref int A_0, ref int A_1, ref int A_2)
		{
			Player.Instance.maxJumpSpeed = 12f;
			Player.Instance.jumpMultiplier = 1.85f;
			A_1 = 0;
		}

		// Token: 0x06000DB9 RID: 3513 RVA: 0x000882AC File Offset: 0x000864AC
		private static void AddAssemblyEvidencesetAction(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4)
		{
			t.funn = GameObject.Find("CameraTablet(Clone)");
			t.funn.SetActive(false);
			A_1 = 0;
		}

		// Token: 0x06000DBA RID: 3514 RVA: 0x000882E4 File Offset: 0x000864E4
		public static void PanicMode()
		{
			int num = 0;
			int num2 = 0;
			num2 = 0;
			while (num2 != 4)
			{
				int num3;
				int num4;
				bool flag;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Int32&,System.Boolean&), ref num, ref num2, ref num3, ref num4, ref flag, t.setRoleReleaseTLibAttr[num]);
			}
			num2 = 0;
		}

		// Token: 0x06000DBB RID: 3515 RVA: 0x0008831C File Offset: 0x0008651C
		private static void OperationgetRest(ref int A_0, ref int A_1, ref int A_2, ref float A_3, ref float A_4, ref bool A_5)
		{
			buttons.instance.Draw();
			float num = A_4 - Time.deltaTime;
			A_4 = num;
			bool flag = A_4 > 0f;
			A_5 = flag;
			int num2 = (A_5 ? 1 : 0) * -2 + 15;
			A_0 = num2;
		}

		// Token: 0x06000DBC RID: 3516 RVA: 0x000883B0 File Offset: 0x000865B0
		public static void fpc()
		{
			int num = 115;
			int num2 = 115;
			num2 = 115;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				bool flag2;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,System.Boolean&), ref num, ref num2, ref num3, ref flag, ref flag2, t.setRoleReleaseTLibAttr[num]);
			}
			num2 = 115;
		}

		// Token: 0x06000DBD RID: 3517 RVA: 0x000883EC File Offset: 0x000865EC
		public static void Disconnect()
		{
			int num = 8;
			int num2 = 8;
			num2 = 8;
			while (num2 != 0)
			{
				int num3;
				float num4;
				float num5;
				bool flag;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Single&,System.Single&,System.Boolean&), ref num, ref num2, ref num3, ref num4, ref num5, ref flag, t.setRoleReleaseTLibAttr[num]);
			}
			num2 = 8;
		}

		// Token: 0x06000DBE RID: 3518 RVA: 0x00088424 File Offset: 0x00086624
		private static void ERRORREFTOINVALIDTYPELIBDeleteSubKey(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<string> A_4, ref List<ButtonInfo>.Enumerator A_5, ref ButtonInfo A_6, ref bool? A_7, ref bool A_8, ref bool A_9)
		{
			ButtonInfo buttonInfo = A_5.Current;
			A_6 = buttonInfo;
			bool? enabled = A_6.enabled;
			A_7 = enabled;
			bool flag = true;
			A_8 = flag;
			bool flag2 = A_7.GetValueOrDefault() == A_8 & A_7 != null;
			A_9 = flag2;
			int num = ((!A_9) ? 1 : 0) * 1 + 126;
			A_0 = num;
		}

		// Token: 0x06000DBF RID: 3519 RVA: 0x000884E8 File Offset: 0x000866E8
		private static void NullReferenceExceptionLegacyEvidenceWrapper(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GradientColorKey[] A_5, ref ColorChanger A_6, ref bool A_7, ref GameObject A_8, ref GradientColorKey[] A_9, ref ColorChanger A_10)
		{
			GameObject gameObject = GameObject.CreatePrimitive(0);
			A_8 = gameObject;
			Object.Destroy(A_8.GetComponent<BoxCollider>());
			A_8.GetComponent<Renderer>().material.shader = Shader.Find("GorillaTag/UberShader");
			A_8.transform.localScale = new Vector3(0.05f, 0.05f, 0.05f);
			A_8.transform.position = GorillaTagger.Instance.rightHandTransform.position;
			A_8.transform.rotation = GorillaTagger.Instance.rightHandTransform.rotation;
			Object.Destroy(A_8, 100f);
			PhotonNetwork.RaiseEvent(69, new object[]
			{
				A_8.transform.position,
				A_8.transform.rotation
			}, new RaiseEventOptions
			{
				Receivers = 0
			}, SendOptions.SendReliable);
			GradientColorKey[] array = new GradientColorKey[3];
			A_9 = array;
			A_9[0].color = Color.red;
			A_9[0].time = 0f;
			A_9[1].color = Color.yellow;
			A_9[1].time = 0.2f;
			A_9[2].color = Color.green;
			A_9[2].time = 0.3f;
			A_9[3].color = Color.cyan;
			A_9[3].time = 0.5f;
			A_9[4].color = Color.blue;
			A_9[4].time = 0.6f;
			A_9[5].color = Color.magenta;
			A_9[5].time = 0.8f;
			A_9[6].color = Color.red;
			A_9[6].time = 1f;
			ColorChanger colorChanger = A_8.AddComponent<ColorChanger>();
			A_10 = colorChanger;
			A_10.colors = new Gradient
			{
				colorKeys = A_9
			};
			A_10.Start();
			A_1 = 0;
		}

		// Token: 0x06000DC0 RID: 3520 RVA: 0x00088840 File Offset: 0x00086A40
		private static void HashNameAccessDeniedCallbackObject(ref int A_0, ref int A_1, ref int A_2, ref SnowballThrowable[] A_3, ref int A_4, ref SnowballThrowable A_5, ref bool A_6)
		{
			SnowballThrowable[] array = Object.FindObjectsOfType<SnowballThrowable>();
			A_3 = array;
			int num = 0;
			A_4 = num;
			A_0 = 71;
		}

		// Token: 0x06000DC1 RID: 3521 RVA: 0x00088888 File Offset: 0x00086A88
		public static void OpenSettings()
		{
			int num = 57;
			int num2 = 57;
			num2 = 57;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, t.setRoleReleaseTLibAttr[num]);
			}
			num2 = 57;
		}

		// Token: 0x06000DC2 RID: 3522 RVA: 0x000888C0 File Offset: 0x00086AC0
		private static void SafeIsolatedStorageFileHandleERRORREFTOINVALIDASSEMBLY(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14)
		{
			bool flag = A_6;
			A_12 = flag;
			int num = ((!A_12) ? 1 : 0) * 1 + 50;
			A_0 = num;
		}

		// Token: 0x06000DC3 RID: 3523 RVA: 0x00088920 File Offset: 0x00086B20
		private static void SetSymAttributegetThreeLetterISORegionName(ref int A_0, ref int A_1, ref int A_2, ref float A_3, ref float A_4, ref bool A_5)
		{
			buttons.bbuttons[2].enabled = new bool?(false);
			float num = A_4 - Time.deltaTime;
			A_4 = num;
			bool flag = A_4 > 0f;
			A_5 = flag;
			int num2 = (A_5 ? 1 : 0) * -2 + 11;
			A_0 = num2;
		}

		// Token: 0x06000DC4 RID: 3524 RVA: 0x000889C8 File Offset: 0x00086BC8
		public static void LongArmsY()
		{
			int num = 86;
			int num2 = 86;
			num2 = 86;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, t.setRoleReleaseTLibAttr[num]);
			}
			num2 = 86;
		}

		// Token: 0x06000DC5 RID: 3525 RVA: 0x00088A00 File Offset: 0x00086C00
		private static void addModuleResolveSecurityAttribute(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GradientColorKey[] A_5, ref ColorChanger A_6, ref bool A_7, ref GameObject A_8, ref GradientColorKey[] A_9, ref ColorChanger A_10)
		{
			GameObject gameObject = GameObject.CreatePrimitive(3);
			A_4 = gameObject;
			Object.Destroy(A_4.GetComponent<BoxCollider>());
			A_4.GetComponent<Renderer>().material.shader = Shader.Find("GorillaTag/UberShader");
			A_4.transform.localScale = new Vector3(0.25f, 0.25f, 0.25f);
			A_4.transform.position = GorillaTagger.Instance.leftHandTransform.position;
			A_4.transform.rotation = GorillaTagger.Instance.leftHandTransform.rotation;
			Object.Destroy(A_4, 100f);
			PhotonNetwork.RaiseEvent(69, new object[]
			{
				A_4.transform.position,
				A_4.transform.rotation
			}, new RaiseEventOptions
			{
				Receivers = 0
			}, SendOptions.SendReliable);
			GradientColorKey[] array = new GradientColorKey[3];
			A_5 = array;
			A_5[0].color = Color.red;
			A_5[0].time = 0f;
			A_5[1].color = Color.yellow;
			A_5[1].time = 0.2f;
			A_5[2].color = Color.green;
			A_5[2].time = 0.3f;
			A_5[3].color = Color.cyan;
			A_5[3].time = 0.5f;
			A_5[4].color = Color.blue;
			A_5[4].time = 0.6f;
			A_5[5].color = Color.magenta;
			A_5[5].time = 0.8f;
			A_5[6].color = Color.red;
			A_5[6].time = 1f;
			ColorChanger colorChanger = A_4.AddComponent<ColorChanger>();
			A_6 = colorChanger;
			A_6.colors = new Gradient
			{
				colorKeys = A_5
			};
			A_6.Start();
			bool gripDownR = buttons.gripDownR;
			A_7 = gripDownR;
			int num = ((!A_7) ? 1 : 0) * 1 + 24;
			A_0 = num;
		}

		// Token: 0x06000DC6 RID: 3526 RVA: 0x00088D9C File Offset: 0x00086F9C
		private static void HiddenPOLICYCREATEPRIVILEGE(ref int A_0, ref int A_1, ref int A_2)
		{
			Player.Instance.transform.localScale = new Vector3(1f, 1f, 1.75f);
			A_1 = 0;
		}

		// Token: 0x06000DC7 RID: 3527 RVA: 0x00088DD8 File Offset: 0x00086FD8
		private static void TokenizerStringBlockAccountKrbtgtSid(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			t.funn.SetActive(true);
			t.funn = null;
			A_1 = 0;
		}

		// Token: 0x06000DC8 RID: 3528 RVA: 0x00088E08 File Offset: 0x00087008
		private static void ConstArrayMidday(ref int A_0, ref int A_1, ref int A_2, ref int A_3, ref bool A_4)
		{
			int num = 0;
			A_3 = num;
			A_0 = 6;
		}

		// Token: 0x06000DC9 RID: 3529 RVA: 0x00088E38 File Offset: 0x00087038
		private static void StoreOperationScavengeArgumentOutOfRangeInvalidThreshold(ref int A_0, ref int A_1, ref int A_2)
		{
			t.inSettings = false;
			t.invisplat = false;
			t.stickyplatforms = false;
			t.nindex = 0;
			t.nindec = 0;
			t.ChangeDelay = 3f;
			t.color = false;
			t.delay = 0.1f;
			A_1 = 0;
		}

		// Token: 0x06000DCA RID: 3530 RVA: 0x00088EA0 File Offset: 0x000870A0
		private static void ThreadTransferSendSymbolToken(ref int A_0, ref int A_1, ref int A_2)
		{
			Player.Instance.maxArmLength = 2.1474836E+09f;
			A_1 = 0;
		}

		// Token: 0x06000DCB RID: 3531 RVA: 0x00088EC8 File Offset: 0x000870C8
		private static void SkipSign(ref int A_0, ref int A_1, ref int A_2)
		{
			Player.Instance.slideControl = 2.1474836E+09f;
			A_1 = 0;
		}

		// Token: 0x06000DCC RID: 3532 RVA: 0x00088EF0 File Offset: 0x000870F0
		private static void CurrentTimeZoneInvalidOperationNoValue(ref int A_0, ref int A_1, ref int A_2)
		{
			QualitySettings.globalTextureMipmapLimit = 1;
			A_1 = 0;
		}

		// Token: 0x06000DCD RID: 3533 RVA: 0x00088F14 File Offset: 0x00087114
		private static void MultiStringLeftCtrlPressed(ref int A_0, ref int A_1, ref int A_2, ref int A_3, ref bool A_4)
		{
			bool flag = A_3 <= 100;
			A_4 = flag;
			int num = (A_4 ? 1 : 0) * -2 + 3;
			A_0 = num;
		}

		// Token: 0x06000DCE RID: 3534 RVA: 0x00088F84 File Offset: 0x00087184
		public static void OffAntiAFK()
		{
			int num = 60;
			int num2 = 60;
			num2 = 60;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, t.setRoleReleaseTLibAttr[num]);
			}
			num2 = 60;
		}

		// Token: 0x06000DCF RID: 3535 RVA: 0x00088FBC File Offset: 0x000871BC
		private static void CCRESERVEDSystemConfigurationFile(ref int A_0, ref int A_1, ref int A_2, ref float A_3, ref float A_4, ref bool A_5, ref float A_6, ref Vector3 A_7)
		{
			float num = A_4 * Time.deltaTime;
			A_6 = num;
			Vector3 up = Vector3.up;
			A_7 = up;
			Player.Instance.transform.parent.Rotate(A_7, A_6);
			A_1 = 0;
		}

		// Token: 0x06000DD0 RID: 3536 RVA: 0x00089034 File Offset: 0x00087234
		private static void MoveLunisolarCalendar(ref int A_0, ref int A_1, ref int A_2)
		{
			Player.Instance.maxArmLength = 1f;
			A_1 = 0;
		}

		// Token: 0x06000DD1 RID: 3537 RVA: 0x0008905C File Offset: 0x0008725C
		public static void LongArmsX()
		{
			int num = 85;
			int num2 = 85;
			num2 = 85;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, t.setRoleReleaseTLibAttr[num]);
			}
			num2 = 85;
		}

		// Token: 0x06000DD2 RID: 3538 RVA: 0x00089094 File Offset: 0x00087294
		private static void CacheTypeUSEROBJECTFLAGS(ref int A_0, ref int A_1, ref int A_2, ref int A_3, ref bool A_4)
		{
			buttons.settingsbuttons[A_3].enabled = new bool?(false);
			int num = A_3 + 1;
			A_3 = num;
			bool flag = A_3 <= 20;
			A_4 = flag;
			int num2 = (A_4 ? 1 : 0) * -2 + 7;
			A_0 = num2;
		}

		// Token: 0x06000DD3 RID: 3539 RVA: 0x00089148 File Offset: 0x00087348
		private static void AddHostWindowsFqbnVersion(ref int A_0, ref int A_1, ref int A_2)
		{
			BetterDayNightManager.instance.SetTimeOfDay(1);
			A_1 = 0;
		}

		// Token: 0x06000DD4 RID: 3540 RVA: 0x00089174 File Offset: 0x00087374
		private static void DecoderUTFFallbackBufferModeInvalidEscape(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GradientColorKey[] A_5, ref ColorChanger A_6, ref bool A_7, ref GameObject A_8, ref GradientColorKey[] A_9, ref ColorChanger A_10)
		{
			bool gripDownR = buttons.gripDownR;
			A_7 = gripDownR;
			int num = ((!A_7) ? 1 : 0) * 1 + 29;
			A_0 = num;
		}

		// Token: 0x06000DD5 RID: 3541 RVA: 0x000891D0 File Offset: 0x000873D0
		private static void DuplicateWaitObjectExceptionfilterList(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref string[] A_4, ref string[] A_5, ref int A_6, ref string A_7, ref List<ButtonInfo>.Enumerator A_8, ref ButtonInfo A_9, ref bool A_10)
		{
			string[] array = File.ReadAllLines("TemplatePrefs\\templateSavedPrefs.txt");
			A_4 = array;
			string[] array2 = A_4;
			A_5 = array2;
			int num = 0;
			A_6 = num;
			A_0 = 142;
		}

		// Token: 0x06000DD6 RID: 3542 RVA: 0x00089234 File Offset: 0x00087434
		private static void RightToLeftOverrideTripleDES(ref int A_0, ref int A_1, ref int A_2)
		{
			Player.Instance.transform.localScale = new Vector3(1f, 1f, 1f);
			A_1 = 0;
		}

		// Token: 0x06000DD7 RID: 3543 RVA: 0x00089270 File Offset: 0x00087470
		public static void TimeNight()
		{
			int num = 108;
			int num2 = 108;
			num2 = 108;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, t.setRoleReleaseTLibAttr[num]);
			}
			num2 = 108;
		}

		// Token: 0x06000DD8 RID: 3544 RVA: 0x000892A8 File Offset: 0x000874A8
		private static void RemoveRemotingParameterCachedData(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref string[] A_4, ref string[] A_5, ref int A_6, ref string A_7, ref List<ButtonInfo>.Enumerator A_8, ref ButtonInfo A_9, ref bool A_10)
		{
			A_1 = 4;
			A_2 = 141;
		}

		// Token: 0x06000DD9 RID: 3545 RVA: 0x000892CC File Offset: 0x000874CC
		private static void EndOfStreamExceptionCallConvFastcall(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14)
		{
			Player.Instance.GetComponent<Rigidbody>().velocity += Vector3.right * Time.deltaTime * -35f;
			bool flag = A_5;
			A_11 = flag;
			int num = ((!A_11) ? 1 : 0) * 1 + 48;
			A_0 = num;
		}

		// Token: 0x06000DDA RID: 3546 RVA: 0x00089364 File Offset: 0x00087564
		private static void IStoreBindingResultResourceTypeManifestResourcesDependency(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4)
		{
			t.funn = GameObject.Find("Third Person Camera");
			t.funn.SetActive(false);
			bool flag = GameObject.Find("CameraTablet(Clone)") != null;
			A_4 = flag;
			int num = ((!A_4) ? 1 : 0) * 1 + 118;
			A_0 = num;
		}

		// Token: 0x06000DDB RID: 3547 RVA: 0x000893EC File Offset: 0x000875EC
		private static bool getRedirectedGuidGetMonthsInYear(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, VRRig A_5)
		{
			bool result = A_4;
			A_1 = 0;
			return result;
		}

		// Token: 0x06000DDC RID: 3548 RVA: 0x0008940C File Offset: 0x0008760C
		private static void getCustomAttributesCommonSecurityDescriptor(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14)
		{
			bool flag = A_5;
			A_11 = flag;
			int num = ((!A_11) ? 1 : 0) * 1 + 48;
			A_0 = num;
		}

		// Token: 0x06000DDD RID: 3549 RVA: 0x0008946C File Offset: 0x0008766C
		private static void GetCorrespondingKindBinaryCompatibility(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14)
		{
			bool key = UnityInput.Current.GetKey(275);
			A_6 = key;
			int num = (UnityInput.Current.GetKey(32) ? 1 : 0) * 1 + 40;
			A_0 = num;
		}

		// Token: 0x06000DDE RID: 3550 RVA: 0x000894DC File Offset: 0x000876DC
		private static void PaddingHelpersAsyncCausalityStatus(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14)
		{
			bool flag = A_8;
			A_14 = flag;
			int num = ((!A_14) ? 1 : 0) * 1 + 54;
			A_0 = num;
		}

		// Token: 0x06000DDF RID: 3551 RVA: 0x0008953C File Offset: 0x0008773C
		private static void IsAsyncFControl(ref int A_0, ref int A_1, ref int A_2, ref SnowballThrowable[] A_3, ref int A_4, ref SnowballThrowable A_5, ref bool A_6)
		{
			SnowballThrowable snowballThrowable = A_3[A_4];
			A_5 = snowballThrowable;
			bool randomizeColor = A_5.randomizeColor;
			A_6 = randomizeColor;
			int num = ((!A_6) ? 1 : 0) * 1 + 69;
			A_0 = num;
		}

		// Token: 0x06000DE0 RID: 3552 RVA: 0x000895C8 File Offset: 0x000877C8
		private static void getOriginalIssuerVersionCompatibility(ref int A_0, ref int A_1, ref int A_2, ref SnowballThrowable[] A_3, ref int A_4, ref SnowballThrowable A_5, ref bool A_6)
		{
			SnowballThrowable[] array = Object.FindObjectsOfType<SnowballThrowable>();
			A_3 = array;
			int num = 0;
			A_4 = num;
			A_0 = 77;
		}

		// Token: 0x06000DE1 RID: 3553 RVA: 0x00089610 File Offset: 0x00087810
		private static void InlineTokGenericWrite(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<string> A_4, ref List<ButtonInfo>.Enumerator A_5, ref ButtonInfo A_6, ref bool? A_7, ref bool A_8, ref bool A_9)
		{
			A_1 = 4;
			A_2 = 131;
		}

		// Token: 0x06000DE2 RID: 3554 RVA: 0x00089634 File Offset: 0x00087834
		private static void StreamReadersetKey(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GradientColorKey[] A_5, ref ColorChanger A_6, ref bool A_7, ref GameObject A_8, ref GradientColorKey[] A_9, ref ColorChanger A_10)
		{
			A_1 = 0;
		}

		// Token: 0x06000DE3 RID: 3555 RVA: 0x0008964C File Offset: 0x0008784C
		private static void getTypeEventRegistrationTokenList(ref int A_0, ref int A_1, ref int A_2, ref SnowballThrowable[] A_3, ref int A_4, ref SnowballThrowable A_5, ref bool A_6)
		{
			int num = ((A_4 < A_3.Length) ? 1 : 0) * -4 + 78;
			A_0 = num;
		}

		// Token: 0x06000DE4 RID: 3556 RVA: 0x00089688 File Offset: 0x00087888
		public static void AntiCheatCrashOff()
		{
			int num = 102;
			int num2 = 102;
			num2 = 102;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, t.setRoleReleaseTLibAttr[num]);
			}
			num2 = 102;
		}

		// Token: 0x06000DE5 RID: 3557 RVA: 0x000896C0 File Offset: 0x000878C0
		private static void TypeLibTypeAttributeWindowsAccountType(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GradientColorKey[] A_5, ref ColorChanger A_6, ref bool A_7, ref GameObject A_8, ref GradientColorKey[] A_9, ref ColorChanger A_10)
		{
			bool gripDownL = buttons.gripDownL;
			A_3 = gripDownL;
			int num = ((!A_3) ? 1 : 0) * 1 + 17;
			A_0 = num;
		}

		// Token: 0x06000DE6 RID: 3558 RVA: 0x0008971C File Offset: 0x0008791C
		private static void InternalArrayTypeEGetPropertyProps(ref int A_0, ref int A_1, ref int A_2)
		{
			Process.Start("https://discord.gg/4FySMhJBZ7");
			buttons.bbuttons[0].enabled = new bool?(false);
			A_1 = 0;
		}

		// Token: 0x06000DE7 RID: 3559 RVA: 0x00089760 File Offset: 0x00087960
		private static void AbsentOriginSchemeTaskStops(ref int A_0, ref int A_1, ref int A_2)
		{
			Player.Instance.transform.localScale = new Vector3(2f, 2f, 2f);
			A_1 = 0;
		}

		// Token: 0x06000DE8 RID: 3560 RVA: 0x0008979C File Offset: 0x0008799C
		private static void getNextSpinWillYieldCurrentIntoBuffer(ref int A_0, ref int A_1, ref int A_2)
		{
			PhotonNetwork.ConnectToBestCloudServer();
			A_1 = 0;
		}

		// Token: 0x06000DE9 RID: 3561 RVA: 0x000897BC File Offset: 0x000879BC
		private static void getRngMetadataSectionKeyInfoElement(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GradientColorKey[] A_5, ref ColorChanger A_6, ref bool A_7, ref GameObject A_8, ref GradientColorKey[] A_9, ref ColorChanger A_10)
		{
			bool gripDownR = buttons.gripDownR;
			A_7 = gripDownR;
			int num = ((!A_7) ? 1 : 0) * 1 + 24;
			A_0 = num;
		}

		// Token: 0x06000DEA RID: 3562 RVA: 0x00089818 File Offset: 0x00087A18
		private static void CompatibilityFlagrangeManager(ref int A_0, ref int A_1, ref int A_2)
		{
			BetterDayNightManager.instance.SetTimeOfDay(6);
			A_1 = 0;
		}

		// Token: 0x06000DEB RID: 3563 RVA: 0x00089844 File Offset: 0x00087A44
		private static void getMaxCapacityAdministerIsolatedStorageByUser(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14)
		{
			int num = (UnityInput.Current.GetKey(119) ? 1 : 0) * 1 + 32;
			A_0 = num;
		}

		// Token: 0x06000DEC RID: 3564 RVA: 0x00089890 File Offset: 0x00087A90
		private static void IsLeapYeargetControlThread(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<string> A_4, ref List<ButtonInfo>.Enumerator A_5, ref ButtonInfo A_6, ref bool? A_7, ref bool A_8, ref bool A_9)
		{
			A_4.Add(A_6.buttonText);
			int num = (A_5.MoveNext() ? 1 : 0) * -4 + 129;
			A_0 = num;
		}

		// Token: 0x06000DED RID: 3565 RVA: 0x000898F8 File Offset: 0x00087AF8
		public static void SpeedBoostMedium()
		{
			int num = 90;
			int num2 = 90;
			num2 = 90;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, t.setRoleReleaseTLibAttr[num]);
			}
			num2 = 90;
		}

		// Token: 0x06000DEE RID: 3566 RVA: 0x00089930 File Offset: 0x00087B30
		private static void GetPermissionsetScope(ref int A_0, ref int A_1, ref int A_2)
		{
			Player.Instance.slideControl = 250f;
			Player.Instance.slideVelocityLimit = 10f;
			A_1 = 0;
		}

		// Token: 0x06000DEF RID: 3567 RVA: 0x00089968 File Offset: 0x00087B68
		private static void TriggersActivityTrackingSendOrPostCallback(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<string> A_4, ref List<ButtonInfo>.Enumerator A_5, ref ButtonInfo A_6, ref bool? A_7, ref bool A_8, ref bool A_9)
		{
			int num = (A_5.MoveNext() ? 1 : 0) * -4 + 129;
			A_0 = num;
		}

		// Token: 0x06000DF0 RID: 3568 RVA: 0x000899B0 File Offset: 0x00087BB0
		private static void ApplicationIdEnableActivateAsActivator(ref int A_0, ref int A_1, ref int A_2, ref float A_3, ref float A_4, ref bool A_5, ref float A_6, ref Vector3 A_7)
		{
			float num = 10f;
			A_3 = num;
			float num2 = 360f / A_3;
			A_4 = num2;
			bool gripDownR = buttons.gripDownR;
			A_5 = gripDownR;
			int num3 = ((!A_5) ? 1 : 0) * 1 + 93;
			A_0 = num3;
		}

		// Token: 0x06000DF1 RID: 3569 RVA: 0x00089A44 File Offset: 0x00087C44
		private static void DTSubStringopBitwiseAnd(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4)
		{
			A_1 = 0;
		}

		// Token: 0x06000DF2 RID: 3570 RVA: 0x00089A5C File Offset: 0x00087C5C
		private static void getSystemConfigurationFilegetOriginalIssuer(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GradientColorKey[] A_5, ref ColorChanger A_6, ref bool A_7, ref GameObject A_8, ref GradientColorKey[] A_9, ref ColorChanger A_10)
		{
			bool gripDownR = buttons.gripDownR;
			A_7 = gripDownR;
			int num = ((!A_7) ? 1 : 0) * 1 + 19;
			A_0 = num;
		}

		// Token: 0x06000DF3 RID: 3571 RVA: 0x00089AB8 File Offset: 0x00087CB8
		private static void NoManglegetInputBlockSize(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref string[] A_4, ref string[] A_5, ref int A_6, ref string A_7, ref List<ButtonInfo>.Enumerator A_8, ref ButtonInfo A_9, ref bool A_10)
		{
			((IDisposable)A_8).Dispose();
			A_1 = 2;
		}

		// Token: 0x06000DF4 RID: 3572 RVA: 0x00089AE0 File Offset: 0x00087CE0
		private static bool GetSignatureTokenRectangularOffset(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, VRRig A_5)
		{
			bool flag = false;
			A_4 = flag;
			A_0 = 107;
			bool result;
			return result;
		}

		// Token: 0x06000DF5 RID: 3573 RVA: 0x00089B14 File Offset: 0x00087D14
		private static void CurrencyObjectString(ref int A_0, ref int A_1, ref int A_2)
		{
			PhotonNetwork.ConnectToRegion("usw");
			A_1 = 0;
		}

		// Token: 0x06000DF6 RID: 3574 RVA: 0x00089B38 File Offset: 0x00087D38
		private static void GetTypeForObjectSearchForChildByTag(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref string[] A_4, ref string[] A_5, ref int A_6, ref string A_7, ref List<ButtonInfo>.Enumerator A_8, ref ButtonInfo A_9, ref bool A_10)
		{
			A_9.enabled = new bool?(true);
			int num = (A_8.MoveNext() ? 1 : 0) * -4 + 139;
			A_0 = num;
		}

		// Token: 0x06000DF7 RID: 3575 RVA: 0x00089B98 File Offset: 0x00087D98
		public static void FixTagOnJoin()
		{
			int num = 114;
			int num2 = 114;
			num2 = 114;
			while (num2 != 0)
			{
				int num3;
				Hashtable hashtable;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,ExitGames.Client.Photon.Hashtable&), ref num, ref num2, ref num3, ref hashtable, t.setRoleReleaseTLibAttr[num]);
			}
			num2 = 114;
		}

		// Token: 0x06000DF8 RID: 3576 RVA: 0x00089BD0 File Offset: 0x00087DD0
		private static void enableWorkerTrackinggetIsLiteral(ref int A_0, ref int A_1, ref int A_2, ref int A_3, ref bool A_4)
		{
			bool flag = A_3 <= 20;
			A_4 = flag;
			int num = (A_4 ? 1 : 0) * -2 + 7;
			A_0 = num;
		}

		// Token: 0x06000DF9 RID: 3577 RVA: 0x00089C40 File Offset: 0x00087E40
		private static bool ToEventKeywordsSetOnInvokeMres(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, VRRig A_5)
		{
			bool flag = A_5 == GorillaTagger.Instance.offlineVRRig;
			A_3 = flag;
			int num = ((!A_3) ? 1 : 0) * 1 + 105;
			A_0 = num;
			bool result;
			return result;
		}

		// Token: 0x06000DFA RID: 3578 RVA: 0x00089CB0 File Offset: 0x00087EB0
		private static void TypeUnloadedExceptionIsLastFrameFromForeignExceptionStackTrace(ref int A_0, ref int A_1, ref int A_2)
		{
			QualitySettings.globalTextureMipmapLimit = 99999;
			A_1 = 0;
		}

		// Token: 0x06000DFB RID: 3579 RVA: 0x00089CD4 File Offset: 0x00087ED4
		public static void JoinDiscordServer()
		{
			int num = 58;
			int num2 = 58;
			num2 = 58;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, t.setRoleReleaseTLibAttr[num]);
			}
			num2 = 58;
		}

		// Token: 0x06000DFC RID: 3580 RVA: 0x00089D0C File Offset: 0x00087F0C
		private static void SecurityPermissionFlaggetNameClaimType(ref int A_0, ref int A_1, ref int A_2, t A_3)
		{
			A_3..ctor();
			A_1 = 0;
		}

		// Token: 0x06000DFD RID: 3581 RVA: 0x00089D30 File Offset: 0x00087F30
		private static void CSTRMarshalerAddAlgorithm(ref int A_0, ref int A_1, ref int A_2, ref SnowballThrowable[] A_3, ref int A_4, ref SnowballThrowable A_5, ref bool A_6)
		{
			A_5.randomizeColor = true;
			int num = A_4 + 1;
			A_4 = num;
			int num2 = ((A_4 < A_3.Length) ? 1 : 0) * -4 + 78;
			A_0 = num2;
		}

		// Token: 0x06000DFE RID: 3582 RVA: 0x00089DA4 File Offset: 0x00087FA4
		private static void AppContextSwitchesObjectUser(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref string[] A_4, ref string[] A_5, ref int A_6, ref string A_7, ref List<ButtonInfo>.Enumerator A_8, ref ButtonInfo A_9, ref bool A_10)
		{
			string text = A_5[A_6];
			A_7 = text;
			List<ButtonInfo>.Enumerator enumerator = buttons.settingsbuttons.GetEnumerator();
			A_8 = enumerator;
			A_0 = 134;
		}

		// Token: 0x06000DFF RID: 3583 RVA: 0x00089DFC File Offset: 0x00087FFC
		private static void InitblkgetDelaySign(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GradientColorKey[] A_5, ref ColorChanger A_6, ref bool A_7, ref GameObject A_8, ref GradientColorKey[] A_9, ref ColorChanger A_10)
		{
			GameObject gameObject = GameObject.CreatePrimitive(0);
			A_4 = gameObject;
			Object.Destroy(A_4.GetComponent<BoxCollider>());
			A_4.GetComponent<Renderer>().material.shader = Shader.Find("GorillaTag/UberShader");
			A_4.transform.localScale = new Vector3(0.05f, 0.05f, 0.05f);
			A_4.transform.position = GorillaTagger.Instance.leftHandTransform.position;
			A_4.transform.rotation = GorillaTagger.Instance.leftHandTransform.rotation;
			Object.Destroy(A_4, 100f);
			PhotonNetwork.RaiseEvent(69, new object[]
			{
				A_4.transform.position,
				A_4.transform.rotation
			}, new RaiseEventOptions
			{
				Receivers = 0
			}, SendOptions.SendReliable);
			GradientColorKey[] array = new GradientColorKey[3];
			A_5 = array;
			A_5[0].color = Color.red;
			A_5[0].time = 0f;
			A_5[1].color = Color.yellow;
			A_5[1].time = 0.2f;
			A_5[2].color = Color.green;
			A_5[2].time = 0.3f;
			A_5[3].color = Color.cyan;
			A_5[3].time = 0.5f;
			A_5[4].color = Color.blue;
			A_5[4].time = 0.6f;
			A_5[5].color = Color.magenta;
			A_5[5].time = 0.8f;
			A_5[6].color = Color.red;
			A_5[6].time = 1f;
			ColorChanger colorChanger = A_4.AddComponent<ColorChanger>();
			A_6 = colorChanger;
			A_6.colors = new Gradient
			{
				colorKeys = A_5
			};
			A_6.Start();
			bool gripDownR = buttons.gripDownR;
			A_7 = gripDownR;
			int num = ((!A_7) ? 1 : 0) * 1 + 19;
			A_0 = num;
		}

		// Token: 0x06000E00 RID: 3584 RVA: 0x0008A198 File Offset: 0x00088398
		public static void TimeDayRise()
		{
			int num = 111;
			int num2 = 111;
			num2 = 111;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, t.setRoleReleaseTLibAttr[num]);
			}
			num2 = 111;
		}

		// Token: 0x06000E01 RID: 3585 RVA: 0x0008A1D0 File Offset: 0x000883D0
		public t()
		{
			int num = 144;
			int num2 = 144;
			num2 = 144;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,ShibaGTTemplate.Backend.t), ref num, ref num2, ref num3, this, t.setRoleReleaseTLibAttr[num]);
			}
			num2 = 144;
		}

		// Token: 0x06000E02 RID: 3586 RVA: 0x0008A214 File Offset: 0x00088414
		private static void GetEnumeratorDelegateLimitExceeded(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14)
		{
			bool flag = true;
			A_5 = flag;
			int num = (UnityInput.Current.GetKey(100) ? 1 : 0) * 1 + 38;
			A_0 = num;
		}

		// Token: 0x06000E03 RID: 3587 RVA: 0x0008A278 File Offset: 0x00088478
		private static void DateTimeRawInfogetMaxSize(ref int A_0, ref int A_1, ref int A_2, ref SnowballThrowable[] A_3, ref int A_4, ref SnowballThrowable A_5, ref bool A_6)
		{
			A_1 = 0;
		}

		// Token: 0x06000E04 RID: 3588 RVA: 0x0008A290 File Offset: 0x00088490
		public static void ElasticMan()
		{
			int num = 100;
			int num2 = 100;
			num2 = 100;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, t.setRoleReleaseTLibAttr[num]);
			}
			num2 = 100;
		}

		// Token: 0x06000E05 RID: 3589 RVA: 0x0008A2C8 File Offset: 0x000884C8
		public static void LessLaggyServers()
		{
			int num = 56;
			int num2 = 56;
			num2 = 56;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, t.setRoleReleaseTLibAttr[num]);
			}
			num2 = 56;
		}

		// Token: 0x06000E06 RID: 3590 RVA: 0x0008A300 File Offset: 0x00088500
		private static void getAccessRuleTypeDescriptionMetadataEntryFieldId(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GradientColorKey[] A_5, ref ColorChanger A_6, ref bool A_7, ref GameObject A_8, ref GradientColorKey[] A_9, ref ColorChanger A_10)
		{
			GameObject gameObject = GameObject.CreatePrimitive(3);
			A_4 = gameObject;
			Object.Destroy(A_4.GetComponent<BoxCollider>());
			A_4.GetComponent<Renderer>().material.shader = Shader.Find("GorillaTag/UberShader");
			A_4.transform.localScale = new Vector3(0.1f, 0.5f, 0.5f);
			A_4.transform.position = GorillaTagger.Instance.leftHandTransform.position;
			A_4.transform.rotation = GorillaTagger.Instance.leftHandTransform.rotation;
			Object.Destroy(A_4, 100f);
			PhotonNetwork.RaiseEvent(69, new object[]
			{
				A_4.transform.position,
				A_4.transform.rotation
			}, new RaiseEventOptions
			{
				Receivers = 0
			}, SendOptions.SendReliable);
			GradientColorKey[] array = new GradientColorKey[3];
			A_5 = array;
			A_5[0].color = Color.red;
			A_5[0].time = 0f;
			A_5[1].color = Color.yellow;
			A_5[1].time = 0.2f;
			A_5[2].color = Color.green;
			A_5[2].time = 0.3f;
			A_5[3].color = Color.cyan;
			A_5[3].time = 0.5f;
			A_5[4].color = Color.blue;
			A_5[4].time = 0.6f;
			A_5[5].color = Color.magenta;
			A_5[5].time = 0.8f;
			A_5[6].color = Color.red;
			A_5[6].time = 1f;
			ColorChanger colorChanger = A_4.AddComponent<ColorChanger>();
			A_6 = colorChanger;
			A_6.colors = new Gradient
			{
				colorKeys = A_5
			};
			A_6.Start();
			bool gripDownR = buttons.gripDownR;
			A_7 = gripDownR;
			int num = ((!A_7) ? 1 : 0) * 1 + 29;
			A_0 = num;
		}

		// Token: 0x06000E07 RID: 3591 RVA: 0x0008A69C File Offset: 0x0008889C
		private static void EventArgsBuiltinAccountOperatorsSid(ref int A_0, ref int A_1, ref int A_2, ref int A_3, ref bool A_4)
		{
			buttons.bbuttons[A_3].enabled = new bool?(false);
			int num = A_3 + 1;
			A_3 = num;
			bool flag = A_3 <= 100;
			A_4 = flag;
			int num2 = (A_4 ? 1 : 0) * -2 + 3;
			A_0 = num2;
		}

		// Token: 0x06000E08 RID: 3592 RVA: 0x0008A750 File Offset: 0x00088950
		private static void BackspaceRequireDashes(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GradientColorKey[] A_5, ref ColorChanger A_6, ref bool A_7, ref GameObject A_8, ref GradientColorKey[] A_9, ref ColorChanger A_10)
		{
			bool gripDownL = buttons.gripDownL;
			A_3 = gripDownL;
			int num = ((!A_3) ? 1 : 0) * 1 + 27;
			A_0 = num;
		}

		// Token: 0x06000E09 RID: 3593 RVA: 0x0008A7AC File Offset: 0x000889AC
		private static void ITypeLibImporterNotifySinkInterfaceIsIUnknown(ref int A_0, ref int A_1, ref int A_2, ref SnowballThrowable[] A_3, ref int A_4, ref SnowballThrowable A_5, ref bool A_6)
		{
			int num = ((A_4 < A_3.Length) ? 1 : 0) * -4 + 72;
			A_0 = num;
		}

		// Token: 0x06000E0A RID: 3594 RVA: 0x0008A7E8 File Offset: 0x000889E8
		private static void AssemblyRequestSectionResourceManagerGetSatelliteAssemblyFailed(ref int A_0, ref int A_1, ref int A_2)
		{
			GameObject.Find("Environment Objects/PersistentObjects_Prefab/GlobalObjectPools").SetActive(true);
			A_1 = 0;
		}

		// Token: 0x06000E0B RID: 3595 RVA: 0x0008A818 File Offset: 0x00088A18
		public static void BeyBladeMod()
		{
			int num = 92;
			int num2 = 92;
			num2 = 92;
			while (num2 != 0)
			{
				int num3;
				float num4;
				float num5;
				bool flag;
				float num6;
				Vector3 vector;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Single&,System.Single&,System.Boolean&,System.Single&,UnityEngine.Vector3&), ref num, ref num2, ref num3, ref num4, ref num5, ref flag, ref num6, ref vector, t.setRoleReleaseTLibAttr[num]);
			}
			num2 = 92;
		}

		// Token: 0x06000E0C RID: 3596 RVA: 0x0008A858 File Offset: 0x00088A58
		private static void lcidLdindRef(ref int A_0, ref int A_1, ref int A_2)
		{
			GameObject.Find("Environment Objects/PersistentObjects_Prefab/GlobalObjectPools").SetActive(false);
			A_1 = 0;
		}

		// Token: 0x06000E0D RID: 3597 RVA: 0x0008A888 File Offset: 0x00088A88
		private static void LeftArrowLocked()
		{
			t.setRoleReleaseTLibAttr = new IntPtr[146];
			t.setRoleReleaseTLibAttr[0] = ldftn(NotImpersonatedgetSecurityContext);
			t.setRoleReleaseTLibAttr[1] = ldftn(EventArgsBuiltinAccountOperatorsSid);
			t.setRoleReleaseTLibAttr[2] = ldftn(MultiStringLeftCtrlPressed);
			t.setRoleReleaseTLibAttr[3] = ldftn(FileSystemEnumerableIteratorPARAMFLAGFIN);
			t.setRoleReleaseTLibAttr[4] = ldftn(ConstArrayMidday);
			t.setRoleReleaseTLibAttr[5] = ldftn(CacheTypeUSEROBJECTFLAGS);
			t.setRoleReleaseTLibAttr[6] = ldftn(enableWorkerTrackinggetIsLiteral);
			t.setRoleReleaseTLibAttr[7] = ldftn(TypeInformationIsNestedPublic);
			t.setRoleReleaseTLibAttr[8] = ldftn(MethodRentalgetClassName);
			t.setRoleReleaseTLibAttr[9] = ldftn(SetSymAttributegetThreeLetterISORegionName);
			t.setRoleReleaseTLibAttr[10] = ldftn(getParentIndexSetSource);
			t.setRoleReleaseTLibAttr[11] = ldftn(IsApplicationTrustedToRunReflectionOnly);
			t.setRoleReleaseTLibAttr[12] = ldftn(UrlAttributegetElementCount);
			t.setRoleReleaseTLibAttr[13] = ldftn(OperationgetRest);
			t.setRoleReleaseTLibAttr[14] = ldftn(NotCurrentlyProcessingCryptoAPITransformMode);
			t.setRoleReleaseTLibAttr[15] = ldftn(LocalPushEnhancedKeyUsage);
			t.setRoleReleaseTLibAttr[16] = ldftn(TypeLibTypeAttributeWindowsAccountType);
			t.setRoleReleaseTLibAttr[17] = ldftn(InitblkgetDelaySign);
			t.setRoleReleaseTLibAttr[18] = ldftn(getSystemConfigurationFilegetOriginalIssuer);
			t.setRoleReleaseTLibAttr[19] = ldftn(NullReferenceExceptionLegacyEvidenceWrapper);
			t.setRoleReleaseTLibAttr[20] = ldftn(UnobservedTaskExceptionEventArgsSoapServices);
			t.setRoleReleaseTLibAttr[21] = ldftn(IsBackgroundEnumInstallerDeploymentProperties);
			t.setRoleReleaseTLibAttr[22] = ldftn(addModuleResolveSecurityAttribute);
			t.setRoleReleaseTLibAttr[23] = ldftn(getRngMetadataSectionKeyInfoElement);
			t.setRoleReleaseTLibAttr[24] = ldftn(LockRecursionExceptionCMSHASHTRANSFORMMANIFESTINVARIANT);
			t.setRoleReleaseTLibAttr[25] = ldftn(getCreateAttribute);
			t.setRoleReleaseTLibAttr[26] = ldftn(BackspaceRequireDashes);
			t.setRoleReleaseTLibAttr[27] = ldftn(getAccessRuleTypeDescriptionMetadataEntryFieldId);
			t.setRoleReleaseTLibAttr[28] = ldftn(DecoderUTFFallbackBufferModeInvalidEscape);
			t.setRoleReleaseTLibAttr[29] = ldftn(SuppressFinalizeRemoveMethod);
			t.setRoleReleaseTLibAttr[30] = ldftn(StreamReadersetKey);
			t.setRoleReleaseTLibAttr[31] = ldftn(getMaxCapacityAdministerIsolatedStorageByUser);
			t.setRoleReleaseTLibAttr[32] = ldftn(NativeRegisterMayCorruptAppDomain);
			t.setRoleReleaseTLibAttr[33] = ldftn(IsErrorRedirectedEraToken);
			t.setRoleReleaseTLibAttr[34] = ldftn(SecurityContextRunDataIsNewContextOK);
			t.setRoleReleaseTLibAttr[35] = ldftn(SerialNumbergetFormatterAlgorithm);
			t.setRoleReleaseTLibAttr[36] = ldftn(ExportedTypesIntBitsToDouble);
			t.setRoleReleaseTLibAttr[37] = ldftn(GetEnumeratorDelegateLimitExceeded);
			t.setRoleReleaseTLibAttr[38] = ldftn(GetCorrespondingKindBinaryCompatibility);
			t.setRoleReleaseTLibAttr[39] = ldftn(InTypeCountMaskGetValueList);
			t.setRoleReleaseTLibAttr[40] = ldftn(getAccountDomainSidNoResourceLookup);
			t.setRoleReleaseTLibAttr[41] = ldftn(getEntryPointSecurityPermissionAttribute);
			t.setRoleReleaseTLibAttr[42] = ldftn(SegmentIMoniker);
			t.setRoleReleaseTLibAttr[43] = ldftn(getParentIReference);
			t.setRoleReleaseTLibAttr[44] = ldftn(BytereadLen);
			t.setRoleReleaseTLibAttr[45] = ldftn(IsFamilyITypeLibExporterNotifySink);
			t.setRoleReleaseTLibAttr[46] = ldftn(EndOfStreamExceptionCallConvFastcall);
			t.setRoleReleaseTLibAttr[47] = ldftn(getCustomAttributesCommonSecurityDescriptor);
			t.setRoleReleaseTLibAttr[48] = ldftn(PARAMDESCReadBlock);
			t.setRoleReleaseTLibAttr[49] = ldftn(SafeIsolatedStorageFileHandleERRORREFTOINVALIDASSEMBLY);
			t.setRoleReleaseTLibAttr[50] = ldftn(WriteLineAsyncMediaPlay);
			t.setRoleReleaseTLibAttr[51] = ldftn(SoapAnyUriSingleton);
			t.setRoleReleaseTLibAttr[52] = ldftn(TokenOriginCausalityTraceLevel);
			t.setRoleReleaseTLibAttr[53] = ldftn(PaddingHelpersAsyncCausalityStatus);
			t.setRoleReleaseTLibAttr[54] = ldftn(DaysInMonthsetProduceLegacyHmacValues);
			t.setRoleReleaseTLibAttr[55] = ldftn(IContextPropertyTripleDES);
			t.setRoleReleaseTLibAttr[56] = ldftn(getNextSpinWillYieldCurrentIntoBuffer);
			t.setRoleReleaseTLibAttr[57] = ldftn(GetTagForElementSetAccessRuleProtection);
			t.setRoleReleaseTLibAttr[58] = ldftn(InternalArrayTypeEGetPropertyProps);
			t.setRoleReleaseTLibAttr[59] = ldftn(NonUniqueAuthorityStatic);
			t.setRoleReleaseTLibAttr[60] = ldftn(getIsThreadOwnerTrackingEnabledDynamicSecurityMethodAttribute);
			t.setRoleReleaseTLibAttr[61] = ldftn(getInMVID);
			t.setRoleReleaseTLibAttr[62] = ldftn(ReadBlockGetOrderableDynamicPartitions);
			t.setRoleReleaseTLibAttr[63] = ldftn(setBufferWidthforkJoinContextID);
			t.setRoleReleaseTLibAttr[64] = ldftn(DaylightTransitionEndLdcI);
			t.setRoleReleaseTLibAttr[65] = ldftn(CurrencyObjectString);
			t.setRoleReleaseTLibAttr[66] = ldftn(ReadOnlyCollectionSTOREASSEMBLY);
			t.setRoleReleaseTLibAttr[67] = ldftn(HashNameAccessDeniedCallbackObject);
			t.setRoleReleaseTLibAttr[68] = ldftn(IsAsyncFControl);
			t.setRoleReleaseTLibAttr[69] = ldftn(continuationIdSecurityContextRunData);
			t.setRoleReleaseTLibAttr[70] = ldftn(IsApplicationTrustedToRunFromSerializedString);
			t.setRoleReleaseTLibAttr[71] = ldftn(ITypeLibImporterNotifySinkInterfaceIsIUnknown);
			t.setRoleReleaseTLibAttr[72] = ldftn(DateTimeRawInfogetMaxSize);
			t.setRoleReleaseTLibAttr[73] = ldftn(getOriginalIssuerVersionCompatibility);
			t.setRoleReleaseTLibAttr[74] = ldftn(FirstMatchCodeGroupOSVERSIONINFOEX);
			t.setRoleReleaseTLibAttr[75] = ldftn(CSTRMarshalerAddAlgorithm);
			t.setRoleReleaseTLibAttr[76] = ldftn(AddressOfMemberCMSSECTIONENTRYIDMETADATA);
			t.setRoleReleaseTLibAttr[77] = ldftn(getTypeEventRegistrationTokenList);
			t.setRoleReleaseTLibAttr[78] = ldftn(StrongNameErrorInfogetXmlTypeNamespace);
			t.setRoleReleaseTLibAttr[79] = ldftn(addUnobservedTaskExceptionTYPEFLAGFAPPOBJECT);
			t.setRoleReleaseTLibAttr[80] = ldftn(StreamWriterBufferedDataLostFieldAccessMask);
			t.setRoleReleaseTLibAttr[81] = ldftn(TypeUnloadedExceptionIsLastFrameFromForeignExceptionStackTrace);
			t.setRoleReleaseTLibAttr[82] = ldftn(CurrentTimeZoneInvalidOperationNoValue);
			t.setRoleReleaseTLibAttr[83] = ldftn(AsyncTaskCacheHSTRINGHEADER);
			t.setRoleReleaseTLibAttr[84] = ldftn(AbsentOriginSchemeTaskStops);
			t.setRoleReleaseTLibAttr[85] = ldftn(TicksRecent);
			t.setRoleReleaseTLibAttr[86] = ldftn(SetMarshalGREGORIANXLITENGLISH);
			t.setRoleReleaseTLibAttr[87] = ldftn(HiddenPOLICYCREATEPRIVILEGE);
			t.setRoleReleaseTLibAttr[88] = ldftn(RightToLeftOverrideTripleDES);
			t.setRoleReleaseTLibAttr[89] = ldftn(GetRuntimeDirectorycharLen);
			t.setRoleReleaseTLibAttr[90] = ldftn(BaseUtcOffsetgetIsDynamic);
			t.setRoleReleaseTLibAttr[91] = ldftn(CreateGlobalFunctionsgetUseNewMaxArraySize);
			t.setRoleReleaseTLibAttr[92] = ldftn(ApplicationIdEnableActivateAsActivator);
			t.setRoleReleaseTLibAttr[93] = ldftn(CCRESERVEDSystemConfigurationFile);
			t.setRoleReleaseTLibAttr[94] = ldftn(SecurityPermissionFlagSignatureDescription);
			t.setRoleReleaseTLibAttr[95] = ldftn(GetPermissionsetScope);
			t.setRoleReleaseTLibAttr[96] = ldftn(KeyContainerNameMachineName);
			t.setRoleReleaseTLibAttr[97] = ldftn(StrongNameSignatureVerificationExRemotingXmlConfigFileParser);
			t.setRoleReleaseTLibAttr[98] = ldftn(MultiDomainHostTransliteratedEnglish);
			t.setRoleReleaseTLibAttr[99] = ldftn(SkipSign);
			t.setRoleReleaseTLibAttr[100] = ldftn(ThreadTransferSendSymbolToken);
			t.setRoleReleaseTLibAttr[101] = ldftn(MoveLunisolarCalendar);
			t.setRoleReleaseTLibAttr[102] = ldftn(lcidLdindRef);
			t.setRoleReleaseTLibAttr[103] = ldftn(AssemblyRequestSectionResourceManagerGetSatelliteAssemblyFailed);
			t.setRoleReleaseTLibAttr[104] = ldftn(ToEventKeywordsSetOnInvokeMres);
			t.setRoleReleaseTLibAttr[105] = ldftn(GetSignatureTokenRectangularOffset);
			t.setRoleReleaseTLibAttr[106] = ldftn(RecentMethodBody);
			t.setRoleReleaseTLibAttr[107] = ldftn(getRedirectedGuidGetMonthsInYear);
			t.setRoleReleaseTLibAttr[108] = ldftn(errgetApplicationActivator);
			t.setRoleReleaseTLibAttr[109] = ldftn(AddHostWindowsFqbnVersion);
			t.setRoleReleaseTLibAttr[110] = ldftn(CompatibilityFlagrangeManager);
			t.setRoleReleaseTLibAttr[111] = ldftn(PrimitiveValueSandboxInterop);
			t.setRoleReleaseTLibAttr[112] = ldftn(OrderSetMethodBody);
			t.setRoleReleaseTLibAttr[113] = ldftn(IAPPIDAUTHORITYAREDEFINITIONSEQUALFLAGSGetValueList);
			t.setRoleReleaseTLibAttr[114] = ldftn(GetSortKeygetCurrencyNativeName);
			t.setRoleReleaseTLibAttr[115] = ldftn(KeyPasswordCausalityTracer);
			t.setRoleReleaseTLibAttr[116] = ldftn(IStoreBindingResultResourceTypeManifestResourcesDependency);
			t.setRoleReleaseTLibAttr[117] = ldftn(TimeSpanTypeInfoObjectEnd);
			t.setRoleReleaseTLibAttr[118] = ldftn(AddAssemblyEvidencesetAction);
			t.setRoleReleaseTLibAttr[119] = ldftn(DTSubStringopBitwiseAnd);
			t.setRoleReleaseTLibAttr[120] = ldftn(getBuildSetAllDateTimePatterns);
			t.setRoleReleaseTLibAttr[121] = ldftn(TokenizerStringBlockAccountKrbtgtSid);
			t.setRoleReleaseTLibAttr[122] = ldftn(FileAssociationParameterOffsetLow);
			t.setRoleReleaseTLibAttr[123] = ldftn(PreferFairnessClassName);
			t.setRoleReleaseTLibAttr[124] = ldftn(SymDocumentTypegetElementCount);
			t.setRoleReleaseTLibAttr[125] = ldftn(ERRORREFTOINVALIDTYPELIBDeleteSubKey);
			t.setRoleReleaseTLibAttr[126] = ldftn(IsLeapYeargetControlThread);
			t.setRoleReleaseTLibAttr[127] = ldftn(TriggersActivityTrackingSendOrPostCallback);
			t.setRoleReleaseTLibAttr[128] = ldftn(GetBooleanArrayContextStaticAttribute);
			t.setRoleReleaseTLibAttr[129] = ldftn(InlineTokGenericWrite);
			t.setRoleReleaseTLibAttr[130] = ldftn(WhenAllPromiseCopyToAsync);
			t.setRoleReleaseTLibAttr[131] = ldftn(ArrayTypeMismatchExceptionToLongDateString);
			t.setRoleReleaseTLibAttr[132] = ldftn(DuplicateWaitObjectExceptionfilterList);
			t.setRoleReleaseTLibAttr[133] = ldftn(AppContextSwitchesObjectUser);
			t.setRoleReleaseTLibAttr[134] = ldftn(GetPreambleReplacementFallback);
			t.setRoleReleaseTLibAttr[135] = ldftn(StructLayoutAttributeRootSetObjectData);
			t.setRoleReleaseTLibAttr[136] = ldftn(GetTypeForObjectSearchForChildByTag);
			t.setRoleReleaseTLibAttr[137] = ldftn(LongDatePatternIsSddlConversionSupported);
			t.setRoleReleaseTLibAttr[138] = ldftn(IdentitySharedBool);
			t.setRoleReleaseTLibAttr[139] = ldftn(RemoveRemotingParameterCachedData);
			t.setRoleReleaseTLibAttr[140] = ldftn(NoManglegetInputBlockSize);
			t.setRoleReleaseTLibAttr[141] = ldftn(ParenthesisFormatNonUniqueAuthority);
			t.setRoleReleaseTLibAttr[142] = ldftn(EnvoyInfoCustAttr);
			t.setRoleReleaseTLibAttr[143] = ldftn(UCOMIEnumerableAceQualifier);
			t.setRoleReleaseTLibAttr[144] = ldftn(SecurityPermissionFlaggetNameClaimType);
			t.setRoleReleaseTLibAttr[145] = ldftn(StoreOperationScavengeArgumentOutOfRangeInvalidThreshold);
		}

		// Token: 0x040000CE RID: 206
		public static bool oiwefkwenfjk;

		// Token: 0x040000CF RID: 207
		public static bool inSettings;

		// Token: 0x040000D0 RID: 208
		public static bool invisplat;

		// Token: 0x040000D1 RID: 209
		public static bool stickyplatforms;

		// Token: 0x040000D2 RID: 210
		public static GameObject funn;

		// Token: 0x040000D3 RID: 211
		public static bool fpcc;

		// Token: 0x040000D4 RID: 212
		public static int nindex;

		// Token: 0x040000D5 RID: 213
		public static int nindec;

		// Token: 0x040000D6 RID: 214
		public static float ChangeDelay;

		// Token: 0x040000D7 RID: 215
		public static bool color;

		// Token: 0x040000D8 RID: 216
		public static float delay;

		// Token: 0x040000D9 RID: 217
		private static IntPtr[] setRoleReleaseTLibAttr;
	}
}
