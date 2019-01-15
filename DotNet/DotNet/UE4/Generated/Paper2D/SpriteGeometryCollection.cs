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


namespace UE4.Paper2D{
        ///<summary>Sprite Geometry Collection</summary>
        [StructLayout( LayoutKind.Explicit, Size=48 )]
        public unsafe struct SpriteGeometryCollection {
            [FieldOffset(0)] byte Shapes; //TODO: array TArray Shapes

            [FieldOffset(16)] public byte GeometryType;

            [FieldOffset(20)] public int PixelsPerSubdivisionX;

            [FieldOffset(24)] public int PixelsPerSubdivisionY;

            [FieldOffset(28)] public bool bAvoidVertexMerging;

            [FieldOffset(32)] public float AlphaThreshold;

            [FieldOffset(36)] public float DetailAmount;

            [FieldOffset(40)] public float SimplifyEpsilon;

        }
}
