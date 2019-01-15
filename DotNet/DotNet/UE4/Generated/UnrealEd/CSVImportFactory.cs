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

namespace UE4.UnrealEd {
    ///<summary>CSVImport Factory</summary>
    public unsafe partial class CSVImportFactory : Factory  {
        ///<summary>Automated Import Settings</summary>
        public unsafe CSVImportSettings AutomatedImportSettings {
            get {return CSVImportFactory_ptr->AutomatedImportSettings;}
            set {CSVImportFactory_ptr->AutomatedImportSettings = value;}
        }
        static CSVImportFactory() {
            StaticClass = Main.GetClass("CSVImportFactory");
        }
        internal unsafe CSVImportFactory_fields* CSVImportFactory_ptr => (CSVImportFactory_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator CSVImportFactory(IntPtr p) => UObject.Make<CSVImportFactory>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static CSVImportFactory DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static CSVImportFactory New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
