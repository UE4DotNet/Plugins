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


namespace UE4.Engine.Native {
    [StructLayout( LayoutKind.Explicit, Size=56 )]
    internal unsafe struct HealthSnapshotBlueprintLibrary_fields {
    }
    internal unsafe struct HealthSnapshotBlueprintLibrary_methods {
        internal struct LogPerformanceSnapshot_method {
            static internal IntPtr LogPerformanceSnapshot_ptr;
            static LogPerformanceSnapshot_method() {
                LogPerformanceSnapshot_ptr = Main.GetMethodUFunction(HealthSnapshotBlueprintLibrary.StaticClass, "LogPerformanceSnapshot");
            }

            internal static unsafe void Invoke(string SnapshotTitle, bool bResetStats) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                var SnapshotTitle_handle = GCHandle.Alloc(SnapshotTitle, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = SnapshotTitle_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = SnapshotTitle.Length;
                *(int*)(b+IntPtr.Size+4+0) = SnapshotTitle.Length;
                *((bool*)(b+16)) = bResetStats;
                Main.GetProcessEvent(HealthSnapshotBlueprintLibrary.DefaultObject, LogPerformanceSnapshot_ptr, new IntPtr(p)); ;
                SnapshotTitle_handle.Free();
            }
        }
        internal struct StartPerformanceSnapshots_method {
            static internal IntPtr StartPerformanceSnapshots_ptr;
            static StartPerformanceSnapshots_method() {
                StartPerformanceSnapshots_ptr = Main.GetMethodUFunction(HealthSnapshotBlueprintLibrary.StaticClass, "StartPerformanceSnapshots");
            }

            internal static unsafe void Invoke() {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(HealthSnapshotBlueprintLibrary.DefaultObject, StartPerformanceSnapshots_ptr, new IntPtr(p)); ;
            }
        }
        internal struct StopPerformanceSnapshots_method {
            static internal IntPtr StopPerformanceSnapshots_ptr;
            static StopPerformanceSnapshots_method() {
                StopPerformanceSnapshots_ptr = Main.GetMethodUFunction(HealthSnapshotBlueprintLibrary.StaticClass, "StopPerformanceSnapshots");
            }

            internal static unsafe void Invoke() {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(HealthSnapshotBlueprintLibrary.DefaultObject, StopPerformanceSnapshots_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct HealthSnapshotBlueprintLibrary_events {
    }
}
