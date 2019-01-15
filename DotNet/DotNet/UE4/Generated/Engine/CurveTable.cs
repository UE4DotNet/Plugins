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
    ///<summary>Imported spreadsheet table as curves.</summary>
    public unsafe partial class CurveTable : UObject  {
        ///<summary>Asset Import Data</summary>
        public unsafe AssetImportData AssetImportData {
            get {return CurveTable_ptr->AssetImportData;}
            set {CurveTable_ptr->AssetImportData = value;}
        }
        static CurveTable() {
            StaticClass = Main.GetClass("CurveTable");
        }
        internal unsafe CurveTable_fields* CurveTable_ptr => (CurveTable_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator CurveTable(IntPtr p) => UObject.Make<CurveTable>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static CurveTable DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static CurveTable New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
