using System;
using GorillaLocomotion;
using Photon.Pun;
using ShibaGTTemplate.UI;
using UnityEngine;

namespace ShibaGTTemplate.Backend
{
	// Token: 0x0200001B RID: 27
	internal class fun
	{
		// Token: 0x0600077E RID: 1918 RVA: 0x00046724 File Offset: 0x00044924
		private static void RandomAccesssetKeySize(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("PBBV");
			buttons.color(new Color32(230, 127, 102, byte.MaxValue));
			bool flag = t.nindex == 3;
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 1 + 105;
			A_0 = num;
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x000467B8 File Offset: 0x000449B8
		private static void LetterNumberLoadWithPartialName(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
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

		// Token: 0x06000780 RID: 1920 RVA: 0x00046C24 File Offset: 0x00044E24
		private static void QueryChangeIDGetAbbreviatedDayName(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("DAISY09");
			buttons.color(new Color32(byte.MaxValue, 81, 231, byte.MaxValue));
			bool flag = t.nindex == 2;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 1 + 42;
			A_0 = num;
		}

		// Token: 0x06000781 RID: 1921 RVA: 0x00046CB8 File Offset: 0x00044EB8
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
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,UnityEngine.GameObject&,UnityEngine.GameObject&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&), ref num, ref num2, ref num3, ref flag, ref gameObject, ref gameObject2, ref flag2, ref flag3, ref flag4, ref flag5, fun.LegacyEvidenceListConfigEvents[num]);
			}
			num2 = 48;
		}

		// Token: 0x06000782 RID: 1922 RVA: 0x00046CFC File Offset: 0x00044EFC
		private static void PrimaryIdentitySelectorCustomAttributeExtensions(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool gripDownR = buttons.gripDownR;
			A_3 = gripDownR;
			int num = ((!A_3) ? 1 : 0) * 9 + 61;
			A_0 = num;
		}

		// Token: 0x06000783 RID: 1923 RVA: 0x00046D58 File Offset: 0x00044F58
		private static void AsyncCausalityStatusSetOffset(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			c.Prefix(GorillaTagger.Instance.offlineVRRig);
			A_1 = 12;
		}

		// Token: 0x06000784 RID: 1924 RVA: 0x00046D80 File Offset: 0x00044F80
		private static void NetworkServiceSidCallConvThiscall(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("DAISY09");
			buttons.color(new Color32(byte.MaxValue, 81, 231, byte.MaxValue));
			bool flag = t.nindex == 2;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 1 + 30;
			A_0 = num;
		}

		// Token: 0x06000785 RID: 1925 RVA: 0x00046E14 File Offset: 0x00045014
		private static void GetAsyncResultRedirectedGuid(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			c.Prefix(GorillaTagger.Instance.offlineVRRig);
			A_1 = 0;
		}

		// Token: 0x06000786 RID: 1926 RVA: 0x00046E3C File Offset: 0x0004503C
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
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,UnityEngine.GameObject&,UnityEngine.GameObject&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&), ref num, ref num2, ref num3, ref flag, ref gameObject, ref gameObject2, ref flag2, ref flag3, ref flag4, ref flag5, fun.LegacyEvidenceListConfigEvents[num]);
			}
			num2 = 85;
		}

		// Token: 0x06000787 RID: 1927 RVA: 0x00046E80 File Offset: 0x00045080
		private static void ISectionWithReferenceIdentityKeyMoveNextRunner(ref int A_0, ref int A_1, ref int A_2, fun A_3)
		{
			A_3..ctor();
			A_1 = 0;
		}

		// Token: 0x06000788 RID: 1928 RVA: 0x00046EA4 File Offset: 0x000450A4
		private static void IsGenericMethodDefinitionCopyToAsync(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
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

		// Token: 0x06000789 RID: 1929 RVA: 0x000470BC File Offset: 0x000452BC
		private static void GCHandleCookieTableAssertFailure(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
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

		// Token: 0x0600078A RID: 1930 RVA: 0x00047528 File Offset: 0x00045728
		private static void APPXFLAGSAPICHECKReflectionRestrictedMemberAccess(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("J3VU");
			buttons.color(new Color32(5, 200, 30, byte.MaxValue));
			A_0 = 47;
		}

		// Token: 0x0600078B RID: 1931 RVA: 0x00047574 File Offset: 0x00045774
		private static void setQuotaMaxMethodImplVal(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("PBBV");
			buttons.color(new Color32(230, 127, 102, byte.MaxValue));
			bool flag = t.nindex == 3;
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 1 + 44;
			A_0 = num;
		}

		// Token: 0x0600078C RID: 1932 RVA: 0x00047608 File Offset: 0x00045808
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
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,UnityEngine.GameObject&,UnityEngine.GameObject&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&), ref num, ref num2, ref num3, ref flag, ref gameObject, ref gameObject2, ref flag2, ref flag3, ref flag4, ref flag5, fun.LegacyEvidenceListConfigEvents[num]);
			}
			num2 = 24;
		}

		// Token: 0x0600078D RID: 1933 RVA: 0x0004764C File Offset: 0x0004584C
		private static void getIsOptionalgetWindowTop(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			t.nindex = 1;
			bool flag = t.nindex == 1;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 1 + 101;
			A_0 = num;
		}

		// Token: 0x0600078E RID: 1934 RVA: 0x000476BC File Offset: 0x000458BC
		private static void StrongNameIdentityPermissionNoteChangeTime(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool gripDownR = buttons.gripDownR;
			A_3 = gripDownR;
			int num = ((!A_3) ? 1 : 0) * 9 + 98;
			A_0 = num;
		}

		// Token: 0x0600078F RID: 1935 RVA: 0x00047718 File Offset: 0x00045918
		private static void UserNameSpaceIEnumSTOREDEPLOYMENTMETADATAPROPERTY(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 3;
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 1 + 20;
			A_0 = num;
		}

		// Token: 0x06000790 RID: 1936 RVA: 0x0004777C File Offset: 0x0004597C
		private static void InternalEncodingDataItemSoapMonthDay(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 3;
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 1 + 93;
			A_0 = num;
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x000477E0 File Offset: 0x000459E0
		private static void WaitHandleExtensionsSafeLocalAllocHandle(ref int A_0, ref int A_1, ref int A_2)
		{
			PhotonNetwork.Disconnect();
			A_1 = 0;
		}

		// Token: 0x06000792 RID: 1938 RVA: 0x00047800 File Offset: 0x00045A00
		private static void dwHelpContextgetInvalidCultureId(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			A_0 = 59;
		}

		// Token: 0x06000793 RID: 1939 RVA: 0x00047818 File Offset: 0x00045A18
		private static void ConstrainedCopyMEMORYBASICINFORMATION(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool gripDownR = buttons.gripDownR;
			A_3 = gripDownR;
			int num = ((!A_3) ? 1 : 0) * 9 + 1;
			A_0 = num;
		}

		// Token: 0x06000794 RID: 1940 RVA: 0x00047874 File Offset: 0x00045A74
		private static void AccessControlTypeProcessorArchitecture(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 1;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 1 + 52;
			A_0 = num;
		}

		// Token: 0x06000795 RID: 1941 RVA: 0x000478D8 File Offset: 0x00045AD8
		private static void SmuggledMethodReturnMessageDuplicate(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("PBBV");
			buttons.color(new Color32(230, 127, 102, byte.MaxValue));
			bool flag = t.nindex == 3;
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 1 + 32;
			A_0 = num;
		}

		// Token: 0x06000796 RID: 1942 RVA: 0x0004796C File Offset: 0x00045B6C
		private static void DefinePInvokeMethodReflectionRestrictedMemberAccess(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
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

		// Token: 0x06000797 RID: 1943 RVA: 0x00047B84 File Offset: 0x00045D84
		private static void AccessDeniedCallbackGetTypeComp(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			A_0 = 47;
		}

		// Token: 0x06000798 RID: 1944 RVA: 0x00047B9C File Offset: 0x00045D9C
		private static void GetOffsetFixupHolderList(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("PBBV");
			buttons.color(new Color32(230, 127, 102, byte.MaxValue));
			bool flag = t.nindex == 3;
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 1 + 68;
			A_0 = num;
		}

		// Token: 0x06000799 RID: 1945 RVA: 0x00047C30 File Offset: 0x00045E30
		private static void AuthenticatedtickNow(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
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

		// Token: 0x0600079A RID: 1946 RVA: 0x0004809C File Offset: 0x0004629C
		private static void OperatingSystemMethodDef(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("PBBV");
			buttons.color(new Color32(230, 127, 102, byte.MaxValue));
			bool flag = t.nindex == 3;
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 1 + 56;
			A_0 = num;
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x00048130 File Offset: 0x00046330
		private static void RegisterTrackingHandlerRFCPattern(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
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

		// Token: 0x0600079C RID: 1948 RVA: 0x00048348 File Offset: 0x00046548
		private static void CodeConnectAccessEventKeywords(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
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

		// Token: 0x0600079D RID: 1949 RVA: 0x000487B4 File Offset: 0x000469B4
		private static void ThisCallNoCodeDownload(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 2;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 1 + 42;
			A_0 = num;
		}

		// Token: 0x0600079E RID: 1950 RVA: 0x00048818 File Offset: 0x00046A18
		private static void GetPropertyObjectWithMapTyped(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 1;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 1 + 77;
			A_0 = num;
		}

		// Token: 0x0600079F RID: 1951 RVA: 0x0004887C File Offset: 0x00046A7C
		private static void CmsUtilsParallelInvoke(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			A_0 = 96;
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x00048894 File Offset: 0x00046A94
		private static void IsCancellationRequestedContinuationOptions(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("J3VU");
			buttons.color(new Color32(5, 200, 30, byte.MaxValue));
			A_0 = 59;
		}

		// Token: 0x060007A1 RID: 1953 RVA: 0x000488E0 File Offset: 0x00046AE0
		private static void setPercentNegativePatternTYPEFLAGFAGGREGATABLE(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			c.Prefix(GorillaTagger.Instance.offlineVRRig);
			A_1 = 0;
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x00048908 File Offset: 0x00046B08
		private static void SecurityBindingRedirectsTaskWaitContinuationComplete(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 1;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 1 + 101;
			A_0 = num;
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x0004896C File Offset: 0x00046B6C
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
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,UnityEngine.GameObject&,UnityEngine.GameObject&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&), ref num, ref num2, ref num3, ref flag, ref gameObject, ref gameObject2, ref flag2, ref flag3, ref flag4, ref flag5, fun.LegacyEvidenceListConfigEvents[num]);
			}
			num2 = 97;
		}

		// Token: 0x060007A4 RID: 1956 RVA: 0x000489B0 File Offset: 0x00046BB0
		private static void IDisposableToIClosableAdapterValueFixup(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
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

		// Token: 0x060007A5 RID: 1957 RVA: 0x00048E1C File Offset: 0x0004701C
		private static void NetFrameworkPermissionTokenFactory(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 3;
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 1 + 56;
			A_0 = num;
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x00048E80 File Offset: 0x00047080
		private static void getCompatibleFrameworksDataEXCEPINFO(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
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

		// Token: 0x060007A7 RID: 1959 RVA: 0x00049098 File Offset: 0x00047298
		private static void SizedReferenceObjectHolderList(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 1;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 1 + 16;
			A_0 = num;
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x000490FC File Offset: 0x000472FC
		private static void getCompilationRelaxationsFReplaceable(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
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

		// Token: 0x060007A9 RID: 1961 RVA: 0x00049314 File Offset: 0x00047514
		private static void StrongNameHelpersEmitCalli(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 1;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 1 + 4;
			A_0 = num;
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x00049378 File Offset: 0x00047578
		private static void IBuiltInPermissionGetFieldSigHelper(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			t.nindex = 1;
			bool flag = t.nindex == 1;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 1 + 52;
			A_0 = num;
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x000493E8 File Offset: 0x000475E8
		private static void ContentTypeDependentOSMetadataMinorVersion(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("J3VU");
			buttons.color(new Color32(5, 200, 30, byte.MaxValue));
			A_0 = 35;
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x00049434 File Offset: 0x00047634
		private static void byteBufferEnhancedKeyUsage(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("PBBV");
			buttons.color(new Color32(230, 127, 102, byte.MaxValue));
			bool flag = t.nindex == 3;
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 1 + 93;
			A_0 = num;
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x000494C8 File Offset: 0x000476C8
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
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,UnityEngine.GameObject&,UnityEngine.GameObject&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&), ref num, ref num2, ref num3, ref flag, ref gameObject, ref gameObject2, ref flag2, ref flag3, ref flag4, ref flag5, fun.LegacyEvidenceListConfigEvents[num]);
			}
			num2 = 36;
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x0004950C File Offset: 0x0004770C
		private static void CurrencyWrapperDQ(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 2;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 1 + 66;
			A_0 = num;
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x00049570 File Offset: 0x00047770
		private static void FinalizationHelperAppDomainID(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
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

		// Token: 0x060007B0 RID: 1968 RVA: 0x000499DC File Offset: 0x00047BDC
		private static void oVftOpenPunctuation(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			c.Prefix(GorillaTagger.Instance.offlineVRRig);
			A_1 = 0;
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x00049A04 File Offset: 0x00047C04
		private static void setDataPointerXmlNsForClrTypeWithAssembly(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			c.Prefix(GorillaTagger.Instance.offlineVRRig);
			A_1 = 0;
		}

		// Token: 0x060007B2 RID: 1970 RVA: 0x00049A2C File Offset: 0x00047C2C
		private static void RectangularSpecialNameAttribute(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("DAISY09");
			buttons.color(new Color32(byte.MaxValue, 81, 231, byte.MaxValue));
			bool flag = t.nindex == 2;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 1 + 18;
			A_0 = num;
		}

		// Token: 0x060007B3 RID: 1971 RVA: 0x00049AC0 File Offset: 0x00047CC0
		private static void OverflowAccessAllowedCallback(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			A_0 = 23;
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x00049AD8 File Offset: 0x00047CD8
		private static void CMSSECTIONIDCLRSURROGATESECTIONbody(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 1;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 1 + 89;
			A_0 = num;
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x00049B3C File Offset: 0x00047D3C
		private static void AssemblyNameThreadInterruptedException(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 2;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 1 + 30;
			A_0 = num;
		}

		// Token: 0x060007B6 RID: 1974 RVA: 0x00049BA0 File Offset: 0x00047DA0
		private static void UtcDateTimeFormatJapaneseFirstYearAsANumber(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 1;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 1 + 40;
			A_0 = num;
		}

		// Token: 0x060007B7 RID: 1975 RVA: 0x00049C04 File Offset: 0x00047E04
		private static void TypeNameNativeDispatchMessage(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("PBBV");
			buttons.color(new Color32(230, 127, 102, byte.MaxValue));
			bool flag = t.nindex == 3;
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 1 + 81;
			A_0 = num;
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x00049C98 File Offset: 0x00047E98
		private static void GenerateMaskSetType(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("J3VU");
			buttons.color(new Color32(5, 200, 30, byte.MaxValue));
			A_0 = 96;
		}

		// Token: 0x060007B9 RID: 1977 RVA: 0x00049CE4 File Offset: 0x00047EE4
		private static void TwoLevelFileEnumeratorgetIsNestedFamORAssem(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 2;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 1 + 91;
			A_0 = num;
		}

		// Token: 0x060007BA RID: 1978 RVA: 0x00049D48 File Offset: 0x00047F48
		private static void TYPEFLAGFRESTRICTEDSafeHandleMinusOneIsInvalid(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			A_0 = 108;
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x00049D60 File Offset: 0x00047F60
		private static void getWasUsedmemid(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("J3VU");
			buttons.color(new Color32(5, 200, 30, byte.MaxValue));
			A_0 = 11;
		}

		// Token: 0x060007BC RID: 1980 RVA: 0x00049DAC File Offset: 0x00047FAC
		private static void lpValuegetPayload(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			c.Prefix(GorillaTagger.Instance.offlineVRRig);
			A_1 = 0;
		}

		// Token: 0x060007BD RID: 1981 RVA: 0x00049DD4 File Offset: 0x00047FD4
		private static void setAccessMaskCFB(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool gripDownR = buttons.gripDownR;
			A_3 = gripDownR;
			int num = ((!A_3) ? 1 : 0) * 9 + 86;
			A_0 = num;
		}

		// Token: 0x060007BE RID: 1982 RVA: 0x00049E30 File Offset: 0x00048030
		private static void LongLengthIEnumString(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
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

		// Token: 0x060007BF RID: 1983 RVA: 0x0004A048 File Offset: 0x00048248
		private static void ImportantBinaryMethodReturn(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 2;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 1 + 54;
			A_0 = num;
		}

		// Token: 0x060007C0 RID: 1984 RVA: 0x0004A0AC File Offset: 0x000482AC
		private static void GetDirectoryNamesRuntimeVersion(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 2;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 1 + 6;
			A_0 = num;
		}

		// Token: 0x060007C1 RID: 1985 RVA: 0x0004A110 File Offset: 0x00048310
		private static void GREGORIANUSgetSuiteName(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			t.nindex = 1;
			bool flag = t.nindex == 1;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 1 + 89;
			A_0 = num;
		}

		// Token: 0x060007C2 RID: 1986 RVA: 0x0004A180 File Offset: 0x00048380
		private static void GetSourceStartEndGetRuntimeFieldHandleFromMetadataToken(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("PBBV");
			buttons.color(new Color32(230, 127, 102, byte.MaxValue));
			bool flag = t.nindex == 3;
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 1 + 20;
			A_0 = num;
		}

		// Token: 0x060007C3 RID: 1987 RVA: 0x0004A214 File Offset: 0x00048414
		private static void HasClaimExpired(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 3;
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 1 + 105;
			A_0 = num;
		}

		// Token: 0x060007C4 RID: 1988 RVA: 0x0004A278 File Offset: 0x00048478
		private static void FilterTasksFromWorkItemsdgetChars(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("J3VU");
			buttons.color(new Color32(5, 200, 30, byte.MaxValue));
			A_0 = 84;
		}

		// Token: 0x060007C5 RID: 1989 RVA: 0x0004A2C4 File Offset: 0x000484C4
		private static void SetValueDirectgetIIDGuid(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
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

		// Token: 0x060007C6 RID: 1990 RVA: 0x0004A4DC File Offset: 0x000486DC
		private static void UrlMembershipConditionThrowHelper(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 3;
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 1 + 44;
			A_0 = num;
		}

		// Token: 0x060007C7 RID: 1991 RVA: 0x0004A540 File Offset: 0x00048740
		private static void PermissionSetEntryMaxTokenInfoClass(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
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

		// Token: 0x060007C8 RID: 1992 RVA: 0x0004A9AC File Offset: 0x00048BAC
		private static void SystemAlarmCallbackObjectsetMayLeakOnAbort(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 1;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 1 + 64;
			A_0 = num;
		}

		// Token: 0x060007C9 RID: 1993 RVA: 0x0004AA10 File Offset: 0x00048C10
		private static void CancellationCallbackInfoBrfalseS(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool gripDownR = buttons.gripDownR;
			A_3 = gripDownR;
			int num = ((!A_3) ? 1 : 0) * 9 + 37;
			A_0 = num;
		}

		// Token: 0x060007CA RID: 1994 RVA: 0x0004AA6C File Offset: 0x00048C6C
		private static void getFallbackTokenElevation(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			c.Prefix(GorillaTagger.Instance.offlineVRRig);
			A_1 = 0;
		}

		// Token: 0x060007CB RID: 1995 RVA: 0x0004AA94 File Offset: 0x00048C94
		public static void spam()
		{
			int num = 0;
			int num2 = 0;
			num2 = 0;
			while (num2 != 12)
			{
				int num3;
				bool flag;
				GameObject gameObject;
				GameObject gameObject2;
				bool flag2;
				bool flag3;
				bool flag4;
				bool flag5;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,UnityEngine.GameObject&,UnityEngine.GameObject&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&), ref num, ref num2, ref num3, ref flag, ref gameObject, ref gameObject2, ref flag2, ref flag3, ref flag4, ref flag5, fun.LegacyEvidenceListConfigEvents[num]);
			}
			num2 = 0;
		}

		// Token: 0x060007CC RID: 1996 RVA: 0x0004AAD8 File Offset: 0x00048CD8
		private static void SoapMessageSurrogateSerializationEventHandler(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("J3VU");
			buttons.color(new Color32(5, 200, 30, byte.MaxValue));
			A_0 = 23;
		}

		// Token: 0x060007CD RID: 1997 RVA: 0x0004AB24 File Offset: 0x00048D24
		private static void CreatorsSecurityInfoAbort(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool gripDownR = buttons.gripDownR;
			A_3 = gripDownR;
			int num = ((!A_3) ? 1 : 0) * 9 + 13;
			A_0 = num;
		}

		// Token: 0x060007CE RID: 1998 RVA: 0x0004AB80 File Offset: 0x00048D80
		private static void UmAlQuraEragetCreate(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("PBBV");
			buttons.color(new Color32(230, 127, 102, byte.MaxValue));
			bool flag = t.nindex == 3;
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 1 + 8;
			A_0 = num;
		}

		// Token: 0x060007CF RID: 1999 RVA: 0x0004AC14 File Offset: 0x00048E14
		private static void CMSASSEMBLYDEPLOYMENTFLAGRUNAFTERINSTALLResourceManagerNotCreatingResourceSet(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			t.nindex = 1;
			bool flag = t.nindex == 1;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 1 + 4;
			A_0 = num;
		}

		// Token: 0x060007D0 RID: 2000 RVA: 0x0004AC84 File Offset: 0x00048E84
		private static void TimeZoneUsedSetMessageCtrl(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
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

		// Token: 0x060007D1 RID: 2001 RVA: 0x0004AE9C File Offset: 0x0004909C
		private static void InsertAtDebuggerDisplayAttribute(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 2;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 1 + 103;
			A_0 = num;
		}

		// Token: 0x060007D2 RID: 2002 RVA: 0x0004AF00 File Offset: 0x00049100
		private static void IAAuthenticated(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
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

		// Token: 0x060007D3 RID: 2003 RVA: 0x0004B36C File Offset: 0x0004956C
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
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,UnityEngine.GameObject&,UnityEngine.GameObject&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&), ref num, ref num2, ref num3, ref flag, ref gameObject, ref gameObject2, ref flag2, ref flag3, ref flag4, ref flag5, fun.LegacyEvidenceListConfigEvents[num]);
			}
			num2 = 73;
		}

		// Token: 0x060007D4 RID: 2004 RVA: 0x0004B3B0 File Offset: 0x000495B0
		private static void StarDeploymentId(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("J3VU");
			buttons.color(new Color32(5, 200, 30, byte.MaxValue));
			A_0 = 108;
		}

		// Token: 0x060007D5 RID: 2005 RVA: 0x0004B3FC File Offset: 0x000495FC
		private static void IReferencegetUIContext(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 1;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 1 + 28;
			A_0 = num;
		}

		// Token: 0x060007D6 RID: 2006 RVA: 0x0004B460 File Offset: 0x00049660
		private static void CMSCOMSERVERFLAGoVft(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
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

		// Token: 0x060007D7 RID: 2007 RVA: 0x0004B8CC File Offset: 0x00049ACC
		private static void LMShareIsSignature(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 3;
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 1 + 32;
			A_0 = num;
		}

		// Token: 0x060007D8 RID: 2008 RVA: 0x0004B930 File Offset: 0x00049B30
		private static void getNameClaimTypeConstants(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 2;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 1 + 79;
			A_0 = num;
		}

		// Token: 0x060007D9 RID: 2009 RVA: 0x0004B994 File Offset: 0x00049B94
		private static void ResourceTypeResourcesDependencyEnd(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			t.nindex = 1;
			bool flag = t.nindex == 1;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 1 + 77;
			A_0 = num;
		}

		// Token: 0x060007DA RID: 2010 RVA: 0x0004BA04 File Offset: 0x00049C04
		private static void NativeRegisterRelativegetIsStopped(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("DAISY09");
			buttons.color(new Color32(byte.MaxValue, 81, 231, byte.MaxValue));
			bool flag = t.nindex == 2;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 1 + 91;
			A_0 = num;
		}

		// Token: 0x060007DB RID: 2011 RVA: 0x0004BA98 File Offset: 0x00049C98
		private static void RectangularProgressNotification(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 3;
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 1 + 68;
			A_0 = num;
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x0004BAFC File Offset: 0x00049CFC
		public fun()
		{
			int num = 109;
			int num2 = 109;
			num2 = 109;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,ShibaGTTemplate.Backend.fun), ref num, ref num2, ref num3, this, fun.LegacyEvidenceListConfigEvents[num]);
			}
			num2 = 109;
		}

		// Token: 0x060007DD RID: 2013 RVA: 0x0004BB34 File Offset: 0x00049D34
		private static void SafeThreadHandleSoapOption(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("DAISY09");
			buttons.color(new Color32(byte.MaxValue, 81, 231, byte.MaxValue));
			bool flag = t.nindex == 2;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 1 + 79;
			A_0 = num;
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x0004BBC8 File Offset: 0x00049DC8
		private static void PreserveSigGetHostSuppliedAppDomainEvidenceTypes(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			A_0 = 35;
		}

		// Token: 0x060007DF RID: 2015 RVA: 0x0004BBE0 File Offset: 0x00049DE0
		private static void InTypeFixedCountFlagFastResourceComparer(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool gripDownR = buttons.gripDownR;
			A_3 = gripDownR;
			int num = ((!A_3) ? 1 : 0) * 9 + 49;
			A_0 = num;
		}

		// Token: 0x060007E0 RID: 2016 RVA: 0x0004BC3C File Offset: 0x00049E3C
		private static void getIsAnonymousSerTrace(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 3;
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 1 + 81;
			A_0 = num;
		}

		// Token: 0x060007E1 RID: 2017 RVA: 0x0004BCA0 File Offset: 0x00049EA0
		private static void getIsMethodDefDefineProperty(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			t.nindex = 1;
			bool flag = t.nindex == 1;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 1 + 16;
			A_0 = num;
		}

		// Token: 0x060007E2 RID: 2018 RVA: 0x0004BD10 File Offset: 0x00049F10
		private static void GetUserStringAbstract(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 2;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 1 + 18;
			A_0 = num;
		}

		// Token: 0x060007E3 RID: 2019 RVA: 0x0004BD74 File Offset: 0x00049F74
		private static void RijndaelManagedTransformParallelLoopState(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("DAISY09");
			buttons.color(new Color32(byte.MaxValue, 81, 231, byte.MaxValue));
			bool flag = t.nindex == 2;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 1 + 103;
			A_0 = num;
		}

		// Token: 0x060007E4 RID: 2020 RVA: 0x0004BE08 File Offset: 0x0004A008
		private static void CreateTokenTokenElevationType(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 0), (float)Random.Range(0, 0), (float)Random.Range(0, 0));
			GorillaTagger.Instance.offlineVRRig.enabled = true;
			c.Prefix(GorillaTagger.Instance.offlineVRRig);
			A_1 = 12;
		}

		// Token: 0x060007E5 RID: 2021 RVA: 0x0004C020 File Offset: 0x0004A220
		private static void DateTimeOffsetMarshalerCallingConventions(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			t.nindex = 1;
			bool flag = t.nindex == 1;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 1 + 64;
			A_0 = num;
		}

		// Token: 0x060007E6 RID: 2022 RVA: 0x0004C090 File Offset: 0x0004A290
		private static void GetCustomAttributesDataSynchronizationContextProperties(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("J3VU");
			buttons.color(new Color32(5, 200, 30, byte.MaxValue));
			A_0 = 71;
		}

		// Token: 0x060007E7 RID: 2023 RVA: 0x0004C0DC File Offset: 0x0004A2DC
		private static void ContextAttributessetDigitSubstitution(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			A_0 = 84;
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x0004C0F4 File Offset: 0x0004A2F4
		public static void dwd()
		{
			int num = 72;
			int num2 = 72;
			num2 = 72;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, fun.LegacyEvidenceListConfigEvents[num]);
			}
			num2 = 72;
		}

		// Token: 0x060007E9 RID: 2025 RVA: 0x0004C12C File Offset: 0x0004A32C
		private static void ExpandStringGetAuditRules(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			A_0 = 11;
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x0004C144 File Offset: 0x0004A344
		private static void ConditionalWeakTableExportAsBit(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			c.Prefix(GorillaTagger.Instance.offlineVRRig);
			A_1 = 0;
		}

		// Token: 0x060007EB RID: 2027 RVA: 0x0004C16C File Offset: 0x0004A36C
		private static void cScodesEnvoyInfo(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool gripDownR = buttons.gripDownR;
			A_3 = gripDownR;
			int num = ((!A_3) ? 1 : 0) * 9 + 25;
			A_0 = num;
		}

		// Token: 0x060007EC RID: 2028 RVA: 0x0004C1C8 File Offset: 0x0004A3C8
		private static void EnterpriseServicesHelpergetKeyAvailable(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("DAISY09");
			buttons.color(new Color32(byte.MaxValue, 81, 231, byte.MaxValue));
			bool flag = t.nindex == 2;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 1 + 66;
			A_0 = num;
		}

		// Token: 0x060007ED RID: 2029 RVA: 0x0004C25C File Offset: 0x0004A45C
		private static void EnumComponentsEntryPointNotFoundException(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			t.nindex = 1;
			bool flag = t.nindex == 1;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 1 + 40;
			A_0 = num;
		}

		// Token: 0x060007EE RID: 2030 RVA: 0x0004C2CC File Offset: 0x0004A4CC
		private static void AccountCertAdminsSidgetMaximumAgeUnit(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			t.nindex = 1;
			bool flag = t.nindex == 1;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 1 + 28;
			A_0 = num;
		}

		// Token: 0x060007EF RID: 2031 RVA: 0x0004C33C File Offset: 0x0004A53C
		private static void ExchangeAuthorityIncludeSect(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool gripDownR = buttons.gripDownR;
			A_3 = gripDownR;
			int num = ((!A_3) ? 1 : 0) * 9 + 74;
			A_0 = num;
		}

		// Token: 0x060007F0 RID: 2032 RVA: 0x0004C398 File Offset: 0x0004A598
		private static void CallTypeAsAny(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("DAISY09");
			buttons.color(new Color32(byte.MaxValue, 81, 231, byte.MaxValue));
			bool flag = t.nindex == 2;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 1 + 6;
			A_0 = num;
		}

		// Token: 0x060007F1 RID: 2033 RVA: 0x0004C42C File Offset: 0x0004A62C
		private static void IsHeldGetDeploymentManifestBytes(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			A_0 = 71;
		}

		// Token: 0x060007F2 RID: 2034 RVA: 0x0004C444 File Offset: 0x0004A644
		private static void getLabelCharSetAnsi(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			buttons.name("DAISY09");
			buttons.color(new Color32(byte.MaxValue, 81, 231, byte.MaxValue));
			bool flag = t.nindex == 2;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 1 + 54;
			A_0 = num;
		}

		// Token: 0x060007F3 RID: 2035 RVA: 0x0004C4D8 File Offset: 0x0004A6D8
		private static void AssignDelegateSoapLanguage(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = t.nindex == 3;
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 1 + 8;
			A_0 = num;
		}

		// Token: 0x060007F4 RID: 2036 RVA: 0x0004C53C File Offset: 0x0004A73C
		private static void URLStringIsPreAllocatedDefault(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GameObject A_4, ref GameObject A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9)
		{
			c.Prefix(GorillaTagger.Instance.offlineVRRig);
			A_1 = 0;
		}

		// Token: 0x060007F5 RID: 2037 RVA: 0x0004C564 File Offset: 0x0004A764
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
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,UnityEngine.GameObject&,UnityEngine.GameObject&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&), ref num, ref num2, ref num3, ref flag, ref gameObject, ref gameObject2, ref flag2, ref flag3, ref flag4, ref flag5, fun.LegacyEvidenceListConfigEvents[num]);
			}
			num2 = 60;
		}

		// Token: 0x060007F6 RID: 2038 RVA: 0x0004C5A8 File Offset: 0x0004A7A8
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
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,UnityEngine.GameObject&,UnityEngine.GameObject&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&), ref num, ref num2, ref num3, ref flag, ref gameObject, ref gameObject2, ref flag2, ref flag3, ref flag4, ref flag5, fun.LegacyEvidenceListConfigEvents[num]);
			}
			num2 = 12;
		}

		// Token: 0x060007F7 RID: 2039 RVA: 0x0004C5EC File Offset: 0x0004A7EC
		// Note: this type is marked as 'beforefieldinit'.
		static fun()
		{
			fun.TYPEFLAGFOLEAUTOMATIONetwLog();
		}

		// Token: 0x060007F8 RID: 2040 RVA: 0x0004C600 File Offset: 0x0004A800
		private static void TYPEFLAGFOLEAUTOMATIONetwLog()
		{
			fun.LegacyEvidenceListConfigEvents = new IntPtr[110];
			fun.LegacyEvidenceListConfigEvents[0] = ldftn(ConstrainedCopyMEMORYBASICINFORMATION);
			fun.LegacyEvidenceListConfigEvents[1] = ldftn(FinalizationHelperAppDomainID);
			fun.LegacyEvidenceListConfigEvents[2] = ldftn(CMSASSEMBLYDEPLOYMENTFLAGRUNAFTERINSTALLResourceManagerNotCreatingResourceSet);
			fun.LegacyEvidenceListConfigEvents[3] = ldftn(StrongNameHelpersEmitCalli);
			fun.LegacyEvidenceListConfigEvents[4] = ldftn(CallTypeAsAny);
			fun.LegacyEvidenceListConfigEvents[5] = ldftn(GetDirectoryNamesRuntimeVersion);
			fun.LegacyEvidenceListConfigEvents[6] = ldftn(UmAlQuraEragetCreate);
			fun.LegacyEvidenceListConfigEvents[7] = ldftn(AssignDelegateSoapLanguage);
			fun.LegacyEvidenceListConfigEvents[8] = ldftn(getWasUsedmemid);
			fun.LegacyEvidenceListConfigEvents[9] = ldftn(ExpandStringGetAuditRules);
			fun.LegacyEvidenceListConfigEvents[10] = ldftn(CreateTokenTokenElevationType);
			fun.LegacyEvidenceListConfigEvents[11] = ldftn(AsyncCausalityStatusSetOffset);
			fun.LegacyEvidenceListConfigEvents[12] = ldftn(CreatorsSecurityInfoAbort);
			fun.LegacyEvidenceListConfigEvents[13] = ldftn(GCHandleCookieTableAssertFailure);
			fun.LegacyEvidenceListConfigEvents[14] = ldftn(getIsMethodDefDefineProperty);
			fun.LegacyEvidenceListConfigEvents[15] = ldftn(SizedReferenceObjectHolderList);
			fun.LegacyEvidenceListConfigEvents[16] = ldftn(RectangularSpecialNameAttribute);
			fun.LegacyEvidenceListConfigEvents[17] = ldftn(GetUserStringAbstract);
			fun.LegacyEvidenceListConfigEvents[18] = ldftn(GetSourceStartEndGetRuntimeFieldHandleFromMetadataToken);
			fun.LegacyEvidenceListConfigEvents[19] = ldftn(UserNameSpaceIEnumSTOREDEPLOYMENTMETADATAPROPERTY);
			fun.LegacyEvidenceListConfigEvents[20] = ldftn(SoapMessageSurrogateSerializationEventHandler);
			fun.LegacyEvidenceListConfigEvents[21] = ldftn(OverflowAccessAllowedCallback);
			fun.LegacyEvidenceListConfigEvents[22] = ldftn(LongLengthIEnumString);
			fun.LegacyEvidenceListConfigEvents[23] = ldftn(oVftOpenPunctuation);
			fun.LegacyEvidenceListConfigEvents[24] = ldftn(cScodesEnvoyInfo);
			fun.LegacyEvidenceListConfigEvents[25] = ldftn(LetterNumberLoadWithPartialName);
			fun.LegacyEvidenceListConfigEvents[26] = ldftn(AccountCertAdminsSidgetMaximumAgeUnit);
			fun.LegacyEvidenceListConfigEvents[27] = ldftn(IReferencegetUIContext);
			fun.LegacyEvidenceListConfigEvents[28] = ldftn(NetworkServiceSidCallConvThiscall);
			fun.LegacyEvidenceListConfigEvents[29] = ldftn(AssemblyNameThreadInterruptedException);
			fun.LegacyEvidenceListConfigEvents[30] = ldftn(SmuggledMethodReturnMessageDuplicate);
			fun.LegacyEvidenceListConfigEvents[31] = ldftn(LMShareIsSignature);
			fun.LegacyEvidenceListConfigEvents[32] = ldftn(ContentTypeDependentOSMetadataMinorVersion);
			fun.LegacyEvidenceListConfigEvents[33] = ldftn(PreserveSigGetHostSuppliedAppDomainEvidenceTypes);
			fun.LegacyEvidenceListConfigEvents[34] = ldftn(TimeZoneUsedSetMessageCtrl);
			fun.LegacyEvidenceListConfigEvents[35] = ldftn(setPercentNegativePatternTYPEFLAGFAGGREGATABLE);
			fun.LegacyEvidenceListConfigEvents[36] = ldftn(CancellationCallbackInfoBrfalseS);
			fun.LegacyEvidenceListConfigEvents[37] = ldftn(IAAuthenticated);
			fun.LegacyEvidenceListConfigEvents[38] = ldftn(EnumComponentsEntryPointNotFoundException);
			fun.LegacyEvidenceListConfigEvents[39] = ldftn(UtcDateTimeFormatJapaneseFirstYearAsANumber);
			fun.LegacyEvidenceListConfigEvents[40] = ldftn(QueryChangeIDGetAbbreviatedDayName);
			fun.LegacyEvidenceListConfigEvents[41] = ldftn(ThisCallNoCodeDownload);
			fun.LegacyEvidenceListConfigEvents[42] = ldftn(setQuotaMaxMethodImplVal);
			fun.LegacyEvidenceListConfigEvents[43] = ldftn(UrlMembershipConditionThrowHelper);
			fun.LegacyEvidenceListConfigEvents[44] = ldftn(APPXFLAGSAPICHECKReflectionRestrictedMemberAccess);
			fun.LegacyEvidenceListConfigEvents[45] = ldftn(AccessDeniedCallbackGetTypeComp);
			fun.LegacyEvidenceListConfigEvents[46] = ldftn(DefinePInvokeMethodReflectionRestrictedMemberAccess);
			fun.LegacyEvidenceListConfigEvents[47] = ldftn(lpValuegetPayload);
			fun.LegacyEvidenceListConfigEvents[48] = ldftn(InTypeFixedCountFlagFastResourceComparer);
			fun.LegacyEvidenceListConfigEvents[49] = ldftn(PermissionSetEntryMaxTokenInfoClass);
			fun.LegacyEvidenceListConfigEvents[50] = ldftn(IBuiltInPermissionGetFieldSigHelper);
			fun.LegacyEvidenceListConfigEvents[51] = ldftn(AccessControlTypeProcessorArchitecture);
			fun.LegacyEvidenceListConfigEvents[52] = ldftn(getLabelCharSetAnsi);
			fun.LegacyEvidenceListConfigEvents[53] = ldftn(ImportantBinaryMethodReturn);
			fun.LegacyEvidenceListConfigEvents[54] = ldftn(OperatingSystemMethodDef);
			fun.LegacyEvidenceListConfigEvents[55] = ldftn(NetFrameworkPermissionTokenFactory);
			fun.LegacyEvidenceListConfigEvents[56] = ldftn(IsCancellationRequestedContinuationOptions);
			fun.LegacyEvidenceListConfigEvents[57] = ldftn(dwHelpContextgetInvalidCultureId);
			fun.LegacyEvidenceListConfigEvents[58] = ldftn(RegisterTrackingHandlerRFCPattern);
			fun.LegacyEvidenceListConfigEvents[59] = ldftn(URLStringIsPreAllocatedDefault);
			fun.LegacyEvidenceListConfigEvents[60] = ldftn(PrimaryIdentitySelectorCustomAttributeExtensions);
			fun.LegacyEvidenceListConfigEvents[61] = ldftn(AuthenticatedtickNow);
			fun.LegacyEvidenceListConfigEvents[62] = ldftn(DateTimeOffsetMarshalerCallingConventions);
			fun.LegacyEvidenceListConfigEvents[63] = ldftn(SystemAlarmCallbackObjectsetMayLeakOnAbort);
			fun.LegacyEvidenceListConfigEvents[64] = ldftn(EnterpriseServicesHelpergetKeyAvailable);
			fun.LegacyEvidenceListConfigEvents[65] = ldftn(CurrencyWrapperDQ);
			fun.LegacyEvidenceListConfigEvents[66] = ldftn(GetOffsetFixupHolderList);
			fun.LegacyEvidenceListConfigEvents[67] = ldftn(RectangularProgressNotification);
			fun.LegacyEvidenceListConfigEvents[68] = ldftn(GetCustomAttributesDataSynchronizationContextProperties);
			fun.LegacyEvidenceListConfigEvents[69] = ldftn(IsHeldGetDeploymentManifestBytes);
			fun.LegacyEvidenceListConfigEvents[70] = ldftn(SetValueDirectgetIIDGuid);
			fun.LegacyEvidenceListConfigEvents[71] = ldftn(getFallbackTokenElevation);
			fun.LegacyEvidenceListConfigEvents[72] = ldftn(WaitHandleExtensionsSafeLocalAllocHandle);
			fun.LegacyEvidenceListConfigEvents[73] = ldftn(ExchangeAuthorityIncludeSect);
			fun.LegacyEvidenceListConfigEvents[74] = ldftn(CodeConnectAccessEventKeywords);
			fun.LegacyEvidenceListConfigEvents[75] = ldftn(ResourceTypeResourcesDependencyEnd);
			fun.LegacyEvidenceListConfigEvents[76] = ldftn(GetPropertyObjectWithMapTyped);
			fun.LegacyEvidenceListConfigEvents[77] = ldftn(SafeThreadHandleSoapOption);
			fun.LegacyEvidenceListConfigEvents[78] = ldftn(getNameClaimTypeConstants);
			fun.LegacyEvidenceListConfigEvents[79] = ldftn(TypeNameNativeDispatchMessage);
			fun.LegacyEvidenceListConfigEvents[80] = ldftn(getIsAnonymousSerTrace);
			fun.LegacyEvidenceListConfigEvents[81] = ldftn(FilterTasksFromWorkItemsdgetChars);
			fun.LegacyEvidenceListConfigEvents[82] = ldftn(ContextAttributessetDigitSubstitution);
			fun.LegacyEvidenceListConfigEvents[83] = ldftn(getCompilationRelaxationsFReplaceable);
			fun.LegacyEvidenceListConfigEvents[84] = ldftn(ConditionalWeakTableExportAsBit);
			fun.LegacyEvidenceListConfigEvents[85] = ldftn(setAccessMaskCFB);
			fun.LegacyEvidenceListConfigEvents[86] = ldftn(IDisposableToIClosableAdapterValueFixup);
			fun.LegacyEvidenceListConfigEvents[87] = ldftn(GREGORIANUSgetSuiteName);
			fun.LegacyEvidenceListConfigEvents[88] = ldftn(CMSSECTIONIDCLRSURROGATESECTIONbody);
			fun.LegacyEvidenceListConfigEvents[89] = ldftn(NativeRegisterRelativegetIsStopped);
			fun.LegacyEvidenceListConfigEvents[90] = ldftn(TwoLevelFileEnumeratorgetIsNestedFamORAssem);
			fun.LegacyEvidenceListConfigEvents[91] = ldftn(byteBufferEnhancedKeyUsage);
			fun.LegacyEvidenceListConfigEvents[92] = ldftn(InternalEncodingDataItemSoapMonthDay);
			fun.LegacyEvidenceListConfigEvents[93] = ldftn(GenerateMaskSetType);
			fun.LegacyEvidenceListConfigEvents[94] = ldftn(CmsUtilsParallelInvoke);
			fun.LegacyEvidenceListConfigEvents[95] = ldftn(getCompatibleFrameworksDataEXCEPINFO);
			fun.LegacyEvidenceListConfigEvents[96] = ldftn(setDataPointerXmlNsForClrTypeWithAssembly);
			fun.LegacyEvidenceListConfigEvents[97] = ldftn(StrongNameIdentityPermissionNoteChangeTime);
			fun.LegacyEvidenceListConfigEvents[98] = ldftn(CMSCOMSERVERFLAGoVft);
			fun.LegacyEvidenceListConfigEvents[99] = ldftn(getIsOptionalgetWindowTop);
			fun.LegacyEvidenceListConfigEvents[100] = ldftn(SecurityBindingRedirectsTaskWaitContinuationComplete);
			fun.LegacyEvidenceListConfigEvents[101] = ldftn(RijndaelManagedTransformParallelLoopState);
			fun.LegacyEvidenceListConfigEvents[102] = ldftn(InsertAtDebuggerDisplayAttribute);
			fun.LegacyEvidenceListConfigEvents[103] = ldftn(RandomAccesssetKeySize);
			fun.LegacyEvidenceListConfigEvents[104] = ldftn(HasClaimExpired);
			fun.LegacyEvidenceListConfigEvents[105] = ldftn(StarDeploymentId);
			fun.LegacyEvidenceListConfigEvents[106] = ldftn(TYPEFLAGFRESTRICTEDSafeHandleMinusOneIsInvalid);
			fun.LegacyEvidenceListConfigEvents[107] = ldftn(IsGenericMethodDefinitionCopyToAsync);
			fun.LegacyEvidenceListConfigEvents[108] = ldftn(GetAsyncResultRedirectedGuid);
			fun.LegacyEvidenceListConfigEvents[109] = ldftn(ISectionWithReferenceIdentityKeyMoveNextRunner);
		}

		// Token: 0x04000096 RID: 150
		private static IntPtr[] LegacyEvidenceListConfigEvents;
	}
}
