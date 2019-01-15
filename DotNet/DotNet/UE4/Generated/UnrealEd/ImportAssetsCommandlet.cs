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
    ///<summary>Import Assets Commandlet</summary>
    public unsafe partial class ImportAssetsCommandlet : Commandlet  {
        ///<summary>Settings used when an import settings file is not used</summary>
        ///<remarks>or as a base to fallback on if settings are not overridden by the file</remarks>
        public unsafe AutomatedAssetImportData GlobalImportData {
            get {return ImportAssetsCommandlet_ptr->GlobalImportData;}
            set {ImportAssetsCommandlet_ptr->GlobalImportData = value;}
        }
        ///<summary>List of import data to import.  Each element in the list represents a list of assets using the same import settings</summary>
        public ObjectArrayField<AutomatedAssetImportData> ImportDataList{ get {
            if(ImportDataList_store == null) ImportDataList_store = new ObjectArrayField<AutomatedAssetImportData> (&ImportAssetsCommandlet_ptr->ImportDataList);
            return ImportDataList_store;
        } }
        private ObjectArrayField<AutomatedAssetImportData> ImportDataList_store;

        static ImportAssetsCommandlet() {
            StaticClass = Main.GetClass("ImportAssetsCommandlet");
        }
        internal unsafe ImportAssetsCommandlet_fields* ImportAssetsCommandlet_ptr => (ImportAssetsCommandlet_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ImportAssetsCommandlet(IntPtr p) => UObject.Make<ImportAssetsCommandlet>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ImportAssetsCommandlet DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ImportAssetsCommandlet New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
