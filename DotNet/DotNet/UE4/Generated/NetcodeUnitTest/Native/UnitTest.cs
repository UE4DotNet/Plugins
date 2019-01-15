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
    [StructLayout( LayoutKind.Explicit, Size=432 )]
    internal unsafe struct UnitTest_fields {
        [FieldOffset(272)] byte PeakMemoryUsage; //TODO: numeric uint64 PeakMemoryUsage
        [FieldOffset(280)] public float TimeToPeakMem;
        [FieldOffset(284)] public float LastExecutionTime;
        [FieldOffset(352)] public NativeArray UnitTasks;
        [FieldOffset(370)] byte VerificationState; //TODO: enum EUnitTestVerification VerificationState
    }
    internal unsafe struct UnitTest_methods {
    }
    internal unsafe struct UnitTest_events {
    }
}
