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


namespace UE4.MovieSceneCapture{
        ///<summary>Metrics that correspond to a particular frame</summary>
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        public unsafe struct FrameMetrics {
            [FieldOffset(0)] public float TotalElapsedTime;

            [FieldOffset(4)] public float FrameDelta;

            [FieldOffset(8)] public int FrameNumber;

            [FieldOffset(12)] public int NumDroppedFrames;

        }
}
