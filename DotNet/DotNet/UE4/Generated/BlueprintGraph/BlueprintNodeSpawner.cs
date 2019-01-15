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
    ///<summary>Intended to be wrapped and used by FBlueprintActionMenuItem.</summary>
    ///<remarks>
    ///Rather than
    ///sub-classing the menu item, we choose to subclass this instead (for
    ///different node types). That way, we get the type inference that comes with
    ///UObjects (and we don't have to continuously compare identification strings).
    ///</remarks>
    public unsafe partial class BlueprintNodeSpawner : UObject  {
        ///<summary>Holds the node type that this spawner will instantiate.</summary>
        public unsafe SubclassOf<EdGraphNode> NodeClass {
            get {return BlueprintNodeSpawner_ptr->NodeClass;}
            set {BlueprintNodeSpawner_ptr->NodeClass = value;}
        }
        static BlueprintNodeSpawner() {
            StaticClass = Main.GetClass("BlueprintNodeSpawner");
        }
        internal unsafe BlueprintNodeSpawner_fields* BlueprintNodeSpawner_ptr => (BlueprintNodeSpawner_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BlueprintNodeSpawner(IntPtr p) => UObject.Make<BlueprintNodeSpawner>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BlueprintNodeSpawner DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BlueprintNodeSpawner New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
