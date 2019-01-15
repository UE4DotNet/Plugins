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
    ///<summary>Anim Graph Node Local Ref Pose</summary>
    public unsafe partial class AnimGraphNode_LocalRefPose : AnimGraphNode_RefPoseBase  {
        static AnimGraphNode_LocalRefPose() {
            StaticClass = Main.GetClass("AnimGraphNode_LocalRefPose");
        }
        internal unsafe AnimGraphNode_LocalRefPose_fields* AnimGraphNode_LocalRefPose_ptr => (AnimGraphNode_LocalRefPose_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AnimGraphNode_LocalRefPose(IntPtr p) => UObject.Make<AnimGraphNode_LocalRefPose>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AnimGraphNode_LocalRefPose DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AnimGraphNode_LocalRefPose New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
