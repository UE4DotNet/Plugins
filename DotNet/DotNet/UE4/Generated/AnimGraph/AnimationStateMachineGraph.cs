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
    ///<summary>Animation State Machine Graph</summary>
    public unsafe partial class AnimationStateMachineGraph : EdGraph  {
        ///<summary>Entry node within the state machine</summary>
        public unsafe AnimStateEntryNode EntryNode {
            get {return AnimationStateMachineGraph_ptr->EntryNode;}
            set {AnimationStateMachineGraph_ptr->EntryNode = value;}
        }
        ///<summary>Parent instance node</summary>
        public unsafe AnimGraphNode_StateMachineBase OwnerAnimGraphNode {
            get {return AnimationStateMachineGraph_ptr->OwnerAnimGraphNode;}
            set {AnimationStateMachineGraph_ptr->OwnerAnimGraphNode = value;}
        }
        static AnimationStateMachineGraph() {
            StaticClass = Main.GetClass("AnimationStateMachineGraph");
        }
        internal unsafe AnimationStateMachineGraph_fields* AnimationStateMachineGraph_ptr => (AnimationStateMachineGraph_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AnimationStateMachineGraph(IntPtr p) => UObject.Make<AnimationStateMachineGraph>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AnimationStateMachineGraph DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AnimationStateMachineGraph New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
