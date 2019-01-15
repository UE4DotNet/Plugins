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
    ///<summary>Takes care of spawning various nodes associated with delegates.</summary>
    ///<remarks>
    ///Serves as the
    ///"action" portion for certain FBlueprintActionMenuItems. Evolved from
    ///FEdGraphSchemaAction_K2Delegate, FEdGraphSchemaAction_K2AssignDelegate, etc.
    ///</remarks>
    public unsafe partial class BlueprintDelegateNodeSpawner : BlueprintFieldNodeSpawner  {
        static BlueprintDelegateNodeSpawner() {
            StaticClass = Main.GetClass("BlueprintDelegateNodeSpawner");
        }
        internal unsafe BlueprintDelegateNodeSpawner_fields* BlueprintDelegateNodeSpawner_ptr => (BlueprintDelegateNodeSpawner_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BlueprintDelegateNodeSpawner(IntPtr p) => UObject.Make<BlueprintDelegateNodeSpawner>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BlueprintDelegateNodeSpawner DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BlueprintDelegateNodeSpawner New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
