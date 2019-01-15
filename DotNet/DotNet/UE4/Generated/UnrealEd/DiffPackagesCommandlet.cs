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
    ///<summary>Diff Packages Commandlet</summary>
    public unsafe partial class DiffPackagesCommandlet : Commandlet  {
        ///<summary>Packages</summary>
        public unsafe Package Packages {
            get {return DiffPackagesCommandlet_ptr->Packages;}
            set {DiffPackagesCommandlet_ptr->Packages = value;}
        }
        static DiffPackagesCommandlet() {
            StaticClass = Main.GetClass("DiffPackagesCommandlet");
        }
        internal unsafe DiffPackagesCommandlet_fields* DiffPackagesCommandlet_ptr => (DiffPackagesCommandlet_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator DiffPackagesCommandlet(IntPtr p) => UObject.Make<DiffPackagesCommandlet>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static DiffPackagesCommandlet DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static DiffPackagesCommandlet New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
