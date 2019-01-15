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
using UE4.AssetRegistry.Native;

namespace UE4.AssetRegistry {
    ///<summary>Asset Registry Impl</summary>
    public unsafe partial class AssetRegistryImpl : UObject  {
        static AssetRegistryImpl() {
            StaticClass = Main.GetClass("AssetRegistryImpl");
        }
        internal unsafe AssetRegistryImpl_fields* AssetRegistryImpl_ptr => (AssetRegistryImpl_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AssetRegistryImpl(IntPtr p) => UObject.Make<AssetRegistryImpl>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AssetRegistryImpl DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AssetRegistryImpl New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
