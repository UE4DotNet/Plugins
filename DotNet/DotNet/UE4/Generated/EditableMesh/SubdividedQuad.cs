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


namespace UE4.EditableMesh{
        ///<summary>Subdivided Quad</summary>
        [StructLayout( LayoutKind.Explicit, Size=208 )]
        public unsafe struct SubdividedQuad {
            ///<summary>The vertices for the four corners of this quad</summary>
            [FieldOffset(0)] SubdividedQuadVertex QuadVertex0;

            ///<summary>Quad Vertex 1</summary>
            [FieldOffset(52)] SubdividedQuadVertex QuadVertex1;

            ///<summary>Quad Vertex 2</summary>
            [FieldOffset(104)] SubdividedQuadVertex QuadVertex2;

            ///<summary>Quad Vertex 3</summary>
            [FieldOffset(156)] SubdividedQuadVertex QuadVertex3;

        }
}
