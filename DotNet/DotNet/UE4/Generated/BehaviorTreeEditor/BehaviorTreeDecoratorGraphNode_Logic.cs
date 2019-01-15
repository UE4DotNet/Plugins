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

namespace UE4.BehaviorTreeEditor {
    ///<summary>Behavior Tree Decorator Graph Node Logic</summary>
    public unsafe partial class BehaviorTreeDecoratorGraphNode_Logic : BehaviorTreeDecoratorGraphNode  {
        ///<summary>Logic Mode</summary>
        public unsafe byte LogicMode {
            get {return BehaviorTreeDecoratorGraphNode_Logic_ptr->LogicMode;}
            set {BehaviorTreeDecoratorGraphNode_Logic_ptr->LogicMode = value;}
        }
        static BehaviorTreeDecoratorGraphNode_Logic() {
            StaticClass = Main.GetClass("BehaviorTreeDecoratorGraphNode_Logic");
        }
        internal unsafe BehaviorTreeDecoratorGraphNode_Logic_fields* BehaviorTreeDecoratorGraphNode_Logic_ptr => (BehaviorTreeDecoratorGraphNode_Logic_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BehaviorTreeDecoratorGraphNode_Logic(IntPtr p) => UObject.Make<BehaviorTreeDecoratorGraphNode_Logic>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BehaviorTreeDecoratorGraphNode_Logic DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BehaviorTreeDecoratorGraphNode_Logic New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
