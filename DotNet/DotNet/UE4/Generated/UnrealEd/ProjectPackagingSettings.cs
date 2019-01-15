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
    ///<summary>Implements the Editor's user settings.</summary>
    public unsafe partial class ProjectPackagingSettings : UObject  {
         //TODO: enum EProjectPackagingBuild Build
        ///<summary>The build configuration for which the project is packaged.</summary>
        public unsafe byte BuildConfiguration {
            get {return ProjectPackagingSettings_ptr->BuildConfiguration;}
            set {ProjectPackagingSettings_ptr->BuildConfiguration = value;}
        }
        ///<summary>The directory to which the packaged project will be copied.</summary>
        public unsafe DirectoryPath StagingDirectory {
            get {return ProjectPackagingSettings_ptr->StagingDirectory;}
            set {ProjectPackagingSettings_ptr->StagingDirectory = value;}
        }
        public bool FullRebuild {
            get {return Main.GetGetBoolPropertyByName(this, "FullRebuild"); }
            set {Main.SetGetBoolPropertyByName(this, "FullRebuild", value); }
        }
        public bool ForDistribution {
            get {return Main.GetGetBoolPropertyByName(this, "ForDistribution"); }
            set {Main.SetGetBoolPropertyByName(this, "ForDistribution", value); }
        }
        public bool IncludeDebugFiles {
            get {return Main.GetGetBoolPropertyByName(this, "IncludeDebugFiles"); }
            set {Main.SetGetBoolPropertyByName(this, "IncludeDebugFiles", value); }
        }
         //TODO: enum EProjectPackagingBlueprintNativizationMethod BlueprintNativizationMethod
         //TODO: array not UObject TArray NativizeBlueprintAssets
        public bool bIncludeNativizedAssetsInProjectGeneration {
            get {return Main.GetGetBoolPropertyByName(this, "bIncludeNativizedAssetsInProjectGeneration"); }
            set {Main.SetGetBoolPropertyByName(this, "bIncludeNativizedAssetsInProjectGeneration", value); }
        }
        public bool bExcludeMonolithicEngineHeadersInNativizedCode {
            get {return Main.GetGetBoolPropertyByName(this, "bExcludeMonolithicEngineHeadersInNativizedCode"); }
            set {Main.SetGetBoolPropertyByName(this, "bExcludeMonolithicEngineHeadersInNativizedCode", value); }
        }
        public bool UsePakFile {
            get {return Main.GetGetBoolPropertyByName(this, "UsePakFile"); }
            set {Main.SetGetBoolPropertyByName(this, "UsePakFile", value); }
        }
        public bool bGenerateChunks {
            get {return Main.GetGetBoolPropertyByName(this, "bGenerateChunks"); }
            set {Main.SetGetBoolPropertyByName(this, "bGenerateChunks", value); }
        }
        public bool bGenerateNoChunks {
            get {return Main.GetGetBoolPropertyByName(this, "bGenerateNoChunks"); }
            set {Main.SetGetBoolPropertyByName(this, "bGenerateNoChunks", value); }
        }
        public bool bChunkHardReferencesOnly {
            get {return Main.GetGetBoolPropertyByName(this, "bChunkHardReferencesOnly"); }
            set {Main.SetGetBoolPropertyByName(this, "bChunkHardReferencesOnly", value); }
        }
        public bool bBuildHttpChunkInstallData {
            get {return Main.GetGetBoolPropertyByName(this, "bBuildHttpChunkInstallData"); }
            set {Main.SetGetBoolPropertyByName(this, "bBuildHttpChunkInstallData", value); }
        }
        ///<summary>When "Build HTTP Chunk Install Data" is enabled this is the directory where the data will be build to.</summary>
        public unsafe DirectoryPath HttpChunkInstallDataDirectory {
            get {return ProjectPackagingSettings_ptr->HttpChunkInstallDataDirectory;}
            set {ProjectPackagingSettings_ptr->HttpChunkInstallDataDirectory = value;}
        }
         //TODO: string FString HttpChunkInstallDataVersion
        public bool IncludePrerequisites {
            get {return Main.GetGetBoolPropertyByName(this, "IncludePrerequisites"); }
            set {Main.SetGetBoolPropertyByName(this, "IncludePrerequisites", value); }
        }
        public bool IncludeAppLocalPrerequisites {
            get {return Main.GetGetBoolPropertyByName(this, "IncludeAppLocalPrerequisites"); }
            set {Main.SetGetBoolPropertyByName(this, "IncludeAppLocalPrerequisites", value); }
        }
        public bool bShareMaterialShaderCode {
            get {return Main.GetGetBoolPropertyByName(this, "bShareMaterialShaderCode"); }
            set {Main.SetGetBoolPropertyByName(this, "bShareMaterialShaderCode", value); }
        }
        public bool bSharedMaterialNativeLibraries {
            get {return Main.GetGetBoolPropertyByName(this, "bSharedMaterialNativeLibraries"); }
            set {Main.SetGetBoolPropertyByName(this, "bSharedMaterialNativeLibraries", value); }
        }
        ///<summary>A directory containing additional prerequisite packages that should be staged in the executable directory. Can be relative to $(EngineDir) or $(ProjectDir)</summary>
        public unsafe DirectoryPath ApplocalPrerequisitesDirectory {
            get {return ProjectPackagingSettings_ptr->ApplocalPrerequisitesDirectory;}
            set {ProjectPackagingSettings_ptr->ApplocalPrerequisitesDirectory = value;}
        }
        public bool IncludeCrashReporter {
            get {return Main.GetGetBoolPropertyByName(this, "IncludeCrashReporter"); }
            set {Main.SetGetBoolPropertyByName(this, "IncludeCrashReporter", value); }
        }
         //TODO: enum EProjectPackagingInternationalizationPresets InternationalizationPreset
         //TODO: array not UObject TArray CulturesToStage
        public bool bCookAll {
            get {return Main.GetGetBoolPropertyByName(this, "bCookAll"); }
            set {Main.SetGetBoolPropertyByName(this, "bCookAll", value); }
        }
        public bool bCookMapsOnly {
            get {return Main.GetGetBoolPropertyByName(this, "bCookMapsOnly"); }
            set {Main.SetGetBoolPropertyByName(this, "bCookMapsOnly", value); }
        }
        public bool bCompressed {
            get {return Main.GetGetBoolPropertyByName(this, "bCompressed"); }
            set {Main.SetGetBoolPropertyByName(this, "bCompressed", value); }
        }
        public bool bSkipEditorContent {
            get {return Main.GetGetBoolPropertyByName(this, "bSkipEditorContent"); }
            set {Main.SetGetBoolPropertyByName(this, "bSkipEditorContent", value); }
        }
        public bool bSkipMovies {
            get {return Main.GetGetBoolPropertyByName(this, "bSkipMovies"); }
            set {Main.SetGetBoolPropertyByName(this, "bSkipMovies", value); }
        }
         //TODO: array not UObject TArray MapsToCook
         //TODO: array not UObject TArray DirectoriesToAlwaysCook
         //TODO: array not UObject TArray DirectoriesToNeverCook
         //TODO: array not UObject TArray DirectoriesToAlwaysStageAsUFS
         //TODO: array not UObject TArray DirectoriesToAlwaysStageAsNonUFS
         //TODO: array not UObject TArray DirectoriesToAlwaysStageAsUFSServer
         //TODO: array not UObject TArray DirectoriesToAlwaysStageAsNonUFSServer
        static ProjectPackagingSettings() {
            StaticClass = Main.GetClass("ProjectPackagingSettings");
        }
        internal unsafe ProjectPackagingSettings_fields* ProjectPackagingSettings_ptr => (ProjectPackagingSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ProjectPackagingSettings(IntPtr p) => UObject.Make<ProjectPackagingSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ProjectPackagingSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ProjectPackagingSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
