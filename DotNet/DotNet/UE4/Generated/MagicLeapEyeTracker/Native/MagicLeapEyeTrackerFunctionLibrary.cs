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


namespace UE4.MagicLeapEyeTracker.Native {
    [StructLayout( LayoutKind.Explicit, Size=56 )]
    internal unsafe struct MagicLeapEyeTrackerFunctionLibrary_fields {
    }
    internal unsafe struct MagicLeapEyeTrackerFunctionLibrary_methods {
        internal struct GetEyeBlinkState_method {
            static internal IntPtr GetEyeBlinkState_ptr;
            static GetEyeBlinkState_method() {
                GetEyeBlinkState_ptr = Main.GetMethodUFunction(MagicLeapEyeTrackerFunctionLibrary.StaticClass, "GetEyeBlinkState");
            }

            internal static unsafe (MagicLeapEyeBlinkState, bool) Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(MagicLeapEyeTrackerFunctionLibrary.DefaultObject, GetEyeBlinkState_ptr, new IntPtr(p)); ;
                return (*((MagicLeapEyeBlinkState*)(b+0)),*((bool*)(b+2)));
            }
        }
        internal struct IsEyeTrackerCalibrated_method {
            static internal IntPtr IsEyeTrackerCalibrated_ptr;
            static IsEyeTrackerCalibrated_method() {
                IsEyeTrackerCalibrated_ptr = Main.GetMethodUFunction(MagicLeapEyeTrackerFunctionLibrary.StaticClass, "IsEyeTrackerCalibrated");
            }

            internal static unsafe bool Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(MagicLeapEyeTrackerFunctionLibrary.DefaultObject, IsEyeTrackerCalibrated_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
    }
    internal unsafe struct MagicLeapEyeTrackerFunctionLibrary_events {
    }
}
