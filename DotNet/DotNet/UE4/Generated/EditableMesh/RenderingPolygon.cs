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
        ///<summary>Rendering Polygon</summary>
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        public unsafe struct RenderingPolygon {
            ///<summary>Which rendering polygon group the polygon is in</summary>
            [FieldOffset(0)] PolygonGroupID PolygonGroupID;

            [FieldOffset(8)] byte TriangulatedPolygonTriangleIndices; //TODO: array TArray TriangulatedPolygonTriangleIndices

        }
}
