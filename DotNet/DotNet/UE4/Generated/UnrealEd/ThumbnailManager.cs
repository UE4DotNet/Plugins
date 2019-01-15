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
using UE4.UnrealEd.Native;
using UE4.Engine;

namespace UE4.UnrealEd {
    ///<summary>Thumbnail Manager</summary>
    public unsafe partial class ThumbnailManager : UObject  {
         //TODO: array not UObject TArray RenderableThumbnailTypes
        ///<summary>The render info to share across all object types when the object doesn't</summary>
        ///<remarks>support rendering of thumbnails</remarks>
        public unsafe ThumbnailRenderingInfo NotSupported {
            get {return ThumbnailManager_ptr->NotSupported;}
            set {ThumbnailManager_ptr->NotSupported = value;}
        }
        ///<summary>All these meshes/materials/textures are preloaded via default properties</summary>
        public unsafe StaticMesh EditorCube {
            get {return ThumbnailManager_ptr->EditorCube;}
            set {ThumbnailManager_ptr->EditorCube = value;}
        }
        ///<summary>Editor Sphere</summary>
        public unsafe StaticMesh EditorSphere {
            get {return ThumbnailManager_ptr->EditorSphere;}
            set {ThumbnailManager_ptr->EditorSphere = value;}
        }
        ///<summary>Editor Cylinder</summary>
        public unsafe StaticMesh EditorCylinder {
            get {return ThumbnailManager_ptr->EditorCylinder;}
            set {ThumbnailManager_ptr->EditorCylinder = value;}
        }
        ///<summary>Editor Plane</summary>
        public unsafe StaticMesh EditorPlane {
            get {return ThumbnailManager_ptr->EditorPlane;}
            set {ThumbnailManager_ptr->EditorPlane = value;}
        }
        ///<summary>Editor Sky Sphere</summary>
        public unsafe StaticMesh EditorSkySphere {
            get {return ThumbnailManager_ptr->EditorSkySphere;}
            set {ThumbnailManager_ptr->EditorSkySphere = value;}
        }
        ///<summary>Floor Plane Material</summary>
        public unsafe Material FloorPlaneMaterial {
            get {return ThumbnailManager_ptr->FloorPlaneMaterial;}
            set {ThumbnailManager_ptr->FloorPlaneMaterial = value;}
        }
        ///<summary>Ambient Cubemap</summary>
        public unsafe TextureCube AmbientCubemap {
            get {return ThumbnailManager_ptr->AmbientCubemap;}
            set {ThumbnailManager_ptr->AmbientCubemap = value;}
        }
        ///<summary>Checkerboard Texture</summary>
        public unsafe Texture2D CheckerboardTexture {
            get {return ThumbnailManager_ptr->CheckerboardTexture;}
            set {ThumbnailManager_ptr->CheckerboardTexture = value;}
        }
         //TODO: string FString ThumbnailManagerClassName
        static ThumbnailManager() {
            StaticClass = Main.GetClass("ThumbnailManager");
        }
        internal unsafe ThumbnailManager_fields* ThumbnailManager_ptr => (ThumbnailManager_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ThumbnailManager(IntPtr p) => UObject.Make<ThumbnailManager>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ThumbnailManager DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ThumbnailManager New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
