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

using UE4.Engine;

namespace UE4.OculusHMD.Native {
    [StructLayout( LayoutKind.Explicit, Size=56 )]
    internal unsafe struct OculusFunctionLibrary_fields {
    }
    internal unsafe struct OculusFunctionLibrary_methods {
        internal struct AddLoadingSplashScreen_method {
            static internal IntPtr AddLoadingSplashScreen_ptr;
            static AddLoadingSplashScreen_method() {
                AddLoadingSplashScreen_ptr = Main.GetMethodUFunction(OculusFunctionLibrary.StaticClass, "AddLoadingSplashScreen");
            }

            internal static unsafe void Invoke(Texture2D Texture, Vector TranslationInMeters, Rotator Rotation, Vector2D SizeInMeters, Rotator DeltaRotation, bool bClearBeforeAdd) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Texture;
                *((Vector*)(b+8)) = TranslationInMeters;
                *((Rotator*)(b+20)) = Rotation;
                *((Vector2D*)(b+32)) = SizeInMeters;
                *((Rotator*)(b+40)) = DeltaRotation;
                *((bool*)(b+52)) = bClearBeforeAdd;
                Main.GetProcessEvent(OculusFunctionLibrary.DefaultObject, AddLoadingSplashScreen_ptr, new IntPtr(p)); ;
            }
        }
        internal struct AreHeadPhonesPluggedIn_method {
            static internal IntPtr AreHeadPhonesPluggedIn_ptr;
            static AreHeadPhonesPluggedIn_method() {
                AreHeadPhonesPluggedIn_ptr = Main.GetMethodUFunction(OculusFunctionLibrary.StaticClass, "AreHeadPhonesPluggedIn");
            }

            internal static unsafe bool Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(OculusFunctionLibrary.DefaultObject, AreHeadPhonesPluggedIn_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct ClearLoadingSplashScreens_method {
            static internal IntPtr ClearLoadingSplashScreens_ptr;
            static ClearLoadingSplashScreens_method() {
                ClearLoadingSplashScreens_ptr = Main.GetMethodUFunction(OculusFunctionLibrary.StaticClass, "ClearLoadingSplashScreens");
            }

            internal static unsafe void Invoke() {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(OculusFunctionLibrary.DefaultObject, ClearLoadingSplashScreens_ptr, new IntPtr(p)); ;
            }
        }
        internal struct EnableArmModel_method {
            static internal IntPtr EnableArmModel_ptr;
            static EnableArmModel_method() {
                EnableArmModel_ptr = Main.GetMethodUFunction(OculusFunctionLibrary.StaticClass, "EnableArmModel");
            }

            internal static unsafe void Invoke(bool bArmModelEnable) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bArmModelEnable;
                Main.GetProcessEvent(OculusFunctionLibrary.DefaultObject, EnableArmModel_ptr, new IntPtr(p)); ;
            }
        }
        internal struct EnableAutoLoadingSplashScreen_method {
            static internal IntPtr EnableAutoLoadingSplashScreen_ptr;
            static EnableAutoLoadingSplashScreen_method() {
                EnableAutoLoadingSplashScreen_ptr = Main.GetMethodUFunction(OculusFunctionLibrary.StaticClass, "EnableAutoLoadingSplashScreen");
            }

            internal static unsafe void Invoke(bool bAutoShowEnabled) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bAutoShowEnabled;
                Main.GetProcessEvent(OculusFunctionLibrary.DefaultObject, EnableAutoLoadingSplashScreen_ptr, new IntPtr(p)); ;
            }
        }
        internal struct GetAvailableDisplayFrequencies_method {
            static internal IntPtr GetAvailableDisplayFrequencies_ptr;
            static GetAvailableDisplayFrequencies_method() {
                GetAvailableDisplayFrequencies_ptr = Main.GetMethodUFunction(OculusFunctionLibrary.StaticClass, "GetAvailableDisplayFrequencies");
            }

            internal static unsafe IReadOnlyCollection<float> Invoke() {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(OculusFunctionLibrary.DefaultObject, GetAvailableDisplayFrequencies_ptr, new IntPtr(p)); ;
                 //TODO: array TArray ReturnValue
                return UObject.ToUnmangedCollection<float>(b+0);
            }
        }
        internal struct GetBaseRotationAndBaseOffsetInMeters_method {
            static internal IntPtr GetBaseRotationAndBaseOffsetInMeters_ptr;
            static GetBaseRotationAndBaseOffsetInMeters_method() {
                GetBaseRotationAndBaseOffsetInMeters_ptr = Main.GetMethodUFunction(OculusFunctionLibrary.StaticClass, "GetBaseRotationAndBaseOffsetInMeters");
            }

            internal static unsafe (Rotator, Vector) Invoke() {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(OculusFunctionLibrary.DefaultObject, GetBaseRotationAndBaseOffsetInMeters_ptr, new IntPtr(p)); ;
                return (*((Rotator*)(b+0)),*((Vector*)(b+12)));
            }
        }
        internal struct GetBaseRotationAndPositionOffset_method {
            static internal IntPtr GetBaseRotationAndPositionOffset_ptr;
            static GetBaseRotationAndPositionOffset_method() {
                GetBaseRotationAndPositionOffset_ptr = Main.GetMethodUFunction(OculusFunctionLibrary.StaticClass, "GetBaseRotationAndPositionOffset");
            }

            internal static unsafe (Rotator, Vector) Invoke() {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(OculusFunctionLibrary.DefaultObject, GetBaseRotationAndPositionOffset_ptr, new IntPtr(p)); ;
                return (*((Rotator*)(b+0)),*((Vector*)(b+12)));
            }
        }
        internal struct GetBatteryLevel_method {
            static internal IntPtr GetBatteryLevel_ptr;
            static GetBatteryLevel_method() {
                GetBatteryLevel_ptr = Main.GetMethodUFunction(OculusFunctionLibrary.StaticClass, "GetBatteryLevel");
            }

            internal static unsafe float Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(OculusFunctionLibrary.DefaultObject, GetBatteryLevel_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetCurrentDisplayFrequency_method {
            static internal IntPtr GetCurrentDisplayFrequency_ptr;
            static GetCurrentDisplayFrequency_method() {
                GetCurrentDisplayFrequency_ptr = Main.GetMethodUFunction(OculusFunctionLibrary.StaticClass, "GetCurrentDisplayFrequency");
            }

            internal static unsafe float Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(OculusFunctionLibrary.DefaultObject, GetCurrentDisplayFrequency_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetDeviceName_method {
            static internal IntPtr GetDeviceName_ptr;
            static GetDeviceName_method() {
                GetDeviceName_ptr = Main.GetMethodUFunction(OculusFunctionLibrary.StaticClass, "GetDeviceName");
            }

            internal static unsafe string Invoke() {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(OculusFunctionLibrary.DefaultObject, GetDeviceName_ptr, new IntPtr(p)); ;
                return FString.Get(b+0);
            }
        }
        internal struct GetGearVRControllerHandedness_method {
            static internal IntPtr GetGearVRControllerHandedness_ptr;
            static GetGearVRControllerHandedness_method() {
                GetGearVRControllerHandedness_ptr = Main.GetMethodUFunction(OculusFunctionLibrary.StaticClass, "GetGearVRControllerHandedness");
            }

            internal static unsafe EGearVRControllerHandedness_DEPRECATED Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(OculusFunctionLibrary.DefaultObject, GetGearVRControllerHandedness_ptr, new IntPtr(p)); ;
                return *((EGearVRControllerHandedness_DEPRECATED*)(b+0));
            }
        }
        internal struct GetGPUUtilization_method {
            static internal IntPtr GetGPUUtilization_ptr;
            static GetGPUUtilization_method() {
                GetGPUUtilization_ptr = Main.GetMethodUFunction(OculusFunctionLibrary.StaticClass, "GetGPUUtilization");
            }

            internal static unsafe (bool, float) Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(OculusFunctionLibrary.DefaultObject, GetGPUUtilization_ptr, new IntPtr(p)); ;
                return (*((bool*)(b+0)),*((float*)(b+4)));
            }
        }
        internal struct GetLoadingSplashParams_method {
            static internal IntPtr GetLoadingSplashParams_ptr;
            static GetLoadingSplashParams_method() {
                GetLoadingSplashParams_ptr = Main.GetMethodUFunction(OculusFunctionLibrary.StaticClass, "GetLoadingSplashParams");
            }

            internal static unsafe (string, Vector, Vector2D, Vector, float) Invoke() {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(OculusFunctionLibrary.DefaultObject, GetLoadingSplashParams_ptr, new IntPtr(p)); ;
                return (FString.Get(b+0),*((Vector*)(b+16)),*((Vector2D*)(b+28)),*((Vector*)(b+36)),*((float*)(b+48)));
            }
        }
        internal struct GetPose_method {
            static internal IntPtr GetPose_ptr;
            static GetPose_method() {
                GetPose_ptr = Main.GetMethodUFunction(OculusFunctionLibrary.StaticClass, "GetPose");
            }

            internal static unsafe (Rotator, Vector, Vector) Invoke(bool bUseOrienationForPlayerCamera, bool bUsePositionForPlayerCamera, Vector PositionScale) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+36)) = bUseOrienationForPlayerCamera;
                *((bool*)(b+37)) = bUsePositionForPlayerCamera;
                *((Vector*)(b+40)) = PositionScale;
                Main.GetProcessEvent(OculusFunctionLibrary.DefaultObject, GetPose_ptr, new IntPtr(p)); ;
                return (*((Rotator*)(b+0)),*((Vector*)(b+12)),*((Vector*)(b+24)));
            }
        }
        internal struct GetRawSensorData_method {
            static internal IntPtr GetRawSensorData_ptr;
            static GetRawSensorData_method() {
                GetRawSensorData_ptr = Main.GetMethodUFunction(OculusFunctionLibrary.StaticClass, "GetRawSensorData");
            }

            internal static unsafe (Vector, Vector, Vector, Vector, float) Invoke(ETrackedDeviceType DeviceType) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *(b+52) = (byte)DeviceType;
                Main.GetProcessEvent(OculusFunctionLibrary.DefaultObject, GetRawSensorData_ptr, new IntPtr(p)); ;
                return (*((Vector*)(b+0)),*((Vector*)(b+12)),*((Vector*)(b+24)),*((Vector*)(b+36)),*((float*)(b+48)));
            }
        }
        internal struct GetTemperatureInCelsius_method {
            static internal IntPtr GetTemperatureInCelsius_ptr;
            static GetTemperatureInCelsius_method() {
                GetTemperatureInCelsius_ptr = Main.GetMethodUFunction(OculusFunctionLibrary.StaticClass, "GetTemperatureInCelsius");
            }

            internal static unsafe float Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(OculusFunctionLibrary.DefaultObject, GetTemperatureInCelsius_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetTiledMultiresLevel_method {
            static internal IntPtr GetTiledMultiresLevel_ptr;
            static GetTiledMultiresLevel_method() {
                GetTiledMultiresLevel_ptr = Main.GetMethodUFunction(OculusFunctionLibrary.StaticClass, "GetTiledMultiresLevel");
            }

            internal static unsafe ETiledMultiResLevel Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(OculusFunctionLibrary.DefaultObject, GetTiledMultiresLevel_ptr, new IntPtr(p)); ;
                return *((ETiledMultiResLevel*)(b+0));
            }
        }
        internal struct GetUserProfile_method {
            static internal IntPtr GetUserProfile_ptr;
            static GetUserProfile_method() {
                GetUserProfile_ptr = Main.GetMethodUFunction(OculusFunctionLibrary.StaticClass, "GetUserProfile");
            }

            internal static unsafe (HmdUserProfile, bool) Invoke() {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(OculusFunctionLibrary.DefaultObject, GetUserProfile_ptr, new IntPtr(p)); ;
                return (*((HmdUserProfile*)(b+0)),*((bool*)(b+72)));
            }
        }
        internal struct HasInputFocus_method {
            static internal IntPtr HasInputFocus_ptr;
            static HasInputFocus_method() {
                HasInputFocus_ptr = Main.GetMethodUFunction(OculusFunctionLibrary.StaticClass, "HasInputFocus");
            }

            internal static unsafe bool Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(OculusFunctionLibrary.DefaultObject, HasInputFocus_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct HasSystemOverlayPresent_method {
            static internal IntPtr HasSystemOverlayPresent_ptr;
            static HasSystemOverlayPresent_method() {
                HasSystemOverlayPresent_ptr = Main.GetMethodUFunction(OculusFunctionLibrary.StaticClass, "HasSystemOverlayPresent");
            }

            internal static unsafe bool Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(OculusFunctionLibrary.DefaultObject, HasSystemOverlayPresent_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct HideLoadingIcon_method {
            static internal IntPtr HideLoadingIcon_ptr;
            static HideLoadingIcon_method() {
                HideLoadingIcon_ptr = Main.GetMethodUFunction(OculusFunctionLibrary.StaticClass, "HideLoadingIcon");
            }

            internal static unsafe void Invoke() {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(OculusFunctionLibrary.DefaultObject, HideLoadingIcon_ptr, new IntPtr(p)); ;
            }
        }
        internal struct HideLoadingSplashScreen_method {
            static internal IntPtr HideLoadingSplashScreen_ptr;
            static HideLoadingSplashScreen_method() {
                HideLoadingSplashScreen_ptr = Main.GetMethodUFunction(OculusFunctionLibrary.StaticClass, "HideLoadingSplashScreen");
            }

            internal static unsafe void Invoke(bool bClear) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bClear;
                Main.GetProcessEvent(OculusFunctionLibrary.DefaultObject, HideLoadingSplashScreen_ptr, new IntPtr(p)); ;
            }
        }
        internal struct IsAutoLoadingSplashScreenEnabled_method {
            static internal IntPtr IsAutoLoadingSplashScreenEnabled_ptr;
            static IsAutoLoadingSplashScreenEnabled_method() {
                IsAutoLoadingSplashScreenEnabled_ptr = Main.GetMethodUFunction(OculusFunctionLibrary.StaticClass, "IsAutoLoadingSplashScreenEnabled");
            }

            internal static unsafe bool Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(OculusFunctionLibrary.DefaultObject, IsAutoLoadingSplashScreenEnabled_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsControllerActive_method {
            static internal IntPtr IsControllerActive_ptr;
            static IsControllerActive_method() {
                IsControllerActive_ptr = Main.GetMethodUFunction(OculusFunctionLibrary.StaticClass, "IsControllerActive");
            }

            internal static unsafe bool Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(OculusFunctionLibrary.DefaultObject, IsControllerActive_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsDeviceTracked_method {
            static internal IntPtr IsDeviceTracked_ptr;
            static IsDeviceTracked_method() {
                IsDeviceTracked_ptr = Main.GetMethodUFunction(OculusFunctionLibrary.StaticClass, "IsDeviceTracked");
            }

            internal static unsafe bool Invoke(ETrackedDeviceType DeviceType) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = (byte)DeviceType;
                Main.GetProcessEvent(OculusFunctionLibrary.DefaultObject, IsDeviceTracked_ptr, new IntPtr(p)); ;
                return *((bool*)(b+1));
            }
        }
        internal struct IsLoadingIconEnabled_method {
            static internal IntPtr IsLoadingIconEnabled_ptr;
            static IsLoadingIconEnabled_method() {
                IsLoadingIconEnabled_ptr = Main.GetMethodUFunction(OculusFunctionLibrary.StaticClass, "IsLoadingIconEnabled");
            }

            internal static unsafe bool Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(OculusFunctionLibrary.DefaultObject, IsLoadingIconEnabled_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsPowerLevelStateMinimum_method {
            static internal IntPtr IsPowerLevelStateMinimum_ptr;
            static IsPowerLevelStateMinimum_method() {
                IsPowerLevelStateMinimum_ptr = Main.GetMethodUFunction(OculusFunctionLibrary.StaticClass, "IsPowerLevelStateMinimum");
            }

            internal static unsafe bool Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(OculusFunctionLibrary.DefaultObject, IsPowerLevelStateMinimum_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsPowerLevelStateThrottled_method {
            static internal IntPtr IsPowerLevelStateThrottled_ptr;
            static IsPowerLevelStateThrottled_method() {
                IsPowerLevelStateThrottled_ptr = Main.GetMethodUFunction(OculusFunctionLibrary.StaticClass, "IsPowerLevelStateThrottled");
            }

            internal static unsafe bool Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(OculusFunctionLibrary.DefaultObject, IsPowerLevelStateThrottled_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct SetBaseRotationAndBaseOffsetInMeters_method {
            static internal IntPtr SetBaseRotationAndBaseOffsetInMeters_ptr;
            static SetBaseRotationAndBaseOffsetInMeters_method() {
                SetBaseRotationAndBaseOffsetInMeters_ptr = Main.GetMethodUFunction(OculusFunctionLibrary.StaticClass, "SetBaseRotationAndBaseOffsetInMeters");
            }

            internal static unsafe void Invoke(Rotator Rotation, Vector BaseOffsetInMeters, byte Options) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Rotator*)(b+0)) = Rotation;
                *((Vector*)(b+12)) = BaseOffsetInMeters;
                *(b+24) = Options;
                Main.GetProcessEvent(OculusFunctionLibrary.DefaultObject, SetBaseRotationAndBaseOffsetInMeters_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetBaseRotationAndPositionOffset_method {
            static internal IntPtr SetBaseRotationAndPositionOffset_ptr;
            static SetBaseRotationAndPositionOffset_method() {
                SetBaseRotationAndPositionOffset_ptr = Main.GetMethodUFunction(OculusFunctionLibrary.StaticClass, "SetBaseRotationAndPositionOffset");
            }

            internal static unsafe void Invoke(Rotator BaseRot, Vector PosOffset, byte Options) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Rotator*)(b+0)) = BaseRot;
                *((Vector*)(b+12)) = PosOffset;
                *(b+24) = Options;
                Main.GetProcessEvent(OculusFunctionLibrary.DefaultObject, SetBaseRotationAndPositionOffset_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetCPUAndGPULevels_method {
            static internal IntPtr SetCPUAndGPULevels_ptr;
            static SetCPUAndGPULevels_method() {
                SetCPUAndGPULevels_ptr = Main.GetMethodUFunction(OculusFunctionLibrary.StaticClass, "SetCPUAndGPULevels");
            }

            internal static unsafe void Invoke(int CPULevel, int GPULevel) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = CPULevel;
                *((int*)(b+4)) = GPULevel;
                Main.GetProcessEvent(OculusFunctionLibrary.DefaultObject, SetCPUAndGPULevels_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetDisplayFrequency_method {
            static internal IntPtr SetDisplayFrequency_ptr;
            static SetDisplayFrequency_method() {
                SetDisplayFrequency_ptr = Main.GetMethodUFunction(OculusFunctionLibrary.StaticClass, "SetDisplayFrequency");
            }

            internal static unsafe void Invoke(float RequestedFrequency) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = RequestedFrequency;
                Main.GetProcessEvent(OculusFunctionLibrary.DefaultObject, SetDisplayFrequency_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetLoadingSplashParams_method {
            static internal IntPtr SetLoadingSplashParams_ptr;
            static SetLoadingSplashParams_method() {
                SetLoadingSplashParams_ptr = Main.GetMethodUFunction(OculusFunctionLibrary.StaticClass, "SetLoadingSplashParams");
            }

            internal static unsafe void Invoke(string TexturePath, Vector DistanceInMeters, Vector2D SizeInMeters, Vector RotationAxis, float RotationDeltaInDeg) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var TexturePath_handle = GCHandle.Alloc(TexturePath, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = TexturePath_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = TexturePath.Length;
                *(int*)(b+IntPtr.Size+4+0) = TexturePath.Length;
                *((Vector*)(b+16)) = DistanceInMeters;
                *((Vector2D*)(b+28)) = SizeInMeters;
                *((Vector*)(b+36)) = RotationAxis;
                *((float*)(b+48)) = RotationDeltaInDeg;
                Main.GetProcessEvent(OculusFunctionLibrary.DefaultObject, SetLoadingSplashParams_ptr, new IntPtr(p)); ;
                TexturePath_handle.Free();
            }
        }
        internal struct SetPositionScale3D_method {
            static internal IntPtr SetPositionScale3D_ptr;
            static SetPositionScale3D_method() {
                SetPositionScale3D_ptr = Main.GetMethodUFunction(OculusFunctionLibrary.StaticClass, "SetPositionScale3D");
            }

            internal static unsafe void Invoke(Vector PosScale3D) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = PosScale3D;
                Main.GetProcessEvent(OculusFunctionLibrary.DefaultObject, SetPositionScale3D_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetTiledMultiresLevel_method {
            static internal IntPtr SetTiledMultiresLevel_ptr;
            static SetTiledMultiresLevel_method() {
                SetTiledMultiresLevel_ptr = Main.GetMethodUFunction(OculusFunctionLibrary.StaticClass, "SetTiledMultiresLevel");
            }

            internal static unsafe void Invoke(ETiledMultiResLevel level) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = (byte)level;
                Main.GetProcessEvent(OculusFunctionLibrary.DefaultObject, SetTiledMultiresLevel_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ShowLoadingIcon_method {
            static internal IntPtr ShowLoadingIcon_ptr;
            static ShowLoadingIcon_method() {
                ShowLoadingIcon_ptr = Main.GetMethodUFunction(OculusFunctionLibrary.StaticClass, "ShowLoadingIcon");
            }

            internal static unsafe void Invoke(Texture2D Texture) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Texture;
                Main.GetProcessEvent(OculusFunctionLibrary.DefaultObject, ShowLoadingIcon_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ShowLoadingSplashScreen_method {
            static internal IntPtr ShowLoadingSplashScreen_ptr;
            static ShowLoadingSplashScreen_method() {
                ShowLoadingSplashScreen_ptr = Main.GetMethodUFunction(OculusFunctionLibrary.StaticClass, "ShowLoadingSplashScreen");
            }

            internal static unsafe void Invoke() {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(OculusFunctionLibrary.DefaultObject, ShowLoadingSplashScreen_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct OculusFunctionLibrary_events {
    }
}
