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
using UE4.UnrealEd;
using UE4.ViewportInteraction;

namespace UE4.VREditor {
    ///<summary>VR Editor Mode. Extends editor viewports with functionality for VR controls and object manipulation</summary>
    public unsafe partial class VREditorMode : EditorWorldExtension  {
        ///<summary>Actor with components to represent the VR avatar in the world, including motion controller meshes</summary>
        public unsafe VREditorAvatarActor AvatarActor {
            get {return VREditorMode_ptr->AvatarActor;}
            set {VREditorMode_ptr->AvatarActor = value;}
        }
        ///<summary>VR UI system</summary>
        public unsafe VREditorUISystem UISystem {
            get {return VREditorMode_ptr->UISystem;}
            set {VREditorMode_ptr->UISystem = value;}
        }
        ///<summary>Teleporter system</summary>
        public unsafe VREditorTeleporter TeleportActor {
            get {return VREditorMode_ptr->TeleportActor;}
            set {VREditorMode_ptr->TeleportActor = value;}
        }
        ///<summary>Automatic scale system</summary>
        public unsafe VREditorAutoScaler AutoScalerSystem {
            get {return VREditorMode_ptr->AutoScalerSystem;}
            set {VREditorMode_ptr->AutoScalerSystem = value;}
        }
        ///<summary>World interaction manager</summary>
        public unsafe ViewportWorldInteraction WorldInteraction {
            get {return VREditorMode_ptr->WorldInteraction;}
            set {VREditorMode_ptr->WorldInteraction = value;}
        }
        ///<summary>Placement System</summary>
        public unsafe VREditorPlacement PlacementSystem {
            get {return VREditorMode_ptr->PlacementSystem;}
            set {VREditorMode_ptr->PlacementSystem = value;}
        }
        ///<summary>The right motion controller</summary>
        public unsafe VREditorMotionControllerInteractor LeftHandInteractor {
            get {return VREditorMode_ptr->LeftHandInteractor;}
            set {VREditorMode_ptr->LeftHandInteractor = value;}
        }
        ///<summary>The right motion controller</summary>
        public unsafe VREditorMotionControllerInteractor RightHandInteractor {
            get {return VREditorMode_ptr->RightHandInteractor;}
            set {VREditorMode_ptr->RightHandInteractor = value;}
        }
        ///<summary>Container of assets</summary>
        public unsafe VREditorAssetContainer AssetContainer {
            get {return VREditorMode_ptr->AssetContainer;}
            set {VREditorMode_ptr->AssetContainer = value;}
        }
        static VREditorMode() {
            StaticClass = Main.GetClass("VREditorMode");
        }
        internal unsafe VREditorMode_fields* VREditorMode_ptr => (VREditorMode_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator VREditorMode(IntPtr p) => UObject.Make<VREditorMode>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static VREditorMode DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static VREditorMode New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
