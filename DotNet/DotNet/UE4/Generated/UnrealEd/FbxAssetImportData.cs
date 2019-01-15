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
    ///<summary>Base class for import data and options used when importing any asset from FBX</summary>
    public unsafe partial class FbxAssetImportData : AssetImportData  {
        ///<summary>Import Translation</summary>
        public unsafe Vector ImportTranslation {
            get {return FbxAssetImportData_ptr->ImportTranslation;}
            set {FbxAssetImportData_ptr->ImportTranslation = value;}
        }
        ///<summary>Import Rotation</summary>
        public unsafe Rotator ImportRotation {
            get {return FbxAssetImportData_ptr->ImportRotation;}
            set {FbxAssetImportData_ptr->ImportRotation = value;}
        }
        ///<summary>Import Uniform Scale</summary>
        public unsafe float ImportUniformScale {
            get {return FbxAssetImportData_ptr->ImportUniformScale;}
            set {FbxAssetImportData_ptr->ImportUniformScale = value;}
        }
        public bool bConvertScene {
            get {return Main.GetGetBoolPropertyByName(this, "bConvertScene"); }
            set {Main.SetGetBoolPropertyByName(this, "bConvertScene", value); }
        }
        public bool bForceFrontXAxis {
            get {return Main.GetGetBoolPropertyByName(this, "bForceFrontXAxis"); }
            set {Main.SetGetBoolPropertyByName(this, "bForceFrontXAxis", value); }
        }
        public bool bConvertSceneUnit {
            get {return Main.GetGetBoolPropertyByName(this, "bConvertSceneUnit"); }
            set {Main.SetGetBoolPropertyByName(this, "bConvertSceneUnit", value); }
        }
        public bool bImportAsScene {
            get {return Main.GetGetBoolPropertyByName(this, "bImportAsScene"); }
            set {Main.SetGetBoolPropertyByName(this, "bImportAsScene", value); }
        }
        ///<summary>Use by the reimport factory to answer CanReimport, if true only factory for scene reimport will return true</summary>
        public unsafe FbxSceneImportData FbxSceneImportDataReference {
            get {return FbxAssetImportData_ptr->FbxSceneImportDataReference;}
            set {FbxAssetImportData_ptr->FbxSceneImportDataReference = value;}
        }
        static FbxAssetImportData() {
            StaticClass = Main.GetClass("FbxAssetImportData");
        }
        internal unsafe FbxAssetImportData_fields* FbxAssetImportData_ptr => (FbxAssetImportData_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator FbxAssetImportData(IntPtr p) => UObject.Make<FbxAssetImportData>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static FbxAssetImportData DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static FbxAssetImportData New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
