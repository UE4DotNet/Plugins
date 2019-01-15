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
    ///<summary>Implements the Level Editor's loading and saving settings.</summary>
    public unsafe partial class EditorLoadingSavingSettings : UObject  {
        ///<summary>Whether to load a default example map at startup</summary>
        public unsafe byte LoadLevelAtStartup {
            get {return EditorLoadingSavingSettings_ptr->LoadLevelAtStartup;}
            set {EditorLoadingSavingSettings_ptr->LoadLevelAtStartup = value;}
        }
        public bool bForceCompilationAtStartup {
            get {return Main.GetGetBoolPropertyByName(this, "bForceCompilationAtStartup"); }
            set {Main.SetGetBoolPropertyByName(this, "bForceCompilationAtStartup", value); }
        }
        public bool bRestoreOpenAssetTabsOnRestart {
            get {return Main.GetGetBoolPropertyByName(this, "bRestoreOpenAssetTabsOnRestart"); }
            set {Main.SetGetBoolPropertyByName(this, "bRestoreOpenAssetTabsOnRestart", value); }
        }
        public bool bMonitorContentDirectories {
            get {return Main.GetGetBoolPropertyByName(this, "bMonitorContentDirectories"); }
            set {Main.SetGetBoolPropertyByName(this, "bMonitorContentDirectories", value); }
        }
         //TODO: array not UObject TArray AutoReimportDirectorySettings
        ///<summary>Specifies an amount of time to wait before a specific file change is considered for auto reimport</summary>
        public unsafe float AutoReimportThreshold {
            get {return EditorLoadingSavingSettings_ptr->AutoReimportThreshold;}
            set {EditorLoadingSavingSettings_ptr->AutoReimportThreshold = value;}
        }
        public bool bAutoCreateAssets {
            get {return Main.GetGetBoolPropertyByName(this, "bAutoCreateAssets"); }
            set {Main.SetGetBoolPropertyByName(this, "bAutoCreateAssets", value); }
        }
        public bool bAutoDeleteAssets {
            get {return Main.GetGetBoolPropertyByName(this, "bAutoDeleteAssets"); }
            set {Main.SetGetBoolPropertyByName(this, "bAutoDeleteAssets", value); }
        }
        public bool bDetectChangesOnStartup {
            get {return Main.GetGetBoolPropertyByName(this, "bDetectChangesOnStartup"); }
            set {Main.SetGetBoolPropertyByName(this, "bDetectChangesOnStartup", value); }
        }
        public bool bPromptBeforeAutoImporting {
            get {return Main.GetGetBoolPropertyByName(this, "bPromptBeforeAutoImporting"); }
            set {Main.SetGetBoolPropertyByName(this, "bPromptBeforeAutoImporting", value); }
        }
        public bool bDeleteSourceFilesWithAssets {
            get {return Main.GetGetBoolPropertyByName(this, "bDeleteSourceFilesWithAssets"); }
            set {Main.SetGetBoolPropertyByName(this, "bDeleteSourceFilesWithAssets", value); }
        }
        public bool bDirtyMigratedBlueprints {
            get {return Main.GetGetBoolPropertyByName(this, "bDirtyMigratedBlueprints"); }
            set {Main.SetGetBoolPropertyByName(this, "bDirtyMigratedBlueprints", value); }
        }
        public bool bAutoSaveEnable {
            get {return Main.GetGetBoolPropertyByName(this, "bAutoSaveEnable"); }
            set {Main.SetGetBoolPropertyByName(this, "bAutoSaveEnable", value); }
        }
        public bool bAutoSaveMaps {
            get {return Main.GetGetBoolPropertyByName(this, "bAutoSaveMaps"); }
            set {Main.SetGetBoolPropertyByName(this, "bAutoSaveMaps", value); }
        }
        public bool bAutoSaveContent {
            get {return Main.GetGetBoolPropertyByName(this, "bAutoSaveContent"); }
            set {Main.SetGetBoolPropertyByName(this, "bAutoSaveContent", value); }
        }
        ///<summary>The time interval after which to auto save</summary>
        public unsafe int AutoSaveTimeMinutes {
            get {return EditorLoadingSavingSettings_ptr->AutoSaveTimeMinutes;}
            set {EditorLoadingSavingSettings_ptr->AutoSaveTimeMinutes = value;}
        }
        ///<summary>The number of seconds warning before an autosave</summary>
        public unsafe int AutoSaveWarningInSeconds {
            get {return EditorLoadingSavingSettings_ptr->AutoSaveWarningInSeconds;}
            set {EditorLoadingSavingSettings_ptr->AutoSaveWarningInSeconds = value;}
        }
        public bool bAutomaticallyCheckoutOnAssetModification {
            get {return Main.GetGetBoolPropertyByName(this, "bAutomaticallyCheckoutOnAssetModification"); }
            set {Main.SetGetBoolPropertyByName(this, "bAutomaticallyCheckoutOnAssetModification", value); }
        }
        public bool bPromptForCheckoutOnAssetModification {
            get {return Main.GetGetBoolPropertyByName(this, "bPromptForCheckoutOnAssetModification"); }
            set {Main.SetGetBoolPropertyByName(this, "bPromptForCheckoutOnAssetModification", value); }
        }
        public bool bSCCAutoAddNewFiles {
            get {return Main.GetGetBoolPropertyByName(this, "bSCCAutoAddNewFiles"); }
            set {Main.SetGetBoolPropertyByName(this, "bSCCAutoAddNewFiles", value); }
        }
        public bool bSCCUseGlobalSettings {
            get {return Main.GetGetBoolPropertyByName(this, "bSCCUseGlobalSettings"); }
            set {Main.SetGetBoolPropertyByName(this, "bSCCUseGlobalSettings", value); }
        }
        ///<summary>Specifies the file path to the tool to be used for diffing text files</summary>
        public unsafe FilePath TextDiffToolPath {
            get {return EditorLoadingSavingSettings_ptr->TextDiffToolPath;}
            set {EditorLoadingSavingSettings_ptr->TextDiffToolPath = value;}
        }
        static EditorLoadingSavingSettings() {
            StaticClass = Main.GetClass("EditorLoadingSavingSettings");
        }
        internal unsafe EditorLoadingSavingSettings_fields* EditorLoadingSavingSettings_ptr => (EditorLoadingSavingSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator EditorLoadingSavingSettings(IntPtr p) => UObject.Make<EditorLoadingSavingSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static EditorLoadingSavingSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static EditorLoadingSavingSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
