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


namespace UE4.Foliage{
        ///<summary>Foliage Vertex Color Channel Mask</summary>
        [StructLayout( LayoutKind.Explicit, Size=12 )]
        public unsafe struct FoliageVertexColorChannelMask {
            [FieldOffset(0)] public bool UseMask;

            [FieldOffset(4)] public float MaskThreshold;

            [FieldOffset(8)] public bool InvertMask;

        }
}
