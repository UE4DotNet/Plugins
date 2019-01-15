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
    ///<summary>Base class for import data and options used when importing any asset from Datasmith</summary>
    public unsafe partial class DatasmithSceneImportData : AssetImportData  {
        ///<summary>Base Options</summary>
        public unsafe DatasmithImportBaseOptions BaseOptions {
            get {return DatasmithSceneImportData_ptr->BaseOptions;}
            set {DatasmithSceneImportData_ptr->BaseOptions = value;}
        }
        static DatasmithSceneImportData() {
            StaticClass = Main.GetClass("DatasmithSceneImportData");
        }
        internal unsafe DatasmithSceneImportData_fields* DatasmithSceneImportData_ptr => (DatasmithSceneImportData_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator DatasmithSceneImportData(IntPtr p) => UObject.Make<DatasmithSceneImportData>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static DatasmithSceneImportData DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static DatasmithSceneImportData New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
