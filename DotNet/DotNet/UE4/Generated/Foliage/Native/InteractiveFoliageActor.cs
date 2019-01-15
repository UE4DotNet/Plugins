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


namespace UE4.Foliage.Native {
    [StructLayout( LayoutKind.Explicit, Size=1120 )]
    internal unsafe struct InteractiveFoliageActor_fields {
        [FieldOffset(1024)]  public IntPtr  CapsuleComponent;
        [FieldOffset(1032)] public Vector TouchingActorEntryPosition;
        [FieldOffset(1044)] public Vector FoliageVelocity;
        [FieldOffset(1056)] public Vector FoliageForce;
        [FieldOffset(1068)] public Vector FoliagePosition;
        [FieldOffset(1080)] public float FoliageDamageImpulseScale;
        [FieldOffset(1084)] public float FoliageTouchImpulseScale;
        [FieldOffset(1088)] public float FoliageStiffness;
        [FieldOffset(1092)] public float FoliageStiffnessQuadratic;
        [FieldOffset(1096)] public float FoliageDamping;
        [FieldOffset(1100)] public float MaxDamageImpulse;
        [FieldOffset(1104)] public float MaxTouchImpulse;
        [FieldOffset(1108)] public float MaxForce;
        [FieldOffset(1112)] public float Mass;
    }
    internal unsafe struct InteractiveFoliageActor_methods {
    }
    internal unsafe struct InteractiveFoliageActor_events {
    }
}
