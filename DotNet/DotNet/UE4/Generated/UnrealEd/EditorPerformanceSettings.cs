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
    ///<summary>Settings to tweak the performance of the editor</summary>
    public unsafe partial class EditorPerformanceSettings : DeveloperSettings  {
        public bool bShowFrameRateAndMemory {
            get {return Main.GetGetBoolPropertyByName(this, "bShowFrameRateAndMemory"); }
            set {Main.SetGetBoolPropertyByName(this, "bShowFrameRateAndMemory", value); }
        }
        public bool bThrottleCPUWhenNotForeground {
            get {return Main.GetGetBoolPropertyByName(this, "bThrottleCPUWhenNotForeground"); }
            set {Main.SetGetBoolPropertyByName(this, "bThrottleCPUWhenNotForeground", value); }
        }
        public bool bMonitorEditorPerformance {
            get {return Main.GetGetBoolPropertyByName(this, "bMonitorEditorPerformance"); }
            set {Main.SetGetBoolPropertyByName(this, "bMonitorEditorPerformance", value); }
        }
        public bool bOverrideDPIBasedEditorViewportScaling {
            get {return Main.GetGetBoolPropertyByName(this, "bOverrideDPIBasedEditorViewportScaling"); }
            set {Main.SetGetBoolPropertyByName(this, "bOverrideDPIBasedEditorViewportScaling", value); }
        }
        public bool bEnableSharedDDCPerformanceNotifications {
            get {return Main.GetGetBoolPropertyByName(this, "bEnableSharedDDCPerformanceNotifications"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnableSharedDDCPerformanceNotifications", value); }
        }
        static EditorPerformanceSettings() {
            StaticClass = Main.GetClass("EditorPerformanceSettings");
        }
        internal unsafe EditorPerformanceSettings_fields* EditorPerformanceSettings_ptr => (EditorPerformanceSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator EditorPerformanceSettings(IntPtr p) => UObject.Make<EditorPerformanceSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static EditorPerformanceSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static EditorPerformanceSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
