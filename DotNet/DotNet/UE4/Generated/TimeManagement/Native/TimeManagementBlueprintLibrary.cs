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
        internal struct Add_FrameNumberFrameNumber_method {
            static internal IntPtr Add_FrameNumberFrameNumber_ptr;
            static Add_FrameNumberFrameNumber_method() {
                Add_FrameNumberFrameNumber_ptr = Main.GetMethodUFunction(TimeManagementBlueprintLibrary.StaticClass, "Add_FrameNumberFrameNumber");
            }

            internal static unsafe FrameNumber Invoke(FrameNumber A, FrameNumber B) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((FrameNumber*)(b+0)) = A;
                *((FrameNumber*)(b+4)) = B;
                Main.GetProcessEvent(TimeManagementBlueprintLibrary.DefaultObject, Add_FrameNumberFrameNumber_ptr, new IntPtr(p)); ;
                return *((FrameNumber*)(b+8));
            }
        }
        internal struct Add_FrameNumberInteger_method {
            static internal IntPtr Add_FrameNumberInteger_ptr;
            static Add_FrameNumberInteger_method() {
                Add_FrameNumberInteger_ptr = Main.GetMethodUFunction(TimeManagementBlueprintLibrary.StaticClass, "Add_FrameNumberInteger");
            }

            internal static unsafe FrameNumber Invoke(FrameNumber A, int B) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((FrameNumber*)(b+0)) = A;
                *((int*)(b+4)) = B;
                Main.GetProcessEvent(TimeManagementBlueprintLibrary.DefaultObject, Add_FrameNumberInteger_ptr, new IntPtr(p)); ;
                return *((FrameNumber*)(b+8));
            }
        }
        internal struct Conv_FrameNumberToInteger_method {
            static internal IntPtr Conv_FrameNumberToInteger_ptr;
            static Conv_FrameNumberToInteger_method() {
                Conv_FrameNumberToInteger_ptr = Main.GetMethodUFunction(TimeManagementBlueprintLibrary.StaticClass, "Conv_FrameNumberToInteger");
            }

            internal static unsafe int Invoke(FrameNumber InFrameNumber) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((FrameNumber*)(b+0)) = InFrameNumber;
                Main.GetProcessEvent(TimeManagementBlueprintLibrary.DefaultObject, Conv_FrameNumberToInteger_ptr, new IntPtr(p)); ;
                return *((int*)(b+4));
            }
        }
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
        internal struct Divide_FrameNumberInteger_method {
            static internal IntPtr Divide_FrameNumberInteger_ptr;
            static Divide_FrameNumberInteger_method() {
                Divide_FrameNumberInteger_ptr = Main.GetMethodUFunction(TimeManagementBlueprintLibrary.StaticClass, "Divide_FrameNumberInteger");
            }

            internal static unsafe FrameNumber Invoke(FrameNumber A, int B) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((FrameNumber*)(b+0)) = A;
                *((int*)(b+4)) = B;
                Main.GetProcessEvent(TimeManagementBlueprintLibrary.DefaultObject, Divide_FrameNumberInteger_ptr, new IntPtr(p)); ;
                return *((FrameNumber*)(b+8));
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
        internal struct IsValid_Framerate_method {
            static internal IntPtr IsValid_Framerate_ptr;
            static IsValid_Framerate_method() {
                IsValid_Framerate_ptr = Main.GetMethodUFunction(TimeManagementBlueprintLibrary.StaticClass, "IsValid_Framerate");
            }

            internal static unsafe bool Invoke(FrameRate InFrameRate) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((FrameRate*)(b+0)) = InFrameRate;
                Main.GetProcessEvent(TimeManagementBlueprintLibrary.DefaultObject, IsValid_Framerate_ptr, new IntPtr(p)); ;
                return *((bool*)(b+8));
            }
        }
        internal struct IsValid_MultipleOf_method {
            static internal IntPtr IsValid_MultipleOf_ptr;
            static IsValid_MultipleOf_method() {
                IsValid_MultipleOf_ptr = Main.GetMethodUFunction(TimeManagementBlueprintLibrary.StaticClass, "IsValid_MultipleOf");
            }

            internal static unsafe bool Invoke(FrameRate InFrameRate, FrameRate OtherFramerate) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((FrameRate*)(b+0)) = InFrameRate;
                *((FrameRate*)(b+8)) = OtherFramerate;
                Main.GetProcessEvent(TimeManagementBlueprintLibrary.DefaultObject, IsValid_MultipleOf_ptr, new IntPtr(p)); ;
                return *((bool*)(b+16));
            }
        }
        internal struct Multiply_FrameNumberInteger_method {
            static internal IntPtr Multiply_FrameNumberInteger_ptr;
            static Multiply_FrameNumberInteger_method() {
                Multiply_FrameNumberInteger_ptr = Main.GetMethodUFunction(TimeManagementBlueprintLibrary.StaticClass, "Multiply_FrameNumberInteger");
            }

            internal static unsafe FrameNumber Invoke(FrameNumber A, int B) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((FrameNumber*)(b+0)) = A;
                *((int*)(b+4)) = B;
                Main.GetProcessEvent(TimeManagementBlueprintLibrary.DefaultObject, Multiply_FrameNumberInteger_ptr, new IntPtr(p)); ;
                return *((FrameNumber*)(b+8));
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
        internal struct SnapFrameTimeToRate_method {
            static internal IntPtr SnapFrameTimeToRate_ptr;
            static SnapFrameTimeToRate_method() {
                SnapFrameTimeToRate_ptr = Main.GetMethodUFunction(TimeManagementBlueprintLibrary.StaticClass, "SnapFrameTimeToRate");
            }

            internal static unsafe FrameTime Invoke(FrameTime SourceTime, FrameRate SourceRate, FrameRate SnapToRate) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((FrameTime*)(b+0)) = SourceTime;
                *((FrameRate*)(b+8)) = SourceRate;
                *((FrameRate*)(b+16)) = SnapToRate;
                Main.GetProcessEvent(TimeManagementBlueprintLibrary.DefaultObject, SnapFrameTimeToRate_ptr, new IntPtr(p)); ;
                return *((FrameTime*)(b+24));
            }
        }
        internal struct Subtract_FrameNumberFrameNumber_method {
            static internal IntPtr Subtract_FrameNumberFrameNumber_ptr;
            static Subtract_FrameNumberFrameNumber_method() {
                Subtract_FrameNumberFrameNumber_ptr = Main.GetMethodUFunction(TimeManagementBlueprintLibrary.StaticClass, "Subtract_FrameNumberFrameNumber");
            }

            internal static unsafe FrameNumber Invoke(FrameNumber A, FrameNumber B) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((FrameNumber*)(b+0)) = A;
                *((FrameNumber*)(b+4)) = B;
                Main.GetProcessEvent(TimeManagementBlueprintLibrary.DefaultObject, Subtract_FrameNumberFrameNumber_ptr, new IntPtr(p)); ;
                return *((FrameNumber*)(b+8));
            }
        }
        internal struct Subtract_FrameNumberInteger_method {
            static internal IntPtr Subtract_FrameNumberInteger_ptr;
            static Subtract_FrameNumberInteger_method() {
                Subtract_FrameNumberInteger_ptr = Main.GetMethodUFunction(TimeManagementBlueprintLibrary.StaticClass, "Subtract_FrameNumberInteger");
            }

            internal static unsafe FrameNumber Invoke(FrameNumber A, int B) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((FrameNumber*)(b+0)) = A;
                *((int*)(b+4)) = B;
                Main.GetProcessEvent(TimeManagementBlueprintLibrary.DefaultObject, Subtract_FrameNumberInteger_ptr, new IntPtr(p)); ;
                return *((FrameNumber*)(b+8));
            }
        }
        internal struct TransformTime_method {
            static internal IntPtr TransformTime_ptr;
            static TransformTime_method() {
                TransformTime_ptr = Main.GetMethodUFunction(TimeManagementBlueprintLibrary.StaticClass, "TransformTime");
            }

            internal static unsafe FrameTime Invoke(FrameTime SourceTime, FrameRate SourceRate, FrameRate DestinationRate) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((FrameTime*)(b+0)) = SourceTime;
                *((FrameRate*)(b+8)) = SourceRate;
                *((FrameRate*)(b+16)) = DestinationRate;
                Main.GetProcessEvent(TimeManagementBlueprintLibrary.DefaultObject, TransformTime_ptr, new IntPtr(p)); ;
                return *((FrameTime*)(b+24));
            }
        }
    }
    internal unsafe struct TimeManagementBlueprintLibrary_events {
    }
}
