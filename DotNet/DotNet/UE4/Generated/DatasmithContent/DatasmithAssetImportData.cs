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
using UE4.DatasmithContent.Native;
using UE4.Engine;

namespace UE4.DatasmithContent {
    ///<summary>Datasmith Asset Import Data</summary>
    public unsafe partial class DatasmithAssetImportData : AssetImportData  {
        ///<summary>Asset Import Options</summary>
        public unsafe DatasmithAssetImportOptions AssetImportOptions {
            get {return DatasmithAssetImportData_ptr->AssetImportOptions;}
            set {DatasmithAssetImportData_ptr->AssetImportOptions = value;}
        }
        static DatasmithAssetImportData() {
            StaticClass = Main.GetClass("DatasmithAssetImportData");
        }
        internal unsafe DatasmithAssetImportData_fields* DatasmithAssetImportData_ptr => (DatasmithAssetImportData_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator DatasmithAssetImportData(IntPtr p) => UObject.Make<DatasmithAssetImportData>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static DatasmithAssetImportData DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static DatasmithAssetImportData New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
