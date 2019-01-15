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
using UE4.Engine;

namespace UE4.AnimGraph {
    ///<summary>Anim Graph Node Use Cached Pose</summary>
    public unsafe partial class AnimGraphNode_UseCachedPose : AnimGraphNode_Base  {
        ///<summary>Node</summary>
        public unsafe AnimNode_UseCachedPose Node {
            get {return AnimGraphNode_UseCachedPose_ptr->Node;}
            set {AnimGraphNode_UseCachedPose_ptr->Node = value;}
        }
         //TODO: weak object TWeakObjectPtr<UAnimGraphNode_SaveCachedPose> SaveCachedPoseNode
         //TODO: string FString NameOfCache
        static AnimGraphNode_UseCachedPose() {
            StaticClass = Main.GetClass("AnimGraphNode_UseCachedPose");
        }
        internal unsafe AnimGraphNode_UseCachedPose_fields* AnimGraphNode_UseCachedPose_ptr => (AnimGraphNode_UseCachedPose_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AnimGraphNode_UseCachedPose(IntPtr p) => UObject.Make<AnimGraphNode_UseCachedPose>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AnimGraphNode_UseCachedPose DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AnimGraphNode_UseCachedPose New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
