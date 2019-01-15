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
using UE4.FunctionalTesting.Native;
using UE4.Engine;

namespace UE4.FunctionalTesting {
    ///<summary>Automation View Settings</summary>
    public unsafe partial class AutomationViewSettings : DataAsset  {
        public bool AntiAliasing {
            get {return Main.GetGetBoolPropertyByName(this, "AntiAliasing"); }
            set {Main.SetGetBoolPropertyByName(this, "AntiAliasing", value); }
        }
        public bool MotionBlur {
            get {return Main.GetGetBoolPropertyByName(this, "MotionBlur"); }
            set {Main.SetGetBoolPropertyByName(this, "MotionBlur", value); }
        }
        public bool TemporalAA {
            get {return Main.GetGetBoolPropertyByName(this, "TemporalAA"); }
            set {Main.SetGetBoolPropertyByName(this, "TemporalAA", value); }
        }
        public bool ScreenSpaceReflections {
            get {return Main.GetGetBoolPropertyByName(this, "ScreenSpaceReflections"); }
            set {Main.SetGetBoolPropertyByName(this, "ScreenSpaceReflections", value); }
        }
        public bool ScreenSpaceAO {
            get {return Main.GetGetBoolPropertyByName(this, "ScreenSpaceAO"); }
            set {Main.SetGetBoolPropertyByName(this, "ScreenSpaceAO", value); }
        }
        public bool DistanceFieldAO {
            get {return Main.GetGetBoolPropertyByName(this, "DistanceFieldAO"); }
            set {Main.SetGetBoolPropertyByName(this, "DistanceFieldAO", value); }
        }
        public bool ContactShadows {
            get {return Main.GetGetBoolPropertyByName(this, "ContactShadows"); }
            set {Main.SetGetBoolPropertyByName(this, "ContactShadows", value); }
        }
        public bool EyeAdaptation {
            get {return Main.GetGetBoolPropertyByName(this, "EyeAdaptation"); }
            set {Main.SetGetBoolPropertyByName(this, "EyeAdaptation", value); }
        }
        public bool Bloom {
            get {return Main.GetGetBoolPropertyByName(this, "Bloom"); }
            set {Main.SetGetBoolPropertyByName(this, "Bloom", value); }
        }
        static AutomationViewSettings() {
            StaticClass = Main.GetClass("AutomationViewSettings");
        }
        internal unsafe AutomationViewSettings_fields* AutomationViewSettings_ptr => (AutomationViewSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AutomationViewSettings(IntPtr p) => UObject.Make<AutomationViewSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AutomationViewSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AutomationViewSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
