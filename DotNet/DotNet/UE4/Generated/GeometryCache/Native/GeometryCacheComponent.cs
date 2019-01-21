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


namespace UE4.GeometryCache.Native {
    [StructLayout( LayoutKind.Explicit, Size=1632 )]
    internal unsafe struct GeometryCacheComponent_fields {
        [FieldOffset(1544)]  public IntPtr  GeometryCache;
        [FieldOffset(1552)] public bool bRunning;
        [FieldOffset(1553)] public bool bLooping;
        [FieldOffset(1556)] public float StartTimeOffset;
        [FieldOffset(1560)] public float PlaybackSpeed;
        [FieldOffset(1564)] public int NumTracks;
        [FieldOffset(1568)] public float ElapsedTime;
        [FieldOffset(1620)] public float Duration;
        [FieldOffset(1624)] public bool bManualTick;
    }
    internal unsafe struct GeometryCacheComponent_methods {
        internal struct GetAnimationTime_method {
            static internal IntPtr GetAnimationTime_ptr;
            static GetAnimationTime_method() {
                GetAnimationTime_ptr = Main.GetMethodUFunction(GeometryCacheComponent.StaticClass, "GetAnimationTime");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetAnimationTime_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetDuration_method {
            static internal IntPtr GetDuration_ptr;
            static GetDuration_method() {
                GetDuration_ptr = Main.GetMethodUFunction(GeometryCacheComponent.StaticClass, "GetDuration");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetDuration_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetNumberOfFrames_method {
            static internal IntPtr GetNumberOfFrames_ptr;
            static GetNumberOfFrames_method() {
                GetNumberOfFrames_ptr = Main.GetMethodUFunction(GeometryCacheComponent.StaticClass, "GetNumberOfFrames");
            }

            internal static unsafe int Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetNumberOfFrames_ptr, new IntPtr(p)); ;
                return *((int*)(b+0));
            }
        }
        internal struct GetPlaybackDirection_method {
            static internal IntPtr GetPlaybackDirection_ptr;
            static GetPlaybackDirection_method() {
                GetPlaybackDirection_ptr = Main.GetMethodUFunction(GeometryCacheComponent.StaticClass, "GetPlaybackDirection");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetPlaybackDirection_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetPlaybackSpeed_method {
            static internal IntPtr GetPlaybackSpeed_ptr;
            static GetPlaybackSpeed_method() {
                GetPlaybackSpeed_ptr = Main.GetMethodUFunction(GeometryCacheComponent.StaticClass, "GetPlaybackSpeed");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetPlaybackSpeed_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetStartTimeOffset_method {
            static internal IntPtr GetStartTimeOffset_ptr;
            static GetStartTimeOffset_method() {
                GetStartTimeOffset_ptr = Main.GetMethodUFunction(GeometryCacheComponent.StaticClass, "GetStartTimeOffset");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetStartTimeOffset_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct IsLooping_method {
            static internal IntPtr IsLooping_ptr;
            static IsLooping_method() {
                IsLooping_ptr = Main.GetMethodUFunction(GeometryCacheComponent.StaticClass, "IsLooping");
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
                IsPlaying_ptr = Main.GetMethodUFunction(GeometryCacheComponent.StaticClass, "IsPlaying");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsPlaying_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsPlayingReversed_method {
            static internal IntPtr IsPlayingReversed_ptr;
            static IsPlayingReversed_method() {
                IsPlayingReversed_ptr = Main.GetMethodUFunction(GeometryCacheComponent.StaticClass, "IsPlayingReversed");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsPlayingReversed_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct Pause_method {
            static internal IntPtr Pause_ptr;
            static Pause_method() {
                Pause_ptr = Main.GetMethodUFunction(GeometryCacheComponent.StaticClass, "Pause");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, Pause_ptr, new IntPtr(p)); ;
            }
        }
        internal struct Play_method {
            static internal IntPtr Play_ptr;
            static Play_method() {
                Play_ptr = Main.GetMethodUFunction(GeometryCacheComponent.StaticClass, "Play");
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
                PlayFromStart_ptr = Main.GetMethodUFunction(GeometryCacheComponent.StaticClass, "PlayFromStart");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, PlayFromStart_ptr, new IntPtr(p)); ;
            }
        }
        internal struct PlayReversed_method {
            static internal IntPtr PlayReversed_ptr;
            static PlayReversed_method() {
                PlayReversed_ptr = Main.GetMethodUFunction(GeometryCacheComponent.StaticClass, "PlayReversed");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, PlayReversed_ptr, new IntPtr(p)); ;
            }
        }
        internal struct PlayReversedFromEnd_method {
            static internal IntPtr PlayReversedFromEnd_ptr;
            static PlayReversedFromEnd_method() {
                PlayReversedFromEnd_ptr = Main.GetMethodUFunction(GeometryCacheComponent.StaticClass, "PlayReversedFromEnd");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, PlayReversedFromEnd_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetGeometryCache_method {
            static internal IntPtr SetGeometryCache_ptr;
            static SetGeometryCache_method() {
                SetGeometryCache_ptr = Main.GetMethodUFunction(GeometryCacheComponent.StaticClass, "SetGeometryCache");
            }

            internal static unsafe bool Invoke(IntPtr obj, GeometryCache NewGeomCache) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = NewGeomCache;
                Main.GetProcessEvent(obj, SetGeometryCache_ptr, new IntPtr(p)); ;
                return *((bool*)(b+8));
            }
        }
        internal struct SetLooping_method {
            static internal IntPtr SetLooping_ptr;
            static SetLooping_method() {
                SetLooping_ptr = Main.GetMethodUFunction(GeometryCacheComponent.StaticClass, "SetLooping");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bNewLooping) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bNewLooping;
                Main.GetProcessEvent(obj, SetLooping_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetPlaybackSpeed_method {
            static internal IntPtr SetPlaybackSpeed_ptr;
            static SetPlaybackSpeed_method() {
                SetPlaybackSpeed_ptr = Main.GetMethodUFunction(GeometryCacheComponent.StaticClass, "SetPlaybackSpeed");
            }

            internal static unsafe void Invoke(IntPtr obj, float NewPlaybackSpeed) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = NewPlaybackSpeed;
                Main.GetProcessEvent(obj, SetPlaybackSpeed_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetStartTimeOffset_method {
            static internal IntPtr SetStartTimeOffset_ptr;
            static SetStartTimeOffset_method() {
                SetStartTimeOffset_ptr = Main.GetMethodUFunction(GeometryCacheComponent.StaticClass, "SetStartTimeOffset");
            }

            internal static unsafe void Invoke(IntPtr obj, float NewStartTimeOffset) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = NewStartTimeOffset;
                Main.GetProcessEvent(obj, SetStartTimeOffset_ptr, new IntPtr(p)); ;
            }
        }
        internal struct Stop_method {
            static internal IntPtr Stop_ptr;
            static Stop_method() {
                Stop_ptr = Main.GetMethodUFunction(GeometryCacheComponent.StaticClass, "Stop");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, Stop_ptr, new IntPtr(p)); ;
            }
        }
        internal struct TickAtThisTime_method {
            static internal IntPtr TickAtThisTime_ptr;
            static TickAtThisTime_method() {
                TickAtThisTime_ptr = Main.GetMethodUFunction(GeometryCacheComponent.StaticClass, "TickAtThisTime");
            }

            internal static unsafe void Invoke(IntPtr obj, float Time, bool bInIsRunning, bool bInBackwards, bool bInIsLooping) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Time;
                *((bool*)(b+4)) = bInIsRunning;
                *((bool*)(b+5)) = bInBackwards;
                *((bool*)(b+6)) = bInIsLooping;
                Main.GetProcessEvent(obj, TickAtThisTime_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct GeometryCacheComponent_events {
    }
}
