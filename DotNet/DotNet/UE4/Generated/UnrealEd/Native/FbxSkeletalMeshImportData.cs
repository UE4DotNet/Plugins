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
    [StructLayout( LayoutKind.Explicit, Size=216 )]
    internal unsafe struct FbxSkeletalMeshImportData_fields {
        [FieldOffset(192)] public byte ImportContentType;
        [FieldOffset(196)] public bool bUpdateSkeletonReferencePose;
        [FieldOffset(196)] public bool bUseT0AsRefPose;
        [FieldOffset(196)] public bool bPreserveSmoothingGroups;
        [FieldOffset(196)] public bool bImportMeshesInBoneHierarchy;
        [FieldOffset(196)] public bool bImportMorphTargets;
        [FieldOffset(200)] public float ThresholdPosition;
        [FieldOffset(204)] public float ThresholdTangentNormal;
        [FieldOffset(208)] public float ThresholdUV;
    }
    internal unsafe struct FbxSkeletalMeshImportData_methods {
    }
    internal unsafe struct FbxSkeletalMeshImportData_events {
    }
}
