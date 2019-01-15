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

using UE4.Engine;

namespace UE4.AnimGraph{
        ///<summary>Node Spawn Data</summary>
        [StructLayout( LayoutKind.Explicit, Size=80 )]
        public unsafe struct NodeSpawnData {
            [FieldOffset(0)] byte CachedTitle; //TODO: text FText CachedTitle

            [FieldOffset(24)] 
            private IntPtr  SourceNode_field;
            ///<summary>The node the spawned getter accesses</summary>
            public AnimGraphNode_Base SourceNode {
                get {return SourceNode_field;}
                set {SourceNode_field = value;}
            }

            [FieldOffset(32)] 
            private IntPtr  SourceStateNode_field;
            ///<summary>The state node the spawned getter accesses</summary>
            public AnimStateNodeBase SourceStateNode {
                get {return SourceStateNode_field;}
                set {SourceStateNode_field = value;}
            }

            ///<summary>The instance class the spawned getter is defined on</summary>
            public SubclassOf<UObject> AnimInstanceClass {
                get {return AnimInstanceClass_class; }
                set {AnimInstanceClass_class = value; }
            }
            [FieldOffset(40)] private IntPtr AnimInstanceClass_class;

            [FieldOffset(48)] 
            private IntPtr  SourceBlueprint_field;
            ///<summary>The blueprint the getter is valid within</summary>
            public AnimBlueprint SourceBlueprint {
                get {return SourceBlueprint_field;}
                set {SourceBlueprint_field = value;}
            }

            [FieldOffset(56)] 
            private IntPtr  Getter_field;
            ///<summary>The UFunction (as a UField)</summary>
            public Field Getter {
                get {return Getter_field;}
                set {Getter_field = value;}
            }

            [FieldOffset(64)] byte GetterContextString; //TODO: string FString GetterContextString

        }
}
