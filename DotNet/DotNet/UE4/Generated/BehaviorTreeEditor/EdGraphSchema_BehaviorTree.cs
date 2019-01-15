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
    ///<summary>Ed Graph Schema Behavior Tree</summary>
    public unsafe partial class EdGraphSchema_BehaviorTree : AIGraphSchema  {
        static EdGraphSchema_BehaviorTree() {
            StaticClass = Main.GetClass("EdGraphSchema_BehaviorTree");
        }
        internal unsafe EdGraphSchema_BehaviorTree_fields* EdGraphSchema_BehaviorTree_ptr => (EdGraphSchema_BehaviorTree_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator EdGraphSchema_BehaviorTree(IntPtr p) => UObject.Make<EdGraphSchema_BehaviorTree>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static EdGraphSchema_BehaviorTree DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static EdGraphSchema_BehaviorTree New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
