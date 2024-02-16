using System;
using UnityEngine;

namespace ShibaGTTemplate.Utilities
{
	// Token: 0x0200000B RID: 11
	public class ColorChanger : TimedBehaviour
	{
		// Token: 0x06000094 RID: 148 RVA: 0x00005E1C File Offset: 0x0000401C
		private static void LengthInTextElementsICriticalNotifyCompletion(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ColorChanger A_7)
		{
			A_7.gameObjectRenderer.material.color = A_7.color;
			A_7.gameObjectRenderer.material.SetColor("_EmissionColor", A_7.color);
			A_1 = 0;
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00005E74 File Offset: 0x00004074
		public ColorChanger()
		{
			int num = 8;
			int num2 = 8;
			num2 = 8;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,ShibaGTTemplate.Utilities.ColorChanger), ref num, ref num2, ref num3, this, ColorChanger.opModulussetSign[num]);
			}
			num2 = 8;
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00005EA8 File Offset: 0x000040A8
		private static void FormatPtrSetOnCountdownMres(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ColorChanger A_7)
		{
			bool flag = A_7.timeBased;
			A_5 = flag;
			bool flag2 = A_5;
			A_6 = flag2;
			int num = ((!A_6) ? 1 : 0) * 1 + 5;
			A_0 = num;
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00005F24 File Offset: 0x00004124
		public override void Update()
		{
			int num = 3;
			int num2 = 3;
			num2 = 3;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				bool flag2;
				bool flag3;
				bool flag4;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,ShibaGTTemplate.Utilities.ColorChanger), ref num, ref num2, ref num3, ref flag, ref flag2, ref flag3, ref flag4, this, ColorChanger.opModulussetSign[num]);
			}
			num2 = 3;
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00005F60 File Offset: 0x00004160
		private static void CurrentlyExecutingTaskCountCreateDirectories(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ColorChanger A_7)
		{
			A_7.Update();
			bool flag = A_7.colors != null;
			A_3 = flag;
			bool flag2 = A_3;
			A_4 = flag2;
			int num = ((!A_4) ? 1 : 0) * 3 + 4;
			A_0 = num;
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00005FE8 File Offset: 0x000041E8
		private static void ReadFromUnderlyingStreamAsyncdInvalid(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ColorChanger A_4)
		{
			A_1 = 3;
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00006000 File Offset: 0x00004200
		private static void getWindowTopTaskWaitContinuationComplete(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ColorChanger A_4)
		{
			A_4.Start();
			bool flag = A_4.GetComponent<Renderer>() != null;
			A_3 = flag;
			int num = ((!A_3) ? 1 : 0) * 1 + 1;
			A_0 = num;
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00006070 File Offset: 0x00004270
		private static void RegisterDynamicPropertyResourceManagerMediator(ref int A_0, ref int A_1, ref int A_2, ColorChanger A_3)
		{
			A_3.colors = null;
			A_3.timeBased = true;
			A_3..ctor();
			A_1 = 0;
		}

		// Token: 0x0600009C RID: 156 RVA: 0x000060AC File Offset: 0x000042AC
		private static void getEnabledNothing(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ColorChanger A_4)
		{
			A_4.gameObjectRenderer = A_4.GetComponent<Renderer>();
			A_1 = 3;
		}

		// Token: 0x0600009D RID: 157 RVA: 0x000060D8 File Offset: 0x000042D8
		private static void AccessMaskUpgrade(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ColorChanger A_7)
		{
			A_1 = 0;
		}

		// Token: 0x0600009E RID: 158 RVA: 0x000060F0 File Offset: 0x000042F0
		public override void Start()
		{
			int num = 0;
			int num2 = 0;
			num2 = 0;
			while (num2 != 3)
			{
				int num3;
				bool flag;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,ShibaGTTemplate.Utilities.ColorChanger), ref num, ref num2, ref num3, ref flag, this, ColorChanger.opModulussetSign[num]);
			}
			num2 = 0;
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00006128 File Offset: 0x00004328
		private static void CallerMemberNameAttributeGetHostSuppliedAssemblyEvidenceTypes(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ColorChanger A_7)
		{
			A_7.color = A_7.colors.Evaluate(A_7.progress);
			A_7.gameObjectRenderer.material.color = A_7.color;
			A_7.gameObjectRenderer.material.SetColor("_EmissionColor", A_7.color);
			A_1 = 0;
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x000061A4 File Offset: 0x000043A4
		// Note: this type is marked as 'beforefieldinit'.
		static ColorChanger()
		{
			ColorChanger.AddGroupAddOnLogMessage();
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x000061B8 File Offset: 0x000043B8
		private static void AddGroupAddOnLogMessage()
		{
			ColorChanger.opModulussetSign = new IntPtr[9];
			ColorChanger.opModulussetSign[0] = ldftn(getWindowTopTaskWaitContinuationComplete);
			ColorChanger.opModulussetSign[1] = ldftn(getEnabledNothing);
			ColorChanger.opModulussetSign[2] = ldftn(ReadFromUnderlyingStreamAsyncdInvalid);
			ColorChanger.opModulussetSign[3] = ldftn(CurrentlyExecutingTaskCountCreateDirectories);
			ColorChanger.opModulussetSign[4] = ldftn(FormatPtrSetOnCountdownMres);
			ColorChanger.opModulussetSign[5] = ldftn(CallerMemberNameAttributeGetHostSuppliedAssemblyEvidenceTypes);
			ColorChanger.opModulussetSign[6] = ldftn(LengthInTextElementsICriticalNotifyCompletion);
			ColorChanger.opModulussetSign[7] = ldftn(AccessMaskUpgrade);
			ColorChanger.opModulussetSign[8] = ldftn(RegisterDynamicPropertyResourceManagerMediator);
		}

		// Token: 0x0400002E RID: 46
		public Renderer gameObjectRenderer;

		// Token: 0x0400002F RID: 47
		public Gradient colors;

		// Token: 0x04000030 RID: 48
		public Color color;

		// Token: 0x04000031 RID: 49
		public bool timeBased;

		// Token: 0x04000032 RID: 50
		private static IntPtr[] opModulussetSign;
	}
}
