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
    ///<summary>todo: Make this class better suited to multiple import paths - maybe have FAssetImportInfo use a map rather than array?</summary>
    public unsafe partial class AssetImportData : UObject  {

        ///<summary>K2 Extract Filenames</summary>
        public IReadOnlyCollection<string> K2_ExtractFilenames()  => 
            AssetImportData_methods.K2_ExtractFilenames_method.Invoke(ObjPointer);

        ///<summary>K2 Get First Filename</summary>
        public string K2_GetFirstFilename()  => 
            AssetImportData_methods.K2_GetFirstFilename_method.Invoke(ObjPointer);
        ///<summary>Source file data describing the files that were used to import this asset.</summary>
        public unsafe AssetImportInfo SourceData {
            get {return AssetImportData_ptr->SourceData;}
            set {AssetImportData_ptr->SourceData = value;}
        }
        static AssetImportData() {
            StaticClass = Main.GetClass("AssetImportData");
        }
        internal unsafe AssetImportData_fields* AssetImportData_ptr => (AssetImportData_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AssetImportData(IntPtr p) => UObject.Make<AssetImportData>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AssetImportData DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AssetImportData New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
