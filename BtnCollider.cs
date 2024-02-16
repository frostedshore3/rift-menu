using System;
using ShibaGTTemplate.UI;
using UnityEngine;

// Token: 0x02000003 RID: 3
internal class BtnCollider : MonoBehaviour
{
	// Token: 0x06000011 RID: 17 RVA: 0x000031F4 File Offset: 0x000013F4
	private void OnTriggerEnter(Collider collider)
	{
		int num = 0;
		int num2 = 0;
		num2 = 0;
		while (num2 != 5)
		{
			int num3;
			bool flag;
			calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,UnityEngine.Collider,BtnCollider), ref num, ref num2, ref num3, ref flag, collider, this, BtnCollider.TraceLoggingTypeInfoResourceConsumptionAttribute[num]);
		}
		num2 = 0;
	}

	// Token: 0x06000012 RID: 18 RVA: 0x0000322C File Offset: 0x0000142C
	private static void SoapTypeAttributeToInt(ref int A_0, ref int A_1, ref int A_2, BtnCollider A_3)
	{
		A_3..ctor();
		A_1 = 0;
	}

	// Token: 0x06000013 RID: 19 RVA: 0x00003250 File Offset: 0x00001450
	private static void DescriptionMetadataEntryPrefixCode(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, Collider A_4, BtnCollider A_5)
	{
		int num = ((Time.frameCount < BtnCollider.framePressCooldown + 20) * true + true) ? 1 : 0;
		A_0 = num;
	}

	// Token: 0x06000014 RID: 20 RVA: 0x0000328C File Offset: 0x0000148C
	private static void setUserQuotaGetValue(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, Collider A_4, BtnCollider A_5)
	{
		GorillaTagger.Instance.offlineVRRig.PlayHandTapLocal(66, false, 5f);
		GorillaTagger.Instance.StartVibration(false, 0.01f, 0.001f);
		buttons.Toggle(A_5.relatedText);
		BtnCollider.framePressCooldown = Time.frameCount;
		A_1 = 5;
	}

	// Token: 0x06000015 RID: 21 RVA: 0x000032F8 File Offset: 0x000014F8
	private static void EuropeanNumberInternalStore(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, Collider A_4, BtnCollider A_5)
	{
		bool flag = false;
		A_3 = flag;
		int num = ((!A_3) ? 1 : 0) * 1 + 3;
		A_0 = num;
	}

	// Token: 0x06000016 RID: 22 RVA: 0x00003354 File Offset: 0x00001554
	private static void getPerMilleSymbolgetIgnorePortablePDBsInStackTraces(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, Collider A_4, BtnCollider A_5)
	{
		A_1 = 5;
	}

	// Token: 0x06000017 RID: 23 RVA: 0x0000336C File Offset: 0x0000156C
	public BtnCollider()
	{
		int num = 5;
		int num2 = 5;
		num2 = 5;
		while (num2 != 0)
		{
			int num3;
			calli(System.Void(System.Int32&,System.Int32&,System.Int32&,BtnCollider), ref num, ref num2, ref num3, this, BtnCollider.TraceLoggingTypeInfoResourceConsumptionAttribute[num]);
		}
		num2 = 5;
	}

	// Token: 0x06000018 RID: 24 RVA: 0x000033A0 File Offset: 0x000015A0
	private static void GetSetMethodRsaAny(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, Collider A_4, BtnCollider A_5)
	{
		bool flag = A_4.name == "buttonPresser";
		A_3 = flag;
		int num = ((!A_3) ? 1 : 0) * 1 + 3;
		A_0 = num;
	}

	// Token: 0x06000019 RID: 25 RVA: 0x00003410 File Offset: 0x00001610
	// Note: this type is marked as 'beforefieldinit'.
	static BtnCollider()
	{
		BtnCollider.getRemoveMethodSetByIndex();
	}

	// Token: 0x0600001A RID: 26 RVA: 0x00003424 File Offset: 0x00001624
	private static void getRemoveMethodSetByIndex()
	{
		BtnCollider.TraceLoggingTypeInfoResourceConsumptionAttribute = new IntPtr[6];
		BtnCollider.TraceLoggingTypeInfoResourceConsumptionAttribute[0] = ldftn(DescriptionMetadataEntryPrefixCode);
		BtnCollider.TraceLoggingTypeInfoResourceConsumptionAttribute[1] = ldftn(GetSetMethodRsaAny);
		BtnCollider.TraceLoggingTypeInfoResourceConsumptionAttribute[2] = ldftn(EuropeanNumberInternalStore);
		BtnCollider.TraceLoggingTypeInfoResourceConsumptionAttribute[3] = ldftn(setUserQuotaGetValue);
		BtnCollider.TraceLoggingTypeInfoResourceConsumptionAttribute[4] = ldftn(getPerMilleSymbolgetIgnorePortablePDBsInStackTraces);
		BtnCollider.TraceLoggingTypeInfoResourceConsumptionAttribute[5] = ldftn(SoapTypeAttributeToInt);
	}

	// Token: 0x04000005 RID: 5
	public static int framePressCooldown;

	// Token: 0x04000006 RID: 6
	public string relatedText;

	// Token: 0x04000007 RID: 7
	private static IntPtr[] TraceLoggingTypeInfoResourceConsumptionAttribute;
}
