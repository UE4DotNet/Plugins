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
    ///<summary>This is the 'source version' of a bone driven controller, which maps part of the state from one bone to another (e.g., 2 * source.x -> target.z)</summary>
    public unsafe partial class AnimGraphNode_BoneDrivenController : AnimGraphNode_SkeletalControlBase  {
        ///<summary>Node</summary>
        public unsafe AnimNode_BoneDrivenController Node {
            get {return AnimGraphNode_BoneDrivenController_ptr->Node;}
            set {AnimGraphNode_BoneDrivenController_ptr->Node = value;}
        }
        static AnimGraphNode_BoneDrivenController() {
            StaticClass = Main.GetClass("AnimGraphNode_BoneDrivenController");
        }
        internal unsafe AnimGraphNode_BoneDrivenController_fields* AnimGraphNode_BoneDrivenController_ptr => (AnimGraphNode_BoneDrivenController_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AnimGraphNode_BoneDrivenController(IntPtr p) => UObject.Make<AnimGraphNode_BoneDrivenController>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AnimGraphNode_BoneDrivenController DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AnimGraphNode_BoneDrivenController New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
