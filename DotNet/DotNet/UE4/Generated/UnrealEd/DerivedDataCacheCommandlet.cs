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
    ///<summary>Derived Data Cache Commandlet</summary>
    public unsafe partial class DerivedDataCacheCommandlet : Commandlet  {
        static DerivedDataCacheCommandlet() {
            StaticClass = Main.GetClass("DerivedDataCacheCommandlet");
        }
        internal unsafe DerivedDataCacheCommandlet_fields* DerivedDataCacheCommandlet_ptr => (DerivedDataCacheCommandlet_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator DerivedDataCacheCommandlet(IntPtr p) => UObject.Make<DerivedDataCacheCommandlet>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static DerivedDataCacheCommandlet DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static DerivedDataCacheCommandlet New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
