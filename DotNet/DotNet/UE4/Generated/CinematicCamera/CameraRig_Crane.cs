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
using UE4.CinematicCamera.Native;
using UE4.Engine;

namespace UE4.CinematicCamera {
    ///<summary>A simple rig for simulating crane-like camera movements.</summary>
    public unsafe partial class CameraRig_Crane : Actor  {
        ///<summary>Controls the pitch of the crane arm.</summary>
        public unsafe float CranePitch {
            get {return CameraRig_Crane_ptr->CranePitch;}
            set {CameraRig_Crane_ptr->CranePitch = value;}
        }
        ///<summary>Controls the yaw of the crane arm.</summary>
        public unsafe float CraneYaw {
            get {return CameraRig_Crane_ptr->CraneYaw;}
            set {CameraRig_Crane_ptr->CraneYaw = value;}
        }
        ///<summary>Controls the length of the crane arm.</summary>
        public unsafe float CraneArmLength {
            get {return CameraRig_Crane_ptr->CraneArmLength;}
            set {CameraRig_Crane_ptr->CraneArmLength = value;}
        }
        public bool bLockMountPitch {
            get {return Main.GetGetBoolPropertyByName(this, "bLockMountPitch"); }
            set {Main.SetGetBoolPropertyByName(this, "bLockMountPitch", value); }
        }
        public bool bLockMountYaw {
            get {return Main.GetGetBoolPropertyByName(this, "bLockMountYaw"); }
            set {Main.SetGetBoolPropertyByName(this, "bLockMountYaw", value); }
        }
        ///<summary>Root component to give the whole actor a transform.</summary>
        public unsafe SceneComponent TransformComponent {
            get {return CameraRig_Crane_ptr->TransformComponent;}
            set {CameraRig_Crane_ptr->TransformComponent = value;}
        }
        ///<summary>Component to control Yaw.</summary>
        public unsafe SceneComponent CraneYawControl {
            get {return CameraRig_Crane_ptr->CraneYawControl;}
            set {CameraRig_Crane_ptr->CraneYawControl = value;}
        }
        ///<summary>Component to control Pitch.</summary>
        public unsafe SceneComponent CranePitchControl {
            get {return CameraRig_Crane_ptr->CranePitchControl;}
            set {CameraRig_Crane_ptr->CranePitchControl = value;}
        }
        ///<summary>Component to define the attach point for cameras.</summary>
        public unsafe SceneComponent CraneCameraMount {
            get {return CameraRig_Crane_ptr->CraneCameraMount;}
            set {CameraRig_Crane_ptr->CraneCameraMount = value;}
        }
        ///<summary>Preview meshes for visualization</summary>
        public unsafe StaticMeshComponent PreviewMesh_CraneArm {
            get {return CameraRig_Crane_ptr->PreviewMesh_CraneArm;}
            set {CameraRig_Crane_ptr->PreviewMesh_CraneArm = value;}
        }
        ///<summary>Preview Mesh Crane Base</summary>
        public unsafe StaticMeshComponent PreviewMesh_CraneBase {
            get {return CameraRig_Crane_ptr->PreviewMesh_CraneBase;}
            set {CameraRig_Crane_ptr->PreviewMesh_CraneBase = value;}
        }
        ///<summary>Preview Mesh Crane Mount</summary>
        public unsafe StaticMeshComponent PreviewMesh_CraneMount {
            get {return CameraRig_Crane_ptr->PreviewMesh_CraneMount;}
            set {CameraRig_Crane_ptr->PreviewMesh_CraneMount = value;}
        }
        ///<summary>Preview Mesh Crane Counter Weight</summary>
        public unsafe StaticMeshComponent PreviewMesh_CraneCounterWeight {
            get {return CameraRig_Crane_ptr->PreviewMesh_CraneCounterWeight;}
            set {CameraRig_Crane_ptr->PreviewMesh_CraneCounterWeight = value;}
        }
        static CameraRig_Crane() {
            StaticClass = Main.GetClass("CameraRig_Crane");
        }
        internal unsafe CameraRig_Crane_fields* CameraRig_Crane_ptr => (CameraRig_Crane_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator CameraRig_Crane(IntPtr p) => UObject.Make<CameraRig_Crane>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static CameraRig_Crane DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static CameraRig_Crane New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
