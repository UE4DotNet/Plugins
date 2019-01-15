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
    ///<summary>Commandlet for generating a filtered list of assets from the asset registry (intended use is for replacing assets with cooked version)</summary>
    public unsafe partial class GenerateAssetManifestCommandlet : Commandlet  {
        static GenerateAssetManifestCommandlet() {
            StaticClass = Main.GetClass("GenerateAssetManifestCommandlet");
        }
        internal unsafe GenerateAssetManifestCommandlet_fields* GenerateAssetManifestCommandlet_ptr => (GenerateAssetManifestCommandlet_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator GenerateAssetManifestCommandlet(IntPtr p) => UObject.Make<GenerateAssetManifestCommandlet>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static GenerateAssetManifestCommandlet DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static GenerateAssetManifestCommandlet New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
