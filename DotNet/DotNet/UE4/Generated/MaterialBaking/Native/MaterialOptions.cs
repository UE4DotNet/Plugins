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


namespace UE4.MaterialBaking.Native {
    [StructLayout( LayoutKind.Explicit, Size=104 )]
    internal unsafe struct MaterialOptions_fields {
        [FieldOffset(56)] public NativeArray Properties;
        [FieldOffset(72)] public IntPoint TextureSize;
        [FieldOffset(80)] public NativeArray LODIndices;
        [FieldOffset(96)] public bool bUseMeshData;
        [FieldOffset(97)] public bool bUseSpecificUVIndex;
        [FieldOffset(100)] public int TextureCoordinateIndex;
    }
    internal unsafe struct MaterialOptions_methods {
    }
    internal unsafe struct MaterialOptions_events {
    }
}
