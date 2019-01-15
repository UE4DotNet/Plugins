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


namespace UE4.CoreUObject{
        ///<summary>Represents a time by a context-free frame number, plus a sub frame value in the range [0:1).</summary>
        [StructLayout( LayoutKind.Explicit, Size=8 )]
        public unsafe struct FrameTime {
            ///<summary>Frame Number</summary>
            [FieldOffset(0)] FrameNumber FrameNumber;

            [FieldOffset(4)] public float SubFrame;

        }
}
