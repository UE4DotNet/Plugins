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
        ///<summary>Vertex Instance to Create</summary>
        [StructLayout( LayoutKind.Explicit, Size=32 )]
        public unsafe struct VertexInstanceToCreate {
            ///<summary>Vertex ID which is being instanced</summary>
            [FieldOffset(0)] VertexID VertexID;

            ///<summary>Attributes of this vertex instance</summary>
            [FieldOffset(8)] MeshElementAttributeList VertexInstanceAttributes;

            ///<summary>The original ID of the vertex instance.  Should only be used by the undo system.</summary>
            [FieldOffset(24)] VertexInstanceID OriginalVertexInstanceID;

        }
}
