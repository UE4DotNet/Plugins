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
    ///<summary>Takes care of spawning various bound nodes.</summary>
    ///<remarks>
    ///Acts as the
    ///"action" portion of certain FBlueprintActionMenuItems.
    ///</remarks>
    public unsafe partial class BlueprintBoundNodeSpawner : BlueprintNodeSpawner  {
        static BlueprintBoundNodeSpawner() {
            StaticClass = Main.GetClass("BlueprintBoundNodeSpawner");
        }
        internal unsafe BlueprintBoundNodeSpawner_fields* BlueprintBoundNodeSpawner_ptr => (BlueprintBoundNodeSpawner_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BlueprintBoundNodeSpawner(IntPtr p) => UObject.Make<BlueprintBoundNodeSpawner>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BlueprintBoundNodeSpawner DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BlueprintBoundNodeSpawner New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
