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
        ///<summary>Structure that stores hierarchical information pertaining to all sequences contained within a master sequence</summary>
        [StructLayout( LayoutKind.Explicit, Size=160 )]
        public unsafe struct MovieSceneSequenceHierarchy {
            [FieldOffset(0)] byte SubSequences; //TODO: map TMap SubSequences

            [FieldOffset(80)] byte Hierarchy; //TODO: map TMap Hierarchy

        }
}
