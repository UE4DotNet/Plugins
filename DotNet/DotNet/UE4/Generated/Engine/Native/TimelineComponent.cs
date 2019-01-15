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
    [StructLayout( LayoutKind.Explicit, Size=432 )]
    internal unsafe struct TimelineComponent_fields {
        [FieldOffset(256)] public Timeline TheTimeline;
        [FieldOffset(424)] public bool bIgnoreTimeDilation;
    }
    internal unsafe struct TimelineComponent_methods {
        internal struct GetIgnoreTimeDilation_method {
            static internal IntPtr GetIgnoreTimeDilation_ptr;
            static GetIgnoreTimeDilation_method() {
                GetIgnoreTimeDilation_ptr = Main.GetMethodUFunction(TimelineComponent.StaticClass, "GetIgnoreTimeDilation");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetIgnoreTimeDilation_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct GetPlaybackPosition_method {
            static internal IntPtr GetPlaybackPosition_ptr;
            static GetPlaybackPosition_method() {
                GetPlaybackPosition_ptr = Main.GetMethodUFunction(TimelineComponent.StaticClass, "GetPlaybackPosition");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetPlaybackPosition_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetPlayRate_method {
            static internal IntPtr GetPlayRate_ptr;
            static GetPlayRate_method() {
                GetPlayRate_ptr = Main.GetMethodUFunction(TimelineComponent.StaticClass, "GetPlayRate");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetPlayRate_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetTimelineLength_method {
            static internal IntPtr GetTimelineLength_ptr;
            static GetTimelineLength_method() {
                GetTimelineLength_ptr = Main.GetMethodUFunction(TimelineComponent.StaticClass, "GetTimelineLength");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetTimelineLength_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct IsLooping_method {
            static internal IntPtr IsLooping_ptr;
            static IsLooping_method() {
                IsLooping_ptr = Main.GetMethodUFunction(TimelineComponent.StaticClass, "IsLooping");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsLooping_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsPlaying_method {
            static internal IntPtr IsPlaying_ptr;
            static IsPlaying_method() {
                IsPlaying_ptr = Main.GetMethodUFunction(TimelineComponent.StaticClass, "IsPlaying");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsPlaying_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsReversing_method {
            static internal IntPtr IsReversing_ptr;
            static IsReversing_method() {
                IsReversing_ptr = Main.GetMethodUFunction(TimelineComponent.StaticClass, "IsReversing");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsReversing_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct Play_method {
            static internal IntPtr Play_ptr;
            static Play_method() {
                Play_ptr = Main.GetMethodUFunction(TimelineComponent.StaticClass, "Play");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, Play_ptr, new IntPtr(p)); ;
            }
        }
        internal struct PlayFromStart_method {
            static internal IntPtr PlayFromStart_ptr;
            static PlayFromStart_method() {
                PlayFromStart_ptr = Main.GetMethodUFunction(TimelineComponent.StaticClass, "PlayFromStart");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, PlayFromStart_ptr, new IntPtr(p)); ;
            }
        }
        internal struct Reverse_method {
            static internal IntPtr Reverse_ptr;
            static Reverse_method() {
                Reverse_ptr = Main.GetMethodUFunction(TimelineComponent.StaticClass, "Reverse");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, Reverse_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ReverseFromEnd_method {
            static internal IntPtr ReverseFromEnd_ptr;
            static ReverseFromEnd_method() {
                ReverseFromEnd_ptr = Main.GetMethodUFunction(TimelineComponent.StaticClass, "ReverseFromEnd");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, ReverseFromEnd_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetFloatCurve_method {
            static internal IntPtr SetFloatCurve_ptr;
            static SetFloatCurve_method() {
                SetFloatCurve_ptr = Main.GetMethodUFunction(TimelineComponent.StaticClass, "SetFloatCurve");
            }

            internal static unsafe void Invoke(IntPtr obj, CurveFloat NewFloatCurve, Name FloatTrackName) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = NewFloatCurve;
                *((Name*)(b+8)) = FloatTrackName;
                Main.GetProcessEvent(obj, SetFloatCurve_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetIgnoreTimeDilation_method {
            static internal IntPtr SetIgnoreTimeDilation_ptr;
            static SetIgnoreTimeDilation_method() {
                SetIgnoreTimeDilation_ptr = Main.GetMethodUFunction(TimelineComponent.StaticClass, "SetIgnoreTimeDilation");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bNewIgnoreTimeDilation) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bNewIgnoreTimeDilation;
                Main.GetProcessEvent(obj, SetIgnoreTimeDilation_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetLinearColorCurve_method {
            static internal IntPtr SetLinearColorCurve_ptr;
            static SetLinearColorCurve_method() {
                SetLinearColorCurve_ptr = Main.GetMethodUFunction(TimelineComponent.StaticClass, "SetLinearColorCurve");
            }

            internal static unsafe void Invoke(IntPtr obj, CurveLinearColor NewLinearColorCurve, Name LinearColorTrackName) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = NewLinearColorCurve;
                *((Name*)(b+8)) = LinearColorTrackName;
                Main.GetProcessEvent(obj, SetLinearColorCurve_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetLooping_method {
            static internal IntPtr SetLooping_ptr;
            static SetLooping_method() {
                SetLooping_ptr = Main.GetMethodUFunction(TimelineComponent.StaticClass, "SetLooping");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bNewLooping) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bNewLooping;
                Main.GetProcessEvent(obj, SetLooping_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetNewTime_method {
            static internal IntPtr SetNewTime_ptr;
            static SetNewTime_method() {
                SetNewTime_ptr = Main.GetMethodUFunction(TimelineComponent.StaticClass, "SetNewTime");
            }

            internal static unsafe void Invoke(IntPtr obj, float NewTime) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = NewTime;
                Main.GetProcessEvent(obj, SetNewTime_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetPlaybackPosition_method {
            static internal IntPtr SetPlaybackPosition_ptr;
            static SetPlaybackPosition_method() {
                SetPlaybackPosition_ptr = Main.GetMethodUFunction(TimelineComponent.StaticClass, "SetPlaybackPosition");
            }

            internal static unsafe void Invoke(IntPtr obj, float NewPosition, bool bFireEvents, bool bFireUpdate) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = NewPosition;
                *((bool*)(b+4)) = bFireEvents;
                *((bool*)(b+5)) = bFireUpdate;
                Main.GetProcessEvent(obj, SetPlaybackPosition_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetPlayRate_method {
            static internal IntPtr SetPlayRate_ptr;
            static SetPlayRate_method() {
                SetPlayRate_ptr = Main.GetMethodUFunction(TimelineComponent.StaticClass, "SetPlayRate");
            }

            internal static unsafe void Invoke(IntPtr obj, float NewRate) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = NewRate;
                Main.GetProcessEvent(obj, SetPlayRate_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetTimelineLength_method {
            static internal IntPtr SetTimelineLength_ptr;
            static SetTimelineLength_method() {
                SetTimelineLength_ptr = Main.GetMethodUFunction(TimelineComponent.StaticClass, "SetTimelineLength");
            }

            internal static unsafe void Invoke(IntPtr obj, float NewLength) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = NewLength;
                Main.GetProcessEvent(obj, SetTimelineLength_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetTimelineLengthMode_method {
            static internal IntPtr SetTimelineLengthMode_ptr;
            static SetTimelineLengthMode_method() {
                SetTimelineLengthMode_ptr = Main.GetMethodUFunction(TimelineComponent.StaticClass, "SetTimelineLengthMode");
            }

            internal static unsafe void Invoke(IntPtr obj, byte NewLengthMode) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = NewLengthMode;
                Main.GetProcessEvent(obj, SetTimelineLengthMode_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetVectorCurve_method {
            static internal IntPtr SetVectorCurve_ptr;
            static SetVectorCurve_method() {
                SetVectorCurve_ptr = Main.GetMethodUFunction(TimelineComponent.StaticClass, "SetVectorCurve");
            }

            internal static unsafe void Invoke(IntPtr obj, CurveVector NewVectorCurve, Name VectorTrackName) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = NewVectorCurve;
                *((Name*)(b+8)) = VectorTrackName;
                Main.GetProcessEvent(obj, SetVectorCurve_ptr, new IntPtr(p)); ;
            }
        }
        internal struct Stop_method {
            static internal IntPtr Stop_ptr;
            static Stop_method() {
                Stop_ptr = Main.GetMethodUFunction(TimelineComponent.StaticClass, "Stop");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, Stop_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct TimelineComponent_events {
    }
}
