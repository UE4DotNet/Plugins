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
    [StructLayout( LayoutKind.Explicit, Size=384 )]
    internal unsafe struct BTTask_RunEQSQuery_fields {
        [FieldOffset(184)]  public IntPtr  QueryTemplate;
        [FieldOffset(192)] public NativeArray QueryParams;
        [FieldOffset(208)] public NativeArray QueryConfig;
        [FieldOffset(224)] public byte RunMode;
        [FieldOffset(232)] public BlackboardKeySelector EQSQueryBlackboardKey;
        [FieldOffset(280)] public bool bUseBBKey;
        [FieldOffset(288)] public EQSParametrizedQueryExecutionRequest EQSRequest;
    }
    internal unsafe struct BTTask_RunEQSQuery_methods {
    }
    internal unsafe struct BTTask_RunEQSQuery_events {
    }
}
