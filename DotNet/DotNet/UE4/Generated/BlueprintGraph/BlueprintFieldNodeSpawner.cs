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
    ///<summary>
    ///Takes care of spawning various field related nodes (nodes associated with
    ///functions, enums, structs, properties, etc.
    ///</summary>
    ///<remarks>
    ///). Acts as the "action" portion
    ///for certain FBlueprintActionMenuItems.
    ///</remarks>
    public unsafe partial class BlueprintFieldNodeSpawner : BlueprintNodeSpawner  {
        ///<summary>The field to configure new nodes with.</summary>
        public unsafe Field Field {
            get {return BlueprintFieldNodeSpawner_ptr->Field;}
            set {BlueprintFieldNodeSpawner_ptr->Field = value;}
        }
        static BlueprintFieldNodeSpawner() {
            StaticClass = Main.GetClass("BlueprintFieldNodeSpawner");
        }
        internal unsafe BlueprintFieldNodeSpawner_fields* BlueprintFieldNodeSpawner_ptr => (BlueprintFieldNodeSpawner_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BlueprintFieldNodeSpawner(IntPtr p) => UObject.Make<BlueprintFieldNodeSpawner>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BlueprintFieldNodeSpawner DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BlueprintFieldNodeSpawner New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
