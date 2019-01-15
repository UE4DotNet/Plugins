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
    ///<summary>General Project Settings</summary>
    public unsafe partial class GeneralProjectSettings : UObject  {
         //TODO: string FString CompanyName
         //TODO: string FString CompanyDistinguishedName
         //TODO: string FString CopyrightNotice
         //TODO: string FString Description
         //TODO: string FString Homepage
         //TODO: string FString LicensingTerms
         //TODO: string FString PrivacyPolicy
        ///<summary>The project's unique identifier.</summary>
        public unsafe FGuid ProjectID {
            get {return GeneralProjectSettings_ptr->ProjectID;}
            set {GeneralProjectSettings_ptr->ProjectID = value;}
        }
         //TODO: string FString ProjectName
         //TODO: string FString ProjectVersion
         //TODO: string FString SupportContact
         //TODO: text FText ProjectDisplayedTitle
         //TODO: text FText ProjectDebugTitleInfo
        public bool bShouldWindowPreserveAspectRatio {
            get {return Main.GetGetBoolPropertyByName(this, "bShouldWindowPreserveAspectRatio"); }
            set {Main.SetGetBoolPropertyByName(this, "bShouldWindowPreserveAspectRatio", value); }
        }
        public bool bUseBorderlessWindow {
            get {return Main.GetGetBoolPropertyByName(this, "bUseBorderlessWindow"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseBorderlessWindow", value); }
        }
        public bool bStartInVR {
            get {return Main.GetGetBoolPropertyByName(this, "bStartInVR"); }
            set {Main.SetGetBoolPropertyByName(this, "bStartInVR", value); }
        }
        public bool bAllowWindowResize {
            get {return Main.GetGetBoolPropertyByName(this, "bAllowWindowResize"); }
            set {Main.SetGetBoolPropertyByName(this, "bAllowWindowResize", value); }
        }
        public bool bAllowClose {
            get {return Main.GetGetBoolPropertyByName(this, "bAllowClose"); }
            set {Main.SetGetBoolPropertyByName(this, "bAllowClose", value); }
        }
        public bool bAllowMaximize {
            get {return Main.GetGetBoolPropertyByName(this, "bAllowMaximize"); }
            set {Main.SetGetBoolPropertyByName(this, "bAllowMaximize", value); }
        }
        public bool bAllowMinimize {
            get {return Main.GetGetBoolPropertyByName(this, "bAllowMinimize"); }
            set {Main.SetGetBoolPropertyByName(this, "bAllowMinimize", value); }
        }
        static GeneralProjectSettings() {
            StaticClass = Main.GetClass("GeneralProjectSettings");
        }
        internal unsafe GeneralProjectSettings_fields* GeneralProjectSettings_ptr => (GeneralProjectSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator GeneralProjectSettings(IntPtr p) => UObject.Make<GeneralProjectSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static GeneralProjectSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static GeneralProjectSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
