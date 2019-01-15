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
using UE4.EditorStyle.Native;
using UE4.SlateCore;

namespace UE4.EditorStyle {
    ///<summary>Implements the Editor style settings.</summary>
    public unsafe partial class EditorStyleSettings : UObject  {
        public bool bEnableHighDPIAwareness {
            get {return Main.GetGetBoolPropertyByName(this, "bEnableHighDPIAwareness"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnableHighDPIAwareness", value); }
        }
         //TODO: enum EColorVisionDeficiency ColorVisionDeficiencyPreviewType
        ///<summary>Color Vision Deficiency Severity</summary>
        public unsafe int ColorVisionDeficiencySeverity {
            get {return EditorStyleSettings_ptr->ColorVisionDeficiencySeverity;}
            set {EditorStyleSettings_ptr->ColorVisionDeficiencySeverity = value;}
        }
        public bool bColorVisionDeficiencyCorrection {
            get {return Main.GetGetBoolPropertyByName(this, "bColorVisionDeficiencyCorrection"); }
            set {Main.SetGetBoolPropertyByName(this, "bColorVisionDeficiencyCorrection", value); }
        }
        public bool bColorVisionDeficiencyCorrectionPreviewWithDeficiency {
            get {return Main.GetGetBoolPropertyByName(this, "bColorVisionDeficiencyCorrectionPreviewWithDeficiency"); }
            set {Main.SetGetBoolPropertyByName(this, "bColorVisionDeficiencyCorrectionPreviewWithDeficiency", value); }
        }
        ///<summary>The color used to represent selection</summary>
        public unsafe LinearColor SelectionColor {
            get {return EditorStyleSettings_ptr->SelectionColor;}
            set {EditorStyleSettings_ptr->SelectionColor = value;}
        }
        ///<summary>The color used to represent a pressed item</summary>
        public unsafe LinearColor PressedSelectionColor {
            get {return EditorStyleSettings_ptr->PressedSelectionColor;}
            set {EditorStyleSettings_ptr->PressedSelectionColor = value;}
        }
        ///<summary>The color used to represent selected items that are currently inactive</summary>
        public unsafe LinearColor InactiveSelectionColor {
            get {return EditorStyleSettings_ptr->InactiveSelectionColor;}
            set {EditorStyleSettings_ptr->InactiveSelectionColor = value;}
        }
        ///<summary>The color used to represent keyboard input selection focus</summary>
        public unsafe LinearColor KeyboardFocusColor {
            get {return EditorStyleSettings_ptr->KeyboardFocusColor;}
            set {EditorStyleSettings_ptr->KeyboardFocusColor = value;}
        }
        ///<summary>The color used to tint the editor window backgrounds</summary>
        public unsafe LinearColor EditorWindowBackgroundColor {
            get {return EditorStyleSettings_ptr->EditorWindowBackgroundColor;}
            set {EditorStyleSettings_ptr->EditorWindowBackgroundColor = value;}
        }
        ///<summary>The override for the background of the main window (if not modified, the defaults will be used)</summary>
        public unsafe SlateBrush EditorMainWindowBackgroundOverride {
            get {return EditorStyleSettings_ptr->EditorMainWindowBackgroundOverride;}
            set {EditorStyleSettings_ptr->EditorMainWindowBackgroundOverride = value;}
        }
        ///<summary>The override for the background of the child window (if not modified, the defaults will be used)</summary>
        public unsafe SlateBrush EditorChildWindowBackgroundOverride {
            get {return EditorStyleSettings_ptr->EditorChildWindowBackgroundOverride;}
            set {EditorStyleSettings_ptr->EditorChildWindowBackgroundOverride = value;}
        }
        public bool bResetEditorWindowBackgroundSettings {
            get {return Main.GetGetBoolPropertyByName(this, "bResetEditorWindowBackgroundSettings"); }
            set {Main.SetGetBoolPropertyByName(this, "bResetEditorWindowBackgroundSettings", value); }
        }
        public bool bUseSmallToolBarIcons {
            get {return Main.GetGetBoolPropertyByName(this, "bUseSmallToolBarIcons"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseSmallToolBarIcons", value); }
        }
        public bool bUseGrid {
            get {return Main.GetGetBoolPropertyByName(this, "bUseGrid"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseGrid", value); }
        }
        ///<summary>The color used to represent regular grid lines</summary>
        public unsafe LinearColor RegularColor {
            get {return EditorStyleSettings_ptr->RegularColor;}
            set {EditorStyleSettings_ptr->RegularColor = value;}
        }
        ///<summary>The color used to represent ruler lines in the grid</summary>
        public unsafe LinearColor RuleColor {
            get {return EditorStyleSettings_ptr->RuleColor;}
            set {EditorStyleSettings_ptr->RuleColor = value;}
        }
        ///<summary>The color used to represent the center lines in the grid</summary>
        public unsafe LinearColor CenterColor {
            get {return EditorStyleSettings_ptr->CenterColor;}
            set {EditorStyleSettings_ptr->CenterColor = value;}
        }
         //TODO: numeric uint32 GridSnapSize
        public bool bEnableWindowAnimations {
            get {return Main.GetGetBoolPropertyByName(this, "bEnableWindowAnimations"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnableWindowAnimations", value); }
        }
        public bool bShowFriendlyNames {
            get {return Main.GetGetBoolPropertyByName(this, "bShowFriendlyNames"); }
            set {Main.SetGetBoolPropertyByName(this, "bShowFriendlyNames", value); }
        }
        public bool bExpandConfigurationMenus {
            get {return Main.GetGetBoolPropertyByName(this, "bExpandConfigurationMenus"); }
            set {Main.SetGetBoolPropertyByName(this, "bExpandConfigurationMenus", value); }
        }
        public bool bShowProjectMenus {
            get {return Main.GetGetBoolPropertyByName(this, "bShowProjectMenus"); }
            set {Main.SetGetBoolPropertyByName(this, "bShowProjectMenus", value); }
        }
        public bool bShowLaunchMenus {
            get {return Main.GetGetBoolPropertyByName(this, "bShowLaunchMenus"); }
            set {Main.SetGetBoolPropertyByName(this, "bShowLaunchMenus", value); }
        }
        ///<summary>The color used for the background in the output log</summary>
        public unsafe LinearColor LogBackgroundColor {
            get {return EditorStyleSettings_ptr->LogBackgroundColor;}
            set {EditorStyleSettings_ptr->LogBackgroundColor = value;}
        }
        ///<summary>The color used for the background of selected text in the output log</summary>
        public unsafe LinearColor LogSelectionBackgroundColor {
            get {return EditorStyleSettings_ptr->LogSelectionBackgroundColor;}
            set {EditorStyleSettings_ptr->LogSelectionBackgroundColor = value;}
        }
        ///<summary>The color used for normal text in the output log</summary>
        public unsafe LinearColor LogNormalColor {
            get {return EditorStyleSettings_ptr->LogNormalColor;}
            set {EditorStyleSettings_ptr->LogNormalColor = value;}
        }
        ///<summary>The color used for normal text in the output log</summary>
        public unsafe LinearColor LogCommandColor {
            get {return EditorStyleSettings_ptr->LogCommandColor;}
            set {EditorStyleSettings_ptr->LogCommandColor = value;}
        }
        ///<summary>The color used for warning log lines</summary>
        public unsafe LinearColor LogWarningColor {
            get {return EditorStyleSettings_ptr->LogWarningColor;}
            set {EditorStyleSettings_ptr->LogWarningColor = value;}
        }
        ///<summary>The color used for error log lines</summary>
        public unsafe LinearColor LogErrorColor {
            get {return EditorStyleSettings_ptr->LogErrorColor;}
            set {EditorStyleSettings_ptr->LogErrorColor = value;}
        }
        public bool bShowAllAdvancedDetails {
            get {return Main.GetGetBoolPropertyByName(this, "bShowAllAdvancedDetails"); }
            set {Main.SetGetBoolPropertyByName(this, "bShowAllAdvancedDetails", value); }
        }
        public bool bShowHiddenPropertiesWhilePlaying {
            get {return Main.GetGetBoolPropertyByName(this, "bShowHiddenPropertiesWhilePlaying"); }
            set {Main.SetGetBoolPropertyByName(this, "bShowHiddenPropertiesWhilePlaying", value); }
        }
        ///<summary>The font size used in the output log</summary>
        public unsafe int LogFontSize {
            get {return EditorStyleSettings_ptr->LogFontSize;}
            set {EditorStyleSettings_ptr->LogFontSize = value;}
        }
        ///<summary>The display mode for timestamps in the output log</summary>
        public unsafe byte LogTimestampMode {
            get {return EditorStyleSettings_ptr->LogTimestampMode;}
            set {EditorStyleSettings_ptr->LogTimestampMode = value;}
        }
        public bool bPromoteOutputLogWarningsDuringPIE {
            get {return Main.GetGetBoolPropertyByName(this, "bPromoteOutputLogWarningsDuringPIE"); }
            set {Main.SetGetBoolPropertyByName(this, "bPromoteOutputLogWarningsDuringPIE", value); }
        }
         //TODO: enum EAssetEditorOpenLocation AssetEditorOpenLocation
        public bool bEnableColorizedEditorTabs {
            get {return Main.GetGetBoolPropertyByName(this, "bEnableColorizedEditorTabs"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnableColorizedEditorTabs", value); }
        }
        static EditorStyleSettings() {
            StaticClass = Main.GetClass("EditorStyleSettings");
        }
        internal unsafe EditorStyleSettings_fields* EditorStyleSettings_ptr => (EditorStyleSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator EditorStyleSettings(IntPtr p) => UObject.Make<EditorStyleSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static EditorStyleSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static EditorStyleSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
