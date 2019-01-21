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
        ///<summary>
        ///Pose data
        ///This is one pose data structure
        ///This will let us blend poses quickly easily
        ///All poses within this asset should contain same number of tracks,
        ///</summary>
        ///<remarks>so that we can blend quickly</remarks>
        [StructLayout( LayoutKind.Explicit, Size=144 )]
        public unsafe struct PoseData {
            [FieldOffset(0)] byte SourceLocalSpacePose; //TODO: array TArray SourceLocalSpacePose

            [FieldOffset(16)] byte SourceCurveData; //TODO: array TArray SourceCurveData

            [FieldOffset(32)] byte LocalSpacePose; //TODO: array TArray LocalSpacePose

            [FieldOffset(48)] byte TrackToBufferIndex; //TODO: map TMap TrackToBufferIndex

            [FieldOffset(128)] byte CurveData; //TODO: array TArray CurveData

        }
}
