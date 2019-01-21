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


namespace UE4.MagicLeap.Native {
    [StructLayout( LayoutKind.Explicit, Size=56 )]
    internal unsafe struct ImageTrackerFunctionLibrary_fields {
    }
    internal unsafe struct ImageTrackerFunctionLibrary_methods {
        internal struct EnableImageTracking_method {
            static internal IntPtr EnableImageTracking_ptr;
            static EnableImageTracking_method() {
                EnableImageTracking_ptr = Main.GetMethodUFunction(ImageTrackerFunctionLibrary.StaticClass, "EnableImageTracking");
            }

            internal static unsafe void Invoke(bool bEnable) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bEnable;
                Main.GetProcessEvent(ImageTrackerFunctionLibrary.DefaultObject, EnableImageTracking_ptr, new IntPtr(p)); ;
            }
        }
        internal struct GetMaxSimultaneousTargets_method {
            static internal IntPtr GetMaxSimultaneousTargets_ptr;
            static GetMaxSimultaneousTargets_method() {
                GetMaxSimultaneousTargets_ptr = Main.GetMethodUFunction(ImageTrackerFunctionLibrary.StaticClass, "GetMaxSimultaneousTargets");
            }

            internal static unsafe int Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(ImageTrackerFunctionLibrary.DefaultObject, GetMaxSimultaneousTargets_ptr, new IntPtr(p)); ;
                return *((int*)(b+0));
            }
        }
        internal struct IsImageTrackingEnabled_method {
            static internal IntPtr IsImageTrackingEnabled_ptr;
            static IsImageTrackingEnabled_method() {
                IsImageTrackingEnabled_ptr = Main.GetMethodUFunction(ImageTrackerFunctionLibrary.StaticClass, "IsImageTrackingEnabled");
            }

            internal static unsafe bool Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(ImageTrackerFunctionLibrary.DefaultObject, IsImageTrackingEnabled_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct SetMaxSimultaneousTargets_method {
            static internal IntPtr SetMaxSimultaneousTargets_ptr;
            static SetMaxSimultaneousTargets_method() {
                SetMaxSimultaneousTargets_ptr = Main.GetMethodUFunction(ImageTrackerFunctionLibrary.StaticClass, "SetMaxSimultaneousTargets");
            }

            internal static unsafe void Invoke(int MaxSimultaneousTargets) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = MaxSimultaneousTargets;
                Main.GetProcessEvent(ImageTrackerFunctionLibrary.DefaultObject, SetMaxSimultaneousTargets_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct ImageTrackerFunctionLibrary_events {
    }
}
