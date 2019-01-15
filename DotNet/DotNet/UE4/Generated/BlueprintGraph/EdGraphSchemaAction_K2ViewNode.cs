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


namespace UE4.BlueprintGraph{
        ///<summary>Action to view a node to the graph</summary>
        [StructLayout( LayoutKind.Explicit, Size=264 )]
        public unsafe struct EdGraphSchemaAction_K2ViewNode {
            [FieldOffset(256)] 
            private IntPtr  NodePtr_field;
            ///<summary>node we want to view</summary>
            public K2Node NodePtr {
                get {return NodePtr_field;}
                set {NodePtr_field = value;}
            }

        }
}
