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
using UE4.AlembicLibrary.Native;

namespace UE4.AlembicLibrary {
    ///<summary>Class that contains all options for importing an alembic file</summary>
    public unsafe partial class AbcImportSettings : UObject  {
         //TODO: enum EAlembicImportType ImportType
        ///<summary>Sampling Settings</summary>
        public unsafe AbcSamplingSettings SamplingSettings {
            get {return AbcImportSettings_ptr->SamplingSettings;}
            set {AbcImportSettings_ptr->SamplingSettings = value;}
        }
        ///<summary>Normal Generation Settings</summary>
        public unsafe AbcNormalGenerationSettings NormalGenerationSettings {
            get {return AbcImportSettings_ptr->NormalGenerationSettings;}
            set {AbcImportSettings_ptr->NormalGenerationSettings = value;}
        }
        ///<summary>Material Settings</summary>
        public unsafe AbcMaterialSettings MaterialSettings {
            get {return AbcImportSettings_ptr->MaterialSettings;}
            set {AbcImportSettings_ptr->MaterialSettings = value;}
        }
        ///<summary>Compression Settings</summary>
        public unsafe AbcCompressionSettings CompressionSettings {
            get {return AbcImportSettings_ptr->CompressionSettings;}
            set {AbcImportSettings_ptr->CompressionSettings = value;}
        }
        ///<summary>Static Mesh Settings</summary>
        public unsafe AbcStaticMeshSettings StaticMeshSettings {
            get {return AbcImportSettings_ptr->StaticMeshSettings;}
            set {AbcImportSettings_ptr->StaticMeshSettings = value;}
        }
        ///<summary>Geometry Cache Settings</summary>
        public unsafe AbcGeometryCacheSettings GeometryCacheSettings {
            get {return AbcImportSettings_ptr->GeometryCacheSettings;}
            set {AbcImportSettings_ptr->GeometryCacheSettings = value;}
        }
        ///<summary>Conversion Settings</summary>
        public unsafe AbcConversionSettings ConversionSettings {
            get {return AbcImportSettings_ptr->ConversionSettings;}
            set {AbcImportSettings_ptr->ConversionSettings = value;}
        }
        static AbcImportSettings() {
            StaticClass = Main.GetClass("AbcImportSettings");
        }
        internal unsafe AbcImportSettings_fields* AbcImportSettings_ptr => (AbcImportSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AbcImportSettings(IntPtr p) => UObject.Make<AbcImportSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AbcImportSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AbcImportSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
