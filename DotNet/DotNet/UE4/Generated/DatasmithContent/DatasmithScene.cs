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
    ///<summary>Datasmith Scene</summary>
    public unsafe partial class DatasmithScene : UObject  {
        ///<summary>Importing data and options used for this Datasmith scene</summary>
        public unsafe DatasmithSceneImportData AssetImportData {
            get {return DatasmithScene_ptr->AssetImportData;}
            set {DatasmithScene_ptr->AssetImportData = value;}
        }
        ///<summary>Bulk Data Version</summary>
        public unsafe int BulkDataVersion {
            get {return DatasmithScene_ptr->BulkDataVersion;}
            set {DatasmithScene_ptr->BulkDataVersion = value;}
        }
        static DatasmithScene() {
            StaticClass = Main.GetClass("DatasmithScene");
        }
        internal unsafe DatasmithScene_fields* DatasmithScene_ptr => (DatasmithScene_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator DatasmithScene(IntPtr p) => UObject.Make<DatasmithScene>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static DatasmithScene DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static DatasmithScene New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
