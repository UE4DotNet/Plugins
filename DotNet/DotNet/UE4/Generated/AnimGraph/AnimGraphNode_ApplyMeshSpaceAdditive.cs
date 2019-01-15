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
    ///<summary>Anim Graph Node Apply Mesh Space Additive</summary>
    public unsafe partial class AnimGraphNode_ApplyMeshSpaceAdditive : AnimGraphNode_Base  {
        ///<summary>Node</summary>
        public unsafe AnimNode_ApplyMeshSpaceAdditive Node {
            get {return AnimGraphNode_ApplyMeshSpaceAdditive_ptr->Node;}
            set {AnimGraphNode_ApplyMeshSpaceAdditive_ptr->Node = value;}
        }
        static AnimGraphNode_ApplyMeshSpaceAdditive() {
            StaticClass = Main.GetClass("AnimGraphNode_ApplyMeshSpaceAdditive");
        }
        internal unsafe AnimGraphNode_ApplyMeshSpaceAdditive_fields* AnimGraphNode_ApplyMeshSpaceAdditive_ptr => (AnimGraphNode_ApplyMeshSpaceAdditive_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AnimGraphNode_ApplyMeshSpaceAdditive(IntPtr p) => UObject.Make<AnimGraphNode_ApplyMeshSpaceAdditive>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AnimGraphNode_ApplyMeshSpaceAdditive DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AnimGraphNode_ApplyMeshSpaceAdditive New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
