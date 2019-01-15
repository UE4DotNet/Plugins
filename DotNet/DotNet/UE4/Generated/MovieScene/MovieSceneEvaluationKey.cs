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
        ///<summary>Keyable struct that represents a particular entity within an evaluation template (either a section/template or a track)</summary>
        [StructLayout( LayoutKind.Explicit, Size=12 )]
        public unsafe struct MovieSceneEvaluationKey {
            ///<summary>ID of the sequence that the entity is contained within</summary>
            [FieldOffset(0)] MovieSceneSequenceID SequenceID;

            ///<summary>ID of the track this key relates to</summary>
            [FieldOffset(4)] MovieSceneTrackIdentifier TrackIdentifier;

            [FieldOffset(8)] byte SectionIndex; //TODO: numeric uint32 SectionIndex

        }
}
