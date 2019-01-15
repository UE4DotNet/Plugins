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
    ///<summary>Anim Graph Node Pose Handler</summary>
    public unsafe partial class AnimGraphNode_PoseHandler : AnimGraphNode_AssetPlayerBase  {
        static AnimGraphNode_PoseHandler() {
            StaticClass = Main.GetClass("AnimGraphNode_PoseHandler");
        }
        internal unsafe AnimGraphNode_PoseHandler_fields* AnimGraphNode_PoseHandler_ptr => (AnimGraphNode_PoseHandler_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AnimGraphNode_PoseHandler(IntPtr p) => UObject.Make<AnimGraphNode_PoseHandler>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AnimGraphNode_PoseHandler DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AnimGraphNode_PoseHandler New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
