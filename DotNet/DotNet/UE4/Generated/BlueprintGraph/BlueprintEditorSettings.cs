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

#pragma warning disable CS0108
using UE4.BlueprintGraph.Native;

namespace UE4.BlueprintGraph {
    ///<summary>Blueprint Editor Settings</summary>
    public unsafe partial class BlueprintEditorSettings : UObject  {
        public bool bDrawMidpointArrowsInBlueprints {
            get {return Main.GetGetBoolPropertyByName(this, "bDrawMidpointArrowsInBlueprints"); }
            set {Main.SetGetBoolPropertyByName(this, "bDrawMidpointArrowsInBlueprints", value); }
        }
        public bool bShowGraphInstructionText {
            get {return Main.GetGetBoolPropertyByName(this, "bShowGraphInstructionText"); }
            set {Main.SetGetBoolPropertyByName(this, "bShowGraphInstructionText", value); }
        }
        public bool bSplitContextTargetSettings {
            get {return Main.GetGetBoolPropertyByName(this, "bSplitContextTargetSettings"); }
            set {Main.SetGetBoolPropertyByName(this, "bSplitContextTargetSettings", value); }
        }
        public bool bExposeAllMemberComponentFunctions {
            get {return Main.GetGetBoolPropertyByName(this, "bExposeAllMemberComponentFunctions"); }
            set {Main.SetGetBoolPropertyByName(this, "bExposeAllMemberComponentFunctions", value); }
        }
        public bool bShowContextualFavorites {
            get {return Main.GetGetBoolPropertyByName(this, "bShowContextualFavorites"); }
            set {Main.SetGetBoolPropertyByName(this, "bShowContextualFavorites", value); }
        }
        public bool bCompactCallOnMemberNodes {
            get {return Main.GetGetBoolPropertyByName(this, "bCompactCallOnMemberNodes"); }
            set {Main.SetGetBoolPropertyByName(this, "bCompactCallOnMemberNodes", value); }
        }
        public bool bFlattenFavoritesMenus {
            get {return Main.GetGetBoolPropertyByName(this, "bFlattenFavoritesMenus"); }
            set {Main.SetGetBoolPropertyByName(this, "bFlattenFavoritesMenus", value); }
        }
        public bool bFavorPureCastNodes {
            get {return Main.GetGetBoolPropertyByName(this, "bFavorPureCastNodes"); }
            set {Main.SetGetBoolPropertyByName(this, "bFavorPureCastNodes", value); }
        }
        public bool bAutoCastObjectConnections {
            get {return Main.GetGetBoolPropertyByName(this, "bAutoCastObjectConnections"); }
            set {Main.SetGetBoolPropertyByName(this, "bAutoCastObjectConnections", value); }
        }
        public bool bShowViewportOnSimulate {
            get {return Main.GetGetBoolPropertyByName(this, "bShowViewportOnSimulate"); }
            set {Main.SetGetBoolPropertyByName(this, "bShowViewportOnSimulate", value); }
        }
        public bool bShowInheritedVariables {
            get {return Main.GetGetBoolPropertyByName(this, "bShowInheritedVariables"); }
            set {Main.SetGetBoolPropertyByName(this, "bShowInheritedVariables", value); }
        }
        public bool bShowEmptySections {
            get {return Main.GetGetBoolPropertyByName(this, "bShowEmptySections"); }
            set {Main.SetGetBoolPropertyByName(this, "bShowEmptySections", value); }
        }
        public bool bSpawnDefaultBlueprintNodes {
            get {return Main.GetGetBoolPropertyByName(this, "bSpawnDefaultBlueprintNodes"); }
            set {Main.SetGetBoolPropertyByName(this, "bSpawnDefaultBlueprintNodes", value); }
        }
        public bool bHideConstructionScriptComponentsInDetailsView {
            get {return Main.GetGetBoolPropertyByName(this, "bHideConstructionScriptComponentsInDetailsView"); }
            set {Main.SetGetBoolPropertyByName(this, "bHideConstructionScriptComponentsInDetailsView", value); }
        }
        public bool bHostFindInBlueprintsInGlobalTab {
            get {return Main.GetGetBoolPropertyByName(this, "bHostFindInBlueprintsInGlobalTab"); }
            set {Main.SetGetBoolPropertyByName(this, "bHostFindInBlueprintsInGlobalTab", value); }
        }
        public bool bNavigateToNativeFunctionsFromCallNodes {
            get {return Main.GetGetBoolPropertyByName(this, "bNavigateToNativeFunctionsFromCallNodes"); }
            set {Main.SetGetBoolPropertyByName(this, "bNavigateToNativeFunctionsFromCallNodes", value); }
        }
         //TODO: map TMap Bookmarks
         //TODO: array not UObject TArray BookmarkNodes
        public bool bIncludeCommentNodesInBookmarksTab {
            get {return Main.GetGetBoolPropertyByName(this, "bIncludeCommentNodesInBookmarksTab"); }
            set {Main.SetGetBoolPropertyByName(this, "bIncludeCommentNodesInBookmarksTab", value); }
        }
        public bool bShowBookmarksForCurrentDocumentOnlyInTab {
            get {return Main.GetGetBoolPropertyByName(this, "bShowBookmarksForCurrentDocumentOnlyInTab"); }
            set {Main.SetGetBoolPropertyByName(this, "bShowBookmarksForCurrentDocumentOnlyInTab", value); }
        }
         //TODO: map TMap GraphEditorQuickJumps
        ///<summary>Determines when to save Blueprints post-compile</summary>
        public unsafe byte SaveOnCompile {
            get {return BlueprintEditorSettings_ptr->SaveOnCompile;}
            set {BlueprintEditorSettings_ptr->SaveOnCompile = value;}
        }
        public bool bJumpToNodeErrors {
            get {return Main.GetGetBoolPropertyByName(this, "bJumpToNodeErrors"); }
            set {Main.SetGetBoolPropertyByName(this, "bJumpToNodeErrors", value); }
        }
        public bool bAllowExplicitImpureNodeDisabling {
            get {return Main.GetGetBoolPropertyByName(this, "bAllowExplicitImpureNodeDisabling"); }
            set {Main.SetGetBoolPropertyByName(this, "bAllowExplicitImpureNodeDisabling", value); }
        }
        public bool bShowActionMenuItemSignatures {
            get {return Main.GetGetBoolPropertyByName(this, "bShowActionMenuItemSignatures"); }
            set {Main.SetGetBoolPropertyByName(this, "bShowActionMenuItemSignatures", value); }
        }
        public bool bBlueprintNodeUniqueNames {
            get {return Main.GetGetBoolPropertyByName(this, "bBlueprintNodeUniqueNames"); }
            set {Main.SetGetBoolPropertyByName(this, "bBlueprintNodeUniqueNames", value); }
        }
        public bool bShowDetailedCompileResults {
            get {return Main.GetGetBoolPropertyByName(this, "bShowDetailedCompileResults"); }
            set {Main.SetGetBoolPropertyByName(this, "bShowDetailedCompileResults", value); }
        }
        ///<summary>Minimum event time threshold used as a filter when additional details are enabled for display in the Compiler Results tab. A value of zero means that all events will be included in the final summary.</summary>
        public unsafe int CompileEventDisplayThresholdMs {
            get {return BlueprintEditorSettings_ptr->CompileEventDisplayThresholdMs;}
            set {BlueprintEditorSettings_ptr->CompileEventDisplayThresholdMs = value;}
        }
        ///<summary>The node template cache is used to speed up blueprint menuing. This determines the peak data size for that cache.</summary>
        public unsafe float NodeTemplateCacheCapMB {
            get {return BlueprintEditorSettings_ptr->NodeTemplateCacheCapMB;}
            set {BlueprintEditorSettings_ptr->NodeTemplateCacheCapMB = value;}
        }
        static BlueprintEditorSettings() {
            StaticClass = Main.GetClass("BlueprintEditorSettings");
        }
        internal unsafe BlueprintEditorSettings_fields* BlueprintEditorSettings_ptr => (BlueprintEditorSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BlueprintEditorSettings(IntPtr p) => UObject.Make<BlueprintEditorSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BlueprintEditorSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BlueprintEditorSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
