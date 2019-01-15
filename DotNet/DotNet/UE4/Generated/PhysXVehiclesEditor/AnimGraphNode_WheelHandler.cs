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
using UE4.PhysXVehiclesEditor.Native;
using UE4.PhysXVehicles;
using UE4.AnimGraph;

namespace UE4.PhysXVehiclesEditor {
    ///<summary>Anim Graph Node Wheel Handler</summary>
    public unsafe partial class AnimGraphNode_WheelHandler : AnimGraphNode_SkeletalControlBase  {
        ///<summary>Node</summary>
        public unsafe AnimNode_WheelHandler Node {
            get {return AnimGraphNode_WheelHandler_ptr->Node;}
            set {AnimGraphNode_WheelHandler_ptr->Node = value;}
        }
        static AnimGraphNode_WheelHandler() {
            StaticClass = Main.GetClass("AnimGraphNode_WheelHandler");
        }
        internal unsafe AnimGraphNode_WheelHandler_fields* AnimGraphNode_WheelHandler_ptr => (AnimGraphNode_WheelHandler_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AnimGraphNode_WheelHandler(IntPtr p) => UObject.Make<AnimGraphNode_WheelHandler>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AnimGraphNode_WheelHandler DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AnimGraphNode_WheelHandler New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
