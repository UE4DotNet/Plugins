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


namespace UE4.MovieScene{
        ///<summary>Structure that references a sorted array of segments by indirect identifiers</summary>
        [StructLayout( LayoutKind.Explicit, Size=32 )]
        public unsafe struct MovieSceneEvaluationTrackSegments {
            [FieldOffset(0)] byte SegmentIdentifierToIndex; //TODO: array TArray SegmentIdentifierToIndex

            [FieldOffset(16)] byte SortedSegments; //TODO: array TArray SortedSegments

        }
}
