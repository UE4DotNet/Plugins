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
using UE4.AIGraph.Native;
using UE4.Engine;

namespace UE4.AIGraph {
    ///<summary>AIGraph Node</summary>
    public unsafe partial class AIGraphNode : EdGraphNode  {
        ///<summary>instance class</summary>
        public unsafe GraphNodeClassData ClassData {
            get {return AIGraphNode_ptr->ClassData;}
            set {AIGraphNode_ptr->ClassData = value;}
        }
        ///<summary>Node Instance</summary>
        public unsafe UObject NodeInstance {
            get {return AIGraphNode_ptr->NodeInstance;}
            set {AIGraphNode_ptr->NodeInstance = value;}
        }
        ///<summary>Parent Node</summary>
        public unsafe AIGraphNode ParentNode {
            get {return AIGraphNode_ptr->ParentNode;}
            set {AIGraphNode_ptr->ParentNode = value;}
        }
        ///<summary>Sub Nodes</summary>
        public ObjectArrayField<AIGraphNode> SubNodes{ get {
            if(SubNodes_store == null) SubNodes_store = new ObjectArrayField<AIGraphNode> (&AIGraphNode_ptr->SubNodes);
            return SubNodes_store;
        } }
        private ObjectArrayField<AIGraphNode> SubNodes_store;

        ///<summary>subnode index assigned during copy operation to connect nodes again on paste</summary>
        public unsafe int CopySubNodeIndex {
            get {return AIGraphNode_ptr->CopySubNodeIndex;}
            set {AIGraphNode_ptr->CopySubNodeIndex = value;}
        }
        public bool bIsReadOnly {
            get {return Main.GetGetBoolPropertyByName(this, "bIsReadOnly"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsReadOnly", value); }
        }
        public bool bIsSubNode {
            get {return Main.GetGetBoolPropertyByName(this, "bIsSubNode"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsSubNode", value); }
        }
         //TODO: string FString ErrorMessage
        static AIGraphNode() {
            StaticClass = Main.GetClass("AIGraphNode");
        }
        internal unsafe AIGraphNode_fields* AIGraphNode_ptr => (AIGraphNode_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AIGraphNode(IntPtr p) => UObject.Make<AIGraphNode>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AIGraphNode DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AIGraphNode New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
