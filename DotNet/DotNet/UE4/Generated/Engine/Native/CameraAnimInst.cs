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
    [StructLayout( LayoutKind.Explicit, Size=288 )]
    internal unsafe struct CameraAnimInst_fields {
        [FieldOffset(56)]  public IntPtr  CamAnim;
        [FieldOffset(64)]  public IntPtr  InterpGroupInst;
        [FieldOffset(96)] public float PlayRate;
        [FieldOffset(120)]  public IntPtr  MoveTrack;
        [FieldOffset(128)]  public IntPtr  MoveInst;
        [FieldOffset(136)] public byte PlaySpace;
    }
    internal unsafe struct CameraAnimInst_methods {
        internal struct SetDuration_method {
            static internal IntPtr SetDuration_ptr;
            static SetDuration_method() {
                SetDuration_ptr = Main.GetMethodUFunction(CameraAnimInst.StaticClass, "SetDuration");
            }

            internal static unsafe void Invoke(IntPtr obj, float NewDuration) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = NewDuration;
                Main.GetProcessEvent(obj, SetDuration_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetScale_method {
            static internal IntPtr SetScale_ptr;
            static SetScale_method() {
                SetScale_ptr = Main.GetMethodUFunction(CameraAnimInst.StaticClass, "SetScale");
            }

            internal static unsafe void Invoke(IntPtr obj, float NewDuration) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = NewDuration;
                Main.GetProcessEvent(obj, SetScale_ptr, new IntPtr(p)); ;
            }
        }
        internal struct Stop_method {
            static internal IntPtr Stop_ptr;
            static Stop_method() {
                Stop_ptr = Main.GetMethodUFunction(CameraAnimInst.StaticClass, "Stop");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bImmediate) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bImmediate;
                Main.GetProcessEvent(obj, Stop_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct CameraAnimInst_events {
    }
}
