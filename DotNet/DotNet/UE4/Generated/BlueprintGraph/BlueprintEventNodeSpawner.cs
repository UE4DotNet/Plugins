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
    public unsafe partial class BlueprintEventNodeSpawner : BlueprintNodeSpawner  {
        ///<summary>The function to configure new nodes with.</summary>
        public unsafe Function EventFunc {
            get {return BlueprintEventNodeSpawner_ptr->EventFunc;}
            set {BlueprintEventNodeSpawner_ptr->EventFunc = value;}
        }
        ///<summary>The custom name to configure new event nodes with.</summary>
        public unsafe Name CustomEventName {
            get {return BlueprintEventNodeSpawner_ptr->CustomEventName;}
            set {BlueprintEventNodeSpawner_ptr->CustomEventName = value;}
        }
        static BlueprintEventNodeSpawner() {
            StaticClass = Main.GetClass("BlueprintEventNodeSpawner");
        }
        internal unsafe BlueprintEventNodeSpawner_fields* BlueprintEventNodeSpawner_ptr => (BlueprintEventNodeSpawner_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BlueprintEventNodeSpawner(IntPtr p) => UObject.Make<BlueprintEventNodeSpawner>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BlueprintEventNodeSpawner DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BlueprintEventNodeSpawner New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
