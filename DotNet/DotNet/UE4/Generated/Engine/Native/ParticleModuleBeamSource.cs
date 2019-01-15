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
    [StructLayout( LayoutKind.Explicit, Size=336 )]
    internal unsafe struct ParticleModuleBeamSource_fields {
        [FieldOffset(72)] public byte SourceMethod;
        [FieldOffset(76)] public Name SourceName;
        [FieldOffset(88)] public bool bSourceAbsolute;
        [FieldOffset(96)] public RawDistributionVector Source;
        [FieldOffset(176)] public bool bLockSource;
        [FieldOffset(180)] public byte SourceTangentMethod;
        [FieldOffset(184)] public RawDistributionVector SourceTangent;
        [FieldOffset(264)] public bool bLockSourceTangent;
        [FieldOffset(272)] public RawDistributionFloat SourceStrength;
        [FieldOffset(328)] public bool bLockSourceStength;
    }
    internal unsafe struct ParticleModuleBeamSource_methods {
    }
    internal unsafe struct ParticleModuleBeamSource_events {
    }
}
