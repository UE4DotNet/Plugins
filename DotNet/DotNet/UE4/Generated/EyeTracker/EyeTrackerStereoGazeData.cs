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


namespace UE4.EyeTracker{
        ///<summary>Stereo gaze data that contains information for each eye individually.</summary>
        ///<remarks>This may not be available with all devices.</remarks>
        [StructLayout( LayoutKind.Explicit, Size=64 )]
        public unsafe struct EyeTrackerStereoGazeData {
            ///<summary>Origin of the left eye's gaze ray.</summary>
            [FieldOffset(0)] Vector LeftEyeOrigin;

            ///<summary>Forward direction of the left eye's gaze ray.</summary>
            [FieldOffset(12)] Vector LeftEyeDirection;

            ///<summary>Origin of the right eye's gaze ray.</summary>
            [FieldOffset(24)] Vector RightEyeOrigin;

            ///<summary>Forward direction of the right eye's gaze ray.</summary>
            [FieldOffset(36)] Vector RightEyeDirection;

            ///<summary>Location that the eyes converge. This is the 3d point where the tracked viewer is looking.</summary>
            [FieldOffset(48)] Vector FixationPoint;

            [FieldOffset(60)] public float ConfidenceValue;

        }
}
