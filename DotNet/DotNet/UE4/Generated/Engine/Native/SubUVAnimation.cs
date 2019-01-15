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
    [StructLayout( LayoutKind.Explicit, Size=112 )]
    internal unsafe struct SubUVAnimation_fields {
        [FieldOffset(56)]  public IntPtr  SubUVTexture;
        [FieldOffset(64)] public int SubImages_Horizontal;
        [FieldOffset(68)] public int SubImages_Vertical;
        [FieldOffset(72)] public byte BoundingMode;
        [FieldOffset(73)] public byte OpacitySourceMode;
        [FieldOffset(76)] public float AlphaThreshold;
    }
    internal unsafe struct SubUVAnimation_methods {
    }
    internal unsafe struct SubUVAnimation_events {
    }
}
