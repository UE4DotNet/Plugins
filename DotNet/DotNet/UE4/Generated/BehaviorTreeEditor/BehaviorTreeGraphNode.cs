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
using UE4.BehaviorTreeEditor.Native;
using UE4.AIGraph;

namespace UE4.BehaviorTreeEditor {
    ///<summary>Behavior Tree Graph Node</summary>
    public unsafe partial class BehaviorTreeGraphNode : AIGraphNode  {
        ///<summary>only some of behavior tree nodes support decorators</summary>
        public ObjectArrayField<BehaviorTreeGraphNode> Decorators{ get {
            if(Decorators_store == null) Decorators_store = new ObjectArrayField<BehaviorTreeGraphNode> (&BehaviorTreeGraphNode_ptr->Decorators);
            return Decorators_store;
        } }
        private ObjectArrayField<BehaviorTreeGraphNode> Decorators_store;

        ///<summary>only some of behavior tree nodes support services</summary>
        public ObjectArrayField<BehaviorTreeGraphNode> Services{ get {
            if(Services_store == null) Services_store = new ObjectArrayField<BehaviorTreeGraphNode> (&BehaviorTreeGraphNode_ptr->Services);
            return Services_store;
        } }
        private ObjectArrayField<BehaviorTreeGraphNode> Services_store;

        public bool bInjectedNode {
            get {return Main.GetGetBoolPropertyByName(this, "bInjectedNode"); }
            set {Main.SetGetBoolPropertyByName(this, "bInjectedNode", value); }
        }
        static BehaviorTreeGraphNode() {
            StaticClass = Main.GetClass("BehaviorTreeGraphNode");
        }
        internal unsafe BehaviorTreeGraphNode_fields* BehaviorTreeGraphNode_ptr => (BehaviorTreeGraphNode_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BehaviorTreeGraphNode(IntPtr p) => UObject.Make<BehaviorTreeGraphNode>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BehaviorTreeGraphNode DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BehaviorTreeGraphNode New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
