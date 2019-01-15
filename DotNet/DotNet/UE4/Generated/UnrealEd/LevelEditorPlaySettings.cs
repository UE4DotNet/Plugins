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
using UE4.SlateCore;

namespace UE4.UnrealEd {
    ///<summary>Implements the Editor's play settings.</summary>
    public unsafe partial class LevelEditorPlaySettings : UObject  {
         //TODO: string FString PlayFromHerePlayerStartClassName
        public bool GameGetsMouseControl {
            get {return Main.GetGetBoolPropertyByName(this, "GameGetsMouseControl"); }
            set {Main.SetGetBoolPropertyByName(this, "GameGetsMouseControl", value); }
        }
        public bool UseMouseForTouch {
            get {return Main.GetGetBoolPropertyByName(this, "UseMouseForTouch"); }
            set {Main.SetGetBoolPropertyByName(this, "UseMouseForTouch", value); }
        }
        public bool ShowMouseControlLabel {
            get {return Main.GetGetBoolPropertyByName(this, "ShowMouseControlLabel"); }
            set {Main.SetGetBoolPropertyByName(this, "ShowMouseControlLabel", value); }
        }
        ///<summary>Location on screen to anchor the mouse control label when in PIE mode.</summary>
        public unsafe byte MouseControlLabelPosition {
            get {return LevelEditorPlaySettings_ptr->MouseControlLabelPosition;}
            set {LevelEditorPlaySettings_ptr->MouseControlLabelPosition = value;}
        }
        public bool ViewportGetsHMDControl {
            get {return Main.GetGetBoolPropertyByName(this, "ViewportGetsHMDControl"); }
            set {Main.SetGetBoolPropertyByName(this, "ViewportGetsHMDControl", value); }
        }
        public bool ShouldMinimizeEditorOnVRPIE {
            get {return Main.GetGetBoolPropertyByName(this, "ShouldMinimizeEditorOnVRPIE"); }
            set {Main.SetGetBoolPropertyByName(this, "ShouldMinimizeEditorOnVRPIE", value); }
        }
        public bool AutoRecompileBlueprints {
            get {return Main.GetGetBoolPropertyByName(this, "AutoRecompileBlueprints"); }
            set {Main.SetGetBoolPropertyByName(this, "AutoRecompileBlueprints", value); }
        }
        public bool EnableGameSound {
            get {return Main.GetGetBoolPropertyByName(this, "EnableGameSound"); }
            set {Main.SetGetBoolPropertyByName(this, "EnableGameSound", value); }
        }
        public bool EnablePIEEnterAndExitSounds {
            get {return Main.GetGetBoolPropertyByName(this, "EnablePIEEnterAndExitSounds"); }
            set {Main.SetGetBoolPropertyByName(this, "EnablePIEEnterAndExitSounds", value); }
        }
        ///<summary>Which quality level to use when playing in editor</summary>
        public unsafe int PlayInEditorSoundQualityLevel {
            get {return LevelEditorPlaySettings_ptr->PlayInEditorSoundQualityLevel;}
            set {LevelEditorPlaySettings_ptr->PlayInEditorSoundQualityLevel = value;}
        }
        public bool bOnlyLoadVisibleLevelsInPIE {
            get {return Main.GetGetBoolPropertyByName(this, "bOnlyLoadVisibleLevelsInPIE"); }
            set {Main.SetGetBoolPropertyByName(this, "bOnlyLoadVisibleLevelsInPIE", value); }
        }
        public bool bPreferToStreamLevelsInPIE {
            get {return Main.GetGetBoolPropertyByName(this, "bPreferToStreamLevelsInPIE"); }
            set {Main.SetGetBoolPropertyByName(this, "bPreferToStreamLevelsInPIE", value); }
        }
        ///<summary>The width of the new view port window in pixels (0 = use the desktop's screen resolution).</summary>
        public unsafe int NewWindowWidth {
            get {return LevelEditorPlaySettings_ptr->NewWindowWidth;}
            set {LevelEditorPlaySettings_ptr->NewWindowWidth = value;}
        }
        ///<summary>The height of the new view port window in pixels (0 = use the desktop's screen resolution).</summary>
        public unsafe int NewWindowHeight {
            get {return LevelEditorPlaySettings_ptr->NewWindowHeight;}
            set {LevelEditorPlaySettings_ptr->NewWindowHeight = value;}
        }
        ///<summary>The position of the new view port window on the screen in pixels.</summary>
        public unsafe IntPoint NewWindowPosition {
            get {return LevelEditorPlaySettings_ptr->NewWindowPosition;}
            set {LevelEditorPlaySettings_ptr->NewWindowPosition = value;}
        }
        public bool CenterNewWindow {
            get {return Main.GetGetBoolPropertyByName(this, "CenterNewWindow"); }
            set {Main.SetGetBoolPropertyByName(this, "CenterNewWindow", value); }
        }
        public bool bBindSequencerToPIE {
            get {return Main.GetGetBoolPropertyByName(this, "bBindSequencerToPIE"); }
            set {Main.SetGetBoolPropertyByName(this, "bBindSequencerToPIE", value); }
        }
        public bool bBindSequencerToSimulate {
            get {return Main.GetGetBoolPropertyByName(this, "bBindSequencerToSimulate"); }
            set {Main.SetGetBoolPropertyByName(this, "bBindSequencerToSimulate", value); }
        }
        public bool PIEAlwaysOnTop {
            get {return Main.GetGetBoolPropertyByName(this, "PIEAlwaysOnTop"); }
            set {Main.SetGetBoolPropertyByName(this, "PIEAlwaysOnTop", value); }
        }
        public bool DisableStandaloneSound {
            get {return Main.GetGetBoolPropertyByName(this, "DisableStandaloneSound"); }
            set {Main.SetGetBoolPropertyByName(this, "DisableStandaloneSound", value); }
        }
         //TODO: string FString AdditionalLaunchParameters
        ///<summary>Whether to build the game before launching on device.</summary>
        public unsafe byte BuildGameBeforeLaunch {
            get {return LevelEditorPlaySettings_ptr->BuildGameBeforeLaunch;}
            set {LevelEditorPlaySettings_ptr->BuildGameBeforeLaunch = value;}
        }
        ///<summary>Which build configuration to use when launching on device.</summary>
        public unsafe byte LaunchConfiguration {
            get {return LevelEditorPlaySettings_ptr->LaunchConfiguration;}
            set {LevelEditorPlaySettings_ptr->LaunchConfiguration = value;}
        }
        public bool bAutoCompileBlueprintsOnLaunch {
            get {return Main.GetGetBoolPropertyByName(this, "bAutoCompileBlueprintsOnLaunch"); }
            set {Main.SetGetBoolPropertyByName(this, "bAutoCompileBlueprintsOnLaunch", value); }
        }
        ///<summary>NetMode to use for Play In Editor.</summary>
        public unsafe byte PlayNetMode {
            get {return LevelEditorPlaySettings_ptr->PlayNetMode;}
            set {LevelEditorPlaySettings_ptr->PlayNetMode = value;}
        }
        public bool RunUnderOneProcess {
            get {return Main.GetGetBoolPropertyByName(this, "RunUnderOneProcess"); }
            set {Main.SetGetBoolPropertyByName(this, "RunUnderOneProcess", value); }
        }
        public bool PlayNetDedicated {
            get {return Main.GetGetBoolPropertyByName(this, "PlayNetDedicated"); }
            set {Main.SetGetBoolPropertyByName(this, "PlayNetDedicated", value); }
        }
        ///<summary>The editor and listen server count as players, a dedicated server will not. Clients make up the remainder.</summary>
        public unsafe int PlayNumberOfClients {
            get {return LevelEditorPlaySettings_ptr->PlayNumberOfClients;}
            set {LevelEditorPlaySettings_ptr->PlayNumberOfClients = value;}
        }
         //TODO: numeric uint16 ServerPort
        ///<summary>Width to use when spawning additional windows.</summary>
        public unsafe int ClientWindowWidth {
            get {return LevelEditorPlaySettings_ptr->ClientWindowWidth;}
            set {LevelEditorPlaySettings_ptr->ClientWindowWidth = value;}
        }
        public bool AutoConnectToServer {
            get {return Main.GetGetBoolPropertyByName(this, "AutoConnectToServer"); }
            set {Main.SetGetBoolPropertyByName(this, "AutoConnectToServer", value); }
        }
        public bool RouteGamepadToSecondWindow {
            get {return Main.GetGetBoolPropertyByName(this, "RouteGamepadToSecondWindow"); }
            set {Main.SetGetBoolPropertyByName(this, "RouteGamepadToSecondWindow", value); }
        }
        public bool CreateAudioDeviceForEveryPlayer {
            get {return Main.GetGetBoolPropertyByName(this, "CreateAudioDeviceForEveryPlayer"); }
            set {Main.SetGetBoolPropertyByName(this, "CreateAudioDeviceForEveryPlayer", value); }
        }
        ///<summary>Height to use when spawning additional windows.</summary>
        public unsafe int ClientWindowHeight {
            get {return LevelEditorPlaySettings_ptr->ClientWindowHeight;}
            set {LevelEditorPlaySettings_ptr->ClientWindowHeight = value;}
        }
         //TODO: string FString AdditionalServerGameOptions
         //TODO: string FString AdditionalLaunchOptions
        ///<summary>The last used height for multiple instance windows (in pixels).</summary>
        public unsafe int MultipleInstanceLastHeight {
            get {return LevelEditorPlaySettings_ptr->MultipleInstanceLastHeight;}
            set {LevelEditorPlaySettings_ptr->MultipleInstanceLastHeight = value;}
        }
        ///<summary>The last used width for multiple instance windows (in pixels).</summary>
        public unsafe int MultipleInstanceLastWidth {
            get {return LevelEditorPlaySettings_ptr->MultipleInstanceLastWidth;}
            set {LevelEditorPlaySettings_ptr->MultipleInstanceLastWidth = value;}
        }
         //TODO: array not UObject TArray MultipleInstancePositions
         //TODO: string FString LastExecutedLaunchDevice
         //TODO: string FString LastExecutedLaunchName
        ///<summary>The last type of play-on session the user ran.</summary>
        public unsafe byte LastExecutedLaunchModeType {
            get {return LevelEditorPlaySettings_ptr->LastExecutedLaunchModeType;}
            set {LevelEditorPlaySettings_ptr->LastExecutedLaunchModeType = value;}
        }
        ///<summary>The last type of play location the user ran.</summary>
        public unsafe byte LastExecutedPlayModeLocation {
            get {return LevelEditorPlaySettings_ptr->LastExecutedPlayModeLocation;}
            set {LevelEditorPlaySettings_ptr->LastExecutedPlayModeLocation = value;}
        }
        ///<summary>The last type of play session the user ran.</summary>
        public unsafe byte LastExecutedPlayModeType {
            get {return LevelEditorPlaySettings_ptr->LastExecutedPlayModeType;}
            set {LevelEditorPlaySettings_ptr->LastExecutedPlayModeType = value;}
        }
         //TODO: string FString LastExecutedPIEPreviewDevice
         //TODO: array not UObject TArray LaptopScreenResolutions
         //TODO: array not UObject TArray MonitorScreenResolutions
         //TODO: array not UObject TArray PhoneScreenResolutions
         //TODO: array not UObject TArray TabletScreenResolutions
         //TODO: array not UObject TArray TelevisionScreenResolutions
         //TODO: string FString DeviceToEmulate
        ///<summary>PIESafe Zone Override</summary>
        public unsafe Margin PIESafeZoneOverride {
            get {return LevelEditorPlaySettings_ptr->PIESafeZoneOverride;}
            set {LevelEditorPlaySettings_ptr->PIESafeZoneOverride = value;}
        }
         //TODO: array not UObject TArray CustomUnsafeZoneStarts
         //TODO: array not UObject TArray CustomUnsafeZoneDimensions
        static LevelEditorPlaySettings() {
            StaticClass = Main.GetClass("LevelEditorPlaySettings");
        }
        internal unsafe LevelEditorPlaySettings_fields* LevelEditorPlaySettings_ptr => (LevelEditorPlaySettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator LevelEditorPlaySettings(IntPtr p) => UObject.Make<LevelEditorPlaySettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static LevelEditorPlaySettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static LevelEditorPlaySettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
