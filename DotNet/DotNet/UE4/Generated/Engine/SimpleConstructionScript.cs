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
using UE4.Engine.Native;

namespace UE4.Engine {
    ///<summary>Simple Construction Script</summary>
    public unsafe partial class SimpleConstructionScript : UObject  {
        ///<summary>Root nodes of the construction script</summary>
        public ObjectArrayField<SCS_Node> RootNodes{ get {
            if(RootNodes_store == null) RootNodes_store = new ObjectArrayField<SCS_Node> (&SimpleConstructionScript_ptr->RootNodes);
            return RootNodes_store;
        } }
        private ObjectArrayField<SCS_Node> RootNodes_store;

        ///<summary>All nodes that exist in the hierarchy of this SimpleConstructionScript</summary>
        public ObjectArrayField<SCS_Node> AllNodes{ get {
            if(AllNodes_store == null) AllNodes_store = new ObjectArrayField<SCS_Node> (&SimpleConstructionScript_ptr->AllNodes);
            return AllNodes_store;
        } }
        private ObjectArrayField<SCS_Node> AllNodes_store;

        ///<summary>Default scene root node; used when no other nodes are available to use as the root</summary>
        public unsafe SCS_Node DefaultSceneRootNode {
            get {return SimpleConstructionScript_ptr->DefaultSceneRootNode;}
            set {SimpleConstructionScript_ptr->DefaultSceneRootNode = value;}
        }
        static SimpleConstructionScript() {
            StaticClass = Main.GetClass("SimpleConstructionScript");
        }
        internal unsafe SimpleConstructionScript_fields* SimpleConstructionScript_ptr => (SimpleConstructionScript_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SimpleConstructionScript(IntPtr p) => UObject.Make<SimpleConstructionScript>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SimpleConstructionScript DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SimpleConstructionScript New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
