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
    ///<summary>Package Tools</summary>
    public unsafe partial class PackageTools : UObject  {

        ///<summary>Replaces all invalid package name characters with _</summary>
        public static string SanitizePackageName(string InPackageName)  => 
            PackageTools_methods.SanitizePackageName_method.Invoke(InPackageName);
        static PackageTools() {
            StaticClass = Main.GetClass("PackageTools");
        }
        internal unsafe PackageTools_fields* PackageTools_ptr => (PackageTools_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PackageTools(IntPtr p) => UObject.Make<PackageTools>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PackageTools DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PackageTools New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
