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
        ///<summary>Edge to Create</summary>
        [StructLayout( LayoutKind.Explicit, Size=48 )]
        public unsafe struct EdgeToCreate {
            ///<summary>The first vertex this edge connects</summary>
            [FieldOffset(0)] VertexID VertexID0;

            ///<summary>The second vertex this edge connects</summary>
            [FieldOffset(4)] VertexID VertexID1;

            [FieldOffset(8)] byte ConnectedPolygons; //TODO: array TArray ConnectedPolygons

            ///<summary>Attributes of this edge itself</summary>
            [FieldOffset(24)] MeshElementAttributeList EdgeAttributes;

            ///<summary>The original ID of the edge.  Should only be used by the undo system.</summary>
            [FieldOffset(40)] EdgeID OriginalEdgeID;

        }
}
