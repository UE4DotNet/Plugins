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

namespace UE4.EyeTracker.Native {
    [StructLayout( LayoutKind.Explicit, Size=56 )]
    internal unsafe struct EyeTrackerFunctionLibrary_fields {
    }
    internal unsafe struct EyeTrackerFunctionLibrary_methods {
        internal struct GetGazeData_method {
            static internal IntPtr GetGazeData_ptr;
            static GetGazeData_method() {
                GetGazeData_ptr = Main.GetMethodUFunction(EyeTrackerFunctionLibrary.StaticClass, "GetGazeData");
            }

            internal static unsafe (EyeTrackerGazeData, bool) Invoke() {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(EyeTrackerFunctionLibrary.DefaultObject, GetGazeData_ptr, new IntPtr(p)); ;
                return (*((EyeTrackerGazeData*)(b+0)),*((bool*)(b+40)));
            }
        }
        internal struct GetStereoGazeData_method {
            static internal IntPtr GetStereoGazeData_ptr;
            static GetStereoGazeData_method() {
                GetStereoGazeData_ptr = Main.GetMethodUFunction(EyeTrackerFunctionLibrary.StaticClass, "GetStereoGazeData");
            }

            internal static unsafe (EyeTrackerStereoGazeData, bool) Invoke() {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(EyeTrackerFunctionLibrary.DefaultObject, GetStereoGazeData_ptr, new IntPtr(p)); ;
                return (*((EyeTrackerStereoGazeData*)(b+0)),*((bool*)(b+64)));
            }
        }
        internal struct IsEyeTrackerConnected_method {
            static internal IntPtr IsEyeTrackerConnected_ptr;
            static IsEyeTrackerConnected_method() {
                IsEyeTrackerConnected_ptr = Main.GetMethodUFunction(EyeTrackerFunctionLibrary.StaticClass, "IsEyeTrackerConnected");
            }

            internal static unsafe bool Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(EyeTrackerFunctionLibrary.DefaultObject, IsEyeTrackerConnected_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsStereoGazeDataAvailable_method {
            static internal IntPtr IsStereoGazeDataAvailable_ptr;
            static IsStereoGazeDataAvailable_method() {
                IsStereoGazeDataAvailable_ptr = Main.GetMethodUFunction(EyeTrackerFunctionLibrary.StaticClass, "IsStereoGazeDataAvailable");
            }

            internal static unsafe bool Invoke() {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(EyeTrackerFunctionLibrary.DefaultObject, IsStereoGazeDataAvailable_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct SetEyeTrackedPlayer_method {
            static internal IntPtr SetEyeTrackedPlayer_ptr;
            static SetEyeTrackedPlayer_method() {
                SetEyeTrackedPlayer_ptr = Main.GetMethodUFunction(EyeTrackerFunctionLibrary.StaticClass, "SetEyeTrackedPlayer");
            }

            internal static unsafe void Invoke(PlayerController PlayerController) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = PlayerController;
                Main.GetProcessEvent(EyeTrackerFunctionLibrary.DefaultObject, SetEyeTrackedPlayer_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct EyeTrackerFunctionLibrary_events {
    }
}
