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
using UE4.Engine.Native;

namespace UE4.Engine {
    ///<summary>Stores user settings for a game (for example graphics and sound settings), with the ability to save and load to and from a file.</summary>
    public unsafe partial class GameUserSettings : UObject  {

        ///<summary>Applies the settings stored in ScalabilityQuality and saves settings</summary>
        public void ApplyHardwareBenchmarkResults()  => 
            GameUserSettings_methods.ApplyHardwareBenchmarkResults_method.Invoke(ObjPointer);

        ///<summary>Apply Non Resolution Settings</summary>
        public void ApplyNonResolutionSettings()  => 
            GameUserSettings_methods.ApplyNonResolutionSettings_method.Invoke(ObjPointer);

        ///<summary>Apply Resolution Settings</summary>
        public void ApplyResolutionSettings(bool bCheckForCommandLineOverrides)  => 
            GameUserSettings_methods.ApplyResolutionSettings_method.Invoke(ObjPointer, bCheckForCommandLineOverrides);

        ///<summary>Applies all current user settings to the game and saves to permanent storage (e.g. file), optionally checking for command line overrides.</summary>
        public void ApplySettings(bool bCheckForCommandLineOverrides)  => 
            GameUserSettings_methods.ApplySettings_method.Invoke(ObjPointer, bCheckForCommandLineOverrides);

        ///<summary>Mark current video mode settings (fullscreenmode/resolution) as being confirmed by the user</summary>
        public void ConfirmVideoMode()  => 
            GameUserSettings_methods.ConfirmVideoMode_method.Invoke(ObjPointer);

        ///<summary>Enables or disables HDR display output. Can be called again to change the desired nit level</summary>
        public void EnableHDRDisplayOutput(bool bEnable, int DisplayNits)  => 
            GameUserSettings_methods.EnableHDRDisplayOutput_method.Invoke(ObjPointer, bEnable, DisplayNits);

        ///<summary>Returns the anti-aliasing quality (0..4, higher is better)</summary>
        public int GetAntiAliasingQuality()  => 
            GameUserSettings_methods.GetAntiAliasingQuality_method.Invoke(ObjPointer);

        ///<summary>Returns the user's audio quality level setting</summary>
        public int GetAudioQualityLevel()  => 
            GameUserSettings_methods.GetAudioQualityLevel_method.Invoke(ObjPointer);

        ///<summary>Returns 0 if HDR isn't supported or is turned off</summary>
        public int GetCurrentHDRDisplayNits()  => 
            GameUserSettings_methods.GetCurrentHDRDisplayNits_method.Invoke(ObjPointer);

        ///<summary>@return The default resolution when no resolution is set</summary>
        public static IntPoint GetDefaultResolution()  => 
            GameUserSettings_methods.GetDefaultResolution_method.Invoke();

        ///<summary>Gets the desired resolution quality based on DesiredScreenWidth/Height and the current screen resolution</summary>
        public float GetDefaultResolutionScale()  => 
            GameUserSettings_methods.GetDefaultResolutionScale_method.Invoke(ObjPointer);

        ///<summary>@return The default window mode when no mode is set</summary>
        public static byte GetDefaultWindowMode()  => 
            GameUserSettings_methods.GetDefaultWindowMode_method.Invoke();

        ///<summary>@return The default window position when no position is set</summary>
        public static IntPoint GetDefaultWindowPosition()  => 
            GameUserSettings_methods.GetDefaultWindowPosition_method.Invoke();

        ///<summary>Returns user's desktop resolution, in pixels.</summary>
        public IntPoint GetDesktopResolution()  => 
            GameUserSettings_methods.GetDesktopResolution_method.Invoke(ObjPointer);

        ///<summary>Returns the foliage quality (0..4, higher is better)</summary>
        public int GetFoliageQuality()  => 
            GameUserSettings_methods.GetFoliageQuality_method.Invoke(ObjPointer);

        ///<summary>Gets the user's frame rate limit (0 indiciates the frame rate limit is disabled)</summary>
        public float GetFrameRateLimit()  => 
            GameUserSettings_methods.GetFrameRateLimit_method.Invoke(ObjPointer);

        ///<summary>Returns the user setting for game window fullscreen mode.</summary>
        public byte GetFullscreenMode()  => 
            GameUserSettings_methods.GetFullscreenMode_method.Invoke(ObjPointer);

        ///<summary>Returns the game local machine settings (resolution, windowing mode, scalability settings, etc...)</summary>
        public static GameUserSettings GetGameUserSettings()  => 
            GameUserSettings_methods.GetGameUserSettings_method.Invoke();

        ///<summary>Returns the last confirmed user setting for game window fullscreen mode.</summary>
        public byte GetLastConfirmedFullscreenMode()  => 
            GameUserSettings_methods.GetLastConfirmedFullscreenMode_method.Invoke(ObjPointer);

        ///<summary>Returns the last confirmed user setting for game screen resolution, in pixels.</summary>
        public IntPoint GetLastConfirmedScreenResolution()  => 
            GameUserSettings_methods.GetLastConfirmedScreenResolution_method.Invoke(ObjPointer);

        ///<summary>Returns the overall scalability level (can return -1 if the settings are custom)</summary>
        public int GetOverallScalabilityLevel()  => 
            GameUserSettings_methods.GetOverallScalabilityLevel_method.Invoke(ObjPointer);

        ///<summary>Returns the post-processing quality (0..4, higher is better)</summary>
        public int GetPostProcessingQuality()  => 
            GameUserSettings_methods.GetPostProcessingQuality_method.Invoke(ObjPointer);

        ///<summary>Returns the user setting for game window fullscreen mode.</summary>
        public byte GetPreferredFullscreenMode()  => 
            GameUserSettings_methods.GetPreferredFullscreenMode_method.Invoke(ObjPointer);

        ///<summary>Gets the recommended resolution quality based on LastRecommendedScreenWidth/Height and the current screen resolution</summary>
        public float GetRecommendedResolutionScale()  => 
            GameUserSettings_methods.GetRecommendedResolutionScale_method.Invoke(ObjPointer);

        ///<summary>Get Resolution Scale Information</summary>
        public (float, int, int, int) GetResolutionScaleInformation()  => 
            GameUserSettings_methods.GetResolutionScaleInformation_method.Invoke(ObjPointer);

        ///<summary>Returns the current resolution scale and the range</summary>
        public (float, float, float, float) GetResolutionScaleInformationEx()  => 
            GameUserSettings_methods.GetResolutionScaleInformationEx_method.Invoke(ObjPointer);

        ///<summary>Returns the user setting for game screen resolution, in pixels.</summary>
        public IntPoint GetScreenResolution()  => 
            GameUserSettings_methods.GetScreenResolution_method.Invoke(ObjPointer);

        ///<summary>Returns the shadow quality (0..4, higher is better)</summary>
        public int GetShadowQuality()  => 
            GameUserSettings_methods.GetShadowQuality_method.Invoke(ObjPointer);

        ///<summary>Returns the texture quality (0..4, higher is better)</summary>
        public int GetTextureQuality()  => 
            GameUserSettings_methods.GetTextureQuality_method.Invoke(ObjPointer);

        ///<summary>Returns the view distance quality (0..4, higher is better)</summary>
        public int GetViewDistanceQuality()  => 
            GameUserSettings_methods.GetViewDistanceQuality_method.Invoke(ObjPointer);

        ///<summary>Returns the visual effects quality (0..4, higher is better)</summary>
        public int GetVisualEffectQuality()  => 
            GameUserSettings_methods.GetVisualEffectQuality_method.Invoke(ObjPointer);

        ///<summary>Checks if any user settings is different from current</summary>
        public bool IsDirty()  => 
            GameUserSettings_methods.IsDirty_method.Invoke(ObjPointer);

        ///<summary>Checks if the dynamic resolution user setting is different from current system setting</summary>
        public bool IsDynamicResolutionDirty()  => 
            GameUserSettings_methods.IsDynamicResolutionDirty_method.Invoke(ObjPointer);

        ///<summary>Returns the user setting for dynamic resolution.</summary>
        public bool IsDynamicResolutionEnabled()  => 
            GameUserSettings_methods.IsDynamicResolutionEnabled_method.Invoke(ObjPointer);

        ///<summary>Checks if the FullscreenMode user setting is different from current</summary>
        public bool IsFullscreenModeDirty()  => 
            GameUserSettings_methods.IsFullscreenModeDirty_method.Invoke(ObjPointer);

        ///<summary>Is HDREnabled</summary>
        public bool IsHDREnabled()  => 
            GameUserSettings_methods.IsHDREnabled_method.Invoke(ObjPointer);

        ///<summary>Checks if the Screen Resolution user setting is different from current</summary>
        public bool IsScreenResolutionDirty()  => 
            GameUserSettings_methods.IsScreenResolutionDirty_method.Invoke(ObjPointer);

        ///<summary>Checks if the vsync user setting is different from current system setting</summary>
        public bool IsVSyncDirty()  => 
            GameUserSettings_methods.IsVSyncDirty_method.Invoke(ObjPointer);

        ///<summary>Returns the user setting for vsync.</summary>
        public bool IsVSyncEnabled()  => 
            GameUserSettings_methods.IsVSyncEnabled_method.Invoke(ObjPointer);

        ///<summary>Loads the user settings from persistent storage</summary>
        public void LoadSettings(bool bForceReload)  => 
            GameUserSettings_methods.LoadSettings_method.Invoke(ObjPointer, bForceReload);

        ///<summary>This function resets all settings to the current system settings</summary>
        public void ResetToCurrentSettings()  => 
            GameUserSettings_methods.ResetToCurrentSettings_method.Invoke(ObjPointer);

        ///<summary>Revert video mode (fullscreenmode/resolution) back to the last user confirmed values</summary>
        public void RevertVideoMode()  => 
            GameUserSettings_methods.RevertVideoMode_method.Invoke(ObjPointer);

        ///<summary>Runs the hardware benchmark and populates ScalabilityQuality as well as the last benchmark results config members, but does not apply the settings it determines. Designed to be called in conjunction with ApplyHardwareBenchmarkResults</summary>
        public void RunHardwareBenchmark(int WorkScale, float CPUMultiplier, float GPUMultiplier)  => 
            GameUserSettings_methods.RunHardwareBenchmark_method.Invoke(ObjPointer, WorkScale, CPUMultiplier, GPUMultiplier);

        ///<summary>Save the user settings to persistent storage (automatically happens as part of ApplySettings)</summary>
        public void SaveSettings()  => 
            GameUserSettings_methods.SaveSettings_method.Invoke(ObjPointer);

        ///<summary>Sets the anti-aliasing quality (0.</summary>
        ///<remarks>
        ///.4, higher is better)
        ///@param Value 0:low, 1:medium, 2:high, 3:epic, 4:cinematic (gets clamped if needed)
        ///</remarks>
        public void SetAntiAliasingQuality(int Value)  => 
            GameUserSettings_methods.SetAntiAliasingQuality_method.Invoke(ObjPointer, Value);

        ///<summary>Sets the user's audio quality level setting</summary>
        public void SetAudioQualityLevel(int QualityLevel)  => 
            GameUserSettings_methods.SetAudioQualityLevel_method.Invoke(ObjPointer, QualityLevel);

        ///<summary>Set scalability settings to sensible fallback values, for use when the benchmark fails or potentially causes a crash</summary>
        public void SetBenchmarkFallbackValues()  => 
            GameUserSettings_methods.SetBenchmarkFallbackValues_method.Invoke(ObjPointer);

        ///<summary>Sets the user setting for dynamic resolution. See UGameUserSettings::bUseDynamicResolution.</summary>
        public void SetDynamicResolutionEnabled(bool bEnable)  => 
            GameUserSettings_methods.SetDynamicResolutionEnabled_method.Invoke(ObjPointer, bEnable);

        ///<summary>Sets the foliage quality (0.</summary>
        ///<remarks>
        ///.4, higher is better)
        ///@param Value 0:low, 1:medium, 2:high, 3:epic, 4:cinematic (gets clamped if needed)
        ///</remarks>
        public void SetFoliageQuality(int Value)  => 
            GameUserSettings_methods.SetFoliageQuality_method.Invoke(ObjPointer, Value);

        ///<summary>Sets the user's frame rate limit (0 will disable frame rate limiting)</summary>
        public void SetFrameRateLimit(float NewLimit)  => 
            GameUserSettings_methods.SetFrameRateLimit_method.Invoke(ObjPointer, NewLimit);

        ///<summary>Sets the user setting for the game window fullscreen mode. See UGameUserSettings::FullscreenMode.</summary>
        public void SetFullscreenMode(byte InFullscreenMode)  => 
            GameUserSettings_methods.SetFullscreenMode_method.Invoke(ObjPointer, InFullscreenMode);

        ///<summary>
        ///Changes all scalability settings at once based on a single overall quality level
        ///@
        ///</summary>
        ///<remarks>param Value 0:low, 1:medium, 2:high, 3:epic, 4:cinematic</remarks>
        public void SetOverallScalabilityLevel(int Value)  => 
            GameUserSettings_methods.SetOverallScalabilityLevel_method.Invoke(ObjPointer, Value);

        ///<summary>Sets the post-processing quality (0.</summary>
        ///<remarks>
        ///.4, higher is better)
        ///@param Value 0:low, 1:medium, 2:high, 3:epic, 4:cinematic (gets clamped if needed)
        ///</remarks>
        public void SetPostProcessingQuality(int Value)  => 
            GameUserSettings_methods.SetPostProcessingQuality_method.Invoke(ObjPointer, Value);

        ///<summary>Sets the current resolution scale as a normalized 0..1 value between MinScaleValue and MaxScaleValue</summary>
        public void SetResolutionScaleNormalized(float NewScaleNormalized)  => 
            GameUserSettings_methods.SetResolutionScaleNormalized_method.Invoke(ObjPointer, NewScaleNormalized);

        ///<summary>Set Resolution Scale Value</summary>
        public void SetResolutionScaleValue(int NewScaleValue)  => 
            GameUserSettings_methods.SetResolutionScaleValue_method.Invoke(ObjPointer, NewScaleValue);

        ///<summary>Sets the current resolution scale</summary>
        public void SetResolutionScaleValueEx(float NewScaleValue)  => 
            GameUserSettings_methods.SetResolutionScaleValueEx_method.Invoke(ObjPointer, NewScaleValue);

        ///<summary>Sets the user setting for game screen resolution, in pixels.</summary>
        public void SetScreenResolution(IntPoint Resolution)  => 
            GameUserSettings_methods.SetScreenResolution_method.Invoke(ObjPointer, Resolution);

        ///<summary>Sets the shadow quality (0.</summary>
        ///<remarks>
        ///.4, higher is better)
        ///@param Value 0:low, 1:medium, 2:high, 3:epic, 4:cinematic (gets clamped if needed)
        ///</remarks>
        public void SetShadowQuality(int Value)  => 
            GameUserSettings_methods.SetShadowQuality_method.Invoke(ObjPointer, Value);

        ///<summary>Sets the texture quality (0.</summary>
        ///<remarks>
        ///.4, higher is better)
        ///@param Value 0:low, 1:medium, 2:high, 3:epic, 4:cinematic  (gets clamped if needed)
        ///</remarks>
        public void SetTextureQuality(int Value)  => 
            GameUserSettings_methods.SetTextureQuality_method.Invoke(ObjPointer, Value);

        ///<summary>Set to Defaults</summary>
        public void SetToDefaults()  => 
            GameUserSettings_methods.SetToDefaults_method.Invoke(ObjPointer);

        ///<summary>Sets the view distance quality (0.</summary>
        ///<remarks>
        ///.4, higher is better)
        ///@param Value 0:low, 1:medium, 2:high, 3:epic, 4:cinematic (gets clamped if needed)
        ///</remarks>
        public void SetViewDistanceQuality(int Value)  => 
            GameUserSettings_methods.SetViewDistanceQuality_method.Invoke(ObjPointer, Value);

        ///<summary>Sets the visual effects quality (0.</summary>
        ///<remarks>
        ///.4, higher is better)
        ///@param Value 0:low, 1:medium, 2:high, 3:epic, 4:cinematic (gets clamped if needed)
        ///</remarks>
        public void SetVisualEffectQuality(int Value)  => 
            GameUserSettings_methods.SetVisualEffectQuality_method.Invoke(ObjPointer, Value);

        ///<summary>Sets the user setting for vsync. See UGameUserSettings::bUseVSync.</summary>
        public void SetVSyncEnabled(bool bEnable)  => 
            GameUserSettings_methods.SetVSyncEnabled_method.Invoke(ObjPointer, bEnable);

        ///<summary>Whether the curently running system supports HDR display output</summary>
        public bool SupportsHDRDisplayOutput()  => 
            GameUserSettings_methods.SupportsHDRDisplayOutput_method.Invoke(ObjPointer);

        ///<summary>Validates and resets bad user settings to default. Deletes stale user settings file if necessary.</summary>
        public void ValidateSettings()  => 
            GameUserSettings_methods.ValidateSettings_method.Invoke(ObjPointer);
        public bool bUseVSync {
            get {return Main.GetGetBoolPropertyByName(this, "bUseVSync"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseVSync", value); }
        }
        public bool bUseDynamicResolution {
            get {return Main.GetGetBoolPropertyByName(this, "bUseDynamicResolution"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseDynamicResolution", value); }
        }
         //TODO: numeric uint32 ResolutionSizeX
         //TODO: numeric uint32 ResolutionSizeY
         //TODO: numeric uint32 LastUserConfirmedResolutionSizeX
         //TODO: numeric uint32 LastUserConfirmedResolutionSizeY
        ///<summary>Window PosX</summary>
        public unsafe int WindowPosX {
            get {return GameUserSettings_ptr->WindowPosX;}
            set {GameUserSettings_ptr->WindowPosX = value;}
        }
        ///<summary>Window PosY</summary>
        public unsafe int WindowPosY {
            get {return GameUserSettings_ptr->WindowPosY;}
            set {GameUserSettings_ptr->WindowPosY = value;}
        }
        ///<summary>
        ///Game window fullscreen mode
        ///     0 = Fullscreen
        ///     1 = Windowed fullscreen
        ///</summary>
        ///<remarks>2 = Windowed</remarks>
        public unsafe int FullscreenMode {
            get {return GameUserSettings_ptr->FullscreenMode;}
            set {GameUserSettings_ptr->FullscreenMode = value;}
        }
        ///<summary>Last user confirmed fullscreen mode setting.</summary>
        public unsafe int LastConfirmedFullscreenMode {
            get {return GameUserSettings_ptr->LastConfirmedFullscreenMode;}
            set {GameUserSettings_ptr->LastConfirmedFullscreenMode = value;}
        }
        ///<summary>Fullscreen mode to use when toggling between windowed and fullscreen. Same values as r.FullScreenMode.</summary>
        public unsafe int PreferredFullscreenMode {
            get {return GameUserSettings_ptr->PreferredFullscreenMode;}
            set {GameUserSettings_ptr->PreferredFullscreenMode = value;}
        }
         //TODO: numeric uint32 Version
        ///<summary>Audio Quality Level</summary>
        public unsafe int AudioQualityLevel {
            get {return GameUserSettings_ptr->AudioQualityLevel;}
            set {GameUserSettings_ptr->AudioQualityLevel = value;}
        }
        ///<summary>Last Confirmed Audio Quality Level</summary>
        public unsafe int LastConfirmedAudioQualityLevel {
            get {return GameUserSettings_ptr->LastConfirmedAudioQualityLevel;}
            set {GameUserSettings_ptr->LastConfirmedAudioQualityLevel = value;}
        }
        ///<summary>Frame rate cap</summary>
        public unsafe float FrameRateLimit {
            get {return GameUserSettings_ptr->FrameRateLimit;}
            set {GameUserSettings_ptr->FrameRateLimit = value;}
        }
        ///<summary>Desired screen width used to calculate the resolution scale when user changes display mode</summary>
        public unsafe int DesiredScreenWidth {
            get {return GameUserSettings_ptr->DesiredScreenWidth;}
            set {GameUserSettings_ptr->DesiredScreenWidth = value;}
        }
        public bool bUseDesiredScreenHeight {
            get {return Main.GetGetBoolPropertyByName(this, "bUseDesiredScreenHeight"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseDesiredScreenHeight", value); }
        }
        ///<summary>Desired screen height used to calculate the resolution scale when user changes display mode</summary>
        public unsafe int DesiredScreenHeight {
            get {return GameUserSettings_ptr->DesiredScreenHeight;}
            set {GameUserSettings_ptr->DesiredScreenHeight = value;}
        }
        ///<summary>Desired screen width used to calculate the resolution scale when user changes display mode</summary>
        public unsafe int LastUserConfirmedDesiredScreenWidth {
            get {return GameUserSettings_ptr->LastUserConfirmedDesiredScreenWidth;}
            set {GameUserSettings_ptr->LastUserConfirmedDesiredScreenWidth = value;}
        }
        ///<summary>Desired screen height used to calculate the resolution scale when user changes display mode</summary>
        public unsafe int LastUserConfirmedDesiredScreenHeight {
            get {return GameUserSettings_ptr->LastUserConfirmedDesiredScreenHeight;}
            set {GameUserSettings_ptr->LastUserConfirmedDesiredScreenHeight = value;}
        }
        ///<summary>Result of the last benchmark; calculated resolution to use.</summary>
        public unsafe float LastRecommendedScreenWidth {
            get {return GameUserSettings_ptr->LastRecommendedScreenWidth;}
            set {GameUserSettings_ptr->LastRecommendedScreenWidth = value;}
        }
        ///<summary>Result of the last benchmark; calculated resolution to use.</summary>
        public unsafe float LastRecommendedScreenHeight {
            get {return GameUserSettings_ptr->LastRecommendedScreenHeight;}
            set {GameUserSettings_ptr->LastRecommendedScreenHeight = value;}
        }
        ///<summary>Result of the last benchmark (CPU); -1 if there has not been a benchmark run</summary>
        public unsafe float LastCPUBenchmarkResult {
            get {return GameUserSettings_ptr->LastCPUBenchmarkResult;}
            set {GameUserSettings_ptr->LastCPUBenchmarkResult = value;}
        }
        ///<summary>Result of the last benchmark (GPU); -1 if there has not been a benchmark run</summary>
        public unsafe float LastGPUBenchmarkResult {
            get {return GameUserSettings_ptr->LastGPUBenchmarkResult;}
            set {GameUserSettings_ptr->LastGPUBenchmarkResult = value;}
        }
         //TODO: array not UObject TArray LastCPUBenchmarkSteps
         //TODO: array not UObject TArray LastGPUBenchmarkSteps
        ///<summary>Multiplier used against the last GPU benchmark</summary>
        public unsafe float LastGPUBenchmarkMultiplier {
            get {return GameUserSettings_ptr->LastGPUBenchmarkMultiplier;}
            set {GameUserSettings_ptr->LastGPUBenchmarkMultiplier = value;}
        }
        public bool bUseHDRDisplayOutput {
            get {return Main.GetGetBoolPropertyByName(this, "bUseHDRDisplayOutput"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseHDRDisplayOutput", value); }
        }
        ///<summary>HDR</summary>
        public unsafe int HDRDisplayOutputNits {
            get {return GameUserSettings_ptr->HDRDisplayOutputNits;}
            set {GameUserSettings_ptr->HDRDisplayOutputNits = value;}
        }
         //TODO: multicast delegate FOnGameUserSettingsUINeedsUpdate OnGameUserSettingsUINeedsUpdate
        static GameUserSettings() {
            StaticClass = Main.GetClass("GameUserSettings");
        }
        internal unsafe GameUserSettings_fields* GameUserSettings_ptr => (GameUserSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator GameUserSettings(IntPtr p) => UObject.Make<GameUserSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static GameUserSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static GameUserSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
