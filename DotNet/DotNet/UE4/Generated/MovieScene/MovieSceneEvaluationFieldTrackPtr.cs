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
        ///<summary>A pointer to a track held within an evaluation template</summary>
        [StructLayout( LayoutKind.Explicit, Size=8 )]
        public unsafe struct MovieSceneEvaluationFieldTrackPtr {
            ///<summary>The sequence ID that identifies to which sequence the track belongs</summary>
            [FieldOffset(0)] MovieSceneSequenceID SequenceID;

            ///<summary>The Identifier of the track inside the track map (see FMovieSceneEvaluationTemplate::Tracks)</summary>
            [FieldOffset(4)] MovieSceneTrackIdentifier TrackIdentifier;

        }
}
