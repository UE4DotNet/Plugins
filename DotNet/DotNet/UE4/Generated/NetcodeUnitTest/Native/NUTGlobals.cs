// Copyright 2018 by JCoder58.  See License.txt for license
// Auto-generated --- Do not modify.
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UE4.Core;
using UE4.CoreUObject;
using UE4.CoreUObject.Native;
using UE4.InputCore;
using UE4.Native;


namespace UE4.NetcodeUnitTest.Native {
    [StructLayout( LayoutKind.Explicit, Size=120 )]
    internal unsafe struct NUTGlobals_fields {
        [FieldOffset(56)]  public IntPtr  EventWatcher;
        [FieldOffset(64)] public int ServerPortOffset;
        [FieldOffset(68)] public int UnitTestNetDriverCount;
        [FieldOffset(72)] public NativeArray DumpRPCMatches;
        [FieldOffset(88)] public NativeArray UnitTestModules;
        [FieldOffset(104)] public NativeArray UnloadedModules;
    }
    internal unsafe struct NUTGlobals_methods {
    }
    internal unsafe struct NUTGlobals_events {
    }
}
