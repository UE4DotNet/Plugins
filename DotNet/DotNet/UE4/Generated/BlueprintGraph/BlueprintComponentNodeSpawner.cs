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
    ///<summary>Takes care of spawning UK2Node_AddComponent nodes.</summary>
    ///<remarks>
    ///Acts as the "action"
    ///portion of certain FBlueprintActionMenuItems. Evolved from
    ///FEdGraphSchemaAction_K2AddComponent.
    ///</remarks>
    public unsafe partial class BlueprintComponentNodeSpawner : BlueprintNodeSpawner  {
        ///<summary>The component class to configure new nodes with.</summary>
        public unsafe SubclassOf<ActorComponent> ComponentClass {
            get {return BlueprintComponentNodeSpawner_ptr->ComponentClass;}
            set {BlueprintComponentNodeSpawner_ptr->ComponentClass = value;}
        }
         //TODO: string FString ComponentName
         //TODO: string FString ComponentAssetName
        static BlueprintComponentNodeSpawner() {
            StaticClass = Main.GetClass("BlueprintComponentNodeSpawner");
        }
        internal unsafe BlueprintComponentNodeSpawner_fields* BlueprintComponentNodeSpawner_ptr => (BlueprintComponentNodeSpawner_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BlueprintComponentNodeSpawner(IntPtr p) => UObject.Make<BlueprintComponentNodeSpawner>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BlueprintComponentNodeSpawner DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BlueprintComponentNodeSpawner New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
