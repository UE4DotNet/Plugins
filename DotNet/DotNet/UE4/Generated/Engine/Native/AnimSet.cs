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
    [StructLayout( LayoutKind.Explicit, Size=280 )]
    internal unsafe struct AnimSet_fields {
        [FieldOffset(56)] public bool bAnimRotationOnly;
        [FieldOffset(64)] public NativeArray TrackBoneNames;
        [FieldOffset(80)] public NativeArray Sequences;
        [FieldOffset(96)] public NativeArray LinkupCache;
        [FieldOffset(112)] public NativeArray BoneUseAnimTranslation;
        [FieldOffset(128)] public NativeArray ForceUseMeshTranslation;
        [FieldOffset(144)] public NativeArray UseTranslationBoneNames;
        [FieldOffset(160)] public NativeArray ForceMeshTranslationBoneNames;
        [FieldOffset(176)] public Name PreviewSkelMeshName;
        [FieldOffset(188)] public Name BestRatioSkelMeshName;
    }
    internal unsafe struct AnimSet_methods {
    }
    internal unsafe struct AnimSet_events {
    }
}
