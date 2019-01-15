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
    ///<summary>Camera Rig Rail</summary>
    public unsafe partial class CameraRig_Rail : Actor  {
        ///<summary>Defines current position of the mount point along the rail, in terms of normalized distance from the beginning of the rail.</summary>
        public unsafe float CurrentPositionOnRail {
            get {return CameraRig_Rail_ptr->CurrentPositionOnRail;}
            set {CameraRig_Rail_ptr->CurrentPositionOnRail = value;}
        }
        public bool bLockOrientationToRail {
            get {return Main.GetGetBoolPropertyByName(this, "bLockOrientationToRail"); }
            set {Main.SetGetBoolPropertyByName(this, "bLockOrientationToRail", value); }
        }
        ///<summary>Root component to give the whole actor a transform.</summary>
        public unsafe SceneComponent TransformComponent {
            get {return CameraRig_Rail_ptr->TransformComponent;}
            set {CameraRig_Rail_ptr->TransformComponent = value;}
        }
        ///<summary>Spline component to define the rail path.</summary>
        public unsafe SplineComponent RailSplineComponent {
            get {return CameraRig_Rail_ptr->RailSplineComponent;}
            set {CameraRig_Rail_ptr->RailSplineComponent = value;}
        }
        ///<summary>Component to define the attach point for cameras. Moves along the rail.</summary>
        public unsafe SceneComponent RailCameraMount {
            get {return CameraRig_Rail_ptr->RailCameraMount;}
            set {CameraRig_Rail_ptr->RailCameraMount = value;}
        }
        ///<summary>Preview meshes for visualization</summary>
        public unsafe SplineMeshComponent PreviewMesh_Rail {
            get {return CameraRig_Rail_ptr->PreviewMesh_Rail;}
            set {CameraRig_Rail_ptr->PreviewMesh_Rail = value;}
        }
        ///<summary>Preview Rail Mesh Segments</summary>
        public ObjectArrayField<SplineMeshComponent> PreviewRailMeshSegments{ get {
            if(PreviewRailMeshSegments_store == null) PreviewRailMeshSegments_store = new ObjectArrayField<SplineMeshComponent> (&CameraRig_Rail_ptr->PreviewRailMeshSegments);
            return PreviewRailMeshSegments_store;
        } }
        private ObjectArrayField<SplineMeshComponent> PreviewRailMeshSegments_store;

        ///<summary>Preview Rail Static Mesh</summary>
        public unsafe StaticMesh PreviewRailStaticMesh {
            get {return CameraRig_Rail_ptr->PreviewRailStaticMesh;}
            set {CameraRig_Rail_ptr->PreviewRailStaticMesh = value;}
        }
        ///<summary>Preview Mesh Mount</summary>
        public unsafe StaticMeshComponent PreviewMesh_Mount {
            get {return CameraRig_Rail_ptr->PreviewMesh_Mount;}
            set {CameraRig_Rail_ptr->PreviewMesh_Mount = value;}
        }
        static CameraRig_Rail() {
            StaticClass = Main.GetClass("CameraRig_Rail");
        }
        internal unsafe CameraRig_Rail_fields* CameraRig_Rail_ptr => (CameraRig_Rail_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator CameraRig_Rail(IntPtr p) => UObject.Make<CameraRig_Rail>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static CameraRig_Rail DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static CameraRig_Rail New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
