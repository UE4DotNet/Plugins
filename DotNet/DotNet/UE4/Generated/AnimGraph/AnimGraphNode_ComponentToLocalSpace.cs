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
    ///<summary>Anim Graph Node Component to Local Space</summary>
    public unsafe partial class AnimGraphNode_ComponentToLocalSpace : AnimGraphNode_Base  {
        ///<summary>Node</summary>
        public unsafe AnimNode_ConvertComponentToLocalSpace Node {
            get {return AnimGraphNode_ComponentToLocalSpace_ptr->Node;}
            set {AnimGraphNode_ComponentToLocalSpace_ptr->Node = value;}
        }
        static AnimGraphNode_ComponentToLocalSpace() {
            StaticClass = Main.GetClass("AnimGraphNode_ComponentToLocalSpace");
        }
        internal unsafe AnimGraphNode_ComponentToLocalSpace_fields* AnimGraphNode_ComponentToLocalSpace_ptr => (AnimGraphNode_ComponentToLocalSpace_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AnimGraphNode_ComponentToLocalSpace(IntPtr p) => UObject.Make<AnimGraphNode_ComponentToLocalSpace>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AnimGraphNode_ComponentToLocalSpace DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AnimGraphNode_ComponentToLocalSpace New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
