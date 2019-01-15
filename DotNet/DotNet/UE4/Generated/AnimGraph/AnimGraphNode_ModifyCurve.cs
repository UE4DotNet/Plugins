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
    ///<summary>Easy way to modify curve values on a pose</summary>
    public unsafe partial class AnimGraphNode_ModifyCurve : AnimGraphNode_Base  {
        ///<summary>Node</summary>
        public unsafe AnimNode_ModifyCurve Node {
            get {return AnimGraphNode_ModifyCurve_ptr->Node;}
            set {AnimGraphNode_ModifyCurve_ptr->Node = value;}
        }
        static AnimGraphNode_ModifyCurve() {
            StaticClass = Main.GetClass("AnimGraphNode_ModifyCurve");
        }
        internal unsafe AnimGraphNode_ModifyCurve_fields* AnimGraphNode_ModifyCurve_ptr => (AnimGraphNode_ModifyCurve_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AnimGraphNode_ModifyCurve(IntPtr p) => UObject.Make<AnimGraphNode_ModifyCurve>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AnimGraphNode_ModifyCurve DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AnimGraphNode_ModifyCurve New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
