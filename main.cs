using System;

namespace ShibaGTTemplate.UI
{
	// Token: 0x0200000C RID: 12
	internal class main
	{
		// Token: 0x060000A2 RID: 162 RVA: 0x00006270 File Offset: 0x00004470
		private static void TaskStatusUCOMIEnumMoniker(ref int A_0, ref int A_1, ref int A_2, main A_3)
		{
			A_3..ctor();
			A_1 = 2;
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00006294 File Offset: 0x00004494
		public main()
		{
			int num = 0;
			int num2 = 0;
			num2 = 0;
			while (num2 != 2)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,ShibaGTTemplate.UI.main), ref num, ref num2, ref num3, this, main.BindToMonikerRectArray[num]);
			}
			num2 = 0;
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x000062C8 File Offset: 0x000044C8
		// Note: this type is marked as 'beforefieldinit'.
		static main()
		{
			main.getStreamingContextgetFilterLevel();
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x000062DC File Offset: 0x000044DC
		private static void getStreamingContextgetFilterLevel()
		{
			main.BindToMonikerRectArray = new IntPtr[1];
			main.BindToMonikerRectArray[0] = ldftn(TaskStatusUCOMIEnumMoniker);
		}

		// Token: 0x04000033 RID: 51
		private static IntPtr[] BindToMonikerRectArray;
	}
}
