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

using UE4.MeshDescription;

namespace UE4.EditableMesh{
        ///<summary>Vertex to Move</summary>
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        public unsafe struct VertexToMove {
            ///<summary>The vertex we'll be moving around</summary>
            [FieldOffset(0)] VertexID VertexID;

            ///<summary>The new position of the vertex</summary>
            [FieldOffset(4)] Vector NewVertexPosition;

        }
}
