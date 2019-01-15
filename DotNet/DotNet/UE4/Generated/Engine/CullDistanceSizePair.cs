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
        ///<summary>Helper structure containing size and cull distance pair.</summary>
        [StructLayout( LayoutKind.Explicit, Size=8 )]
        public unsafe struct CullDistanceSizePair {
            [FieldOffset(0)] public float Size;

            [FieldOffset(4)] public float CullDistance;

        }
}
