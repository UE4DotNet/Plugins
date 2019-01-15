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
        ///<summary>Vertex Pair</summary>
        [StructLayout( LayoutKind.Explicit, Size=8 )]
        public unsafe struct VertexPair {
            ///<summary>The first vertex ID in this pair</summary>
            [FieldOffset(0)] VertexID VertexID0;

            ///<summary>The second vertex ID in this pair</summary>
            [FieldOffset(4)] VertexID VertexID1;

        }
}
