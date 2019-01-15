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
        ///<summary>Struct that stores the key for an evaluated entity, and the index at which it was (or is to be) evaluated</summary>
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        public unsafe struct MovieSceneOrderedEvaluationKey {
            ///<summary>Key</summary>
            [FieldOffset(0)] MovieSceneEvaluationKey Key;

            [FieldOffset(12)] byte EvaluationIndex; //TODO: numeric uint32 EvaluationIndex

        }
}
