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


namespace UE4.AIModule{
        ///<summary>Env Overlap Data</summary>
        [StructLayout( LayoutKind.Explicit, Size=32 )]
        public unsafe struct EnvOverlapData {
            [FieldOffset(0)] public float ExtentX;

            [FieldOffset(4)] public float ExtentY;

            [FieldOffset(8)] public float ExtentZ;

            ///<summary>Offset from the item location at which to test the overlap.  For example, you may need to offset vertically to avoid overlaps with flat ground.</summary>
            [FieldOffset(12)] Vector ShapeOffset;

            [FieldOffset(24)] public byte OverlapChannel;

            [FieldOffset(25)] public byte OverlapShape;

            [FieldOffset(28)] public bool bOnlyBlockingHits;

            [FieldOffset(28)] public bool bOverlapComplex;

        }
}
