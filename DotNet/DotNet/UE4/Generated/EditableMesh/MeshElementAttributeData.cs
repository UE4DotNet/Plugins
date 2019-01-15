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
        ///<summary>Mesh Element Attribute Data</summary>
        [StructLayout( LayoutKind.Explicit, Size=96 )]
        public unsafe struct MeshElementAttributeData {
            [FieldOffset(0)] public Name AttributeName;

            [FieldOffset(12)] public int AttributeIndex;

            ///<summary>The value of this attribute</summary>
            [FieldOffset(16)] MeshElementAttributeValue AttributeValue;

        }
}
