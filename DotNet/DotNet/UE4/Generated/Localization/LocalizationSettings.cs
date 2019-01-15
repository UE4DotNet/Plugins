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
using UE4.Localization.Native;

namespace UE4.Localization {
    ///<summary>Class for loading/saving configuration settings and the details view objects needed for localization dashboard functionality.</summary>
    public unsafe partial class LocalizationSettings : UObject  {
        ///<summary>Engine Target Set</summary>
        public unsafe LocalizationTargetSet EngineTargetSet {
            get {return LocalizationSettings_ptr->EngineTargetSet;}
            set {LocalizationSettings_ptr->EngineTargetSet = value;}
        }
         //TODO: array not UObject TArray EngineTargetsSettings
        ///<summary>Game Target Set</summary>
        public unsafe LocalizationTargetSet GameTargetSet {
            get {return LocalizationSettings_ptr->GameTargetSet;}
            set {LocalizationSettings_ptr->GameTargetSet = value;}
        }
         //TODO: array not UObject TArray GameTargetsSettings
        static LocalizationSettings() {
            StaticClass = Main.GetClass("LocalizationSettings");
        }
        internal unsafe LocalizationSettings_fields* LocalizationSettings_ptr => (LocalizationSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator LocalizationSettings(IntPtr p) => UObject.Make<LocalizationSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static LocalizationSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static LocalizationSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
