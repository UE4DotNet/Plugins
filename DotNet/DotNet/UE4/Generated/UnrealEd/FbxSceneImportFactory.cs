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

namespace UE4.UnrealEd {
    ///<summary>Fbx Scene Import Factory</summary>
    public unsafe partial class FbxSceneImportFactory : SceneImportFactory  {
        ///<summary>Import options UI detail when importing fbx scene</summary>
        public unsafe FbxSceneImportOptions SceneImportOptions {
            get {return FbxSceneImportFactory_ptr->SceneImportOptions;}
            set {FbxSceneImportFactory_ptr->SceneImportOptions = value;}
        }
        ///<summary>Import options UI detail when importing fbx scene static mesh</summary>
        public unsafe FbxSceneImportOptionsStaticMesh SceneImportOptionsStaticMesh {
            get {return FbxSceneImportFactory_ptr->SceneImportOptionsStaticMesh;}
            set {FbxSceneImportFactory_ptr->SceneImportOptionsStaticMesh = value;}
        }
        ///<summary>Import options UI detail when importing fbx scene skeletal mesh</summary>
        public unsafe FbxSceneImportOptionsSkeletalMesh SceneImportOptionsSkeletalMesh {
            get {return FbxSceneImportFactory_ptr->SceneImportOptionsSkeletalMesh;}
            set {FbxSceneImportFactory_ptr->SceneImportOptionsSkeletalMesh = value;}
        }
        ///<summary>Import data used when importing static meshes</summary>
        public unsafe FbxStaticMeshImportData StaticMeshImportData {
            get {return FbxSceneImportFactory_ptr->StaticMeshImportData;}
            set {FbxSceneImportFactory_ptr->StaticMeshImportData = value;}
        }
        ///<summary>Import data used when importing skeletal meshes</summary>
        public unsafe FbxSkeletalMeshImportData SkeletalMeshImportData {
            get {return FbxSceneImportFactory_ptr->SkeletalMeshImportData;}
            set {FbxSceneImportFactory_ptr->SkeletalMeshImportData = value;}
        }
        ///<summary>Import data used when importing animations</summary>
        public unsafe FbxAnimSequenceImportData AnimSequenceImportData {
            get {return FbxSceneImportFactory_ptr->AnimSequenceImportData;}
            set {FbxSceneImportFactory_ptr->AnimSequenceImportData = value;}
        }
        ///<summary>Import data used when importing textures</summary>
        public unsafe FbxTextureImportData TextureImportData {
            get {return FbxSceneImportFactory_ptr->TextureImportData;}
            set {FbxSceneImportFactory_ptr->TextureImportData = value;}
        }
        ///<summary>Pointer on the fbx scene import data, we fill this object to be able to do re import of the scene</summary>
        public unsafe FbxSceneImportData ReimportData {
            get {return FbxSceneImportFactory_ptr->ReimportData;}
            set {FbxSceneImportFactory_ptr->ReimportData = value;}
        }
        static FbxSceneImportFactory() {
            StaticClass = Main.GetClass("FbxSceneImportFactory");
        }
        internal unsafe FbxSceneImportFactory_fields* FbxSceneImportFactory_ptr => (FbxSceneImportFactory_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator FbxSceneImportFactory(IntPtr p) => UObject.Make<FbxSceneImportFactory>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static FbxSceneImportFactory DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static FbxSceneImportFactory New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
