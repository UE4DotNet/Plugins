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
using UE4.Engine;

namespace UE4.VREditor {
    ///<summary>Avatar Actor</summary>
    public unsafe partial class VREditorAvatarActor : Actor  {
        ///<summary>Our avatar's head mesh</summary>
        public unsafe StaticMeshComponent HeadMeshComponent {
            get {return VREditorAvatarActor_ptr->HeadMeshComponent;}
            set {VREditorAvatarActor_ptr->HeadMeshComponent = value;}
        }
        ///<summary>The grid that appears while the user is dragging the world around</summary>
        public unsafe StaticMeshComponent WorldMovementGridMeshComponent {
            get {return VREditorAvatarActor_ptr->WorldMovementGridMeshComponent;}
            set {VREditorAvatarActor_ptr->WorldMovementGridMeshComponent = value;}
        }
        ///<summary>Grid mesh component dynamic material instance to set the opacity</summary>
        public unsafe MaterialInstanceDynamic WorldMovementGridMID {
            get {return VREditorAvatarActor_ptr->WorldMovementGridMID;}
            set {VREditorAvatarActor_ptr->WorldMovementGridMID = value;}
        }
        ///<summary>Opacity of the movement grid and post process</summary>
        public unsafe float WorldMovementGridOpacity {
            get {return VREditorAvatarActor_ptr->WorldMovementGridOpacity;}
            set {VREditorAvatarActor_ptr->WorldMovementGridOpacity = value;}
        }
        public bool bIsDrawingWorldMovementPostProcess {
            get {return Main.GetGetBoolPropertyByName(this, "bIsDrawingWorldMovementPostProcess"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsDrawingWorldMovementPostProcess", value); }
        }
        ///<summary>Post process material for "greying out" the world while in world movement mode</summary>
        public unsafe MaterialInstanceDynamic WorldMovementPostProcessMaterial {
            get {return VREditorAvatarActor_ptr->WorldMovementPostProcessMaterial;}
            set {VREditorAvatarActor_ptr->WorldMovementPostProcessMaterial = value;}
        }
        ///<summary>Background progressbar scaling mesh</summary>
        public unsafe StaticMeshComponent ScaleProgressMeshComponent {
            get {return VREditorAvatarActor_ptr->ScaleProgressMeshComponent;}
            set {VREditorAvatarActor_ptr->ScaleProgressMeshComponent = value;}
        }
        ///<summary>Current scale progressbar mesh</summary>
        public unsafe StaticMeshComponent CurrentScaleProgressMeshComponent {
            get {return VREditorAvatarActor_ptr->CurrentScaleProgressMeshComponent;}
            set {VREditorAvatarActor_ptr->CurrentScaleProgressMeshComponent = value;}
        }
        ///<summary>Current scale text</summary>
        public unsafe TextRenderComponent UserScaleIndicatorText {
            get {return VREditorAvatarActor_ptr->UserScaleIndicatorText;}
            set {VREditorAvatarActor_ptr->UserScaleIndicatorText = value;}
        }
        ///<summary>Base dynamic material for the user scale fixed progressbar</summary>
        public unsafe MaterialInstanceDynamic FixedUserScaleMID {
            get {return VREditorAvatarActor_ptr->FixedUserScaleMID;}
            set {VREditorAvatarActor_ptr->FixedUserScaleMID = value;}
        }
        ///<summary>Translucent dynamic material for the user scale fixed progressbar</summary>
        public unsafe MaterialInstanceDynamic TranslucentFixedUserScaleMID {
            get {return VREditorAvatarActor_ptr->TranslucentFixedUserScaleMID;}
            set {VREditorAvatarActor_ptr->TranslucentFixedUserScaleMID = value;}
        }
        ///<summary>Base dynamic material for the current user scale progressbar</summary>
        public unsafe MaterialInstanceDynamic CurrentUserScaleMID {
            get {return VREditorAvatarActor_ptr->CurrentUserScaleMID;}
            set {VREditorAvatarActor_ptr->CurrentUserScaleMID = value;}
        }
        ///<summary>Translucent dynamic material for the current user scale progressbar</summary>
        public unsafe MaterialInstanceDynamic TranslucentCurrentUserScaleMID {
            get {return VREditorAvatarActor_ptr->TranslucentCurrentUserScaleMID;}
            set {VREditorAvatarActor_ptr->TranslucentCurrentUserScaleMID = value;}
        }
        ///<summary>Post process for drawing VR-specific post effects</summary>
        public unsafe PostProcessComponent PostProcessComponent {
            get {return VREditorAvatarActor_ptr->PostProcessComponent;}
            set {VREditorAvatarActor_ptr->PostProcessComponent = value;}
        }
        ///<summary>Owning object</summary>
        public unsafe VREditorMode VRMode {
            get {return VREditorAvatarActor_ptr->VRMode;}
            set {VREditorAvatarActor_ptr->VRMode = value;}
        }
        static VREditorAvatarActor() {
            StaticClass = Main.GetClass("VREditorAvatarActor");
        }
        internal unsafe VREditorAvatarActor_fields* VREditorAvatarActor_ptr => (VREditorAvatarActor_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator VREditorAvatarActor(IntPtr p) => UObject.Make<VREditorAvatarActor>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static VREditorAvatarActor DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static VREditorAvatarActor New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
