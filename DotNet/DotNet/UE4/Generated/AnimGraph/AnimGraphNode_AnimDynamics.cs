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
using UE4.Engine;

namespace UE4.AnimGraph {
    ///<summary>Anim Graph Node Anim Dynamics</summary>
    public unsafe partial class AnimGraphNode_AnimDynamics : AnimGraphNode_SkeletalControlBase  {
        ///<summary>Node</summary>
        public unsafe AnimNode_AnimDynamics Node {
            get {return AnimGraphNode_AnimDynamics_ptr->Node;}
            set {AnimGraphNode_AnimDynamics_ptr->Node = value;}
        }
        public bool bPreviewLive {
            get {return Main.GetGetBoolPropertyByName(this, "bPreviewLive"); }
            set {Main.SetGetBoolPropertyByName(this, "bPreviewLive", value); }
        }
        public bool bShowLinearLimits {
            get {return Main.GetGetBoolPropertyByName(this, "bShowLinearLimits"); }
            set {Main.SetGetBoolPropertyByName(this, "bShowLinearLimits", value); }
        }
        public bool bShowAngularLimits {
            get {return Main.GetGetBoolPropertyByName(this, "bShowAngularLimits"); }
            set {Main.SetGetBoolPropertyByName(this, "bShowAngularLimits", value); }
        }
        public bool bShowPlanarLimit {
            get {return Main.GetGetBoolPropertyByName(this, "bShowPlanarLimit"); }
            set {Main.SetGetBoolPropertyByName(this, "bShowPlanarLimit", value); }
        }
        public bool bShowSphericalLimit {
            get {return Main.GetGetBoolPropertyByName(this, "bShowSphericalLimit"); }
            set {Main.SetGetBoolPropertyByName(this, "bShowSphericalLimit", value); }
        }
        public bool bShowCollisionSpheres {
            get {return Main.GetGetBoolPropertyByName(this, "bShowCollisionSpheres"); }
            set {Main.SetGetBoolPropertyByName(this, "bShowCollisionSpheres", value); }
        }
        ///<summary>Last Preview Component</summary>
        public unsafe SkeletalMeshComponent LastPreviewComponent {
            get {return AnimGraphNode_AnimDynamics_ptr->LastPreviewComponent;}
            set {AnimGraphNode_AnimDynamics_ptr->LastPreviewComponent = value;}
        }
        static AnimGraphNode_AnimDynamics() {
            StaticClass = Main.GetClass("AnimGraphNode_AnimDynamics");
        }
        internal unsafe AnimGraphNode_AnimDynamics_fields* AnimGraphNode_AnimDynamics_ptr => (AnimGraphNode_AnimDynamics_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AnimGraphNode_AnimDynamics(IntPtr p) => UObject.Make<AnimGraphNode_AnimDynamics>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AnimGraphNode_AnimDynamics DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AnimGraphNode_AnimDynamics New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
