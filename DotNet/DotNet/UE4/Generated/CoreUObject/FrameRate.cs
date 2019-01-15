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
        ///<summary>A frame rate represented as a fraction comprising 2 integers: a numerator (number of frames), and a denominator (per second).</summary>
        [StructLayout( LayoutKind.Explicit, Size=8 )]
        public unsafe struct FrameRate {
            [FieldOffset(0)] public int Numerator;

            [FieldOffset(4)] public int Denominator;

        }
}
