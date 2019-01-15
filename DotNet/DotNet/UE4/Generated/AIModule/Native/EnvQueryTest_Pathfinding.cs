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
    [StructLayout( LayoutKind.Explicit, Size=696 )]
    internal unsafe struct EnvQueryTest_Pathfinding_fields {
        [FieldOffset(560)] public byte TestMode;
        [FieldOffset(568)] public IntPtr Context;
        [FieldOffset(576)] public AIDataProviderBoolValue PathFromContext;
        [FieldOffset(632)] public AIDataProviderBoolValue SkipUnreachable;
        [FieldOffset(688)] public IntPtr FilterClass;
    }
    internal unsafe struct EnvQueryTest_Pathfinding_methods {
    }
    internal unsafe struct EnvQueryTest_Pathfinding_events {
    }
}
