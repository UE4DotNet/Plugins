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
        ///<summary>Represents a unified gaze ray that incorporates both eyes.</summary>
        [StructLayout( LayoutKind.Explicit, Size=40 )]
        public unsafe struct EyeTrackerGazeData {
            ///<summary>Origin of the unified gaze ray.</summary>
            [FieldOffset(0)] Vector GazeOrigin;

            ///<summary>Forward direction of the unified gaze ray.</summary>
            [FieldOffset(12)] Vector GazeDirection;

            ///<summary>Location that the eyes converge. This is the 3d point where the tracked viewer is looking.</summary>
            [FieldOffset(24)] Vector FixationPoint;

            [FieldOffset(36)] public float ConfidenceValue;

        }
}
