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


namespace UE4.ClothingSystemRuntime.Native {
    [StructLayout( LayoutKind.Explicit, Size=392 )]
    internal unsafe struct ClothingAsset_fields {
        [FieldOffset(88)]  public IntPtr  PhysicsAsset;
        [FieldOffset(96)] public ClothConfig ClothConfig;
        [FieldOffset(312)] public NativeArray LodData;
        [FieldOffset(328)] public NativeArray LodMap;
        [FieldOffset(344)] public NativeArray UsedBoneNames;
        [FieldOffset(360)] public NativeArray UsedBoneIndices;
        [FieldOffset(376)] public int ReferenceBoneIndex;
        [FieldOffset(384)]  public IntPtr  CustomData;
    }
    internal unsafe struct ClothingAsset_methods {
    }
    internal unsafe struct ClothingAsset_events {
    }
}
