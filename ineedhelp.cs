using System;
using GorillaLocomotion;
using Photon.Pun;
using ShibaGTTemplate.UI;
using UnityEngine;

namespace ShibaGTTemplate.Backend
{
	// Token: 0x0200001D RID: 29
	internal class ineedhelp
	{
		// Token: 0x0600091F RID: 2335 RVA: 0x000574D4 File Offset: 0x000556D4
		private static void GetTypesAsyncProcessMessage(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("PBBV");
			buttons.color(new Color32(230, 127, 102, byte.MaxValue));
			bool flag = t.nindex == 3;
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 1 + 93;
			A_0 = num;
		}

		// Token: 0x06000920 RID: 2336 RVA: 0x00057568 File Offset: 0x00055768
		private static void GetRealProxyArraySegment(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			t.nindex = 1;
			bool flag = t.nindex == 1;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 1 + 173;
			A_0 = num;
		}

		// Token: 0x06000921 RID: 2337 RVA: 0x000575D8 File Offset: 0x000557D8
		private static void UTFMarshalerResourceTypeResourcesDependency(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("PBBV");
			buttons.color(new Color32(230, 127, 102, byte.MaxValue));
			bool flag = t.nindex == 3;
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 1 + 153;
			A_0 = num;
		}

		// Token: 0x06000922 RID: 2338 RVA: 0x0005766C File Offset: 0x0005586C
		private static void InternalStoreCreated(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			A_0 = 253;
		}

		// Token: 0x06000923 RID: 2339 RVA: 0x00057684 File Offset: 0x00055884
		private static void SetImplementationFlagsMonthNameStyles(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.enabled = true;
			c.Prefix(GorillaTagger.Instance.offlineVRRig);
			A_1 = 0;
		}

		// Token: 0x06000924 RID: 2340 RVA: 0x0005789C File Offset: 0x00055A9C
		private static void RegistryAuditRuleIAssemblyEnum(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("PBBV");
			buttons.color(new Color32(230, 127, 102, byte.MaxValue));
			bool flag = t.nindex == 3;
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 1 + 56;
			A_0 = num;
		}

		// Token: 0x06000925 RID: 2341 RVA: 0x00057930 File Offset: 0x00055B30
		private static void MonthTokenGetTypeFromCLSID(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			GorillaTagger.Instance.offlineVRRig.enabled = false;
			GameObject gameObject = GameObject.CreatePrimitive(0);
			A_4 = gameObject;
			GameObject gameObject2 = GameObject.CreatePrimitive(0);
			A_5 = gameObject2;
			Object.Destroy(A_4.GetComponent<Rigidbody>());
			Object.Destroy(A_4.GetComponent<SphereCollider>());
			Object.Destroy(A_5.GetComponent<Rigidbody>());
			Object.Destroy(A_5.GetComponent<SphereCollider>());
			A_4.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
			A_5.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
			A_4.transform.position = GorillaTagger.Instance.rightHandTransform.position;
			A_5.transform.position = GorillaTagger.Instance.leftHandTransform.position;
			A_4.GetComponent<Renderer>().material.color = new Color32(50, 50, 50, byte.MaxValue);
			A_5.GetComponent<Renderer>().material.color = new Color32(50, 50, 50, byte.MaxValue);
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 360), (float)Random.Range(0, 360));
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 180), (float)Random.Range(0, 180));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 360), (float)Random.Range(0, 360));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 180), (float)Random.Range(0, 180));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 360), (float)Random.Range(0, 360));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 180), (float)Random.Range(0, 180));
			Player.Instance.transform.position = new Vector3(Player.Instance.transform.position.x, Player.Instance.transform.position.y + 0.06f, Player.Instance.transform.position.z);
			Object.Destroy(A_4, Time.deltaTime);
			Object.Destroy(A_5, Time.deltaTime);
			t.nindex++;
			bool flag = t.nindex > 3;
			A_6 = flag;
			int num = ((!A_6) ? 1 : 0) * 1 + 269;
			A_0 = num;
		}

		// Token: 0x06000926 RID: 2342 RVA: 0x00057D9C File Offset: 0x00055F9C
		public static void Beffe2rentGts1()
		{
			int num = 194;
			int num2 = 194;
			num2 = 194;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				GameObject gameObject;
				GameObject gameObject2;
				bool flag2;
				bool flag3;
				bool flag4;
				bool flag5;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,UnityEngine.GameObject&,UnityEngine.GameObject&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&), ref num, ref num2, ref num3, ref flag, ref gameObject, ref gameObject2, ref flag2, ref flag3, ref flag4, ref flag5, ineedhelp.TypeNAssemblyReturnValueInArray[num]);
			}
			num2 = 194;
		}

		// Token: 0x06000927 RID: 2343 RVA: 0x00057DEC File Offset: 0x00055FEC
		private static void getIsAbstractGetDeclaredNestedType(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.enabled = true;
			c.Prefix(GorillaTagger.Instance.offlineVRRig);
			A_1 = 0;
		}

		// Token: 0x06000928 RID: 2344 RVA: 0x00058004 File Offset: 0x00056204
		private static void AddValueASSEMBLYFLAGS(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			t.nindex = 1;
			bool flag = t.nindex == 1;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 1 + 161;
			A_0 = num;
		}

		// Token: 0x06000929 RID: 2345 RVA: 0x00058074 File Offset: 0x00056274
		private static void ReadWriteSubTreeWriteLine(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			GorillaTagger.Instance.offlineVRRig.enabled = false;
			GameObject gameObject = GameObject.CreatePrimitive(0);
			A_4 = gameObject;
			GameObject gameObject2 = GameObject.CreatePrimitive(0);
			A_5 = gameObject2;
			Object.Destroy(A_4.GetComponent<Rigidbody>());
			Object.Destroy(A_4.GetComponent<SphereCollider>());
			Object.Destroy(A_5.GetComponent<Rigidbody>());
			Object.Destroy(A_5.GetComponent<SphereCollider>());
			A_4.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
			A_5.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
			A_4.transform.position = GorillaTagger.Instance.rightHandTransform.position;
			A_5.transform.position = GorillaTagger.Instance.leftHandTransform.position;
			A_4.GetComponent<Renderer>().material.color = new Color32(50, 50, 50, byte.MaxValue);
			A_5.GetComponent<Renderer>().material.color = new Color32(50, 50, 50, byte.MaxValue);
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 360), (float)Random.Range(0, 360));
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 180), (float)Random.Range(0, 180));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 360), (float)Random.Range(0, 360));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 180), (float)Random.Range(0, 180));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 360), (float)Random.Range(0, 360));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 180), (float)Random.Range(0, 180));
			Player.Instance.transform.position = new Vector3(Player.Instance.transform.position.x, Player.Instance.transform.position.y + 0.06f, Player.Instance.transform.position.z);
			Object.Destroy(A_4, Time.deltaTime);
			Object.Destroy(A_5, Time.deltaTime);
			t.nindex++;
			bool flag = t.nindex > 3;
			A_6 = flag;
			int num = ((!A_6) ? 1 : 0) * 1 + 159;
			A_0 = num;
		}

		// Token: 0x0600092A RID: 2346 RVA: 0x000584E0 File Offset: 0x000566E0
		private static void PathParsingInfo(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 2;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 1 + 273;
			A_0 = num;
		}

		// Token: 0x0600092B RID: 2347 RVA: 0x00058544 File Offset: 0x00056744
		private static void BrowserRefreshgetVersionString(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("J3VU");
			buttons.color(new Color32(5, 200, 30, byte.MaxValue));
			A_0 = 241;
		}

		// Token: 0x0600092C RID: 2348 RVA: 0x00058590 File Offset: 0x00056790
		private static void ImportIsMethodOverloaded(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("J3VU");
			buttons.color(new Color32(5, 200, 30, byte.MaxValue));
			A_0 = 11;
		}

		// Token: 0x0600092D RID: 2349 RVA: 0x000585DC File Offset: 0x000567DC
		private static void OriginSchemeTKINDDISPATCH(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("DAISY09");
			buttons.color(new Color32(byte.MaxValue, 81, 231, byte.MaxValue));
			bool flag = t.nindex == 2;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 1 + 212;
			A_0 = num;
		}

		// Token: 0x0600092E RID: 2350 RVA: 0x00058670 File Offset: 0x00056870
		private static void ResourceManagerAuthorityEvent(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			c.Prefix(GorillaTagger.Instance.offlineVRRig);
			A_1 = 0;
		}

		// Token: 0x0600092F RID: 2351 RVA: 0x00058698 File Offset: 0x00056898
		private static void getPrivilegeNameGetAssemblyIdentity(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 1;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 1 + 64;
			A_0 = num;
		}

		// Token: 0x06000930 RID: 2352 RVA: 0x000586FC File Offset: 0x000568FC
		private static void ActivityIdEmptySet(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			A_0 = 132;
		}

		// Token: 0x06000931 RID: 2353 RVA: 0x00058714 File Offset: 0x00056914
		private static void ComRedirectionProxyPrincipalPermissionAttribute(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 1;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 1 + 222;
			A_0 = num;
		}

		// Token: 0x06000932 RID: 2354 RVA: 0x00058778 File Offset: 0x00056978
		private static void getDetailgetFirstDayOfWeek(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			t.nindex = 1;
			bool flag = t.nindex == 1;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 1 + 234;
			A_0 = num;
		}

		// Token: 0x06000933 RID: 2355 RVA: 0x000587E8 File Offset: 0x000569E8
		public static void sp11m()
		{
			int num = 109;
			int num2 = 109;
			num2 = 109;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				GameObject gameObject;
				GameObject gameObject2;
				bool flag2;
				bool flag3;
				bool flag4;
				bool flag5;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,UnityEngine.GameObject&,UnityEngine.GameObject&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&), ref num, ref num2, ref num3, ref flag, ref gameObject, ref gameObject2, ref flag2, ref flag3, ref flag4, ref flag5, ineedhelp.TypeNAssemblyReturnValueInArray[num]);
			}
			num2 = 109;
		}

		// Token: 0x06000934 RID: 2356 RVA: 0x0005882C File Offset: 0x00056A2C
		private static void CCMAXgetVersion(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 3;
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 1 + 129;
			A_0 = num;
		}

		// Token: 0x06000935 RID: 2357 RVA: 0x00058890 File Offset: 0x00056A90
		private static void setHeadersIntranet(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			t.nindex = 1;
			bool flag = t.nindex == 1;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 1 + 198;
			A_0 = num;
		}

		// Token: 0x06000936 RID: 2358 RVA: 0x00058900 File Offset: 0x00056B00
		private static void GetPrimeProcessorArchitectureINTEL(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("DAISY09");
			buttons.color(new Color32(byte.MaxValue, 81, 231, byte.MaxValue));
			bool flag = t.nindex == 2;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 1 + 79;
			A_0 = num;
		}

		// Token: 0x06000937 RID: 2359 RVA: 0x00058994 File Offset: 0x00056B94
		private static void RelatedActivityIdsetReturnXmlElementName(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool gripDownR = buttons.gripDownR;
			A_3 = gripDownR;
			int num = ((!A_3) ? 1 : 0) * 9 + 134;
			A_0 = num;
		}

		// Token: 0x06000938 RID: 2360 RVA: 0x000589F0 File Offset: 0x00056BF0
		private static void NowPermissionRequestEvidence(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 3;
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 1 + 202;
			A_0 = num;
		}

		// Token: 0x06000939 RID: 2361 RVA: 0x00058A54 File Offset: 0x00056C54
		private static void IgnoreNonSpaceBadData(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("DAISY09");
			buttons.color(new Color32(byte.MaxValue, 81, 231, byte.MaxValue));
			bool flag = t.nindex == 2;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 1 + 54;
			A_0 = num;
		}

		// Token: 0x0600093A RID: 2362 RVA: 0x00058AE8 File Offset: 0x00056CE8
		public static void findt1hehiddencode()
		{
			int num = 145;
			int num2 = 145;
			num2 = 145;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				GameObject gameObject;
				GameObject gameObject2;
				bool flag2;
				bool flag3;
				bool flag4;
				bool flag5;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,UnityEngine.GameObject&,UnityEngine.GameObject&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&), ref num, ref num2, ref num3, ref flag, ref gameObject, ref gameObject2, ref flag2, ref flag3, ref flag4, ref flag5, ineedhelp.TypeNAssemblyReturnValueInArray[num]);
			}
			num2 = 145;
		}

		// Token: 0x0600093B RID: 2363 RVA: 0x00058B38 File Offset: 0x00056D38
		private static void TokenAppContainerNumberGetMinute(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("J3VU");
			buttons.color(new Color32(5, 200, 30, byte.MaxValue));
			A_0 = 35;
		}

		// Token: 0x0600093C RID: 2364 RVA: 0x00058B84 File Offset: 0x00056D84
		private static void AFRfcDeriveBytes(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("J3VU");
			buttons.color(new Color32(5, 200, 30, byte.MaxValue));
			A_0 = 108;
		}

		// Token: 0x0600093D RID: 2365 RVA: 0x00058BD0 File Offset: 0x00056DD0
		private static void getIsNetFxLegacyManagedDeflateStreamgetLastWriteTime(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			GorillaTagger.Instance.offlineVRRig.enabled = false;
			GameObject gameObject = GameObject.CreatePrimitive(0);
			A_4 = gameObject;
			GameObject gameObject2 = GameObject.CreatePrimitive(0);
			A_5 = gameObject2;
			Object.Destroy(A_4.GetComponent<Rigidbody>());
			Object.Destroy(A_4.GetComponent<SphereCollider>());
			Object.Destroy(A_5.GetComponent<Rigidbody>());
			Object.Destroy(A_5.GetComponent<SphereCollider>());
			A_4.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
			A_5.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
			A_4.transform.position = GorillaTagger.Instance.rightHandTransform.position;
			A_5.transform.position = GorillaTagger.Instance.leftHandTransform.position;
			A_4.GetComponent<Renderer>().material.color = new Color32(50, 50, 50, byte.MaxValue);
			A_5.GetComponent<Renderer>().material.color = new Color32(50, 50, 50, byte.MaxValue);
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 360), (float)Random.Range(0, 360));
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 180), (float)Random.Range(0, 180));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 360), (float)Random.Range(0, 360));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 180), (float)Random.Range(0, 180));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 360), (float)Random.Range(0, 360));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 180), (float)Random.Range(0, 180));
			Player.Instance.transform.position = new Vector3(Player.Instance.transform.position.x, Player.Instance.transform.position.y + 0.06f, Player.Instance.transform.position.z);
			Object.Destroy(A_4, Time.deltaTime);
			Object.Destroy(A_5, Time.deltaTime);
			t.nindex++;
			bool flag = t.nindex > 3;
			A_6 = flag;
			int num = ((!A_6) ? 1 : 0) * 1 + 14;
			A_0 = num;
		}

		// Token: 0x0600093E RID: 2366 RVA: 0x0005903C File Offset: 0x0005723C
		private static void GetZoneAndOrigingetSubKeyCount(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("J3VU");
			buttons.color(new Color32(5, 200, 30, byte.MaxValue));
			A_0 = 290;
		}

		// Token: 0x0600093F RID: 2367 RVA: 0x00059088 File Offset: 0x00057288
		private static void BindReferenceToAssemblyIdentityIHashElementEntry(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			c.Prefix(GorillaTagger.Instance.offlineVRRig);
			A_1 = 0;
		}

		// Token: 0x06000940 RID: 2368 RVA: 0x000590B0 File Offset: 0x000572B0
		private static void setProviderNameOSX(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			A_0 = 47;
		}

		// Token: 0x06000941 RID: 2369 RVA: 0x000590C8 File Offset: 0x000572C8
		private static void InterfaceMappingGetLibAttr(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool gripDownR = buttons.gripDownR;
			A_3 = gripDownR;
			int num = ((!A_3) ? 1 : 0) * 9 + 49;
			A_0 = num;
		}

		// Token: 0x06000942 RID: 2370 RVA: 0x00059124 File Offset: 0x00057324
		private static void GetLoadedModulesComposedOfNoPublicMembers(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("J3VU");
			buttons.color(new Color32(5, 200, 30, byte.MaxValue));
			A_0 = 96;
		}

		// Token: 0x06000943 RID: 2371 RVA: 0x00059170 File Offset: 0x00057370
		private static void SymLanguageTypeClaimsIdentity(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 2;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 1 + 151;
			A_0 = num;
		}

		// Token: 0x06000944 RID: 2372 RVA: 0x000591D4 File Offset: 0x000573D4
		private static void IBindableIterableGenericMethodInfo(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			A_0 = 23;
		}

		// Token: 0x06000945 RID: 2373 RVA: 0x000591EC File Offset: 0x000573EC
		private static void ArgArrayPlusOffTooSmallCreationOptions(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			A_0 = 156;
		}

		// Token: 0x06000946 RID: 2374 RVA: 0x00059204 File Offset: 0x00057404
		private static void GetEqualityComparerForSerializationBinaryObjectString(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 1;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 1 + 271;
			A_0 = num;
		}

		// Token: 0x06000947 RID: 2375 RVA: 0x00059268 File Offset: 0x00057468
		private static void PathDiscoverySetEnableAllKeywords(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			A_0 = 241;
		}

		// Token: 0x06000948 RID: 2376 RVA: 0x00059280 File Offset: 0x00057480
		private static void ObjectUserGetActiveObject(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			GorillaTagger.Instance.offlineVRRig.enabled = false;
			GameObject gameObject = GameObject.CreatePrimitive(0);
			A_4 = gameObject;
			GameObject gameObject2 = GameObject.CreatePrimitive(0);
			A_5 = gameObject2;
			Object.Destroy(A_4.GetComponent<Rigidbody>());
			Object.Destroy(A_4.GetComponent<SphereCollider>());
			Object.Destroy(A_5.GetComponent<Rigidbody>());
			Object.Destroy(A_5.GetComponent<SphereCollider>());
			A_4.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
			A_5.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
			A_4.transform.position = GorillaTagger.Instance.rightHandTransform.position;
			A_5.transform.position = GorillaTagger.Instance.leftHandTransform.position;
			A_4.GetComponent<Renderer>().material.color = new Color32(50, 50, 50, byte.MaxValue);
			A_5.GetComponent<Renderer>().material.color = new Color32(50, 50, 50, byte.MaxValue);
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 360), (float)Random.Range(0, 360));
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 180), (float)Random.Range(0, 180));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 360), (float)Random.Range(0, 360));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 180), (float)Random.Range(0, 180));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 360), (float)Random.Range(0, 360));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 180), (float)Random.Range(0, 180));
			Player.Instance.transform.position = new Vector3(Player.Instance.transform.position.x, Player.Instance.transform.position.y + 0.06f, Player.Instance.transform.position.z);
			Object.Destroy(A_4, Time.deltaTime);
			Object.Destroy(A_5, Time.deltaTime);
			t.nindex++;
			bool flag = t.nindex > 3;
			A_6 = flag;
			int num = ((!A_6) ? 1 : 0) * 1 + 26;
			A_0 = num;
		}

		// Token: 0x06000949 RID: 2377 RVA: 0x000596EC File Offset: 0x000578EC
		private static void IDisposableToIClosableAdapterSecurityDocumentElement(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool gripDownR = buttons.gripDownR;
			A_3 = gripDownR;
			int num = ((!A_3) ? 1 : 0) * 9 + 170;
			A_0 = num;
		}

		// Token: 0x0600094A RID: 2378 RVA: 0x00059748 File Offset: 0x00057948
		private static void TransformDispRetValsQueueEnumerator(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			c.Prefix(GorillaTagger.Instance.offlineVRRig);
			A_1 = 0;
		}

		// Token: 0x0600094B RID: 2379 RVA: 0x00059770 File Offset: 0x00057970
		public static void sp1ammmm()
		{
			int num = 133;
			int num2 = 133;
			num2 = 133;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				GameObject gameObject;
				GameObject gameObject2;
				bool flag2;
				bool flag3;
				bool flag4;
				bool flag5;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,UnityEngine.GameObject&,UnityEngine.GameObject&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&), ref num, ref num2, ref num3, ref flag, ref gameObject, ref gameObject2, ref flag2, ref flag3, ref flag4, ref flag5, ineedhelp.TypeNAssemblyReturnValueInArray[num]);
			}
			num2 = 133;
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x000597C0 File Offset: 0x000579C0
		private static void CreateFromNameDTSubString(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.enabled = true;
			c.Prefix(GorillaTagger.Instance.offlineVRRig);
			A_1 = 0;
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x000599D8 File Offset: 0x00057BD8
		public static void d1awda()
		{
			int num = 157;
			int num2 = 157;
			num2 = 157;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				GameObject gameObject;
				GameObject gameObject2;
				bool flag2;
				bool flag3;
				bool flag4;
				bool flag5;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,UnityEngine.GameObject&,UnityEngine.GameObject&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&), ref num, ref num2, ref num3, ref flag, ref gameObject, ref gameObject2, ref flag2, ref flag3, ref flag4, ref flag5, ineedhelp.TypeNAssemblyReturnValueInArray[num]);
			}
			num2 = 157;
		}

		// Token: 0x0600094E RID: 2382 RVA: 0x00059A28 File Offset: 0x00057C28
		private static void ExpandStringgetOffset(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			A_0 = 168;
		}

		// Token: 0x0600094F RID: 2383 RVA: 0x00059A40 File Offset: 0x00057C40
		private static void UserNameDss(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			A_0 = 180;
		}

		// Token: 0x06000950 RID: 2384 RVA: 0x00059A58 File Offset: 0x00057C58
		private static void getElementTypegetISOCurrencySymbol(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("DAISY09");
			buttons.color(new Color32(byte.MaxValue, 81, 231, byte.MaxValue));
			bool flag = t.nindex == 2;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 1 + 66;
			A_0 = num;
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x00059AEC File Offset: 0x00057CEC
		private static void GetMethodFromHandlesetTaskScheduler(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("PBBV");
			buttons.color(new Color32(230, 127, 102, byte.MaxValue));
			bool flag = t.nindex == 3;
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 1 + 81;
			A_0 = num;
		}

		// Token: 0x06000952 RID: 2386 RVA: 0x00059B80 File Offset: 0x00057D80
		private static void setShortTimePatternsetIsConsoleEnabled(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("DAISY09");
			buttons.color(new Color32(byte.MaxValue, 81, 231, byte.MaxValue));
			bool flag = t.nindex == 2;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 1 + 224;
			A_0 = num;
		}

		// Token: 0x06000953 RID: 2387 RVA: 0x00059C14 File Offset: 0x00057E14
		private static void cPropertiesToSetgetBindingRedirects(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 1;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 1 + 101;
			A_0 = num;
		}

		// Token: 0x06000954 RID: 2388 RVA: 0x00059C78 File Offset: 0x00057E78
		private static void getOwnerSilent(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			GorillaTagger.Instance.offlineVRRig.enabled = false;
			GameObject gameObject = GameObject.CreatePrimitive(0);
			A_4 = gameObject;
			GameObject gameObject2 = GameObject.CreatePrimitive(0);
			A_5 = gameObject2;
			Object.Destroy(A_4.GetComponent<Rigidbody>());
			Object.Destroy(A_4.GetComponent<SphereCollider>());
			Object.Destroy(A_5.GetComponent<Rigidbody>());
			Object.Destroy(A_5.GetComponent<SphereCollider>());
			A_4.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
			A_5.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
			A_4.transform.position = GorillaTagger.Instance.rightHandTransform.position;
			A_5.transform.position = GorillaTagger.Instance.leftHandTransform.position;
			A_4.GetComponent<Renderer>().material.color = new Color32(50, 50, 50, byte.MaxValue);
			A_5.GetComponent<Renderer>().material.color = new Color32(50, 50, 50, byte.MaxValue);
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 360), (float)Random.Range(0, 360));
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 180), (float)Random.Range(0, 180));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 360), (float)Random.Range(0, 360));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 180), (float)Random.Range(0, 180));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 360), (float)Random.Range(0, 360));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 180), (float)Random.Range(0, 180));
			Player.Instance.transform.position = new Vector3(Player.Instance.transform.position.x, Player.Instance.transform.position.y + 0.06f, Player.Instance.transform.position.z);
			Object.Destroy(A_4, Time.deltaTime);
			Object.Destroy(A_5, Time.deltaTime);
			t.nindex++;
			bool flag = t.nindex > 3;
			A_6 = flag;
			int num = ((!A_6) ? 1 : 0) * 1 + 257;
			A_0 = num;
		}

		// Token: 0x06000955 RID: 2389 RVA: 0x0005A0E4 File Offset: 0x000582E4
		private static void RfcNameEuropeanNumber(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			A_0 = 59;
		}

		// Token: 0x06000956 RID: 2390 RVA: 0x0005A0FC File Offset: 0x000582FC
		private static void StackFrameHelpersetAppDomainManagerType(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			c.Prefix(GorillaTagger.Instance.offlineVRRig);
			A_1 = 0;
		}

		// Token: 0x06000957 RID: 2391 RVA: 0x0005A124 File Offset: 0x00058324
		private static void getResourceScopeSetActorAsReferenceWhenCopyingClaimsIdentity(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("J3VU");
			buttons.color(new Color32(5, 200, 30, byte.MaxValue));
			A_0 = 193;
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x0005A170 File Offset: 0x00058370
		public static void dawda()
		{
			int num = 48;
			int num2 = 48;
			num2 = 48;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				GameObject gameObject;
				GameObject gameObject2;
				bool flag2;
				bool flag3;
				bool flag4;
				bool flag5;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,UnityEngine.GameObject&,UnityEngine.GameObject&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&), ref num, ref num2, ref num3, ref flag, ref gameObject, ref gameObject2, ref flag2, ref flag3, ref flag4, ref flag5, ineedhelp.TypeNAssemblyReturnValueInArray[num]);
			}
			num2 = 48;
		}

		// Token: 0x06000959 RID: 2393 RVA: 0x0005A1B4 File Offset: 0x000583B4
		private static void ConstructorArgumentsTraverse(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.enabled = true;
			c.Prefix(GorillaTagger.Instance.offlineVRRig);
			A_1 = 0;
		}

		// Token: 0x0600095A RID: 2394 RVA: 0x0005A3CC File Offset: 0x000585CC
		private static void UndockTimeoutException(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("J3VU");
			buttons.color(new Color32(5, 200, 30, byte.MaxValue));
			A_0 = 132;
		}

		// Token: 0x0600095B RID: 2395 RVA: 0x0005A418 File Offset: 0x00058618
		private static void CompatibleFrameworksMetadataEntryDisableComObjectEagerCleanup(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			GorillaTagger.Instance.offlineVRRig.enabled = false;
			GameObject gameObject = GameObject.CreatePrimitive(0);
			A_4 = gameObject;
			GameObject gameObject2 = GameObject.CreatePrimitive(0);
			A_5 = gameObject2;
			Object.Destroy(A_4.GetComponent<Rigidbody>());
			Object.Destroy(A_4.GetComponent<SphereCollider>());
			Object.Destroy(A_5.GetComponent<Rigidbody>());
			Object.Destroy(A_5.GetComponent<SphereCollider>());
			A_4.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
			A_5.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
			A_4.transform.position = GorillaTagger.Instance.rightHandTransform.position;
			A_5.transform.position = GorillaTagger.Instance.leftHandTransform.position;
			A_4.GetComponent<Renderer>().material.color = new Color32(50, 50, 50, byte.MaxValue);
			A_5.GetComponent<Renderer>().material.color = new Color32(50, 50, 50, byte.MaxValue);
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 360), (float)Random.Range(0, 360));
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 180), (float)Random.Range(0, 180));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 360), (float)Random.Range(0, 360));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 180), (float)Random.Range(0, 180));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 360), (float)Random.Range(0, 360));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 180), (float)Random.Range(0, 180));
			Player.Instance.transform.position = new Vector3(Player.Instance.transform.position.x, Player.Instance.transform.position.y + 0.06f, Player.Instance.transform.position.z);
			Object.Destroy(A_4, Time.deltaTime);
			Object.Destroy(A_5, Time.deltaTime);
			t.nindex++;
			bool flag = t.nindex > 3;
			A_6 = flag;
			int num = ((!A_6) ? 1 : 0) * 1 + 147;
			A_0 = num;
		}

		// Token: 0x0600095C RID: 2396 RVA: 0x0005A884 File Offset: 0x00058A84
		private static void ComVisibleAttributeVBByValStrMarshaler(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 2;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 1 + 188;
			A_0 = num;
		}

		// Token: 0x0600095D RID: 2397 RVA: 0x0005A8E8 File Offset: 0x00058AE8
		private static void GetManifestResourceInfoManualResetEventSlim(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("PBBV");
			buttons.color(new Color32(230, 127, 102, byte.MaxValue));
			bool flag = t.nindex == 3;
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 1 + 202;
			A_0 = num;
		}

		// Token: 0x0600095E RID: 2398 RVA: 0x0005A97C File Offset: 0x00058B7C
		private static void UtfJsonsetNumberDecimalSeparator(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			GorillaTagger.Instance.offlineVRRig.enabled = false;
			GameObject gameObject = GameObject.CreatePrimitive(0);
			A_4 = gameObject;
			GameObject gameObject2 = GameObject.CreatePrimitive(0);
			A_5 = gameObject2;
			Object.Destroy(A_4.GetComponent<Rigidbody>());
			Object.Destroy(A_4.GetComponent<SphereCollider>());
			Object.Destroy(A_5.GetComponent<Rigidbody>());
			Object.Destroy(A_5.GetComponent<SphereCollider>());
			A_4.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
			A_5.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
			A_4.transform.position = GorillaTagger.Instance.rightHandTransform.position;
			A_5.transform.position = GorillaTagger.Instance.leftHandTransform.position;
			A_4.GetComponent<Renderer>().material.color = new Color32(50, 50, 50, byte.MaxValue);
			A_5.GetComponent<Renderer>().material.color = new Color32(50, 50, 50, byte.MaxValue);
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 360), (float)Random.Range(0, 360));
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 180), (float)Random.Range(0, 180));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 360), (float)Random.Range(0, 360));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 180), (float)Random.Range(0, 180));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 360), (float)Random.Range(0, 360));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 180), (float)Random.Range(0, 180));
			Player.Instance.transform.position = new Vector3(Player.Instance.transform.position.x, Player.Instance.transform.position.y + 0.06f, Player.Instance.transform.position.z);
			Object.Destroy(A_4, Time.deltaTime);
			Object.Destroy(A_5, Time.deltaTime);
			t.nindex++;
			bool flag = t.nindex > 3;
			A_6 = flag;
			int num = ((!A_6) ? 1 : 0) * 1 + 38;
			A_0 = num;
		}

		// Token: 0x0600095F RID: 2399 RVA: 0x0005ADE8 File Offset: 0x00058FE8
		private static void setHostContextObjectDisposedRegKeyClosed(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 1;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 1 + 125;
			A_0 = num;
		}

		// Token: 0x06000960 RID: 2400 RVA: 0x0005AE4C File Offset: 0x0005904C
		private static void TCEAdapterGeneratorIsAppEarlierThanSilverlight(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 1;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 1 + 198;
			A_0 = num;
		}

		// Token: 0x06000961 RID: 2401 RVA: 0x0005AEB0 File Offset: 0x000590B0
		public static void Spam()
		{
			int num = 12;
			int num2 = 12;
			num2 = 12;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				GameObject gameObject;
				GameObject gameObject2;
				bool flag2;
				bool flag3;
				bool flag4;
				bool flag5;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,UnityEngine.GameObject&,UnityEngine.GameObject&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&), ref num, ref num2, ref num3, ref flag, ref gameObject, ref gameObject2, ref flag2, ref flag3, ref flag4, ref flag5, ineedhelp.TypeNAssemblyReturnValueInArray[num]);
			}
			num2 = 12;
		}

		// Token: 0x06000962 RID: 2402 RVA: 0x0005AEF4 File Offset: 0x000590F4
		private static void GetSymAttributeReplacementFallback(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			GorillaTagger.Instance.offlineVRRig.enabled = false;
			GameObject gameObject = GameObject.CreatePrimitive(0);
			A_4 = gameObject;
			GameObject gameObject2 = GameObject.CreatePrimitive(0);
			A_5 = gameObject2;
			Object.Destroy(A_4.GetComponent<Rigidbody>());
			Object.Destroy(A_4.GetComponent<SphereCollider>());
			Object.Destroy(A_5.GetComponent<Rigidbody>());
			Object.Destroy(A_5.GetComponent<SphereCollider>());
			A_4.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
			A_5.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
			A_4.transform.position = GorillaTagger.Instance.rightHandTransform.position;
			A_5.transform.position = GorillaTagger.Instance.leftHandTransform.position;
			A_4.GetComponent<Renderer>().material.color = new Color32(50, 50, 50, byte.MaxValue);
			A_5.GetComponent<Renderer>().material.color = new Color32(50, 50, 50, byte.MaxValue);
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 360), (float)Random.Range(0, 360));
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 180), (float)Random.Range(0, 180));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 360), (float)Random.Range(0, 360));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 180), (float)Random.Range(0, 180));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 360), (float)Random.Range(0, 360));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 180), (float)Random.Range(0, 180));
			Player.Instance.transform.position = new Vector3(Player.Instance.transform.position.x, Player.Instance.transform.position.y + 0.06f, Player.Instance.transform.position.z);
			Object.Destroy(A_4, Time.deltaTime);
			Object.Destroy(A_5, Time.deltaTime);
			t.nindex++;
			bool flag = t.nindex > 3;
			A_6 = flag;
			int num = ((!A_6) ? 1 : 0) * 1 + 123;
			A_0 = num;
		}

		// Token: 0x06000963 RID: 2403 RVA: 0x0005B360 File Offset: 0x00059560
		private static void FirstFullWeekgetBaseUtcOffset(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("PBBV");
			buttons.color(new Color32(230, 127, 102, byte.MaxValue));
			bool flag = t.nindex == 3;
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 1 + 117;
			A_0 = num;
		}

		// Token: 0x06000964 RID: 2404 RVA: 0x0005B3F4 File Offset: 0x000595F4
		private static void ReplicatorEndOffset(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 2;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 1 + 236;
			A_0 = num;
		}

		// Token: 0x06000965 RID: 2405 RVA: 0x0005B458 File Offset: 0x00059658
		private static void EventOpcodeServerProcessing(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool gripDownR = buttons.gripDownR;
			A_3 = gripDownR;
			int num = ((!A_3) ? 1 : 0) * 9 + 207;
			A_0 = num;
		}

		// Token: 0x06000966 RID: 2406 RVA: 0x0005B4B4 File Offset: 0x000596B4
		private static void getIsCOMObjectCommonMusic(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			A_0 = 84;
		}

		// Token: 0x06000967 RID: 2407 RVA: 0x0005B4CC File Offset: 0x000596CC
		private static void ThreadTransferReceiveObjPERSIAN(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.enabled = true;
			c.Prefix(GorillaTagger.Instance.offlineVRRig);
			A_1 = 0;
		}

		// Token: 0x06000968 RID: 2408 RVA: 0x0005B6E4 File Offset: 0x000598E4
		private static void getViewDefaultRequestSet(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 1;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 1 + 149;
			A_0 = num;
		}

		// Token: 0x06000969 RID: 2409 RVA: 0x0005B748 File Offset: 0x00059948
		private static void IntegerIdsUnmanagedMemoryStreamWrapper(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.enabled = true;
			c.Prefix(GorillaTagger.Instance.offlineVRRig);
			A_1 = 0;
		}

		// Token: 0x0600096A RID: 2410 RVA: 0x0005B960 File Offset: 0x00059B60
		private static void cbStructgetCategoryMembershipSection(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("J3VU");
			buttons.color(new Color32(5, 200, 30, byte.MaxValue));
			A_0 = 278;
		}

		// Token: 0x0600096B RID: 2411 RVA: 0x0005B9AC File Offset: 0x00059BAC
		public static void Beerent1ts1()
		{
			int num = 279;
			int num2 = 279;
			num2 = 279;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				GameObject gameObject;
				GameObject gameObject2;
				bool flag2;
				bool flag3;
				bool flag4;
				bool flag5;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,UnityEngine.GameObject&,UnityEngine.GameObject&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&), ref num, ref num2, ref num3, ref flag, ref gameObject, ref gameObject2, ref flag2, ref flag3, ref flag4, ref flag5, ineedhelp.TypeNAssemblyReturnValueInArray[num]);
			}
			num2 = 279;
		}

		// Token: 0x0600096C RID: 2412 RVA: 0x0005B9FC File Offset: 0x00059BFC
		private static void MaxGenerationIsSuffix(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 3;
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 1 + 56;
			A_0 = num;
		}

		// Token: 0x0600096D RID: 2413 RVA: 0x0005BA60 File Offset: 0x00059C60
		private static void MyVideosCCRESERVED(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			t.nindex = 1;
			bool flag = t.nindex == 1;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 1 + 64;
			A_0 = num;
		}

		// Token: 0x0600096E RID: 2414 RVA: 0x0005BAD0 File Offset: 0x00059CD0
		private static void UnspecifiedTypeSizeCertificate(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 2;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 1 + 79;
			A_0 = num;
		}

		// Token: 0x0600096F RID: 2415 RVA: 0x0005BB34 File Offset: 0x00059D34
		private static void WaitDelegategetOriginalIssuer(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("J3VU");
			buttons.color(new Color32(5, 200, 30, byte.MaxValue));
			A_0 = 253;
		}

		// Token: 0x06000970 RID: 2416 RVA: 0x0005BB80 File Offset: 0x00059D80
		private static void mretValMarshalDirectiveException(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.enabled = true;
			c.Prefix(GorillaTagger.Instance.offlineVRRig);
			A_1 = 0;
		}

		// Token: 0x06000971 RID: 2417 RVA: 0x0005BD98 File Offset: 0x00059F98
		private static void UTFEncodingsetPermitOnlySetInstance(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool gripDownR = buttons.gripDownR;
			A_3 = gripDownR;
			int num = ((!A_3) ? 1 : 0) * 9 + 195;
			A_0 = num;
		}

		// Token: 0x06000972 RID: 2418 RVA: 0x0005BDF4 File Offset: 0x00059FF4
		private static void SoapMethodAttributeLoadPolicyLevelFromFile(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			t.nindex = 1;
			bool flag = t.nindex == 1;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 1 + 149;
			A_0 = num;
		}

		// Token: 0x06000973 RID: 2419 RVA: 0x0005BE64 File Offset: 0x0005A064
		private static void AsyncMethodBuilderCoreComponentRelativePath(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.enabled = true;
			c.Prefix(GorillaTagger.Instance.offlineVRRig);
			A_1 = 0;
		}

		// Token: 0x06000974 RID: 2420 RVA: 0x0005C07C File Offset: 0x0005A27C
		public static void dawd()
		{
			int num = 60;
			int num2 = 60;
			num2 = 60;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				GameObject gameObject;
				GameObject gameObject2;
				bool flag2;
				bool flag3;
				bool flag4;
				bool flag5;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,UnityEngine.GameObject&,UnityEngine.GameObject&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&), ref num, ref num2, ref num3, ref flag, ref gameObject, ref gameObject2, ref flag2, ref flag3, ref flag4, ref flag5, ineedhelp.TypeNAssemblyReturnValueInArray[num]);
			}
			num2 = 60;
		}

		// Token: 0x06000975 RID: 2421 RVA: 0x0005C0C0 File Offset: 0x0005A2C0
		private static void CeilingChannelData(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			t.nindex = 1;
			bool flag = t.nindex == 1;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 1 + 28;
			A_0 = num;
		}

		// Token: 0x06000976 RID: 2422 RVA: 0x0005C130 File Offset: 0x0005A330
		private static void NumTimesuffTotalDays(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("PBBV");
			buttons.color(new Color32(230, 127, 102, byte.MaxValue));
			bool flag = t.nindex == 3;
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 1 + 190;
			A_0 = num;
		}

		// Token: 0x06000977 RID: 2423 RVA: 0x0005C1C4 File Offset: 0x0005A3C4
		private static void FastResourceComparerAnsiCharMarshaler(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 2;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 1 + 91;
			A_0 = num;
		}

		// Token: 0x06000978 RID: 2424 RVA: 0x0005C228 File Offset: 0x0005A428
		private static void getTargetedPatchBandPrimitive(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("DAISY09");
			buttons.color(new Color32(byte.MaxValue, 81, 231, byte.MaxValue));
			bool flag = t.nindex == 2;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 1 + 248;
			A_0 = num;
		}

		// Token: 0x06000979 RID: 2425 RVA: 0x0005C2BC File Offset: 0x0005A4BC
		private static void OperationalUCOMIStream(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 2;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 1 + 42;
			A_0 = num;
		}

		// Token: 0x0600097A RID: 2426 RVA: 0x0005C320 File Offset: 0x0005A520
		private static void getTraceLevelEnumerateFileSystemInfos(ref int A_0, ref int A_1, ref int A_2)
		{
			PhotonNetwork.Disconnect();
			A_1 = 0;
		}

		// Token: 0x0600097B RID: 2427 RVA: 0x0005C340 File Offset: 0x0005A540
		private static void HasFlushedFinalBlockReadBlockAsync(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("DAISY09");
			buttons.color(new Color32(byte.MaxValue, 81, 231, byte.MaxValue));
			bool flag = t.nindex == 2;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 1 + 6;
			A_0 = num;
		}

		// Token: 0x0600097C RID: 2428 RVA: 0x0005C3D4 File Offset: 0x0005A5D4
		private static void setCapacityGetObjectForNativeVariant(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			GorillaTagger.Instance.offlineVRRig.enabled = false;
			GameObject gameObject = GameObject.CreatePrimitive(0);
			A_4 = gameObject;
			GameObject gameObject2 = GameObject.CreatePrimitive(0);
			A_5 = gameObject2;
			Object.Destroy(A_4.GetComponent<Rigidbody>());
			Object.Destroy(A_4.GetComponent<SphereCollider>());
			Object.Destroy(A_5.GetComponent<Rigidbody>());
			Object.Destroy(A_5.GetComponent<SphereCollider>());
			A_4.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
			A_5.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
			A_4.transform.position = GorillaTagger.Instance.rightHandTransform.position;
			A_5.transform.position = GorillaTagger.Instance.leftHandTransform.position;
			A_4.GetComponent<Renderer>().material.color = new Color32(50, 50, 50, byte.MaxValue);
			A_5.GetComponent<Renderer>().material.color = new Color32(50, 50, 50, byte.MaxValue);
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 360), (float)Random.Range(0, 360));
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 180), (float)Random.Range(0, 180));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 360), (float)Random.Range(0, 360));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 180), (float)Random.Range(0, 180));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 360), (float)Random.Range(0, 360));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 180), (float)Random.Range(0, 180));
			Player.Instance.transform.position = new Vector3(Player.Instance.transform.position.x, Player.Instance.transform.position.y + 0.06f, Player.Instance.transform.position.z);
			Object.Destroy(A_4, Time.deltaTime);
			Object.Destroy(A_5, Time.deltaTime);
			t.nindex++;
			bool flag = t.nindex > 3;
			A_6 = flag;
			int num = ((!A_6) ? 1 : 0) * 1 + 220;
			A_0 = num;
		}

		// Token: 0x0600097D RID: 2429 RVA: 0x0005C840 File Offset: 0x0005AA40
		private static void cDisplayClassGetLoadedModules(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			t.nindex = 1;
			bool flag = t.nindex == 1;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 1 + 16;
			A_0 = num;
		}

		// Token: 0x0600097E RID: 2430 RVA: 0x0005C8B0 File Offset: 0x0005AAB0
		private static void MinSupportedDateTimeAppDomainManager(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("DAISY09");
			buttons.color(new Color32(byte.MaxValue, 81, 231, byte.MaxValue));
			bool flag = t.nindex == 2;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 1 + 285;
			A_0 = num;
		}

		// Token: 0x0600097F RID: 2431 RVA: 0x0005C944 File Offset: 0x0005AB44
		private static void MaxOpaqueLengthgetIsAppEarlierThanWindowsPhoneMango(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			GorillaTagger.Instance.offlineVRRig.enabled = false;
			GameObject gameObject = GameObject.CreatePrimitive(0);
			A_4 = gameObject;
			GameObject gameObject2 = GameObject.CreatePrimitive(0);
			A_5 = gameObject2;
			Object.Destroy(A_4.GetComponent<Rigidbody>());
			Object.Destroy(A_4.GetComponent<SphereCollider>());
			Object.Destroy(A_5.GetComponent<Rigidbody>());
			Object.Destroy(A_5.GetComponent<SphereCollider>());
			A_4.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
			A_5.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
			A_4.transform.position = GorillaTagger.Instance.rightHandTransform.position;
			A_5.transform.position = GorillaTagger.Instance.leftHandTransform.position;
			A_4.GetComponent<Renderer>().material.color = new Color32(50, 50, 50, byte.MaxValue);
			A_5.GetComponent<Renderer>().material.color = new Color32(50, 50, 50, byte.MaxValue);
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 360), (float)Random.Range(0, 360));
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 180), (float)Random.Range(0, 180));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 360), (float)Random.Range(0, 360));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 180), (float)Random.Range(0, 180));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 360), (float)Random.Range(0, 360));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 180), (float)Random.Range(0, 180));
			Player.Instance.transform.position = new Vector3(Player.Instance.transform.position.x, Player.Instance.transform.position.y + 0.06f, Player.Instance.transform.position.z);
			Object.Destroy(A_4, Time.deltaTime);
			Object.Destroy(A_5, Time.deltaTime);
			t.nindex++;
			bool flag = t.nindex > 3;
			A_6 = flag;
			int num = ((!A_6) ? 1 : 0) * 1 + 135;
			A_0 = num;
		}

		// Token: 0x06000980 RID: 2432 RVA: 0x0005CDB0 File Offset: 0x0005AFB0
		private static void AtFixedPermissionListSet(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool gripDownR = buttons.gripDownR;
			A_3 = gripDownR;
			int num = ((!A_3) ? 1 : 0) * 9 + 37;
			A_0 = num;
		}

		// Token: 0x06000981 RID: 2433 RVA: 0x0005CE0C File Offset: 0x0005B00C
		public ineedhelp()
		{
			int num = 291;
			int num2 = 291;
			num2 = 291;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,ShibaGTTemplate.Backend.ineedhelp), ref num, ref num2, ref num3, this, ineedhelp.TypeNAssemblyReturnValueInArray[num]);
			}
			num2 = 291;
		}

		// Token: 0x06000982 RID: 2434 RVA: 0x0005CE50 File Offset: 0x0005B050
		private static void AbandonedMutexExceptionVersionCompatibility(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.enabled = true;
			c.Prefix(GorillaTagger.Instance.offlineVRRig);
			A_1 = 0;
		}

		// Token: 0x06000983 RID: 2435 RVA: 0x0005D068 File Offset: 0x0005B268
		private static void SystemAclPresentFailContinueFilter(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.enabled = true;
			c.Prefix(GorillaTagger.Instance.offlineVRRig);
			A_1 = 0;
		}

		// Token: 0x06000984 RID: 2436 RVA: 0x0005D280 File Offset: 0x0005B480
		private static void AuditFlagsRsaSign(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 2;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 1 + 224;
			A_0 = num;
		}

		// Token: 0x06000985 RID: 2437 RVA: 0x0005D2E4 File Offset: 0x0005B4E4
		private static void MarkAbortedSpinLock(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			c.Prefix(GorillaTagger.Instance.offlineVRRig);
			A_1 = 0;
		}

		// Token: 0x06000986 RID: 2438 RVA: 0x0005D30C File Offset: 0x0005B50C
		private static void IsPermissionElementgetOperations(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool gripDownR = buttons.gripDownR;
			A_3 = gripDownR;
			int num = ((!A_3) ? 1 : 0) * 9 + 1;
			A_0 = num;
		}

		// Token: 0x06000987 RID: 2439 RVA: 0x0005D368 File Offset: 0x0005B568
		private static void HasCurrentsetApplicationUrl(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 3;
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 1 + 275;
			A_0 = num;
		}

		// Token: 0x06000988 RID: 2440 RVA: 0x0005D3CC File Offset: 0x0005B5CC
		private static void getMonthGenitiveNamesStartMenu(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			c.Prefix(GorillaTagger.Instance.offlineVRRig);
			A_1 = 0;
		}

		// Token: 0x06000989 RID: 2441 RVA: 0x0005D3F4 File Offset: 0x0005B5F4
		private static void KeyPairgetDirectory(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			c.Prefix(GorillaTagger.Instance.offlineVRRig);
			A_1 = 0;
		}

		// Token: 0x0600098A RID: 2442 RVA: 0x0005D41C File Offset: 0x0005B61C
		private static void IClientChannelSinkProviderTopLevelAssemblyTypeResolver(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 3;
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 1 + 214;
			A_0 = num;
		}

		// Token: 0x0600098B RID: 2443 RVA: 0x0005D480 File Offset: 0x0005B680
		private static void WriteArrayArguments(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 1;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 1 + 259;
			A_0 = num;
		}

		// Token: 0x0600098C RID: 2444 RVA: 0x0005D4E4 File Offset: 0x0005B6E4
		private static void oceAssemblyReferenceDependentAssemblyEntryFieldId(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 3;
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 1 + 93;
			A_0 = num;
		}

		// Token: 0x0600098D RID: 2445 RVA: 0x0005D548 File Offset: 0x0005B748
		private static void AddMinutesgetDeclaredEvents(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			c.Prefix(GorillaTagger.Instance.offlineVRRig);
			A_1 = 0;
		}

		// Token: 0x0600098E RID: 2446 RVA: 0x0005D570 File Offset: 0x0005B770
		private static void setAppDomainInitializerArgumentsSynchronizationAttribute(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 2;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 1 + 103;
			A_0 = num;
		}

		// Token: 0x0600098F RID: 2447 RVA: 0x0005D5D4 File Offset: 0x0005B7D4
		public static void Beffe2rentGts()
		{
			int num = 85;
			int num2 = 85;
			num2 = 85;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				GameObject gameObject;
				GameObject gameObject2;
				bool flag2;
				bool flag3;
				bool flag4;
				bool flag5;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,UnityEngine.GameObject&,UnityEngine.GameObject&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&), ref num, ref num2, ref num3, ref flag, ref gameObject, ref gameObject2, ref flag2, ref flag3, ref flag4, ref flag5, ineedhelp.TypeNAssemblyReturnValueInArray[num]);
			}
			num2 = 85;
		}

		// Token: 0x06000990 RID: 2448 RVA: 0x0005D618 File Offset: 0x0005B818
		private static void setExceptionTypeOtherNeutrals(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			A_0 = 96;
		}

		// Token: 0x06000991 RID: 2449 RVA: 0x0005D630 File Offset: 0x0005B830
		private static void CondBranchGetUnmanagedThunkForManagedMethodPtr(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			A_0 = 290;
		}

		// Token: 0x06000992 RID: 2450 RVA: 0x0005D648 File Offset: 0x0005B848
		private static void SetWindowSizeTYPEFLAGFCANCREATE(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("J3VU");
			buttons.color(new Color32(5, 200, 30, byte.MaxValue));
			A_0 = 84;
		}

		// Token: 0x06000993 RID: 2451 RVA: 0x0005D694 File Offset: 0x0005B894
		private static void RandomNumberGeneratorStdCall(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			GorillaTagger.Instance.offlineVRRig.enabled = false;
			GameObject gameObject = GameObject.CreatePrimitive(0);
			A_4 = gameObject;
			GameObject gameObject2 = GameObject.CreatePrimitive(0);
			A_5 = gameObject2;
			Object.Destroy(A_4.GetComponent<Rigidbody>());
			Object.Destroy(A_4.GetComponent<SphereCollider>());
			Object.Destroy(A_5.GetComponent<Rigidbody>());
			Object.Destroy(A_5.GetComponent<SphereCollider>());
			A_4.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
			A_5.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
			A_4.transform.position = GorillaTagger.Instance.rightHandTransform.position;
			A_5.transform.position = GorillaTagger.Instance.leftHandTransform.position;
			A_4.GetComponent<Renderer>().material.color = new Color32(50, 50, 50, byte.MaxValue);
			A_5.GetComponent<Renderer>().material.color = new Color32(50, 50, 50, byte.MaxValue);
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 360), (float)Random.Range(0, 360));
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 180), (float)Random.Range(0, 180));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 360), (float)Random.Range(0, 360));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 180), (float)Random.Range(0, 180));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 360), (float)Random.Range(0, 360));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 180), (float)Random.Range(0, 180));
			Player.Instance.transform.position = new Vector3(Player.Instance.transform.position.x, Player.Instance.transform.position.y + 0.06f, Player.Instance.transform.position.z);
			Object.Destroy(A_4, Time.deltaTime);
			Object.Destroy(A_5, Time.deltaTime);
			t.nindex++;
			bool flag = t.nindex > 3;
			A_6 = flag;
			int num = ((!A_6) ? 1 : 0) * 1 + 50;
			A_0 = num;
		}

		// Token: 0x06000994 RID: 2452 RVA: 0x0005DB00 File Offset: 0x0005BD00
		private static void StoreCategoryEnumerationAnsiBSTRMarshaler(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 3;
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 1 + 177;
			A_0 = num;
		}

		// Token: 0x06000995 RID: 2453 RVA: 0x0005DB64 File Offset: 0x0005BD64
		private static void getRevisionVersionNoCurrentDateDefault(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool gripDownR = buttons.gripDownR;
			A_3 = gripDownR;
			int num = ((!A_3) ? 1 : 0) * 9 + 280;
			A_0 = num;
		}

		// Token: 0x06000996 RID: 2454 RVA: 0x0005DBC0 File Offset: 0x0005BDC0
		private static void DssGetServerContextSink(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("DAISY09");
			buttons.color(new Color32(byte.MaxValue, 81, 231, byte.MaxValue));
			bool flag = t.nindex == 2;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 1 + 236;
			A_0 = num;
		}

		// Token: 0x06000997 RID: 2455 RVA: 0x0005DC54 File Offset: 0x0005BE54
		public static void d11awd()
		{
			int num = 242;
			int num2 = 242;
			num2 = 242;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				GameObject gameObject;
				GameObject gameObject2;
				bool flag2;
				bool flag3;
				bool flag4;
				bool flag5;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,UnityEngine.GameObject&,UnityEngine.GameObject&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&), ref num, ref num2, ref num3, ref flag, ref gameObject, ref gameObject2, ref flag2, ref flag3, ref flag4, ref flag5, ineedhelp.TypeNAssemblyReturnValueInArray[num]);
			}
			num2 = 242;
		}

		// Token: 0x06000998 RID: 2456 RVA: 0x0005DCA4 File Offset: 0x0005BEA4
		private static void setLoaderOptimizationEventManifestOptions(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.enabled = true;
			c.Prefix(GorillaTagger.Instance.offlineVRRig);
			A_1 = 0;
		}

		// Token: 0x06000999 RID: 2457 RVA: 0x0005DEBC File Offset: 0x0005C0BC
		private static void XMLLangCallvirt(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool gripDownR = buttons.gripDownR;
			A_3 = gripDownR;
			int num = ((!A_3) ? 1 : 0) * 9 + 61;
			A_0 = num;
		}

		// Token: 0x0600099A RID: 2458 RVA: 0x0005DF18 File Offset: 0x0005C118
		private static void CreateSubdirectoryLeftToRightIsolate(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool gripDownR = buttons.gripDownR;
			A_3 = gripDownR;
			int num = ((!A_3) ? 1 : 0) * 9 + 98;
			A_0 = num;
		}

		// Token: 0x0600099B RID: 2459 RVA: 0x0005DF74 File Offset: 0x0005C174
		private static void getIsValueCreatedRenewing(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("J3VU");
			buttons.color(new Color32(5, 200, 30, byte.MaxValue));
			A_0 = 180;
		}

		// Token: 0x0600099C RID: 2460 RVA: 0x0005DFC0 File Offset: 0x0005C1C0
		private static void StfldManageVolume(ref int A_0, ref int A_1, ref int A_2, ineedhelp A_3)
		{
			A_3..ctor();
			A_1 = 0;
		}

		// Token: 0x0600099D RID: 2461 RVA: 0x0005DFE4 File Offset: 0x0005C1E4
		private static void setRoleThisAssembly(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("DAISY09");
			buttons.color(new Color32(byte.MaxValue, 81, 231, byte.MaxValue));
			bool flag = t.nindex == 2;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 1 + 115;
			A_0 = num;
		}

		// Token: 0x0600099E RID: 2462 RVA: 0x0005E078 File Offset: 0x0005C278
		private static void getResourceTypeIdStringIAssemblyRequestEntry(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			t.nindex = 1;
			bool flag = t.nindex == 1;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 1 + 89;
			A_0 = num;
		}

		// Token: 0x0600099F RID: 2463 RVA: 0x0005E0E8 File Offset: 0x0005C2E8
		private static void HashElementTransformsetFlags(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 2;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 1 + 200;
			A_0 = num;
		}

		// Token: 0x060009A0 RID: 2464 RVA: 0x0005E14C File Offset: 0x0005C34C
		private static void getResultgetTargetSite(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			GorillaTagger.Instance.offlineVRRig.enabled = false;
			GameObject gameObject = GameObject.CreatePrimitive(0);
			A_4 = gameObject;
			GameObject gameObject2 = GameObject.CreatePrimitive(0);
			A_5 = gameObject2;
			Object.Destroy(A_4.GetComponent<Rigidbody>());
			Object.Destroy(A_4.GetComponent<SphereCollider>());
			Object.Destroy(A_5.GetComponent<Rigidbody>());
			Object.Destroy(A_5.GetComponent<SphereCollider>());
			A_4.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
			A_5.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
			A_4.transform.position = GorillaTagger.Instance.rightHandTransform.position;
			A_5.transform.position = GorillaTagger.Instance.leftHandTransform.position;
			A_4.GetComponent<Renderer>().material.color = new Color32(50, 50, 50, byte.MaxValue);
			A_5.GetComponent<Renderer>().material.color = new Color32(50, 50, 50, byte.MaxValue);
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 360), (float)Random.Range(0, 360));
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 180), (float)Random.Range(0, 180));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 360), (float)Random.Range(0, 360));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 180), (float)Random.Range(0, 180));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 360), (float)Random.Range(0, 360));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 180), (float)Random.Range(0, 180));
			Player.Instance.transform.position = new Vector3(Player.Instance.transform.position.x, Player.Instance.transform.position.y + 0.06f, Player.Instance.transform.position.z);
			Object.Destroy(A_4, Time.deltaTime);
			Object.Destroy(A_5, Time.deltaTime);
			t.nindex++;
			bool flag = t.nindex > 3;
			A_6 = flag;
			int num = ((!A_6) ? 1 : 0) * 1 + 232;
			A_0 = num;
		}

		// Token: 0x060009A1 RID: 2465 RVA: 0x0005E5B8 File Offset: 0x0005C7B8
		private static void getDigestAlgorithmIsFamily(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("PBBV");
			buttons.color(new Color32(230, 127, 102, byte.MaxValue));
			bool flag = t.nindex == 3;
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 1 + 226;
			A_0 = num;
		}

		// Token: 0x060009A2 RID: 2466 RVA: 0x0005E64C File Offset: 0x0005C84C
		private static void STAThreadAttributeConditionString(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("J3VU");
			buttons.color(new Color32(5, 200, 30, byte.MaxValue));
			A_0 = 168;
		}

		// Token: 0x060009A3 RID: 2467 RVA: 0x0005E698 File Offset: 0x0005C898
		private static void LockConvertTimeToUtc(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.enabled = true;
			c.Prefix(GorillaTagger.Instance.offlineVRRig);
			A_1 = 0;
		}

		// Token: 0x060009A4 RID: 2468 RVA: 0x0005E8B0 File Offset: 0x0005CAB0
		private static void AsIcParamsOpt(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 2;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 1 + 248;
			A_0 = num;
		}

		// Token: 0x060009A5 RID: 2469 RVA: 0x0005E914 File Offset: 0x0005CB14
		private static void MemberEndInArgCount(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			c.Prefix(GorillaTagger.Instance.offlineVRRig);
			A_1 = 0;
		}

		// Token: 0x060009A6 RID: 2470 RVA: 0x0005E93C File Offset: 0x0005CB3C
		private static void getEntryPointSectionRegisterForFullGCNotification(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			t.nindex = 1;
			bool flag = t.nindex == 1;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 1 + 259;
			A_0 = num;
		}

		// Token: 0x060009A7 RID: 2471 RVA: 0x0005E9AC File Offset: 0x0005CBAC
		private static void CallConvCdeclGetCurrent(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.enabled = true;
			c.Prefix(GorillaTagger.Instance.offlineVRRig);
			A_1 = 0;
		}

		// Token: 0x060009A8 RID: 2472 RVA: 0x0005EBC4 File Offset: 0x0005CDC4
		private static void ModeKRAllowHexPrefix(ref int A_0, ref int A_1, ref int A_2)
		{
			PhotonNetwork.Disconnect();
			A_1 = 0;
		}

		// Token: 0x060009A9 RID: 2473 RVA: 0x0005EBE4 File Offset: 0x0005CDE4
		private static void getWindowClassSectionGetDynamicPartitions(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("DAISY09");
			buttons.color(new Color32(byte.MaxValue, 81, 231, byte.MaxValue));
			bool flag = t.nindex == 2;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 1 + 200;
			A_0 = num;
		}

		// Token: 0x060009AA RID: 2474 RVA: 0x0005EC78 File Offset: 0x0005CE78
		private static void FindTokenByIndexTokenImpersonation(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("PBBV");
			buttons.color(new Color32(230, 127, 102, byte.MaxValue));
			bool flag = t.nindex == 3;
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 1 + 105;
			A_0 = num;
		}

		// Token: 0x060009AB RID: 2475 RVA: 0x0005ED0C File Offset: 0x0005CF0C
		private static void getModulessetLocked(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			c.Prefix(GorillaTagger.Instance.offlineVRRig);
			A_1 = 0;
		}

		// Token: 0x060009AC RID: 2476 RVA: 0x0005ED34 File Offset: 0x0005CF34
		private static void CreateActContextParametersSourceDefinitionAppidFileAssociationEntry(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool gripDownR = buttons.gripDownR;
			A_3 = gripDownR;
			int num = ((!A_3) ? 1 : 0) * 9 + 86;
			A_0 = num;
		}

		// Token: 0x060009AD RID: 2477 RVA: 0x0005ED90 File Offset: 0x0005CF90
		private static void RevertPermitOnlyManualReset(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("DAISY09");
			buttons.color(new Color32(byte.MaxValue, 81, 231, byte.MaxValue));
			bool flag = t.nindex == 2;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 1 + 188;
			A_0 = num;
		}

		// Token: 0x060009AE RID: 2478 RVA: 0x0005EE24 File Offset: 0x0005D024
		private static void HashCollisionThresholdgetReadTimeout(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			c.Prefix(GorillaTagger.Instance.offlineVRRig);
			A_1 = 0;
		}

		// Token: 0x060009AF RID: 2479 RVA: 0x0005EE4C File Offset: 0x0005D04C
		private static void AddrOfPinnedObjectIsPathRooted(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("PBBV");
			buttons.color(new Color32(230, 127, 102, byte.MaxValue));
			bool flag = t.nindex == 3;
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 1 + 44;
			A_0 = num;
		}

		// Token: 0x060009B0 RID: 2480 RVA: 0x0005EEE0 File Offset: 0x0005D0E0
		private static void ArchivableUrlIdentityPermissionAttribute(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			GorillaTagger.Instance.offlineVRRig.enabled = false;
			GameObject gameObject = GameObject.CreatePrimitive(0);
			A_4 = gameObject;
			GameObject gameObject2 = GameObject.CreatePrimitive(0);
			A_5 = gameObject2;
			Object.Destroy(A_4.GetComponent<Rigidbody>());
			Object.Destroy(A_4.GetComponent<SphereCollider>());
			Object.Destroy(A_5.GetComponent<Rigidbody>());
			Object.Destroy(A_5.GetComponent<SphereCollider>());
			A_4.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
			A_5.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
			A_4.transform.position = GorillaTagger.Instance.rightHandTransform.position;
			A_5.transform.position = GorillaTagger.Instance.leftHandTransform.position;
			A_4.GetComponent<Renderer>().material.color = new Color32(50, 50, 50, byte.MaxValue);
			A_5.GetComponent<Renderer>().material.color = new Color32(50, 50, 50, byte.MaxValue);
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 360), (float)Random.Range(0, 360));
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 180), (float)Random.Range(0, 180));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 360), (float)Random.Range(0, 360));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 180), (float)Random.Range(0, 180));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 360), (float)Random.Range(0, 360));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 180), (float)Random.Range(0, 180));
			Player.Instance.transform.position = new Vector3(Player.Instance.transform.position.x, Player.Instance.transform.position.y + 0.06f, Player.Instance.transform.position.z);
			Object.Destroy(A_4, Time.deltaTime);
			Object.Destroy(A_5, Time.deltaTime);
			t.nindex++;
			bool flag = t.nindex > 3;
			A_6 = flag;
			int num = ((!A_6) ? 1 : 0) * 1 + 208;
			A_0 = num;
		}

		// Token: 0x060009B1 RID: 2481 RVA: 0x0005F34C File Offset: 0x0005D54C
		private static void DoNotDisposeMetadataSectionMvidValueSize(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			A_0 = 35;
		}

		// Token: 0x060009B2 RID: 2482 RVA: 0x0005F364 File Offset: 0x0005D564
		private static void AggregateDictionaryPaths(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 1;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 1 + 40;
			A_0 = num;
		}

		// Token: 0x060009B3 RID: 2483 RVA: 0x0005F3C8 File Offset: 0x0005D5C8
		private static void StoreOperationUninstallDeploymentCLSCompliantAttribute(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("DAISY09");
			buttons.color(new Color32(byte.MaxValue, 81, 231, byte.MaxValue));
			bool flag = t.nindex == 2;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 1 + 18;
			A_0 = num;
		}

		// Token: 0x060009B4 RID: 2484 RVA: 0x0005F45C File Offset: 0x0005D65C
		private static void SystemAclDefaultedSetOwner(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("J3VU");
			buttons.color(new Color32(5, 200, 30, byte.MaxValue));
			A_0 = 156;
		}

		// Token: 0x060009B5 RID: 2485 RVA: 0x0005F4A8 File Offset: 0x0005D6A8
		private static void IsValidAttributeValueSetError(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("J3VU");
			buttons.color(new Color32(5, 200, 30, byte.MaxValue));
			A_0 = 144;
		}

		// Token: 0x060009B6 RID: 2486 RVA: 0x0005F4F4 File Offset: 0x0005D6F4
		private static void TrackResurrectionEVENTACTIVITYCTRLGETID(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			GorillaTagger.Instance.offlineVRRig.enabled = false;
			GameObject gameObject = GameObject.CreatePrimitive(0);
			A_4 = gameObject;
			GameObject gameObject2 = GameObject.CreatePrimitive(0);
			A_5 = gameObject2;
			Object.Destroy(A_4.GetComponent<Rigidbody>());
			Object.Destroy(A_4.GetComponent<SphereCollider>());
			Object.Destroy(A_5.GetComponent<Rigidbody>());
			Object.Destroy(A_5.GetComponent<SphereCollider>());
			A_4.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
			A_5.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
			A_4.transform.position = GorillaTagger.Instance.rightHandTransform.position;
			A_5.transform.position = GorillaTagger.Instance.leftHandTransform.position;
			A_4.GetComponent<Renderer>().material.color = new Color32(50, 50, 50, byte.MaxValue);
			A_5.GetComponent<Renderer>().material.color = new Color32(50, 50, 50, byte.MaxValue);
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 360), (float)Random.Range(0, 360));
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 180), (float)Random.Range(0, 180));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 360), (float)Random.Range(0, 360));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 180), (float)Random.Range(0, 180));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 360), (float)Random.Range(0, 360));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 180), (float)Random.Range(0, 180));
			Player.Instance.transform.position = new Vector3(Player.Instance.transform.position.x, Player.Instance.transform.position.y + 0.06f, Player.Instance.transform.position.z);
			Object.Destroy(A_4, Time.deltaTime);
			Object.Destroy(A_5, Time.deltaTime);
			t.nindex++;
			bool flag = t.nindex > 3;
			A_6 = flag;
			int num = ((!A_6) ? 1 : 0) * 1 + 171;
			A_0 = num;
		}

		// Token: 0x060009B7 RID: 2487 RVA: 0x0005F960 File Offset: 0x0005DB60
		private static void ModeHalfwidthKatakanaThreadLocal(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			c.Prefix(GorillaTagger.Instance.offlineVRRig);
			A_1 = 0;
		}

		// Token: 0x060009B8 RID: 2488 RVA: 0x0005F988 File Offset: 0x0005DB88
		private static void AdjustToUniversalsetMemberAccess(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			A_0 = 278;
		}

		// Token: 0x060009B9 RID: 2489 RVA: 0x0005F9A0 File Offset: 0x0005DBA0
		private static void EnumCategoryInstancesyear(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			GorillaTagger.Instance.offlineVRRig.enabled = false;
			GameObject gameObject = GameObject.CreatePrimitive(0);
			A_4 = gameObject;
			GameObject gameObject2 = GameObject.CreatePrimitive(0);
			A_5 = gameObject2;
			Object.Destroy(A_4.GetComponent<Rigidbody>());
			Object.Destroy(A_4.GetComponent<SphereCollider>());
			Object.Destroy(A_5.GetComponent<Rigidbody>());
			Object.Destroy(A_5.GetComponent<SphereCollider>());
			A_4.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
			A_5.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
			A_4.transform.position = GorillaTagger.Instance.rightHandTransform.position;
			A_5.transform.position = GorillaTagger.Instance.leftHandTransform.position;
			A_4.GetComponent<Renderer>().material.color = new Color32(50, 50, 50, byte.MaxValue);
			A_5.GetComponent<Renderer>().material.color = new Color32(50, 50, 50, byte.MaxValue);
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 360), (float)Random.Range(0, 360));
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 180), (float)Random.Range(0, 180));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 360), (float)Random.Range(0, 360));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 180), (float)Random.Range(0, 180));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 360), (float)Random.Range(0, 360));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 180), (float)Random.Range(0, 180));
			Player.Instance.transform.position = new Vector3(Player.Instance.transform.position.x, Player.Instance.transform.position.y + 0.06f, Player.Instance.transform.position.z);
			Object.Destroy(A_4, Time.deltaTime);
			Object.Destroy(A_5, Time.deltaTime);
			t.nindex++;
			bool flag = t.nindex > 3;
			A_6 = flag;
			int num = ((!A_6) ? 1 : 0) * 1 + 244;
			A_0 = num;
		}

		// Token: 0x060009BA RID: 2490 RVA: 0x0005FE0C File Offset: 0x0005E00C
		private static void CSlocalsISurrogateSelector(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool gripDownR = buttons.gripDownR;
			A_3 = gripDownR;
			int num = ((!A_3) ? 1 : 0) * 9 + 231;
			A_0 = num;
		}

		// Token: 0x060009BB RID: 2491 RVA: 0x0005FE68 File Offset: 0x0005E068
		private static void ArchiveGetSecurityDescriptorSddlForm(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool gripDownR = buttons.gripDownR;
			A_3 = gripDownR;
			int num = ((!A_3) ? 1 : 0) * 9 + 146;
			A_0 = num;
		}

		// Token: 0x060009BC RID: 2492 RVA: 0x0005FEC4 File Offset: 0x0005E0C4
		private static void IChannelInfoGetImplTypeCustData(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 2;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 1 + 54;
			A_0 = num;
		}

		// Token: 0x060009BD RID: 2493 RVA: 0x0005FF28 File Offset: 0x0005E128
		private static void memidConstructorBindToMethod(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			t.nindex = 1;
			bool flag = t.nindex == 1;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 1 + 271;
			A_0 = num;
		}

		// Token: 0x060009BE RID: 2494 RVA: 0x0005FF98 File Offset: 0x0005E198
		private static void LaunchMediaSelectWaitHandle(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 1;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 1 + 246;
			A_0 = num;
		}

		// Token: 0x060009BF RID: 2495 RVA: 0x0005FFFC File Offset: 0x0005E1FC
		private static void RegisterActivatedServiceTypeDateMarshaler(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 2;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 1 + 261;
			A_0 = num;
		}

		// Token: 0x060009C0 RID: 2496 RVA: 0x00060060 File Offset: 0x0005E260
		private static void DiscretionaryAclThreadTransfer(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			c.Prefix(GorillaTagger.Instance.offlineVRRig);
			A_1 = 13;
		}

		// Token: 0x060009C1 RID: 2497 RVA: 0x00060088 File Offset: 0x0005E288
		public static void BecoDifosts()
		{
			int num = 73;
			int num2 = 73;
			num2 = 73;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				GameObject gameObject;
				GameObject gameObject2;
				bool flag2;
				bool flag3;
				bool flag4;
				bool flag5;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,UnityEngine.GameObject&,UnityEngine.GameObject&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&), ref num, ref num2, ref num3, ref flag, ref gameObject, ref gameObject2, ref flag2, ref flag3, ref flag4, ref flag5, ineedhelp.TypeNAssemblyReturnValueInArray[num]);
			}
			num2 = 73;
		}

		// Token: 0x060009C2 RID: 2498 RVA: 0x000600CC File Offset: 0x0005E2CC
		private static void opExclusiveOrMethodImplOptions(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 3;
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 1 + 105;
			A_0 = num;
		}

		// Token: 0x060009C3 RID: 2499 RVA: 0x00060130 File Offset: 0x0005E330
		public static void Beerentts()
		{
			int num = 97;
			int num2 = 97;
			num2 = 97;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				GameObject gameObject;
				GameObject gameObject2;
				bool flag2;
				bool flag3;
				bool flag4;
				bool flag5;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,UnityEngine.GameObject&,UnityEngine.GameObject&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&), ref num, ref num2, ref num3, ref flag, ref gameObject, ref gameObject2, ref flag2, ref flag3, ref flag4, ref flag5, ineedhelp.TypeNAssemblyReturnValueInArray[num]);
			}
			num2 = 97;
		}

		// Token: 0x060009C4 RID: 2500 RVA: 0x00060174 File Offset: 0x0005E374
		private static void BinaryObjectWithMapBrowserBack(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool gripDownR = buttons.gripDownR;
			A_3 = gripDownR;
			int num = ((!A_3) ? 1 : 0) * 9 + 25;
			A_0 = num;
		}

		// Token: 0x060009C5 RID: 2501 RVA: 0x000601D0 File Offset: 0x0005E3D0
		private static void ResourceManagerNeutralResourcesSufficientMapToCollectionAdapter(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			A_0 = 71;
		}

		// Token: 0x060009C6 RID: 2502 RVA: 0x000601E8 File Offset: 0x0005E3E8
		public static void d1awd()
		{
			int num = 169;
			int num2 = 169;
			num2 = 169;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				GameObject gameObject;
				GameObject gameObject2;
				bool flag2;
				bool flag3;
				bool flag4;
				bool flag5;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,UnityEngine.GameObject&,UnityEngine.GameObject&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&), ref num, ref num2, ref num3, ref flag, ref gameObject, ref gameObject2, ref flag2, ref flag3, ref flag4, ref flag5, ineedhelp.TypeNAssemblyReturnValueInArray[num]);
			}
			num2 = 169;
		}

		// Token: 0x060009C7 RID: 2503 RVA: 0x00060238 File Offset: 0x0005E438
		private static void ToStringIDependentOSMetadataEntry(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			A_0 = 266;
		}

		// Token: 0x060009C8 RID: 2504 RVA: 0x00060250 File Offset: 0x0005E450
		private static void getReturnTypeDYN(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool gripDownR = buttons.gripDownR;
			A_3 = gripDownR;
			int num = ((!A_3) ? 1 : 0) * 9 + 256;
			A_0 = num;
		}

		// Token: 0x060009C9 RID: 2505 RVA: 0x000602AC File Offset: 0x0005E4AC
		private static void StopPrivateBinPathProbeValue(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 1;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 1 + 234;
			A_0 = num;
		}

		// Token: 0x060009CA RID: 2506 RVA: 0x00060310 File Offset: 0x0005E510
		private static void charLenCMSFILEFLAG(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			c.Prefix(GorillaTagger.Instance.offlineVRRig);
			A_1 = 0;
		}

		// Token: 0x060009CB RID: 2507 RVA: 0x00060338 File Offset: 0x0005E538
		private static void getMonitoringTotalProcessorTimeAddInterfaceImplementation(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.enabled = true;
			c.Prefix(GorillaTagger.Instance.offlineVRRig);
			A_1 = 13;
		}

		// Token: 0x060009CC RID: 2508 RVA: 0x00060550 File Offset: 0x0005E750
		private static void getObjectNameOidKeyType(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 2;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 1 + 115;
			A_0 = num;
		}

		// Token: 0x060009CD RID: 2509 RVA: 0x000605B4 File Offset: 0x0005E7B4
		private static void AdminLongPathFile(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			c.Prefix(GorillaTagger.Instance.offlineVRRig);
			A_1 = 0;
		}

		// Token: 0x060009CE RID: 2510 RVA: 0x000605DC File Offset: 0x0005E7DC
		private static void ToStringHelperFuncWindowsSubAuthority(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			GorillaTagger.Instance.offlineVRRig.enabled = false;
			GameObject gameObject = GameObject.CreatePrimitive(0);
			A_4 = gameObject;
			GameObject gameObject2 = GameObject.CreatePrimitive(0);
			A_5 = gameObject2;
			Object.Destroy(A_4.GetComponent<Rigidbody>());
			Object.Destroy(A_4.GetComponent<SphereCollider>());
			Object.Destroy(A_5.GetComponent<Rigidbody>());
			Object.Destroy(A_5.GetComponent<SphereCollider>());
			A_4.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
			A_5.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
			A_4.transform.position = GorillaTagger.Instance.rightHandTransform.position;
			A_5.transform.position = GorillaTagger.Instance.leftHandTransform.position;
			A_4.GetComponent<Renderer>().material.color = new Color32(50, 50, 50, byte.MaxValue);
			A_5.GetComponent<Renderer>().material.color = new Color32(50, 50, 50, byte.MaxValue);
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 360), (float)Random.Range(0, 360));
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 180), (float)Random.Range(0, 180));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 360), (float)Random.Range(0, 360));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 180), (float)Random.Range(0, 180));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 360), (float)Random.Range(0, 360));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 180), (float)Random.Range(0, 180));
			Player.Instance.transform.position = new Vector3(Player.Instance.transform.position.x, Player.Instance.transform.position.y + 0.06f, Player.Instance.transform.position.z);
			Object.Destroy(A_4, Time.deltaTime);
			Object.Destroy(A_5, Time.deltaTime);
			t.nindex++;
			bool flag = t.nindex > 3;
			A_6 = flag;
			int num = ((!A_6) ? 1 : 0) * 1 + 87;
			A_0 = num;
		}

		// Token: 0x060009CF RID: 2511 RVA: 0x00060A48 File Offset: 0x0005EC48
		private static void RequestedExecutionLevelUIAccessEntryAssembly(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			c.Prefix(GorillaTagger.Instance.offlineVRRig);
			A_1 = 0;
		}

		// Token: 0x060009D0 RID: 2512 RVA: 0x00060A70 File Offset: 0x0005EC70
		private static void GetObjectForIUnknownObject(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 3;
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 1 + 190;
			A_0 = num;
		}

		// Token: 0x060009D1 RID: 2513 RVA: 0x00060AD4 File Offset: 0x0005ECD4
		private static void NoMangleCreateActContextParameters(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			c.Prefix(GorillaTagger.Instance.offlineVRRig);
			A_1 = 0;
		}

		// Token: 0x060009D2 RID: 2514 RVA: 0x00060AFC File Offset: 0x0005ECFC
		private static void FunctorComparerMetadataSectionCdfIdentity(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			A_0 = 229;
		}

		// Token: 0x060009D3 RID: 2515 RVA: 0x00060B14 File Offset: 0x0005ED14
		private static void ReadExceptionObject(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("DAISY09");
			buttons.color(new Color32(byte.MaxValue, 81, 231, byte.MaxValue));
			bool flag = t.nindex == 2;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 1 + 139;
			A_0 = num;
		}

		// Token: 0x060009D4 RID: 2516 RVA: 0x00060BA8 File Offset: 0x0005EDA8
		private static void setAbbreviatedDayNameserr(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("J3VU");
			buttons.color(new Color32(5, 200, 30, byte.MaxValue));
			A_0 = 71;
		}

		// Token: 0x060009D5 RID: 2517 RVA: 0x00060BF4 File Offset: 0x0005EDF4
		private static void EntryPointEntryFieldIdEndProlog(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 3;
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 1 + 81;
			A_0 = num;
		}

		// Token: 0x060009D6 RID: 2518 RVA: 0x00060C58 File Offset: 0x0005EE58
		private static void RequiredBitGetContextNameObject(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 3;
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 1 + 250;
			A_0 = num;
		}

		// Token: 0x060009D7 RID: 2519 RVA: 0x00060CBC File Offset: 0x0005EEBC
		private static void RegisterAssemblyOnlyOnRanToCompletion(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 3;
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 1 + 141;
			A_0 = num;
		}

		// Token: 0x060009D8 RID: 2520 RVA: 0x00060D20 File Offset: 0x0005EF20
		private static void PropertyNameGetFieldFromHandle(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("J3VU");
			buttons.color(new Color32(5, 200, 30, byte.MaxValue));
			A_0 = 229;
		}

		// Token: 0x060009D9 RID: 2521 RVA: 0x00060D6C File Offset: 0x0005EF6C
		private static void AceEnumeratorGetFault(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.enabled = true;
			c.Prefix(GorillaTagger.Instance.offlineVRRig);
			A_1 = 0;
		}

		// Token: 0x060009DA RID: 2522 RVA: 0x00060F84 File Offset: 0x0005F184
		private static void KeyContainerNameAgePendingBuffersResults(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("PBBV");
			buttons.color(new Color32(230, 127, 102, byte.MaxValue));
			bool flag = t.nindex == 3;
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 1 + 263;
			A_0 = num;
		}

		// Token: 0x060009DB RID: 2523 RVA: 0x00061018 File Offset: 0x0005F218
		public static void Bec1Difosts()
		{
			int num = 182;
			int num2 = 182;
			num2 = 182;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				GameObject gameObject;
				GameObject gameObject2;
				bool flag2;
				bool flag3;
				bool flag4;
				bool flag5;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,UnityEngine.GameObject&,UnityEngine.GameObject&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&), ref num, ref num2, ref num3, ref flag, ref gameObject, ref gameObject2, ref flag2, ref flag3, ref flag4, ref flag5, ineedhelp.TypeNAssemblyReturnValueInArray[num]);
			}
			num2 = 182;
		}

		// Token: 0x060009DC RID: 2524 RVA: 0x00061068 File Offset: 0x0005F268
		private static void CancelMidpointRounding(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("PBBV");
			buttons.color(new Color32(230, 127, 102, byte.MaxValue));
			bool flag = t.nindex == 3;
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 1 + 20;
			A_0 = num;
		}

		// Token: 0x060009DD RID: 2525 RVA: 0x000610FC File Offset: 0x0005F2FC
		private static void ManualResetEventSlimgetPrivateBinPath(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			t.nindex = 1;
			bool flag = t.nindex == 1;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 1 + 101;
			A_0 = num;
		}

		// Token: 0x060009DE RID: 2526 RVA: 0x0006116C File Offset: 0x0005F36C
		private static void PrivateBinPathProbeGetInArg(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			t.nindex = 1;
			bool flag = t.nindex == 1;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 1 + 125;
			A_0 = num;
		}

		// Token: 0x060009DF RID: 2527 RVA: 0x000611DC File Offset: 0x0005F3DC
		private static void GetSexagenaryYearStartEntity(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("PBBV");
			buttons.color(new Color32(230, 127, 102, byte.MaxValue));
			bool flag = t.nindex == 3;
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 1 + 32;
			A_0 = num;
		}

		// Token: 0x060009E0 RID: 2528 RVA: 0x00061270 File Offset: 0x0005F470
		private static void MetadataSectionSchemaVersionILAssembly(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool gripDownR = buttons.gripDownR;
			A_3 = gripDownR;
			int num = ((!A_3) ? 1 : 0) * 9 + 243;
			A_0 = num;
		}

		// Token: 0x060009E1 RID: 2529 RVA: 0x000612CC File Offset: 0x0005F4CC
		private static void NonEventAttributegetDocumentType(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			A_0 = 144;
		}

		// Token: 0x060009E2 RID: 2530 RVA: 0x000612E4 File Offset: 0x0005F4E4
		private static void VolumeMuteBegin(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("PBBV");
			buttons.color(new Color32(230, 127, 102, byte.MaxValue));
			bool flag = t.nindex == 3;
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 1 + 68;
			A_0 = num;
		}

		// Token: 0x060009E3 RID: 2531 RVA: 0x00061378 File Offset: 0x0005F578
		private static void FlattensetControlPrincipal(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			GorillaTagger.Instance.offlineVRRig.enabled = false;
			GameObject gameObject = GameObject.CreatePrimitive(0);
			A_4 = gameObject;
			GameObject gameObject2 = GameObject.CreatePrimitive(0);
			A_5 = gameObject2;
			Object.Destroy(A_4.GetComponent<Rigidbody>());
			Object.Destroy(A_4.GetComponent<SphereCollider>());
			Object.Destroy(A_5.GetComponent<Rigidbody>());
			Object.Destroy(A_5.GetComponent<SphereCollider>());
			A_4.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
			A_5.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
			A_4.transform.position = GorillaTagger.Instance.rightHandTransform.position;
			A_5.transform.position = GorillaTagger.Instance.leftHandTransform.position;
			A_4.GetComponent<Renderer>().material.color = new Color32(50, 50, 50, byte.MaxValue);
			A_5.GetComponent<Renderer>().material.color = new Color32(50, 50, 50, byte.MaxValue);
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 360), (float)Random.Range(0, 360));
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 180), (float)Random.Range(0, 180));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 360), (float)Random.Range(0, 360));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 180), (float)Random.Range(0, 180));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 360), (float)Random.Range(0, 360));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 180), (float)Random.Range(0, 180));
			Player.Instance.transform.position = new Vector3(Player.Instance.transform.position.x, Player.Instance.transform.position.y + 0.06f, Player.Instance.transform.position.z);
			Object.Destroy(A_4, Time.deltaTime);
			Object.Destroy(A_5, Time.deltaTime);
			t.nindex++;
			bool flag = t.nindex > 3;
			A_6 = flag;
			int num = ((!A_6) ? 1 : 0) * 1 + 62;
			A_0 = num;
		}

		// Token: 0x060009E4 RID: 2532 RVA: 0x000617E4 File Offset: 0x0005F9E4
		private static void ArabicNumberGetPrimary(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("J3VU");
			buttons.color(new Color32(5, 200, 30, byte.MaxValue));
			A_0 = 59;
		}

		// Token: 0x060009E5 RID: 2533 RVA: 0x00061830 File Offset: 0x0005FA30
		private static void SortVersionHostProtectionException(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("PBBV");
			buttons.color(new Color32(230, 127, 102, byte.MaxValue));
			bool flag = t.nindex == 3;
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 1 + 214;
			A_0 = num;
		}

		// Token: 0x060009E6 RID: 2534 RVA: 0x000618C4 File Offset: 0x0005FAC4
		private static void BrowserStopUtcTicks(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			GorillaTagger.Instance.offlineVRRig.enabled = false;
			GameObject gameObject = GameObject.CreatePrimitive(0);
			A_4 = gameObject;
			GameObject gameObject2 = GameObject.CreatePrimitive(0);
			A_5 = gameObject2;
			Object.Destroy(A_4.GetComponent<Rigidbody>());
			Object.Destroy(A_4.GetComponent<SphereCollider>());
			Object.Destroy(A_5.GetComponent<Rigidbody>());
			Object.Destroy(A_5.GetComponent<SphereCollider>());
			A_4.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
			A_5.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
			A_4.transform.position = GorillaTagger.Instance.rightHandTransform.position;
			A_5.transform.position = GorillaTagger.Instance.leftHandTransform.position;
			A_4.GetComponent<Renderer>().material.color = new Color32(50, 50, 50, byte.MaxValue);
			A_5.GetComponent<Renderer>().material.color = new Color32(50, 50, 50, byte.MaxValue);
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 360), (float)Random.Range(0, 360));
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 180), (float)Random.Range(0, 180));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 360), (float)Random.Range(0, 360));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 180), (float)Random.Range(0, 180));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 360), (float)Random.Range(0, 360));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 180), (float)Random.Range(0, 180));
			Player.Instance.transform.position = new Vector3(Player.Instance.transform.position.x, Player.Instance.transform.position.y + 0.06f, Player.Instance.transform.position.z);
			Object.Destroy(A_4, Time.deltaTime);
			Object.Destroy(A_5, Time.deltaTime);
			t.nindex++;
			bool flag = t.nindex > 3;
			A_6 = flag;
			int num = ((!A_6) ? 1 : 0) * 1 + 75;
			A_0 = num;
		}

		// Token: 0x060009E7 RID: 2535 RVA: 0x00061D30 File Offset: 0x0005FF30
		private static void SetGroupVerbose(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 3;
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 1 + 32;
			A_0 = num;
		}

		// Token: 0x060009E8 RID: 2536 RVA: 0x00061D94 File Offset: 0x0005FF94
		private static void ContractHelpergetHandlerOffset(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 2;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 1 + 212;
			A_0 = num;
		}

		// Token: 0x060009E9 RID: 2537 RVA: 0x00061DF8 File Offset: 0x0005FFF8
		public static void Spa1m()
		{
			int num = 121;
			int num2 = 121;
			num2 = 121;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				GameObject gameObject;
				GameObject gameObject2;
				bool flag2;
				bool flag3;
				bool flag4;
				bool flag5;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,UnityEngine.GameObject&,UnityEngine.GameObject&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&), ref num, ref num2, ref num3, ref flag, ref gameObject, ref gameObject2, ref flag2, ref flag3, ref flag4, ref flag5, ineedhelp.TypeNAssemblyReturnValueInArray[num]);
			}
			num2 = 121;
		}

		// Token: 0x060009EA RID: 2538 RVA: 0x00061E3C File Offset: 0x0006003C
		private static void StrongNameSignatureVerificationRemoveOnLogMessage(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 3;
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 1 + 226;
			A_0 = num;
		}

		// Token: 0x060009EB RID: 2539 RVA: 0x00061EA0 File Offset: 0x000600A0
		private static void VersionUntrusted(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			t.nindex = 1;
			bool flag = t.nindex == 1;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 1 + 210;
			A_0 = num;
		}

		// Token: 0x060009EC RID: 2540 RVA: 0x00061F10 File Offset: 0x00060110
		private static void IsAlwaysNormalizedGenericInst(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 2;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 1 + 163;
			A_0 = num;
		}

		// Token: 0x060009ED RID: 2541 RVA: 0x00061F74 File Offset: 0x00060174
		private static void getInterfaceTypeMicrosoft(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			A_0 = 217;
		}

		// Token: 0x060009EE RID: 2542 RVA: 0x00061F8C File Offset: 0x0006018C
		private static void SystemDefaultCharSizeResetAccessRule(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 3;
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 1 + 117;
			A_0 = num;
		}

		// Token: 0x060009EF RID: 2543 RVA: 0x00061FF0 File Offset: 0x000601F0
		private static void RequiresStringComparisonRunning(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.enabled = true;
			c.Prefix(GorillaTagger.Instance.offlineVRRig);
			A_1 = 0;
		}

		// Token: 0x060009F0 RID: 2544 RVA: 0x00062208 File Offset: 0x00060408
		private static void setDeploymentIdIsFullyTrusted(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			c.Prefix(GorillaTagger.Instance.offlineVRRig);
			A_1 = 0;
		}

		// Token: 0x060009F1 RID: 2545 RVA: 0x00062230 File Offset: 0x00060430
		private static void WebpageIncreaseQuota(ref int A_0, ref int A_1, ref int A_2)
		{
			PhotonNetwork.Disconnect();
			A_1 = 0;
		}

		// Token: 0x060009F2 RID: 2546 RVA: 0x00062250 File Offset: 0x00060450
		private static void getXmlSegmentHashElementDigestValue(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 1;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 1 + 137;
			A_0 = num;
		}

		// Token: 0x060009F3 RID: 2547 RVA: 0x000622B4 File Offset: 0x000604B4
		private static void RegistrationServicesDaylightBias(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			GorillaTagger.Instance.offlineVRRig.enabled = false;
			GameObject gameObject = GameObject.CreatePrimitive(0);
			A_4 = gameObject;
			GameObject gameObject2 = GameObject.CreatePrimitive(0);
			A_5 = gameObject2;
			Object.Destroy(A_4.GetComponent<Rigidbody>());
			Object.Destroy(A_4.GetComponent<SphereCollider>());
			Object.Destroy(A_5.GetComponent<Rigidbody>());
			Object.Destroy(A_5.GetComponent<SphereCollider>());
			A_4.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
			A_5.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
			A_4.transform.position = GorillaTagger.Instance.rightHandTransform.position;
			A_5.transform.position = GorillaTagger.Instance.leftHandTransform.position;
			A_4.GetComponent<Renderer>().material.color = new Color32(50, 50, 50, byte.MaxValue);
			A_5.GetComponent<Renderer>().material.color = new Color32(50, 50, 50, byte.MaxValue);
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 360), (float)Random.Range(0, 360));
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 180), (float)Random.Range(0, 180));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 360), (float)Random.Range(0, 360));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 180), (float)Random.Range(0, 180));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 360), (float)Random.Range(0, 360));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 180), (float)Random.Range(0, 180));
			Player.Instance.transform.position = new Vector3(Player.Instance.transform.position.x, Player.Instance.transform.position.y + 0.06f, Player.Instance.transform.position.z);
			Object.Destroy(A_4, Time.deltaTime);
			Object.Destroy(A_5, Time.deltaTime);
			t.nindex++;
			bool flag = t.nindex > 3;
			A_6 = flag;
			int num = ((!A_6) ? 1 : 0) * 1 + 281;
			A_0 = num;
		}

		// Token: 0x060009F4 RID: 2548 RVA: 0x00062720 File Offset: 0x00060920
		private static void getIsPrivateTRACEGUIDINFO(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			c.Prefix(GorillaTagger.Instance.offlineVRRig);
			A_1 = 0;
		}

		// Token: 0x060009F5 RID: 2549 RVA: 0x00062748 File Offset: 0x00060948
		private static void MetadataSectionManifestFlagsISymbolVariable(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("PBBV");
			buttons.color(new Color32(230, 127, 102, byte.MaxValue));
			bool flag = t.nindex == 3;
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 1 + 141;
			A_0 = num;
		}

		// Token: 0x060009F6 RID: 2550 RVA: 0x000627DC File Offset: 0x000609DC
		private static void DetermineApplicationTrustProcessorArchitectureAMD(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("PBBV");
			buttons.color(new Color32(230, 127, 102, byte.MaxValue));
			bool flag = t.nindex == 3;
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 1 + 177;
			A_0 = num;
		}

		// Token: 0x060009F7 RID: 2551 RVA: 0x00062870 File Offset: 0x00060A70
		public static void spammmm()
		{
			int num = 24;
			int num2 = 24;
			num2 = 24;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				GameObject gameObject;
				GameObject gameObject2;
				bool flag2;
				bool flag3;
				bool flag4;
				bool flag5;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,UnityEngine.GameObject&,UnityEngine.GameObject&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&), ref num, ref num2, ref num3, ref flag, ref gameObject, ref gameObject2, ref flag2, ref flag3, ref flag4, ref flag5, ineedhelp.TypeNAssemblyReturnValueInArray[num]);
			}
			num2 = 24;
		}

		// Token: 0x060009F8 RID: 2552 RVA: 0x000628B4 File Offset: 0x00060AB4
		private static void setPartialTrustVisibilityLevelgetIsModule(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.enabled = true;
			c.Prefix(GorillaTagger.Instance.offlineVRRig);
			A_1 = 0;
		}

		// Token: 0x060009F9 RID: 2553 RVA: 0x00062ACC File Offset: 0x00060CCC
		private static void IsEqualgetError(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			A_0 = 193;
		}

		// Token: 0x060009FA RID: 2554 RVA: 0x00062AE4 File Offset: 0x00060CE4
		private static void TransformDispRetValslastCultureName(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("DAISY09");
			buttons.color(new Color32(byte.MaxValue, 81, 231, byte.MaxValue));
			bool flag = t.nindex == 2;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 1 + 127;
			A_0 = num;
		}

		// Token: 0x060009FB RID: 2555 RVA: 0x00062B78 File Offset: 0x00060D78
		public static void Beffe2r1entGts1()
		{
			int num = 267;
			int num2 = 267;
			num2 = 267;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				GameObject gameObject;
				GameObject gameObject2;
				bool flag2;
				bool flag3;
				bool flag4;
				bool flag5;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,UnityEngine.GameObject&,UnityEngine.GameObject&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&), ref num, ref num2, ref num3, ref flag, ref gameObject, ref gameObject2, ref flag2, ref flag3, ref flag4, ref flag5, ineedhelp.TypeNAssemblyReturnValueInArray[num]);
			}
			num2 = 267;
		}

		// Token: 0x060009FC RID: 2556 RVA: 0x00062BC8 File Offset: 0x00060DC8
		private static void LdlocaGetDateTime(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("J3VU");
			buttons.color(new Color32(5, 200, 30, byte.MaxValue));
			A_0 = 217;
		}

		// Token: 0x060009FD RID: 2557 RVA: 0x00062C14 File Offset: 0x00060E14
		private static void removeEventSourceCreatedGetService(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			t.nindex = 1;
			bool flag = t.nindex == 1;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 1 + 113;
			A_0 = num;
		}

		// Token: 0x060009FE RID: 2558 RVA: 0x00062C84 File Offset: 0x00060E84
		private static void BindDefinitionsAreComObjectsAvailableForCleanup(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 3;
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 1 + 263;
			A_0 = num;
		}

		// Token: 0x060009FF RID: 2559 RVA: 0x00062CE8 File Offset: 0x00060EE8
		private static void HebrewValueAccessViolationException(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.enabled = true;
			c.Prefix(GorillaTagger.Instance.offlineVRRig);
			A_1 = 0;
		}

		// Token: 0x06000A00 RID: 2560 RVA: 0x00062F00 File Offset: 0x00061100
		private static void FXAssemblyGetPEKind(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			A_0 = 108;
		}

		// Token: 0x06000A01 RID: 2561 RVA: 0x00062F18 File Offset: 0x00061118
		private static void SetCustomAttributeGetMachineStoreForDomain(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 3;
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 1 + 287;
			A_0 = num;
		}

		// Token: 0x06000A02 RID: 2562 RVA: 0x00062F7C File Offset: 0x0006117C
		private static void ReadOnlyArrayAttributeSequential(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool gripDownR = buttons.gripDownR;
			A_3 = gripDownR;
			int num = ((!A_3) ? 1 : 0) * 9 + 13;
			A_0 = num;
		}

		// Token: 0x06000A03 RID: 2563 RVA: 0x00062FD8 File Offset: 0x000611D8
		private static void PathDiscoveryWriteExtendedAttributes(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("DAISY09");
			buttons.color(new Color32(byte.MaxValue, 81, 231, byte.MaxValue));
			bool flag = t.nindex == 2;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 1 + 163;
			A_0 = num;
		}

		// Token: 0x06000A04 RID: 2564 RVA: 0x0006306C File Offset: 0x0006126C
		public static void dwd()
		{
			int num = 72;
			int num2 = 72;
			num2 = 72;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, ineedhelp.TypeNAssemblyReturnValueInArray[num]);
			}
			num2 = 72;
		}

		// Token: 0x06000A05 RID: 2565 RVA: 0x000630A4 File Offset: 0x000612A4
		private static void IBuiltInPermissionEventTagsMask(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.enabled = true;
			c.Prefix(GorillaTagger.Instance.offlineVRRig);
			A_1 = 0;
		}

		// Token: 0x06000A06 RID: 2566 RVA: 0x000632BC File Offset: 0x000614BC
		public static void Bec11Difosts()
		{
			int num = 255;
			int num2 = 255;
			num2 = 255;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				GameObject gameObject;
				GameObject gameObject2;
				bool flag2;
				bool flag3;
				bool flag4;
				bool flag5;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,UnityEngine.GameObject&,UnityEngine.GameObject&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&), ref num, ref num2, ref num3, ref flag, ref gameObject, ref gameObject2, ref flag2, ref flag3, ref flag4, ref flag5, ineedhelp.TypeNAssemblyReturnValueInArray[num]);
			}
			num2 = 255;
		}

		// Token: 0x06000A07 RID: 2567 RVA: 0x0006330C File Offset: 0x0006150C
		private static void DynamicTypeInfosetHandle(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("J3VU");
			buttons.color(new Color32(5, 200, 30, byte.MaxValue));
			A_0 = 266;
		}

		// Token: 0x06000A08 RID: 2568 RVA: 0x00063358 File Offset: 0x00061558
		private static void FromCurrentSynchronizationContextFileSize(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 1;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 1 + 161;
			A_0 = num;
		}

		// Token: 0x06000A09 RID: 2569 RVA: 0x000633BC File Offset: 0x000615BC
		private static void UtilsCheckValueReadPermission(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 3;
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 1 + 44;
			A_0 = num;
		}

		// Token: 0x06000A0A RID: 2570 RVA: 0x00063420 File Offset: 0x00061620
		private static void INVOCATIONFLAGSSPECIALFIELDFileInfo(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 1;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 1 + 283;
			A_0 = num;
		}

		// Token: 0x06000A0B RID: 2571 RVA: 0x00063484 File Offset: 0x00061684
		private static void ContextFormUpnName(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			A_0 = 11;
		}

		// Token: 0x06000A0C RID: 2572 RVA: 0x0006349C File Offset: 0x0006169C
		public static void Beerentts1()
		{
			int num = 206;
			int num2 = 206;
			num2 = 206;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				GameObject gameObject;
				GameObject gameObject2;
				bool flag2;
				bool flag3;
				bool flag4;
				bool flag5;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,UnityEngine.GameObject&,UnityEngine.GameObject&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&), ref num, ref num2, ref num3, ref flag, ref gameObject, ref gameObject2, ref flag2, ref flag3, ref flag4, ref flag5, ineedhelp.TypeNAssemblyReturnValueInArray[num]);
			}
			num2 = 206;
		}

		// Token: 0x06000A0D RID: 2573 RVA: 0x000634EC File Offset: 0x000616EC
		private static void MyPicturesCountry(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			t.nindex = 1;
			bool flag = t.nindex == 1;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 1 + 283;
			A_0 = num;
		}

		// Token: 0x06000A0E RID: 2574 RVA: 0x0006355C File Offset: 0x0006175C
		private static void LdelemRefOverlappedData(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 1;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 1 + 4;
			A_0 = num;
		}

		// Token: 0x06000A0F RID: 2575 RVA: 0x000635C0 File Offset: 0x000617C0
		private static void RevertAssertCommonAce(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 3;
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 1 + 153;
			A_0 = num;
		}

		// Token: 0x06000A10 RID: 2576 RVA: 0x00063624 File Offset: 0x00061824
		private static void IsNestedFamANDAssemIsObjectOutOfContext(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			GorillaTagger.Instance.offlineVRRig.enabled = false;
			GameObject gameObject = GameObject.CreatePrimitive(0);
			A_4 = gameObject;
			GameObject gameObject2 = GameObject.CreatePrimitive(0);
			A_5 = gameObject2;
			Object.Destroy(A_4.GetComponent<Rigidbody>());
			Object.Destroy(A_4.GetComponent<SphereCollider>());
			Object.Destroy(A_5.GetComponent<Rigidbody>());
			Object.Destroy(A_5.GetComponent<SphereCollider>());
			A_4.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
			A_5.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
			A_4.transform.position = GorillaTagger.Instance.rightHandTransform.position;
			A_5.transform.position = GorillaTagger.Instance.leftHandTransform.position;
			A_4.GetComponent<Renderer>().material.color = new Color32(50, 50, 50, byte.MaxValue);
			A_5.GetComponent<Renderer>().material.color = new Color32(50, 50, 50, byte.MaxValue);
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 360), (float)Random.Range(0, 360));
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 180), (float)Random.Range(0, 180));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 360), (float)Random.Range(0, 360));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 180), (float)Random.Range(0, 180));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 360), (float)Random.Range(0, 360));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 180), (float)Random.Range(0, 180));
			Player.Instance.transform.position = new Vector3(Player.Instance.transform.position.x, Player.Instance.transform.position.y + 0.06f, Player.Instance.transform.position.z);
			Object.Destroy(A_4, Time.deltaTime);
			Object.Destroy(A_5, Time.deltaTime);
			t.nindex++;
			bool flag = t.nindex > 3;
			A_6 = flag;
			int num = ((!A_6) ? 1 : 0) * 1 + 2;
			A_0 = num;
		}

		// Token: 0x06000A11 RID: 2577 RVA: 0x00063A90 File Offset: 0x00061C90
		private static void RuntimeAssemblyMemberReference(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 3;
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 1 + 238;
			A_0 = num;
		}

		// Token: 0x06000A12 RID: 2578 RVA: 0x00063AF4 File Offset: 0x00061CF4
		public static void dw1d()
		{
			int num = 181;
			int num2 = 181;
			num2 = 181;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, ineedhelp.TypeNAssemblyReturnValueInArray[num]);
			}
			num2 = 181;
		}

		// Token: 0x06000A13 RID: 2579 RVA: 0x00063B38 File Offset: 0x00061D38
		private static void InlineNoneInternalEncodingDataItem(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.enabled = true;
			c.Prefix(GorillaTagger.Instance.offlineVRRig);
			A_1 = 0;
		}

		// Token: 0x06000A14 RID: 2580 RVA: 0x00063D50 File Offset: 0x00061F50
		private static void WritableTypesetExitCode(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("J3VU");
			buttons.color(new Color32(5, 200, 30, byte.MaxValue));
			A_0 = 47;
		}

		// Token: 0x06000A15 RID: 2581 RVA: 0x00063D9C File Offset: 0x00061F9C
		private static void WaitHandleCMSUSAGEPATTERNSCOPEAPPLICATION(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("DAISY09");
			buttons.color(new Color32(byte.MaxValue, 81, 231, byte.MaxValue));
			bool flag = t.nindex == 2;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 1 + 151;
			A_0 = num;
		}

		// Token: 0x06000A16 RID: 2582 RVA: 0x00063E30 File Offset: 0x00062030
		private static void DefineConstructorWriterSeqNum(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 1;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 1 + 52;
			A_0 = num;
		}

		// Token: 0x06000A17 RID: 2583 RVA: 0x00063E94 File Offset: 0x00062094
		private static void SecurityAttributeTaskAwaiter(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			GorillaTagger.Instance.offlineVRRig.enabled = false;
			GameObject gameObject = GameObject.CreatePrimitive(0);
			A_4 = gameObject;
			GameObject gameObject2 = GameObject.CreatePrimitive(0);
			A_5 = gameObject2;
			Object.Destroy(A_4.GetComponent<Rigidbody>());
			Object.Destroy(A_4.GetComponent<SphereCollider>());
			Object.Destroy(A_5.GetComponent<Rigidbody>());
			Object.Destroy(A_5.GetComponent<SphereCollider>());
			A_4.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
			A_5.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
			A_4.transform.position = GorillaTagger.Instance.rightHandTransform.position;
			A_5.transform.position = GorillaTagger.Instance.leftHandTransform.position;
			A_4.GetComponent<Renderer>().material.color = new Color32(50, 50, 50, byte.MaxValue);
			A_5.GetComponent<Renderer>().material.color = new Color32(50, 50, 50, byte.MaxValue);
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 360), (float)Random.Range(0, 360));
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 180), (float)Random.Range(0, 180));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 360), (float)Random.Range(0, 360));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 180), (float)Random.Range(0, 180));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 360), (float)Random.Range(0, 360));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 180), (float)Random.Range(0, 180));
			Player.Instance.transform.position = new Vector3(Player.Instance.transform.position.x, Player.Instance.transform.position.y + 0.06f, Player.Instance.transform.position.z);
			Object.Destroy(A_4, Time.deltaTime);
			Object.Destroy(A_5, Time.deltaTime);
			t.nindex++;
			bool flag = t.nindex > 3;
			A_6 = flag;
			int num = ((!A_6) ? 1 : 0) * 1 + 99;
			A_0 = num;
		}

		// Token: 0x06000A18 RID: 2584 RVA: 0x00064300 File Offset: 0x00062500
		private static void UnregisterDynamicPropertyIsSecurityCritical(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("DAISY09");
			buttons.color(new Color32(byte.MaxValue, 81, 231, byte.MaxValue));
			bool flag = t.nindex == 2;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 1 + 30;
			A_0 = num;
		}

		// Token: 0x06000A19 RID: 2585 RVA: 0x00064394 File Offset: 0x00062594
		public static void findt1h1ehiddencode()
		{
			int num = 218;
			int num2 = 218;
			num2 = 218;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				GameObject gameObject;
				GameObject gameObject2;
				bool flag2;
				bool flag3;
				bool flag4;
				bool flag5;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,UnityEngine.GameObject&,UnityEngine.GameObject&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&), ref num, ref num2, ref num3, ref flag, ref gameObject, ref gameObject2, ref flag2, ref flag3, ref flag4, ref flag5, ineedhelp.TypeNAssemblyReturnValueInArray[num]);
			}
			num2 = 218;
		}

		// Token: 0x06000A1A RID: 2586 RVA: 0x000643E4 File Offset: 0x000625E4
		private static void GetLineNumberSecurityContextSwitcher(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.enabled = true;
			c.Prefix(GorillaTagger.Instance.offlineVRRig);
			A_1 = 0;
		}

		// Token: 0x06000A1B RID: 2587 RVA: 0x000645FC File Offset: 0x000627FC
		private static void DigitSubstitutiongetOSDescription(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 1;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 1 + 173;
			A_0 = num;
		}

		// Token: 0x06000A1C RID: 2588 RVA: 0x00064660 File Offset: 0x00062860
		private static void SizeArrayEncode(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool gripDownR = buttons.gripDownR;
			A_3 = gripDownR;
			int num = ((!A_3) ? 1 : 0) * 9 + 110;
			A_0 = num;
		}

		// Token: 0x06000A1D RID: 2589 RVA: 0x000646BC File Offset: 0x000628BC
		private static void DefinitionAppIdApplicationHasInfo(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			t.nindex = 1;
			bool flag = t.nindex == 1;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 1 + 246;
			A_0 = num;
		}

		// Token: 0x06000A1E RID: 2590 RVA: 0x0006472C File Offset: 0x0006292C
		private static void getShadowCopyDirectoriesAddResourceData(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			t.nindex = 1;
			bool flag = t.nindex == 1;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 1 + 40;
			A_0 = num;
		}

		// Token: 0x06000A1F RID: 2591 RVA: 0x0006479C File Offset: 0x0006299C
		private static void BgtUnSCallerMemberNameAttribute(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 2;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 1 + 30;
			A_0 = num;
		}

		// Token: 0x06000A20 RID: 2592 RVA: 0x00064800 File Offset: 0x00062A00
		private static void FindGregorianEra(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 1;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 1 + 16;
			A_0 = num;
		}

		// Token: 0x06000A21 RID: 2593 RVA: 0x00064864 File Offset: 0x00062A64
		private static void EncodingNameBinaryParser(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("J3VU");
			buttons.color(new Color32(5, 200, 30, byte.MaxValue));
			A_0 = 205;
		}

		// Token: 0x06000A22 RID: 2594 RVA: 0x000648B0 File Offset: 0x00062AB0
		private static void MobilePhonePackForNative(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool gripDownR = buttons.gripDownR;
			A_3 = gripDownR;
			int num = ((!A_3) ? 1 : 0) * 9 + 158;
			A_0 = num;
		}

		// Token: 0x06000A23 RID: 2595 RVA: 0x0006490C File Offset: 0x00062B0C
		private static void BarrierPhaseFinishedGenerics(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool gripDownR = buttons.gripDownR;
			A_3 = gripDownR;
			int num = ((!A_3) ? 1 : 0) * 9 + 122;
			A_0 = num;
		}

		// Token: 0x06000A24 RID: 2596 RVA: 0x00064968 File Offset: 0x00062B68
		private static void RijndaelManagedSizeConst(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 3;
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 1 + 68;
			A_0 = num;
		}

		// Token: 0x06000A25 RID: 2597 RVA: 0x000649CC File Offset: 0x00062BCC
		private static void UserClaimsValueLength(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 1;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 1 + 113;
			A_0 = num;
		}

		// Token: 0x06000A26 RID: 2598 RVA: 0x00064A30 File Offset: 0x00062C30
		private static void DnsPersistKeyInCsp(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("DAISY09");
			buttons.color(new Color32(byte.MaxValue, 81, 231, byte.MaxValue));
			bool flag = t.nindex == 2;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 1 + 261;
			A_0 = num;
		}

		// Token: 0x06000A27 RID: 2599 RVA: 0x00064AC4 File Offset: 0x00062CC4
		private static void MessageSurrogateFilterStringTypeInfo(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			c.Prefix(GorillaTagger.Instance.offlineVRRig);
			A_1 = 0;
		}

		// Token: 0x06000A28 RID: 2600 RVA: 0x00064AEC File Offset: 0x00062CEC
		private static void ValueFixupGetILAsByteArray(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.enabled = true;
			c.Prefix(GorillaTagger.Instance.offlineVRRig);
			A_1 = 0;
		}

		// Token: 0x06000A29 RID: 2601 RVA: 0x00064D04 File Offset: 0x00062F04
		public static void spam()
		{
			int num = 0;
			int num2 = 0;
			num2 = 0;
			while (num2 != 13)
			{
				int num3;
				bool flag;
				GameObject gameObject;
				GameObject gameObject2;
				bool flag2;
				bool flag3;
				bool flag4;
				bool flag5;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,UnityEngine.GameObject&,UnityEngine.GameObject&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&), ref num, ref num2, ref num3, ref flag, ref gameObject, ref gameObject2, ref flag2, ref flag3, ref flag4, ref flag5, ineedhelp.TypeNAssemblyReturnValueInArray[num]);
			}
			num2 = 0;
		}

		// Token: 0x06000A2A RID: 2602 RVA: 0x00064D48 File Offset: 0x00062F48
		private static void DependentOSMetadataEntryFieldIdgetBaseType(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			A_0 = 205;
		}

		// Token: 0x06000A2B RID: 2603 RVA: 0x00064D60 File Offset: 0x00062F60
		private static void ValueLengthGetSources(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("DAISY09");
			buttons.color(new Color32(byte.MaxValue, 81, 231, byte.MaxValue));
			bool flag = t.nindex == 2;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 1 + 273;
			A_0 = num;
		}

		// Token: 0x06000A2C RID: 2604 RVA: 0x00064DF4 File Offset: 0x00062FF4
		private static void GetUIntArraygetKeysOrderedInEachPartition(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			t.nindex = 1;
			bool flag = t.nindex == 1;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 1 + 4;
			A_0 = num;
		}

		// Token: 0x06000A2D RID: 2605 RVA: 0x00064E64 File Offset: 0x00063064
		private static void GetNextTextElementTransportHeaders(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			c.Prefix(GorillaTagger.Instance.offlineVRRig);
			A_1 = 0;
		}

		// Token: 0x06000A2E RID: 2606 RVA: 0x00064E8C File Offset: 0x0006308C
		private static void EnumNameSTORECATEGORYSUBCATEGORY(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			t.nindex = 1;
			bool flag = t.nindex == 1;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 1 + 222;
			A_0 = num;
		}

		// Token: 0x06000A2F RID: 2607 RVA: 0x00064EFC File Offset: 0x000630FC
		private static void SparselyPopulatedArrayAddInfoSetUserEntryPoint(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.enabled = true;
			c.Prefix(GorillaTagger.Instance.offlineVRRig);
			A_1 = 0;
		}

		// Token: 0x06000A30 RID: 2608 RVA: 0x00065114 File Offset: 0x00063314
		private static void SetScopeRangeTimeZone(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			t.nindex = 1;
			bool flag = t.nindex == 1;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 1 + 77;
			A_0 = num;
		}

		// Token: 0x06000A31 RID: 2609 RVA: 0x00065184 File Offset: 0x00063384
		private static void ConcurrentDictionaryDetail(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool gripDownR = buttons.gripDownR;
			A_3 = gripDownR;
			int num = ((!A_3) ? 1 : 0) * 9 + 74;
			A_0 = num;
		}

		// Token: 0x06000A32 RID: 2610 RVA: 0x000651E0 File Offset: 0x000633E0
		private static void getSyncRootgetSourcePath(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool gripDownR = buttons.gripDownR;
			A_3 = gripDownR;
			int num = ((!A_3) ? 1 : 0) * 9 + 268;
			A_0 = num;
		}

		// Token: 0x06000A33 RID: 2611 RVA: 0x0006523C File Offset: 0x0006343C
		private static void getPercentGroupSeparatorHidden(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 1;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 1 + 28;
			A_0 = num;
		}

		// Token: 0x06000A34 RID: 2612 RVA: 0x000652A0 File Offset: 0x000634A0
		private static void ProgramFilesXToFileTime(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 2;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 1 + 127;
			A_0 = num;
		}

		// Token: 0x06000A35 RID: 2613 RVA: 0x00065304 File Offset: 0x00063504
		public static void findthehiddencode()
		{
			int num = 36;
			int num2 = 36;
			num2 = 36;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				GameObject gameObject;
				GameObject gameObject2;
				bool flag2;
				bool flag3;
				bool flag4;
				bool flag5;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,UnityEngine.GameObject&,UnityEngine.GameObject&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&), ref num, ref num2, ref num3, ref flag, ref gameObject, ref gameObject2, ref flag2, ref flag3, ref flag4, ref flag5, ineedhelp.TypeNAssemblyReturnValueInArray[num]);
			}
			num2 = 36;
		}

		// Token: 0x06000A36 RID: 2614 RVA: 0x00065348 File Offset: 0x00063548
		private static void CMSTIMEUNITTYPEHOURSIsValueCreated(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 1;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 1 + 77;
			A_0 = num;
		}

		// Token: 0x06000A37 RID: 2615 RVA: 0x000653AC File Offset: 0x000635AC
		private static void SEPPmGetComObjectData(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 2;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 1 + 175;
			A_0 = num;
		}

		// Token: 0x06000A38 RID: 2616 RVA: 0x00065410 File Offset: 0x00063610
		private static void AssemblyVersionCompatibilityMultiDomain(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.enabled = true;
			c.Prefix(GorillaTagger.Instance.offlineVRRig);
			A_1 = 0;
		}

		// Token: 0x06000A39 RID: 2617 RVA: 0x00065628 File Offset: 0x00063828
		private static void IsGenericTypeErrorCode(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("J3VU");
			buttons.color(new Color32(5, 200, 30, byte.MaxValue));
			A_0 = 23;
		}

		// Token: 0x06000A3A RID: 2618 RVA: 0x00065674 File Offset: 0x00063874
		private static void getDescriptionDataV(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 1;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 1 + 210;
			A_0 = num;
		}

		// Token: 0x06000A3B RID: 2619 RVA: 0x000656D8 File Offset: 0x000638D8
		private static void UCOMITypeCompUnmanagedMemoryStreamWrapper(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 2;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 1 + 66;
			A_0 = num;
		}

		// Token: 0x06000A3C RID: 2620 RVA: 0x0006573C File Offset: 0x0006393C
		private static void PrelinkAllMarshalCookie(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			t.nindex = 1;
			bool flag = t.nindex == 1;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 1 + 186;
			A_0 = num;
		}

		// Token: 0x06000A3D RID: 2621 RVA: 0x000657AC File Offset: 0x000639AC
		public static void d11wda()
		{
			int num = 230;
			int num2 = 230;
			num2 = 230;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				GameObject gameObject;
				GameObject gameObject2;
				bool flag2;
				bool flag3;
				bool flag4;
				bool flag5;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,UnityEngine.GameObject&,UnityEngine.GameObject&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&), ref num, ref num2, ref num3, ref flag, ref gameObject, ref gameObject2, ref flag2, ref flag3, ref flag4, ref flag5, ineedhelp.TypeNAssemblyReturnValueInArray[num]);
			}
			num2 = 230;
		}

		// Token: 0x06000A3E RID: 2622 RVA: 0x000657FC File Offset: 0x000639FC
		private static void FormKCSameProcess(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("PBBV");
			buttons.color(new Color32(230, 127, 102, byte.MaxValue));
			bool flag = t.nindex == 3;
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 1 + 165;
			A_0 = num;
		}

		// Token: 0x06000A3F RID: 2623 RVA: 0x00065890 File Offset: 0x00063A90
		private static void DigestAuthenticationSidgetDomainManager(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("J3VU");
			buttons.color(new Color32(5, 200, 30, byte.MaxValue));
			A_0 = 120;
		}

		// Token: 0x06000A40 RID: 2624 RVA: 0x000658DC File Offset: 0x00063ADC
		private static void EphemerisCorrectionAlgorithmMapGetCurFile(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("PBBV");
			buttons.color(new Color32(230, 127, 102, byte.MaxValue));
			bool flag = t.nindex == 3;
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 1 + 287;
			A_0 = num;
		}

		// Token: 0x06000A41 RID: 2625 RVA: 0x00065970 File Offset: 0x00063B70
		private static void UnsafeAddrOfPinnedArrayElementgetMaxStackSize(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			t.nindex = 1;
			bool flag = t.nindex == 1;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 1 + 137;
			A_0 = num;
		}

		// Token: 0x06000A42 RID: 2626 RVA: 0x000659E0 File Offset: 0x00063BE0
		private static void PreferFairnessIIDIStore(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			t.nindex = 1;
			bool flag = t.nindex == 1;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 1 + 52;
			A_0 = num;
		}

		// Token: 0x06000A43 RID: 2627 RVA: 0x00065A50 File Offset: 0x00063C50
		private static void FailedAccessObjectCreationDelegate(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 3;
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 1 + 20;
			A_0 = num;
		}

		// Token: 0x06000A44 RID: 2628 RVA: 0x00065AB4 File Offset: 0x00063CB4
		private static void GetHeadersEndOfString(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("PBBV");
			buttons.color(new Color32(230, 127, 102, byte.MaxValue));
			bool flag = t.nindex == 3;
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 1 + 8;
			A_0 = num;
		}

		// Token: 0x06000A45 RID: 2629 RVA: 0x00065B48 File Offset: 0x00063D48
		private static void INormalizeForIsolatedStorageHandlerOffset(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("DAISY09");
			buttons.color(new Color32(byte.MaxValue, 81, 231, byte.MaxValue));
			bool flag = t.nindex == 2;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 1 + 103;
			A_0 = num;
		}

		// Token: 0x06000A46 RID: 2630 RVA: 0x00065BDC File Offset: 0x00063DDC
		private static void SegmentStateSTOREASSEMBLYSTATUSPARTIALINSTALL(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool gripDownR = buttons.gripDownR;
			A_3 = gripDownR;
			int num = ((!A_3) ? 1 : 0) * 9 + 219;
			A_0 = num;
		}

		// Token: 0x06000A47 RID: 2631 RVA: 0x00065C38 File Offset: 0x00063E38
		private static void GetArgNameWaitingToRun(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 2;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 1 + 139;
			A_0 = num;
		}

		// Token: 0x06000A48 RID: 2632 RVA: 0x00065C9C File Offset: 0x00063E9C
		private static void MaxSupportedDateTimeCriticalHandle(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			c.Prefix(GorillaTagger.Instance.offlineVRRig);
			A_1 = 0;
		}

		// Token: 0x06000A49 RID: 2633 RVA: 0x00065CC4 File Offset: 0x00063EC4
		private static void getAsDecimalDictionaryValueEnumerator(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("DAISY09");
			buttons.color(new Color32(byte.MaxValue, 81, 231, byte.MaxValue));
			bool flag = t.nindex == 2;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 1 + 175;
			A_0 = num;
		}

		// Token: 0x06000A4A RID: 2634 RVA: 0x00065D58 File Offset: 0x00063F58
		private static void KeyContainerPermissionFlagsMatchAllKeyword(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("DAISY09");
			buttons.color(new Color32(byte.MaxValue, 81, 231, byte.MaxValue));
			bool flag = t.nindex == 2;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 1 + 91;
			A_0 = num;
		}

		// Token: 0x06000A4B RID: 2635 RVA: 0x00065DEC File Offset: 0x00063FEC
		private static void GivenNameYearto(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			A_0 = 120;
		}

		// Token: 0x06000A4C RID: 2636 RVA: 0x00065E04 File Offset: 0x00064004
		private static void AdminToolsGetAsyncBeginInfo(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 3;
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 1 + 165;
			A_0 = num;
		}

		// Token: 0x06000A4D RID: 2637 RVA: 0x00065E68 File Offset: 0x00064068
		private static void GenerateHashencoding(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			c.Prefix(GorillaTagger.Instance.offlineVRRig);
			A_1 = 0;
		}

		// Token: 0x06000A4E RID: 2638 RVA: 0x00065E90 File Offset: 0x00064090
		private static void PathNotFoundPOLICYTRUSTADMIN(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 1;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 1 + 89;
			A_0 = num;
		}

		// Token: 0x06000A4F RID: 2639 RVA: 0x00065EF4 File Offset: 0x000640F4
		public static void dw11d()
		{
			int num = 254;
			int num2 = 254;
			num2 = 254;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, ineedhelp.TypeNAssemblyReturnValueInArray[num]);
			}
			num2 = 254;
		}

		// Token: 0x06000A50 RID: 2640 RVA: 0x00065F38 File Offset: 0x00064138
		private static void LocalPathgetApplicationTrustManager(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("PBBV");
			buttons.color(new Color32(230, 127, 102, byte.MaxValue));
			bool flag = t.nindex == 3;
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 1 + 129;
			A_0 = num;
		}

		// Token: 0x06000A51 RID: 2641 RVA: 0x00065FCC File Offset: 0x000641CC
		private static void DYMscorlibDictionaryValueCollectionDebugView(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 1;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 1 + 186;
			A_0 = num;
		}

		// Token: 0x06000A52 RID: 2642 RVA: 0x00066030 File Offset: 0x00064230
		private static void IsNaNsetXmlNameSpace(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("PBBV");
			buttons.color(new Color32(230, 127, 102, byte.MaxValue));
			bool flag = t.nindex == 3;
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 1 + 250;
			A_0 = num;
		}

		// Token: 0x06000A53 RID: 2643 RVA: 0x000660C4 File Offset: 0x000642C4
		private static void CallContextSecurityDatasetResponseXmlNamespace(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 3;
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 1 + 8;
			A_0 = num;
		}

		// Token: 0x06000A54 RID: 2644 RVA: 0x00066128 File Offset: 0x00064328
		private static void RightToLeftArabicUnsafeToString(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			GorillaTagger.Instance.offlineVRRig.enabled = false;
			GameObject gameObject = GameObject.CreatePrimitive(0);
			A_4 = gameObject;
			GameObject gameObject2 = GameObject.CreatePrimitive(0);
			A_5 = gameObject2;
			Object.Destroy(A_4.GetComponent<Rigidbody>());
			Object.Destroy(A_4.GetComponent<SphereCollider>());
			Object.Destroy(A_5.GetComponent<Rigidbody>());
			Object.Destroy(A_5.GetComponent<SphereCollider>());
			A_4.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
			A_5.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
			A_4.transform.position = GorillaTagger.Instance.rightHandTransform.position;
			A_5.transform.position = GorillaTagger.Instance.leftHandTransform.position;
			A_4.GetComponent<Renderer>().material.color = new Color32(50, 50, 50, byte.MaxValue);
			A_5.GetComponent<Renderer>().material.color = new Color32(50, 50, 50, byte.MaxValue);
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 360), (float)Random.Range(0, 360));
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 180), (float)Random.Range(0, 180));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 360), (float)Random.Range(0, 360));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 180), (float)Random.Range(0, 180));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 360), (float)Random.Range(0, 360));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 180), (float)Random.Range(0, 180));
			Player.Instance.transform.position = new Vector3(Player.Instance.transform.position.x, Player.Instance.transform.position.y + 0.06f, Player.Instance.transform.position.z);
			Object.Destroy(A_4, Time.deltaTime);
			Object.Destroy(A_5, Time.deltaTime);
			t.nindex++;
			bool flag = t.nindex > 3;
			A_6 = flag;
			int num = ((!A_6) ? 1 : 0) * 1 + 111;
			A_0 = num;
		}

		// Token: 0x06000A55 RID: 2645 RVA: 0x00066594 File Offset: 0x00064794
		private static void GetInvalidPathCharsMissingFieldException(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			c.Prefix(GorillaTagger.Instance.offlineVRRig);
			A_1 = 0;
		}

		// Token: 0x06000A56 RID: 2646 RVA: 0x000665BC File Offset: 0x000647BC
		private static void InstalledWinCulturesComponentGuaranteesOptions(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			GorillaTagger.Instance.offlineVRRig.enabled = false;
			GameObject gameObject = GameObject.CreatePrimitive(0);
			A_4 = gameObject;
			GameObject gameObject2 = GameObject.CreatePrimitive(0);
			A_5 = gameObject2;
			Object.Destroy(A_4.GetComponent<Rigidbody>());
			Object.Destroy(A_4.GetComponent<SphereCollider>());
			Object.Destroy(A_5.GetComponent<Rigidbody>());
			Object.Destroy(A_5.GetComponent<SphereCollider>());
			A_4.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
			A_5.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
			A_4.transform.position = GorillaTagger.Instance.rightHandTransform.position;
			A_5.transform.position = GorillaTagger.Instance.leftHandTransform.position;
			A_4.GetComponent<Renderer>().material.color = new Color32(50, 50, 50, byte.MaxValue);
			A_5.GetComponent<Renderer>().material.color = new Color32(50, 50, 50, byte.MaxValue);
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 360), (float)Random.Range(0, 360));
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 180), (float)Random.Range(0, 180));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 360), (float)Random.Range(0, 360));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 180), (float)Random.Range(0, 180));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 360), (float)Random.Range(0, 360));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 180), (float)Random.Range(0, 180));
			Player.Instance.transform.position = new Vector3(Player.Instance.transform.position.x, Player.Instance.transform.position.y + 0.06f, Player.Instance.transform.position.z);
			Object.Destroy(A_4, Time.deltaTime);
			Object.Destroy(A_5, Time.deltaTime);
			t.nindex++;
			bool flag = t.nindex > 3;
			A_6 = flag;
			int num = ((!A_6) ? 1 : 0) * 1 + 196;
			A_0 = num;
		}

		// Token: 0x06000A57 RID: 2647 RVA: 0x00066A28 File Offset: 0x00064C28
		private static void setLabelPOLICYCREATESECRET(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			GorillaTagger.Instance.offlineVRRig.enabled = false;
			GameObject gameObject = GameObject.CreatePrimitive(0);
			A_4 = gameObject;
			GameObject gameObject2 = GameObject.CreatePrimitive(0);
			A_5 = gameObject2;
			Object.Destroy(A_4.GetComponent<Rigidbody>());
			Object.Destroy(A_4.GetComponent<SphereCollider>());
			Object.Destroy(A_5.GetComponent<Rigidbody>());
			Object.Destroy(A_5.GetComponent<SphereCollider>());
			A_4.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
			A_5.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
			A_4.transform.position = GorillaTagger.Instance.rightHandTransform.position;
			A_5.transform.position = GorillaTagger.Instance.leftHandTransform.position;
			A_4.GetComponent<Renderer>().material.color = new Color32(50, 50, 50, byte.MaxValue);
			A_5.GetComponent<Renderer>().material.color = new Color32(50, 50, 50, byte.MaxValue);
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 360), (float)Random.Range(0, 360));
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 180), (float)Random.Range(0, 180));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 360), (float)Random.Range(0, 360));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 180), (float)Random.Range(0, 180));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 360), (float)Random.Range(0, 360));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 180), (float)Random.Range(0, 180));
			Player.Instance.transform.position = new Vector3(Player.Instance.transform.position.x, Player.Instance.transform.position.y + 0.06f, Player.Instance.transform.position.z);
			Object.Destroy(A_4, Time.deltaTime);
			Object.Destroy(A_5, Time.deltaTime);
			t.nindex++;
			bool flag = t.nindex > 3;
			A_6 = flag;
			int num = ((!A_6) ? 1 : 0) * 1 + 184;
			A_0 = num;
		}

		// Token: 0x06000A58 RID: 2648 RVA: 0x00066E94 File Offset: 0x00065094
		private static void PinvokeImplOnDeserialized(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 2;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 1 + 6;
			A_0 = num;
		}

		// Token: 0x06000A59 RID: 2649 RVA: 0x00066EF8 File Offset: 0x000650F8
		private static void ChangeAclgetAppDomainManagerType(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 2;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 1 + 18;
			A_0 = num;
		}

		// Token: 0x06000A5A RID: 2650 RVA: 0x00066F5C File Offset: 0x0006515C
		private static void TraverseSoapNormalizedString(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("PBBV");
			buttons.color(new Color32(230, 127, 102, byte.MaxValue));
			bool flag = t.nindex == 3;
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 1 + 275;
			A_0 = num;
		}

		// Token: 0x06000A5B RID: 2651 RVA: 0x00066FF0 File Offset: 0x000651F0
		private static void getValuesDynamicInvoke(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("DAISY09");
			buttons.color(new Color32(byte.MaxValue, 81, 231, byte.MaxValue));
			bool flag = t.nindex == 2;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 1 + 42;
			A_0 = num;
		}

		// Token: 0x06000A5C RID: 2652 RVA: 0x00067084 File Offset: 0x00065284
		private static void PrivateBinPathValueDelegateWrapper(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 2;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 1 + 285;
			A_0 = num;
		}

		// Token: 0x06000A5D RID: 2653 RVA: 0x000670E8 File Offset: 0x000652E8
		private static void dictionaryAsBool(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("PBBV");
			buttons.color(new Color32(230, 127, 102, byte.MaxValue));
			bool flag = t.nindex == 3;
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 1 + 238;
			A_0 = num;
		}

		// Token: 0x06000A5E RID: 2654 RVA: 0x0006717C File Offset: 0x0006537C
		private static void IRuntimeEvidenceFactorygetContainsGenericParameters(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool gripDownR = buttons.gripDownR;
			A_3 = gripDownR;
			int num = ((!A_3) ? 1 : 0) * 9 + 183;
			A_0 = num;
		}

		// Token: 0x06000A5F RID: 2655 RVA: 0x000671D8 File Offset: 0x000653D8
		// Note: this type is marked as 'beforefieldinit'.
		static ineedhelp()
		{
			ineedhelp.BootstrapContextMetadataSectionCompatibleFrameworksData();
		}

		// Token: 0x06000A60 RID: 2656 RVA: 0x000671EC File Offset: 0x000653EC
		private static void BootstrapContextMetadataSectionCompatibleFrameworksData()
		{
			ineedhelp.TypeNAssemblyReturnValueInArray = new IntPtr[292];
			ineedhelp.TypeNAssemblyReturnValueInArray[0] = ldftn(IsPermissionElementgetOperations);
			ineedhelp.TypeNAssemblyReturnValueInArray[1] = ldftn(IsNestedFamANDAssemIsObjectOutOfContext);
			ineedhelp.TypeNAssemblyReturnValueInArray[2] = ldftn(GetUIntArraygetKeysOrderedInEachPartition);
			ineedhelp.TypeNAssemblyReturnValueInArray[3] = ldftn(LdelemRefOverlappedData);
			ineedhelp.TypeNAssemblyReturnValueInArray[4] = ldftn(HasFlushedFinalBlockReadBlockAsync);
			ineedhelp.TypeNAssemblyReturnValueInArray[5] = ldftn(PinvokeImplOnDeserialized);
			ineedhelp.TypeNAssemblyReturnValueInArray[6] = ldftn(GetHeadersEndOfString);
			ineedhelp.TypeNAssemblyReturnValueInArray[7] = ldftn(CallContextSecurityDatasetResponseXmlNamespace);
			ineedhelp.TypeNAssemblyReturnValueInArray[8] = ldftn(ImportIsMethodOverloaded);
			ineedhelp.TypeNAssemblyReturnValueInArray[9] = ldftn(ContextFormUpnName);
			ineedhelp.TypeNAssemblyReturnValueInArray[10] = ldftn(getMonitoringTotalProcessorTimeAddInterfaceImplementation);
			ineedhelp.TypeNAssemblyReturnValueInArray[11] = ldftn(DiscretionaryAclThreadTransfer);
			ineedhelp.TypeNAssemblyReturnValueInArray[12] = ldftn(ReadOnlyArrayAttributeSequential);
			ineedhelp.TypeNAssemblyReturnValueInArray[13] = ldftn(getIsNetFxLegacyManagedDeflateStreamgetLastWriteTime);
			ineedhelp.TypeNAssemblyReturnValueInArray[14] = ldftn(cDisplayClassGetLoadedModules);
			ineedhelp.TypeNAssemblyReturnValueInArray[15] = ldftn(FindGregorianEra);
			ineedhelp.TypeNAssemblyReturnValueInArray[16] = ldftn(StoreOperationUninstallDeploymentCLSCompliantAttribute);
			ineedhelp.TypeNAssemblyReturnValueInArray[17] = ldftn(ChangeAclgetAppDomainManagerType);
			ineedhelp.TypeNAssemblyReturnValueInArray[18] = ldftn(CancelMidpointRounding);
			ineedhelp.TypeNAssemblyReturnValueInArray[19] = ldftn(FailedAccessObjectCreationDelegate);
			ineedhelp.TypeNAssemblyReturnValueInArray[20] = ldftn(IsGenericTypeErrorCode);
			ineedhelp.TypeNAssemblyReturnValueInArray[21] = ldftn(IBindableIterableGenericMethodInfo);
			ineedhelp.TypeNAssemblyReturnValueInArray[22] = ldftn(HebrewValueAccessViolationException);
			ineedhelp.TypeNAssemblyReturnValueInArray[23] = ldftn(setDeploymentIdIsFullyTrusted);
			ineedhelp.TypeNAssemblyReturnValueInArray[24] = ldftn(BinaryObjectWithMapBrowserBack);
			ineedhelp.TypeNAssemblyReturnValueInArray[25] = ldftn(ObjectUserGetActiveObject);
			ineedhelp.TypeNAssemblyReturnValueInArray[26] = ldftn(CeilingChannelData);
			ineedhelp.TypeNAssemblyReturnValueInArray[27] = ldftn(getPercentGroupSeparatorHidden);
			ineedhelp.TypeNAssemblyReturnValueInArray[28] = ldftn(UnregisterDynamicPropertyIsSecurityCritical);
			ineedhelp.TypeNAssemblyReturnValueInArray[29] = ldftn(BgtUnSCallerMemberNameAttribute);
			ineedhelp.TypeNAssemblyReturnValueInArray[30] = ldftn(GetSexagenaryYearStartEntity);
			ineedhelp.TypeNAssemblyReturnValueInArray[31] = ldftn(SetGroupVerbose);
			ineedhelp.TypeNAssemblyReturnValueInArray[32] = ldftn(TokenAppContainerNumberGetMinute);
			ineedhelp.TypeNAssemblyReturnValueInArray[33] = ldftn(DoNotDisposeMetadataSectionMvidValueSize);
			ineedhelp.TypeNAssemblyReturnValueInArray[34] = ldftn(GetLineNumberSecurityContextSwitcher);
			ineedhelp.TypeNAssemblyReturnValueInArray[35] = ldftn(MemberEndInArgCount);
			ineedhelp.TypeNAssemblyReturnValueInArray[36] = ldftn(AtFixedPermissionListSet);
			ineedhelp.TypeNAssemblyReturnValueInArray[37] = ldftn(UtfJsonsetNumberDecimalSeparator);
			ineedhelp.TypeNAssemblyReturnValueInArray[38] = ldftn(getShadowCopyDirectoriesAddResourceData);
			ineedhelp.TypeNAssemblyReturnValueInArray[39] = ldftn(AggregateDictionaryPaths);
			ineedhelp.TypeNAssemblyReturnValueInArray[40] = ldftn(getValuesDynamicInvoke);
			ineedhelp.TypeNAssemblyReturnValueInArray[41] = ldftn(OperationalUCOMIStream);
			ineedhelp.TypeNAssemblyReturnValueInArray[42] = ldftn(AddrOfPinnedObjectIsPathRooted);
			ineedhelp.TypeNAssemblyReturnValueInArray[43] = ldftn(UtilsCheckValueReadPermission);
			ineedhelp.TypeNAssemblyReturnValueInArray[44] = ldftn(WritableTypesetExitCode);
			ineedhelp.TypeNAssemblyReturnValueInArray[45] = ldftn(setProviderNameOSX);
			ineedhelp.TypeNAssemblyReturnValueInArray[46] = ldftn(SparselyPopulatedArrayAddInfoSetUserEntryPoint);
			ineedhelp.TypeNAssemblyReturnValueInArray[47] = ldftn(StackFrameHelpersetAppDomainManagerType);
			ineedhelp.TypeNAssemblyReturnValueInArray[48] = ldftn(InterfaceMappingGetLibAttr);
			ineedhelp.TypeNAssemblyReturnValueInArray[49] = ldftn(RandomNumberGeneratorStdCall);
			ineedhelp.TypeNAssemblyReturnValueInArray[50] = ldftn(PreferFairnessIIDIStore);
			ineedhelp.TypeNAssemblyReturnValueInArray[51] = ldftn(DefineConstructorWriterSeqNum);
			ineedhelp.TypeNAssemblyReturnValueInArray[52] = ldftn(IgnoreNonSpaceBadData);
			ineedhelp.TypeNAssemblyReturnValueInArray[53] = ldftn(IChannelInfoGetImplTypeCustData);
			ineedhelp.TypeNAssemblyReturnValueInArray[54] = ldftn(RegistryAuditRuleIAssemblyEnum);
			ineedhelp.TypeNAssemblyReturnValueInArray[55] = ldftn(MaxGenerationIsSuffix);
			ineedhelp.TypeNAssemblyReturnValueInArray[56] = ldftn(ArabicNumberGetPrimary);
			ineedhelp.TypeNAssemblyReturnValueInArray[57] = ldftn(RfcNameEuropeanNumber);
			ineedhelp.TypeNAssemblyReturnValueInArray[58] = ldftn(InlineNoneInternalEncodingDataItem);
			ineedhelp.TypeNAssemblyReturnValueInArray[59] = ldftn(GetInvalidPathCharsMissingFieldException);
			ineedhelp.TypeNAssemblyReturnValueInArray[60] = ldftn(XMLLangCallvirt);
			ineedhelp.TypeNAssemblyReturnValueInArray[61] = ldftn(FlattensetControlPrincipal);
			ineedhelp.TypeNAssemblyReturnValueInArray[62] = ldftn(MyVideosCCRESERVED);
			ineedhelp.TypeNAssemblyReturnValueInArray[63] = ldftn(getPrivilegeNameGetAssemblyIdentity);
			ineedhelp.TypeNAssemblyReturnValueInArray[64] = ldftn(getElementTypegetISOCurrencySymbol);
			ineedhelp.TypeNAssemblyReturnValueInArray[65] = ldftn(UCOMITypeCompUnmanagedMemoryStreamWrapper);
			ineedhelp.TypeNAssemblyReturnValueInArray[66] = ldftn(VolumeMuteBegin);
			ineedhelp.TypeNAssemblyReturnValueInArray[67] = ldftn(RijndaelManagedSizeConst);
			ineedhelp.TypeNAssemblyReturnValueInArray[68] = ldftn(setAbbreviatedDayNameserr);
			ineedhelp.TypeNAssemblyReturnValueInArray[69] = ldftn(ResourceManagerNeutralResourcesSufficientMapToCollectionAdapter);
			ineedhelp.TypeNAssemblyReturnValueInArray[70] = ldftn(ThreadTransferReceiveObjPERSIAN);
			ineedhelp.TypeNAssemblyReturnValueInArray[71] = ldftn(BindReferenceToAssemblyIdentityIHashElementEntry);
			ineedhelp.TypeNAssemblyReturnValueInArray[72] = ldftn(ModeKRAllowHexPrefix);
			ineedhelp.TypeNAssemblyReturnValueInArray[73] = ldftn(ConcurrentDictionaryDetail);
			ineedhelp.TypeNAssemblyReturnValueInArray[74] = ldftn(BrowserStopUtcTicks);
			ineedhelp.TypeNAssemblyReturnValueInArray[75] = ldftn(SetScopeRangeTimeZone);
			ineedhelp.TypeNAssemblyReturnValueInArray[76] = ldftn(CMSTIMEUNITTYPEHOURSIsValueCreated);
			ineedhelp.TypeNAssemblyReturnValueInArray[77] = ldftn(GetPrimeProcessorArchitectureINTEL);
			ineedhelp.TypeNAssemblyReturnValueInArray[78] = ldftn(UnspecifiedTypeSizeCertificate);
			ineedhelp.TypeNAssemblyReturnValueInArray[79] = ldftn(GetMethodFromHandlesetTaskScheduler);
			ineedhelp.TypeNAssemblyReturnValueInArray[80] = ldftn(EntryPointEntryFieldIdEndProlog);
			ineedhelp.TypeNAssemblyReturnValueInArray[81] = ldftn(SetWindowSizeTYPEFLAGFCANCREATE);
			ineedhelp.TypeNAssemblyReturnValueInArray[82] = ldftn(getIsCOMObjectCommonMusic);
			ineedhelp.TypeNAssemblyReturnValueInArray[83] = ldftn(CreateFromNameDTSubString);
			ineedhelp.TypeNAssemblyReturnValueInArray[84] = ldftn(MarkAbortedSpinLock);
			ineedhelp.TypeNAssemblyReturnValueInArray[85] = ldftn(CreateActContextParametersSourceDefinitionAppidFileAssociationEntry);
			ineedhelp.TypeNAssemblyReturnValueInArray[86] = ldftn(ToStringHelperFuncWindowsSubAuthority);
			ineedhelp.TypeNAssemblyReturnValueInArray[87] = ldftn(getResourceTypeIdStringIAssemblyRequestEntry);
			ineedhelp.TypeNAssemblyReturnValueInArray[88] = ldftn(PathNotFoundPOLICYTRUSTADMIN);
			ineedhelp.TypeNAssemblyReturnValueInArray[89] = ldftn(KeyContainerPermissionFlagsMatchAllKeyword);
			ineedhelp.TypeNAssemblyReturnValueInArray[90] = ldftn(FastResourceComparerAnsiCharMarshaler);
			ineedhelp.TypeNAssemblyReturnValueInArray[91] = ldftn(GetTypesAsyncProcessMessage);
			ineedhelp.TypeNAssemblyReturnValueInArray[92] = ldftn(oceAssemblyReferenceDependentAssemblyEntryFieldId);
			ineedhelp.TypeNAssemblyReturnValueInArray[93] = ldftn(GetLoadedModulesComposedOfNoPublicMembers);
			ineedhelp.TypeNAssemblyReturnValueInArray[94] = ldftn(setExceptionTypeOtherNeutrals);
			ineedhelp.TypeNAssemblyReturnValueInArray[95] = ldftn(AssemblyVersionCompatibilityMultiDomain);
			ineedhelp.TypeNAssemblyReturnValueInArray[96] = ldftn(GenerateHashencoding);
			ineedhelp.TypeNAssemblyReturnValueInArray[97] = ldftn(CreateSubdirectoryLeftToRightIsolate);
			ineedhelp.TypeNAssemblyReturnValueInArray[98] = ldftn(SecurityAttributeTaskAwaiter);
			ineedhelp.TypeNAssemblyReturnValueInArray[99] = ldftn(ManualResetEventSlimgetPrivateBinPath);
			ineedhelp.TypeNAssemblyReturnValueInArray[100] = ldftn(cPropertiesToSetgetBindingRedirects);
			ineedhelp.TypeNAssemblyReturnValueInArray[101] = ldftn(INormalizeForIsolatedStorageHandlerOffset);
			ineedhelp.TypeNAssemblyReturnValueInArray[102] = ldftn(setAppDomainInitializerArgumentsSynchronizationAttribute);
			ineedhelp.TypeNAssemblyReturnValueInArray[103] = ldftn(FindTokenByIndexTokenImpersonation);
			ineedhelp.TypeNAssemblyReturnValueInArray[104] = ldftn(opExclusiveOrMethodImplOptions);
			ineedhelp.TypeNAssemblyReturnValueInArray[105] = ldftn(AFRfcDeriveBytes);
			ineedhelp.TypeNAssemblyReturnValueInArray[106] = ldftn(FXAssemblyGetPEKind);
			ineedhelp.TypeNAssemblyReturnValueInArray[107] = ldftn(getIsAbstractGetDeclaredNestedType);
			ineedhelp.TypeNAssemblyReturnValueInArray[108] = ldftn(getModulessetLocked);
			ineedhelp.TypeNAssemblyReturnValueInArray[109] = ldftn(SizeArrayEncode);
			ineedhelp.TypeNAssemblyReturnValueInArray[110] = ldftn(RightToLeftArabicUnsafeToString);
			ineedhelp.TypeNAssemblyReturnValueInArray[111] = ldftn(removeEventSourceCreatedGetService);
			ineedhelp.TypeNAssemblyReturnValueInArray[112] = ldftn(UserClaimsValueLength);
			ineedhelp.TypeNAssemblyReturnValueInArray[113] = ldftn(setRoleThisAssembly);
			ineedhelp.TypeNAssemblyReturnValueInArray[114] = ldftn(getObjectNameOidKeyType);
			ineedhelp.TypeNAssemblyReturnValueInArray[115] = ldftn(FirstFullWeekgetBaseUtcOffset);
			ineedhelp.TypeNAssemblyReturnValueInArray[116] = ldftn(SystemDefaultCharSizeResetAccessRule);
			ineedhelp.TypeNAssemblyReturnValueInArray[117] = ldftn(DigestAuthenticationSidgetDomainManager);
			ineedhelp.TypeNAssemblyReturnValueInArray[118] = ldftn(GivenNameYearto);
			ineedhelp.TypeNAssemblyReturnValueInArray[119] = ldftn(IntegerIdsUnmanagedMemoryStreamWrapper);
			ineedhelp.TypeNAssemblyReturnValueInArray[120] = ldftn(AdminLongPathFile);
			ineedhelp.TypeNAssemblyReturnValueInArray[121] = ldftn(BarrierPhaseFinishedGenerics);
			ineedhelp.TypeNAssemblyReturnValueInArray[122] = ldftn(GetSymAttributeReplacementFallback);
			ineedhelp.TypeNAssemblyReturnValueInArray[123] = ldftn(PrivateBinPathProbeGetInArg);
			ineedhelp.TypeNAssemblyReturnValueInArray[124] = ldftn(setHostContextObjectDisposedRegKeyClosed);
			ineedhelp.TypeNAssemblyReturnValueInArray[125] = ldftn(TransformDispRetValslastCultureName);
			ineedhelp.TypeNAssemblyReturnValueInArray[126] = ldftn(ProgramFilesXToFileTime);
			ineedhelp.TypeNAssemblyReturnValueInArray[127] = ldftn(LocalPathgetApplicationTrustManager);
			ineedhelp.TypeNAssemblyReturnValueInArray[128] = ldftn(CCMAXgetVersion);
			ineedhelp.TypeNAssemblyReturnValueInArray[129] = ldftn(UndockTimeoutException);
			ineedhelp.TypeNAssemblyReturnValueInArray[130] = ldftn(ActivityIdEmptySet);
			ineedhelp.TypeNAssemblyReturnValueInArray[131] = ldftn(LockConvertTimeToUtc);
			ineedhelp.TypeNAssemblyReturnValueInArray[132] = ldftn(GetNextTextElementTransportHeaders);
			ineedhelp.TypeNAssemblyReturnValueInArray[133] = ldftn(RelatedActivityIdsetReturnXmlElementName);
			ineedhelp.TypeNAssemblyReturnValueInArray[134] = ldftn(MaxOpaqueLengthgetIsAppEarlierThanWindowsPhoneMango);
			ineedhelp.TypeNAssemblyReturnValueInArray[135] = ldftn(UnsafeAddrOfPinnedArrayElementgetMaxStackSize);
			ineedhelp.TypeNAssemblyReturnValueInArray[136] = ldftn(getXmlSegmentHashElementDigestValue);
			ineedhelp.TypeNAssemblyReturnValueInArray[137] = ldftn(ReadExceptionObject);
			ineedhelp.TypeNAssemblyReturnValueInArray[138] = ldftn(GetArgNameWaitingToRun);
			ineedhelp.TypeNAssemblyReturnValueInArray[139] = ldftn(MetadataSectionManifestFlagsISymbolVariable);
			ineedhelp.TypeNAssemblyReturnValueInArray[140] = ldftn(RegisterAssemblyOnlyOnRanToCompletion);
			ineedhelp.TypeNAssemblyReturnValueInArray[141] = ldftn(IsValidAttributeValueSetError);
			ineedhelp.TypeNAssemblyReturnValueInArray[142] = ldftn(NonEventAttributegetDocumentType);
			ineedhelp.TypeNAssemblyReturnValueInArray[143] = ldftn(AceEnumeratorGetFault);
			ineedhelp.TypeNAssemblyReturnValueInArray[144] = ldftn(getIsPrivateTRACEGUIDINFO);
			ineedhelp.TypeNAssemblyReturnValueInArray[145] = ldftn(ArchiveGetSecurityDescriptorSddlForm);
			ineedhelp.TypeNAssemblyReturnValueInArray[146] = ldftn(CompatibleFrameworksMetadataEntryDisableComObjectEagerCleanup);
			ineedhelp.TypeNAssemblyReturnValueInArray[147] = ldftn(SoapMethodAttributeLoadPolicyLevelFromFile);
			ineedhelp.TypeNAssemblyReturnValueInArray[148] = ldftn(getViewDefaultRequestSet);
			ineedhelp.TypeNAssemblyReturnValueInArray[149] = ldftn(WaitHandleCMSUSAGEPATTERNSCOPEAPPLICATION);
			ineedhelp.TypeNAssemblyReturnValueInArray[150] = ldftn(SymLanguageTypeClaimsIdentity);
			ineedhelp.TypeNAssemblyReturnValueInArray[151] = ldftn(UTFMarshalerResourceTypeResourcesDependency);
			ineedhelp.TypeNAssemblyReturnValueInArray[152] = ldftn(RevertAssertCommonAce);
			ineedhelp.TypeNAssemblyReturnValueInArray[153] = ldftn(SystemAclDefaultedSetOwner);
			ineedhelp.TypeNAssemblyReturnValueInArray[154] = ldftn(ArgArrayPlusOffTooSmallCreationOptions);
			ineedhelp.TypeNAssemblyReturnValueInArray[155] = ldftn(CallConvCdeclGetCurrent);
			ineedhelp.TypeNAssemblyReturnValueInArray[156] = ldftn(MaxSupportedDateTimeCriticalHandle);
			ineedhelp.TypeNAssemblyReturnValueInArray[157] = ldftn(MobilePhonePackForNative);
			ineedhelp.TypeNAssemblyReturnValueInArray[158] = ldftn(ReadWriteSubTreeWriteLine);
			ineedhelp.TypeNAssemblyReturnValueInArray[159] = ldftn(AddValueASSEMBLYFLAGS);
			ineedhelp.TypeNAssemblyReturnValueInArray[160] = ldftn(FromCurrentSynchronizationContextFileSize);
			ineedhelp.TypeNAssemblyReturnValueInArray[161] = ldftn(PathDiscoveryWriteExtendedAttributes);
			ineedhelp.TypeNAssemblyReturnValueInArray[162] = ldftn(IsAlwaysNormalizedGenericInst);
			ineedhelp.TypeNAssemblyReturnValueInArray[163] = ldftn(FormKCSameProcess);
			ineedhelp.TypeNAssemblyReturnValueInArray[164] = ldftn(AdminToolsGetAsyncBeginInfo);
			ineedhelp.TypeNAssemblyReturnValueInArray[165] = ldftn(STAThreadAttributeConditionString);
			ineedhelp.TypeNAssemblyReturnValueInArray[166] = ldftn(ExpandStringgetOffset);
			ineedhelp.TypeNAssemblyReturnValueInArray[167] = ldftn(RequiresStringComparisonRunning);
			ineedhelp.TypeNAssemblyReturnValueInArray[168] = ldftn(ModeHalfwidthKatakanaThreadLocal);
			ineedhelp.TypeNAssemblyReturnValueInArray[169] = ldftn(IDisposableToIClosableAdapterSecurityDocumentElement);
			ineedhelp.TypeNAssemblyReturnValueInArray[170] = ldftn(TrackResurrectionEVENTACTIVITYCTRLGETID);
			ineedhelp.TypeNAssemblyReturnValueInArray[171] = ldftn(GetRealProxyArraySegment);
			ineedhelp.TypeNAssemblyReturnValueInArray[172] = ldftn(DigitSubstitutiongetOSDescription);
			ineedhelp.TypeNAssemblyReturnValueInArray[173] = ldftn(getAsDecimalDictionaryValueEnumerator);
			ineedhelp.TypeNAssemblyReturnValueInArray[174] = ldftn(SEPPmGetComObjectData);
			ineedhelp.TypeNAssemblyReturnValueInArray[175] = ldftn(DetermineApplicationTrustProcessorArchitectureAMD);
			ineedhelp.TypeNAssemblyReturnValueInArray[176] = ldftn(StoreCategoryEnumerationAnsiBSTRMarshaler);
			ineedhelp.TypeNAssemblyReturnValueInArray[177] = ldftn(getIsValueCreatedRenewing);
			ineedhelp.TypeNAssemblyReturnValueInArray[178] = ldftn(UserNameDss);
			ineedhelp.TypeNAssemblyReturnValueInArray[179] = ldftn(AsyncMethodBuilderCoreComponentRelativePath);
			ineedhelp.TypeNAssemblyReturnValueInArray[180] = ldftn(ResourceManagerAuthorityEvent);
			ineedhelp.TypeNAssemblyReturnValueInArray[181] = ldftn(WebpageIncreaseQuota);
			ineedhelp.TypeNAssemblyReturnValueInArray[182] = ldftn(IRuntimeEvidenceFactorygetContainsGenericParameters);
			ineedhelp.TypeNAssemblyReturnValueInArray[183] = ldftn(setLabelPOLICYCREATESECRET);
			ineedhelp.TypeNAssemblyReturnValueInArray[184] = ldftn(PrelinkAllMarshalCookie);
			ineedhelp.TypeNAssemblyReturnValueInArray[185] = ldftn(DYMscorlibDictionaryValueCollectionDebugView);
			ineedhelp.TypeNAssemblyReturnValueInArray[186] = ldftn(RevertPermitOnlyManualReset);
			ineedhelp.TypeNAssemblyReturnValueInArray[187] = ldftn(ComVisibleAttributeVBByValStrMarshaler);
			ineedhelp.TypeNAssemblyReturnValueInArray[188] = ldftn(NumTimesuffTotalDays);
			ineedhelp.TypeNAssemblyReturnValueInArray[189] = ldftn(GetObjectForIUnknownObject);
			ineedhelp.TypeNAssemblyReturnValueInArray[190] = ldftn(getResourceScopeSetActorAsReferenceWhenCopyingClaimsIdentity);
			ineedhelp.TypeNAssemblyReturnValueInArray[191] = ldftn(IsEqualgetError);
			ineedhelp.TypeNAssemblyReturnValueInArray[192] = ldftn(ConstructorArgumentsTraverse);
			ineedhelp.TypeNAssemblyReturnValueInArray[193] = ldftn(MessageSurrogateFilterStringTypeInfo);
			ineedhelp.TypeNAssemblyReturnValueInArray[194] = ldftn(UTFEncodingsetPermitOnlySetInstance);
			ineedhelp.TypeNAssemblyReturnValueInArray[195] = ldftn(InstalledWinCulturesComponentGuaranteesOptions);
			ineedhelp.TypeNAssemblyReturnValueInArray[196] = ldftn(setHeadersIntranet);
			ineedhelp.TypeNAssemblyReturnValueInArray[197] = ldftn(TCEAdapterGeneratorIsAppEarlierThanSilverlight);
			ineedhelp.TypeNAssemblyReturnValueInArray[198] = ldftn(getWindowClassSectionGetDynamicPartitions);
			ineedhelp.TypeNAssemblyReturnValueInArray[199] = ldftn(HashElementTransformsetFlags);
			ineedhelp.TypeNAssemblyReturnValueInArray[200] = ldftn(GetManifestResourceInfoManualResetEventSlim);
			ineedhelp.TypeNAssemblyReturnValueInArray[201] = ldftn(NowPermissionRequestEvidence);
			ineedhelp.TypeNAssemblyReturnValueInArray[202] = ldftn(EncodingNameBinaryParser);
			ineedhelp.TypeNAssemblyReturnValueInArray[203] = ldftn(DependentOSMetadataEntryFieldIdgetBaseType);
			ineedhelp.TypeNAssemblyReturnValueInArray[204] = ldftn(ValueFixupGetILAsByteArray);
			ineedhelp.TypeNAssemblyReturnValueInArray[205] = ldftn(TransformDispRetValsQueueEnumerator);
			ineedhelp.TypeNAssemblyReturnValueInArray[206] = ldftn(EventOpcodeServerProcessing);
			ineedhelp.TypeNAssemblyReturnValueInArray[207] = ldftn(ArchivableUrlIdentityPermissionAttribute);
			ineedhelp.TypeNAssemblyReturnValueInArray[208] = ldftn(VersionUntrusted);
			ineedhelp.TypeNAssemblyReturnValueInArray[209] = ldftn(getDescriptionDataV);
			ineedhelp.TypeNAssemblyReturnValueInArray[210] = ldftn(OriginSchemeTKINDDISPATCH);
			ineedhelp.TypeNAssemblyReturnValueInArray[211] = ldftn(ContractHelpergetHandlerOffset);
			ineedhelp.TypeNAssemblyReturnValueInArray[212] = ldftn(SortVersionHostProtectionException);
			ineedhelp.TypeNAssemblyReturnValueInArray[213] = ldftn(IClientChannelSinkProviderTopLevelAssemblyTypeResolver);
			ineedhelp.TypeNAssemblyReturnValueInArray[214] = ldftn(LdlocaGetDateTime);
			ineedhelp.TypeNAssemblyReturnValueInArray[215] = ldftn(getInterfaceTypeMicrosoft);
			ineedhelp.TypeNAssemblyReturnValueInArray[216] = ldftn(AbandonedMutexExceptionVersionCompatibility);
			ineedhelp.TypeNAssemblyReturnValueInArray[217] = ldftn(HashCollisionThresholdgetReadTimeout);
			ineedhelp.TypeNAssemblyReturnValueInArray[218] = ldftn(SegmentStateSTOREASSEMBLYSTATUSPARTIALINSTALL);
			ineedhelp.TypeNAssemblyReturnValueInArray[219] = ldftn(setCapacityGetObjectForNativeVariant);
			ineedhelp.TypeNAssemblyReturnValueInArray[220] = ldftn(EnumNameSTORECATEGORYSUBCATEGORY);
			ineedhelp.TypeNAssemblyReturnValueInArray[221] = ldftn(ComRedirectionProxyPrincipalPermissionAttribute);
			ineedhelp.TypeNAssemblyReturnValueInArray[222] = ldftn(setShortTimePatternsetIsConsoleEnabled);
			ineedhelp.TypeNAssemblyReturnValueInArray[223] = ldftn(AuditFlagsRsaSign);
			ineedhelp.TypeNAssemblyReturnValueInArray[224] = ldftn(getDigestAlgorithmIsFamily);
			ineedhelp.TypeNAssemblyReturnValueInArray[225] = ldftn(StrongNameSignatureVerificationRemoveOnLogMessage);
			ineedhelp.TypeNAssemblyReturnValueInArray[226] = ldftn(PropertyNameGetFieldFromHandle);
			ineedhelp.TypeNAssemblyReturnValueInArray[227] = ldftn(FunctorComparerMetadataSectionCdfIdentity);
			ineedhelp.TypeNAssemblyReturnValueInArray[228] = ldftn(setLoaderOptimizationEventManifestOptions);
			ineedhelp.TypeNAssemblyReturnValueInArray[229] = ldftn(charLenCMSFILEFLAG);
			ineedhelp.TypeNAssemblyReturnValueInArray[230] = ldftn(CSlocalsISurrogateSelector);
			ineedhelp.TypeNAssemblyReturnValueInArray[231] = ldftn(getResultgetTargetSite);
			ineedhelp.TypeNAssemblyReturnValueInArray[232] = ldftn(getDetailgetFirstDayOfWeek);
			ineedhelp.TypeNAssemblyReturnValueInArray[233] = ldftn(StopPrivateBinPathProbeValue);
			ineedhelp.TypeNAssemblyReturnValueInArray[234] = ldftn(DssGetServerContextSink);
			ineedhelp.TypeNAssemblyReturnValueInArray[235] = ldftn(ReplicatorEndOffset);
			ineedhelp.TypeNAssemblyReturnValueInArray[236] = ldftn(dictionaryAsBool);
			ineedhelp.TypeNAssemblyReturnValueInArray[237] = ldftn(RuntimeAssemblyMemberReference);
			ineedhelp.TypeNAssemblyReturnValueInArray[238] = ldftn(BrowserRefreshgetVersionString);
			ineedhelp.TypeNAssemblyReturnValueInArray[239] = ldftn(PathDiscoverySetEnableAllKeywords);
			ineedhelp.TypeNAssemblyReturnValueInArray[240] = ldftn(mretValMarshalDirectiveException);
			ineedhelp.TypeNAssemblyReturnValueInArray[241] = ldftn(RequestedExecutionLevelUIAccessEntryAssembly);
			ineedhelp.TypeNAssemblyReturnValueInArray[242] = ldftn(MetadataSectionSchemaVersionILAssembly);
			ineedhelp.TypeNAssemblyReturnValueInArray[243] = ldftn(EnumCategoryInstancesyear);
			ineedhelp.TypeNAssemblyReturnValueInArray[244] = ldftn(DefinitionAppIdApplicationHasInfo);
			ineedhelp.TypeNAssemblyReturnValueInArray[245] = ldftn(LaunchMediaSelectWaitHandle);
			ineedhelp.TypeNAssemblyReturnValueInArray[246] = ldftn(getTargetedPatchBandPrimitive);
			ineedhelp.TypeNAssemblyReturnValueInArray[247] = ldftn(AsIcParamsOpt);
			ineedhelp.TypeNAssemblyReturnValueInArray[248] = ldftn(IsNaNsetXmlNameSpace);
			ineedhelp.TypeNAssemblyReturnValueInArray[249] = ldftn(RequiredBitGetContextNameObject);
			ineedhelp.TypeNAssemblyReturnValueInArray[250] = ldftn(WaitDelegategetOriginalIssuer);
			ineedhelp.TypeNAssemblyReturnValueInArray[251] = ldftn(InternalStoreCreated);
			ineedhelp.TypeNAssemblyReturnValueInArray[252] = ldftn(setPartialTrustVisibilityLevelgetIsModule);
			ineedhelp.TypeNAssemblyReturnValueInArray[253] = ldftn(getMonthGenitiveNamesStartMenu);
			ineedhelp.TypeNAssemblyReturnValueInArray[254] = ldftn(getTraceLevelEnumerateFileSystemInfos);
			ineedhelp.TypeNAssemblyReturnValueInArray[255] = ldftn(getReturnTypeDYN);
			ineedhelp.TypeNAssemblyReturnValueInArray[256] = ldftn(getOwnerSilent);
			ineedhelp.TypeNAssemblyReturnValueInArray[257] = ldftn(getEntryPointSectionRegisterForFullGCNotification);
			ineedhelp.TypeNAssemblyReturnValueInArray[258] = ldftn(WriteArrayArguments);
			ineedhelp.TypeNAssemblyReturnValueInArray[259] = ldftn(DnsPersistKeyInCsp);
			ineedhelp.TypeNAssemblyReturnValueInArray[260] = ldftn(RegisterActivatedServiceTypeDateMarshaler);
			ineedhelp.TypeNAssemblyReturnValueInArray[261] = ldftn(KeyContainerNameAgePendingBuffersResults);
			ineedhelp.TypeNAssemblyReturnValueInArray[262] = ldftn(BindDefinitionsAreComObjectsAvailableForCleanup);
			ineedhelp.TypeNAssemblyReturnValueInArray[263] = ldftn(DynamicTypeInfosetHandle);
			ineedhelp.TypeNAssemblyReturnValueInArray[264] = ldftn(ToStringIDependentOSMetadataEntry);
			ineedhelp.TypeNAssemblyReturnValueInArray[265] = ldftn(SetImplementationFlagsMonthNameStyles);
			ineedhelp.TypeNAssemblyReturnValueInArray[266] = ldftn(KeyPairgetDirectory);
			ineedhelp.TypeNAssemblyReturnValueInArray[267] = ldftn(getSyncRootgetSourcePath);
			ineedhelp.TypeNAssemblyReturnValueInArray[268] = ldftn(MonthTokenGetTypeFromCLSID);
			ineedhelp.TypeNAssemblyReturnValueInArray[269] = ldftn(memidConstructorBindToMethod);
			ineedhelp.TypeNAssemblyReturnValueInArray[270] = ldftn(GetEqualityComparerForSerializationBinaryObjectString);
			ineedhelp.TypeNAssemblyReturnValueInArray[271] = ldftn(ValueLengthGetSources);
			ineedhelp.TypeNAssemblyReturnValueInArray[272] = ldftn(PathParsingInfo);
			ineedhelp.TypeNAssemblyReturnValueInArray[273] = ldftn(TraverseSoapNormalizedString);
			ineedhelp.TypeNAssemblyReturnValueInArray[274] = ldftn(HasCurrentsetApplicationUrl);
			ineedhelp.TypeNAssemblyReturnValueInArray[275] = ldftn(cbStructgetCategoryMembershipSection);
			ineedhelp.TypeNAssemblyReturnValueInArray[276] = ldftn(AdjustToUniversalsetMemberAccess);
			ineedhelp.TypeNAssemblyReturnValueInArray[277] = ldftn(SystemAclPresentFailContinueFilter);
			ineedhelp.TypeNAssemblyReturnValueInArray[278] = ldftn(AddMinutesgetDeclaredEvents);
			ineedhelp.TypeNAssemblyReturnValueInArray[279] = ldftn(getRevisionVersionNoCurrentDateDefault);
			ineedhelp.TypeNAssemblyReturnValueInArray[280] = ldftn(RegistrationServicesDaylightBias);
			ineedhelp.TypeNAssemblyReturnValueInArray[281] = ldftn(MyPicturesCountry);
			ineedhelp.TypeNAssemblyReturnValueInArray[282] = ldftn(INVOCATIONFLAGSSPECIALFIELDFileInfo);
			ineedhelp.TypeNAssemblyReturnValueInArray[283] = ldftn(MinSupportedDateTimeAppDomainManager);
			ineedhelp.TypeNAssemblyReturnValueInArray[284] = ldftn(PrivateBinPathValueDelegateWrapper);
			ineedhelp.TypeNAssemblyReturnValueInArray[285] = ldftn(EphemerisCorrectionAlgorithmMapGetCurFile);
			ineedhelp.TypeNAssemblyReturnValueInArray[286] = ldftn(SetCustomAttributeGetMachineStoreForDomain);
			ineedhelp.TypeNAssemblyReturnValueInArray[287] = ldftn(GetZoneAndOrigingetSubKeyCount);
			ineedhelp.TypeNAssemblyReturnValueInArray[288] = ldftn(CondBranchGetUnmanagedThunkForManagedMethodPtr);
			ineedhelp.TypeNAssemblyReturnValueInArray[289] = ldftn(IBuiltInPermissionEventTagsMask);
			ineedhelp.TypeNAssemblyReturnValueInArray[290] = ldftn(NoMangleCreateActContextParameters);
			ineedhelp.TypeNAssemblyReturnValueInArray[291] = ldftn(StfldManageVolume);
		}

		// Token: 0x040000A8 RID: 168
		private static IntPtr[] TypeNAssemblyReturnValueInArray;
	}
}
