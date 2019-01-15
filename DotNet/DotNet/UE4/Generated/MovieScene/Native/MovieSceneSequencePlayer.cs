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


namespace UE4.MovieScene.Native {
    [StructLayout( LayoutKind.Explicit, Size=2032 )]
    internal unsafe struct MovieSceneSequencePlayer_fields {
        [FieldOffset(896)] byte OnPlay; //TODO: multicast delegate FOnMovieSceneSequencePlayerEvent OnPlay
        [FieldOffset(912)] byte OnPlayReverse; //TODO: multicast delegate FOnMovieSceneSequencePlayerEvent OnPlayReverse
        [FieldOffset(928)] byte OnStop; //TODO: multicast delegate FOnMovieSceneSequencePlayerEvent OnStop
        [FieldOffset(944)] byte OnPause; //TODO: multicast delegate FOnMovieSceneSequencePlayerEvent OnPause
        [FieldOffset(960)] byte OnFinished; //TODO: multicast delegate FOnMovieSceneSequencePlayerEvent OnFinished
        [FieldOffset(976)] public byte Status;
        [FieldOffset(980)] public bool bReversePlayback;
        [FieldOffset(992)]  public IntPtr  Sequence;
        [FieldOffset(1000)] public FrameNumber StartTime;
        [FieldOffset(1004)] public int DurationFrames;
        [FieldOffset(1008)] public int CurrentNumLoops;
        [FieldOffset(1032)] public MovieSceneSequencePlaybackSettings PlaybackSettings;
    }
    internal unsafe struct MovieSceneSequencePlayer_methods {
        internal struct ChangePlaybackDirection_method {
            static internal IntPtr ChangePlaybackDirection_ptr;
            static ChangePlaybackDirection_method() {
                ChangePlaybackDirection_ptr = Main.GetMethodUFunction(MovieSceneSequencePlayer.StaticClass, "ChangePlaybackDirection");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, ChangePlaybackDirection_ptr, new IntPtr(p)); ;
            }
        }
        internal struct GetBoundObjects_method {
            static internal IntPtr GetBoundObjects_ptr;
            static GetBoundObjects_method() {
                GetBoundObjects_ptr = Main.GetMethodUFunction(MovieSceneSequencePlayer.StaticClass, "GetBoundObjects");
            }

            internal static unsafe IReadOnlyCollection<UObject> Invoke(IntPtr obj, MovieSceneObjectBindingID ObjectBinding) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((MovieSceneObjectBindingID*)(b+0)) = ObjectBinding;
                Main.GetProcessEvent(obj, GetBoundObjects_ptr, new IntPtr(p)); ;
                 //TODO: array TArray ReturnValue
                return UObject.ToUObjectCollection<UObject>(b+24);
            }
        }
        internal struct GetCurrentTime_method {
            static internal IntPtr GetCurrentTime_ptr;
            static GetCurrentTime_method() {
                GetCurrentTime_ptr = Main.GetMethodUFunction(MovieSceneSequencePlayer.StaticClass, "GetCurrentTime");
            }

            internal static unsafe QualifiedFrameTime Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetCurrentTime_ptr, new IntPtr(p)); ;
                return *((QualifiedFrameTime*)(b+0));
            }
        }
        internal struct GetDisableCameraCuts_method {
            static internal IntPtr GetDisableCameraCuts_ptr;
            static GetDisableCameraCuts_method() {
                GetDisableCameraCuts_ptr = Main.GetMethodUFunction(MovieSceneSequencePlayer.StaticClass, "GetDisableCameraCuts");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetDisableCameraCuts_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct GetDuration_method {
            static internal IntPtr GetDuration_ptr;
            static GetDuration_method() {
                GetDuration_ptr = Main.GetMethodUFunction(MovieSceneSequencePlayer.StaticClass, "GetDuration");
            }

            internal static unsafe QualifiedFrameTime Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetDuration_ptr, new IntPtr(p)); ;
                return *((QualifiedFrameTime*)(b+0));
            }
        }
        internal struct GetEndTime_method {
            static internal IntPtr GetEndTime_ptr;
            static GetEndTime_method() {
                GetEndTime_ptr = Main.GetMethodUFunction(MovieSceneSequencePlayer.StaticClass, "GetEndTime");
            }

            internal static unsafe QualifiedFrameTime Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetEndTime_ptr, new IntPtr(p)); ;
                return *((QualifiedFrameTime*)(b+0));
            }
        }
        internal struct GetFrameDuration_method {
            static internal IntPtr GetFrameDuration_ptr;
            static GetFrameDuration_method() {
                GetFrameDuration_ptr = Main.GetMethodUFunction(MovieSceneSequencePlayer.StaticClass, "GetFrameDuration");
            }

            internal static unsafe int Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetFrameDuration_ptr, new IntPtr(p)); ;
                return *((int*)(b+0));
            }
        }
        internal struct GetFrameRate_method {
            static internal IntPtr GetFrameRate_ptr;
            static GetFrameRate_method() {
                GetFrameRate_ptr = Main.GetMethodUFunction(MovieSceneSequencePlayer.StaticClass, "GetFrameRate");
            }

            internal static unsafe FrameRate Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetFrameRate_ptr, new IntPtr(p)); ;
                return *((FrameRate*)(b+0));
            }
        }
        internal struct GetLength_method {
            static internal IntPtr GetLength_ptr;
            static GetLength_method() {
                GetLength_ptr = Main.GetMethodUFunction(MovieSceneSequencePlayer.StaticClass, "GetLength");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetLength_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetPlaybackEnd_method {
            static internal IntPtr GetPlaybackEnd_ptr;
            static GetPlaybackEnd_method() {
                GetPlaybackEnd_ptr = Main.GetMethodUFunction(MovieSceneSequencePlayer.StaticClass, "GetPlaybackEnd");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetPlaybackEnd_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetPlaybackPosition_method {
            static internal IntPtr GetPlaybackPosition_ptr;
            static GetPlaybackPosition_method() {
                GetPlaybackPosition_ptr = Main.GetMethodUFunction(MovieSceneSequencePlayer.StaticClass, "GetPlaybackPosition");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetPlaybackPosition_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetPlaybackStart_method {
            static internal IntPtr GetPlaybackStart_ptr;
            static GetPlaybackStart_method() {
                GetPlaybackStart_ptr = Main.GetMethodUFunction(MovieSceneSequencePlayer.StaticClass, "GetPlaybackStart");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetPlaybackStart_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetPlayRate_method {
            static internal IntPtr GetPlayRate_ptr;
            static GetPlayRate_method() {
                GetPlayRate_ptr = Main.GetMethodUFunction(MovieSceneSequencePlayer.StaticClass, "GetPlayRate");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetPlayRate_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetStartTime_method {
            static internal IntPtr GetStartTime_ptr;
            static GetStartTime_method() {
                GetStartTime_ptr = Main.GetMethodUFunction(MovieSceneSequencePlayer.StaticClass, "GetStartTime");
            }

            internal static unsafe QualifiedFrameTime Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetStartTime_ptr, new IntPtr(p)); ;
                return *((QualifiedFrameTime*)(b+0));
            }
        }
        internal struct GoToEndAndStop_method {
            static internal IntPtr GoToEndAndStop_ptr;
            static GoToEndAndStop_method() {
                GoToEndAndStop_ptr = Main.GetMethodUFunction(MovieSceneSequencePlayer.StaticClass, "GoToEndAndStop");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GoToEndAndStop_ptr, new IntPtr(p)); ;
            }
        }
        internal struct IsPaused_method {
            static internal IntPtr IsPaused_ptr;
            static IsPaused_method() {
                IsPaused_ptr = Main.GetMethodUFunction(MovieSceneSequencePlayer.StaticClass, "IsPaused");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsPaused_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsPlaying_method {
            static internal IntPtr IsPlaying_ptr;
            static IsPlaying_method() {
                IsPlaying_ptr = Main.GetMethodUFunction(MovieSceneSequencePlayer.StaticClass, "IsPlaying");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsPlaying_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsReversed_method {
            static internal IntPtr IsReversed_ptr;
            static IsReversed_method() {
                IsReversed_ptr = Main.GetMethodUFunction(MovieSceneSequencePlayer.StaticClass, "IsReversed");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsReversed_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct JumpToFrame_method {
            static internal IntPtr JumpToFrame_ptr;
            static JumpToFrame_method() {
                JumpToFrame_ptr = Main.GetMethodUFunction(MovieSceneSequencePlayer.StaticClass, "JumpToFrame");
            }

            internal static unsafe void Invoke(IntPtr obj, FrameTime NewPosition) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((FrameTime*)(b+0)) = NewPosition;
                Main.GetProcessEvent(obj, JumpToFrame_ptr, new IntPtr(p)); ;
            }
        }
        internal struct JumpToPosition_method {
            static internal IntPtr JumpToPosition_ptr;
            static JumpToPosition_method() {
                JumpToPosition_ptr = Main.GetMethodUFunction(MovieSceneSequencePlayer.StaticClass, "JumpToPosition");
            }

            internal static unsafe void Invoke(IntPtr obj, float NewPlaybackPosition) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = NewPlaybackPosition;
                Main.GetProcessEvent(obj, JumpToPosition_ptr, new IntPtr(p)); ;
            }
        }
        internal struct JumpToSeconds_method {
            static internal IntPtr JumpToSeconds_ptr;
            static JumpToSeconds_method() {
                JumpToSeconds_ptr = Main.GetMethodUFunction(MovieSceneSequencePlayer.StaticClass, "JumpToSeconds");
            }

            internal static unsafe void Invoke(IntPtr obj, float TimeInSeconds) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = TimeInSeconds;
                Main.GetProcessEvent(obj, JumpToSeconds_ptr, new IntPtr(p)); ;
            }
        }
        internal struct Pause_method {
            static internal IntPtr Pause_ptr;
            static Pause_method() {
                Pause_ptr = Main.GetMethodUFunction(MovieSceneSequencePlayer.StaticClass, "Pause");
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
                Play_ptr = Main.GetMethodUFunction(MovieSceneSequencePlayer.StaticClass, "Play");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, Play_ptr, new IntPtr(p)); ;
            }
        }
        internal struct PlayLooping_method {
            static internal IntPtr PlayLooping_ptr;
            static PlayLooping_method() {
                PlayLooping_ptr = Main.GetMethodUFunction(MovieSceneSequencePlayer.StaticClass, "PlayLooping");
            }

            internal static unsafe void Invoke(IntPtr obj, int NumLoops) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = NumLoops;
                Main.GetProcessEvent(obj, PlayLooping_ptr, new IntPtr(p)); ;
            }
        }
        internal struct PlayReverse_method {
            static internal IntPtr PlayReverse_ptr;
            static PlayReverse_method() {
                PlayReverse_ptr = Main.GetMethodUFunction(MovieSceneSequencePlayer.StaticClass, "PlayReverse");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, PlayReverse_ptr, new IntPtr(p)); ;
            }
        }
        internal struct PlayToFrame_method {
            static internal IntPtr PlayToFrame_ptr;
            static PlayToFrame_method() {
                PlayToFrame_ptr = Main.GetMethodUFunction(MovieSceneSequencePlayer.StaticClass, "PlayToFrame");
            }

            internal static unsafe void Invoke(IntPtr obj, FrameTime NewPosition) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((FrameTime*)(b+0)) = NewPosition;
                Main.GetProcessEvent(obj, PlayToFrame_ptr, new IntPtr(p)); ;
            }
        }
        internal struct PlayToSeconds_method {
            static internal IntPtr PlayToSeconds_ptr;
            static PlayToSeconds_method() {
                PlayToSeconds_ptr = Main.GetMethodUFunction(MovieSceneSequencePlayer.StaticClass, "PlayToSeconds");
            }

            internal static unsafe void Invoke(IntPtr obj, float TimeInSeconds) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = TimeInSeconds;
                Main.GetProcessEvent(obj, PlayToSeconds_ptr, new IntPtr(p)); ;
            }
        }
        internal struct Scrub_method {
            static internal IntPtr Scrub_ptr;
            static Scrub_method() {
                Scrub_ptr = Main.GetMethodUFunction(MovieSceneSequencePlayer.StaticClass, "Scrub");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, Scrub_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ScrubToFrame_method {
            static internal IntPtr ScrubToFrame_ptr;
            static ScrubToFrame_method() {
                ScrubToFrame_ptr = Main.GetMethodUFunction(MovieSceneSequencePlayer.StaticClass, "ScrubToFrame");
            }

            internal static unsafe void Invoke(IntPtr obj, FrameTime NewPosition) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((FrameTime*)(b+0)) = NewPosition;
                Main.GetProcessEvent(obj, ScrubToFrame_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ScrubToSeconds_method {
            static internal IntPtr ScrubToSeconds_ptr;
            static ScrubToSeconds_method() {
                ScrubToSeconds_ptr = Main.GetMethodUFunction(MovieSceneSequencePlayer.StaticClass, "ScrubToSeconds");
            }

            internal static unsafe void Invoke(IntPtr obj, float TimeInSeconds) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = TimeInSeconds;
                Main.GetProcessEvent(obj, ScrubToSeconds_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetDisableCameraCuts_method {
            static internal IntPtr SetDisableCameraCuts_ptr;
            static SetDisableCameraCuts_method() {
                SetDisableCameraCuts_ptr = Main.GetMethodUFunction(MovieSceneSequencePlayer.StaticClass, "SetDisableCameraCuts");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bInDisableCameraCuts) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bInDisableCameraCuts;
                Main.GetProcessEvent(obj, SetDisableCameraCuts_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetFrameRange_method {
            static internal IntPtr SetFrameRange_ptr;
            static SetFrameRange_method() {
                SetFrameRange_ptr = Main.GetMethodUFunction(MovieSceneSequencePlayer.StaticClass, "SetFrameRange");
            }

            internal static unsafe void Invoke(IntPtr obj, int StartFrame, int Duration) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = StartFrame;
                *((int*)(b+4)) = Duration;
                Main.GetProcessEvent(obj, SetFrameRange_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetFrameRate_method {
            static internal IntPtr SetFrameRate_ptr;
            static SetFrameRate_method() {
                SetFrameRate_ptr = Main.GetMethodUFunction(MovieSceneSequencePlayer.StaticClass, "SetFrameRate");
            }

            internal static unsafe void Invoke(IntPtr obj, FrameRate FrameRate) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((FrameRate*)(b+0)) = FrameRate;
                Main.GetProcessEvent(obj, SetFrameRate_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetPlaybackPosition_method {
            static internal IntPtr SetPlaybackPosition_ptr;
            static SetPlaybackPosition_method() {
                SetPlaybackPosition_ptr = Main.GetMethodUFunction(MovieSceneSequencePlayer.StaticClass, "SetPlaybackPosition");
            }

            internal static unsafe void Invoke(IntPtr obj, float NewPlaybackPosition) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = NewPlaybackPosition;
                Main.GetProcessEvent(obj, SetPlaybackPosition_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetPlaybackRange_method {
            static internal IntPtr SetPlaybackRange_ptr;
            static SetPlaybackRange_method() {
                SetPlaybackRange_ptr = Main.GetMethodUFunction(MovieSceneSequencePlayer.StaticClass, "SetPlaybackRange");
            }

            internal static unsafe void Invoke(IntPtr obj, float NewStartTime, float NewEndTime) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = NewStartTime;
                *((float*)(b+4)) = NewEndTime;
                Main.GetProcessEvent(obj, SetPlaybackRange_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetPlayRate_method {
            static internal IntPtr SetPlayRate_ptr;
            static SetPlayRate_method() {
                SetPlayRate_ptr = Main.GetMethodUFunction(MovieSceneSequencePlayer.StaticClass, "SetPlayRate");
            }

            internal static unsafe void Invoke(IntPtr obj, float PlayRate) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = PlayRate;
                Main.GetProcessEvent(obj, SetPlayRate_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetTimeRange_method {
            static internal IntPtr SetTimeRange_ptr;
            static SetTimeRange_method() {
                SetTimeRange_ptr = Main.GetMethodUFunction(MovieSceneSequencePlayer.StaticClass, "SetTimeRange");
            }

            internal static unsafe void Invoke(IntPtr obj, float StartTime, float Duration) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = StartTime;
                *((float*)(b+4)) = Duration;
                Main.GetProcessEvent(obj, SetTimeRange_ptr, new IntPtr(p)); ;
            }
        }
        internal struct Stop_method {
            static internal IntPtr Stop_ptr;
            static Stop_method() {
                Stop_ptr = Main.GetMethodUFunction(MovieSceneSequencePlayer.StaticClass, "Stop");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, Stop_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct MovieSceneSequencePlayer_events {
    }
}
