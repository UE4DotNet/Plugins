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
    [StructLayout( LayoutKind.Explicit, Size=88 )]
    internal unsafe struct FbxSceneImportOptionsStaticMesh_fields {
        [FieldOffset(56)] public Name StaticMeshLODGroup;
        [FieldOffset(68)] public bool bAutoGenerateCollision;
        [FieldOffset(72)] public byte VertexColorImportOption;
        [FieldOffset(76)] public Color VertexOverrideColor;
        [FieldOffset(80)] public bool bRemoveDegenerates;
        [FieldOffset(80)] public bool bBuildAdjacencyBuffer;
        [FieldOffset(80)] public bool bBuildReversedIndexBuffer;
        [FieldOffset(80)] public bool bGenerateLightmapUVs;
        [FieldOffset(80)] public bool bOneConvexHullPerUCX;
        [FieldOffset(84)] public byte NormalImportMethod;
        [FieldOffset(85)] public byte NormalGenerationMethod;
    }
    internal unsafe struct FbxSceneImportOptionsStaticMesh_methods {
    }
    internal unsafe struct FbxSceneImportOptionsStaticMesh_events {
    }
}
