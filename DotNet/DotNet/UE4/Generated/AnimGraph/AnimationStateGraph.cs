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
    ///<summary>Animation State Graph</summary>
    public unsafe partial class AnimationStateGraph : AnimationGraph  {
        ///<summary>Result node within the state's animation graph</summary>
        public unsafe AnimGraphNode_StateResult MyResultNode {
            get {return AnimationStateGraph_ptr->MyResultNode;}
            set {AnimationStateGraph_ptr->MyResultNode = value;}
        }
        static AnimationStateGraph() {
            StaticClass = Main.GetClass("AnimationStateGraph");
        }
        internal unsafe AnimationStateGraph_fields* AnimationStateGraph_ptr => (AnimationStateGraph_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AnimationStateGraph(IntPtr p) => UObject.Make<AnimationStateGraph>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AnimationStateGraph DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AnimationStateGraph New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
