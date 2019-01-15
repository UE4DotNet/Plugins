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

namespace UE4.HeadMountedDisplay.Native {
    [StructLayout( LayoutKind.Explicit, Size=56 )]
    internal unsafe struct HeadMountedDisplayFunctionLibrary_fields {
    }
    internal unsafe struct HeadMountedDisplayFunctionLibrary_methods {
        internal struct EnableHMD_method {
            static internal IntPtr EnableHMD_ptr;
            static EnableHMD_method() {
                EnableHMD_ptr = Main.GetMethodUFunction(HeadMountedDisplayFunctionLibrary.StaticClass, "EnableHMD");
            }

            internal static unsafe bool Invoke(bool bEnable) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bEnable;
                Main.GetProcessEvent(HeadMountedDisplayFunctionLibrary.DefaultObject, EnableHMD_ptr, new IntPtr(p)); ;
                return *((bool*)(b+1));
            }
        }
        internal struct EnableLowPersistenceMode_method {
            static internal IntPtr EnableLowPersistenceMode_ptr;
            static EnableLowPersistenceMode_method() {
                EnableLowPersistenceMode_ptr = Main.GetMethodUFunction(HeadMountedDisplayFunctionLibrary.StaticClass, "EnableLowPersistenceMode");
            }

            internal static unsafe void Invoke(bool bEnable) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bEnable;
                Main.GetProcessEvent(HeadMountedDisplayFunctionLibrary.DefaultObject, EnableLowPersistenceMode_ptr, new IntPtr(p)); ;
            }
        }
        internal struct EnumerateTrackedDevices_method {
            static internal IntPtr EnumerateTrackedDevices_ptr;
            static EnumerateTrackedDevices_method() {
                EnumerateTrackedDevices_ptr = Main.GetMethodUFunction(HeadMountedDisplayFunctionLibrary.StaticClass, "EnumerateTrackedDevices");
            }

            internal static unsafe IReadOnlyCollection<XRDeviceId> Invoke(Name SystemId, EXRTrackedDeviceType DeviceType) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = SystemId;
                *(b+12) = (byte)DeviceType;
                Main.GetProcessEvent(HeadMountedDisplayFunctionLibrary.DefaultObject, EnumerateTrackedDevices_ptr, new IntPtr(p)); ;
                 //TODO: array TArray ReturnValue
                return UObject.ToUnmangedCollection<XRDeviceId>(b+16);
            }
        }
        internal struct GetDevicePose_method {
            static internal IntPtr GetDevicePose_ptr;
            static GetDevicePose_method() {
                GetDevicePose_ptr = Main.GetMethodUFunction(HeadMountedDisplayFunctionLibrary.StaticClass, "GetDevicePose");
            }

            internal static unsafe (bool, Rotator, bool, Vector) Invoke(XRDeviceId XRDeviceId) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((XRDeviceId*)(b+0)) = XRDeviceId;
                Main.GetProcessEvent(HeadMountedDisplayFunctionLibrary.DefaultObject, GetDevicePose_ptr, new IntPtr(p)); ;
                return (*((bool*)(b+16)),*((Rotator*)(b+20)),*((bool*)(b+32)),*((Vector*)(b+36)));
            }
        }
        internal struct GetDeviceWorldPose_method {
            static internal IntPtr GetDeviceWorldPose_ptr;
            static GetDeviceWorldPose_method() {
                GetDeviceWorldPose_ptr = Main.GetMethodUFunction(HeadMountedDisplayFunctionLibrary.StaticClass, "GetDeviceWorldPose");
            }

            internal static unsafe (bool, Rotator, bool, Vector) Invoke(UObject WorldContext, XRDeviceId XRDeviceId) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContext;
                *((XRDeviceId*)(b+8)) = XRDeviceId;
                Main.GetProcessEvent(HeadMountedDisplayFunctionLibrary.DefaultObject, GetDeviceWorldPose_ptr, new IntPtr(p)); ;
                return (*((bool*)(b+24)),*((Rotator*)(b+28)),*((bool*)(b+40)),*((Vector*)(b+44)));
            }
        }
        internal struct GetHMDDeviceName_method {
            static internal IntPtr GetHMDDeviceName_ptr;
            static GetHMDDeviceName_method() {
                GetHMDDeviceName_ptr = Main.GetMethodUFunction(HeadMountedDisplayFunctionLibrary.StaticClass, "GetHMDDeviceName");
            }

            internal static unsafe Name Invoke() {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(HeadMountedDisplayFunctionLibrary.DefaultObject, GetHMDDeviceName_ptr, new IntPtr(p)); ;
                return *((Name*)(b+0));
            }
        }
        internal struct GetHMDWornState_method {
            static internal IntPtr GetHMDWornState_ptr;
            static GetHMDWornState_method() {
                GetHMDWornState_ptr = Main.GetMethodUFunction(HeadMountedDisplayFunctionLibrary.StaticClass, "GetHMDWornState");
            }

            internal static unsafe byte Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(HeadMountedDisplayFunctionLibrary.DefaultObject, GetHMDWornState_ptr, new IntPtr(p)); ;
                return *(b+0);
            }
        }
        internal struct GetNumOfTrackingSensors_method {
            static internal IntPtr GetNumOfTrackingSensors_ptr;
            static GetNumOfTrackingSensors_method() {
                GetNumOfTrackingSensors_ptr = Main.GetMethodUFunction(HeadMountedDisplayFunctionLibrary.StaticClass, "GetNumOfTrackingSensors");
            }

            internal static unsafe int Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(HeadMountedDisplayFunctionLibrary.DefaultObject, GetNumOfTrackingSensors_ptr, new IntPtr(p)); ;
                return *((int*)(b+0));
            }
        }
        internal struct GetOrientationAndPosition_method {
            static internal IntPtr GetOrientationAndPosition_ptr;
            static GetOrientationAndPosition_method() {
                GetOrientationAndPosition_ptr = Main.GetMethodUFunction(HeadMountedDisplayFunctionLibrary.StaticClass, "GetOrientationAndPosition");
            }

            internal static unsafe (Rotator, Vector) Invoke() {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(HeadMountedDisplayFunctionLibrary.DefaultObject, GetOrientationAndPosition_ptr, new IntPtr(p)); ;
                return (*((Rotator*)(b+0)),*((Vector*)(b+12)));
            }
        }
        internal struct GetPixelDensity_method {
            static internal IntPtr GetPixelDensity_ptr;
            static GetPixelDensity_method() {
                GetPixelDensity_ptr = Main.GetMethodUFunction(HeadMountedDisplayFunctionLibrary.StaticClass, "GetPixelDensity");
            }

            internal static unsafe float Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(HeadMountedDisplayFunctionLibrary.DefaultObject, GetPixelDensity_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetPositionalTrackingCameraParameters_method {
            static internal IntPtr GetPositionalTrackingCameraParameters_ptr;
            static GetPositionalTrackingCameraParameters_method() {
                GetPositionalTrackingCameraParameters_ptr = Main.GetMethodUFunction(HeadMountedDisplayFunctionLibrary.StaticClass, "GetPositionalTrackingCameraParameters");
            }

            internal static unsafe (Vector, Rotator, float, float, float, float, float) Invoke() {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(HeadMountedDisplayFunctionLibrary.DefaultObject, GetPositionalTrackingCameraParameters_ptr, new IntPtr(p)); ;
                return (*((Vector*)(b+0)),*((Rotator*)(b+12)),*((float*)(b+24)),*((float*)(b+28)),*((float*)(b+32)),*((float*)(b+36)),*((float*)(b+40)));
            }
        }
        internal struct GetScreenPercentage_method {
            static internal IntPtr GetScreenPercentage_ptr;
            static GetScreenPercentage_method() {
                GetScreenPercentage_ptr = Main.GetMethodUFunction(HeadMountedDisplayFunctionLibrary.StaticClass, "GetScreenPercentage");
            }

            internal static unsafe float Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(HeadMountedDisplayFunctionLibrary.DefaultObject, GetScreenPercentage_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetTrackingOrigin_method {
            static internal IntPtr GetTrackingOrigin_ptr;
            static GetTrackingOrigin_method() {
                GetTrackingOrigin_ptr = Main.GetMethodUFunction(HeadMountedDisplayFunctionLibrary.StaticClass, "GetTrackingOrigin");
            }

            internal static unsafe byte Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(HeadMountedDisplayFunctionLibrary.DefaultObject, GetTrackingOrigin_ptr, new IntPtr(p)); ;
                return *(b+0);
            }
        }
        internal struct GetTrackingSensorParameters_method {
            static internal IntPtr GetTrackingSensorParameters_ptr;
            static GetTrackingSensorParameters_method() {
                GetTrackingSensorParameters_ptr = Main.GetMethodUFunction(HeadMountedDisplayFunctionLibrary.StaticClass, "GetTrackingSensorParameters");
            }

            internal static unsafe (Vector, Rotator, float, float, float, float, float, float, float, bool) Invoke(int Index) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+56)) = Index;
                Main.GetProcessEvent(HeadMountedDisplayFunctionLibrary.DefaultObject, GetTrackingSensorParameters_ptr, new IntPtr(p)); ;
                return (*((Vector*)(b+0)),*((Rotator*)(b+12)),*((float*)(b+24)),*((float*)(b+28)),*((float*)(b+32)),*((float*)(b+36)),*((float*)(b+40)),*((float*)(b+44)),*((float*)(b+48)),*((bool*)(b+52)));
            }
        }
        internal struct GetTrackingToWorldTransform_method {
            static internal IntPtr GetTrackingToWorldTransform_ptr;
            static GetTrackingToWorldTransform_method() {
                GetTrackingToWorldTransform_ptr = Main.GetMethodUFunction(HeadMountedDisplayFunctionLibrary.StaticClass, "GetTrackingToWorldTransform");
            }

            internal static unsafe Transform Invoke(UObject WorldContext) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContext;
                Main.GetProcessEvent(HeadMountedDisplayFunctionLibrary.DefaultObject, GetTrackingToWorldTransform_ptr, new IntPtr(p)); ;
                return *((Transform*)(b+16));
            }
        }
        internal struct GetVRFocusState_method {
            static internal IntPtr GetVRFocusState_ptr;
            static GetVRFocusState_method() {
                GetVRFocusState_ptr = Main.GetMethodUFunction(HeadMountedDisplayFunctionLibrary.StaticClass, "GetVRFocusState");
            }

            internal static unsafe (bool, bool) Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(HeadMountedDisplayFunctionLibrary.DefaultObject, GetVRFocusState_ptr, new IntPtr(p)); ;
                return (*((bool*)(b+0)),*((bool*)(b+1)));
            }
        }
        internal struct GetWorldToMetersScale_method {
            static internal IntPtr GetWorldToMetersScale_ptr;
            static GetWorldToMetersScale_method() {
                GetWorldToMetersScale_ptr = Main.GetMethodUFunction(HeadMountedDisplayFunctionLibrary.StaticClass, "GetWorldToMetersScale");
            }

            internal static unsafe float Invoke(UObject WorldContext) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContext;
                Main.GetProcessEvent(HeadMountedDisplayFunctionLibrary.DefaultObject, GetWorldToMetersScale_ptr, new IntPtr(p)); ;
                return *((float*)(b+8));
            }
        }
        internal struct HasValidTrackingPosition_method {
            static internal IntPtr HasValidTrackingPosition_ptr;
            static HasValidTrackingPosition_method() {
                HasValidTrackingPosition_ptr = Main.GetMethodUFunction(HeadMountedDisplayFunctionLibrary.StaticClass, "HasValidTrackingPosition");
            }

            internal static unsafe bool Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(HeadMountedDisplayFunctionLibrary.DefaultObject, HasValidTrackingPosition_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsDeviceTracking_method {
            static internal IntPtr IsDeviceTracking_ptr;
            static IsDeviceTracking_method() {
                IsDeviceTracking_ptr = Main.GetMethodUFunction(HeadMountedDisplayFunctionLibrary.StaticClass, "IsDeviceTracking");
            }

            internal static unsafe bool Invoke(XRDeviceId XRDeviceId) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((XRDeviceId*)(b+0)) = XRDeviceId;
                Main.GetProcessEvent(HeadMountedDisplayFunctionLibrary.DefaultObject, IsDeviceTracking_ptr, new IntPtr(p)); ;
                return *((bool*)(b+16));
            }
        }
        internal struct IsHeadMountedDisplayConnected_method {
            static internal IntPtr IsHeadMountedDisplayConnected_ptr;
            static IsHeadMountedDisplayConnected_method() {
                IsHeadMountedDisplayConnected_ptr = Main.GetMethodUFunction(HeadMountedDisplayFunctionLibrary.StaticClass, "IsHeadMountedDisplayConnected");
            }

            internal static unsafe bool Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(HeadMountedDisplayFunctionLibrary.DefaultObject, IsHeadMountedDisplayConnected_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsHeadMountedDisplayEnabled_method {
            static internal IntPtr IsHeadMountedDisplayEnabled_ptr;
            static IsHeadMountedDisplayEnabled_method() {
                IsHeadMountedDisplayEnabled_ptr = Main.GetMethodUFunction(HeadMountedDisplayFunctionLibrary.StaticClass, "IsHeadMountedDisplayEnabled");
            }

            internal static unsafe bool Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(HeadMountedDisplayFunctionLibrary.DefaultObject, IsHeadMountedDisplayEnabled_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsInLowPersistenceMode_method {
            static internal IntPtr IsInLowPersistenceMode_ptr;
            static IsInLowPersistenceMode_method() {
                IsInLowPersistenceMode_ptr = Main.GetMethodUFunction(HeadMountedDisplayFunctionLibrary.StaticClass, "IsInLowPersistenceMode");
            }

            internal static unsafe bool Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(HeadMountedDisplayFunctionLibrary.DefaultObject, IsInLowPersistenceMode_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsSpectatorScreenModeControllable_method {
            static internal IntPtr IsSpectatorScreenModeControllable_ptr;
            static IsSpectatorScreenModeControllable_method() {
                IsSpectatorScreenModeControllable_ptr = Main.GetMethodUFunction(HeadMountedDisplayFunctionLibrary.StaticClass, "IsSpectatorScreenModeControllable");
            }

            internal static unsafe bool Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(HeadMountedDisplayFunctionLibrary.DefaultObject, IsSpectatorScreenModeControllable_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct ResetOrientationAndPosition_method {
            static internal IntPtr ResetOrientationAndPosition_ptr;
            static ResetOrientationAndPosition_method() {
                ResetOrientationAndPosition_ptr = Main.GetMethodUFunction(HeadMountedDisplayFunctionLibrary.StaticClass, "ResetOrientationAndPosition");
            }

            internal static unsafe void Invoke(float Yaw, byte Options) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Yaw;
                *(b+4) = Options;
                Main.GetProcessEvent(HeadMountedDisplayFunctionLibrary.DefaultObject, ResetOrientationAndPosition_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetClippingPlanes_method {
            static internal IntPtr SetClippingPlanes_ptr;
            static SetClippingPlanes_method() {
                SetClippingPlanes_ptr = Main.GetMethodUFunction(HeadMountedDisplayFunctionLibrary.StaticClass, "SetClippingPlanes");
            }

            internal static unsafe void Invoke(float Near, float Far) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Near;
                *((float*)(b+4)) = Far;
                Main.GetProcessEvent(HeadMountedDisplayFunctionLibrary.DefaultObject, SetClippingPlanes_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetSpectatorScreenMode_method {
            static internal IntPtr SetSpectatorScreenMode_ptr;
            static SetSpectatorScreenMode_method() {
                SetSpectatorScreenMode_ptr = Main.GetMethodUFunction(HeadMountedDisplayFunctionLibrary.StaticClass, "SetSpectatorScreenMode");
            }

            internal static unsafe void Invoke(ESpectatorScreenMode Mode) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = (byte)Mode;
                Main.GetProcessEvent(HeadMountedDisplayFunctionLibrary.DefaultObject, SetSpectatorScreenMode_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetSpectatorScreenModeTexturePlusEyeLayout_method {
            static internal IntPtr SetSpectatorScreenModeTexturePlusEyeLayout_ptr;
            static SetSpectatorScreenModeTexturePlusEyeLayout_method() {
                SetSpectatorScreenModeTexturePlusEyeLayout_ptr = Main.GetMethodUFunction(HeadMountedDisplayFunctionLibrary.StaticClass, "SetSpectatorScreenModeTexturePlusEyeLayout");
            }

            internal static unsafe void Invoke(Vector2D EyeRectMin, Vector2D EyeRectMax, Vector2D TextureRectMin, Vector2D TextureRectMax, bool bDrawEyeFirst, bool bClearBlack) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector2D*)(b+0)) = EyeRectMin;
                *((Vector2D*)(b+8)) = EyeRectMax;
                *((Vector2D*)(b+16)) = TextureRectMin;
                *((Vector2D*)(b+24)) = TextureRectMax;
                *((bool*)(b+32)) = bDrawEyeFirst;
                *((bool*)(b+33)) = bClearBlack;
                Main.GetProcessEvent(HeadMountedDisplayFunctionLibrary.DefaultObject, SetSpectatorScreenModeTexturePlusEyeLayout_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetSpectatorScreenTexture_method {
            static internal IntPtr SetSpectatorScreenTexture_ptr;
            static SetSpectatorScreenTexture_method() {
                SetSpectatorScreenTexture_ptr = Main.GetMethodUFunction(HeadMountedDisplayFunctionLibrary.StaticClass, "SetSpectatorScreenTexture");
            }

            internal static unsafe void Invoke(Texture InTexture) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = InTexture;
                Main.GetProcessEvent(HeadMountedDisplayFunctionLibrary.DefaultObject, SetSpectatorScreenTexture_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetTrackingOrigin_method {
            static internal IntPtr SetTrackingOrigin_ptr;
            static SetTrackingOrigin_method() {
                SetTrackingOrigin_ptr = Main.GetMethodUFunction(HeadMountedDisplayFunctionLibrary.StaticClass, "SetTrackingOrigin");
            }

            internal static unsafe void Invoke(byte Origin) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = Origin;
                Main.GetProcessEvent(HeadMountedDisplayFunctionLibrary.DefaultObject, SetTrackingOrigin_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetWorldToMetersScale_method {
            static internal IntPtr SetWorldToMetersScale_ptr;
            static SetWorldToMetersScale_method() {
                SetWorldToMetersScale_ptr = Main.GetMethodUFunction(HeadMountedDisplayFunctionLibrary.StaticClass, "SetWorldToMetersScale");
            }

            internal static unsafe void Invoke(UObject WorldContext, float NewScale) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContext;
                *((float*)(b+8)) = NewScale;
                Main.GetProcessEvent(HeadMountedDisplayFunctionLibrary.DefaultObject, SetWorldToMetersScale_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct HeadMountedDisplayFunctionLibrary_events {
    }
}
