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
    ///<summary>Anim Graph Node Copy Bone</summary>
    public unsafe partial class AnimGraphNode_CopyBone : AnimGraphNode_SkeletalControlBase  {
        ///<summary>Node</summary>
        public unsafe AnimNode_CopyBone Node {
            get {return AnimGraphNode_CopyBone_ptr->Node;}
            set {AnimGraphNode_CopyBone_ptr->Node = value;}
        }
        static AnimGraphNode_CopyBone() {
            StaticClass = Main.GetClass("AnimGraphNode_CopyBone");
        }
        internal unsafe AnimGraphNode_CopyBone_fields* AnimGraphNode_CopyBone_ptr => (AnimGraphNode_CopyBone_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AnimGraphNode_CopyBone(IntPtr p) => UObject.Make<AnimGraphNode_CopyBone>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AnimGraphNode_CopyBone DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AnimGraphNode_CopyBone New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
