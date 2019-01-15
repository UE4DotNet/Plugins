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
    ///<summary>Anim Graph Node Sub Input</summary>
    public unsafe partial class AnimGraphNode_SubInput : AnimGraphNode_Base  {
        ///<summary>Node</summary>
        public unsafe AnimNode_SubInput Node {
            get {return AnimGraphNode_SubInput_ptr->Node;}
            set {AnimGraphNode_SubInput_ptr->Node = value;}
        }
        static AnimGraphNode_SubInput() {
            StaticClass = Main.GetClass("AnimGraphNode_SubInput");
        }
        internal unsafe AnimGraphNode_SubInput_fields* AnimGraphNode_SubInput_ptr => (AnimGraphNode_SubInput_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AnimGraphNode_SubInput(IntPtr p) => UObject.Make<AnimGraphNode_SubInput>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AnimGraphNode_SubInput DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AnimGraphNode_SubInput New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
