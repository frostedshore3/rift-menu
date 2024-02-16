using System;

// Token: 0x02000001 RID: 1
internal class <Module>
{
	// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
	unsafe static <Module>()
	{
		<Module>.MathSymbolGetHashFromAssemblyFileW();
		int num = 1;
		int num2 = num;
		int num3 = num2 * 4;
		int num4 = num2 * 8;
		byte[] array = new byte[5];
		object[] array2 = new object[5];
		int[] array3 = new int[5];
		long[] array5;
		fixed (long[] array4 = array5 = new long[5])
		{
			object[] array6 = new object[8];
			array6[0] = <Module>.MemoryBarrierAddNonscalar;
			byte* ptr = (byte*)(&EntryPointEntryFieldIdIsAssembly.JitImmediategetScheduledConcurrent);
			int num5;
			while (num5 != 1)
			{
				byte b = (byte)(*(sbyte*)ptr);
				ptr++;
				int num6;
				if (b >= 1 && b <= 32)
				{
					if (16 >= b)
					{
						if (16 <= b)
						{
							((object[])array2[num6 - 3])[*(int*)(&array5[num6 - 2])] = array2[num6 - 1];
							num6 -= 3;
							continue;
						}
						if (8 >= b)
						{
							if (8 <= b)
							{
								array[num6] = 13;
								*(int*)(&array5[num6]) = *(int*)(ptr + num3);
								array3[num6 - 0] = *(int*)(ptr + 8 + num3);
								num6++;
								ptr += 16;
								continue;
							}
							if (4 >= b)
							{
								if (4 <= b)
								{
									<Module>.getIdentityReferenceCultureAwareComparer = (byte)(*(int*)(&array5[num6 - 1]));
									num6--;
									continue;
								}
								if (2 >= b)
								{
									if (2 <= b)
									{
										array2[num6 - 1] = new object[*(int*)(&array5[num6 - 1])];
										array[num6 - 1] = 5;
										continue;
									}
									if (1 >= b)
									{
										if (1 <= b)
										{
										}
									}
								}
								else if (3 >= b)
								{
									if (3 <= b)
									{
										array6[*(int*)(ptr + num3)] = array2[num6 - 1];
										ptr += 8;
										num6--;
										continue;
									}
								}
							}
							else if (6 >= b)
							{
								if (6 <= b)
								{
									array[num6] = 4;
									array2[num6] = calli(System.DateTime(), <Module>.EvidenceEnumeratorSeed[*(int*)(ptr + num3)]);
									num6++;
									ptr += 8;
									continue;
								}
								if (5 >= b)
								{
									if (5 <= b)
									{
										*(&array5[num6]) = *(long*)(ptr + num4);
										array[num6] = 1;
										num6++;
										ptr += 16;
										continue;
									}
								}
							}
							else if (7 >= b)
							{
								if (7 <= b)
								{
									array6[*(int*)(ptr + num3)] = (DateTime)array2[num6 - 1];
									ptr += 8;
									num6--;
									continue;
								}
							}
						}
						else if (12 >= b)
						{
							if (12 <= b)
							{
								array[num6] = array[num6 - 1];
								array3[num6 - 0] = array3[num6 - 1];
								*(&array5[num6]) = *(&array5[num6 - 1]);
								array2[num6] = array2[num6 - 1];
								num6++;
								continue;
							}
							if (10 >= b)
							{
								if (10 <= b)
								{
									ptr = ((*(&array5[num6 - 2]) > *(&array5[num6 - 1])) ? 1 : 0) * (*(int*)(ptr + num3) - *(int*)(ptr + 8 + num3)) + *(int*)(ptr + 8 + num3) + ref EntryPointEntryFieldIdIsAssembly.JitImmediategetScheduledConcurrent;
									num6 -= 2;
									continue;
								}
								if (9 >= b)
								{
									if (9 <= b)
									{
										array[num6 - 1] = 1;
										*(&array5[num6 - 1]) = calli(System.Int64(System.DateTime&), calli(System.DateTime&(System.Object,System.IntPtr,System.Object[]), array2[num6 - 1], *(int*)(&array5[num6 - 1]), array6, <Module>.EvidenceEnumeratorSeed[array3[num6 - 1]]), <Module>.EvidenceEnumeratorSeed[*(int*)(ptr + num3)]);
										ptr += 8;
										continue;
									}
								}
							}
							else if (11 >= b)
							{
								if (11 <= b)
								{
									array2[num6 - 1] = new char[*(int*)(&array5[num6 - 1])];
									array[num6 - 1] = 5;
									continue;
								}
							}
						}
						else if (14 >= b)
						{
							if (14 <= b)
							{
								array[num6] = 5;
								array2[num6] = array6[*(int*)(ptr + num3)];
								num6++;
								ptr += 8;
								continue;
							}
							if (13 >= b)
							{
								if (13 <= b)
								{
									array6[*(int*)(ptr + num3)] = array2[num6 - 1];
									ptr += 8;
									num6--;
									continue;
								}
							}
						}
						else if (15 >= b)
						{
							if (15 <= b)
							{
								array[num6] = 5;
								array2[num6] = array6[*(int*)(ptr + num3)];
								num6++;
								ptr += 8;
								continue;
							}
						}
					}
					else if (24 >= b)
					{
						if (24 <= b)
						{
							*(int*)(&array5[num6 - 1]) = *(int*)(&array5[num6 - 1]);
							array[num6 - 1] = 0;
							continue;
						}
						if (20 >= b)
						{
							if (20 <= b)
							{
								array[num6] = 15;
								array3[num6] = *(int*)(ptr + num3);
								ptr += 8;
								num6++;
								continue;
							}
							if (18 >= b)
							{
								if (18 <= b)
								{
									*(int*)(&array5[num6 - 2]) = (*(int*)(&array5[num6 - 2]) ^ *(int*)(&array5[num6 - 1]));
									array[num6 - 2] = 0;
									num6--;
									continue;
								}
								if (17 >= b)
								{
									if (17 <= b)
									{
										array2[num6 - 2] = ((object[])array2[num6 - 2])[*(int*)(&array5[num6 - 1])];
										array[num6 - 2] = 5;
										num6--;
										continue;
									}
								}
							}
							else if (19 >= b)
							{
								if (19 <= b)
								{
									array2[num6 - 3][*(int*)(&array5[num6 - 2])] = *(int*)(&array5[num6 - 1]);
									num6 -= 3;
									continue;
								}
							}
						}
						else if (22 >= b)
						{
							if (22 <= b)
							{
								*(IntPtr*)(&array5[num6 - 2]) = *(IntPtr*)(&array5[num6 - 2]) + (IntPtr)(*(int*)(&array5[num6 - 1]));
								array[num6 - 2] = 2;
								num6--;
								continue;
							}
							if (21 >= b)
							{
								if (21 <= b)
								{
									*(IntPtr*)(&array5[num6 - 1]) = calli(NameCacheThread&(System.Object,System.IntPtr,System.Object[]), array2[num6 - 1], *(int*)(&array5[num6 - 1]), array6, <Module>.EvidenceEnumeratorSeed[array3[num6 - 1]]);
									array[num6 - 1] = 2;
									continue;
								}
							}
						}
						else if (23 >= b)
						{
							if (23 <= b)
							{
								*(int*)(&array5[num6 - 1]) = (int)(*(*(IntPtr*)(&array5[num6 - 1])));
								array[num6 - 1] = 0;
								continue;
							}
						}
					}
					else if (28 >= b)
					{
						if (28 <= b)
						{
							*(IntPtr*)(&array5[num6 - 1]) = calli(CreateSHAAsDecimal&(System.Object,System.IntPtr,System.Object[]), array2[num6 - 1], *(int*)(&array5[num6 - 1]), array6, <Module>.EvidenceEnumeratorSeed[array3[num6 - 1]]);
							array[num6 - 1] = 2;
							continue;
						}
						if (26 >= b)
						{
							if (26 <= b)
							{
								calli(System.Void(System.String), (string)array2[num6 - 1], <Module>.EvidenceEnumeratorSeed[*(int*)(ptr + num3)]);
								num6--;
								ptr += 8;
								continue;
							}
							if (25 >= b)
							{
								if (25 <= b)
								{
									array[num6 - 1] = 5;
									array2[num6 - 1] = calli(System.String(System.Char[]), (char[])array2[num6 - 1], <Module>.EvidenceEnumeratorSeed[*(int*)(ptr + num3)]);
									ptr += 8;
									continue;
								}
							}
						}
						else if (27 >= b)
						{
							if (27 <= b)
							{
								array[num6] = 15;
								array3[num6] = *(int*)(ptr + num3);
								ptr += 8;
								num6++;
								continue;
							}
						}
					}
					else if (30 >= b)
					{
						if (30 <= b)
						{
							throw (Exception)array2[num6 - 1];
						}
						if (29 >= b)
						{
							if (29 <= b)
							{
								array[num6 - 1] = 5;
								array2[num6 - 1] = calli(System.Exception(System.String), (string)array2[num6 - 1], <Module>.EvidenceEnumeratorSeed[*(int*)(ptr + num3)]);
								ptr += 8;
								continue;
							}
						}
					}
					else if (31 >= b)
					{
						if (31 <= b)
						{
							continue;
						}
					}
					else if (32 >= b)
					{
						if (32 <= b)
						{
							num5 = 1;
							continue;
						}
					}
				}
				IL_5BF:
				*(int*)(&array5[num6]) = *(int*)(ptr + num3);
				array[num6] = 0;
				num6++;
				ptr += 8;
				continue;
				goto IL_5BF;
			}
		}
	}

	// Token: 0x06000002 RID: 2 RVA: 0x00002FE4 File Offset: 0x000011E4
	public static DateTime getHasShutdownStartedOnCompleted()
	{
		return DateTime.UtcNow;
	}

	// Token: 0x06000003 RID: 3 RVA: 0x00002FEB File Offset: 0x000011EB
	private static ref DateTime getVisualizerTypeNameLight(object A_0, IntPtr A_1, object[] A_2)
	{
		return ref (DateTime)A_2[(int)A_1];
	}

	// Token: 0x06000004 RID: 4 RVA: 0x00002FFB File Offset: 0x000011FB
	public static long EndBufferedArrayTrySetApartmentState(ref DateTime A_0)
	{
		return A_0.Ticks;
	}

	// Token: 0x06000005 RID: 5 RVA: 0x00003006 File Offset: 0x00001206
	private static ref NameCacheThread CompareOrdinalExplicitLayout(object A_0, IntPtr A_1, object[] A_2)
	{
		return ref NameCacheThread.AppendStringWindowClassEntryFieldId;
	}

	// Token: 0x06000006 RID: 6 RVA: 0x0000300D File Offset: 0x0000120D
	public static string getAllDataNoThrowOnInvalidTime(char[] A_0)
	{
		return new string(A_0);
	}

	// Token: 0x06000007 RID: 7 RVA: 0x00003018 File Offset: 0x00001218
	public static void GetComInterfaceForObjectInContextCreateIdentityPermission(string A_0)
	{
		Environment.FailFast(A_0);
	}

	// Token: 0x06000008 RID: 8 RVA: 0x00003023 File Offset: 0x00001223
	private static ref CreateSHAAsDecimal RequestedExecutionLevelUIAccessSystemAclProtected(object A_0, IntPtr A_1, object[] A_2)
	{
		return ref CreateSHAAsDecimal.setResponseXmlElementNamegetHasShutdownStarted;
	}

	// Token: 0x06000009 RID: 9 RVA: 0x0000302A File Offset: 0x0000122A
	public static Exception CalendarAppendFormat(string A_0)
	{
		return new Exception(A_0);
	}

	// Token: 0x0600000A RID: 10 RVA: 0x00003038 File Offset: 0x00001238
	private static void MathSymbolGetHashFromAssemblyFileW()
	{
		<Module>.EvidenceEnumeratorSeed = new IntPtr[8];
		<Module>.EvidenceEnumeratorSeed[0] = ldftn(getHasShutdownStartedOnCompleted);
		<Module>.EvidenceEnumeratorSeed[1] = ldftn(getVisualizerTypeNameLight);
		<Module>.EvidenceEnumeratorSeed[2] = ldftn(EndBufferedArrayTrySetApartmentState);
		<Module>.EvidenceEnumeratorSeed[3] = ldftn(CompareOrdinalExplicitLayout);
		<Module>.EvidenceEnumeratorSeed[4] = ldftn(getAllDataNoThrowOnInvalidTime);
		<Module>.EvidenceEnumeratorSeed[5] = ldftn(GetComInterfaceForObjectInContextCreateIdentityPermission);
		<Module>.EvidenceEnumeratorSeed[6] = ldftn(RequestedExecutionLevelUIAccessSystemAclProtected);
		<Module>.EvidenceEnumeratorSeed[7] = ldftn(CalendarAppendFormat);
	}

	// Token: 0x04000001 RID: 1
	public static byte getIdentityReferenceCultureAwareComparer;

	// Token: 0x04000002 RID: 2
	private static DateTime MemoryBarrierAddNonscalar;

	// Token: 0x04000003 RID: 3
	private static IntPtr[] EvidenceEnumeratorSeed;
}
