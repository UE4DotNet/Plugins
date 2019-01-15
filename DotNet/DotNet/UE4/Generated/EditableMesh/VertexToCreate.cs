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
        ///<summary>Vertex to Create</summary>
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        public unsafe struct VertexToCreate {
            ///<summary>Attributes of this vertex itself</summary>
            [FieldOffset(0)] MeshElementAttributeList VertexAttributes;

            ///<summary>The original ID of the vertex.  Should only be used by the undo system.</summary>
            [FieldOffset(16)] VertexID OriginalVertexID;

        }
}
