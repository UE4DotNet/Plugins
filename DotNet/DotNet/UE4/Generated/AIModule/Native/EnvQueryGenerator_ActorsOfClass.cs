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
    [StructLayout( LayoutKind.Explicit, Size=224 )]
    internal unsafe struct EnvQueryGenerator_ActorsOfClass_fields {
        [FieldOffset(96)] public IntPtr SearchedActorClass;
        [FieldOffset(104)] public AIDataProviderBoolValue GenerateOnlyActorsInRadius;
        [FieldOffset(160)] public AIDataProviderFloatValue SearchRadius;
        [FieldOffset(216)] public IntPtr SearchCenter;
    }
    internal unsafe struct EnvQueryGenerator_ActorsOfClass_methods {
    }
    internal unsafe struct EnvQueryGenerator_ActorsOfClass_events {
    }
}
