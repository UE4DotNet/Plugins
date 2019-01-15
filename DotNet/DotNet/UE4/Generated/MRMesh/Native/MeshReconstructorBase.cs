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


namespace UE4.MRMesh.Native {
    [StructLayout( LayoutKind.Explicit, Size=56 )]
    internal unsafe struct MeshReconstructorBase_fields {
    }
    internal unsafe struct MeshReconstructorBase_methods {
        internal struct IsReconstructionPaused_method {
            static internal IntPtr IsReconstructionPaused_ptr;
            static IsReconstructionPaused_method() {
                IsReconstructionPaused_ptr = Main.GetMethodUFunction(MeshReconstructorBase.StaticClass, "IsReconstructionPaused");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsReconstructionPaused_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsReconstructionStarted_method {
            static internal IntPtr IsReconstructionStarted_ptr;
            static IsReconstructionStarted_method() {
                IsReconstructionStarted_ptr = Main.GetMethodUFunction(MeshReconstructorBase.StaticClass, "IsReconstructionStarted");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsReconstructionStarted_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct PauseReconstruction_method {
            static internal IntPtr PauseReconstruction_ptr;
            static PauseReconstruction_method() {
                PauseReconstruction_ptr = Main.GetMethodUFunction(MeshReconstructorBase.StaticClass, "PauseReconstruction");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, PauseReconstruction_ptr, new IntPtr(p)); ;
            }
        }
        internal struct StartReconstruction_method {
            static internal IntPtr StartReconstruction_ptr;
            static StartReconstruction_method() {
                StartReconstruction_ptr = Main.GetMethodUFunction(MeshReconstructorBase.StaticClass, "StartReconstruction");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, StartReconstruction_ptr, new IntPtr(p)); ;
            }
        }
        internal struct StopReconstruction_method {
            static internal IntPtr StopReconstruction_ptr;
            static StopReconstruction_method() {
                StopReconstruction_ptr = Main.GetMethodUFunction(MeshReconstructorBase.StaticClass, "StopReconstruction");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, StopReconstruction_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct MeshReconstructorBase_events {
    }
}
