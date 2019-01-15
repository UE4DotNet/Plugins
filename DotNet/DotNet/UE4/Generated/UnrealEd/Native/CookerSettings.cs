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


namespace UE4.UnrealEd.Native {
    [StructLayout( LayoutKind.Explicit, Size=176 )]
    internal unsafe struct CookerSettings_fields {
        [FieldOffset(80)] public bool bEnableCookOnTheSide;
        [FieldOffset(81)] public bool bEnableBuildDDCInBackground;
        [FieldOffset(82)] public bool bIterativeCookingForLaunchOn;
        [FieldOffset(83)] public bool bIterativeCookingForFileCookContent;
        [FieldOffset(84)] byte CookProgressDisplayMode; //TODO: enum ECookProgressDisplayMode CookProgressDisplayMode
        [FieldOffset(88)] public bool bIgnoreIniSettingsOutOfDateForIteration;
        [FieldOffset(89)] public bool bIgnoreScriptPackagesOutOfDateForIteration;
        [FieldOffset(90)] public bool bCompileBlueprintsInDevelopmentMode;
        [FieldOffset(91)] public bool bCookBlueprintComponentTemplateData;
        [FieldOffset(96)] public NativeArray ClassesExcludedOnDedicatedServer;
        [FieldOffset(112)] public NativeArray ModulesExcludedOnDedicatedServer;
        [FieldOffset(128)] public NativeArray ClassesExcludedOnDedicatedClient;
        [FieldOffset(144)] public NativeArray ModulesExcludedOnDedicatedClient;
        [FieldOffset(160)] public int DefaultPVRTCQuality;
        [FieldOffset(164)] public int DefaultASTCQualityBySpeed;
        [FieldOffset(168)] public int DefaultASTCQualityBySize;
    }
    internal unsafe struct CookerSettings_methods {
    }
    internal unsafe struct CookerSettings_events {
    }
}
