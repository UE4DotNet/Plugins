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
    [StructLayout( LayoutKind.Explicit, Size=480 )]
    internal unsafe struct EnvQueryGenerator_Donut_fields {
        [FieldOffset(144)] public AIDataProviderFloatValue InnerRadius;
        [FieldOffset(200)] public AIDataProviderFloatValue OuterRadius;
        [FieldOffset(256)] public AIDataProviderIntValue NumberOfRings;
        [FieldOffset(312)] public AIDataProviderIntValue PointsPerRing;
        [FieldOffset(368)] public EnvDirection ArcDirection;
        [FieldOffset(400)] public AIDataProviderFloatValue ArcAngle;
        [FieldOffset(456)] public bool bUseSpiralPattern;
        [FieldOffset(464)] public IntPtr Center;
        [FieldOffset(472)] public bool bDefineArc;
    }
    internal unsafe struct EnvQueryGenerator_Donut_methods {
    }
    internal unsafe struct EnvQueryGenerator_Donut_events {
    }
}
