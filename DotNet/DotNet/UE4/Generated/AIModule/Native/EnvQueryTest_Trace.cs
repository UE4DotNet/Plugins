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


namespace UE4.AIModule.Native {
    [StructLayout( LayoutKind.Explicit, Size=784 )]
    internal unsafe struct EnvQueryTest_Trace_fields {
        [FieldOffset(560)] public EnvTraceData TraceData;
        [FieldOffset(608)] public AIDataProviderBoolValue TraceFromContext;
        [FieldOffset(664)] public AIDataProviderFloatValue ItemHeightOffset;
        [FieldOffset(720)] public AIDataProviderFloatValue ContextHeightOffset;
        [FieldOffset(776)] public IntPtr Context;
    }
    internal unsafe struct EnvQueryTest_Trace_methods {
    }
    internal unsafe struct EnvQueryTest_Trace_events {
    }
}
