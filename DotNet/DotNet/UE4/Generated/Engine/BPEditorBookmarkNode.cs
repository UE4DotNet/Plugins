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


namespace UE4.Engine{
        ///<summary>Bookmark node info</summary>
        [StructLayout( LayoutKind.Explicit, Size=56 )]
        public unsafe struct BPEditorBookmarkNode {
            ///<summary>Node ID</summary>
            [FieldOffset(0)] FGuid NodeGuid;

            ///<summary>Parent ID</summary>
            [FieldOffset(16)] FGuid ParentGuid;

            [FieldOffset(32)] byte DisplayName; //TODO: text FText DisplayName

        }
}
