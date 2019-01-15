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
using UE4.OnlineSubsystemUtils.Native;
using UE4.Engine;

namespace UE4.OnlineSubsystemUtils {
    ///<summary>Setup login credentials for the Play In Editor (PIE) feature</summary>
    public unsafe partial class OnlinePIESettings : DeveloperSettings  {
        public bool bOnlinePIEEnabled {
            get {return Main.GetGetBoolPropertyByName(this, "bOnlinePIEEnabled"); }
            set {Main.SetGetBoolPropertyByName(this, "bOnlinePIEEnabled", value); }
        }
         //TODO: array not UObject TArray Logins
        static OnlinePIESettings() {
            StaticClass = Main.GetClass("OnlinePIESettings");
        }
        internal unsafe OnlinePIESettings_fields* OnlinePIESettings_ptr => (OnlinePIESettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator OnlinePIESettings(IntPtr p) => UObject.Make<OnlinePIESettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static OnlinePIESettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static OnlinePIESettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
