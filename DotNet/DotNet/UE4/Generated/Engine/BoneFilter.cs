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
        ///<summary>Bone Filter</summary>
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        public unsafe struct BoneFilter {
            [FieldOffset(0)] public bool bExcludeSelf;

            [FieldOffset(4)] public Name BoneName;

        }
}
