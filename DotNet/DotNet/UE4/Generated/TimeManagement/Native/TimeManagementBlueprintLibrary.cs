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


namespace UE4.TimeManagement.Native {
    [StructLayout( LayoutKind.Explicit, Size=56 )]
    internal unsafe struct TimeManagementBlueprintLibrary_fields {
    }
    internal unsafe struct TimeManagementBlueprintLibrary_methods {
        internal struct Conv_FrameRateToSeconds_method {
            static internal IntPtr Conv_FrameRateToSeconds_ptr;
            static Conv_FrameRateToSeconds_method() {
                Conv_FrameRateToSeconds_ptr = Main.GetMethodUFunction(TimeManagementBlueprintLibrary.StaticClass, "Conv_FrameRateToSeconds");
            }

            internal static unsafe float Invoke(FrameRate InFrameRate) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((FrameRate*)(b+0)) = InFrameRate;
                Main.GetProcessEvent(TimeManagementBlueprintLibrary.DefaultObject, Conv_FrameRateToSeconds_ptr, new IntPtr(p)); ;
                return *((float*)(b+8));
            }
        }
        internal struct Conv_QualifiedFrameTimeToSeconds_method {
            static internal IntPtr Conv_QualifiedFrameTimeToSeconds_ptr;
            static Conv_QualifiedFrameTimeToSeconds_method() {
                Conv_QualifiedFrameTimeToSeconds_ptr = Main.GetMethodUFunction(TimeManagementBlueprintLibrary.StaticClass, "Conv_QualifiedFrameTimeToSeconds");
            }

            internal static unsafe float Invoke(QualifiedFrameTime InFrameTime) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((QualifiedFrameTime*)(b+0)) = InFrameTime;
                Main.GetProcessEvent(TimeManagementBlueprintLibrary.DefaultObject, Conv_QualifiedFrameTimeToSeconds_ptr, new IntPtr(p)); ;
                return *((float*)(b+16));
            }
        }
        internal struct Conv_TimecodeToString_method {
            static internal IntPtr Conv_TimecodeToString_ptr;
            static Conv_TimecodeToString_method() {
                Conv_TimecodeToString_ptr = Main.GetMethodUFunction(TimeManagementBlueprintLibrary.StaticClass, "Conv_TimecodeToString");
            }

            internal static unsafe string Invoke(Timecode InTimecode, bool bForceSignDisplay) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Timecode*)(b+0)) = InTimecode;
                *((bool*)(b+20)) = bForceSignDisplay;
                Main.GetProcessEvent(TimeManagementBlueprintLibrary.DefaultObject, Conv_TimecodeToString_ptr, new IntPtr(p)); ;
                return FString.Get(b+24);
            }
        }
        internal struct GetTimecode_method {
            static internal IntPtr GetTimecode_ptr;
            static GetTimecode_method() {
                GetTimecode_ptr = Main.GetMethodUFunction(TimeManagementBlueprintLibrary.StaticClass, "GetTimecode");
            }

            internal static unsafe Timecode Invoke() {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(TimeManagementBlueprintLibrary.DefaultObject, GetTimecode_ptr, new IntPtr(p)); ;
                return *((Timecode*)(b+0));
            }
        }
        internal struct Multiply_SecondsFrameRate_method {
            static internal IntPtr Multiply_SecondsFrameRate_ptr;
            static Multiply_SecondsFrameRate_method() {
                Multiply_SecondsFrameRate_ptr = Main.GetMethodUFunction(TimeManagementBlueprintLibrary.StaticClass, "Multiply_SecondsFrameRate");
            }

            internal static unsafe FrameTime Invoke(float TimeInSeconds, FrameRate FrameRate) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = TimeInSeconds;
                *((FrameRate*)(b+4)) = FrameRate;
                Main.GetProcessEvent(TimeManagementBlueprintLibrary.DefaultObject, Multiply_SecondsFrameRate_ptr, new IntPtr(p)); ;
                return *((FrameTime*)(b+12));
            }
        }
    }
    internal unsafe struct TimeManagementBlueprintLibrary_events {
    }
}
