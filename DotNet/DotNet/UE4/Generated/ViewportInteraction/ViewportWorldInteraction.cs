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
using UE4.UnrealEd;
using UE4.Engine;

namespace UE4.ViewportInteraction {
    ///<summary>Viewport World Interaction</summary>
    public unsafe partial class ViewportWorldInteraction : EditorWorldExtension  {
        ///<summary>All the interactors registered to modify the world</summary>
        public ObjectArrayField<ViewportInteractor> Interactors{ get {
            if(Interactors_store == null) Interactors_store = new ObjectArrayField<ViewportInteractor> (&ViewportWorldInteraction_ptr->Interactors);
            return Interactors_store;
        } }
        private ObjectArrayField<ViewportInteractor> Interactors_store;

        ///<summary>The active system being used to transform objects</summary>
        public unsafe ViewportTransformer ViewportTransformer {
            get {return ViewportWorldInteraction_ptr->ViewportTransformer;}
            set {ViewportWorldInteraction_ptr->ViewportTransformer = value;}
        }
        ///<summary>Transform gizmo actor, for manipulating selected actor(s)</summary>
        public unsafe BaseTransformGizmo TransformGizmoActor {
            get {return ViewportWorldInteraction_ptr->TransformGizmoActor;}
            set {ViewportWorldInteraction_ptr->TransformGizmoActor = value;}
        }
        ///<summary>Actor for the snap grid</summary>
        public unsafe Actor SnapGridActor {
            get {return ViewportWorldInteraction_ptr->SnapGridActor;}
            set {ViewportWorldInteraction_ptr->SnapGridActor = value;}
        }
        ///<summary>The plane mesh we use to draw a snap grid under selected objects</summary>
        public unsafe StaticMeshComponent SnapGridMeshComponent {
            get {return ViewportWorldInteraction_ptr->SnapGridMeshComponent;}
            set {ViewportWorldInteraction_ptr->SnapGridMeshComponent = value;}
        }
        ///<summary>MID for the snap grid, so we can update snap values on the fly</summary>
        public unsafe MaterialInstanceDynamic SnapGridMID {
            get {return ViewportWorldInteraction_ptr->SnapGridMID;}
            set {ViewportWorldInteraction_ptr->SnapGridMID = value;}
        }
        ///<summary>The default mouse cursor interactor, activated on demand</summary>
        public unsafe MouseCursorInteractor DefaultMouseCursorInteractor {
            get {return ViewportWorldInteraction_ptr->DefaultMouseCursorInteractor;}
            set {ViewportWorldInteraction_ptr->DefaultMouseCursorInteractor = value;}
        }
         //TODO: array not UObject TArray ActorsToExcludeFromHitTest
        ///<summary>Container of assets</summary>
        public unsafe ViewportInteractionAssetContainer AssetContainer {
            get {return ViewportWorldInteraction_ptr->AssetContainer;}
            set {ViewportWorldInteraction_ptr->AssetContainer = value;}
        }
        static ViewportWorldInteraction() {
            StaticClass = Main.GetClass("ViewportWorldInteraction");
        }
        internal unsafe ViewportWorldInteraction_fields* ViewportWorldInteraction_ptr => (ViewportWorldInteraction_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ViewportWorldInteraction(IntPtr p) => UObject.Make<ViewportWorldInteraction>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ViewportWorldInteraction DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ViewportWorldInteraction New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
