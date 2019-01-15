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
    [StructLayout( LayoutKind.Explicit, Size=152 )]
    internal unsafe struct ParticleModuleLocationBoneSocket_fields {
        [FieldOffset(72)] public byte SourceType;
        [FieldOffset(76)] public Vector UniversalOffset;
        [FieldOffset(88)] public NativeArray SourceLocations;
        [FieldOffset(104)] public byte SelectionMethod;
        [FieldOffset(108)] public bool bUpdatePositionEachFrame;
        [FieldOffset(108)] public bool bOrientMeshEmitters;
        [FieldOffset(108)] public bool bInheritBoneVelocity;
        [FieldOffset(112)] public float InheritVelocityScale;
        [FieldOffset(116)] public Name SkelMeshActorParamName;
        [FieldOffset(128)] public int NumPreSelectedIndices;
        [FieldOffset(136)]  public IntPtr  EditorSkelMesh;
    }
    internal unsafe struct ParticleModuleLocationBoneSocket_methods {
    }
    internal unsafe struct ParticleModuleLocationBoneSocket_events {
    }
}
