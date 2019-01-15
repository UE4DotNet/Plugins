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
    ///<summary>Ed Graph</summary>
    public unsafe partial class EdGraph : UObject  {
        ///<summary>The schema that this graph obeys</summary>
        public unsafe SubclassOf<EdGraphSchema> Schema {
            get {return EdGraph_ptr->Schema;}
            set {EdGraph_ptr->Schema = value;}
        }
        ///<summary>Set of all nodes in this graph</summary>
        public ObjectArrayField<EdGraphNode> Nodes{ get {
            if(Nodes_store == null) Nodes_store = new ObjectArrayField<EdGraphNode> (&EdGraph_ptr->Nodes);
            return Nodes_store;
        } }
        private ObjectArrayField<EdGraphNode> Nodes_store;

        public bool bEditable {
            get {return Main.GetGetBoolPropertyByName(this, "bEditable"); }
            set {Main.SetGetBoolPropertyByName(this, "bEditable", value); }
        }
        public bool bAllowDeletion {
            get {return Main.GetGetBoolPropertyByName(this, "bAllowDeletion"); }
            set {Main.SetGetBoolPropertyByName(this, "bAllowDeletion", value); }
        }
        public bool bAllowRenaming {
            get {return Main.GetGetBoolPropertyByName(this, "bAllowRenaming"); }
            set {Main.SetGetBoolPropertyByName(this, "bAllowRenaming", value); }
        }
        ///<summary>Child graphs that are a part of this graph; the separation is purely visual</summary>
        public ObjectArrayField<EdGraph> SubGraphs{ get {
            if(SubGraphs_store == null) SubGraphs_store = new ObjectArrayField<EdGraph> (&EdGraph_ptr->SubGraphs);
            return SubGraphs_store;
        } }
        private ObjectArrayField<EdGraph> SubGraphs_store;

        ///<summary>Guid for this graph</summary>
        public unsafe FGuid GraphGuid {
            get {return EdGraph_ptr->GraphGuid;}
            set {EdGraph_ptr->GraphGuid = value;}
        }
        ///<summary>Guid of interface graph this graph comes from (used for conforming)</summary>
        public unsafe FGuid InterfaceGuid {
            get {return EdGraph_ptr->InterfaceGuid;}
            set {EdGraph_ptr->InterfaceGuid = value;}
        }
        static EdGraph() {
            StaticClass = Main.GetClass("EdGraph");
        }
        internal unsafe EdGraph_fields* EdGraph_ptr => (EdGraph_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator EdGraph(IntPtr p) => UObject.Make<EdGraph>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static EdGraph DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static EdGraph New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
