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
    [StructLayout( LayoutKind.Explicit, Size=208 )]
    internal unsafe struct FbxSkeletalMeshImportData_fields {
        [FieldOffset(192)] public bool bUpdateSkeletonReferencePose;
        [FieldOffset(192)] public bool bUseT0AsRefPose;
        [FieldOffset(192)] public bool bPreserveSmoothingGroups;
        [FieldOffset(192)] public bool bImportMeshesInBoneHierarchy;
        [FieldOffset(192)] public bool bImportMorphTargets;
        [FieldOffset(196)] public float ThresholdPosition;
        [FieldOffset(200)] public float ThresholdTangentNormal;
        [FieldOffset(204)] public float ThresholdUV;
    }
    internal unsafe struct FbxSkeletalMeshImportData_methods {
    }
    internal unsafe struct FbxSkeletalMeshImportData_events {
    }
}
