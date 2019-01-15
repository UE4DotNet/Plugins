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
using UE4.AnimGraph.Native;

namespace UE4.AnimGraph {
    ///<summary>Anim Graph Node State Machine Base</summary>
    public unsafe partial class AnimGraphNode_StateMachineBase : AnimGraphNode_Base  {
        ///<summary>Editor state machine representation</summary>
        public unsafe AnimationStateMachineGraph EditorStateMachineGraph {
            get {return AnimGraphNode_StateMachineBase_ptr->EditorStateMachineGraph;}
            set {AnimGraphNode_StateMachineBase_ptr->EditorStateMachineGraph = value;}
        }
        static AnimGraphNode_StateMachineBase() {
            StaticClass = Main.GetClass("AnimGraphNode_StateMachineBase");
        }
        internal unsafe AnimGraphNode_StateMachineBase_fields* AnimGraphNode_StateMachineBase_ptr => (AnimGraphNode_StateMachineBase_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AnimGraphNode_StateMachineBase(IntPtr p) => UObject.Make<AnimGraphNode_StateMachineBase>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AnimGraphNode_StateMachineBase DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AnimGraphNode_StateMachineBase New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
