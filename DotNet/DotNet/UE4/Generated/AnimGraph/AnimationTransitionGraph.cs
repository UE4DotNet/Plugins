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
    ///<summary>Animation Transition Graph</summary>
    public unsafe partial class AnimationTransitionGraph : AnimationGraph  {
        ///<summary>My Result Node</summary>
        public unsafe AnimGraphNode_TransitionResult MyResultNode {
            get {return AnimationTransitionGraph_ptr->MyResultNode;}
            set {AnimationTransitionGraph_ptr->MyResultNode = value;}
        }
        static AnimationTransitionGraph() {
            StaticClass = Main.GetClass("AnimationTransitionGraph");
        }
        internal unsafe AnimationTransitionGraph_fields* AnimationTransitionGraph_ptr => (AnimationTransitionGraph_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AnimationTransitionGraph(IntPtr p) => UObject.Make<AnimationTransitionGraph>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AnimationTransitionGraph DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AnimationTransitionGraph New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
