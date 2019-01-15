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
        ///<summary>Array of group names to retrieve position and rotation data from instead of using the data stored in the keyframe.</summary>
        ///<remarks>
        ///A value of NAME_None means to use the PosTrack and EulerTrack data for the keyframe.
        ///There needs to be the same amount of elements in this array as there are keyframes.
        ///</remarks>
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        public unsafe struct InterpLookupPoint {
            [FieldOffset(0)] public Name GroupName;

            [FieldOffset(12)] public float Time;

        }
}
