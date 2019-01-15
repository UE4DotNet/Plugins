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
        ///<summary>Polygon to Create</summary>
        [StructLayout( LayoutKind.Explicit, Size=48 )]
        public unsafe struct PolygonToCreate {
            ///<summary>The group the polygon will be added to</summary>
            [FieldOffset(0)] PolygonGroupID PolygonGroupID;

            [FieldOffset(8)] byte PerimeterVertices; //TODO: array TArray PerimeterVertices

            [FieldOffset(24)] byte PolygonHoles; //TODO: array TArray PolygonHoles

            ///<summary>The original ID of the polygon.  Should only be used by the undo system.</summary>
            [FieldOffset(40)] PolygonID OriginalPolygonID;

            [FieldOffset(44)] byte PolygonEdgeHardness; //TODO: enum EPolygonEdgeHardness PolygonEdgeHardness

        }
}
