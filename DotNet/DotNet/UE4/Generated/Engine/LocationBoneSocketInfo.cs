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


namespace UE4.Engine{
        ///<summary>Location Bone Socket Info</summary>
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        public unsafe struct LocationBoneSocketInfo {
            [FieldOffset(0)] public Name BoneSocketName;

            ///<summary>The offset from the bone/socket to use</summary>
            [FieldOffset(12)] Vector Offset;

        }
}
