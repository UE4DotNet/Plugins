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
        ///<summary>Simple structure specifying parent and child sequence IDs for any given sequences</summary>
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        public unsafe struct MovieSceneSequenceHierarchyNode {
            ///<summary>Movie scene sequence ID of this node's parent sequence</summary>
            [FieldOffset(0)] MovieSceneSequenceID ParentID;

            [FieldOffset(8)] byte Children; //TODO: array TArray Children

        }
}
