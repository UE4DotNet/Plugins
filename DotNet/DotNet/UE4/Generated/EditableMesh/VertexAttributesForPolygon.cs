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
        ///<summary>Vertex Attributes for Polygon</summary>
        [StructLayout( LayoutKind.Explicit, Size=40 )]
        public unsafe struct VertexAttributesForPolygon {
            ///<summary>The polygon to set vertex attributes on</summary>
            [FieldOffset(0)] PolygonID PolygonID;

            [FieldOffset(8)] byte PerimeterVertexAttributeLists; //TODO: array TArray PerimeterVertexAttributeLists

            [FieldOffset(24)] byte VertexAttributeListsForEachHole; //TODO: array TArray VertexAttributeListsForEachHole

        }
}
