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

using UE4.InputCore;

namespace UE4.SteamVR.Native {
    [StructLayout( LayoutKind.Explicit, Size=56 )]
    internal unsafe struct SteamVRFunctionLibrary_fields {
    }
    internal unsafe struct SteamVRFunctionLibrary_methods {
        internal struct GetHandPositionAndOrientation_method {
            static internal IntPtr GetHandPositionAndOrientation_ptr;
            static GetHandPositionAndOrientation_method() {
                GetHandPositionAndOrientation_ptr = Main.GetMethodUFunction(SteamVRFunctionLibrary.StaticClass, "GetHandPositionAndOrientation");
            }

            internal static unsafe (Vector, Rotator, bool) Invoke(int ControllerIndex, EControllerHand Hand) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = ControllerIndex;
                *(b+4) = (byte)Hand;
                Main.GetProcessEvent(SteamVRFunctionLibrary.DefaultObject, GetHandPositionAndOrientation_ptr, new IntPtr(p)); ;
                return (*((Vector*)(b+8)),*((Rotator*)(b+20)),*((bool*)(b+32)));
            }
        }
        internal struct GetTrackedDevicePositionAndOrientation_method {
            static internal IntPtr GetTrackedDevicePositionAndOrientation_ptr;
            static GetTrackedDevicePositionAndOrientation_method() {
                GetTrackedDevicePositionAndOrientation_ptr = Main.GetMethodUFunction(SteamVRFunctionLibrary.StaticClass, "GetTrackedDevicePositionAndOrientation");
            }

            internal static unsafe (Vector, Rotator, bool) Invoke(int DeviceId) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = DeviceId;
                Main.GetProcessEvent(SteamVRFunctionLibrary.DefaultObject, GetTrackedDevicePositionAndOrientation_ptr, new IntPtr(p)); ;
                return (*((Vector*)(b+4)),*((Rotator*)(b+16)),*((bool*)(b+28)));
            }
        }
        internal struct GetValidTrackedDeviceIds_method {
            static internal IntPtr GetValidTrackedDeviceIds_ptr;
            static GetValidTrackedDeviceIds_method() {
                GetValidTrackedDeviceIds_ptr = Main.GetMethodUFunction(SteamVRFunctionLibrary.StaticClass, "GetValidTrackedDeviceIds");
            }

            internal static unsafe IReadOnlyCollection<int> Invoke(ESteamVRTrackedDeviceType DeviceType) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *(b+0) = (byte)DeviceType;
                Main.GetProcessEvent(SteamVRFunctionLibrary.DefaultObject, GetValidTrackedDeviceIds_ptr, new IntPtr(p)); ;
                 //TODO: array TArray OutTrackedDeviceIds
                return UObject.ToUnmangedCollection<int>(b+8);
            }
        }
    }
    internal unsafe struct SteamVRFunctionLibrary_events {
    }
}
