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
using UE4.Engine;

namespace UE4.AnimGraph {
    ///<summary>Anim Graph Node State Machine</summary>
    public unsafe partial class AnimGraphNode_StateMachine : AnimGraphNode_StateMachineBase  {
        ///<summary>Runtime state machine representation (empty; populated during compilation)</summary>
        public unsafe AnimNode_StateMachine Node {
            get {return AnimGraphNode_StateMachine_ptr->Node;}
            set {AnimGraphNode_StateMachine_ptr->Node = value;}
        }
        static AnimGraphNode_StateMachine() {
            StaticClass = Main.GetClass("AnimGraphNode_StateMachine");
        }
        internal unsafe AnimGraphNode_StateMachine_fields* AnimGraphNode_StateMachine_ptr => (AnimGraphNode_StateMachine_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AnimGraphNode_StateMachine(IntPtr p) => UObject.Make<AnimGraphNode_StateMachine>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AnimGraphNode_StateMachine DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AnimGraphNode_StateMachine New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
