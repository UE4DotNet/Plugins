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
        ///<summary>Vertex and Attributes</summary>
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        public unsafe struct VertexAndAttributes {
            ///<summary>The vertex instance ID to insert into the polygon, or FVertexInstanceID::Invalid to create a new vertex instance with the given attributes</summary>
            [FieldOffset(0)] VertexInstanceID VertexInstanceID;

            ///<summary>The vertex ID to insert into the polygon, if no valid vertex instance ID was supplied.</summary>
            [FieldOffset(4)] VertexID VertexID;

            ///<summary>A list of polygon attributes to set for the vertex on the polygon we're inserting it into, if no valid vertex instance ID was supplied.</summary>
            [FieldOffset(8)] MeshElementAttributeList PolygonVertexAttributes;

        }
}
