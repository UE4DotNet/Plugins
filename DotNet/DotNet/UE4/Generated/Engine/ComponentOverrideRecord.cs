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
        ///<summary>Component Override Record</summary>
        [StructLayout( LayoutKind.Explicit, Size=144 )]
        public unsafe struct ComponentOverrideRecord {
            ///<summary>Component Class</summary>
            public SubclassOf<UObject> ComponentClass {
                get {return ComponentClass_class; }
                set {ComponentClass_class = value; }
            }
            [FieldOffset(0)] private IntPtr ComponentClass_class;

            [FieldOffset(8)] 
            private IntPtr  ComponentTemplate_field;
            ///<summary>Component Template</summary>
            public ActorComponent ComponentTemplate {
                get {return ComponentTemplate_field;}
                set {ComponentTemplate_field = value;}
            }

            ///<summary>Component Key</summary>
            [FieldOffset(16)] ComponentKey ComponentKey;

            ///<summary>Cooked Component Instancing Data</summary>
            [FieldOffset(56)] BlueprintCookedComponentInstancingData CookedComponentInstancingData;

        }
}
