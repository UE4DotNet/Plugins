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
    ///<summary>
    ///This is the base class for the 'source version' of all skeletal control animation graph nodes
    ///(nodes that manipulate the pose rather than playing animations to create a pose or blending between poses)
    ///</summary>
    ///<remarks>Concrete subclasses should contain a member struct derived from FAnimNode_SkeletalControlBase</remarks>
    public unsafe partial class AnimGraphNode_SkeletalControlBase : AnimGraphNode_Base  {
        static AnimGraphNode_SkeletalControlBase() {
            StaticClass = Main.GetClass("AnimGraphNode_SkeletalControlBase");
        }
        internal unsafe AnimGraphNode_SkeletalControlBase_fields* AnimGraphNode_SkeletalControlBase_ptr => (AnimGraphNode_SkeletalControlBase_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AnimGraphNode_SkeletalControlBase(IntPtr p) => UObject.Make<AnimGraphNode_SkeletalControlBase>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AnimGraphNode_SkeletalControlBase DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AnimGraphNode_SkeletalControlBase New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
