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
    ///<summary>Anim Graph Node Leg IK</summary>
    public unsafe partial class AnimGraphNode_LegIK : AnimGraphNode_SkeletalControlBase  {
        ///<summary>Node</summary>
        public unsafe AnimNode_LegIK Node {
            get {return AnimGraphNode_LegIK_ptr->Node;}
            set {AnimGraphNode_LegIK_ptr->Node = value;}
        }
        static AnimGraphNode_LegIK() {
            StaticClass = Main.GetClass("AnimGraphNode_LegIK");
        }
        internal unsafe AnimGraphNode_LegIK_fields* AnimGraphNode_LegIK_ptr => (AnimGraphNode_LegIK_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AnimGraphNode_LegIK(IntPtr p) => UObject.Make<AnimGraphNode_LegIK>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AnimGraphNode_LegIK DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AnimGraphNode_LegIK New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
