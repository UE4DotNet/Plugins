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
    ///<summary>Anim Graph Node Two Way Blend</summary>
    public unsafe partial class AnimGraphNode_TwoWayBlend : AnimGraphNode_Base  {
        ///<summary>Blend Node</summary>
        public unsafe AnimNode_TwoWayBlend BlendNode {
            get {return AnimGraphNode_TwoWayBlend_ptr->BlendNode;}
            set {AnimGraphNode_TwoWayBlend_ptr->BlendNode = value;}
        }
        static AnimGraphNode_TwoWayBlend() {
            StaticClass = Main.GetClass("AnimGraphNode_TwoWayBlend");
        }
        internal unsafe AnimGraphNode_TwoWayBlend_fields* AnimGraphNode_TwoWayBlend_ptr => (AnimGraphNode_TwoWayBlend_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AnimGraphNode_TwoWayBlend(IntPtr p) => UObject.Make<AnimGraphNode_TwoWayBlend>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AnimGraphNode_TwoWayBlend DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AnimGraphNode_TwoWayBlend New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
