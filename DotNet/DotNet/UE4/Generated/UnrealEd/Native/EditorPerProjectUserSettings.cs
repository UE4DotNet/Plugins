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
    [StructLayout( LayoutKind.Explicit, Size=224 )]
    internal unsafe struct EditorPerProjectUserSettings_fields {
        [FieldOffset(56)] public bool bDisplayUIExtensionPoints;
        [FieldOffset(56)] public bool bDisplayDocumentationLink;
        [FieldOffset(56)] public bool bDisplayActionListItemRefIds;
        [FieldOffset(56)] public bool bAlwaysGatherBehaviorTreeDebuggerData;
        [FieldOffset(60)] public bool bDisplayEngineVersionInBadge;
        [FieldOffset(61)] public bool bUseSimplygonSwarm;
        [FieldOffset(64)] byte SimplygonServerIP; //TODO: string FString SimplygonServerIP
        [FieldOffset(80)] public bool bEnableSwarmDebugging;
        [FieldOffset(84)] byte SimplygonSwarmDelay; //TODO: numeric uint32 SimplygonSwarmDelay
        [FieldOffset(88)] byte SwarmNumOfConcurrentJobs; //TODO: numeric uint32 SwarmNumOfConcurrentJobs
        [FieldOffset(92)] byte SwarmMaxUploadChunkSizeInMB; //TODO: numeric uint32 SwarmMaxUploadChunkSizeInMB
        [FieldOffset(96)] byte SwarmIntermediateFolder; //TODO: string FString SwarmIntermediateFolder
        [FieldOffset(112)] public bool bAutomaticallyHotReloadNewClasses;
        [FieldOffset(112)] public bool bShowCompilerLogOnCompileError;
        [FieldOffset(112)] public bool bShowImportDialogAtReimport;
        [FieldOffset(120)] public DirectoryPath DataSourceFolder;
        [FieldOffset(136)] public bool bKeepAttachHierarchy;
        [FieldOffset(136)] public bool bAnimationReimportWarnings;
        [FieldOffset(136)] public bool bUseCurvesForDistributions;
        [FieldOffset(140)] public int PropertyMatrix_NumberOfPasteOperationsBeforeWarning;
        [FieldOffset(144)] public bool bSCSEditorShowGrid;
        [FieldOffset(145)] public bool bSCSEditorShowFloor;
        [FieldOffset(148)] public int SCSViewportCameraSpeed;
        [FieldOffset(152)] public bool bAutoloadCheckedOutPackages;
        [FieldOffset(152)] public bool bSuppressFullyLoadPrompt;
        [FieldOffset(152)] public bool bAllowSelectTranslucent;
        [FieldOffset(160)]  public IntPtr  BlueprintFavorites;
        [FieldOffset(168)] public int AssetViewerProfileIndex;
        [FieldOffset(176)] byte AssetViewerProfileName; //TODO: string FString AssetViewerProfileName
        [FieldOffset(192)] public int MaterialQualityLevel;
    }
    internal unsafe struct EditorPerProjectUserSettings_methods {
    }
    internal unsafe struct EditorPerProjectUserSettings_events {
    }
}
