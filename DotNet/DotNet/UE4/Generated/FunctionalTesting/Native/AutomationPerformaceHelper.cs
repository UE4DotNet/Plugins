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


namespace UE4.FunctionalTesting.Native {
    [StructLayout( LayoutKind.Explicit, Size=112 )]
    internal unsafe struct AutomationPerformaceHelper_fields {
    }
    internal unsafe struct AutomationPerformaceHelper_methods {
        internal struct BeginRecording_method {
            static internal IntPtr BeginRecording_ptr;
            static BeginRecording_method() {
                BeginRecording_ptr = Main.GetMethodUFunction(AutomationPerformaceHelper.StaticClass, "BeginRecording");
            }

            internal static unsafe void Invoke(IntPtr obj, string RecordName, float InGPUBudget, float InRenderThreadBudget, float InGameThreadBudget) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var RecordName_handle = GCHandle.Alloc(RecordName, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = RecordName_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = RecordName.Length;
                *(int*)(b+IntPtr.Size+4+0) = RecordName.Length;
                *((float*)(b+16)) = InGPUBudget;
                *((float*)(b+20)) = InRenderThreadBudget;
                *((float*)(b+24)) = InGameThreadBudget;
                Main.GetProcessEvent(obj, BeginRecording_ptr, new IntPtr(p)); ;
                RecordName_handle.Free();
            }
        }
        internal struct BeginRecordingBaseline_method {
            static internal IntPtr BeginRecordingBaseline_ptr;
            static BeginRecordingBaseline_method() {
                BeginRecordingBaseline_ptr = Main.GetMethodUFunction(AutomationPerformaceHelper.StaticClass, "BeginRecordingBaseline");
            }

            internal static unsafe void Invoke(IntPtr obj, string RecordName) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                var RecordName_handle = GCHandle.Alloc(RecordName, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = RecordName_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = RecordName.Length;
                *(int*)(b+IntPtr.Size+4+0) = RecordName.Length;
                Main.GetProcessEvent(obj, BeginRecordingBaseline_ptr, new IntPtr(p)); ;
                RecordName_handle.Free();
            }
        }
        internal struct BeginStatsFile_method {
            static internal IntPtr BeginStatsFile_ptr;
            static BeginStatsFile_method() {
                BeginStatsFile_ptr = Main.GetMethodUFunction(AutomationPerformaceHelper.StaticClass, "BeginStatsFile");
            }

            internal static unsafe void Invoke(IntPtr obj, string RecordName) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                var RecordName_handle = GCHandle.Alloc(RecordName, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = RecordName_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = RecordName.Length;
                *(int*)(b+IntPtr.Size+4+0) = RecordName.Length;
                Main.GetProcessEvent(obj, BeginStatsFile_ptr, new IntPtr(p)); ;
                RecordName_handle.Free();
            }
        }
        internal struct EndRecording_method {
            static internal IntPtr EndRecording_ptr;
            static EndRecording_method() {
                EndRecording_ptr = Main.GetMethodUFunction(AutomationPerformaceHelper.StaticClass, "EndRecording");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, EndRecording_ptr, new IntPtr(p)); ;
            }
        }
        internal struct EndRecordingBaseline_method {
            static internal IntPtr EndRecordingBaseline_ptr;
            static EndRecordingBaseline_method() {
                EndRecordingBaseline_ptr = Main.GetMethodUFunction(AutomationPerformaceHelper.StaticClass, "EndRecordingBaseline");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, EndRecordingBaseline_ptr, new IntPtr(p)); ;
            }
        }
        internal struct EndStatsFile_method {
            static internal IntPtr EndStatsFile_ptr;
            static EndStatsFile_method() {
                EndStatsFile_ptr = Main.GetMethodUFunction(AutomationPerformaceHelper.StaticClass, "EndStatsFile");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, EndStatsFile_ptr, new IntPtr(p)); ;
            }
        }
        internal struct IsCurrentRecordWithinGameThreadBudget_method {
            static internal IntPtr IsCurrentRecordWithinGameThreadBudget_ptr;
            static IsCurrentRecordWithinGameThreadBudget_method() {
                IsCurrentRecordWithinGameThreadBudget_ptr = Main.GetMethodUFunction(AutomationPerformaceHelper.StaticClass, "IsCurrentRecordWithinGameThreadBudget");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsCurrentRecordWithinGameThreadBudget_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsCurrentRecordWithinGPUBudget_method {
            static internal IntPtr IsCurrentRecordWithinGPUBudget_ptr;
            static IsCurrentRecordWithinGPUBudget_method() {
                IsCurrentRecordWithinGPUBudget_ptr = Main.GetMethodUFunction(AutomationPerformaceHelper.StaticClass, "IsCurrentRecordWithinGPUBudget");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsCurrentRecordWithinGPUBudget_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsCurrentRecordWithinRenderThreadBudget_method {
            static internal IntPtr IsCurrentRecordWithinRenderThreadBudget_ptr;
            static IsCurrentRecordWithinRenderThreadBudget_method() {
                IsCurrentRecordWithinRenderThreadBudget_ptr = Main.GetMethodUFunction(AutomationPerformaceHelper.StaticClass, "IsCurrentRecordWithinRenderThreadBudget");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsCurrentRecordWithinRenderThreadBudget_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsRecording_method {
            static internal IntPtr IsRecording_ptr;
            static IsRecording_method() {
                IsRecording_ptr = Main.GetMethodUFunction(AutomationPerformaceHelper.StaticClass, "IsRecording");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsRecording_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct OnAllTestsComplete_method {
            static internal IntPtr OnAllTestsComplete_ptr;
            static OnAllTestsComplete_method() {
                OnAllTestsComplete_ptr = Main.GetMethodUFunction(AutomationPerformaceHelper.StaticClass, "OnAllTestsComplete");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, OnAllTestsComplete_ptr, new IntPtr(p)); ;
            }
        }
        internal struct OnBeginTests_method {
            static internal IntPtr OnBeginTests_ptr;
            static OnBeginTests_method() {
                OnBeginTests_ptr = Main.GetMethodUFunction(AutomationPerformaceHelper.StaticClass, "OnBeginTests");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, OnBeginTests_ptr, new IntPtr(p)); ;
            }
        }
        internal struct Sample_method {
            static internal IntPtr Sample_ptr;
            static Sample_method() {
                Sample_ptr = Main.GetMethodUFunction(AutomationPerformaceHelper.StaticClass, "Sample");
            }

            internal static unsafe void Invoke(IntPtr obj, float DeltaSeconds) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = DeltaSeconds;
                Main.GetProcessEvent(obj, Sample_ptr, new IntPtr(p)); ;
            }
        }
        internal struct StartCPUProfiling_method {
            static internal IntPtr StartCPUProfiling_ptr;
            static StartCPUProfiling_method() {
                StartCPUProfiling_ptr = Main.GetMethodUFunction(AutomationPerformaceHelper.StaticClass, "StartCPUProfiling");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, StartCPUProfiling_ptr, new IntPtr(p)); ;
            }
        }
        internal struct StopCPUProfiling_method {
            static internal IntPtr StopCPUProfiling_ptr;
            static StopCPUProfiling_method() {
                StopCPUProfiling_ptr = Main.GetMethodUFunction(AutomationPerformaceHelper.StaticClass, "StopCPUProfiling");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, StopCPUProfiling_ptr, new IntPtr(p)); ;
            }
        }
        internal struct Tick_method {
            static internal IntPtr Tick_ptr;
            static Tick_method() {
                Tick_ptr = Main.GetMethodUFunction(AutomationPerformaceHelper.StaticClass, "Tick");
            }

            internal static unsafe void Invoke(IntPtr obj, float DeltaSeconds) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = DeltaSeconds;
                Main.GetProcessEvent(obj, Tick_ptr, new IntPtr(p)); ;
            }
        }
        internal struct TriggerGPUTraceIfRecordFallsBelowBudget_method {
            static internal IntPtr TriggerGPUTraceIfRecordFallsBelowBudget_ptr;
            static TriggerGPUTraceIfRecordFallsBelowBudget_method() {
                TriggerGPUTraceIfRecordFallsBelowBudget_ptr = Main.GetMethodUFunction(AutomationPerformaceHelper.StaticClass, "TriggerGPUTraceIfRecordFallsBelowBudget");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, TriggerGPUTraceIfRecordFallsBelowBudget_ptr, new IntPtr(p)); ;
            }
        }
        internal struct WriteLogFile_method {
            static internal IntPtr WriteLogFile_ptr;
            static WriteLogFile_method() {
                WriteLogFile_ptr = Main.GetMethodUFunction(AutomationPerformaceHelper.StaticClass, "WriteLogFile");
            }

            internal static unsafe void Invoke(IntPtr obj, string CaptureDir, string CaptureExtension) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                var CaptureDir_handle = GCHandle.Alloc(CaptureDir, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = CaptureDir_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = CaptureDir.Length;
                *(int*)(b+IntPtr.Size+4+0) = CaptureDir.Length;
                var CaptureExtension_handle = GCHandle.Alloc(CaptureExtension, GCHandleType.Pinned);
                *(IntPtr*)(b+16) = CaptureExtension_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+16) = CaptureExtension.Length;
                *(int*)(b+IntPtr.Size+4+16) = CaptureExtension.Length;
                Main.GetProcessEvent(obj, WriteLogFile_ptr, new IntPtr(p)); ;
                CaptureDir_handle.Free();
                CaptureExtension_handle.Free();
            }
        }
    }
    internal unsafe struct AutomationPerformaceHelper_events {
    }
}
