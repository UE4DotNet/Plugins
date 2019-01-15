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
    ///<summary>Anim Graph Node Aim Offset Look At</summary>
    public unsafe partial class AnimGraphNode_AimOffsetLookAt : AnimGraphNode_BlendSpaceBase  {
        ///<summary>Node</summary>
        public unsafe AnimNode_AimOffsetLookAt Node {
            get {return AnimGraphNode_AimOffsetLookAt_ptr->Node;}
            set {AnimGraphNode_AimOffsetLookAt_ptr->Node = value;}
        }
        static AnimGraphNode_AimOffsetLookAt() {
            StaticClass = Main.GetClass("AnimGraphNode_AimOffsetLookAt");
        }
        internal unsafe AnimGraphNode_AimOffsetLookAt_fields* AnimGraphNode_AimOffsetLookAt_ptr => (AnimGraphNode_AimOffsetLookAt_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AnimGraphNode_AimOffsetLookAt(IntPtr p) => UObject.Make<AnimGraphNode_AimOffsetLookAt>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AnimGraphNode_AimOffsetLookAt DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AnimGraphNode_AimOffsetLookAt New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
