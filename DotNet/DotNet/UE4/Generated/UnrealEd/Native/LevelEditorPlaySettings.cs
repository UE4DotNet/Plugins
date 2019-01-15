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

namespace UE4.UnrealEd.Native {
    [StructLayout( LayoutKind.Explicit, Size=432 )]
    internal unsafe struct LevelEditorPlaySettings_fields {
        [FieldOffset(56)] byte PlayFromHerePlayerStartClassName; //TODO: string FString PlayFromHerePlayerStartClassName
        [FieldOffset(72)] public bool GameGetsMouseControl;
        [FieldOffset(73)] public bool UseMouseForTouch;
        [FieldOffset(74)] public bool ShowMouseControlLabel;
        [FieldOffset(75)] public byte MouseControlLabelPosition;
        [FieldOffset(76)] public bool ViewportGetsHMDControl;
        [FieldOffset(77)] public bool ShouldMinimizeEditorOnVRPIE;
        [FieldOffset(78)] public bool AutoRecompileBlueprints;
        [FieldOffset(79)] public bool EnableGameSound;
        [FieldOffset(80)] public bool EnablePIEEnterAndExitSounds;
        [FieldOffset(84)] public int PlayInEditorSoundQualityLevel;
        [FieldOffset(88)] public bool bOnlyLoadVisibleLevelsInPIE;
        [FieldOffset(88)] public bool bPreferToStreamLevelsInPIE;
        [FieldOffset(92)] public int NewWindowWidth;
        [FieldOffset(96)] public int NewWindowHeight;
        [FieldOffset(100)] public IntPoint NewWindowPosition;
        [FieldOffset(108)] public bool CenterNewWindow;
        [FieldOffset(108)] public bool bBindSequencerToPIE;
        [FieldOffset(108)] public bool bBindSequencerToSimulate;
        [FieldOffset(108)] public bool PIEAlwaysOnTop;
        [FieldOffset(108)] public bool DisableStandaloneSound;
        [FieldOffset(112)] byte AdditionalLaunchParameters; //TODO: string FString AdditionalLaunchParameters
        [FieldOffset(128)] public byte BuildGameBeforeLaunch;
        [FieldOffset(129)] public byte LaunchConfiguration;
        [FieldOffset(130)] public bool bAutoCompileBlueprintsOnLaunch;
        [FieldOffset(152)] public byte PlayNetMode;
        [FieldOffset(153)] public bool RunUnderOneProcess;
        [FieldOffset(154)] public bool PlayNetDedicated;
        [FieldOffset(156)] public int PlayNumberOfClients;
        [FieldOffset(160)] byte ServerPort; //TODO: numeric uint16 ServerPort
        [FieldOffset(164)] public int ClientWindowWidth;
        [FieldOffset(168)] public bool AutoConnectToServer;
        [FieldOffset(169)] public bool RouteGamepadToSecondWindow;
        [FieldOffset(170)] public bool CreateAudioDeviceForEveryPlayer;
        [FieldOffset(172)] public int ClientWindowHeight;
        [FieldOffset(176)] byte AdditionalServerGameOptions; //TODO: string FString AdditionalServerGameOptions
        [FieldOffset(192)] byte AdditionalLaunchOptions; //TODO: string FString AdditionalLaunchOptions
        [FieldOffset(208)] public int MultipleInstanceLastHeight;
        [FieldOffset(212)] public int MultipleInstanceLastWidth;
        [FieldOffset(216)] public NativeArray MultipleInstancePositions;
        [FieldOffset(232)] byte LastExecutedLaunchDevice; //TODO: string FString LastExecutedLaunchDevice
        [FieldOffset(248)] byte LastExecutedLaunchName; //TODO: string FString LastExecutedLaunchName
        [FieldOffset(264)] public byte LastExecutedLaunchModeType;
        [FieldOffset(265)] public byte LastExecutedPlayModeLocation;
        [FieldOffset(266)] public byte LastExecutedPlayModeType;
        [FieldOffset(272)] byte LastExecutedPIEPreviewDevice; //TODO: string FString LastExecutedPIEPreviewDevice
        [FieldOffset(288)] public NativeArray LaptopScreenResolutions;
        [FieldOffset(304)] public NativeArray MonitorScreenResolutions;
        [FieldOffset(320)] public NativeArray PhoneScreenResolutions;
        [FieldOffset(336)] public NativeArray TabletScreenResolutions;
        [FieldOffset(352)] public NativeArray TelevisionScreenResolutions;
        [FieldOffset(368)] byte DeviceToEmulate; //TODO: string FString DeviceToEmulate
        [FieldOffset(384)] public Margin PIESafeZoneOverride;
        [FieldOffset(400)] public NativeArray CustomUnsafeZoneStarts;
        [FieldOffset(416)] public NativeArray CustomUnsafeZoneDimensions;
    }
    internal unsafe struct LevelEditorPlaySettings_methods {
    }
    internal unsafe struct LevelEditorPlaySettings_events {
    }
}
