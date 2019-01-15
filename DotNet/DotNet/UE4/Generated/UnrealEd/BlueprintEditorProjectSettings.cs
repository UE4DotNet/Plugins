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
    ///<summary>Blueprint Editor Project Settings</summary>
    public unsafe partial class BlueprintEditorProjectSettings : DeveloperSettings  {
        public bool bDisableCompilationManager {
            get {return Main.GetGetBoolPropertyByName(this, "bDisableCompilationManager"); }
            set {Main.SetGetBoolPropertyByName(this, "bDisableCompilationManager", value); }
        }
        public bool bForceAllDependenciesToRecompile {
            get {return Main.GetGetBoolPropertyByName(this, "bForceAllDependenciesToRecompile"); }
            set {Main.SetGetBoolPropertyByName(this, "bForceAllDependenciesToRecompile", value); }
        }
        public bool bValidateUnloadedSoftActorReferences {
            get {return Main.GetGetBoolPropertyByName(this, "bValidateUnloadedSoftActorReferences"); }
            set {Main.SetGetBoolPropertyByName(this, "bValidateUnloadedSoftActorReferences", value); }
        }
        static BlueprintEditorProjectSettings() {
            StaticClass = Main.GetClass("BlueprintEditorProjectSettings");
        }
        internal unsafe BlueprintEditorProjectSettings_fields* BlueprintEditorProjectSettings_ptr => (BlueprintEditorProjectSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BlueprintEditorProjectSettings(IntPtr p) => UObject.Make<BlueprintEditorProjectSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BlueprintEditorProjectSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BlueprintEditorProjectSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
