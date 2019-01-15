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
    [StructLayout( LayoutKind.Explicit, Size=152 )]
    internal unsafe struct PersonaOptions_fields {
        [FieldOffset(56)] public bool bAutoAlignFloorToMesh;
        [FieldOffset(56)] public bool bShowGrid;
        [FieldOffset(56)] public bool bHighlightOrigin;
        [FieldOffset(56)] public bool bMuteAudio;
        [FieldOffset(56)] public bool bUseAudioAttenuation;
        [FieldOffset(60)] public int ShowMeshStats;
        [FieldOffset(64)] byte DefaultLocalAxesSelection; //TODO: numeric uint32 DefaultLocalAxesSelection
        [FieldOffset(68)] byte DefaultBoneDrawSelection; //TODO: numeric uint32 DefaultBoneDrawSelection
        [FieldOffset(72)] public LinearColor SectionTimingNodeColor;
        [FieldOffset(88)] public LinearColor NotifyTimingNodeColor;
        [FieldOffset(104)] public LinearColor BranchingPointTimingNodeColor;
        [FieldOffset(120)] public bool bUseInlineSocketEditor;
        [FieldOffset(121)] public bool bFlattenSkeletonHierarchyWhenFiltering;
        [FieldOffset(122)] public bool bHideParentsWhenFiltering;
        [FieldOffset(123)] public bool bAllowPreviewMeshCollectionsToSelectFromDifferentSkeletons;
        [FieldOffset(124)] public bool bAllowMeshSectionSelection;
        [FieldOffset(128)] byte NumFolderFiltersInAssetBrowser; //TODO: numeric uint32 NumFolderFiltersInAssetBrowser
        [FieldOffset(136)] public NativeArray AssetEditorOptions;
    }
    internal unsafe struct PersonaOptions_methods {
    }
    internal unsafe struct PersonaOptions_events {
    }
}
