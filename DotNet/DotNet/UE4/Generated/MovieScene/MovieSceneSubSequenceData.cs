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
        ///<summary>Sub sequence data that is stored within an evaluation template as a backreference to the originating sequence, and section</summary>
        [StructLayout( LayoutKind.Explicit, Size=232 )]
        public unsafe struct MovieSceneSubSequenceData {
            ///<summary>The sequence that the sub section references</summary>
            [FieldOffset(0)] SoftObjectPath Sequence;

            ///<summary>Transform that transforms a given time from the sequences outer space, to its authored space.</summary>
            [FieldOffset(32)] MovieSceneSequenceTransform RootToSequenceTransform;

            ///<summary>The tick resolution of the inner sequence.</summary>
            [FieldOffset(44)] FrameRate TickResolution;

            ///<summary>This sequence's deterministic sequence ID. Used in editor to reduce the risk of collisions on recompilation.</summary>
            [FieldOffset(52)] MovieSceneSequenceID DeterministicSequenceID;

            ///<summary>This sub sequence's playback range according to its parent sub section. Clamped recursively during template generation</summary>
            [FieldOffset(56)] MovieSceneFrameRange PlayRange;

            ///<summary>The sequence preroll range considering the start offset</summary>
            [FieldOffset(88)] MovieSceneFrameRange PreRollRange;

            ///<summary>The sequence postroll range considering the start offset</summary>
            [FieldOffset(120)] MovieSceneFrameRange PostRollRange;

            [FieldOffset(152)] public int HierarchicalBias;

            ///<summary>Instance data that should be used for any tracks contained immediately within this sub sequence</summary>
            [FieldOffset(160)] MovieSceneSequenceInstanceDataPtr InstanceData;

            [FieldOffset(184)] public Name SectionPath;

            ///<summary>The sub section's signature at the time this structure was populated.</summary>
            [FieldOffset(204)] FGuid SubSectionSignature;

            ///<summary>The transform from this sub sequence's parent to its own play space.</summary>
            [FieldOffset(220)] MovieSceneSequenceTransform OuterToInnerTransform;

        }
}
