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
using UE4.AlembicLibrary.Native;
using UE4.Engine;

namespace UE4.AlembicLibrary {
    ///<summary>Base class for import data and options used when importing any asset from Alembic</summary>
    public unsafe partial class AbcAssetImportData : AssetImportData  {
         //TODO: array not UObject TArray TrackNames
        ///<summary>Sampling Settings</summary>
        public unsafe AbcSamplingSettings SamplingSettings {
            get {return AbcAssetImportData_ptr->SamplingSettings;}
            set {AbcAssetImportData_ptr->SamplingSettings = value;}
        }
        static AbcAssetImportData() {
            StaticClass = Main.GetClass("AbcAssetImportData");
        }
        internal unsafe AbcAssetImportData_fields* AbcAssetImportData_ptr => (AbcAssetImportData_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AbcAssetImportData(IntPtr p) => UObject.Make<AbcAssetImportData>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AbcAssetImportData DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AbcAssetImportData New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
