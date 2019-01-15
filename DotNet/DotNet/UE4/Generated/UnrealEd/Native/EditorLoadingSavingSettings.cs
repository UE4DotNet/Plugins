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
    [StructLayout( LayoutKind.Explicit, Size=176 )]
    internal unsafe struct EditorLoadingSavingSettings_fields {
        [FieldOffset(56)] public byte LoadLevelAtStartup;
        [FieldOffset(60)] public bool bForceCompilationAtStartup;
        [FieldOffset(60)] public bool bRestoreOpenAssetTabsOnRestart;
        [FieldOffset(65)] public bool bMonitorContentDirectories;
        [FieldOffset(88)] public NativeArray AutoReimportDirectorySettings;
        [FieldOffset(104)] public float AutoReimportThreshold;
        [FieldOffset(108)] public bool bAutoCreateAssets;
        [FieldOffset(109)] public bool bAutoDeleteAssets;
        [FieldOffset(110)] public bool bDetectChangesOnStartup;
        [FieldOffset(111)] public bool bPromptBeforeAutoImporting;
        [FieldOffset(112)] public bool bDeleteSourceFilesWithAssets;
        [FieldOffset(115)] public bool bDirtyMigratedBlueprints;
        [FieldOffset(116)] public bool bAutoSaveEnable;
        [FieldOffset(116)] public bool bAutoSaveMaps;
        [FieldOffset(116)] public bool bAutoSaveContent;
        [FieldOffset(120)] public int AutoSaveTimeMinutes;
        [FieldOffset(124)] public int AutoSaveWarningInSeconds;
        [FieldOffset(128)] public bool bAutomaticallyCheckoutOnAssetModification;
        [FieldOffset(128)] public bool bPromptForCheckoutOnAssetModification;
        [FieldOffset(128)] public bool bSCCAutoAddNewFiles;
        [FieldOffset(128)] public bool bSCCUseGlobalSettings;
        [FieldOffset(136)] public FilePath TextDiffToolPath;
    }
    internal unsafe struct EditorLoadingSavingSettings_methods {
    }
    internal unsafe struct EditorLoadingSavingSettings_events {
    }
}
