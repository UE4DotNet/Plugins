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
using UE4.Engine;

namespace UE4.BlueprintGraph {
    ///<summary>K2Node Actor Bound Event</summary>
    public unsafe partial class K2Node_ActorBoundEvent : K2Node_Event  {
        ///<summary>Delegate property name that this event is associated with</summary>
        public unsafe Name DelegatePropertyName {
            get {return K2Node_ActorBoundEvent_ptr->DelegatePropertyName;}
            set {K2Node_ActorBoundEvent_ptr->DelegatePropertyName = value;}
        }
        ///<summary>Delegate property's owner class that this event is associated with</summary>
        public unsafe SubclassOf<UObject> DelegateOwnerClass {
            get {return K2Node_ActorBoundEvent_ptr->DelegateOwnerClass;}
            set {K2Node_ActorBoundEvent_ptr->DelegateOwnerClass = value;}
        }
        ///<summary>The event that this event is bound to</summary>
        public unsafe Actor EventOwner {
            get {return K2Node_ActorBoundEvent_ptr->EventOwner;}
            set {K2Node_ActorBoundEvent_ptr->EventOwner = value;}
        }
        static K2Node_ActorBoundEvent() {
            StaticClass = Main.GetClass("K2Node_ActorBoundEvent");
        }
        internal unsafe K2Node_ActorBoundEvent_fields* K2Node_ActorBoundEvent_ptr => (K2Node_ActorBoundEvent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator K2Node_ActorBoundEvent(IntPtr p) => UObject.Make<K2Node_ActorBoundEvent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static K2Node_ActorBoundEvent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static K2Node_ActorBoundEvent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
