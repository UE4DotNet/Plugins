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
        ///<summary>Pose data container</summary>
        ///<remarks>Contains animation and curve for all poses</remarks>
        [StructLayout( LayoutKind.Explicit, Size=144 )]
        public unsafe struct PoseDataContainer {
            [FieldOffset(0)] byte PoseNames; //TODO: array TArray PoseNames

            [FieldOffset(16)] byte Tracks; //TODO: array TArray Tracks

            [FieldOffset(32)] byte TrackMap; //TODO: map TMap TrackMap

            [FieldOffset(112)] byte Poses; //TODO: array TArray Poses

            [FieldOffset(128)] byte Curves; //TODO: array TArray Curves

        }
}
