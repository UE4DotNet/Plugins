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
        ///<summary>Action to add a node to the graph</summary>
        [StructLayout( LayoutKind.Explicit, Size=264 )]
        public unsafe struct EdGraphSchemaAction_NewNode {
            [FieldOffset(256)] 
            private IntPtr  NodeTemplate_field;
            ///<summary>Template of node we want to create</summary>
            public EdGraphNode NodeTemplate {
                get {return NodeTemplate_field;}
                set {NodeTemplate_field = value;}
            }

        }
}
