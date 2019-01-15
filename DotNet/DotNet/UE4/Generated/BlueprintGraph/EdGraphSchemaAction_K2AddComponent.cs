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

namespace UE4.BlueprintGraph{
        ///<summary>Action to add an 'add component' node to the graph</summary>
        [StructLayout( LayoutKind.Explicit, Size=288 )]
        public unsafe struct EdGraphSchemaAction_K2AddComponent {
            ///<summary>Class of component we want to add</summary>
            public SubclassOf<ActorComponent> ComponentClass {
                get {return ComponentClass_class; }
                set {ComponentClass_class = value; }
            }
            [FieldOffset(272)] private IntPtr ComponentClass_class;

            [FieldOffset(280)] 
            private IntPtr  ComponentAsset_field;
            ///<summary>Option asset to assign to newly created component</summary>
            public UObject ComponentAsset {
                get {return ComponentAsset_field;}
                set {ComponentAsset_field = value;}
            }

        }
}
