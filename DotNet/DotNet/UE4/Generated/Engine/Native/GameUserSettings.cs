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


namespace UE4.Engine.Native {
    [StructLayout( LayoutKind.Explicit, Size=296 )]
    internal unsafe struct GameUserSettings_fields {
        [FieldOffset(56)] public bool bUseVSync;
        [FieldOffset(57)] public bool bUseDynamicResolution;
        [FieldOffset(136)] byte ResolutionSizeX; //TODO: numeric uint32 ResolutionSizeX
        [FieldOffset(140)] byte ResolutionSizeY; //TODO: numeric uint32 ResolutionSizeY
        [FieldOffset(144)] byte LastUserConfirmedResolutionSizeX; //TODO: numeric uint32 LastUserConfirmedResolutionSizeX
        [FieldOffset(148)] byte LastUserConfirmedResolutionSizeY; //TODO: numeric uint32 LastUserConfirmedResolutionSizeY
        [FieldOffset(152)] public int WindowPosX;
        [FieldOffset(156)] public int WindowPosY;
        [FieldOffset(160)] public int FullscreenMode;
        [FieldOffset(164)] public int LastConfirmedFullscreenMode;
        [FieldOffset(168)] public int PreferredFullscreenMode;
        [FieldOffset(172)] byte Version; //TODO: numeric uint32 Version
        [FieldOffset(176)] public int AudioQualityLevel;
        [FieldOffset(180)] public int LastConfirmedAudioQualityLevel;
        [FieldOffset(184)] public float FrameRateLimit;
        [FieldOffset(192)] public int DesiredScreenWidth;
        [FieldOffset(196)] public bool bUseDesiredScreenHeight;
        [FieldOffset(200)] public int DesiredScreenHeight;
        [FieldOffset(204)] public int LastUserConfirmedDesiredScreenWidth;
        [FieldOffset(208)] public int LastUserConfirmedDesiredScreenHeight;
        [FieldOffset(212)] public float LastRecommendedScreenWidth;
        [FieldOffset(216)] public float LastRecommendedScreenHeight;
        [FieldOffset(220)] public float LastCPUBenchmarkResult;
        [FieldOffset(224)] public float LastGPUBenchmarkResult;
        [FieldOffset(232)] public NativeArray LastCPUBenchmarkSteps;
        [FieldOffset(248)] public NativeArray LastGPUBenchmarkSteps;
        [FieldOffset(264)] public float LastGPUBenchmarkMultiplier;
        [FieldOffset(268)] public bool bUseHDRDisplayOutput;
        [FieldOffset(272)] public int HDRDisplayOutputNits;
        [FieldOffset(280)] byte OnGameUserSettingsUINeedsUpdate; //TODO: multicast delegate FOnGameUserSettingsUINeedsUpdate OnGameUserSettingsUINeedsUpdate
    }
    internal unsafe struct GameUserSettings_methods {
        internal struct ApplyHardwareBenchmarkResults_method {
            static internal IntPtr ApplyHardwareBenchmarkResults_ptr;
            static ApplyHardwareBenchmarkResults_method() {
                ApplyHardwareBenchmarkResults_ptr = Main.GetMethodUFunction(GameUserSettings.StaticClass, "ApplyHardwareBenchmarkResults");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, ApplyHardwareBenchmarkResults_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ApplyNonResolutionSettings_method {
            static internal IntPtr ApplyNonResolutionSettings_ptr;
            static ApplyNonResolutionSettings_method() {
                ApplyNonResolutionSettings_ptr = Main.GetMethodUFunction(GameUserSettings.StaticClass, "ApplyNonResolutionSettings");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, ApplyNonResolutionSettings_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ApplyResolutionSettings_method {
            static internal IntPtr ApplyResolutionSettings_ptr;
            static ApplyResolutionSettings_method() {
                ApplyResolutionSettings_ptr = Main.GetMethodUFunction(GameUserSettings.StaticClass, "ApplyResolutionSettings");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bCheckForCommandLineOverrides) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bCheckForCommandLineOverrides;
                Main.GetProcessEvent(obj, ApplyResolutionSettings_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ApplySettings_method {
            static internal IntPtr ApplySettings_ptr;
            static ApplySettings_method() {
                ApplySettings_ptr = Main.GetMethodUFunction(GameUserSettings.StaticClass, "ApplySettings");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bCheckForCommandLineOverrides) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bCheckForCommandLineOverrides;
                Main.GetProcessEvent(obj, ApplySettings_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ConfirmVideoMode_method {
            static internal IntPtr ConfirmVideoMode_ptr;
            static ConfirmVideoMode_method() {
                ConfirmVideoMode_ptr = Main.GetMethodUFunction(GameUserSettings.StaticClass, "ConfirmVideoMode");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, ConfirmVideoMode_ptr, new IntPtr(p)); ;
            }
        }
        internal struct EnableHDRDisplayOutput_method {
            static internal IntPtr EnableHDRDisplayOutput_ptr;
            static EnableHDRDisplayOutput_method() {
                EnableHDRDisplayOutput_ptr = Main.GetMethodUFunction(GameUserSettings.StaticClass, "EnableHDRDisplayOutput");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bEnable, int DisplayNits) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bEnable;
                *((int*)(b+4)) = DisplayNits;
                Main.GetProcessEvent(obj, EnableHDRDisplayOutput_ptr, new IntPtr(p)); ;
            }
        }
        internal struct GetAntiAliasingQuality_method {
            static internal IntPtr GetAntiAliasingQuality_ptr;
            static GetAntiAliasingQuality_method() {
                GetAntiAliasingQuality_ptr = Main.GetMethodUFunction(GameUserSettings.StaticClass, "GetAntiAliasingQuality");
            }

            internal static unsafe int Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetAntiAliasingQuality_ptr, new IntPtr(p)); ;
                return *((int*)(b+0));
            }
        }
        internal struct GetAudioQualityLevel_method {
            static internal IntPtr GetAudioQualityLevel_ptr;
            static GetAudioQualityLevel_method() {
                GetAudioQualityLevel_ptr = Main.GetMethodUFunction(GameUserSettings.StaticClass, "GetAudioQualityLevel");
            }

            internal static unsafe int Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetAudioQualityLevel_ptr, new IntPtr(p)); ;
                return *((int*)(b+0));
            }
        }
        internal struct GetCurrentHDRDisplayNits_method {
            static internal IntPtr GetCurrentHDRDisplayNits_ptr;
            static GetCurrentHDRDisplayNits_method() {
                GetCurrentHDRDisplayNits_ptr = Main.GetMethodUFunction(GameUserSettings.StaticClass, "GetCurrentHDRDisplayNits");
            }

            internal static unsafe int Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetCurrentHDRDisplayNits_ptr, new IntPtr(p)); ;
                return *((int*)(b+0));
            }
        }
        internal struct GetDefaultResolution_method {
            static internal IntPtr GetDefaultResolution_ptr;
            static GetDefaultResolution_method() {
                GetDefaultResolution_ptr = Main.GetMethodUFunction(GameUserSettings.StaticClass, "GetDefaultResolution");
            }

            internal static unsafe IntPoint Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(GameUserSettings.DefaultObject, GetDefaultResolution_ptr, new IntPtr(p)); ;
                return *((IntPoint*)(b+0));
            }
        }
        internal struct GetDefaultResolutionScale_method {
            static internal IntPtr GetDefaultResolutionScale_ptr;
            static GetDefaultResolutionScale_method() {
                GetDefaultResolutionScale_ptr = Main.GetMethodUFunction(GameUserSettings.StaticClass, "GetDefaultResolutionScale");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetDefaultResolutionScale_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetDefaultWindowMode_method {
            static internal IntPtr GetDefaultWindowMode_ptr;
            static GetDefaultWindowMode_method() {
                GetDefaultWindowMode_ptr = Main.GetMethodUFunction(GameUserSettings.StaticClass, "GetDefaultWindowMode");
            }

            internal static unsafe byte Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(GameUserSettings.DefaultObject, GetDefaultWindowMode_ptr, new IntPtr(p)); ;
                return *(b+0);
            }
        }
        internal struct GetDefaultWindowPosition_method {
            static internal IntPtr GetDefaultWindowPosition_ptr;
            static GetDefaultWindowPosition_method() {
                GetDefaultWindowPosition_ptr = Main.GetMethodUFunction(GameUserSettings.StaticClass, "GetDefaultWindowPosition");
            }

            internal static unsafe IntPoint Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(GameUserSettings.DefaultObject, GetDefaultWindowPosition_ptr, new IntPtr(p)); ;
                return *((IntPoint*)(b+0));
            }
        }
        internal struct GetDesktopResolution_method {
            static internal IntPtr GetDesktopResolution_ptr;
            static GetDesktopResolution_method() {
                GetDesktopResolution_ptr = Main.GetMethodUFunction(GameUserSettings.StaticClass, "GetDesktopResolution");
            }

            internal static unsafe IntPoint Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetDesktopResolution_ptr, new IntPtr(p)); ;
                return *((IntPoint*)(b+0));
            }
        }
        internal struct GetFoliageQuality_method {
            static internal IntPtr GetFoliageQuality_ptr;
            static GetFoliageQuality_method() {
                GetFoliageQuality_ptr = Main.GetMethodUFunction(GameUserSettings.StaticClass, "GetFoliageQuality");
            }

            internal static unsafe int Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetFoliageQuality_ptr, new IntPtr(p)); ;
                return *((int*)(b+0));
            }
        }
        internal struct GetFrameRateLimit_method {
            static internal IntPtr GetFrameRateLimit_ptr;
            static GetFrameRateLimit_method() {
                GetFrameRateLimit_ptr = Main.GetMethodUFunction(GameUserSettings.StaticClass, "GetFrameRateLimit");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetFrameRateLimit_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetFullscreenMode_method {
            static internal IntPtr GetFullscreenMode_ptr;
            static GetFullscreenMode_method() {
                GetFullscreenMode_ptr = Main.GetMethodUFunction(GameUserSettings.StaticClass, "GetFullscreenMode");
            }

            internal static unsafe byte Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetFullscreenMode_ptr, new IntPtr(p)); ;
                return *(b+0);
            }
        }
        internal struct GetGameUserSettings_method {
            static internal IntPtr GetGameUserSettings_ptr;
            static GetGameUserSettings_method() {
                GetGameUserSettings_ptr = Main.GetMethodUFunction(GameUserSettings.StaticClass, "GetGameUserSettings");
            }

            internal static unsafe GameUserSettings Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(GameUserSettings.DefaultObject, GetGameUserSettings_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
        internal struct GetLastConfirmedFullscreenMode_method {
            static internal IntPtr GetLastConfirmedFullscreenMode_ptr;
            static GetLastConfirmedFullscreenMode_method() {
                GetLastConfirmedFullscreenMode_ptr = Main.GetMethodUFunction(GameUserSettings.StaticClass, "GetLastConfirmedFullscreenMode");
            }

            internal static unsafe byte Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetLastConfirmedFullscreenMode_ptr, new IntPtr(p)); ;
                return *(b+0);
            }
        }
        internal struct GetLastConfirmedScreenResolution_method {
            static internal IntPtr GetLastConfirmedScreenResolution_ptr;
            static GetLastConfirmedScreenResolution_method() {
                GetLastConfirmedScreenResolution_ptr = Main.GetMethodUFunction(GameUserSettings.StaticClass, "GetLastConfirmedScreenResolution");
            }

            internal static unsafe IntPoint Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetLastConfirmedScreenResolution_ptr, new IntPtr(p)); ;
                return *((IntPoint*)(b+0));
            }
        }
        internal struct GetOverallScalabilityLevel_method {
            static internal IntPtr GetOverallScalabilityLevel_ptr;
            static GetOverallScalabilityLevel_method() {
                GetOverallScalabilityLevel_ptr = Main.GetMethodUFunction(GameUserSettings.StaticClass, "GetOverallScalabilityLevel");
            }

            internal static unsafe int Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetOverallScalabilityLevel_ptr, new IntPtr(p)); ;
                return *((int*)(b+0));
            }
        }
        internal struct GetPostProcessingQuality_method {
            static internal IntPtr GetPostProcessingQuality_ptr;
            static GetPostProcessingQuality_method() {
                GetPostProcessingQuality_ptr = Main.GetMethodUFunction(GameUserSettings.StaticClass, "GetPostProcessingQuality");
            }

            internal static unsafe int Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetPostProcessingQuality_ptr, new IntPtr(p)); ;
                return *((int*)(b+0));
            }
        }
        internal struct GetPreferredFullscreenMode_method {
            static internal IntPtr GetPreferredFullscreenMode_ptr;
            static GetPreferredFullscreenMode_method() {
                GetPreferredFullscreenMode_ptr = Main.GetMethodUFunction(GameUserSettings.StaticClass, "GetPreferredFullscreenMode");
            }

            internal static unsafe byte Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetPreferredFullscreenMode_ptr, new IntPtr(p)); ;
                return *(b+0);
            }
        }
        internal struct GetRecommendedResolutionScale_method {
            static internal IntPtr GetRecommendedResolutionScale_ptr;
            static GetRecommendedResolutionScale_method() {
                GetRecommendedResolutionScale_ptr = Main.GetMethodUFunction(GameUserSettings.StaticClass, "GetRecommendedResolutionScale");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetRecommendedResolutionScale_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetResolutionScaleInformation_method {
            static internal IntPtr GetResolutionScaleInformation_ptr;
            static GetResolutionScaleInformation_method() {
                GetResolutionScaleInformation_ptr = Main.GetMethodUFunction(GameUserSettings.StaticClass, "GetResolutionScaleInformation");
            }

            internal static unsafe (float, int, int, int) Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetResolutionScaleInformation_ptr, new IntPtr(p)); ;
                return (*((float*)(b+0)),*((int*)(b+4)),*((int*)(b+8)),*((int*)(b+12)));
            }
        }
        internal struct GetResolutionScaleInformationEx_method {
            static internal IntPtr GetResolutionScaleInformationEx_ptr;
            static GetResolutionScaleInformationEx_method() {
                GetResolutionScaleInformationEx_ptr = Main.GetMethodUFunction(GameUserSettings.StaticClass, "GetResolutionScaleInformationEx");
            }

            internal static unsafe (float, float, float, float) Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetResolutionScaleInformationEx_ptr, new IntPtr(p)); ;
                return (*((float*)(b+0)),*((float*)(b+4)),*((float*)(b+8)),*((float*)(b+12)));
            }
        }
        internal struct GetScreenResolution_method {
            static internal IntPtr GetScreenResolution_ptr;
            static GetScreenResolution_method() {
                GetScreenResolution_ptr = Main.GetMethodUFunction(GameUserSettings.StaticClass, "GetScreenResolution");
            }

            internal static unsafe IntPoint Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetScreenResolution_ptr, new IntPtr(p)); ;
                return *((IntPoint*)(b+0));
            }
        }
        internal struct GetShadowQuality_method {
            static internal IntPtr GetShadowQuality_ptr;
            static GetShadowQuality_method() {
                GetShadowQuality_ptr = Main.GetMethodUFunction(GameUserSettings.StaticClass, "GetShadowQuality");
            }

            internal static unsafe int Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetShadowQuality_ptr, new IntPtr(p)); ;
                return *((int*)(b+0));
            }
        }
        internal struct GetTextureQuality_method {
            static internal IntPtr GetTextureQuality_ptr;
            static GetTextureQuality_method() {
                GetTextureQuality_ptr = Main.GetMethodUFunction(GameUserSettings.StaticClass, "GetTextureQuality");
            }

            internal static unsafe int Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetTextureQuality_ptr, new IntPtr(p)); ;
                return *((int*)(b+0));
            }
        }
        internal struct GetViewDistanceQuality_method {
            static internal IntPtr GetViewDistanceQuality_ptr;
            static GetViewDistanceQuality_method() {
                GetViewDistanceQuality_ptr = Main.GetMethodUFunction(GameUserSettings.StaticClass, "GetViewDistanceQuality");
            }

            internal static unsafe int Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetViewDistanceQuality_ptr, new IntPtr(p)); ;
                return *((int*)(b+0));
            }
        }
        internal struct GetVisualEffectQuality_method {
            static internal IntPtr GetVisualEffectQuality_ptr;
            static GetVisualEffectQuality_method() {
                GetVisualEffectQuality_ptr = Main.GetMethodUFunction(GameUserSettings.StaticClass, "GetVisualEffectQuality");
            }

            internal static unsafe int Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetVisualEffectQuality_ptr, new IntPtr(p)); ;
                return *((int*)(b+0));
            }
        }
        internal struct IsDirty_method {
            static internal IntPtr IsDirty_ptr;
            static IsDirty_method() {
                IsDirty_ptr = Main.GetMethodUFunction(GameUserSettings.StaticClass, "IsDirty");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsDirty_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsDynamicResolutionDirty_method {
            static internal IntPtr IsDynamicResolutionDirty_ptr;
            static IsDynamicResolutionDirty_method() {
                IsDynamicResolutionDirty_ptr = Main.GetMethodUFunction(GameUserSettings.StaticClass, "IsDynamicResolutionDirty");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsDynamicResolutionDirty_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsDynamicResolutionEnabled_method {
            static internal IntPtr IsDynamicResolutionEnabled_ptr;
            static IsDynamicResolutionEnabled_method() {
                IsDynamicResolutionEnabled_ptr = Main.GetMethodUFunction(GameUserSettings.StaticClass, "IsDynamicResolutionEnabled");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsDynamicResolutionEnabled_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsFullscreenModeDirty_method {
            static internal IntPtr IsFullscreenModeDirty_ptr;
            static IsFullscreenModeDirty_method() {
                IsFullscreenModeDirty_ptr = Main.GetMethodUFunction(GameUserSettings.StaticClass, "IsFullscreenModeDirty");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsFullscreenModeDirty_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsHDREnabled_method {
            static internal IntPtr IsHDREnabled_ptr;
            static IsHDREnabled_method() {
                IsHDREnabled_ptr = Main.GetMethodUFunction(GameUserSettings.StaticClass, "IsHDREnabled");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsHDREnabled_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsScreenResolutionDirty_method {
            static internal IntPtr IsScreenResolutionDirty_ptr;
            static IsScreenResolutionDirty_method() {
                IsScreenResolutionDirty_ptr = Main.GetMethodUFunction(GameUserSettings.StaticClass, "IsScreenResolutionDirty");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsScreenResolutionDirty_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsVSyncDirty_method {
            static internal IntPtr IsVSyncDirty_ptr;
            static IsVSyncDirty_method() {
                IsVSyncDirty_ptr = Main.GetMethodUFunction(GameUserSettings.StaticClass, "IsVSyncDirty");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsVSyncDirty_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsVSyncEnabled_method {
            static internal IntPtr IsVSyncEnabled_ptr;
            static IsVSyncEnabled_method() {
                IsVSyncEnabled_ptr = Main.GetMethodUFunction(GameUserSettings.StaticClass, "IsVSyncEnabled");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsVSyncEnabled_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct LoadSettings_method {
            static internal IntPtr LoadSettings_ptr;
            static LoadSettings_method() {
                LoadSettings_ptr = Main.GetMethodUFunction(GameUserSettings.StaticClass, "LoadSettings");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bForceReload) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bForceReload;
                Main.GetProcessEvent(obj, LoadSettings_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ResetToCurrentSettings_method {
            static internal IntPtr ResetToCurrentSettings_ptr;
            static ResetToCurrentSettings_method() {
                ResetToCurrentSettings_ptr = Main.GetMethodUFunction(GameUserSettings.StaticClass, "ResetToCurrentSettings");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, ResetToCurrentSettings_ptr, new IntPtr(p)); ;
            }
        }
        internal struct RevertVideoMode_method {
            static internal IntPtr RevertVideoMode_ptr;
            static RevertVideoMode_method() {
                RevertVideoMode_ptr = Main.GetMethodUFunction(GameUserSettings.StaticClass, "RevertVideoMode");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, RevertVideoMode_ptr, new IntPtr(p)); ;
            }
        }
        internal struct RunHardwareBenchmark_method {
            static internal IntPtr RunHardwareBenchmark_ptr;
            static RunHardwareBenchmark_method() {
                RunHardwareBenchmark_ptr = Main.GetMethodUFunction(GameUserSettings.StaticClass, "RunHardwareBenchmark");
            }

            internal static unsafe void Invoke(IntPtr obj, int WorkScale, float CPUMultiplier, float GPUMultiplier) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = WorkScale;
                *((float*)(b+4)) = CPUMultiplier;
                *((float*)(b+8)) = GPUMultiplier;
                Main.GetProcessEvent(obj, RunHardwareBenchmark_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SaveSettings_method {
            static internal IntPtr SaveSettings_ptr;
            static SaveSettings_method() {
                SaveSettings_ptr = Main.GetMethodUFunction(GameUserSettings.StaticClass, "SaveSettings");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, SaveSettings_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetAntiAliasingQuality_method {
            static internal IntPtr SetAntiAliasingQuality_ptr;
            static SetAntiAliasingQuality_method() {
                SetAntiAliasingQuality_ptr = Main.GetMethodUFunction(GameUserSettings.StaticClass, "SetAntiAliasingQuality");
            }

            internal static unsafe void Invoke(IntPtr obj, int Value) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = Value;
                Main.GetProcessEvent(obj, SetAntiAliasingQuality_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetAudioQualityLevel_method {
            static internal IntPtr SetAudioQualityLevel_ptr;
            static SetAudioQualityLevel_method() {
                SetAudioQualityLevel_ptr = Main.GetMethodUFunction(GameUserSettings.StaticClass, "SetAudioQualityLevel");
            }

            internal static unsafe void Invoke(IntPtr obj, int QualityLevel) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = QualityLevel;
                Main.GetProcessEvent(obj, SetAudioQualityLevel_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetBenchmarkFallbackValues_method {
            static internal IntPtr SetBenchmarkFallbackValues_ptr;
            static SetBenchmarkFallbackValues_method() {
                SetBenchmarkFallbackValues_ptr = Main.GetMethodUFunction(GameUserSettings.StaticClass, "SetBenchmarkFallbackValues");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, SetBenchmarkFallbackValues_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetDynamicResolutionEnabled_method {
            static internal IntPtr SetDynamicResolutionEnabled_ptr;
            static SetDynamicResolutionEnabled_method() {
                SetDynamicResolutionEnabled_ptr = Main.GetMethodUFunction(GameUserSettings.StaticClass, "SetDynamicResolutionEnabled");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bEnable) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bEnable;
                Main.GetProcessEvent(obj, SetDynamicResolutionEnabled_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetFoliageQuality_method {
            static internal IntPtr SetFoliageQuality_ptr;
            static SetFoliageQuality_method() {
                SetFoliageQuality_ptr = Main.GetMethodUFunction(GameUserSettings.StaticClass, "SetFoliageQuality");
            }

            internal static unsafe void Invoke(IntPtr obj, int Value) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = Value;
                Main.GetProcessEvent(obj, SetFoliageQuality_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetFrameRateLimit_method {
            static internal IntPtr SetFrameRateLimit_ptr;
            static SetFrameRateLimit_method() {
                SetFrameRateLimit_ptr = Main.GetMethodUFunction(GameUserSettings.StaticClass, "SetFrameRateLimit");
            }

            internal static unsafe void Invoke(IntPtr obj, float NewLimit) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = NewLimit;
                Main.GetProcessEvent(obj, SetFrameRateLimit_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetFullscreenMode_method {
            static internal IntPtr SetFullscreenMode_ptr;
            static SetFullscreenMode_method() {
                SetFullscreenMode_ptr = Main.GetMethodUFunction(GameUserSettings.StaticClass, "SetFullscreenMode");
            }

            internal static unsafe void Invoke(IntPtr obj, byte InFullscreenMode) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = InFullscreenMode;
                Main.GetProcessEvent(obj, SetFullscreenMode_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetOverallScalabilityLevel_method {
            static internal IntPtr SetOverallScalabilityLevel_ptr;
            static SetOverallScalabilityLevel_method() {
                SetOverallScalabilityLevel_ptr = Main.GetMethodUFunction(GameUserSettings.StaticClass, "SetOverallScalabilityLevel");
            }

            internal static unsafe void Invoke(IntPtr obj, int Value) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = Value;
                Main.GetProcessEvent(obj, SetOverallScalabilityLevel_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetPostProcessingQuality_method {
            static internal IntPtr SetPostProcessingQuality_ptr;
            static SetPostProcessingQuality_method() {
                SetPostProcessingQuality_ptr = Main.GetMethodUFunction(GameUserSettings.StaticClass, "SetPostProcessingQuality");
            }

            internal static unsafe void Invoke(IntPtr obj, int Value) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = Value;
                Main.GetProcessEvent(obj, SetPostProcessingQuality_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetResolutionScaleNormalized_method {
            static internal IntPtr SetResolutionScaleNormalized_ptr;
            static SetResolutionScaleNormalized_method() {
                SetResolutionScaleNormalized_ptr = Main.GetMethodUFunction(GameUserSettings.StaticClass, "SetResolutionScaleNormalized");
            }

            internal static unsafe void Invoke(IntPtr obj, float NewScaleNormalized) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = NewScaleNormalized;
                Main.GetProcessEvent(obj, SetResolutionScaleNormalized_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetResolutionScaleValue_method {
            static internal IntPtr SetResolutionScaleValue_ptr;
            static SetResolutionScaleValue_method() {
                SetResolutionScaleValue_ptr = Main.GetMethodUFunction(GameUserSettings.StaticClass, "SetResolutionScaleValue");
            }

            internal static unsafe void Invoke(IntPtr obj, int NewScaleValue) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = NewScaleValue;
                Main.GetProcessEvent(obj, SetResolutionScaleValue_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetResolutionScaleValueEx_method {
            static internal IntPtr SetResolutionScaleValueEx_ptr;
            static SetResolutionScaleValueEx_method() {
                SetResolutionScaleValueEx_ptr = Main.GetMethodUFunction(GameUserSettings.StaticClass, "SetResolutionScaleValueEx");
            }

            internal static unsafe void Invoke(IntPtr obj, float NewScaleValue) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = NewScaleValue;
                Main.GetProcessEvent(obj, SetResolutionScaleValueEx_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetScreenResolution_method {
            static internal IntPtr SetScreenResolution_ptr;
            static SetScreenResolution_method() {
                SetScreenResolution_ptr = Main.GetMethodUFunction(GameUserSettings.StaticClass, "SetScreenResolution");
            }

            internal static unsafe void Invoke(IntPtr obj, IntPoint Resolution) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPoint*)(b+0)) = Resolution;
                Main.GetProcessEvent(obj, SetScreenResolution_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetShadowQuality_method {
            static internal IntPtr SetShadowQuality_ptr;
            static SetShadowQuality_method() {
                SetShadowQuality_ptr = Main.GetMethodUFunction(GameUserSettings.StaticClass, "SetShadowQuality");
            }

            internal static unsafe void Invoke(IntPtr obj, int Value) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = Value;
                Main.GetProcessEvent(obj, SetShadowQuality_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetTextureQuality_method {
            static internal IntPtr SetTextureQuality_ptr;
            static SetTextureQuality_method() {
                SetTextureQuality_ptr = Main.GetMethodUFunction(GameUserSettings.StaticClass, "SetTextureQuality");
            }

            internal static unsafe void Invoke(IntPtr obj, int Value) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = Value;
                Main.GetProcessEvent(obj, SetTextureQuality_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetToDefaults_method {
            static internal IntPtr SetToDefaults_ptr;
            static SetToDefaults_method() {
                SetToDefaults_ptr = Main.GetMethodUFunction(GameUserSettings.StaticClass, "SetToDefaults");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, SetToDefaults_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetViewDistanceQuality_method {
            static internal IntPtr SetViewDistanceQuality_ptr;
            static SetViewDistanceQuality_method() {
                SetViewDistanceQuality_ptr = Main.GetMethodUFunction(GameUserSettings.StaticClass, "SetViewDistanceQuality");
            }

            internal static unsafe void Invoke(IntPtr obj, int Value) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = Value;
                Main.GetProcessEvent(obj, SetViewDistanceQuality_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetVisualEffectQuality_method {
            static internal IntPtr SetVisualEffectQuality_ptr;
            static SetVisualEffectQuality_method() {
                SetVisualEffectQuality_ptr = Main.GetMethodUFunction(GameUserSettings.StaticClass, "SetVisualEffectQuality");
            }

            internal static unsafe void Invoke(IntPtr obj, int Value) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = Value;
                Main.GetProcessEvent(obj, SetVisualEffectQuality_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetVSyncEnabled_method {
            static internal IntPtr SetVSyncEnabled_ptr;
            static SetVSyncEnabled_method() {
                SetVSyncEnabled_ptr = Main.GetMethodUFunction(GameUserSettings.StaticClass, "SetVSyncEnabled");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bEnable) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bEnable;
                Main.GetProcessEvent(obj, SetVSyncEnabled_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SupportsHDRDisplayOutput_method {
            static internal IntPtr SupportsHDRDisplayOutput_ptr;
            static SupportsHDRDisplayOutput_method() {
                SupportsHDRDisplayOutput_ptr = Main.GetMethodUFunction(GameUserSettings.StaticClass, "SupportsHDRDisplayOutput");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, SupportsHDRDisplayOutput_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct ValidateSettings_method {
            static internal IntPtr ValidateSettings_ptr;
            static ValidateSettings_method() {
                ValidateSettings_ptr = Main.GetMethodUFunction(GameUserSettings.StaticClass, "ValidateSettings");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, ValidateSettings_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct GameUserSettings_events {
    }
}
