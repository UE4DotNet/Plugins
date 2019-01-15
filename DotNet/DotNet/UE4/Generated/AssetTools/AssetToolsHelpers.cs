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
using UE4.AssetTools.Native;

namespace UE4.AssetTools {
    ///<summary>Asset Tools Helpers</summary>
    public unsafe partial class AssetToolsHelpers : UObject  {

        ///<summary>Get Asset Tools</summary>
        public static AssetTools GetAssetTools()  => 
            AssetToolsHelpers_methods.GetAssetTools_method.Invoke();
        static AssetToolsHelpers() {
            StaticClass = Main.GetClass("AssetToolsHelpers");
        }
        internal unsafe AssetToolsHelpers_fields* AssetToolsHelpers_ptr => (AssetToolsHelpers_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AssetToolsHelpers(IntPtr p) => UObject.Make<AssetToolsHelpers>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AssetToolsHelpers DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AssetToolsHelpers New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
