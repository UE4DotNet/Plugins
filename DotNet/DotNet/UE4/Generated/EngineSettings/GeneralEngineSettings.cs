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
using UE4.EngineSettings.Native;

namespace UE4.EngineSettings {
    ///<summary>General Engine Settings</summary>
    public unsafe partial class GeneralEngineSettings : UObject  {
        static GeneralEngineSettings() {
            StaticClass = Main.GetClass("GeneralEngineSettings");
        }
        internal unsafe GeneralEngineSettings_fields* GeneralEngineSettings_ptr => (GeneralEngineSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator GeneralEngineSettings(IntPtr p) => UObject.Make<GeneralEngineSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static GeneralEngineSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static GeneralEngineSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
