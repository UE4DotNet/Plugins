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
using UE4.AIModule;

namespace UE4.BehaviorTreeEditor {
    ///<summary>Root node of this behavior tree, holds Blackboard data</summary>
    public unsafe partial class BehaviorTreeGraphNode_Root : BehaviorTreeGraphNode  {
        ///<summary>Blackboard Asset</summary>
        public unsafe BlackboardData BlackboardAsset {
            get {return BehaviorTreeGraphNode_Root_ptr->BlackboardAsset;}
            set {BehaviorTreeGraphNode_Root_ptr->BlackboardAsset = value;}
        }
        static BehaviorTreeGraphNode_Root() {
            StaticClass = Main.GetClass("BehaviorTreeGraphNode_Root");
        }
        internal unsafe BehaviorTreeGraphNode_Root_fields* BehaviorTreeGraphNode_Root_ptr => (BehaviorTreeGraphNode_Root_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BehaviorTreeGraphNode_Root(IntPtr p) => UObject.Make<BehaviorTreeGraphNode_Root>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BehaviorTreeGraphNode_Root DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BehaviorTreeGraphNode_Root New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
