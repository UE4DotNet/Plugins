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


namespace UE4.CustomMeshComponent{
        ///<summary>Custom Mesh Triangle</summary>
        [StructLayout( LayoutKind.Explicit, Size=36 )]
        public unsafe struct CustomMeshTriangle {
            ///<summary>Vertex 0</summary>
            [FieldOffset(0)] Vector Vertex0;

            ///<summary>Vertex 1</summary>
            [FieldOffset(12)] Vector Vertex1;

            ///<summary>Vertex 2</summary>
            [FieldOffset(24)] Vector Vertex2;

        }
}
