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
    ///<summary>Base class for gizmo handles</summary>
    public unsafe partial class GizmoHandleGroup : SceneComponent  {
        ///<summary>Gizmo material (opaque)</summary>
        public unsafe MaterialInterface GizmoMaterial {
            get {return GizmoHandleGroup_ptr->GizmoMaterial;}
            set {GizmoHandleGroup_ptr->GizmoMaterial = value;}
        }
        ///<summary>Gizmo material (translucent)</summary>
        public unsafe MaterialInterface TranslucentGizmoMaterial {
            get {return GizmoHandleGroup_ptr->TranslucentGizmoMaterial;}
            set {GizmoHandleGroup_ptr->TranslucentGizmoMaterial = value;}
        }
         //TODO: array not UObject TArray Handles
        ///<summary>The actor transform gizmo owning this handlegroup</summary>
        public unsafe BaseTransformGizmo OwningTransformGizmoActor {
            get {return GizmoHandleGroup_ptr->OwningTransformGizmoActor;}
            set {GizmoHandleGroup_ptr->OwningTransformGizmoActor = value;}
        }
        ///<summary>Drag Operation Component</summary>
        public unsafe ViewportDragOperationComponent DragOperationComponent {
            get {return GizmoHandleGroup_ptr->DragOperationComponent;}
            set {GizmoHandleGroup_ptr->DragOperationComponent = value;}
        }
        static GizmoHandleGroup() {
            StaticClass = Main.GetClass("GizmoHandleGroup");
        }
        internal unsafe GizmoHandleGroup_fields* GizmoHandleGroup_ptr => (GizmoHandleGroup_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator GizmoHandleGroup(IntPtr p) => UObject.Make<GizmoHandleGroup>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static GizmoHandleGroup DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static GizmoHandleGroup New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
