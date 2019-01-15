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
        ///<summary>Subdivided Quad Vertex</summary>
        [StructLayout( LayoutKind.Explicit, Size=52 )]
        public unsafe struct SubdividedQuadVertex {
            [FieldOffset(0)] public int VertexPositionIndex;

            ///<summary>Texture coordinates for this vertex.  We only support up to two, for now. (Just to avoid TArrays/allocations)</summary>
            [FieldOffset(4)] Vector2D TextureCoordinate0;

            ///<summary>Texture Coordinate 1</summary>
            [FieldOffset(12)] Vector2D TextureCoordinate1;

            ///<summary>Vertex color</summary>
            [FieldOffset(20)] Color VertexColor;

            ///<summary>Quad vertex normal</summary>
            [FieldOffset(24)] Vector VertexNormal;

            ///<summary>Quad vertex tangent</summary>
            [FieldOffset(36)] Vector VertexTangent;

            [FieldOffset(48)] public float VertexBinormalSign;

        }
}
