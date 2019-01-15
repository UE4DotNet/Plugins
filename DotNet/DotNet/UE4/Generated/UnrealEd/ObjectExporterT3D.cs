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
using UE4.Engine;

namespace UE4.UnrealEd {
    ///<summary>Object Exporter T3D</summary>
    public unsafe partial class ObjectExporterT3D : Exporter  {
        static ObjectExporterT3D() {
            StaticClass = Main.GetClass("ObjectExporterT3D");
        }
        internal unsafe ObjectExporterT3D_fields* ObjectExporterT3D_ptr => (ObjectExporterT3D_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ObjectExporterT3D(IntPtr p) => UObject.Make<ObjectExporterT3D>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ObjectExporterT3D DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ObjectExporterT3D New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
