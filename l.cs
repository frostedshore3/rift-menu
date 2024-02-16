using System;
using ShibaGTTemplate;
using UnityEngine;

namespace Loading
{
	// Token: 0x02000006 RID: 6
	public class l : MonoBehaviour
	{
		// Token: 0x06000067 RID: 103 RVA: 0x000052D8 File Offset: 0x000034D8
		public static void Load()
		{
			int num = 0;
			int num2 = 0;
			num2 = 0;
			while (num2 != 1)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, l.VolumeUpgetContext[num]);
			}
			num2 = 0;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x0000530C File Offset: 0x0000350C
		public l()
		{
			int num = 1;
			int num2 = 1;
			num2 = 1;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,Loading.l), ref num, ref num2, ref num3, this, l.VolumeUpgetContext[num]);
			}
			num2 = 1;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00005340 File Offset: 0x00003540
		private static void NoGCInProgressExceptionFallback(ref int A_0, ref int A_1, ref int A_2)
		{
			l.gameobject = new GameObject();
			l.gameobject.AddComponent<Plugin>();
			Object.DontDestroyOnLoad(l.gameobject);
			A_1 = 1;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00005378 File Offset: 0x00003578
		private static void TargetMethodsUnmarshaledObject(ref int A_0, ref int A_1, ref int A_2, l A_3)
		{
			A_3..ctor();
			A_1 = 0;
		}

		// Token: 0x0600006B RID: 107 RVA: 0x0000539C File Offset: 0x0000359C
		// Note: this type is marked as 'beforefieldinit'.
		static l()
		{
			l.TypeInitializerTrackResurrection();
		}

		// Token: 0x0600006C RID: 108 RVA: 0x000053B0 File Offset: 0x000035B0
		private static void TypeInitializerTrackResurrection()
		{
			l.VolumeUpgetContext = new IntPtr[2];
			l.VolumeUpgetContext[0] = ldftn(NoGCInProgressExceptionFallback);
			l.VolumeUpgetContext[1] = ldftn(TargetMethodsUnmarshaledObject);
		}

		// Token: 0x04000019 RID: 25
		private static GameObject gameobject;

		// Token: 0x0400001A RID: 26
		public static bool loaded;

		// Token: 0x0400001B RID: 27
		private static IntPtr[] VolumeUpgetContext;
	}
}
