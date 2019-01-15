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
    [StructLayout( LayoutKind.Explicit, Size=224 )]
    internal unsafe struct HierarchicalLODSettings_fields {
        [FieldOffset(80)] public bool bForceSettingsInAllMaps;
        [FieldOffset(88)] byte DefaultSetup; //TODO: soft class TSoftClassPtr<UHierarchicalLODSetup>  DefaultSetup
        [FieldOffset(136)] public NativeArray DirectoriesForHLODCommandlet;
        [FieldOffset(152)] public NativeArray MapsToBuild;
        [FieldOffset(168)] public bool bInvalidateHLODClusters;
        [FieldOffset(169)] public bool bDeleteHLODAssets;
        [FieldOffset(176)] byte BaseMaterial; //TODO: soft object TSoftObjectPtr<UMaterialInterface> BaseMaterial
    }
    internal unsafe struct HierarchicalLODSettings_methods {
    }
    internal unsafe struct HierarchicalLODSettings_events {
    }
}
