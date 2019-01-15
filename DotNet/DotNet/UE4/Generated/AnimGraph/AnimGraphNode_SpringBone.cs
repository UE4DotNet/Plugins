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
    ///<summary>Anim Graph Node Spring Bone</summary>
    public unsafe partial class AnimGraphNode_SpringBone : AnimGraphNode_SkeletalControlBase  {
        ///<summary>Node</summary>
        public unsafe AnimNode_SpringBone Node {
            get {return AnimGraphNode_SpringBone_ptr->Node;}
            set {AnimGraphNode_SpringBone_ptr->Node = value;}
        }
        static AnimGraphNode_SpringBone() {
            StaticClass = Main.GetClass("AnimGraphNode_SpringBone");
        }
        internal unsafe AnimGraphNode_SpringBone_fields* AnimGraphNode_SpringBone_ptr => (AnimGraphNode_SpringBone_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AnimGraphNode_SpringBone(IntPtr p) => UObject.Make<AnimGraphNode_SpringBone>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AnimGraphNode_SpringBone DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AnimGraphNode_SpringBone New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
