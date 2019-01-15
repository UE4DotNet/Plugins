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
using UE4.NetcodeUnitTest.Native;
using UE4.Engine;

namespace UE4.NetcodeUnitTest {
    ///<summary>Package map override, for blocking the creation of actor channels for specific actors (by detecting the actor class being created)</summary>
    public unsafe partial class UnitTestPackageMap : PackageMapClient  {
        static UnitTestPackageMap() {
            StaticClass = Main.GetClass("UnitTestPackageMap");
        }
        internal unsafe UnitTestPackageMap_fields* UnitTestPackageMap_ptr => (UnitTestPackageMap_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator UnitTestPackageMap(IntPtr p) => UObject.Make<UnitTestPackageMap>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static UnitTestPackageMap DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static UnitTestPackageMap New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
