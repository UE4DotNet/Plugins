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
using UE4.AIModule.Native;
using UE4.Engine;

namespace UE4.AIModule {
    ///<summary>Behavior Tree</summary>
    public unsafe partial class BehaviorTree : UObject  {
        ///<summary>root node of loaded tree</summary>
        public unsafe BTCompositeNode RootNode {
            get {return BehaviorTree_ptr->RootNode;}
            set {BehaviorTree_ptr->RootNode = value;}
        }
        ///<summary>Graph for Behavior Tree</summary>
        public unsafe EdGraph BTGraph {
            get {return BehaviorTree_ptr->BTGraph;}
            set {BehaviorTree_ptr->BTGraph = value;}
        }
         //TODO: array not UObject TArray LastEditedDocuments
        ///<summary>blackboard asset for this tree</summary>
        public unsafe BlackboardData BlackboardAsset {
            get {return BehaviorTree_ptr->BlackboardAsset;}
            set {BehaviorTree_ptr->BlackboardAsset = value;}
        }
        ///<summary>root level decorators, used by subtrees</summary>
        public ObjectArrayField<BTDecorator> RootDecorators{ get {
            if(RootDecorators_store == null) RootDecorators_store = new ObjectArrayField<BTDecorator> (&BehaviorTree_ptr->RootDecorators);
            return RootDecorators_store;
        } }
        private ObjectArrayField<BTDecorator> RootDecorators_store;

         //TODO: array not UObject TArray RootDecoratorOps
        static BehaviorTree() {
            StaticClass = Main.GetClass("BehaviorTree");
        }
        internal unsafe BehaviorTree_fields* BehaviorTree_ptr => (BehaviorTree_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BehaviorTree(IntPtr p) => UObject.Make<BehaviorTree>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BehaviorTree DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BehaviorTree New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
