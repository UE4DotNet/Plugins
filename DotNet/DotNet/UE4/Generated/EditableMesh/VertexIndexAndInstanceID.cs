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
        ///<summary>Vertex Index and Instance ID</summary>
        [StructLayout( LayoutKind.Explicit, Size=8 )]
        public unsafe struct VertexIndexAndInstanceID {
            [FieldOffset(0)] public int ContourIndex;

            ///<summary>New vertex instance ID to assign</summary>
            [FieldOffset(4)] VertexInstanceID VertexInstanceID;

        }
}
