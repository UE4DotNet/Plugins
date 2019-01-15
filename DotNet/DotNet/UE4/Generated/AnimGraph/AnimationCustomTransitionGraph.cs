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
    ///<summary>Animation Custom Transition Graph</summary>
    public unsafe partial class AnimationCustomTransitionGraph : AnimationGraph  {
        ///<summary>Result node within the state's animation graph</summary>
        public unsafe AnimGraphNode_CustomTransitionResult MyResultNode {
            get {return AnimationCustomTransitionGraph_ptr->MyResultNode;}
            set {AnimationCustomTransitionGraph_ptr->MyResultNode = value;}
        }
        static AnimationCustomTransitionGraph() {
            StaticClass = Main.GetClass("AnimationCustomTransitionGraph");
        }
        internal unsafe AnimationCustomTransitionGraph_fields* AnimationCustomTransitionGraph_ptr => (AnimationCustomTransitionGraph_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AnimationCustomTransitionGraph(IntPtr p) => UObject.Make<AnimationCustomTransitionGraph>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AnimationCustomTransitionGraph DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AnimationCustomTransitionGraph New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
