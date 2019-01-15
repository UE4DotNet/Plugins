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


namespace UE4.Engine.Native {
    [StructLayout( LayoutKind.Explicit, Size=832 )]
    internal unsafe struct AutomationTestSettings_fields {
        [FieldOffset(56)] public NativeArray EngineTestModules;
        [FieldOffset(72)] public NativeArray EditorTestModules;
        [FieldOffset(88)] public SoftObjectPath AutomationTestmap;
        [FieldOffset(120)] public NativeArray EditorPerformanceTestMaps;
        [FieldOffset(136)] public NativeArray AssetsToOpen;
        [FieldOffset(152)] public BuildPromotionTestSettings BuildPromotionTest;
        [FieldOffset(648)] public MaterialEditorPromotionSettings MaterialEditorPromotionTest;
        [FieldOffset(696)] public ParticleEditorPromotionSettings ParticleEditorPromotionTest;
        [FieldOffset(712)] public BlueprintEditorPromotionSettings BlueprintEditorPromotionTest;
        [FieldOffset(760)] public NativeArray TestLevelFolders;
        [FieldOffset(776)] public NativeArray ExternalTools;
        [FieldOffset(792)] public NativeArray ImportExportTestDefinitions;
        [FieldOffset(808)] public NativeArray LaunchOnSettings;
        [FieldOffset(824)] public IntPoint DefaultScreenshotResolution;
    }
    internal unsafe struct AutomationTestSettings_methods {
    }
    internal unsafe struct AutomationTestSettings_events {
    }
}
