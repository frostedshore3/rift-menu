using System;
using HarmonyLib;
using UnityEngine;

// Token: 0x02000002 RID: 2
[HarmonyPatch(typeof(GameObject))]
[HarmonyPatch("CreatePrimitive", 0)]
internal class zz : MonoBehaviour
{
	// Token: 0x0600000B RID: 11 RVA: 0x000030DC File Offset: 0x000012DC
	private static void ConfigurationBytesValueFileAccess(ref int A_0, ref int A_1, ref int A_2, GameObject A_3)
	{
		A_3.GetComponent<Renderer>().material.shader = Shader.Find("GorillaTag/UberShader");
		A_1 = 2;
	}

	// Token: 0x0600000C RID: 12 RVA: 0x00003114 File Offset: 0x00001314
	private static void SynchronousAsyncResultFixedElementField(ref int A_0, ref int A_1, ref int A_2, zz A_3)
	{
		A_3..ctor();
		A_1 = 0;
	}

	// Token: 0x0600000D RID: 13 RVA: 0x00003138 File Offset: 0x00001338
	public zz()
	{
		int num = 1;
		int num2 = 1;
		num2 = 1;
		while (num2 != 0)
		{
			int num3;
			calli(System.Void(System.Int32&,System.Int32&,System.Int32&,zz), ref num, ref num2, ref num3, this, zz.InTypeChainFlagSetByIndex[num]);
		}
		num2 = 1;
	}

	// Token: 0x0600000E RID: 14 RVA: 0x0000316C File Offset: 0x0000136C
	private static void Postfix(GameObject __result)
	{
		int num = 0;
		int num2 = 0;
		num2 = 0;
		while (num2 != 2)
		{
			int num3;
			calli(System.Void(System.Int32&,System.Int32&,System.Int32&,UnityEngine.GameObject), ref num, ref num2, ref num3, __result, zz.InTypeChainFlagSetByIndex[num]);
		}
		num2 = 0;
	}

	// Token: 0x0600000F RID: 15 RVA: 0x000031A0 File Offset: 0x000013A0
	// Note: this type is marked as 'beforefieldinit'.
	static zz()
	{
		zz.BreakStrongNameIdentityPermission();
	}

	// Token: 0x06000010 RID: 16 RVA: 0x000031B4 File Offset: 0x000013B4
	private static void BreakStrongNameIdentityPermission()
	{
		zz.InTypeChainFlagSetByIndex = new IntPtr[2];
		zz.InTypeChainFlagSetByIndex[0] = ldftn(ConfigurationBytesValueFileAccess);
		zz.InTypeChainFlagSetByIndex[1] = ldftn(SynchronousAsyncResultFixedElementField);
	}

	// Token: 0x04000004 RID: 4
	private static IntPtr[] InTypeChainFlagSetByIndex;
}
