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
    ///<summary>Anim Graph Node Sub Instance</summary>
    public unsafe partial class AnimGraphNode_SubInstance : AnimGraphNode_Base  {
        ///<summary>Node</summary>
        public unsafe AnimNode_SubInstance Node {
            get {return AnimGraphNode_SubInstance_ptr->Node;}
            set {AnimGraphNode_SubInstance_ptr->Node = value;}
        }
         //TODO: array not UObject TArray KnownExposableProperties
         //TODO: array not UObject TArray ExposedPropertyNames
        static AnimGraphNode_SubInstance() {
            StaticClass = Main.GetClass("AnimGraphNode_SubInstance");
        }
        internal unsafe AnimGraphNode_SubInstance_fields* AnimGraphNode_SubInstance_ptr => (AnimGraphNode_SubInstance_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AnimGraphNode_SubInstance(IntPtr p) => UObject.Make<AnimGraphNode_SubInstance>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AnimGraphNode_SubInstance DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AnimGraphNode_SubInstance New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
