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
using UE4.LinuxTargetPlatform.Native;

namespace UE4.LinuxTargetPlatform {
    ///<summary>Implements the settings for the Linux target platform.</summary>
    public unsafe partial class LinuxTargetSettings : UObject  {
         //TODO: string FString SpatializationPlugin
         //TODO: string FString ReverbPlugin
         //TODO: string FString OcclusionPlugin
         //TODO: array not UObject TArray TargetedRHIs
        static LinuxTargetSettings() {
            StaticClass = Main.GetClass("LinuxTargetSettings");
        }
        internal unsafe LinuxTargetSettings_fields* LinuxTargetSettings_ptr => (LinuxTargetSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator LinuxTargetSettings(IntPtr p) => UObject.Make<LinuxTargetSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static LinuxTargetSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static LinuxTargetSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
