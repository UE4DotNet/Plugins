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
        ///<summary>Persistent identifier to a specific object binding within a sequence hierarchy.</summary>
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        public unsafe struct MovieSceneObjectBindingID {
            [FieldOffset(0)] public int SequenceID;

            [FieldOffset(4)] byte Space; //TODO: enum EMovieSceneObjectBindingSpace Space

            ///<summary>Identifier for the object binding within the sequence</summary>
            [FieldOffset(8)] FGuid FGuid;

        }
}
