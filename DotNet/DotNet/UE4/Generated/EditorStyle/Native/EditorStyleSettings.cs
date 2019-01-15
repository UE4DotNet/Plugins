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

using UE4.SlateCore;

namespace UE4.EditorStyle.Native {
    [StructLayout( LayoutKind.Explicit, Size=672 )]
    internal unsafe struct EditorStyleSettings_fields {
        [FieldOffset(56)] public bool bEnableHighDPIAwareness;
        [FieldOffset(57)] byte ColorVisionDeficiencyPreviewType; //TODO: enum EColorVisionDeficiency ColorVisionDeficiencyPreviewType
        [FieldOffset(60)] public int ColorVisionDeficiencySeverity;
        [FieldOffset(64)] public bool bColorVisionDeficiencyCorrection;
        [FieldOffset(65)] public bool bColorVisionDeficiencyCorrectionPreviewWithDeficiency;
        [FieldOffset(68)] public LinearColor SelectionColor;
        [FieldOffset(84)] public LinearColor PressedSelectionColor;
        [FieldOffset(100)] public LinearColor InactiveSelectionColor;
        [FieldOffset(116)] public LinearColor KeyboardFocusColor;
        [FieldOffset(132)] public LinearColor EditorWindowBackgroundColor;
        [FieldOffset(152)] public SlateBrush EditorMainWindowBackgroundOverride;
        [FieldOffset(312)] public SlateBrush EditorChildWindowBackgroundOverride;
        [FieldOffset(472)] public bool bResetEditorWindowBackgroundSettings;
        [FieldOffset(476)] public bool bUseSmallToolBarIcons;
        [FieldOffset(476)] public bool bUseGrid;
        [FieldOffset(480)] public LinearColor RegularColor;
        [FieldOffset(496)] public LinearColor RuleColor;
        [FieldOffset(512)] public LinearColor CenterColor;
        [FieldOffset(528)] byte GridSnapSize; //TODO: numeric uint32 GridSnapSize
        [FieldOffset(532)] public bool bEnableWindowAnimations;
        [FieldOffset(532)] public bool bShowFriendlyNames;
        [FieldOffset(532)] public bool bExpandConfigurationMenus;
        [FieldOffset(532)] public bool bShowProjectMenus;
        [FieldOffset(532)] public bool bShowLaunchMenus;
        [FieldOffset(536)] public LinearColor LogBackgroundColor;
        [FieldOffset(552)] public LinearColor LogSelectionBackgroundColor;
        [FieldOffset(568)] public LinearColor LogNormalColor;
        [FieldOffset(584)] public LinearColor LogCommandColor;
        [FieldOffset(600)] public LinearColor LogWarningColor;
        [FieldOffset(616)] public LinearColor LogErrorColor;
        [FieldOffset(632)] public bool bShowAllAdvancedDetails;
        [FieldOffset(632)] public bool bShowHiddenPropertiesWhilePlaying;
        [FieldOffset(636)] public int LogFontSize;
        [FieldOffset(640)] public byte LogTimestampMode;
        [FieldOffset(641)] public bool bPromoteOutputLogWarningsDuringPIE;
        [FieldOffset(642)] byte AssetEditorOpenLocation; //TODO: enum EAssetEditorOpenLocation AssetEditorOpenLocation
        [FieldOffset(644)] public bool bEnableColorizedEditorTabs;
    }
    internal unsafe struct EditorStyleSettings_methods {
    }
    internal unsafe struct EditorStyleSettings_events {
    }
}
