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
    ///<summary>Datasmith Static Mesh CADImport Data</summary>
    public unsafe partial class DatasmithStaticMeshCADImportData : DatasmithStaticMeshImportData  {
        ///<summary>Tessellation Options</summary>
        public unsafe DatasmithTessellationOptions TessellationOptions {
            get {return DatasmithStaticMeshCADImportData_ptr->TessellationOptions;}
            set {DatasmithStaticMeshCADImportData_ptr->TessellationOptions = value;}
        }
        ///<summary>Model Unit</summary>
        public unsafe double ModelUnit {
            get {return DatasmithStaticMeshCADImportData_ptr->ModelUnit;}
            set {DatasmithStaticMeshCADImportData_ptr->ModelUnit = value;}
        }
        ///<summary>Model Tolerance</summary>
        public unsafe double ModelTolerance {
            get {return DatasmithStaticMeshCADImportData_ptr->ModelTolerance;}
            set {DatasmithStaticMeshCADImportData_ptr->ModelTolerance = value;}
        }
         //TODO: string FString ResourcePath
         //TODO: string FString ResourceFilename
         //TODO: array not UObject TArray AuxiliaryFilenames
        static DatasmithStaticMeshCADImportData() {
            StaticClass = Main.GetClass("DatasmithStaticMeshCADImportData");
        }
        internal unsafe DatasmithStaticMeshCADImportData_fields* DatasmithStaticMeshCADImportData_ptr => (DatasmithStaticMeshCADImportData_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator DatasmithStaticMeshCADImportData(IntPtr p) => UObject.Make<DatasmithStaticMeshCADImportData>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static DatasmithStaticMeshCADImportData DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static DatasmithStaticMeshCADImportData New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
