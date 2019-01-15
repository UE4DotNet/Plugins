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
    [StructLayout( LayoutKind.Explicit, Size=144 )]
    internal unsafe struct PhysicalMaterial_fields {
        [FieldOffset(56)] public float Friction;
        [FieldOffset(60)] public byte FrictionCombineMode;
        [FieldOffset(61)] public bool bOverrideFrictionCombineMode;
        [FieldOffset(64)] public float Restitution;
        [FieldOffset(68)] public byte RestitutionCombineMode;
        [FieldOffset(69)] public bool bOverrideRestitutionCombineMode;
        [FieldOffset(72)] public float Density;
        [FieldOffset(76)] public float RaiseMassToPower;
        [FieldOffset(80)] public float DestructibleDamageThresholdScale;
        [FieldOffset(88)]  public IntPtr  PhysicalMaterialProperty;
        [FieldOffset(96)] public byte SurfaceType;
        [FieldOffset(100)] public float TireFrictionScale;
        [FieldOffset(104)] public NativeArray TireFrictionScales;
    }
    internal unsafe struct PhysicalMaterial_methods {
    }
    internal unsafe struct PhysicalMaterial_events {
    }
}
