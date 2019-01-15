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
    ///<summary>Interface Asset User Data</summary>
    public unsafe partial class Interface_AssetUserData : Interface  {
        static Interface_AssetUserData() {
            StaticClass = Main.GetClass("Interface_AssetUserData");
        }
        internal unsafe Interface_AssetUserData_fields* Interface_AssetUserData_ptr => (Interface_AssetUserData_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator Interface_AssetUserData(IntPtr p) => UObject.Make<Interface_AssetUserData>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static Interface_AssetUserData DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static Interface_AssetUserData New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
