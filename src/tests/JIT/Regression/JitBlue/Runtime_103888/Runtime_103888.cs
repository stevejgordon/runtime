// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.CompilerServices;
using Xunit;

public class Runtime_103888_A
{
    // Generated by Fuzzlyn v1.6 on 2024-06-23 16:50:17
    // Run on X64 Windows
    // Seed: 14337630088129483600
    // Reduced from 13.5 KiB to 0.3 KiB in 00:01:04
    // Hits JIT assert in Release:
    // Assertion failed 'block->bbPreorderNum == preorderNum' in 'Program:Main(Fuzzlyn.ExecutionServer.IRuntime)' during 'Early Value Propagation' (IL size 47; hash 0xade6b36b; FullOpts)
    //
    //     File: D:\a\_work\1\s\src\coreclr\jit\fgdiagnostic.cpp Line: 4750
    //

    public class C0
    {
        public uint F0;
        public int F1;
    }

    [Fact]
    public static void TestEntryPoint()
    {
        C0 vr0 = new C0();
        if (!((ulong)(0 << vr0.F1) <= vr0.F0))
        {
            vr0.F1 ^= vr0.F1;
        }
    }
}

public class Runtime_103888_B
{
    public static ushort[, ] s_69 = new ushort[1,1];

    [Fact]
    public static void TestEntryPoint()
    {
        try
        {
            var vr2 = new int[][, ][]{new int[, ][]{{new int[]{0}}}};
        }
        finally
        {
            if (0UL > s_69[0, 0])
            {
                var vr3 = new byte[, ]{{0}};
            }
            else
            {
                uint[, ] vr4 = new uint[, ]{{0}};
            }
        }
    }
}
