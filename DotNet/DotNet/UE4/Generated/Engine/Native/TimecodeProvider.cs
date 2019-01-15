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
    internal unsafe struct TimecodeProvider_fields {
    }
    internal unsafe struct TimecodeProvider_methods {
        internal struct GetFrameRate_method {
            static internal IntPtr GetFrameRate_ptr;
            static GetFrameRate_method() {
                GetFrameRate_ptr = Main.GetMethodUFunction(TimecodeProvider.StaticClass, "GetFrameRate");
            }

            internal static unsafe FrameRate Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetFrameRate_ptr, new IntPtr(p)); ;
                return *((FrameRate*)(b+0));
            }
        }
        internal struct GetSynchronizationState_method {
            static internal IntPtr GetSynchronizationState_ptr;
            static GetSynchronizationState_method() {
                GetSynchronizationState_ptr = Main.GetMethodUFunction(TimecodeProvider.StaticClass, "GetSynchronizationState");
            }

            internal static unsafe ETimecodeProviderSynchronizationState Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetSynchronizationState_ptr, new IntPtr(p)); ;
                return *((ETimecodeProviderSynchronizationState*)(b+0));
            }
        }
        internal struct GetTimecode_method {
            static internal IntPtr GetTimecode_ptr;
            static GetTimecode_method() {
                GetTimecode_ptr = Main.GetMethodUFunction(TimecodeProvider.StaticClass, "GetTimecode");
            }

            internal static unsafe Timecode Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetTimecode_ptr, new IntPtr(p)); ;
                return *((Timecode*)(b+0));
            }
        }
    }
    internal unsafe struct TimecodeProvider_events {
    }
}
