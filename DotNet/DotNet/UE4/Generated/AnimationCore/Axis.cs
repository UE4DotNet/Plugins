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
        ///<summary>Axis to represent direction</summary>
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        public unsafe struct Axis {
            ///<summary>Axis</summary>
            [FieldOffset(0)] Vector Axis_;

            [FieldOffset(12)] public bool bInLocalSpace;

        }
}
