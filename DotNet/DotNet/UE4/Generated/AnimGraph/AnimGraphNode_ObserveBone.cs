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
    ///<summary>This allows you to observe the state of a bone at a particular point in the graph, showing it in any space and optionally relative to the reference pose</summary>
    public unsafe partial class AnimGraphNode_ObserveBone : AnimGraphNode_SkeletalControlBase  {
        ///<summary>Node</summary>
        public unsafe AnimNode_ObserveBone Node {
            get {return AnimGraphNode_ObserveBone_ptr->Node;}
            set {AnimGraphNode_ObserveBone_ptr->Node = value;}
        }
        static AnimGraphNode_ObserveBone() {
            StaticClass = Main.GetClass("AnimGraphNode_ObserveBone");
        }
        internal unsafe AnimGraphNode_ObserveBone_fields* AnimGraphNode_ObserveBone_ptr => (AnimGraphNode_ObserveBone_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AnimGraphNode_ObserveBone(IntPtr p) => UObject.Make<AnimGraphNode_ObserveBone>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AnimGraphNode_ObserveBone DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AnimGraphNode_ObserveBone New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
