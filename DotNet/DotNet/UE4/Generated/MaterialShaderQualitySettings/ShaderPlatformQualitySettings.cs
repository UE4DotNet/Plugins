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
using UE4.MaterialShaderQualitySettings.Native;

namespace UE4.MaterialShaderQualitySettings {
    ///<summary>Shader Platform Quality Settings</summary>
    public unsafe partial class ShaderPlatformQualitySettings : UObject  {
        ///<summary>Quality Overrides</summary>
        public unsafe MaterialQualityOverrides QualityOverrides {
            get {return ShaderPlatformQualitySettings_ptr->QualityOverrides;}
            set {ShaderPlatformQualitySettings_ptr->QualityOverrides = value;}
        }
        static ShaderPlatformQualitySettings() {
            StaticClass = Main.GetClass("ShaderPlatformQualitySettings");
        }
        internal unsafe ShaderPlatformQualitySettings_fields* ShaderPlatformQualitySettings_ptr => (ShaderPlatformQualitySettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ShaderPlatformQualitySettings(IntPtr p) => UObject.Make<ShaderPlatformQualitySettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ShaderPlatformQualitySettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ShaderPlatformQualitySettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
