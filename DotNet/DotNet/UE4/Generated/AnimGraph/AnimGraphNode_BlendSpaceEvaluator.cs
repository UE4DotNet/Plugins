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
using UE4.AnimGraphRuntime;

namespace UE4.AnimGraph {
    ///<summary>Anim Graph Node Blend Space Evaluator</summary>
    public unsafe partial class AnimGraphNode_BlendSpaceEvaluator : AnimGraphNode_BlendSpaceBase  {
        ///<summary>Node</summary>
        public unsafe AnimNode_BlendSpaceEvaluator Node {
            get {return AnimGraphNode_BlendSpaceEvaluator_ptr->Node;}
            set {AnimGraphNode_BlendSpaceEvaluator_ptr->Node = value;}
        }
        static AnimGraphNode_BlendSpaceEvaluator() {
            StaticClass = Main.GetClass("AnimGraphNode_BlendSpaceEvaluator");
        }
        internal unsafe AnimGraphNode_BlendSpaceEvaluator_fields* AnimGraphNode_BlendSpaceEvaluator_ptr => (AnimGraphNode_BlendSpaceEvaluator_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AnimGraphNode_BlendSpaceEvaluator(IntPtr p) => UObject.Make<AnimGraphNode_BlendSpaceEvaluator>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AnimGraphNode_BlendSpaceEvaluator DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AnimGraphNode_BlendSpaceEvaluator New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
