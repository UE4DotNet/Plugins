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
        ///<summary>Structure used for movie scene evaluation templates contained within a track.</summary>
        ///<remarks>
        ///Typically these are defined as one per-section.
        ///Serialized into a FMovieSceneEvaluationTemplate contained within the sequence itself (for fast initialization at runtime).
        ///Templates are executed in a 3-phase algorithm:
        ///            1) Initialize: (opt-in) Called at the start of the frame. Able to access mutable state from the playback context. Used to initialize any persistent state required for the evaluation pass.
        ///            2) Evaluate: Potentially called on a thread. Should (where possible) perform all costly evaluation logic, accumulating into execution tokens which will be executed at a later time on the game thread.
        ///            3) Execute: Called on all previously submitted execution tokens to apply the evaluated state to the movie scene player
        ///</remarks>
        [StructLayout( LayoutKind.Explicit, Size=32 )]
        public unsafe struct MovieSceneEvalTemplate {
            [FieldOffset(16)] byte CompletionMode; //TODO: enum EMovieSceneCompletionMode CompletionMode

            [FieldOffset(24)] 
            private IntPtr  SourceSection_field;
            ///<summary>The section from which this template originates</summary>
            public MovieSceneSection SourceSection {
                get {return SourceSection_field;}
                set {SourceSection_field = value;}
            }

        }
}
