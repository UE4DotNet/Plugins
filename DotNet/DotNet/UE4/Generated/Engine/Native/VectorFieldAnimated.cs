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
    [StructLayout( LayoutKind.Explicit, Size=152 )]
    internal unsafe struct VectorFieldAnimated_fields {
        [FieldOffset(88)]  public IntPtr  Texture;
        [FieldOffset(96)] public byte ConstructionOp;
        [FieldOffset(100)] public int VolumeSizeX;
        [FieldOffset(104)] public int VolumeSizeY;
        [FieldOffset(108)] public int VolumeSizeZ;
        [FieldOffset(112)] public int SubImagesX;
        [FieldOffset(116)] public int SubImagesY;
        [FieldOffset(120)] public int FrameCount;
        [FieldOffset(124)] public float FramesPerSecond;
        [FieldOffset(128)] public bool bLoop;
        [FieldOffset(136)]  public IntPtr  NoiseField;
        [FieldOffset(144)] public float NoiseScale;
        [FieldOffset(148)] public float NoiseMax;
    }
    internal unsafe struct VectorFieldAnimated_methods {
    }
    internal unsafe struct VectorFieldAnimated_events {
    }
}
