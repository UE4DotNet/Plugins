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
using UE4.WmfMediaFactory.Native;

namespace UE4.WmfMediaFactory {
    ///<summary>Settings for the WmfMedia plug-in.</summary>
    public unsafe partial class WmfMediaSettings : UObject  {
        public bool AllowNonStandardCodecs {
            get {return Main.GetGetBoolPropertyByName(this, "AllowNonStandardCodecs"); }
            set {Main.SetGetBoolPropertyByName(this, "AllowNonStandardCodecs", value); }
        }
        public bool LowLatency {
            get {return Main.GetGetBoolPropertyByName(this, "LowLatency"); }
            set {Main.SetGetBoolPropertyByName(this, "LowLatency", value); }
        }
        public bool NativeAudioOut {
            get {return Main.GetGetBoolPropertyByName(this, "NativeAudioOut"); }
            set {Main.SetGetBoolPropertyByName(this, "NativeAudioOut", value); }
        }
        static WmfMediaSettings() {
            StaticClass = Main.GetClass("WmfMediaSettings");
        }
        internal unsafe WmfMediaSettings_fields* WmfMediaSettings_ptr => (WmfMediaSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator WmfMediaSettings(IntPtr p) => UObject.Make<WmfMediaSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static WmfMediaSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static WmfMediaSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
