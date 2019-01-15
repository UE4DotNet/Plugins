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
    ///<summary>Editor node for FABRIK IK skeletal controller</summary>
    public unsafe partial class AnimGraphNode_Fabrik : AnimGraphNode_SkeletalControlBase  {
        ///<summary>Node</summary>
        public unsafe AnimNode_Fabrik Node {
            get {return AnimGraphNode_Fabrik_ptr->Node;}
            set {AnimGraphNode_Fabrik_ptr->Node = value;}
        }
        static AnimGraphNode_Fabrik() {
            StaticClass = Main.GetClass("AnimGraphNode_Fabrik");
        }
        internal unsafe AnimGraphNode_Fabrik_fields* AnimGraphNode_Fabrik_ptr => (AnimGraphNode_Fabrik_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AnimGraphNode_Fabrik(IntPtr p) => UObject.Make<AnimGraphNode_Fabrik>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AnimGraphNode_Fabrik DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AnimGraphNode_Fabrik New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
