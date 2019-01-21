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
    [StructLayout( LayoutKind.Explicit, Size=128 )]
    internal unsafe struct VirtualTextureSpace_fields {
        [FieldOffset(56)] public NativeArray Layers;
        [FieldOffset(72)] public int TileSize;
        [FieldOffset(76)] public int BorderWidth;
        [FieldOffset(80)] public int Size;
        [FieldOffset(84)] public int Dimensions;
        [FieldOffset(88)] public byte Format;
        [FieldOffset(92)] public int PoolSize;
    }
    internal unsafe struct VirtualTextureSpace_methods {
    }
    internal unsafe struct VirtualTextureSpace_events {
    }
}
