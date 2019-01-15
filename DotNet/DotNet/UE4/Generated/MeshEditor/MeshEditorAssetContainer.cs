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
using UE4.MeshEditor.Native;
using UE4.Engine;

namespace UE4.MeshEditor {
    ///<summary>Asset container for the mesh editor</summary>
    public unsafe partial class MeshEditorAssetContainer : DataAsset  {
        ///<summary>Hovered Geometry Material</summary>
        public unsafe MaterialInterface HoveredGeometryMaterial {
            get {return MeshEditorAssetContainer_ptr->HoveredGeometryMaterial;}
            set {MeshEditorAssetContainer_ptr->HoveredGeometryMaterial = value;}
        }
        ///<summary>Hovered Face Material</summary>
        public unsafe MaterialInterface HoveredFaceMaterial {
            get {return MeshEditorAssetContainer_ptr->HoveredFaceMaterial;}
            set {MeshEditorAssetContainer_ptr->HoveredFaceMaterial = value;}
        }
        ///<summary>Wire Material</summary>
        public unsafe MaterialInterface WireMaterial {
            get {return MeshEditorAssetContainer_ptr->WireMaterial;}
            set {MeshEditorAssetContainer_ptr->WireMaterial = value;}
        }
        ///<summary>Subdivided Mesh Wire Material</summary>
        public unsafe MaterialInterface SubdividedMeshWireMaterial {
            get {return MeshEditorAssetContainer_ptr->SubdividedMeshWireMaterial;}
            set {MeshEditorAssetContainer_ptr->SubdividedMeshWireMaterial = value;}
        }
        ///<summary>Overlay Line Material</summary>
        public unsafe MaterialInterface OverlayLineMaterial {
            get {return MeshEditorAssetContainer_ptr->OverlayLineMaterial;}
            set {MeshEditorAssetContainer_ptr->OverlayLineMaterial = value;}
        }
        ///<summary>Overlay Point Material</summary>
        public unsafe MaterialInterface OverlayPointMaterial {
            get {return MeshEditorAssetContainer_ptr->OverlayPointMaterial;}
            set {MeshEditorAssetContainer_ptr->OverlayPointMaterial = value;}
        }
        ///<summary>Default Sound</summary>
        public unsafe SoundBase DefaultSound {
            get {return MeshEditorAssetContainer_ptr->DefaultSound;}
            set {MeshEditorAssetContainer_ptr->DefaultSound = value;}
        }
        static MeshEditorAssetContainer() {
            StaticClass = Main.GetClass("MeshEditorAssetContainer");
        }
        internal unsafe MeshEditorAssetContainer_fields* MeshEditorAssetContainer_ptr => (MeshEditorAssetContainer_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MeshEditorAssetContainer(IntPtr p) => UObject.Make<MeshEditorAssetContainer>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MeshEditorAssetContainer DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MeshEditorAssetContainer New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
