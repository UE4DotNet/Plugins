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
    ///<summary>Anim Graph Node Sequence Player</summary>
    public unsafe partial class AnimGraphNode_SequencePlayer : AnimGraphNode_AssetPlayerBase  {
        ///<summary>Node</summary>
        public unsafe AnimNode_SequencePlayer Node {
            get {return AnimGraphNode_SequencePlayer_ptr->Node;}
            set {AnimGraphNode_SequencePlayer_ptr->Node = value;}
        }
        static AnimGraphNode_SequencePlayer() {
            StaticClass = Main.GetClass("AnimGraphNode_SequencePlayer");
        }
        internal unsafe AnimGraphNode_SequencePlayer_fields* AnimGraphNode_SequencePlayer_ptr => (AnimGraphNode_SequencePlayer_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AnimGraphNode_SequencePlayer(IntPtr p) => UObject.Make<AnimGraphNode_SequencePlayer>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AnimGraphNode_SequencePlayer DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AnimGraphNode_SequencePlayer New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
