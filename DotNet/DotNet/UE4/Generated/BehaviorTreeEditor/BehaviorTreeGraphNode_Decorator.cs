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
    ///<summary>Behavior Tree Graph Node Decorator</summary>
    public unsafe partial class BehaviorTreeGraphNode_Decorator : BehaviorTreeGraphNode  {
        static BehaviorTreeGraphNode_Decorator() {
            StaticClass = Main.GetClass("BehaviorTreeGraphNode_Decorator");
        }
        internal unsafe BehaviorTreeGraphNode_Decorator_fields* BehaviorTreeGraphNode_Decorator_ptr => (BehaviorTreeGraphNode_Decorator_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BehaviorTreeGraphNode_Decorator(IntPtr p) => UObject.Make<BehaviorTreeGraphNode_Decorator>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BehaviorTreeGraphNode_Decorator DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BehaviorTreeGraphNode_Decorator New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
