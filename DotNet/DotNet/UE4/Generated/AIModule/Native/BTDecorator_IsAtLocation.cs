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
    [StructLayout( LayoutKind.Explicit, Size=248 )]
    internal unsafe struct BTDecorator_IsAtLocation_fields {
        [FieldOffset(176)] public float AcceptableRadius;
        [FieldOffset(184)] public AIDataProviderFloatValue ParametrizedAcceptableRadius;
        [FieldOffset(240)] byte GeometricDistanceType; //TODO: enum FAIDistanceType GeometricDistanceType
        [FieldOffset(244)] public bool bUseParametrizedRadius;
        [FieldOffset(244)] public bool bUseNavAgentGoalLocation;
        [FieldOffset(244)] public bool bPathFindingBasedTest;
    }
    internal unsafe struct BTDecorator_IsAtLocation_methods {
    }
    internal unsafe struct BTDecorator_IsAtLocation_events {
    }
}
