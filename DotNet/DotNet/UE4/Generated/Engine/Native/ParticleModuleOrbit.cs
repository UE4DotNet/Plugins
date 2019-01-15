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
    [StructLayout( LayoutKind.Explicit, Size=352 )]
    internal unsafe struct ParticleModuleOrbit_fields {
        [FieldOffset(80)] public byte ChainMode;
        [FieldOffset(88)] public RawDistributionVector OffsetAmount;
        [FieldOffset(168)] public OrbitOptions OffsetOptions;
        [FieldOffset(176)] public RawDistributionVector RotationAmount;
        [FieldOffset(256)] public OrbitOptions RotationOptions;
        [FieldOffset(264)] public RawDistributionVector RotationRateAmount;
        [FieldOffset(344)] public OrbitOptions RotationRateOptions;
    }
    internal unsafe struct ParticleModuleOrbit_methods {
    }
    internal unsafe struct ParticleModuleOrbit_events {
    }
}
