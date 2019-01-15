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


namespace UE4.MeshEditor{
        ///<summary>Overlay Triangle Vertex</summary>
        [StructLayout( LayoutKind.Explicit, Size=36 )]
        public unsafe struct OverlayTriangleVertex {
            ///<summary>Position</summary>
            [FieldOffset(0)] Vector Position;

            ///<summary>UV</summary>
            [FieldOffset(12)] Vector2D UV;

            ///<summary>Normal</summary>
            [FieldOffset(20)] Vector Normal;

            ///<summary>Color</summary>
            [FieldOffset(32)] Color Color;

        }
}
