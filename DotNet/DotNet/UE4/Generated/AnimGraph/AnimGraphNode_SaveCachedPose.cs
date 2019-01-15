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
    ///<summary>Anim Graph Node Save Cached Pose</summary>
    public unsafe partial class AnimGraphNode_SaveCachedPose : AnimGraphNode_Base  {
        ///<summary>Node</summary>
        public unsafe AnimNode_SaveCachedPose Node {
            get {return AnimGraphNode_SaveCachedPose_ptr->Node;}
            set {AnimGraphNode_SaveCachedPose_ptr->Node = value;}
        }
         //TODO: string FString CacheName
        static AnimGraphNode_SaveCachedPose() {
            StaticClass = Main.GetClass("AnimGraphNode_SaveCachedPose");
        }
        internal unsafe AnimGraphNode_SaveCachedPose_fields* AnimGraphNode_SaveCachedPose_ptr => (AnimGraphNode_SaveCachedPose_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AnimGraphNode_SaveCachedPose(IntPtr p) => UObject.Make<AnimGraphNode_SaveCachedPose>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AnimGraphNode_SaveCachedPose DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AnimGraphNode_SaveCachedPose New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
