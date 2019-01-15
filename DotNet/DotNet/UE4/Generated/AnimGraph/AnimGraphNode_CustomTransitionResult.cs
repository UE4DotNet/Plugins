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
    ///<summary>Anim Graph Node Custom Transition Result</summary>
    public unsafe partial class AnimGraphNode_CustomTransitionResult : AnimGraphNode_Root  {
        static AnimGraphNode_CustomTransitionResult() {
            StaticClass = Main.GetClass("AnimGraphNode_CustomTransitionResult");
        }
        internal unsafe AnimGraphNode_CustomTransitionResult_fields* AnimGraphNode_CustomTransitionResult_ptr => (AnimGraphNode_CustomTransitionResult_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AnimGraphNode_CustomTransitionResult(IntPtr p) => UObject.Make<AnimGraphNode_CustomTransitionResult>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AnimGraphNode_CustomTransitionResult DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AnimGraphNode_CustomTransitionResult New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
