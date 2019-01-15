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
    internal unsafe struct EnvQueryGenerator_Cone_fields {
        [FieldOffset(144)] public AIDataProviderFloatValue AlignedPointsDistance;
        [FieldOffset(200)] public AIDataProviderFloatValue ConeDegrees;
        [FieldOffset(256)] public AIDataProviderFloatValue AngleStep;
        [FieldOffset(312)] public AIDataProviderFloatValue Range;
        [FieldOffset(368)] public IntPtr CenterActor;
        [FieldOffset(376)] public bool bIncludeContextLocation;
    }
    internal unsafe struct EnvQueryGenerator_Cone_methods {
    }
    internal unsafe struct EnvQueryGenerator_Cone_events {
    }
}
