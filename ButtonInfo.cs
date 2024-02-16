using System;

namespace ShibaGTTemplate.UI
{
	// Token: 0x0200000D RID: 13
	public class ButtonInfo
	{
		// Token: 0x060000A6 RID: 166 RVA: 0x0000630C File Offset: 0x0000450C
		private static void BinaryFormatterPopipopipopi(ref int A_0, ref int A_1, ref int A_2, ButtonInfo A_3)
		{
			A_3.buttonText = "Error";
			A_3.method = null;
			A_3.disableMethod = null;
			A_3.enabled = new bool?(false);
			A_3.toolTip = "This button doesn't have a tooltip/tutorial";
			A_3..ctor();
			A_1 = 2;
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00006370 File Offset: 0x00004570
		public ButtonInfo()
		{
			int num = 0;
			int num2 = 0;
			num2 = 0;
			while (num2 != 2)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,ShibaGTTemplate.UI.ButtonInfo), ref num, ref num2, ref num3, this, ButtonInfo.ProvideAppDomainEvidencegetEndOfStream[num]);
			}
			num2 = 0;
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x000063A4 File Offset: 0x000045A4
		// Note: this type is marked as 'beforefieldinit'.
		static ButtonInfo()
		{
			ButtonInfo.ConcurrentDictionaryAcquiringAllLocksgetCancellationToken();
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x000063B8 File Offset: 0x000045B8
		private static void ConcurrentDictionaryAcquiringAllLocksgetCancellationToken()
		{
			ButtonInfo.ProvideAppDomainEvidencegetEndOfStream = new IntPtr[1];
			ButtonInfo.ProvideAppDomainEvidencegetEndOfStream[0] = ldftn(BinaryFormatterPopipopipopi);
		}

		// Token: 0x04000034 RID: 52
		public string buttonText;

		// Token: 0x04000035 RID: 53
		public Action method;

		// Token: 0x04000036 RID: 54
		public Action disableMethod;

		// Token: 0x04000037 RID: 55
		public bool? enabled;

		// Token: 0x04000038 RID: 56
		public string toolTip;

		// Token: 0x04000039 RID: 57
		private static IntPtr[] ProvideAppDomainEvidencegetEndOfStream;
	}
}
