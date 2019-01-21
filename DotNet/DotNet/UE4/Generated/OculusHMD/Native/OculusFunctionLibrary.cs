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
        internal struct EnableOrientationTracking_method {
            static internal IntPtr EnableOrientationTracking_ptr;
            static EnableOrientationTracking_method() {
                EnableOrientationTracking_ptr = Main.GetMethodUFunction(OculusFunctionLibrary.StaticClass, "EnableOrientationTracking");
            }

            internal static unsafe void Invoke(bool bOrientationTracking) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bOrientationTracking;
                Main.GetProcessEvent(OculusFunctionLibrary.DefaultObject, EnableOrientationTracking_ptr, new IntPtr(p)); ;
            }
        }
        internal struct EnablePositionTracking_method {
            static internal IntPtr EnablePositionTracking_ptr;
            static EnablePositionTracking_method() {
                EnablePositionTracking_ptr = Main.GetMethodUFunction(OculusFunctionLibrary.StaticClass, "EnablePositionTracking");
            }

            internal static unsafe void Invoke(bool bPositionTracking) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bPositionTracking;
                Main.GetProcessEvent(OculusFunctionLibrary.DefaultObject, EnablePositionTracking_ptr, new IntPtr(p)); ;
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
        internal struct GetGPUFrameTime_method {
            static internal IntPtr GetGPUFrameTime_ptr;
            static GetGPUFrameTime_method() {
                GetGPUFrameTime_ptr = Main.GetMethodUFunction(OculusFunctionLibrary.StaticClass, "GetGPUFrameTime");
            }

            internal static unsafe float Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(OculusFunctionLibrary.DefaultObject, GetGPUFrameTime_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
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
        internal struct GetGuardianDimensions_method {
            static internal IntPtr GetGuardianDimensions_ptr;
            static GetGuardianDimensions_method() {
                GetGuardianDimensions_ptr = Main.GetMethodUFunction(OculusFunctionLibrary.StaticClass, "GetGuardianDimensions");
            }

            internal static unsafe Vector Invoke(EBoundaryType BoundaryType) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *(b+0) = (byte)BoundaryType;
                Main.GetProcessEvent(OculusFunctionLibrary.DefaultObject, GetGuardianDimensions_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+4));
            }
        }
        internal struct GetGuardianPoints_method {
            static internal IntPtr GetGuardianPoints_ptr;
            static GetGuardianPoints_method() {
                GetGuardianPoints_ptr = Main.GetMethodUFunction(OculusFunctionLibrary.StaticClass, "GetGuardianPoints");
            }

            internal static unsafe IReadOnlyCollection<Vector> Invoke(EBoundaryType BoundaryType) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *(b+0) = (byte)BoundaryType;
                Main.GetProcessEvent(OculusFunctionLibrary.DefaultObject, GetGuardianPoints_ptr, new IntPtr(p)); ;
                 //TODO: array TArray ReturnValue
                return UObject.ToUnmangedCollection<Vector>(b+8);
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
        internal struct GetNodeGuardianIntersection_method {
            static internal IntPtr GetNodeGuardianIntersection_ptr;
            static GetNodeGuardianIntersection_method() {
                GetNodeGuardianIntersection_ptr = Main.GetMethodUFunction(OculusFunctionLibrary.StaticClass, "GetNodeGuardianIntersection");
            }

            internal static unsafe GuardianTestResult Invoke(ETrackedDeviceType DeviceType, EBoundaryType BoundaryType) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *(b+0) = (byte)DeviceType;
                *(b+1) = (byte)BoundaryType;
                Main.GetProcessEvent(OculusFunctionLibrary.DefaultObject, GetNodeGuardianIntersection_ptr, new IntPtr(p)); ;
                return *((GuardianTestResult*)(b+4));
            }
        }
        internal struct GetPlayAreaTransform_method {
            static internal IntPtr GetPlayAreaTransform_ptr;
            static GetPlayAreaTransform_method() {
                GetPlayAreaTransform_ptr = Main.GetMethodUFunction(OculusFunctionLibrary.StaticClass, "GetPlayAreaTransform");
            }

            internal static unsafe Transform Invoke() {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(OculusFunctionLibrary.DefaultObject, GetPlayAreaTransform_ptr, new IntPtr(p)); ;
                return *((Transform*)(b+0));
            }
        }
        internal struct GetPointGuardianIntersection_method {
            static internal IntPtr GetPointGuardianIntersection_ptr;
            static GetPointGuardianIntersection_method() {
                GetPointGuardianIntersection_ptr = Main.GetMethodUFunction(OculusFunctionLibrary.StaticClass, "GetPointGuardianIntersection");
            }

            internal static unsafe GuardianTestResult Invoke(Vector Point, EBoundaryType BoundaryType) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = Point;
                *(b+12) = (byte)BoundaryType;
                Main.GetProcessEvent(OculusFunctionLibrary.DefaultObject, GetPointGuardianIntersection_ptr, new IntPtr(p)); ;
                return *((GuardianTestResult*)(b+16));
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
        internal struct IsGuardianDisplayed_method {
            static internal IntPtr IsGuardianDisplayed_ptr;
            static IsGuardianDisplayed_method() {
                IsGuardianDisplayed_ptr = Main.GetMethodUFunction(OculusFunctionLibrary.StaticClass, "IsGuardianDisplayed");
            }

            internal static unsafe bool Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(OculusFunctionLibrary.DefaultObject, IsGuardianDisplayed_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
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
        internal struct SetGuardianVisibility_method {
            static internal IntPtr SetGuardianVisibility_ptr;
            static SetGuardianVisibility_method() {
                SetGuardianVisibility_ptr = Main.GetMethodUFunction(OculusFunctionLibrary.StaticClass, "SetGuardianVisibility");
            }

            internal static unsafe void Invoke(bool GuardianVisible) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = GuardianVisible;
                Main.GetProcessEvent(OculusFunctionLibrary.DefaultObject, SetGuardianVisibility_ptr, new IntPtr(p)); ;
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
        internal struct SetReorientHMDOnControllerRecenter_method {
            static internal IntPtr SetReorientHMDOnControllerRecenter_ptr;
            static SetReorientHMDOnControllerRecenter_method() {
                SetReorientHMDOnControllerRecenter_ptr = Main.GetMethodUFunction(OculusFunctionLibrary.StaticClass, "SetReorientHMDOnControllerRecenter");
            }

            internal static unsafe void Invoke(bool recenterMode) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = recenterMode;
                Main.GetProcessEvent(OculusFunctionLibrary.DefaultObject, SetReorientHMDOnControllerRecenter_ptr, new IntPtr(p)); ;
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
