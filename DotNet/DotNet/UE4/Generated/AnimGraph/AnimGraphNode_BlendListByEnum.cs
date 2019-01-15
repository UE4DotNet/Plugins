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
    ///<summary>Anim Graph Node Blend List by Enum</summary>
    public unsafe partial class AnimGraphNode_BlendListByEnum : AnimGraphNode_BlendListBase  {
        ///<summary>Node</summary>
        public unsafe AnimNode_BlendListByEnum Node {
            get {return AnimGraphNode_BlendListByEnum_ptr->Node;}
            set {AnimGraphNode_BlendListByEnum_ptr->Node = value;}
        }
        ///<summary>Name of the enum being switched on</summary>
        public unsafe UEnum BoundEnum {
            get {return AnimGraphNode_BlendListByEnum_ptr->BoundEnum;}
            set {AnimGraphNode_BlendListByEnum_ptr->BoundEnum = value;}
        }
         //TODO: array not UObject TArray VisibleEnumEntries
        static AnimGraphNode_BlendListByEnum() {
            StaticClass = Main.GetClass("AnimGraphNode_BlendListByEnum");
        }
        internal unsafe AnimGraphNode_BlendListByEnum_fields* AnimGraphNode_BlendListByEnum_ptr => (AnimGraphNode_BlendListByEnum_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AnimGraphNode_BlendListByEnum(IntPtr p) => UObject.Make<AnimGraphNode_BlendListByEnum>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AnimGraphNode_BlendListByEnum DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AnimGraphNode_BlendListByEnum New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
