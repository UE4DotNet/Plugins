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

namespace UE4.UnrealEd {
    ///<summary>Implements per-project cooker settings exposed to the editor</summary>
    public unsafe partial class CrashReporterSettings : UObject  {
         //TODO: string FString UploadSymbolsPath
         //TODO: string FString DownstreamStorage
         //TODO: array not UObject TArray RemoteStorage
        static CrashReporterSettings() {
            StaticClass = Main.GetClass("CrashReporterSettings");
        }
        internal unsafe CrashReporterSettings_fields* CrashReporterSettings_ptr => (CrashReporterSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator CrashReporterSettings(IntPtr p) => UObject.Make<CrashReporterSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static CrashReporterSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static CrashReporterSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
