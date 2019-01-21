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


namespace UE4.UnrealEd.Native {
    [StructLayout( LayoutKind.Explicit, Size=104 )]
    internal unsafe struct FbxSceneImportOptionsSkeletalMesh_fields {
        [FieldOffset(56)] public bool bUpdateSkeletonReferencePose;
        [FieldOffset(56)] public bool bCreatePhysicsAsset;
        [FieldOffset(56)] public bool bUseT0AsRefPose;
        [FieldOffset(56)] public bool bPreserveSmoothingGroups;
        [FieldOffset(56)] public bool bImportMeshesInBoneHierarchy;
        [FieldOffset(56)] public bool bImportMorphTargets;
        [FieldOffset(60)] public float ThresholdPosition;
        [FieldOffset(64)] public float ThresholdTangentNormal;
        [FieldOffset(68)] public float ThresholdUV;
        [FieldOffset(72)] public bool bImportAnimations;
        [FieldOffset(76)] public byte AnimationLength;
        [FieldOffset(80)] public Int32Interval FrameImportRange;
        [FieldOffset(88)] public bool bUseDefaultSampleRate;
        [FieldOffset(92)] public int CustomSampleRate;
        [FieldOffset(96)] public bool bImportCustomAttribute;
        [FieldOffset(97)] public bool bPreserveLocalTransform;
        [FieldOffset(98)] public bool bDeleteExistingMorphTargetCurves;
    }
    internal unsafe struct FbxSceneImportOptionsSkeletalMesh_methods {
    }
    internal unsafe struct FbxSceneImportOptionsSkeletalMesh_events {
    }
}
