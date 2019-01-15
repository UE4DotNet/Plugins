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
    [StructLayout( LayoutKind.Explicit, Size=264 )]
    internal unsafe struct AssetManagerSettings_fields {
        [FieldOffset(80)] public NativeArray PrimaryAssetTypesToScan;
        [FieldOffset(96)] public NativeArray DirectoriesToExclude;
        [FieldOffset(112)] public NativeArray PrimaryAssetRules;
        [FieldOffset(128)] public bool bOnlyCookProductionAssets;
        [FieldOffset(129)] public bool bShouldManagerDetermineTypeAndName;
        [FieldOffset(130)] public bool bShouldGuessTypeAndNameInEditor;
        [FieldOffset(131)] public bool bShouldAcquireMissingChunksOnLoad;
        [FieldOffset(136)] public NativeArray PrimaryAssetIdRedirects;
        [FieldOffset(152)] public NativeArray PrimaryAssetTypeRedirects;
        [FieldOffset(168)] public NativeArray AssetPathRedirects;
        [FieldOffset(184)] byte MetaDataTagsForAssetRegistry; //TODO: set TSet MetaDataTagsForAssetRegistry
    }
    internal unsafe struct AssetManagerSettings_methods {
    }
    internal unsafe struct AssetManagerSettings_events {
    }
}
