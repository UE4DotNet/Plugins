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
    ///<summary>Hud Settings</summary>
    public unsafe partial class HudSettings : UObject  {
        public bool bShowHUD {
            get {return Main.GetGetBoolPropertyByName(this, "bShowHUD"); }
            set {Main.SetGetBoolPropertyByName(this, "bShowHUD", value); }
        }
         //TODO: array not UObject TArray DebugDisplay
        static HudSettings() {
            StaticClass = Main.GetClass("HudSettings");
        }
        internal unsafe HudSettings_fields* HudSettings_ptr => (HudSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator HudSettings(IntPtr p) => UObject.Make<HudSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static HudSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static HudSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
