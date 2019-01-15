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
    [StructLayout( LayoutKind.Explicit, Size=544 )]
    internal unsafe struct EnvQueryGenerator_OnCircle_fields {
        [FieldOffset(144)] public AIDataProviderFloatValue CircleRadius;
        [FieldOffset(200)] public AIDataProviderFloatValue SpaceBetween;
        [FieldOffset(256)] public AIDataProviderIntValue NumberOfPoints;
        [FieldOffset(312)] byte PointOnCircleSpacingMethod; //TODO: enum EPointOnCircleSpacingMethod PointOnCircleSpacingMethod
        [FieldOffset(320)] public EnvDirection ArcDirection;
        [FieldOffset(352)] public AIDataProviderFloatValue ArcAngle;
        [FieldOffset(408)] public float AngleRadians;
        [FieldOffset(416)] public IntPtr CircleCenter;
        [FieldOffset(424)] public bool bIgnoreAnyContextActorsWhenGeneratingCircle;
        [FieldOffset(432)] public AIDataProviderFloatValue CircleCenterZOffset;
        [FieldOffset(488)] public EnvTraceData TraceData;
        [FieldOffset(536)] public bool bDefineArc;
    }
    internal unsafe struct EnvQueryGenerator_OnCircle_methods {
    }
    internal unsafe struct EnvQueryGenerator_OnCircle_events {
    }
}
