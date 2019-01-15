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
        ///<summary>Virtual Bone</summary>
        [StructLayout( LayoutKind.Explicit, Size=36 )]
        public unsafe struct VirtualBone {
            [FieldOffset(0)] public Name SourceBoneName;

            [FieldOffset(12)] public Name TargetBoneName;

            [FieldOffset(24)] public Name VirtualBoneName;

        }
}
