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


namespace UE4.BlueprintGraph.Native {
    [StructLayout( LayoutKind.Explicit, Size=184 )]
    internal unsafe struct BlueprintEditorSettings_fields {
        [FieldOffset(56)] public bool bDrawMidpointArrowsInBlueprints;
        [FieldOffset(57)] public bool bShowGraphInstructionText;
        [FieldOffset(58)] public bool bSplitContextTargetSettings;
        [FieldOffset(59)] public bool bExposeAllMemberComponentFunctions;
        [FieldOffset(60)] public bool bShowContextualFavorites;
        [FieldOffset(61)] public bool bCompactCallOnMemberNodes;
        [FieldOffset(62)] public bool bFlattenFavoritesMenus;
        [FieldOffset(63)] public bool bFavorPureCastNodes;
        [FieldOffset(64)] public bool bAutoCastObjectConnections;
        [FieldOffset(65)] public bool bShowViewportOnSimulate;
        [FieldOffset(66)] public bool bShowInheritedVariables;
        [FieldOffset(67)] public bool bShowEmptySections;
        [FieldOffset(68)] public bool bSpawnDefaultBlueprintNodes;
        [FieldOffset(69)] public bool bHideConstructionScriptComponentsInDetailsView;
        [FieldOffset(70)] public bool bHostFindInBlueprintsInGlobalTab;
        [FieldOffset(71)] public bool bNavigateToNativeFunctionsFromCallNodes;
        [FieldOffset(72)] byte Bookmarks; //TODO: map TMap Bookmarks
        [FieldOffset(152)] public NativeArray BookmarkNodes;
        [FieldOffset(168)] public bool bIncludeCommentNodesInBookmarksTab;
        [FieldOffset(169)] public bool bShowBookmarksForCurrentDocumentOnlyInTab;
        [FieldOffset(170)] public byte SaveOnCompile;
        [FieldOffset(171)] public bool bJumpToNodeErrors;
        [FieldOffset(172)] public bool bAllowExplicitImpureNodeDisabling;
        [FieldOffset(173)] public bool bShowActionMenuItemSignatures;
        [FieldOffset(174)] public bool bBlueprintNodeUniqueNames;
        [FieldOffset(175)] public bool bShowDetailedCompileResults;
        [FieldOffset(176)] public int CompileEventDisplayThresholdMs;
        [FieldOffset(180)] public float NodeTemplateCacheCapMB;
    }
    internal unsafe struct BlueprintEditorSettings_methods {
    }
    internal unsafe struct BlueprintEditorSettings_events {
    }
}
