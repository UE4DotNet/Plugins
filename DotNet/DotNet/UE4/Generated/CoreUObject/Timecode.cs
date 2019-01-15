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
        ///<summary>A timecode that stores time in HH:MM:SS format with the remainder of time represented by an integer frame count.</summary>
        [StructLayout( LayoutKind.Explicit, Size=20 )]
        public unsafe struct Timecode {
            [FieldOffset(0)] public int Hours;

            [FieldOffset(4)] public int Minutes;

            [FieldOffset(8)] public int Seconds;

            [FieldOffset(12)] public int Frames;

            [FieldOffset(16)] public bool bDropFrameFormat;

        }
}
