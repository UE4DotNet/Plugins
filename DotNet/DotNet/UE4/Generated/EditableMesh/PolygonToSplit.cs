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
        ///<summary>Polygon to Split</summary>
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        public unsafe struct PolygonToSplit {
            ///<summary>The polygon that we'll be splitting</summary>
            [FieldOffset(0)] PolygonID PolygonID;

            [FieldOffset(8)] byte VertexPairsToSplitAt; //TODO: array TArray VertexPairsToSplitAt

        }
}
