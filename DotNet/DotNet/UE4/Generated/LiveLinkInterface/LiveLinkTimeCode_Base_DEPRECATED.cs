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


namespace UE4.LiveLinkInterface{
        ///<summary>Live Link Time Code Base DEPRECATED</summary>
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        public unsafe struct LiveLinkTimeCode_Base_DEPRECATED {
            [FieldOffset(0)] public int Seconds;

            [FieldOffset(4)] public int Frames;

            ///<summary>Value calculated on create to represent the different between the source time and client time</summary>
            [FieldOffset(8)] LiveLinkFrameRate FrameRate;

        }
}
