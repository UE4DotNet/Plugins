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
using UE4.ViewportInteraction.Native;
using UE4.Engine;

namespace UE4.ViewportInteraction {
    ///<summary>A transform gizmo on the pivot that allows you to interact with selected objects by moving, scaling and rotating.</summary>
    public unsafe partial class PivotTransformGizmo : BaseTransformGizmo  {
        ///<summary>Uniform scale handle group component</summary>
        public unsafe UniformScaleGizmoHandleGroup UniformScaleGizmoHandleGroup {
            get {return PivotTransformGizmo_ptr->UniformScaleGizmoHandleGroup;}
            set {PivotTransformGizmo_ptr->UniformScaleGizmoHandleGroup = value;}
        }
        ///<summary>Translation handle group component</summary>
        public unsafe PivotTranslationGizmoHandleGroup TranslationGizmoHandleGroup {
            get {return PivotTransformGizmo_ptr->TranslationGizmoHandleGroup;}
            set {PivotTransformGizmo_ptr->TranslationGizmoHandleGroup = value;}
        }
        ///<summary>Scale handle group component</summary>
        public unsafe PivotScaleGizmoHandleGroup ScaleGizmoHandleGroup {
            get {return PivotTransformGizmo_ptr->ScaleGizmoHandleGroup;}
            set {PivotTransformGizmo_ptr->ScaleGizmoHandleGroup = value;}
        }
        ///<summary>Plane translation handle group component</summary>
        public unsafe PivotPlaneTranslationGizmoHandleGroup PlaneTranslationGizmoHandleGroup {
            get {return PivotTransformGizmo_ptr->PlaneTranslationGizmoHandleGroup;}
            set {PivotTransformGizmo_ptr->PlaneTranslationGizmoHandleGroup = value;}
        }
        ///<summary>Rotation handle group component</summary>
        public unsafe PivotRotationGizmoHandleGroup RotationGizmoHandleGroup {
            get {return PivotTransformGizmo_ptr->RotationGizmoHandleGroup;}
            set {PivotTransformGizmo_ptr->RotationGizmoHandleGroup = value;}
        }
        ///<summary>Stretch handle group component</summary>
        public unsafe StretchGizmoHandleGroup StretchGizmoHandleGroup {
            get {return PivotTransformGizmo_ptr->StretchGizmoHandleGroup;}
            set {PivotTransformGizmo_ptr->StretchGizmoHandleGroup = value;}
        }
        ///<summary>Handle from previous tick that was dragged</summary>
        public unsafe ActorComponent LastDraggingHandle {
            get {return PivotTransformGizmo_ptr->LastDraggingHandle;}
            set {PivotTransformGizmo_ptr->LastDraggingHandle = value;}
        }
        static PivotTransformGizmo() {
            StaticClass = Main.GetClass("PivotTransformGizmo");
        }
        internal unsafe PivotTransformGizmo_fields* PivotTransformGizmo_ptr => (PivotTransformGizmo_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PivotTransformGizmo(IntPtr p) => UObject.Make<PivotTransformGizmo>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PivotTransformGizmo DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PivotTransformGizmo New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
