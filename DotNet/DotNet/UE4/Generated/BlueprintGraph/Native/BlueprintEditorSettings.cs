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
    [StructLayout( LayoutKind.Explicit, Size=272 )]
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
        [FieldOffset(176)] byte GraphEditorQuickJumps; //TODO: map TMap GraphEditorQuickJumps
        [FieldOffset(256)] public byte SaveOnCompile;
        [FieldOffset(257)] public bool bJumpToNodeErrors;
        [FieldOffset(258)] public bool bAllowExplicitImpureNodeDisabling;
        [FieldOffset(259)] public bool bShowActionMenuItemSignatures;
        [FieldOffset(260)] public bool bBlueprintNodeUniqueNames;
        [FieldOffset(261)] public bool bShowDetailedCompileResults;
        [FieldOffset(264)] public int CompileEventDisplayThresholdMs;
        [FieldOffset(268)] public float NodeTemplateCacheCapMB;
    }
    internal unsafe struct BlueprintEditorSettings_methods {
    }
    internal unsafe struct BlueprintEditorSettings_events {
    }
}
