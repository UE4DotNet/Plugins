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
    ///<summary>Takes care of spawning variable getter/setter nodes.</summary>
    ///<remarks>
    ///Serves as the "action"
    ///portion for certain FBlueprintActionMenuItems. Evolved from
    ///FEdGraphSchemaAction_K2Var, and can spawn nodes for both member-variables and
    ///local function variables.
    ///</remarks>
    public unsafe partial class BlueprintVariableNodeSpawner : BlueprintFieldNodeSpawner  {
        ///<summary>The graph that the local variable belongs to (if this is a local variable spawner).</summary>
        public unsafe EdGraph LocalVarOuter {
            get {return BlueprintVariableNodeSpawner_ptr->LocalVarOuter;}
            set {BlueprintVariableNodeSpawner_ptr->LocalVarOuter = value;}
        }
        ///<summary>Local Var Desc</summary>
        public unsafe BPVariableDescription LocalVarDesc {
            get {return BlueprintVariableNodeSpawner_ptr->LocalVarDesc;}
            set {BlueprintVariableNodeSpawner_ptr->LocalVarDesc = value;}
        }
        static BlueprintVariableNodeSpawner() {
            StaticClass = Main.GetClass("BlueprintVariableNodeSpawner");
        }
        internal unsafe BlueprintVariableNodeSpawner_fields* BlueprintVariableNodeSpawner_ptr => (BlueprintVariableNodeSpawner_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BlueprintVariableNodeSpawner(IntPtr p) => UObject.Make<BlueprintVariableNodeSpawner>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BlueprintVariableNodeSpawner DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BlueprintVariableNodeSpawner New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
