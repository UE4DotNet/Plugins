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
using UE4.Engine;

namespace UE4.AnimGraph {
    ///<summary>Anim Graph Node Pose Driver</summary>
    public unsafe partial class AnimGraphNode_PoseDriver : AnimGraphNode_PoseHandler  {
        ///<summary>Node</summary>
        public unsafe AnimNode_PoseDriver Node {
            get {return AnimGraphNode_PoseDriver_ptr->Node;}
            set {AnimGraphNode_PoseDriver_ptr->Node = value;}
        }
        ///<summary>Used to refer back to preview instance in anim tools</summary>
        public unsafe SkeletalMeshComponent LastPreviewComponent {
            get {return AnimGraphNode_PoseDriver_ptr->LastPreviewComponent;}
            set {AnimGraphNode_PoseDriver_ptr->LastPreviewComponent = value;}
        }
        static AnimGraphNode_PoseDriver() {
            StaticClass = Main.GetClass("AnimGraphNode_PoseDriver");
        }
        internal unsafe AnimGraphNode_PoseDriver_fields* AnimGraphNode_PoseDriver_ptr => (AnimGraphNode_PoseDriver_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AnimGraphNode_PoseDriver(IntPtr p) => UObject.Make<AnimGraphNode_PoseDriver>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AnimGraphNode_PoseDriver DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AnimGraphNode_PoseDriver New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
