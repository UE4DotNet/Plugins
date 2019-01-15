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
    ///<summary>Axis Gizmo handle for rotation</summary>
    public unsafe partial class PivotRotationGizmoHandleGroup : AxisGizmoHandleGroup  {
        ///<summary>Root component of all the mesh components that are used to visualize the rotation when dragging</summary>
        public unsafe SceneComponent RootFullRotationHandleComponent {
            get {return PivotRotationGizmoHandleGroup_ptr->RootFullRotationHandleComponent;}
            set {PivotRotationGizmoHandleGroup_ptr->RootFullRotationHandleComponent = value;}
        }
        ///<summary>When dragging a rotation handle the full rotation circle appears</summary>
        public unsafe GizmoHandleMeshComponent FullRotationHandleMeshComponent {
            get {return PivotRotationGizmoHandleGroup_ptr->FullRotationHandleMeshComponent;}
            set {PivotRotationGizmoHandleGroup_ptr->FullRotationHandleMeshComponent = value;}
        }
        ///<summary>The mesh that indicated the start rotation</summary>
        public unsafe GizmoHandleMeshComponent StartRotationIndicatorMeshComponent {
            get {return PivotRotationGizmoHandleGroup_ptr->StartRotationIndicatorMeshComponent;}
            set {PivotRotationGizmoHandleGroup_ptr->StartRotationIndicatorMeshComponent = value;}
        }
        ///<summary>The root component of the start rotation indicator</summary>
        public unsafe SceneComponent RootStartRotationIdicatorComponent {
            get {return PivotRotationGizmoHandleGroup_ptr->RootStartRotationIdicatorComponent;}
            set {PivotRotationGizmoHandleGroup_ptr->RootStartRotationIdicatorComponent = value;}
        }
        ///<summary>The mesh that indicated the delta rotation</summary>
        public unsafe GizmoHandleMeshComponent DeltaRotationIndicatorMeshComponent {
            get {return PivotRotationGizmoHandleGroup_ptr->DeltaRotationIndicatorMeshComponent;}
            set {PivotRotationGizmoHandleGroup_ptr->DeltaRotationIndicatorMeshComponent = value;}
        }
        ///<summary>The root component of the delta rotation indicator</summary>
        public unsafe SceneComponent RootDeltaRotationIndicatorComponent {
            get {return PivotRotationGizmoHandleGroup_ptr->RootDeltaRotationIndicatorComponent;}
            set {PivotRotationGizmoHandleGroup_ptr->RootDeltaRotationIndicatorComponent = value;}
        }
        static PivotRotationGizmoHandleGroup() {
            StaticClass = Main.GetClass("PivotRotationGizmoHandleGroup");
        }
        internal unsafe PivotRotationGizmoHandleGroup_fields* PivotRotationGizmoHandleGroup_ptr => (PivotRotationGizmoHandleGroup_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PivotRotationGizmoHandleGroup(IntPtr p) => UObject.Make<PivotRotationGizmoHandleGroup>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PivotRotationGizmoHandleGroup DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PivotRotationGizmoHandleGroup New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
