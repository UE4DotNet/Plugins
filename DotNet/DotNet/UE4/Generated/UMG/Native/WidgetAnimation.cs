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


namespace UE4.UMG.Native {
    [StructLayout( LayoutKind.Explicit, Size=952 )]
    internal unsafe struct WidgetAnimation_fields {
        [FieldOffset(888)] byte OnAnimationStarted; //TODO: multicast delegate FOnWidgetAnimationPlaybackStatusChanged OnAnimationStarted
        [FieldOffset(904)] byte OnAnimationFinished; //TODO: multicast delegate FOnWidgetAnimationPlaybackStatusChanged OnAnimationFinished
        [FieldOffset(920)]  public IntPtr  UMovieScene;
        [FieldOffset(928)] public NativeArray AnimationBindings;
        [FieldOffset(944)] public bool bLegacyFinishOnStop;
    }
    internal unsafe struct WidgetAnimation_methods {
        internal struct GetEndTime_method {
            static internal IntPtr GetEndTime_ptr;
            static GetEndTime_method() {
                GetEndTime_ptr = Main.GetMethodUFunction(WidgetAnimation.StaticClass, "GetEndTime");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetEndTime_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetStartTime_method {
            static internal IntPtr GetStartTime_ptr;
            static GetStartTime_method() {
                GetStartTime_ptr = Main.GetMethodUFunction(WidgetAnimation.StaticClass, "GetStartTime");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetStartTime_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
    }
    internal unsafe struct WidgetAnimation_events {
    }
}
