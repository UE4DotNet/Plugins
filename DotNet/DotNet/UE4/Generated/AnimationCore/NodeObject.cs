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


namespace UE4.AnimationCore{
        ///<summary>A node in a named hierarchy</summary>
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        public unsafe struct NodeObject {
            [FieldOffset(0)] public Name Name;

            [FieldOffset(12)] public Name ParentName;

        }
}
