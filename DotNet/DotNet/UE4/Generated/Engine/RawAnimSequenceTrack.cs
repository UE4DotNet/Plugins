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
        ///<summary>Raw keyframe data for one track.</summary>
        ///<remarks>
        ///Each array will contain either NumFrames elements or 1 element.
        ///One element is used as a simple compression scheme where if all keys are the same, they'll be
        ///reduced to 1 key that is constant over the entire sequence.
        ///</remarks>
        [StructLayout( LayoutKind.Explicit, Size=48 )]
        public unsafe struct RawAnimSequenceTrack {
            [FieldOffset(0)] byte PosKeys; //TODO: array TArray PosKeys

            [FieldOffset(16)] byte RotKeys; //TODO: array TArray RotKeys

            [FieldOffset(32)] byte ScaleKeys; //TODO: array TArray ScaleKeys

        }
}
