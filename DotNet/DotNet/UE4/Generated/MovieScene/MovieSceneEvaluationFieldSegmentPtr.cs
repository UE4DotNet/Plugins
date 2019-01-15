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
        ///<summary>A pointer to a particular segment of a track held within an evaluation template</summary>
        [StructLayout( LayoutKind.Explicit, Size=12 )]
        public unsafe struct MovieSceneEvaluationFieldSegmentPtr {
            ///<summary>The identifier of the segment within the track (see FMovieSceneEvaluationTrack::Segments)</summary>
            [FieldOffset(8)] MovieSceneSegmentIdentifier SegmentID;

        }
}
