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
using UE4.VREditor.Native;
using UE4.HeadMountedDisplay;
using UE4.Engine;

namespace UE4.VREditor {
    ///<summary>Represents the interactor in the world</summary>
    public unsafe partial class VREditorMotionControllerInteractor : VREditorInteractor  {
        ///<summary>Motion controller component which handles late-frame transform updates of all parented sub-components</summary>
        public unsafe MotionControllerComponent MotionControllerComponent {
            get {return VREditorMotionControllerInteractor_ptr->MotionControllerComponent;}
            set {VREditorMotionControllerInteractor_ptr->MotionControllerComponent = value;}
        }
        ///<summary>Mesh for this hand</summary>
        public unsafe StaticMeshComponent HandMeshComponent {
            get {return VREditorMotionControllerInteractor_ptr->HandMeshComponent;}
            set {VREditorMotionControllerInteractor_ptr->HandMeshComponent = value;}
        }
        ///<summary>Spline for this hand's laser pointer</summary>
        public unsafe SplineComponent LaserSplineComponent {
            get {return VREditorMotionControllerInteractor_ptr->LaserSplineComponent;}
            set {VREditorMotionControllerInteractor_ptr->LaserSplineComponent = value;}
        }
        ///<summary>Spline meshes for curved laser</summary>
        public ObjectArrayField<SplineMeshComponent> LaserSplineMeshComponents{ get {
            if(LaserSplineMeshComponents_store == null) LaserSplineMeshComponents_store = new ObjectArrayField<SplineMeshComponent> (&VREditorMotionControllerInteractor_ptr->LaserSplineMeshComponents);
            return LaserSplineMeshComponents_store;
        } }
        private ObjectArrayField<SplineMeshComponent> LaserSplineMeshComponents_store;

        ///<summary>MID for laser pointer material (opaque parts)</summary>
        public unsafe MaterialInstanceDynamic LaserPointerMID {
            get {return VREditorMotionControllerInteractor_ptr->LaserPointerMID;}
            set {VREditorMotionControllerInteractor_ptr->LaserPointerMID = value;}
        }
        ///<summary>MID for laser pointer material (translucent parts)</summary>
        public unsafe MaterialInstanceDynamic TranslucentLaserPointerMID {
            get {return VREditorMotionControllerInteractor_ptr->TranslucentLaserPointerMID;}
            set {VREditorMotionControllerInteractor_ptr->TranslucentLaserPointerMID = value;}
        }
        ///<summary>Hover impact indicator mesh</summary>
        public unsafe StaticMeshComponent HoverMeshComponent {
            get {return VREditorMotionControllerInteractor_ptr->HoverMeshComponent;}
            set {VREditorMotionControllerInteractor_ptr->HoverMeshComponent = value;}
        }
        ///<summary>Hover point light</summary>
        public unsafe PointLightComponent HoverPointLightComponent {
            get {return VREditorMotionControllerInteractor_ptr->HoverPointLightComponent;}
            set {VREditorMotionControllerInteractor_ptr->HoverPointLightComponent = value;}
        }
        ///<summary>MID for hand mesh</summary>
        public unsafe MaterialInstanceDynamic HandMeshMID {
            get {return VREditorMotionControllerInteractor_ptr->HandMeshMID;}
            set {VREditorMotionControllerInteractor_ptr->HandMeshMID = value;}
        }
        static VREditorMotionControllerInteractor() {
            StaticClass = Main.GetClass("VREditorMotionControllerInteractor");
        }
        internal unsafe VREditorMotionControllerInteractor_fields* VREditorMotionControllerInteractor_ptr => (VREditorMotionControllerInteractor_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator VREditorMotionControllerInteractor(IntPtr p) => UObject.Make<VREditorMotionControllerInteractor>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static VREditorMotionControllerInteractor DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static VREditorMotionControllerInteractor New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
