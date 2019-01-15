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
using UE4.UMGEditor.Native;
using UE4.Engine;

namespace UE4.UMGEditor {
    ///<summary>Implements the settings for the UMG Editor Project Settings</summary>
    public unsafe partial class UMGEditorProjectSettings : DeveloperSettings  {
        public bool bCookSlowConstructionWidgetTree {
            get {return Main.GetGetBoolPropertyByName(this, "bCookSlowConstructionWidgetTree"); }
            set {Main.SetGetBoolPropertyByName(this, "bCookSlowConstructionWidgetTree", value); }
        }
        public bool bWidgetSupportsDynamicCreation {
            get {return Main.GetGetBoolPropertyByName(this, "bWidgetSupportsDynamicCreation"); }
            set {Main.SetGetBoolPropertyByName(this, "bWidgetSupportsDynamicCreation", value); }
        }
         //TODO: array not UObject TArray DebugResolutions
        public bool bShowWidgetsFromEngineContent {
            get {return Main.GetGetBoolPropertyByName(this, "bShowWidgetsFromEngineContent"); }
            set {Main.SetGetBoolPropertyByName(this, "bShowWidgetsFromEngineContent", value); }
        }
        public bool bShowWidgetsFromDeveloperContent {
            get {return Main.GetGetBoolPropertyByName(this, "bShowWidgetsFromDeveloperContent"); }
            set {Main.SetGetBoolPropertyByName(this, "bShowWidgetsFromDeveloperContent", value); }
        }
         //TODO: array not UObject TArray CategoriesToHide
         //TODO: array not UObject TArray WidgetClassesToHide
        static UMGEditorProjectSettings() {
            StaticClass = Main.GetClass("UMGEditorProjectSettings");
        }
        internal unsafe UMGEditorProjectSettings_fields* UMGEditorProjectSettings_ptr => (UMGEditorProjectSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator UMGEditorProjectSettings(IntPtr p) => UObject.Make<UMGEditorProjectSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static UMGEditorProjectSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static UMGEditorProjectSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
