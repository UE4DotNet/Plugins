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

namespace UE4.BehaviorTreeEditor {
    ///<summary>Behavior Tree Decorator Graph Node</summary>
    public unsafe partial class BehaviorTreeDecoratorGraphNode : EdGraphNode  {
        static BehaviorTreeDecoratorGraphNode() {
            StaticClass = Main.GetClass("BehaviorTreeDecoratorGraphNode");
        }
        internal unsafe BehaviorTreeDecoratorGraphNode_fields* BehaviorTreeDecoratorGraphNode_ptr => (BehaviorTreeDecoratorGraphNode_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BehaviorTreeDecoratorGraphNode(IntPtr p) => UObject.Make<BehaviorTreeDecoratorGraphNode>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BehaviorTreeDecoratorGraphNode DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BehaviorTreeDecoratorGraphNode New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
