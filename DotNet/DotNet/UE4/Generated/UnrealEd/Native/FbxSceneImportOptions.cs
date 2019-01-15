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
    internal unsafe struct FbxSceneImportOptions_fields {
        [FieldOffset(56)] public bool bCreateContentFolderHierarchy;
        [FieldOffset(56)] public bool bImportAsDynamic;
        [FieldOffset(60)] public byte HierarchyType;
        [FieldOffset(64)] public bool bForceFrontXAxis;
        [FieldOffset(68)] public Vector ImportTranslation;
        [FieldOffset(80)] public Rotator ImportRotation;
        [FieldOffset(92)] public float ImportUniformScale;
        [FieldOffset(96)] public bool bTransformVertexToAbsolute;
        [FieldOffset(97)] public bool bBakePivotInVertex;
        [FieldOffset(100)] public bool bImportStaticMeshLODs;
        [FieldOffset(100)] public bool bImportSkeletalMeshLODs;
        [FieldOffset(100)] public bool bInvertNormalMaps;
    }
    internal unsafe struct FbxSceneImportOptions_methods {
    }
    internal unsafe struct FbxSceneImportOptions_events {
    }
}
