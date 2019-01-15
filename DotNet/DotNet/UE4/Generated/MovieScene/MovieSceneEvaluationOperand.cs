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
        ///<summary>Structure that describes an object that is to be animated. Used as an abstraction of the actual objects bound to object bindings.</summary>
        [StructLayout( LayoutKind.Explicit, Size=20 )]
        public unsafe struct MovieSceneEvaluationOperand {
            ///<summary>A GUID relating to either a posessable, or a spawnable binding</summary>
            [FieldOffset(0)] FGuid ObjectBindingID;

            ///<summary>The ID of the sequence within which the object binding resides</summary>
            [FieldOffset(16)] MovieSceneSequenceID SequenceID;

        }
}
