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
    ///<summary>Anim Graph Node Blend Space Player</summary>
    public unsafe partial class AnimGraphNode_BlendSpacePlayer : AnimGraphNode_BlendSpaceBase  {
        ///<summary>Node</summary>
        public unsafe AnimNode_BlendSpacePlayer Node {
            get {return AnimGraphNode_BlendSpacePlayer_ptr->Node;}
            set {AnimGraphNode_BlendSpacePlayer_ptr->Node = value;}
        }
        static AnimGraphNode_BlendSpacePlayer() {
            StaticClass = Main.GetClass("AnimGraphNode_BlendSpacePlayer");
        }
        internal unsafe AnimGraphNode_BlendSpacePlayer_fields* AnimGraphNode_BlendSpacePlayer_ptr => (AnimGraphNode_BlendSpacePlayer_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AnimGraphNode_BlendSpacePlayer(IntPtr p) => UObject.Make<AnimGraphNode_BlendSpacePlayer>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AnimGraphNode_BlendSpacePlayer DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AnimGraphNode_BlendSpacePlayer New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
