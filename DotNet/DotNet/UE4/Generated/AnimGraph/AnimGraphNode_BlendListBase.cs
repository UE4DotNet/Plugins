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
    ///<summary>Anim Graph Node Blend List Base</summary>
    public unsafe partial class AnimGraphNode_BlendListBase : AnimGraphNode_Base  {
        static AnimGraphNode_BlendListBase() {
            StaticClass = Main.GetClass("AnimGraphNode_BlendListBase");
        }
        internal unsafe AnimGraphNode_BlendListBase_fields* AnimGraphNode_BlendListBase_ptr => (AnimGraphNode_BlendListBase_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AnimGraphNode_BlendListBase(IntPtr p) => UObject.Make<AnimGraphNode_BlendListBase>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AnimGraphNode_BlendListBase DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AnimGraphNode_BlendListBase New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
