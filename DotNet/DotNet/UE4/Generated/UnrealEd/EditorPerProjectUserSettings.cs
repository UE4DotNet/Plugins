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
using UE4.Kismet;

namespace UE4.UnrealEd {
    ///<summary>Editor Per Project User Settings</summary>
    public unsafe partial class EditorPerProjectUserSettings : UObject  {
        public bool bDisplayUIExtensionPoints {
            get {return Main.GetGetBoolPropertyByName(this, "bDisplayUIExtensionPoints"); }
            set {Main.SetGetBoolPropertyByName(this, "bDisplayUIExtensionPoints", value); }
        }
        public bool bDisplayDocumentationLink {
            get {return Main.GetGetBoolPropertyByName(this, "bDisplayDocumentationLink"); }
            set {Main.SetGetBoolPropertyByName(this, "bDisplayDocumentationLink", value); }
        }
        public bool bDisplayActionListItemRefIds {
            get {return Main.GetGetBoolPropertyByName(this, "bDisplayActionListItemRefIds"); }
            set {Main.SetGetBoolPropertyByName(this, "bDisplayActionListItemRefIds", value); }
        }
        public bool bAlwaysGatherBehaviorTreeDebuggerData {
            get {return Main.GetGetBoolPropertyByName(this, "bAlwaysGatherBehaviorTreeDebuggerData"); }
            set {Main.SetGetBoolPropertyByName(this, "bAlwaysGatherBehaviorTreeDebuggerData", value); }
        }
        public bool bDisplayEngineVersionInBadge {
            get {return Main.GetGetBoolPropertyByName(this, "bDisplayEngineVersionInBadge"); }
            set {Main.SetGetBoolPropertyByName(this, "bDisplayEngineVersionInBadge", value); }
        }
        public bool bUseSimplygonSwarm {
            get {return Main.GetGetBoolPropertyByName(this, "bUseSimplygonSwarm"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseSimplygonSwarm", value); }
        }
         //TODO: string FString SimplygonServerIP
        public bool bEnableSwarmDebugging {
            get {return Main.GetGetBoolPropertyByName(this, "bEnableSwarmDebugging"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnableSwarmDebugging", value); }
        }
         //TODO: numeric uint32 SimplygonSwarmDelay
         //TODO: numeric uint32 SwarmNumOfConcurrentJobs
         //TODO: numeric uint32 SwarmMaxUploadChunkSizeInMB
         //TODO: string FString SwarmIntermediateFolder
        public bool bAutomaticallyHotReloadNewClasses {
            get {return Main.GetGetBoolPropertyByName(this, "bAutomaticallyHotReloadNewClasses"); }
            set {Main.SetGetBoolPropertyByName(this, "bAutomaticallyHotReloadNewClasses", value); }
        }
        public bool bShowCompilerLogOnCompileError {
            get {return Main.GetGetBoolPropertyByName(this, "bShowCompilerLogOnCompileError"); }
            set {Main.SetGetBoolPropertyByName(this, "bShowCompilerLogOnCompileError", value); }
        }
        public bool bShowImportDialogAtReimport {
            get {return Main.GetGetBoolPropertyByName(this, "bShowImportDialogAtReimport"); }
            set {Main.SetGetBoolPropertyByName(this, "bShowImportDialogAtReimport", value); }
        }
        ///<summary>Specify a project data source folder to store relative source file path to ease the re-import process</summary>
        public unsafe DirectoryPath DataSourceFolder {
            get {return EditorPerProjectUserSettings_ptr->DataSourceFolder;}
            set {EditorPerProjectUserSettings_ptr->DataSourceFolder = value;}
        }
        public bool bKeepAttachHierarchy {
            get {return Main.GetGetBoolPropertyByName(this, "bKeepAttachHierarchy"); }
            set {Main.SetGetBoolPropertyByName(this, "bKeepAttachHierarchy", value); }
        }
        public bool bAnimationReimportWarnings {
            get {return Main.GetGetBoolPropertyByName(this, "bAnimationReimportWarnings"); }
            set {Main.SetGetBoolPropertyByName(this, "bAnimationReimportWarnings", value); }
        }
        public bool bUseCurvesForDistributions {
            get {return Main.GetGetBoolPropertyByName(this, "bUseCurvesForDistributions"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseCurvesForDistributions", value); }
        }
        ///<summary>Controls the minimum value at which the property matrix editor will display a loading bar when pasting values</summary>
        public unsafe int PropertyMatrix_NumberOfPasteOperationsBeforeWarning {
            get {return EditorPerProjectUserSettings_ptr->PropertyMatrix_NumberOfPasteOperationsBeforeWarning;}
            set {EditorPerProjectUserSettings_ptr->PropertyMatrix_NumberOfPasteOperationsBeforeWarning = value;}
        }
        public bool bSCSEditorShowGrid {
            get {return Main.GetGetBoolPropertyByName(this, "bSCSEditorShowGrid"); }
            set {Main.SetGetBoolPropertyByName(this, "bSCSEditorShowGrid", value); }
        }
        public bool bSCSEditorShowFloor {
            get {return Main.GetGetBoolPropertyByName(this, "bSCSEditorShowFloor"); }
            set {Main.SetGetBoolPropertyByName(this, "bSCSEditorShowFloor", value); }
        }
        ///<summary>How fast the SCS viewport camera moves</summary>
        public unsafe int SCSViewportCameraSpeed {
            get {return EditorPerProjectUserSettings_ptr->SCSViewportCameraSpeed;}
            set {EditorPerProjectUserSettings_ptr->SCSViewportCameraSpeed = value;}
        }
        public bool bAutoloadCheckedOutPackages {
            get {return Main.GetGetBoolPropertyByName(this, "bAutoloadCheckedOutPackages"); }
            set {Main.SetGetBoolPropertyByName(this, "bAutoloadCheckedOutPackages", value); }
        }
        public bool bSuppressFullyLoadPrompt {
            get {return Main.GetGetBoolPropertyByName(this, "bSuppressFullyLoadPrompt"); }
            set {Main.SetGetBoolPropertyByName(this, "bSuppressFullyLoadPrompt", value); }
        }
        public bool bAllowSelectTranslucent {
            get {return Main.GetGetBoolPropertyByName(this, "bAllowSelectTranslucent"); }
            set {Main.SetGetBoolPropertyByName(this, "bAllowSelectTranslucent", value); }
        }
        ///<summary>Blueprint Favorites</summary>
        public unsafe BlueprintPaletteFavorites BlueprintFavorites {
            get {return EditorPerProjectUserSettings_ptr->BlueprintFavorites;}
            set {EditorPerProjectUserSettings_ptr->BlueprintFavorites = value;}
        }
        ///<summary>Per project user settings for which asset viewer profile should be used</summary>
        public unsafe int AssetViewerProfileIndex {
            get {return EditorPerProjectUserSettings_ptr->AssetViewerProfileIndex;}
            set {EditorPerProjectUserSettings_ptr->AssetViewerProfileIndex = value;}
        }
         //TODO: string FString AssetViewerProfileName
        ///<summary>Material Quality Level</summary>
        public unsafe int MaterialQualityLevel {
            get {return EditorPerProjectUserSettings_ptr->MaterialQualityLevel;}
            set {EditorPerProjectUserSettings_ptr->MaterialQualityLevel = value;}
        }
        static EditorPerProjectUserSettings() {
            StaticClass = Main.GetClass("EditorPerProjectUserSettings");
        }
        internal unsafe EditorPerProjectUserSettings_fields* EditorPerProjectUserSettings_ptr => (EditorPerProjectUserSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator EditorPerProjectUserSettings(IntPtr p) => UObject.Make<EditorPerProjectUserSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static EditorPerProjectUserSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static EditorPerProjectUserSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
