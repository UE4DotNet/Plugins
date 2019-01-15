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
    [StructLayout( LayoutKind.Explicit, Size=216 )]
    internal unsafe struct ParticleModuleLocationPrimitiveBase_fields {
        [FieldOffset(72)] public bool Positive_X;
        [FieldOffset(72)] public bool Positive_Y;
        [FieldOffset(72)] public bool Positive_Z;
        [FieldOffset(72)] public bool Negative_X;
        [FieldOffset(72)] public bool Negative_Y;
        [FieldOffset(72)] public bool Negative_Z;
        [FieldOffset(72)] public bool SurfaceOnly;
        [FieldOffset(72)] public bool Velocity;
        [FieldOffset(80)] public RawDistributionFloat VelocityScale;
        [FieldOffset(136)] public RawDistributionVector StartLocation;
    }
    internal unsafe struct ParticleModuleLocationPrimitiveBase_methods {
    }
    internal unsafe struct ParticleModuleLocationPrimitiveBase_events {
    }
}
