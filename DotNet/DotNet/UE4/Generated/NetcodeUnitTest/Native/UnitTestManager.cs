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
    [StructLayout( LayoutKind.Explicit, Size=368 )]
    internal unsafe struct UnitTestManager_fields {
        [FieldOffset(80)] public bool bCapUnitTestCount;
        [FieldOffset(81)] public byte MaxUnitTestCount;
        [FieldOffset(82)] public bool bCapUnitTestMemory;
        [FieldOffset(83)] public byte MaxMemoryPercent;
        [FieldOffset(84)] public byte AutoCloseMemoryPercent;
        [FieldOffset(85)] public byte MaxAutoCloseCount;
        [FieldOffset(88)] byte UnitTestSessionCount; //TODO: numeric uint32 UnitTestSessionCount
        [FieldOffset(96)] public NativeArray PendingUnitTests;
        [FieldOffset(112)] public NativeArray ActiveUnitTests;
        [FieldOffset(128)] public NativeArray FinishedUnitTests;
    }
    internal unsafe struct UnitTestManager_methods {
    }
    internal unsafe struct UnitTestManager_events {
    }
}
