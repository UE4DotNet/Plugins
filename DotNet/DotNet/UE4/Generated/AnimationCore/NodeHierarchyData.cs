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


namespace UE4.AnimationCore{
        ///<summary>Hierarchy of nodes</summary>
        [StructLayout( LayoutKind.Explicit, Size=112 )]
        public unsafe struct NodeHierarchyData {
            [FieldOffset(0)] byte Nodes; //TODO: array TArray Nodes

            [FieldOffset(16)] byte Transforms; //TODO: array TArray Transforms

            [FieldOffset(32)] byte NodeNameToIndexMapping; //TODO: map TMap NodeNameToIndexMapping

        }
}
