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
        ///<summary>Node Information to save with</summary>
        [StructLayout( LayoutKind.Explicit, Size=64 )]
        public unsafe struct NodeItem {
            [FieldOffset(0)] public Name ParentName;

            ///<summary>Space transform (Not based on parent). Used by control rig system</summary>
            [FieldOffset(16)] Transform Transform;

        }
}
