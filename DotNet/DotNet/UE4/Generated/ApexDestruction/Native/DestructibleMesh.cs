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


namespace UE4.ApexDestruction.Native {
    [StructLayout( LayoutKind.Explicit, Size=1344 )]
    internal unsafe struct DestructibleMesh_fields {
        [FieldOffset(1144)] public DestructibleParameters DefaultDestructibleParameters;
        [FieldOffset(1280)] byte FractureEffects; //TODO: array TArray FractureEffects
        [FieldOffset(1296)]  public IntPtr  FractureSettings;
        [FieldOffset(1304)]  public IntPtr  SourceStaticMesh;
        [FieldOffset(1312)] public FDateTime SourceSMImportTimestamp;
        [FieldOffset(1320)] byte FractureChunkMeshes; //TODO: array TArray FractureChunkMeshes
    }
    internal unsafe struct DestructibleMesh_methods {
    }
    internal unsafe struct DestructibleMesh_events {
    }
}
