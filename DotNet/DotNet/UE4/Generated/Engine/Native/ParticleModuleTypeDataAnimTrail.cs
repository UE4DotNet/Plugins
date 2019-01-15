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


namespace UE4.Engine.Native {
    [StructLayout( LayoutKind.Explicit, Size=96 )]
    internal unsafe struct ParticleModuleTypeDataAnimTrail_fields {
        [FieldOffset(72)] public bool bDeadTrailsOnDeactivate;
        [FieldOffset(72)] public bool bEnablePreviousTangentRecalculation;
        [FieldOffset(72)] public bool bTangentRecalculationEveryFrame;
        [FieldOffset(76)] public float TilingDistance;
        [FieldOffset(80)] public float DistanceTessellationStepSize;
        [FieldOffset(84)] public float TangentTessellationStepSize;
        [FieldOffset(88)] public float WidthTessellationStepSize;
    }
    internal unsafe struct ParticleModuleTypeDataAnimTrail_methods {
    }
    internal unsafe struct ParticleModuleTypeDataAnimTrail_events {
    }
}
