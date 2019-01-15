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


namespace UE4.LinearTimecode{
        ///<summary>Hold a frame of a Linear Timecode Frame</summary>
        [StructLayout( LayoutKind.Explicit, Size=28 )]
        public unsafe struct DropTimecode {
            ///<summary>Decoded Timecode</summary>
            [FieldOffset(0)] Timecode Timecode;

            [FieldOffset(20)] public int FrameRate;

            [FieldOffset(24)] public bool bColorFraming;

            [FieldOffset(25)] public bool bRunningForward;

            [FieldOffset(26)] public bool bNewFrame;

        }
}
