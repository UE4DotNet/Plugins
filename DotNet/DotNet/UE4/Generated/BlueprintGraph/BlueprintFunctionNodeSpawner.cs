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
    ///<summary>Takes care of spawning various UK2Node_CallFunction nodes.</summary>
    ///<remarks>
    ///Acts as the
    ///"action" portion of certain FBlueprintActionMenuItems.
    ///</remarks>
    public unsafe partial class BlueprintFunctionNodeSpawner : BlueprintFieldNodeSpawner  {
        static BlueprintFunctionNodeSpawner() {
            StaticClass = Main.GetClass("BlueprintFunctionNodeSpawner");
        }
        internal unsafe BlueprintFunctionNodeSpawner_fields* BlueprintFunctionNodeSpawner_ptr => (BlueprintFunctionNodeSpawner_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BlueprintFunctionNodeSpawner(IntPtr p) => UObject.Make<BlueprintFunctionNodeSpawner>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BlueprintFunctionNodeSpawner DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BlueprintFunctionNodeSpawner New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
