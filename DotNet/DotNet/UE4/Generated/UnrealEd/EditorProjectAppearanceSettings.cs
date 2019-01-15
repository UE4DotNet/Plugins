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
    ///<summary>Editor project appearance settings. Stored in default config, per-project</summary>
    public unsafe partial class EditorProjectAppearanceSettings : DeveloperSettings  {
        public bool bDisplayUnits {
            get {return Main.GetGetBoolPropertyByName(this, "bDisplayUnits"); }
            set {Main.SetGetBoolPropertyByName(this, "bDisplayUnits", value); }
        }
        public bool bDisplayUnitsOnComponentTransforms {
            get {return Main.GetGetBoolPropertyByName(this, "bDisplayUnitsOnComponentTransforms"); }
            set {Main.SetGetBoolPropertyByName(this, "bDisplayUnitsOnComponentTransforms", value); }
        }
         //TODO: array not UObject TArray DistanceUnits
         //TODO: array not UObject TArray MassUnits
         //TODO: array not UObject TArray TimeUnits
         //TODO: enum EUnit AngleUnits
         //TODO: enum EUnit SpeedUnits
         //TODO: enum EUnit TemperatureUnits
         //TODO: enum EUnit ForceUnits
        static EditorProjectAppearanceSettings() {
            StaticClass = Main.GetClass("EditorProjectAppearanceSettings");
        }
        internal unsafe EditorProjectAppearanceSettings_fields* EditorProjectAppearanceSettings_ptr => (EditorProjectAppearanceSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator EditorProjectAppearanceSettings(IntPtr p) => UObject.Make<EditorProjectAppearanceSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static EditorProjectAppearanceSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static EditorProjectAppearanceSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
