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


namespace UE4.MeshDescription{
        ///<summary>Mesh Triangle</summary>
        [StructLayout( LayoutKind.Explicit, Size=12 )]
        public unsafe struct MeshTriangle {
            ///<summary>First vertex instance that makes up this triangle.  Indices must be ordered counter-clockwise.</summary>
            [FieldOffset(0)] VertexInstanceID VertexInstanceID0;

            ///<summary>Second vertex instance that makes up this triangle.  Indices must be ordered counter-clockwise.</summary>
            [FieldOffset(4)] VertexInstanceID VertexInstanceID1;

            ///<summary>Third vertex instance that makes up this triangle.  Indices must be ordered counter-clockwise.</summary>
            [FieldOffset(8)] VertexInstanceID VertexInstanceID2;

        }
}
