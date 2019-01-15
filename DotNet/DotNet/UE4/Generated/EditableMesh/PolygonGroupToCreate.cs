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
        ///<summary>Polygon Group to Create</summary>
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        public unsafe struct PolygonGroupToCreate {
            ///<summary>Attributes of this polygon group</summary>
            [FieldOffset(0)] MeshElementAttributeList PolygonGroupAttributes;

            ///<summary>The original ID of the polygon group.  Should only be used by the undo system.</summary>
            [FieldOffset(16)] PolygonGroupID OriginalPolygonGroupID;

        }
}
