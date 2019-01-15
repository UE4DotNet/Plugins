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
    ///<summary>Takes care of spawning UK2Node_Event nodes.</summary>
    ///<remarks>
    ///Acts as the "action" portion of
    ///certain FBlueprintActionMenuItems. Will not spawn a new event node if one
    ///associated with the specified function already exits (instead, Invoke() will
    ///return the existing one). Evolved from FEdGraphSchemaAction_K2AddEvent and
    ///FEdGraphSchemaAction_K2ViewNode.
    ///</remarks>
    public unsafe partial class BlueprintBoundEventNodeSpawner : BlueprintEventNodeSpawner  {
        ///<summary>Event Delegate</summary>
        public unsafe MulticastDelegateProperty EventDelegate {
            get {return BlueprintBoundEventNodeSpawner_ptr->EventDelegate;}
            set {BlueprintBoundEventNodeSpawner_ptr->EventDelegate = value;}
        }
        static BlueprintBoundEventNodeSpawner() {
            StaticClass = Main.GetClass("BlueprintBoundEventNodeSpawner");
        }
        internal unsafe BlueprintBoundEventNodeSpawner_fields* BlueprintBoundEventNodeSpawner_ptr => (BlueprintBoundEventNodeSpawner_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BlueprintBoundEventNodeSpawner(IntPtr p) => UObject.Make<BlueprintBoundEventNodeSpawner>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BlueprintBoundEventNodeSpawner DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BlueprintBoundEventNodeSpawner New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
