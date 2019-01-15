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
        ///<summary>Memory layout optimized primarily for speed of searching the applicable ranges</summary>
        [StructLayout( LayoutKind.Explicit, Size=64 )]
        public unsafe struct MovieSceneEvaluationField {
            ///<summary>Signature that uniquely identifies any state this field can be in - regenerated on mutation</summary>
            [FieldOffset(0)] FGuid Signature;

            [FieldOffset(16)] byte Ranges; //TODO: array TArray Ranges

            [FieldOffset(32)] byte Groups; //TODO: array TArray Groups

            [FieldOffset(48)] byte MetaData; //TODO: array TArray MetaData

        }
}
