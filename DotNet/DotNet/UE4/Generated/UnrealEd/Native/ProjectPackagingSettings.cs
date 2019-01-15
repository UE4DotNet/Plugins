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

using UE4.Engine;

namespace UE4.UnrealEd.Native {
    [StructLayout( LayoutKind.Explicit, Size=336 )]
    internal unsafe struct ProjectPackagingSettings_fields {
        [FieldOffset(56)] byte Build; //TODO: enum EProjectPackagingBuild Build
        [FieldOffset(60)] public byte BuildConfiguration;
        [FieldOffset(64)] public DirectoryPath StagingDirectory;
        [FieldOffset(80)] public bool FullRebuild;
        [FieldOffset(81)] public bool ForDistribution;
        [FieldOffset(82)] public bool IncludeDebugFiles;
        [FieldOffset(83)] byte BlueprintNativizationMethod; //TODO: enum EProjectPackagingBlueprintNativizationMethod BlueprintNativizationMethod
        [FieldOffset(88)] public NativeArray NativizeBlueprintAssets;
        [FieldOffset(104)] public bool bIncludeNativizedAssetsInProjectGeneration;
        [FieldOffset(105)] public bool bExcludeMonolithicEngineHeadersInNativizedCode;
        [FieldOffset(106)] public bool UsePakFile;
        [FieldOffset(107)] public bool bGenerateChunks;
        [FieldOffset(108)] public bool bGenerateNoChunks;
        [FieldOffset(109)] public bool bChunkHardReferencesOnly;
        [FieldOffset(110)] public bool bBuildHttpChunkInstallData;
        [FieldOffset(112)] public DirectoryPath HttpChunkInstallDataDirectory;
        [FieldOffset(128)] byte HttpChunkInstallDataVersion; //TODO: string FString HttpChunkInstallDataVersion
        [FieldOffset(144)] public bool IncludePrerequisites;
        [FieldOffset(145)] public bool IncludeAppLocalPrerequisites;
        [FieldOffset(146)] public bool bShareMaterialShaderCode;
        [FieldOffset(147)] public bool bSharedMaterialNativeLibraries;
        [FieldOffset(152)] public DirectoryPath ApplocalPrerequisitesDirectory;
        [FieldOffset(168)] public bool IncludeCrashReporter;
        [FieldOffset(169)] byte InternationalizationPreset; //TODO: enum EProjectPackagingInternationalizationPresets InternationalizationPreset
        [FieldOffset(176)] public NativeArray CulturesToStage;
        [FieldOffset(192)] public bool bCookAll;
        [FieldOffset(193)] public bool bCookMapsOnly;
        [FieldOffset(194)] public bool bCompressed;
        [FieldOffset(197)] public bool bSkipEditorContent;
        [FieldOffset(198)] public bool bSkipMovies;
        [FieldOffset(200)] public NativeArray MapsToCook;
        [FieldOffset(216)] public NativeArray DirectoriesToAlwaysCook;
        [FieldOffset(232)] public NativeArray DirectoriesToNeverCook;
        [FieldOffset(248)] public NativeArray DirectoriesToAlwaysStageAsUFS;
        [FieldOffset(264)] public NativeArray DirectoriesToAlwaysStageAsNonUFS;
        [FieldOffset(280)] public NativeArray DirectoriesToAlwaysStageAsUFSServer;
        [FieldOffset(296)] public NativeArray DirectoriesToAlwaysStageAsNonUFSServer;
    }
    internal unsafe struct ProjectPackagingSettings_methods {
    }
    internal unsafe struct ProjectPackagingSettings_events {
    }
}
