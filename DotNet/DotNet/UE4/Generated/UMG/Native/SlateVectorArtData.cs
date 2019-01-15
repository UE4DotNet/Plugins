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


namespace UE4.UMG.Native {
    [StructLayout( LayoutKind.Explicit, Size=128 )]
    internal unsafe struct SlateVectorArtData_fields {
        [FieldOffset(56)]  public IntPtr  MeshAsset;
        [FieldOffset(64)]  public IntPtr  SourceMaterial;
        [FieldOffset(72)] public NativeArray VertexData;
        [FieldOffset(88)] public NativeArray IndexData;
        [FieldOffset(104)]  public IntPtr  Material;
        [FieldOffset(112)] public Vector2D ExtentMin;
        [FieldOffset(120)] public Vector2D ExtentMax;
    }
    internal unsafe struct SlateVectorArtData_methods {
    }
    internal unsafe struct SlateVectorArtData_events {
    }
}
