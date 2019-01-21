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


namespace UE4.Engine{
        ///<summary>Virtual Texture Layer</summary>
        [StructLayout( LayoutKind.Explicit, Size=4 )]
        public unsafe struct VirtualTextureLayer {
            [FieldOffset(0)] public byte Format;

            [FieldOffset(1)] public bool bCompressed;

            [FieldOffset(2)] public bool bHasAlpha;

            [FieldOffset(3)] public byte CompressionSettings;

        }
}
