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

using UE4.Engine;

namespace UE4.MeshEditor{
        ///<summary>Overlay Triangle</summary>
        [StructLayout( LayoutKind.Explicit, Size=120 )]
        public unsafe struct OverlayTriangle {
            [FieldOffset(0)] 
            private IntPtr  Material_field;
            ///<summary>Material</summary>
            public MaterialInterface Material {
                get {return Material_field;}
                set {Material_field = value;}
            }

            ///<summary>Vertex 0</summary>
            [FieldOffset(8)] OverlayTriangleVertex Vertex0;

            ///<summary>Vertex 1</summary>
            [FieldOffset(44)] OverlayTriangleVertex Vertex1;

            ///<summary>Vertex 2</summary>
            [FieldOffset(80)] OverlayTriangleVertex Vertex2;

        }
}
