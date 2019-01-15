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
    ///<summary>Import data and options used when importing any mesh from FBX</summary>
    public unsafe partial class FbxTextureImportData : FbxAssetImportData  {
        public bool bInvertNormalMaps {
            get {return Main.GetGetBoolPropertyByName(this, "bInvertNormalMaps"); }
            set {Main.SetGetBoolPropertyByName(this, "bInvertNormalMaps", value); }
        }
         //TODO: enum EMaterialSearchLocation MaterialSearchLocation
        ///<summary>Base material to instance from when importing materials.</summary>
        public unsafe SoftObjectPath BaseMaterialName {
            get {return FbxTextureImportData_ptr->BaseMaterialName;}
            set {FbxTextureImportData_ptr->BaseMaterialName = value;}
        }
         //TODO: string FString BaseColorName
         //TODO: string FString BaseDiffuseTextureName
         //TODO: string FString BaseNormalTextureName
         //TODO: string FString BaseEmissiveColorName
         //TODO: string FString BaseEmmisiveTextureName
         //TODO: string FString BaseSpecularTextureName
        static FbxTextureImportData() {
            StaticClass = Main.GetClass("FbxTextureImportData");
        }
        internal unsafe FbxTextureImportData_fields* FbxTextureImportData_ptr => (FbxTextureImportData_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator FbxTextureImportData(IntPtr p) => UObject.Make<FbxTextureImportData>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static FbxTextureImportData DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static FbxTextureImportData New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
