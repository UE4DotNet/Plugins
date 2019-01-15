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
    ///<summary>Various cooker settings.</summary>
    public unsafe partial class CookerSettings : DeveloperSettings  {
        public bool bEnableCookOnTheSide {
            get {return Main.GetGetBoolPropertyByName(this, "bEnableCookOnTheSide"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnableCookOnTheSide", value); }
        }
        public bool bEnableBuildDDCInBackground {
            get {return Main.GetGetBoolPropertyByName(this, "bEnableBuildDDCInBackground"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnableBuildDDCInBackground", value); }
        }
        public bool bIterativeCookingForLaunchOn {
            get {return Main.GetGetBoolPropertyByName(this, "bIterativeCookingForLaunchOn"); }
            set {Main.SetGetBoolPropertyByName(this, "bIterativeCookingForLaunchOn", value); }
        }
        public bool bIterativeCookingForFileCookContent {
            get {return Main.GetGetBoolPropertyByName(this, "bIterativeCookingForFileCookContent"); }
            set {Main.SetGetBoolPropertyByName(this, "bIterativeCookingForFileCookContent", value); }
        }
         //TODO: enum ECookProgressDisplayMode CookProgressDisplayMode
        public bool bIgnoreIniSettingsOutOfDateForIteration {
            get {return Main.GetGetBoolPropertyByName(this, "bIgnoreIniSettingsOutOfDateForIteration"); }
            set {Main.SetGetBoolPropertyByName(this, "bIgnoreIniSettingsOutOfDateForIteration", value); }
        }
        public bool bIgnoreScriptPackagesOutOfDateForIteration {
            get {return Main.GetGetBoolPropertyByName(this, "bIgnoreScriptPackagesOutOfDateForIteration"); }
            set {Main.SetGetBoolPropertyByName(this, "bIgnoreScriptPackagesOutOfDateForIteration", value); }
        }
        public bool bCompileBlueprintsInDevelopmentMode {
            get {return Main.GetGetBoolPropertyByName(this, "bCompileBlueprintsInDevelopmentMode"); }
            set {Main.SetGetBoolPropertyByName(this, "bCompileBlueprintsInDevelopmentMode", value); }
        }
        public bool bCookBlueprintComponentTemplateData {
            get {return Main.GetGetBoolPropertyByName(this, "bCookBlueprintComponentTemplateData"); }
            set {Main.SetGetBoolPropertyByName(this, "bCookBlueprintComponentTemplateData", value); }
        }
         //TODO: array not UObject TArray ClassesExcludedOnDedicatedServer
         //TODO: array not UObject TArray ModulesExcludedOnDedicatedServer
         //TODO: array not UObject TArray ClassesExcludedOnDedicatedClient
         //TODO: array not UObject TArray ModulesExcludedOnDedicatedClient
        ///<summary>Quality of 0 means fastest, 4 means best quality</summary>
        public unsafe int DefaultPVRTCQuality {
            get {return CookerSettings_ptr->DefaultPVRTCQuality;}
            set {CookerSettings_ptr->DefaultPVRTCQuality = value;}
        }
        ///<summary>Quality of 0 means fastest, 3 means best quality</summary>
        public unsafe int DefaultASTCQualityBySpeed {
            get {return CookerSettings_ptr->DefaultASTCQualityBySpeed;}
            set {CookerSettings_ptr->DefaultASTCQualityBySpeed = value;}
        }
        ///<summary>Quality of 0 means smallest (12x12 block size), 4 means best (4x4 block size)</summary>
        public unsafe int DefaultASTCQualityBySize {
            get {return CookerSettings_ptr->DefaultASTCQualityBySize;}
            set {CookerSettings_ptr->DefaultASTCQualityBySize = value;}
        }
        static CookerSettings() {
            StaticClass = Main.GetClass("CookerSettings");
        }
        internal unsafe CookerSettings_fields* CookerSettings_ptr => (CookerSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator CookerSettings(IntPtr p) => UObject.Make<CookerSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static CookerSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static CookerSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
