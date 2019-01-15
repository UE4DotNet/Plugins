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
    ///<summary>Import data and options specific to tessellated Datasmith scenes</summary>
    public unsafe partial class DatasmithCADImportSceneData : DatasmithSceneImportData  {
        ///<summary>Tessellation Options</summary>
        public unsafe DatasmithTessellationOptions TessellationOptions {
            get {return DatasmithCADImportSceneData_ptr->TessellationOptions;}
            set {DatasmithCADImportSceneData_ptr->TessellationOptions = value;}
        }
        static DatasmithCADImportSceneData() {
            StaticClass = Main.GetClass("DatasmithCADImportSceneData");
        }
        internal unsafe DatasmithCADImportSceneData_fields* DatasmithCADImportSceneData_ptr => (DatasmithCADImportSceneData_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator DatasmithCADImportSceneData(IntPtr p) => UObject.Make<DatasmithCADImportSceneData>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static DatasmithCADImportSceneData DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static DatasmithCADImportSceneData New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
