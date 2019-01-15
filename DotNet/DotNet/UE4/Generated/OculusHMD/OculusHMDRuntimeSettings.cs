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
using UE4.OculusHMD.Native;

namespace UE4.OculusHMD {
    ///<summary>Implements the settings for the OculusVR plugin.</summary>
    public unsafe partial class OculusHMDRuntimeSettings : UObject  {
        public bool bAutoEnabled {
            get {return Main.GetGetBoolPropertyByName(this, "bAutoEnabled"); }
            set {Main.SetGetBoolPropertyByName(this, "bAutoEnabled", value); }
        }
         //TODO: array not UObject TArray SplashDescs
        static OculusHMDRuntimeSettings() {
            StaticClass = Main.GetClass("OculusHMDRuntimeSettings");
        }
        internal unsafe OculusHMDRuntimeSettings_fields* OculusHMDRuntimeSettings_ptr => (OculusHMDRuntimeSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator OculusHMDRuntimeSettings(IntPtr p) => UObject.Make<OculusHMDRuntimeSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static OculusHMDRuntimeSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static OculusHMDRuntimeSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
