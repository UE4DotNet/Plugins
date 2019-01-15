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
        ///<summary>Evaluation track that is stored within an evaluation template for a sequence.</summary>
        ///<remarks>Contains user-defined evaluation templates, and an optional track implementation</remarks>
        [StructLayout( LayoutKind.Explicit, Size=248 )]
        public unsafe struct MovieSceneEvaluationTrack {
            ///<summary>ID of the possessable or spawnable within the UMovieScene this track belongs to, if any. Zero guid where this relates to a master track.</summary>
            [FieldOffset(0)] FGuid ObjectBindingID;

            [FieldOffset(16)] byte EvaluationPriority; //TODO: numeric uint16 EvaluationPriority

            [FieldOffset(18)] byte EvaluationMethod; //TODO: enum EEvaluationMethod EvaluationMethod

            ///<summary>Array of segmented ranges contained within the track.</summary>
            [FieldOffset(24)] MovieSceneEvaluationTrackSegments Segments;

            [FieldOffset(56)] 
            private IntPtr  SourceTrack_field;
            ///<summary>The movie scene track that created this evaluation track.</summary>
            public MovieSceneTrack SourceTrack {
                get {return SourceTrack_field;}
                set {SourceTrack_field = value;}
            }

            ///<summary>Evaluation tree specifying what happens at any given time.</summary>
            [FieldOffset(64)] SectionEvaluationDataTree EvaluationTree;

            [FieldOffset(160)] byte ChildTemplates; //TODO: array TArray ChildTemplates

            ///<summary>Domain-specific track implementation override.</summary>
            [FieldOffset(176)] MovieSceneTrackImplementationPtr TrackTemplate;

            [FieldOffset(232)] public Name EvaluationGroup;

            [FieldOffset(244)] public bool bEvaluateInPreroll;

            [FieldOffset(244)] public bool bEvaluateInPostroll;

        }
}
