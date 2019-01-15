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
using UE4.SpeedTreeImporter.Native;
using UE4.UnrealEd;

namespace UE4.SpeedTreeImporter {
    ///<summary>Speed Tree Import Factory</summary>
    public unsafe partial class SpeedTreeImportFactory : Factory  {
        static SpeedTreeImportFactory() {
            StaticClass = Main.GetClass("SpeedTreeImportFactory");
        }
        internal unsafe SpeedTreeImportFactory_fields* SpeedTreeImportFactory_ptr => (SpeedTreeImportFactory_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SpeedTreeImportFactory(IntPtr p) => UObject.Make<SpeedTreeImportFactory>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SpeedTreeImportFactory DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SpeedTreeImportFactory New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
