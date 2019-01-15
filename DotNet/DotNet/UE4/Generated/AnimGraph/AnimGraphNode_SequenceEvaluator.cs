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
    ///<summary>Anim Graph Node Sequence Evaluator</summary>
    public unsafe partial class AnimGraphNode_SequenceEvaluator : AnimGraphNode_AssetPlayerBase  {
        ///<summary>Node</summary>
        public unsafe AnimNode_SequenceEvaluator Node {
            get {return AnimGraphNode_SequenceEvaluator_ptr->Node;}
            set {AnimGraphNode_SequenceEvaluator_ptr->Node = value;}
        }
        static AnimGraphNode_SequenceEvaluator() {
            StaticClass = Main.GetClass("AnimGraphNode_SequenceEvaluator");
        }
        internal unsafe AnimGraphNode_SequenceEvaluator_fields* AnimGraphNode_SequenceEvaluator_ptr => (AnimGraphNode_SequenceEvaluator_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AnimGraphNode_SequenceEvaluator(IntPtr p) => UObject.Make<AnimGraphNode_SequenceEvaluator>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AnimGraphNode_SequenceEvaluator DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AnimGraphNode_SequenceEvaluator New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
