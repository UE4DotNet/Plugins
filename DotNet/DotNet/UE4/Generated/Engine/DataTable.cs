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
using UE4.Engine.Native;

namespace UE4.Engine {
    ///<summary>Imported spreadsheet table.</summary>
    public unsafe partial class DataTable : UObject  {
        ///<summary>Structure to use for each row of the table, must inherit from FTableRowBase</summary>
        public unsafe ScriptStruct RowStruct {
            get {return DataTable_ptr->RowStruct;}
            set {DataTable_ptr->RowStruct = value;}
        }
        public bool bStripFromClientBuilds {
            get {return Main.GetGetBoolPropertyByName(this, "bStripFromClientBuilds"); }
            set {Main.SetGetBoolPropertyByName(this, "bStripFromClientBuilds", value); }
        }
        ///<summary>Asset Import Data</summary>
        public unsafe AssetImportData AssetImportData {
            get {return DataTable_ptr->AssetImportData;}
            set {DataTable_ptr->AssetImportData = value;}
        }
        ///<summary>The name of the RowStruct we were using when we were last saved</summary>
        public unsafe Name RowStructName {
            get {return DataTable_ptr->RowStructName;}
            set {DataTable_ptr->RowStructName = value;}
        }
         //TODO: array not UObject TArray RowsSerializedWithTags
         //TODO: set TSet TemporarilyReferencedObjects
        static DataTable() {
            StaticClass = Main.GetClass("DataTable");
        }
        internal unsafe DataTable_fields* DataTable_ptr => (DataTable_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator DataTable(IntPtr p) => UObject.Make<DataTable>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static DataTable DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static DataTable New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
