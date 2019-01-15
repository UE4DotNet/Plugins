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


namespace UE4.FunctionalTesting{
        ///<summary>Trace Channel Test Batch Options</summary>
        [StructLayout( LayoutKind.Explicit, Size=7 )]
        public unsafe struct TraceChannelTestBatchOptions {
            [FieldOffset(0)] public bool bLineTrace;

            [FieldOffset(1)] public bool bSphereTrace;

            [FieldOffset(2)] public bool bCapsuleTrace;

            [FieldOffset(3)] public bool bBoxTrace;

            [FieldOffset(4)] public bool bChannelTrace;

            [FieldOffset(5)] public bool bObjectsTrace;

            [FieldOffset(6)] public bool bProfileTrace;

        }
}
