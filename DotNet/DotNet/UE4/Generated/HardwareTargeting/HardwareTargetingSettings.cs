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
using UE4.HardwareTargeting.Native;

namespace UE4.HardwareTargeting {
    ///<summary>Hardware targeting settings, stored in default config, per-project</summary>
    public unsafe partial class HardwareTargetingSettings : UObject  {
        ///<summary>Enum specifying which class of hardware this game is targeting</summary>
        public unsafe byte TargetedHardwareClass {
            get {return HardwareTargetingSettings_ptr->TargetedHardwareClass;}
            set {HardwareTargetingSettings_ptr->TargetedHardwareClass = value;}
        }
        ///<summary>Enum that is set to TargetedHardwareClass when the settings have been successfully applied</summary>
        public unsafe byte AppliedTargetedHardwareClass {
            get {return HardwareTargetingSettings_ptr->AppliedTargetedHardwareClass;}
            set {HardwareTargetingSettings_ptr->AppliedTargetedHardwareClass = value;}
        }
        ///<summary>Enum specifying a graphics preset to use for this game</summary>
        public unsafe byte DefaultGraphicsPerformance {
            get {return HardwareTargetingSettings_ptr->DefaultGraphicsPerformance;}
            set {HardwareTargetingSettings_ptr->DefaultGraphicsPerformance = value;}
        }
        ///<summary>Enum that is set to DefaultGraphicsPerformance when the settings have been successfully applied</summary>
        public unsafe byte AppliedDefaultGraphicsPerformance {
            get {return HardwareTargetingSettings_ptr->AppliedDefaultGraphicsPerformance;}
            set {HardwareTargetingSettings_ptr->AppliedDefaultGraphicsPerformance = value;}
        }
        static HardwareTargetingSettings() {
            StaticClass = Main.GetClass("HardwareTargetingSettings");
        }
        internal unsafe HardwareTargetingSettings_fields* HardwareTargetingSettings_ptr => (HardwareTargetingSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator HardwareTargetingSettings(IntPtr p) => UObject.Make<HardwareTargetingSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static HardwareTargetingSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static HardwareTargetingSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
