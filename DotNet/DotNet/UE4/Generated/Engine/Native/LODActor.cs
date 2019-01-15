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
    [StructLayout( LayoutKind.Explicit, Size=1296 )]
    internal unsafe struct LODActor_fields {
        [FieldOffset(1008)]  public IntPtr  StaticMeshComponent;
        [FieldOffset(1016)]  public IntPtr  Proxy;
        [FieldOffset(1024)] public Name Key;
        [FieldOffset(1036)] public float LODDrawDistance;
        [FieldOffset(1040)] public NativeArray SubActors;
        [FieldOffset(1056)] public int LODLevel;
        [FieldOffset(1080)] public byte CachedNumHLODLevels;
        [FieldOffset(1104)] byte NumTrianglesInSubActors; //TODO: numeric uint32 NumTrianglesInSubActors
        [FieldOffset(1108)] byte NumTrianglesInMergedMesh; //TODO: numeric uint32 NumTrianglesInMergedMesh
        [FieldOffset(1112)] public bool bOverrideMaterialMergeSettings;
        [FieldOffset(1116)] public MaterialProxySettings MaterialSettings;
        [FieldOffset(1256)] public bool bOverrideTransitionScreenSize;
        [FieldOffset(1260)] public float TransitionScreenSize;
        [FieldOffset(1264)] public bool bOverrideScreenSize;
        [FieldOffset(1268)] public int ScreenSize;
    }
    internal unsafe struct LODActor_methods {
    }
    internal unsafe struct LODActor_events {
    }
}
