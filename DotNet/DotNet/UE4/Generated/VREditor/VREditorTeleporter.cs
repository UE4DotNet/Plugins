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
using UE4.ViewportInteraction;

namespace UE4.VREditor {
    ///<summary>VR Editor teleport manager and the visual representation of the teleport</summary>
    public unsafe partial class VREditorTeleporter : Actor  {
        ///<summary>The owning VR mode</summary>
        public unsafe VREditorMode VRMode {
            get {return VREditorTeleporter_ptr->VRMode;}
            set {VREditorTeleporter_ptr->VRMode = value;}
        }
        ///<summary>Visuals for the feet location of the teleporter with the same direction of the HMD yaw</summary>
        public unsafe StaticMeshComponent TeleportDirectionMeshComponent {
            get {return VREditorTeleporter_ptr->TeleportDirectionMeshComponent;}
            set {VREditorTeleporter_ptr->TeleportDirectionMeshComponent = value;}
        }
        ///<summary>Visuals for teleport HMD</summary>
        public unsafe StaticMeshComponent HMDMeshComponent {
            get {return VREditorTeleporter_ptr->HMDMeshComponent;}
            set {VREditorTeleporter_ptr->HMDMeshComponent = value;}
        }
        ///<summary>Visuals for teleport left motion controller</summary>
        public unsafe StaticMeshComponent LeftMotionControllerMeshComponent {
            get {return VREditorTeleporter_ptr->LeftMotionControllerMeshComponent;}
            set {VREditorTeleporter_ptr->LeftMotionControllerMeshComponent = value;}
        }
        ///<summary>Visuals for teleport right motion controller</summary>
        public unsafe StaticMeshComponent RightMotionControllerMeshComponent {
            get {return VREditorTeleporter_ptr->RightMotionControllerMeshComponent;}
            set {VREditorTeleporter_ptr->RightMotionControllerMeshComponent = value;}
        }
        ///<summary>Dynamic material for teleport visuals</summary>
        public unsafe MaterialInstanceDynamic TeleportMID {
            get {return VREditorTeleporter_ptr->TeleportMID;}
            set {VREditorTeleporter_ptr->TeleportMID = value;}
        }
        ///<summary>The interactor that started aiming to teleport</summary>
        public unsafe ViewportInteractor InteractorTryingTeleport {
            get {return VREditorTeleporter_ptr->InteractorTryingTeleport;}
            set {VREditorTeleporter_ptr->InteractorTryingTeleport = value;}
        }
        static VREditorTeleporter() {
            StaticClass = Main.GetClass("VREditorTeleporter");
        }
        internal unsafe VREditorTeleporter_fields* VREditorTeleporter_ptr => (VREditorTeleporter_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator VREditorTeleporter(IntPtr p) => UObject.Make<VREditorTeleporter>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static VREditorTeleporter DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static VREditorTeleporter New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
