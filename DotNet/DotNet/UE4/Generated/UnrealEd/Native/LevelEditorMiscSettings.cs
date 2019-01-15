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
    [StructLayout( LayoutKind.Explicit, Size=120 )]
    internal unsafe struct LevelEditorMiscSettings_fields {
        [FieldOffset(80)] public bool bAutoApplyLightingEnable;
        [FieldOffset(80)] public bool bBSPAutoUpdate;
        [FieldOffset(80)] public bool bAutoMoveBSPPivotOffset;
        [FieldOffset(80)] public bool bNavigationAutoUpdate;
        [FieldOffset(80)] public bool bReplaceRespectsScale;
        [FieldOffset(80)] public bool bAllowBackgroundAudio;
        [FieldOffset(80)] public bool bEnableRealTimeAudio;
        [FieldOffset(84)] public float EditorVolumeLevel;
        [FieldOffset(88)] public bool bEnableEditorSounds;
        [FieldOffset(96)] public IntPtr DefaultLevelStreamingClass;
        [FieldOffset(104)] public DirectoryPath EditorScreenshotSaveDirectory;
    }
    internal unsafe struct LevelEditorMiscSettings_methods {
    }
    internal unsafe struct LevelEditorMiscSettings_events {
    }
}
