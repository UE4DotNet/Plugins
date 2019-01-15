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

namespace UE4.DatasmithContent {
    ///<summary>Datasmith Static Mesh Import Data</summary>
    public unsafe partial class DatasmithStaticMeshImportData : DatasmithAssetImportData  {
        ///<summary>Import Options</summary>
        public unsafe DatasmithStaticMeshImportOptions ImportOptions {
            get {return DatasmithStaticMeshImportData_ptr->ImportOptions;}
            set {DatasmithStaticMeshImportData_ptr->ImportOptions = value;}
        }
        static DatasmithStaticMeshImportData() {
            StaticClass = Main.GetClass("DatasmithStaticMeshImportData");
        }
        internal unsafe DatasmithStaticMeshImportData_fields* DatasmithStaticMeshImportData_ptr => (DatasmithStaticMeshImportData_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator DatasmithStaticMeshImportData(IntPtr p) => UObject.Make<DatasmithStaticMeshImportData>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static DatasmithStaticMeshImportData DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static DatasmithStaticMeshImportData New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
