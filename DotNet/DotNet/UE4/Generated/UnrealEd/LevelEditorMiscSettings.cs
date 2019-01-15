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
    ///<summary>Configure miscellaneous settings for the Level Editor.</summary>
    public unsafe partial class LevelEditorMiscSettings : DeveloperSettings  {
        public bool bAutoApplyLightingEnable {
            get {return Main.GetGetBoolPropertyByName(this, "bAutoApplyLightingEnable"); }
            set {Main.SetGetBoolPropertyByName(this, "bAutoApplyLightingEnable", value); }
        }
        public bool bBSPAutoUpdate {
            get {return Main.GetGetBoolPropertyByName(this, "bBSPAutoUpdate"); }
            set {Main.SetGetBoolPropertyByName(this, "bBSPAutoUpdate", value); }
        }
        public bool bAutoMoveBSPPivotOffset {
            get {return Main.GetGetBoolPropertyByName(this, "bAutoMoveBSPPivotOffset"); }
            set {Main.SetGetBoolPropertyByName(this, "bAutoMoveBSPPivotOffset", value); }
        }
        public bool bNavigationAutoUpdate {
            get {return Main.GetGetBoolPropertyByName(this, "bNavigationAutoUpdate"); }
            set {Main.SetGetBoolPropertyByName(this, "bNavigationAutoUpdate", value); }
        }
        public bool bReplaceRespectsScale {
            get {return Main.GetGetBoolPropertyByName(this, "bReplaceRespectsScale"); }
            set {Main.SetGetBoolPropertyByName(this, "bReplaceRespectsScale", value); }
        }
        public bool bAllowBackgroundAudio {
            get {return Main.GetGetBoolPropertyByName(this, "bAllowBackgroundAudio"); }
            set {Main.SetGetBoolPropertyByName(this, "bAllowBackgroundAudio", value); }
        }
        public bool bEnableRealTimeAudio {
            get {return Main.GetGetBoolPropertyByName(this, "bEnableRealTimeAudio"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnableRealTimeAudio", value); }
        }
        ///<summary>Global volume setting for the editor</summary>
        public unsafe float EditorVolumeLevel {
            get {return LevelEditorMiscSettings_ptr->EditorVolumeLevel;}
            set {LevelEditorMiscSettings_ptr->EditorVolumeLevel = value;}
        }
        public bool bEnableEditorSounds {
            get {return Main.GetGetBoolPropertyByName(this, "bEnableEditorSounds"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnableEditorSounds", value); }
        }
        ///<summary>The default level streaming class to use when adding new streaming levels</summary>
        public unsafe SubclassOf<LevelStreaming> DefaultLevelStreamingClass {
            get {return LevelEditorMiscSettings_ptr->DefaultLevelStreamingClass;}
            set {LevelEditorMiscSettings_ptr->DefaultLevelStreamingClass = value;}
        }
        ///<summary>The save directory for newly created screenshots</summary>
        public unsafe DirectoryPath EditorScreenshotSaveDirectory {
            get {return LevelEditorMiscSettings_ptr->EditorScreenshotSaveDirectory;}
            set {LevelEditorMiscSettings_ptr->EditorScreenshotSaveDirectory = value;}
        }
        static LevelEditorMiscSettings() {
            StaticClass = Main.GetClass("LevelEditorMiscSettings");
        }
        internal unsafe LevelEditorMiscSettings_fields* LevelEditorMiscSettings_ptr => (LevelEditorMiscSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator LevelEditorMiscSettings(IntPtr p) => UObject.Make<LevelEditorMiscSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static LevelEditorMiscSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static LevelEditorMiscSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
