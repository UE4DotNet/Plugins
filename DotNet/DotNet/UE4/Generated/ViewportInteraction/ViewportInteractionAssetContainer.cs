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
    ///<summary>Asset container for viewport interaction.</summary>
    public unsafe partial class ViewportInteractionAssetContainer : DataAsset  {
        ///<summary>Sound</summary>
        public unsafe SoundBase GizmoHandleSelectedSound {
            get {return ViewportInteractionAssetContainer_ptr->GizmoHandleSelectedSound;}
            set {ViewportInteractionAssetContainer_ptr->GizmoHandleSelectedSound = value;}
        }
        ///<summary>Gizmo Handle Drop Sound</summary>
        public unsafe SoundBase GizmoHandleDropSound {
            get {return ViewportInteractionAssetContainer_ptr->GizmoHandleDropSound;}
            set {ViewportInteractionAssetContainer_ptr->GizmoHandleDropSound = value;}
        }
        ///<summary>Selection Change Sound</summary>
        public unsafe SoundBase SelectionChangeSound {
            get {return ViewportInteractionAssetContainer_ptr->SelectionChangeSound;}
            set {ViewportInteractionAssetContainer_ptr->SelectionChangeSound = value;}
        }
        ///<summary>Selection Drop Sound</summary>
        public unsafe SoundBase SelectionDropSound {
            get {return ViewportInteractionAssetContainer_ptr->SelectionDropSound;}
            set {ViewportInteractionAssetContainer_ptr->SelectionDropSound = value;}
        }
        ///<summary>Selection Start Drag Sound</summary>
        public unsafe SoundBase SelectionStartDragSound {
            get {return ViewportInteractionAssetContainer_ptr->SelectionStartDragSound;}
            set {ViewportInteractionAssetContainer_ptr->SelectionStartDragSound = value;}
        }
        ///<summary>Grid Snap Sound</summary>
        public unsafe SoundBase GridSnapSound {
            get {return ViewportInteractionAssetContainer_ptr->GridSnapSound;}
            set {ViewportInteractionAssetContainer_ptr->GridSnapSound = value;}
        }
        ///<summary>Actor Snap Sound</summary>
        public unsafe SoundBase ActorSnapSound {
            get {return ViewportInteractionAssetContainer_ptr->ActorSnapSound;}
            set {ViewportInteractionAssetContainer_ptr->ActorSnapSound = value;}
        }
        ///<summary>Undo Sound</summary>
        public unsafe SoundBase UndoSound {
            get {return ViewportInteractionAssetContainer_ptr->UndoSound;}
            set {ViewportInteractionAssetContainer_ptr->UndoSound = value;}
        }
        ///<summary>Redo Sound</summary>
        public unsafe SoundBase RedoSound {
            get {return ViewportInteractionAssetContainer_ptr->RedoSound;}
            set {ViewportInteractionAssetContainer_ptr->RedoSound = value;}
        }
        ///<summary>Meshes</summary>
        public unsafe StaticMesh GridMesh {
            get {return ViewportInteractionAssetContainer_ptr->GridMesh;}
            set {ViewportInteractionAssetContainer_ptr->GridMesh = value;}
        }
        ///<summary>Translation Handle Mesh</summary>
        public unsafe StaticMesh TranslationHandleMesh {
            get {return ViewportInteractionAssetContainer_ptr->TranslationHandleMesh;}
            set {ViewportInteractionAssetContainer_ptr->TranslationHandleMesh = value;}
        }
        ///<summary>Uniform Scale Handle Mesh</summary>
        public unsafe StaticMesh UniformScaleHandleMesh {
            get {return ViewportInteractionAssetContainer_ptr->UniformScaleHandleMesh;}
            set {ViewportInteractionAssetContainer_ptr->UniformScaleHandleMesh = value;}
        }
        ///<summary>Scale Handle Mesh</summary>
        public unsafe StaticMesh ScaleHandleMesh {
            get {return ViewportInteractionAssetContainer_ptr->ScaleHandleMesh;}
            set {ViewportInteractionAssetContainer_ptr->ScaleHandleMesh = value;}
        }
        ///<summary>Plane Translation Handle Mesh</summary>
        public unsafe StaticMesh PlaneTranslationHandleMesh {
            get {return ViewportInteractionAssetContainer_ptr->PlaneTranslationHandleMesh;}
            set {ViewportInteractionAssetContainer_ptr->PlaneTranslationHandleMesh = value;}
        }
        ///<summary>Rotation Handle Mesh</summary>
        public unsafe StaticMesh RotationHandleMesh {
            get {return ViewportInteractionAssetContainer_ptr->RotationHandleMesh;}
            set {ViewportInteractionAssetContainer_ptr->RotationHandleMesh = value;}
        }
        ///<summary>Rotation Handle Selected Mesh</summary>
        public unsafe StaticMesh RotationHandleSelectedMesh {
            get {return ViewportInteractionAssetContainer_ptr->RotationHandleSelectedMesh;}
            set {ViewportInteractionAssetContainer_ptr->RotationHandleSelectedMesh = value;}
        }
        ///<summary>Start Rotation Indicator Mesh</summary>
        public unsafe StaticMesh StartRotationIndicatorMesh {
            get {return ViewportInteractionAssetContainer_ptr->StartRotationIndicatorMesh;}
            set {ViewportInteractionAssetContainer_ptr->StartRotationIndicatorMesh = value;}
        }
        ///<summary>Current Rotation Indicator Mesh</summary>
        public unsafe StaticMesh CurrentRotationIndicatorMesh {
            get {return ViewportInteractionAssetContainer_ptr->CurrentRotationIndicatorMesh;}
            set {ViewportInteractionAssetContainer_ptr->CurrentRotationIndicatorMesh = value;}
        }
        ///<summary>Free Rotation Handle Mesh</summary>
        public unsafe StaticMesh FreeRotationHandleMesh {
            get {return ViewportInteractionAssetContainer_ptr->FreeRotationHandleMesh;}
            set {ViewportInteractionAssetContainer_ptr->FreeRotationHandleMesh = value;}
        }
        ///<summary>Materials</summary>
        public unsafe MaterialInterface GridMaterial {
            get {return ViewportInteractionAssetContainer_ptr->GridMaterial;}
            set {ViewportInteractionAssetContainer_ptr->GridMaterial = value;}
        }
        ///<summary>Transform Gizmo Material</summary>
        public unsafe MaterialInterface TransformGizmoMaterial {
            get {return ViewportInteractionAssetContainer_ptr->TransformGizmoMaterial;}
            set {ViewportInteractionAssetContainer_ptr->TransformGizmoMaterial = value;}
        }
        ///<summary>Translucent Transform Gizmo Material</summary>
        public unsafe MaterialInterface TranslucentTransformGizmoMaterial {
            get {return ViewportInteractionAssetContainer_ptr->TranslucentTransformGizmoMaterial;}
            set {ViewportInteractionAssetContainer_ptr->TranslucentTransformGizmoMaterial = value;}
        }
        static ViewportInteractionAssetContainer() {
            StaticClass = Main.GetClass("ViewportInteractionAssetContainer");
        }
        internal unsafe ViewportInteractionAssetContainer_fields* ViewportInteractionAssetContainer_ptr => (ViewportInteractionAssetContainer_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ViewportInteractionAssetContainer(IntPtr p) => UObject.Make<ViewportInteractionAssetContainer>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ViewportInteractionAssetContainer DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ViewportInteractionAssetContainer New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
