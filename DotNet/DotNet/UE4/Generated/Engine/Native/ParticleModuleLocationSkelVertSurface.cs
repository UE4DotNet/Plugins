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
    [StructLayout( LayoutKind.Explicit, Size=184 )]
    internal unsafe struct ParticleModuleLocationSkelVertSurface_fields {
        [FieldOffset(72)] public byte SourceType;
        [FieldOffset(76)] public Vector UniversalOffset;
        [FieldOffset(88)] public bool bUpdatePositionEachFrame;
        [FieldOffset(88)] public bool bOrientMeshEmitters;
        [FieldOffset(88)] public bool bInheritBoneVelocity;
        [FieldOffset(92)] public float InheritVelocityScale;
        [FieldOffset(96)] public Name SkelMeshActorParamName;
        [FieldOffset(112)]  public IntPtr  EditorSkelMesh;
        [FieldOffset(120)] public NativeArray ValidAssociatedBones;
        [FieldOffset(136)] public bool bEnforceNormalCheck;
        [FieldOffset(140)] public Vector NormalToCompare;
        [FieldOffset(152)] public float NormalCheckToleranceDegrees;
        [FieldOffset(156)] public float NormalCheckTolerance;
        [FieldOffset(160)] public NativeArray ValidMaterialIndices;
        [FieldOffset(176)] public bool bInheritVertexColor;
        [FieldOffset(176)] public bool bInheritUV;
        [FieldOffset(180)] byte InheritUVChannel; //TODO: numeric uint32 InheritUVChannel
    }
    internal unsafe struct ParticleModuleLocationSkelVertSurface_methods {
    }
    internal unsafe struct ParticleModuleLocationSkelVertSurface_events {
    }
}
