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
    [StructLayout( LayoutKind.Explicit, Size=128 )]
    internal unsafe struct ParticleModuleVectorFieldLocal_fields {
        [FieldOffset(72)]  public IntPtr  VectorField;
        [FieldOffset(80)] public Vector RelativeTranslation;
        [FieldOffset(92)] public Rotator RelativeRotation;
        [FieldOffset(104)] public Vector RelativeScale3D;
        [FieldOffset(116)] public float Intensity;
        [FieldOffset(120)] public float Tightness;
        [FieldOffset(124)] public bool bIgnoreComponentTransform;
        [FieldOffset(124)] public bool bTileX;
        [FieldOffset(124)] public bool bTileY;
        [FieldOffset(124)] public bool bTileZ;
        [FieldOffset(124)] public bool bUseFixDT;
    }
    internal unsafe struct ParticleModuleVectorFieldLocal_methods {
    }
    internal unsafe struct ParticleModuleVectorFieldLocal_events {
    }
}
