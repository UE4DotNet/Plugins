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
        ///<summary>Vertices for Edge</summary>
        [StructLayout( LayoutKind.Explicit, Size=12 )]
        public unsafe struct VerticesForEdge {
            ///<summary>The edge ID</summary>
            [FieldOffset(0)] EdgeID EdgeID;

            ///<summary>First new vertex ID for this edge</summary>
            [FieldOffset(4)] VertexID NewVertexID0;

            ///<summary>Second new vertex ID for this edge</summary>
            [FieldOffset(8)] VertexID NewVertexID1;

        }
}
