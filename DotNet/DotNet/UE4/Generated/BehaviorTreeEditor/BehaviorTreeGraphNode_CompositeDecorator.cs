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
using UE4.Engine;
using UE4.AIModule;

namespace UE4.BehaviorTreeEditor {
    ///<summary>Behavior Tree Graph Node Composite Decorator</summary>
    public unsafe partial class BehaviorTreeGraphNode_CompositeDecorator : BehaviorTreeGraphNode  {
        ///<summary>The logic graph for this decorator (returning a boolean)</summary>
        public unsafe EdGraph BoundGraph {
            get {return BehaviorTreeGraphNode_CompositeDecorator_ptr->BoundGraph;}
            set {BehaviorTreeGraphNode_CompositeDecorator_ptr->BoundGraph = value;}
        }
         //TODO: string FString CompositeName
        public bool bShowOperations {
            get {return Main.GetGetBoolPropertyByName(this, "bShowOperations"); }
            set {Main.SetGetBoolPropertyByName(this, "bShowOperations", value); }
        }
        public bool bCanAbortFlow {
            get {return Main.GetGetBoolPropertyByName(this, "bCanAbortFlow"); }
            set {Main.SetGetBoolPropertyByName(this, "bCanAbortFlow", value); }
        }
        ///<summary>Parent Node Instance</summary>
        public unsafe BTCompositeNode ParentNodeInstance {
            get {return BehaviorTreeGraphNode_CompositeDecorator_ptr->ParentNodeInstance;}
            set {BehaviorTreeGraphNode_CompositeDecorator_ptr->ParentNodeInstance = value;}
        }
         //TODO: string FString CachedDescription
        static BehaviorTreeGraphNode_CompositeDecorator() {
            StaticClass = Main.GetClass("BehaviorTreeGraphNode_CompositeDecorator");
        }
        internal unsafe BehaviorTreeGraphNode_CompositeDecorator_fields* BehaviorTreeGraphNode_CompositeDecorator_ptr => (BehaviorTreeGraphNode_CompositeDecorator_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BehaviorTreeGraphNode_CompositeDecorator(IntPtr p) => UObject.Make<BehaviorTreeGraphNode_CompositeDecorator>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BehaviorTreeGraphNode_CompositeDecorator DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BehaviorTreeGraphNode_CompositeDecorator New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
