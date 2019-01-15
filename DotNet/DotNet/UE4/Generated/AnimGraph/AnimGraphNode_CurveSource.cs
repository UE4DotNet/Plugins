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
    ///<summary>Supply curves from some external source (e.g. audio)</summary>
    public unsafe partial class AnimGraphNode_CurveSource : AnimGraphNode_Base  {
        ///<summary>Node</summary>
        public unsafe AnimNode_CurveSource Node {
            get {return AnimGraphNode_CurveSource_ptr->Node;}
            set {AnimGraphNode_CurveSource_ptr->Node = value;}
        }
        static AnimGraphNode_CurveSource() {
            StaticClass = Main.GetClass("AnimGraphNode_CurveSource");
        }
        internal unsafe AnimGraphNode_CurveSource_fields* AnimGraphNode_CurveSource_ptr => (AnimGraphNode_CurveSource_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AnimGraphNode_CurveSource(IntPtr p) => UObject.Make<AnimGraphNode_CurveSource>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AnimGraphNode_CurveSource DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AnimGraphNode_CurveSource New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
