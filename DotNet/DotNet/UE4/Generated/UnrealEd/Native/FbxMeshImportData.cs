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
    [StructLayout( LayoutKind.Explicit, Size=192 )]
    internal unsafe struct FbxMeshImportData_fields {
        [FieldOffset(144)] public bool bTransformVertexToAbsolute;
        [FieldOffset(145)] public bool bBakePivotInVertex;
        [FieldOffset(148)] public bool bImportMeshLODs;
        [FieldOffset(152)] public byte NormalImportMethod;
        [FieldOffset(153)] public byte NormalGenerationMethod;
        [FieldOffset(160)] public NativeArray ImportMaterialOriginalNameData;
        [FieldOffset(176)] public NativeArray ImportMeshLodData;
    }
    internal unsafe struct FbxMeshImportData_methods {
    }
    internal unsafe struct FbxMeshImportData_events {
    }
}
