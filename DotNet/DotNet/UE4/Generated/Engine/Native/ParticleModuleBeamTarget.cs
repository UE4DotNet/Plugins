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
    internal unsafe struct ParticleModuleBeamTarget_fields {
        [FieldOffset(72)] public byte TargetMethod;
        [FieldOffset(76)] public Name TargetName;
        [FieldOffset(88)] public RawDistributionVector Target;
        [FieldOffset(168)] public bool bTargetAbsolute;
        [FieldOffset(168)] public bool bLockTarget;
        [FieldOffset(172)] public byte TargetTangentMethod;
        [FieldOffset(176)] public RawDistributionVector TargetTangent;
        [FieldOffset(256)] public bool bLockTargetTangent;
        [FieldOffset(264)] public RawDistributionFloat TargetStrength;
        [FieldOffset(320)] public bool bLockTargetStength;
        [FieldOffset(324)] public float LockRadius;
    }
    internal unsafe struct ParticleModuleBeamTarget_methods {
    }
    internal unsafe struct ParticleModuleBeamTarget_events {
    }
}
