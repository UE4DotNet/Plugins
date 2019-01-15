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
        ///<summary>Attributes for Edge</summary>
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        public unsafe struct AttributesForEdge {
            ///<summary>The edge ID to set attributes on</summary>
            [FieldOffset(0)] EdgeID EdgeID;

            ///<summary>A list of attributes to set for the edge</summary>
            [FieldOffset(8)] MeshElementAttributeList EdgeAttributes;

        }
}
