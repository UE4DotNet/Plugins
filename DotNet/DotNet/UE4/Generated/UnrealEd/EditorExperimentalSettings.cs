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
using UE4.UnrealEd.Native;

namespace UE4.UnrealEd {
    ///<summary>Implements Editor settings for experimental features.</summary>
    public unsafe partial class EditorExperimentalSettings : UObject  {
        public bool bProceduralFoliage {
            get {return Main.GetGetBoolPropertyByName(this, "bProceduralFoliage"); }
            set {Main.SetGetBoolPropertyByName(this, "bProceduralFoliage", value); }
        }
        public bool bEnableLocalizationDashboard {
            get {return Main.GetGetBoolPropertyByName(this, "bEnableLocalizationDashboard"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnableLocalizationDashboard", value); }
        }
        public bool bEnableTranslationPicker {
            get {return Main.GetGetBoolPropertyByName(this, "bEnableTranslationPicker"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnableTranslationPicker", value); }
        }
        public bool bEnableEditorUtilityBlueprints {
            get {return Main.GetGetBoolPropertyByName(this, "bEnableEditorUtilityBlueprints"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnableEditorUtilityBlueprints", value); }
        }
        public bool bEnableFavoriteSystem {
            get {return Main.GetGetBoolPropertyByName(this, "bEnableFavoriteSystem"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnableFavoriteSystem", value); }
        }
        public bool bDeviceOutputLog {
            get {return Main.GetGetBoolPropertyByName(this, "bDeviceOutputLog"); }
            set {Main.SetGetBoolPropertyByName(this, "bDeviceOutputLog", value); }
        }
        ///<summary>Specify which console-specific nomenclature to use for gamepad label text</summary>
        public unsafe byte ConsoleForGamepadLabels {
            get {return EditorExperimentalSettings_ptr->ConsoleForGamepadLabels;}
            set {EditorExperimentalSettings_ptr->ConsoleForGamepadLabels = value;}
        }
        public bool bToolbarCustomization {
            get {return Main.GetGetBoolPropertyByName(this, "bToolbarCustomization"); }
            set {Main.SetGetBoolPropertyByName(this, "bToolbarCustomization", value); }
        }
        public bool bBreakOnExceptions {
            get {return Main.GetGetBoolPropertyByName(this, "bBreakOnExceptions"); }
            set {Main.SetGetBoolPropertyByName(this, "bBreakOnExceptions", value); }
        }
        public bool bEnableFindAndReplaceReferences {
            get {return Main.GetGetBoolPropertyByName(this, "bEnableFindAndReplaceReferences"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnableFindAndReplaceReferences", value); }
        }
        public bool bDrawMidpointArrowsInBlueprints {
            get {return Main.GetGetBoolPropertyByName(this, "bDrawMidpointArrowsInBlueprints"); }
            set {Main.SetGetBoolPropertyByName(this, "bDrawMidpointArrowsInBlueprints", value); }
        }
        public bool bContextMenuChunkAssignments {
            get {return Main.GetGetBoolPropertyByName(this, "bContextMenuChunkAssignments"); }
            set {Main.SetGetBoolPropertyByName(this, "bContextMenuChunkAssignments", value); }
        }
        public bool bDisableCookInEditor {
            get {return Main.GetGetBoolPropertyByName(this, "bDisableCookInEditor"); }
            set {Main.SetGetBoolPropertyByName(this, "bDisableCookInEditor", value); }
        }
        public bool bSharedCookedBuilds {
            get {return Main.GetGetBoolPropertyByName(this, "bSharedCookedBuilds"); }
            set {Main.SetGetBoolPropertyByName(this, "bSharedCookedBuilds", value); }
        }
        ///<summary>Multi Process Cooking</summary>
        public unsafe int MultiProcessCooking {
            get {return EditorExperimentalSettings_ptr->MultiProcessCooking;}
            set {EditorExperimentalSettings_ptr->MultiProcessCooking = value;}
        }
        public bool bEQSEditor {
            get {return Main.GetGetBoolPropertyByName(this, "bEQSEditor"); }
            set {Main.SetGetBoolPropertyByName(this, "bEQSEditor", value); }
        }
        public bool bAllowLateJoinInPIE {
            get {return Main.GetGetBoolPropertyByName(this, "bAllowLateJoinInPIE"); }
            set {Main.SetGetBoolPropertyByName(this, "bAllowLateJoinInPIE", value); }
        }
        public bool bAllowVulkanPreview {
            get {return Main.GetGetBoolPropertyByName(this, "bAllowVulkanPreview"); }
            set {Main.SetGetBoolPropertyByName(this, "bAllowVulkanPreview", value); }
        }
        public bool bEnableMultithreadedLightmapEncoding {
            get {return Main.GetGetBoolPropertyByName(this, "bEnableMultithreadedLightmapEncoding"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnableMultithreadedLightmapEncoding", value); }
        }
        public bool bEnableMultithreadedShadowmapEncoding {
            get {return Main.GetGetBoolPropertyByName(this, "bEnableMultithreadedShadowmapEncoding"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnableMultithreadedShadowmapEncoding", value); }
        }
        public bool bUseOpenCLForConvexHullDecomp {
            get {return Main.GetGetBoolPropertyByName(this, "bUseOpenCLForConvexHullDecomp"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseOpenCLForConvexHullDecomp", value); }
        }
        public bool bAllowPotentiallyUnsafePropertyEditing {
            get {return Main.GetGetBoolPropertyByName(this, "bAllowPotentiallyUnsafePropertyEditing"); }
            set {Main.SetGetBoolPropertyByName(this, "bAllowPotentiallyUnsafePropertyEditing", value); }
        }
        public bool bFacialAnimationImporter {
            get {return Main.GetGetBoolPropertyByName(this, "bFacialAnimationImporter"); }
            set {Main.SetGetBoolPropertyByName(this, "bFacialAnimationImporter", value); }
        }
        public bool bEnableLiveRecompilationOfAnimationBlueprints {
            get {return Main.GetGetBoolPropertyByName(this, "bEnableLiveRecompilationOfAnimationBlueprints"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnableLiveRecompilationOfAnimationBlueprints", value); }
        }
        public bool bMobilePIEPreviewDeviceLaunch {
            get {return Main.GetGetBoolPropertyByName(this, "bMobilePIEPreviewDeviceLaunch"); }
            set {Main.SetGetBoolPropertyByName(this, "bMobilePIEPreviewDeviceLaunch", value); }
        }
        public bool bTextAssetFormatSupport {
            get {return Main.GetGetBoolPropertyByName(this, "bTextAssetFormatSupport"); }
            set {Main.SetGetBoolPropertyByName(this, "bTextAssetFormatSupport", value); }
        }
        public bool bExampleLayersAndBlends {
            get {return Main.GetGetBoolPropertyByName(this, "bExampleLayersAndBlends"); }
            set {Main.SetGetBoolPropertyByName(this, "bExampleLayersAndBlends", value); }
        }
        static EditorExperimentalSettings() {
            StaticClass = Main.GetClass("EditorExperimentalSettings");
        }
        internal unsafe EditorExperimentalSettings_fields* EditorExperimentalSettings_ptr => (EditorExperimentalSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator EditorExperimentalSettings(IntPtr p) => UObject.Make<EditorExperimentalSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static EditorExperimentalSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static EditorExperimentalSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
