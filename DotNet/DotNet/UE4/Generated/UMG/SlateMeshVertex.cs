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


namespace UE4.UMG{
        ///<summary>Slate Mesh Vertex</summary>
        [StructLayout( LayoutKind.Explicit, Size=60 )]
        public unsafe struct SlateMeshVertex {
            ///<summary>Position</summary>
            [FieldOffset(0)] Vector2D Position;

            ///<summary>Color</summary>
            [FieldOffset(8)] Color Color;

            ///<summary>UV0</summary>
            [FieldOffset(12)] Vector2D UV0;

            ///<summary>UV1</summary>
            [FieldOffset(20)] Vector2D UV1;

            ///<summary>UV2</summary>
            [FieldOffset(28)] Vector2D UV2;

            ///<summary>UV3</summary>
            [FieldOffset(36)] Vector2D UV3;

            ///<summary>UV4</summary>
            [FieldOffset(44)] Vector2D UV4;

            ///<summary>UV5</summary>
            [FieldOffset(52)] Vector2D UV5;

        }
}
