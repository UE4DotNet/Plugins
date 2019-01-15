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
    [StructLayout( LayoutKind.Explicit, Size=464 )]
    internal unsafe struct ParticleModuleCollision_fields {
        [FieldOffset(72)] public RawDistributionVector DampingFactor;
        [FieldOffset(152)] public RawDistributionVector DampingFactorRotation;
        [FieldOffset(232)] public RawDistributionFloat MaxCollisions;
        [FieldOffset(288)] public byte CollisionCompletionOption;
        [FieldOffset(296)] public NativeArray CollisionTypes;
        [FieldOffset(320)] public bool bApplyPhysics;
        [FieldOffset(320)] public bool bIgnoreTriggerVolumes;
        [FieldOffset(328)] public RawDistributionFloat ParticleMass;
        [FieldOffset(384)] public float DirScalar;
        [FieldOffset(388)] public bool bPawnsDoNotDecrementCount;
        [FieldOffset(388)] public bool bOnlyVerticalNormalsDecrementCount;
        [FieldOffset(392)] public float VerticalFudgeFactor;
        [FieldOffset(400)] public RawDistributionFloat DelayAmount;
        [FieldOffset(456)] public bool bDropDetail;
        [FieldOffset(456)] public bool bCollideOnlyIfVisible;
        [FieldOffset(456)] public bool bIgnoreSourceActor;
        [FieldOffset(460)] public float MaxCollisionDistance;
    }
    internal unsafe struct ParticleModuleCollision_methods {
    }
    internal unsafe struct ParticleModuleCollision_events {
    }
}
