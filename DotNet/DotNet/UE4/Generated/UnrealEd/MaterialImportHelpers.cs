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
    ///<summary>Material Import Helpers</summary>
    public unsafe partial class MaterialImportHelpers : UObject  {

        ///<summary>Find Existing Material</summary>
        public static (byte /*TODO: text FText*/, MaterialInterface) FindExistingMaterial(string BasePath, string MaterialFullName, bool bRecursivePaths)  => 
            MaterialImportHelpers_methods.FindExistingMaterial_method.Invoke(BasePath, MaterialFullName, bRecursivePaths);

        ///<summary>Find Existing Material from Search Location</summary>
        public static (byte /*TODO: text FText*/, MaterialInterface) FindExistingMaterialFromSearchLocation(string MaterialFullName, string BasePackagePath, EMaterialSearchLocation SearchLocation)  => 
            MaterialImportHelpers_methods.FindExistingMaterialFromSearchLocation_method.Invoke(MaterialFullName, BasePackagePath, SearchLocation);
        static MaterialImportHelpers() {
            StaticClass = Main.GetClass("MaterialImportHelpers");
        }
        internal unsafe MaterialImportHelpers_fields* MaterialImportHelpers_ptr => (MaterialImportHelpers_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MaterialImportHelpers(IntPtr p) => UObject.Make<MaterialImportHelpers>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MaterialImportHelpers DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MaterialImportHelpers New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
