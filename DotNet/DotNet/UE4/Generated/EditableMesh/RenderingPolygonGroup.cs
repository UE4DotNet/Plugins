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


namespace UE4.EditableMesh{
        ///<summary>Rendering Polygon Group</summary>
        [StructLayout( LayoutKind.Explicit, Size=72 )]
        public unsafe struct RenderingPolygonGroup {
            [FieldOffset(0)] byte RenderingSectionIndex; //TODO: numeric uint32 RenderingSectionIndex

            [FieldOffset(4)] public int MaterialIndex;

            [FieldOffset(8)] public int MaxTriangles;

        }
}
