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
    ///<summary>Resave Packages Commandlet</summary>
    public unsafe partial class ResavePackagesCommandlet : Commandlet  {
        static ResavePackagesCommandlet() {
            StaticClass = Main.GetClass("ResavePackagesCommandlet");
        }
        internal unsafe ResavePackagesCommandlet_fields* ResavePackagesCommandlet_ptr => (ResavePackagesCommandlet_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ResavePackagesCommandlet(IntPtr p) => UObject.Make<ResavePackagesCommandlet>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ResavePackagesCommandlet DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ResavePackagesCommandlet New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
