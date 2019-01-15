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

namespace UE4.HeadMountedDisplay.Native {
    [StructLayout( LayoutKind.Explicit, Size=56 )]
    internal unsafe struct MotionTrackedDeviceFunctionLibrary_fields {
    }
    internal unsafe struct MotionTrackedDeviceFunctionLibrary_methods {
        internal struct DisableMotionTrackingForComponent_method {
            static internal IntPtr DisableMotionTrackingForComponent_ptr;
            static DisableMotionTrackingForComponent_method() {
                DisableMotionTrackingForComponent_ptr = Main.GetMethodUFunction(MotionTrackedDeviceFunctionLibrary.StaticClass, "DisableMotionTrackingForComponent");
            }

            internal static unsafe void Invoke(MotionControllerComponent MotionControllerComponent) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = MotionControllerComponent;
                Main.GetProcessEvent(MotionTrackedDeviceFunctionLibrary.DefaultObject, DisableMotionTrackingForComponent_ptr, new IntPtr(p)); ;
            }
        }
        internal struct DisableMotionTrackingOfAllControllers_method {
            static internal IntPtr DisableMotionTrackingOfAllControllers_ptr;
            static DisableMotionTrackingOfAllControllers_method() {
                DisableMotionTrackingOfAllControllers_ptr = Main.GetMethodUFunction(MotionTrackedDeviceFunctionLibrary.StaticClass, "DisableMotionTrackingOfAllControllers");
            }

            internal static unsafe void Invoke() {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(MotionTrackedDeviceFunctionLibrary.DefaultObject, DisableMotionTrackingOfAllControllers_ptr, new IntPtr(p)); ;
            }
        }
        internal struct DisableMotionTrackingOfControllersForPlayer_method {
            static internal IntPtr DisableMotionTrackingOfControllersForPlayer_ptr;
            static DisableMotionTrackingOfControllersForPlayer_method() {
                DisableMotionTrackingOfControllersForPlayer_ptr = Main.GetMethodUFunction(MotionTrackedDeviceFunctionLibrary.StaticClass, "DisableMotionTrackingOfControllersForPlayer");
            }

            internal static unsafe void Invoke(int PlayerIndex) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = PlayerIndex;
                Main.GetProcessEvent(MotionTrackedDeviceFunctionLibrary.DefaultObject, DisableMotionTrackingOfControllersForPlayer_ptr, new IntPtr(p)); ;
            }
        }
        internal struct DisableMotionTrackingOfDevice_method {
            static internal IntPtr DisableMotionTrackingOfDevice_ptr;
            static DisableMotionTrackingOfDevice_method() {
                DisableMotionTrackingOfDevice_ptr = Main.GetMethodUFunction(MotionTrackedDeviceFunctionLibrary.StaticClass, "DisableMotionTrackingOfDevice");
            }

            internal static unsafe void Invoke(int PlayerIndex, EControllerHand Hand) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = PlayerIndex;
                *(b+4) = (byte)Hand;
                Main.GetProcessEvent(MotionTrackedDeviceFunctionLibrary.DefaultObject, DisableMotionTrackingOfDevice_ptr, new IntPtr(p)); ;
            }
        }
        internal struct DisableMotionTrackingOfSource_method {
            static internal IntPtr DisableMotionTrackingOfSource_ptr;
            static DisableMotionTrackingOfSource_method() {
                DisableMotionTrackingOfSource_ptr = Main.GetMethodUFunction(MotionTrackedDeviceFunctionLibrary.StaticClass, "DisableMotionTrackingOfSource");
            }

            internal static unsafe void Invoke(int PlayerIndex, Name SourceName) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = PlayerIndex;
                *((Name*)(b+4)) = SourceName;
                Main.GetProcessEvent(MotionTrackedDeviceFunctionLibrary.DefaultObject, DisableMotionTrackingOfSource_ptr, new IntPtr(p)); ;
            }
        }
        internal struct EnableMotionTrackingForComponent_method {
            static internal IntPtr EnableMotionTrackingForComponent_ptr;
            static EnableMotionTrackingForComponent_method() {
                EnableMotionTrackingForComponent_ptr = Main.GetMethodUFunction(MotionTrackedDeviceFunctionLibrary.StaticClass, "EnableMotionTrackingForComponent");
            }

            internal static unsafe bool Invoke(MotionControllerComponent MotionControllerComponent) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = MotionControllerComponent;
                Main.GetProcessEvent(MotionTrackedDeviceFunctionLibrary.DefaultObject, EnableMotionTrackingForComponent_ptr, new IntPtr(p)); ;
                return *((bool*)(b+8));
            }
        }
        internal struct EnableMotionTrackingOfDevice_method {
            static internal IntPtr EnableMotionTrackingOfDevice_ptr;
            static EnableMotionTrackingOfDevice_method() {
                EnableMotionTrackingOfDevice_ptr = Main.GetMethodUFunction(MotionTrackedDeviceFunctionLibrary.StaticClass, "EnableMotionTrackingOfDevice");
            }

            internal static unsafe bool Invoke(int PlayerIndex, EControllerHand Hand) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = PlayerIndex;
                *(b+4) = (byte)Hand;
                Main.GetProcessEvent(MotionTrackedDeviceFunctionLibrary.DefaultObject, EnableMotionTrackingOfDevice_ptr, new IntPtr(p)); ;
                return *((bool*)(b+5));
            }
        }
        internal struct EnableMotionTrackingOfSource_method {
            static internal IntPtr EnableMotionTrackingOfSource_ptr;
            static EnableMotionTrackingOfSource_method() {
                EnableMotionTrackingOfSource_ptr = Main.GetMethodUFunction(MotionTrackedDeviceFunctionLibrary.StaticClass, "EnableMotionTrackingOfSource");
            }

            internal static unsafe bool Invoke(int PlayerIndex, Name SourceName) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = PlayerIndex;
                *((Name*)(b+4)) = SourceName;
                Main.GetProcessEvent(MotionTrackedDeviceFunctionLibrary.DefaultObject, EnableMotionTrackingOfSource_ptr, new IntPtr(p)); ;
                return *((bool*)(b+16));
            }
        }
        internal struct EnumerateMotionSources_method {
            static internal IntPtr EnumerateMotionSources_ptr;
            static EnumerateMotionSources_method() {
                EnumerateMotionSources_ptr = Main.GetMethodUFunction(MotionTrackedDeviceFunctionLibrary.StaticClass, "EnumerateMotionSources");
            }

            internal static unsafe IReadOnlyCollection<Name> Invoke() {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(MotionTrackedDeviceFunctionLibrary.DefaultObject, EnumerateMotionSources_ptr, new IntPtr(p)); ;
                 //TODO: array TArray ReturnValue
                return UObject.ToUnmangedCollection<Name>(b+0);
            }
        }
        internal struct GetActiveTrackingSystemName_method {
            static internal IntPtr GetActiveTrackingSystemName_ptr;
            static GetActiveTrackingSystemName_method() {
                GetActiveTrackingSystemName_ptr = Main.GetMethodUFunction(MotionTrackedDeviceFunctionLibrary.StaticClass, "GetActiveTrackingSystemName");
            }

            internal static unsafe Name Invoke() {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(MotionTrackedDeviceFunctionLibrary.DefaultObject, GetActiveTrackingSystemName_ptr, new IntPtr(p)); ;
                return *((Name*)(b+0));
            }
        }
        internal struct GetMaximumMotionTrackedControllerCount_method {
            static internal IntPtr GetMaximumMotionTrackedControllerCount_ptr;
            static GetMaximumMotionTrackedControllerCount_method() {
                GetMaximumMotionTrackedControllerCount_ptr = Main.GetMethodUFunction(MotionTrackedDeviceFunctionLibrary.StaticClass, "GetMaximumMotionTrackedControllerCount");
            }

            internal static unsafe int Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(MotionTrackedDeviceFunctionLibrary.DefaultObject, GetMaximumMotionTrackedControllerCount_ptr, new IntPtr(p)); ;
                return *((int*)(b+0));
            }
        }
        internal struct GetMotionTrackingEnabledControllerCount_method {
            static internal IntPtr GetMotionTrackingEnabledControllerCount_ptr;
            static GetMotionTrackingEnabledControllerCount_method() {
                GetMotionTrackingEnabledControllerCount_ptr = Main.GetMethodUFunction(MotionTrackedDeviceFunctionLibrary.StaticClass, "GetMotionTrackingEnabledControllerCount");
            }

            internal static unsafe int Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(MotionTrackedDeviceFunctionLibrary.DefaultObject, GetMotionTrackingEnabledControllerCount_ptr, new IntPtr(p)); ;
                return *((int*)(b+0));
            }
        }
        internal struct IsMotionSourceTracking_method {
            static internal IntPtr IsMotionSourceTracking_ptr;
            static IsMotionSourceTracking_method() {
                IsMotionSourceTracking_ptr = Main.GetMethodUFunction(MotionTrackedDeviceFunctionLibrary.StaticClass, "IsMotionSourceTracking");
            }

            internal static unsafe bool Invoke(int PlayerIndex, Name SourceName) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = PlayerIndex;
                *((Name*)(b+4)) = SourceName;
                Main.GetProcessEvent(MotionTrackedDeviceFunctionLibrary.DefaultObject, IsMotionSourceTracking_ptr, new IntPtr(p)); ;
                return *((bool*)(b+16));
            }
        }
        internal struct IsMotionTrackedDeviceCountManagementNecessary_method {
            static internal IntPtr IsMotionTrackedDeviceCountManagementNecessary_ptr;
            static IsMotionTrackedDeviceCountManagementNecessary_method() {
                IsMotionTrackedDeviceCountManagementNecessary_ptr = Main.GetMethodUFunction(MotionTrackedDeviceFunctionLibrary.StaticClass, "IsMotionTrackedDeviceCountManagementNecessary");
            }

            internal static unsafe bool Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(MotionTrackedDeviceFunctionLibrary.DefaultObject, IsMotionTrackedDeviceCountManagementNecessary_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsMotionTrackingEnabledForComponent_method {
            static internal IntPtr IsMotionTrackingEnabledForComponent_ptr;
            static IsMotionTrackingEnabledForComponent_method() {
                IsMotionTrackingEnabledForComponent_ptr = Main.GetMethodUFunction(MotionTrackedDeviceFunctionLibrary.StaticClass, "IsMotionTrackingEnabledForComponent");
            }

            internal static unsafe bool Invoke(MotionControllerComponent MotionControllerComponent) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = MotionControllerComponent;
                Main.GetProcessEvent(MotionTrackedDeviceFunctionLibrary.DefaultObject, IsMotionTrackingEnabledForComponent_ptr, new IntPtr(p)); ;
                return *((bool*)(b+8));
            }
        }
        internal struct IsMotionTrackingEnabledForDevice_method {
            static internal IntPtr IsMotionTrackingEnabledForDevice_ptr;
            static IsMotionTrackingEnabledForDevice_method() {
                IsMotionTrackingEnabledForDevice_ptr = Main.GetMethodUFunction(MotionTrackedDeviceFunctionLibrary.StaticClass, "IsMotionTrackingEnabledForDevice");
            }

            internal static unsafe bool Invoke(int PlayerIndex, EControllerHand Hand) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = PlayerIndex;
                *(b+4) = (byte)Hand;
                Main.GetProcessEvent(MotionTrackedDeviceFunctionLibrary.DefaultObject, IsMotionTrackingEnabledForDevice_ptr, new IntPtr(p)); ;
                return *((bool*)(b+5));
            }
        }
        internal struct IsMotionTrackingEnabledForSource_method {
            static internal IntPtr IsMotionTrackingEnabledForSource_ptr;
            static IsMotionTrackingEnabledForSource_method() {
                IsMotionTrackingEnabledForSource_ptr = Main.GetMethodUFunction(MotionTrackedDeviceFunctionLibrary.StaticClass, "IsMotionTrackingEnabledForSource");
            }

            internal static unsafe bool Invoke(int PlayerIndex, Name SourceName) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = PlayerIndex;
                *((Name*)(b+4)) = SourceName;
                Main.GetProcessEvent(MotionTrackedDeviceFunctionLibrary.DefaultObject, IsMotionTrackingEnabledForSource_ptr, new IntPtr(p)); ;
                return *((bool*)(b+16));
            }
        }
        internal struct SetIsControllerMotionTrackingEnabledByDefault_method {
            static internal IntPtr SetIsControllerMotionTrackingEnabledByDefault_ptr;
            static SetIsControllerMotionTrackingEnabledByDefault_method() {
                SetIsControllerMotionTrackingEnabledByDefault_ptr = Main.GetMethodUFunction(MotionTrackedDeviceFunctionLibrary.StaticClass, "SetIsControllerMotionTrackingEnabledByDefault");
            }

            internal static unsafe void Invoke(bool Enable) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = Enable;
                Main.GetProcessEvent(MotionTrackedDeviceFunctionLibrary.DefaultObject, SetIsControllerMotionTrackingEnabledByDefault_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct MotionTrackedDeviceFunctionLibrary_events {
    }
}
