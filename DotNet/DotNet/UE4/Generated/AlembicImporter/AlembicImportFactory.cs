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
using UE4.AlembicImporter.Native;
using UE4.UnrealEd;
using UE4.AlembicLibrary;

namespace UE4.AlembicImporter {
    ///<summary>Alembic Import Factory</summary>
    public unsafe partial class AlembicImportFactory : Factory  {
        ///<summary>Object used to show import options for Alembic</summary>
        public unsafe AbcImportSettings ImportSettings {
            get {return AlembicImportFactory_ptr->ImportSettings;}
            set {AlembicImportFactory_ptr->ImportSettings = value;}
        }
        public bool bShowOption {
            get {return Main.GetGetBoolPropertyByName(this, "bShowOption"); }
            set {Main.SetGetBoolPropertyByName(this, "bShowOption", value); }
        }
        static AlembicImportFactory() {
            StaticClass = Main.GetClass("AlembicImportFactory");
        }
        internal unsafe AlembicImportFactory_fields* AlembicImportFactory_ptr => (AlembicImportFactory_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AlembicImportFactory(IntPtr p) => UObject.Make<AlembicImportFactory>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AlembicImportFactory DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AlembicImportFactory New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
