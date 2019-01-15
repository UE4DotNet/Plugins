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

#pragma warning disable CS0108
using UE4.BlueprintGraph.Native;

namespace UE4.BlueprintGraph {
    ///<summary>K2Node Component Bound Event</summary>
    public unsafe partial class K2Node_ComponentBoundEvent : K2Node_Event  {
        ///<summary>Delegate property name that this event is associated with</summary>
        public unsafe Name DelegatePropertyName {
            get {return K2Node_ComponentBoundEvent_ptr->DelegatePropertyName;}
            set {K2Node_ComponentBoundEvent_ptr->DelegatePropertyName = value;}
        }
        ///<summary>Delegate property's owner class that this event is associated with</summary>
        public unsafe SubclassOf<UObject> DelegateOwnerClass {
            get {return K2Node_ComponentBoundEvent_ptr->DelegateOwnerClass;}
            set {K2Node_ComponentBoundEvent_ptr->DelegateOwnerClass = value;}
        }
        ///<summary>Name of property in Blueprint class that pointer to component we want to bind to</summary>
        public unsafe Name ComponentPropertyName {
            get {return K2Node_ComponentBoundEvent_ptr->ComponentPropertyName;}
            set {K2Node_ComponentBoundEvent_ptr->ComponentPropertyName = value;}
        }
         //TODO: text FText DelegatePropertyDisplayName
        static K2Node_ComponentBoundEvent() {
            StaticClass = Main.GetClass("K2Node_ComponentBoundEvent");
        }
        internal unsafe K2Node_ComponentBoundEvent_fields* K2Node_ComponentBoundEvent_ptr => (K2Node_ComponentBoundEvent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator K2Node_ComponentBoundEvent(IntPtr p) => UObject.Make<K2Node_ComponentBoundEvent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static K2Node_ComponentBoundEvent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static K2Node_ComponentBoundEvent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
