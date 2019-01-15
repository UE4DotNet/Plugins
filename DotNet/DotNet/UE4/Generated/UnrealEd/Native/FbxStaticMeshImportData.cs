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
    internal unsafe struct FbxStaticMeshImportData_fields {
        [FieldOffset(192)] public Name StaticMeshLODGroup;
        [FieldOffset(204)] public byte VertexColorImportOption;
        [FieldOffset(208)] public Color VertexOverrideColor;
        [FieldOffset(212)] public bool bRemoveDegenerates;
        [FieldOffset(212)] public bool bBuildAdjacencyBuffer;
        [FieldOffset(212)] public bool bBuildReversedIndexBuffer;
        [FieldOffset(212)] public bool bGenerateLightmapUVs;
        [FieldOffset(212)] public bool bOneConvexHullPerUCX;
        [FieldOffset(212)] public bool bAutoGenerateCollision;
        [FieldOffset(212)] public bool bCombineMeshes;
    }
    internal unsafe struct FbxStaticMeshImportData_methods {
    }
    internal unsafe struct FbxStaticMeshImportData_events {
    }
}
