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


namespace UE4.LinearTimecode.Native {
    [StructLayout( LayoutKind.Explicit, Size=736 )]
    internal unsafe struct LinearTimecodeComponent_fields {
        [FieldOffset(624)]  public IntPtr  MediaPlayer;
        [FieldOffset(632)] public DropTimecode DropTimecode;
        [FieldOffset(664)] byte OnTimecodeChange; //TODO: multicast delegate FOnTimecodeChange OnTimecodeChange
    }
    internal unsafe struct LinearTimecodeComponent_methods {
        internal struct GetDropFrameNumber_method {
            static internal IntPtr GetDropFrameNumber_ptr;
            static GetDropFrameNumber_method() {
                GetDropFrameNumber_ptr = Main.GetMethodUFunction(LinearTimecodeComponent.StaticClass, "GetDropFrameNumber");
            }

            internal static unsafe int Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetDropFrameNumber_ptr, new IntPtr(p)); ;
                return *((int*)(b+0));
            }
        }
        internal struct GetDropTimeCodeFrameNumber_method {
            static internal IntPtr GetDropTimeCodeFrameNumber_ptr;
            static GetDropTimeCodeFrameNumber_method() {
                GetDropTimeCodeFrameNumber_ptr = Main.GetMethodUFunction(LinearTimecodeComponent.StaticClass, "GetDropTimeCodeFrameNumber");
            }

            internal static unsafe int Invoke(DropTimecode Timecode) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((DropTimecode*)(b+0)) = Timecode;
                Main.GetProcessEvent(LinearTimecodeComponent.DefaultObject, GetDropTimeCodeFrameNumber_ptr, new IntPtr(p)); ;
                return *((int*)(b+28));
            }
        }
        internal struct SetDropTimecodeFrameNumber_method {
            static internal IntPtr SetDropTimecodeFrameNumber_ptr;
            static SetDropTimecodeFrameNumber_method() {
                SetDropTimecodeFrameNumber_ptr = Main.GetMethodUFunction(LinearTimecodeComponent.StaticClass, "SetDropTimecodeFrameNumber");
            }

            internal static unsafe DropTimecode Invoke(DropTimecode Timecode, int FrameNumber) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((DropTimecode*)(b+0)) = Timecode;
                *((int*)(b+28)) = FrameNumber;
                Main.GetProcessEvent(LinearTimecodeComponent.DefaultObject, SetDropTimecodeFrameNumber_ptr, new IntPtr(p)); ;
                return *((DropTimecode*)(b+32));
            }
        }
    }
    internal unsafe struct LinearTimecodeComponent_events {
    }
}
