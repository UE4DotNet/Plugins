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


namespace UE4.Paper2D.Native {
    [StructLayout( LayoutKind.Explicit, Size=1616 )]
    internal unsafe struct PaperFlipbookComponent_fields {
        [FieldOffset(1544)]  public IntPtr  SourceFlipbook;
        [FieldOffset(1560)] public float PlayRate;
        [FieldOffset(1564)] public bool bLooping;
        [FieldOffset(1564)] public bool bReversePlayback;
        [FieldOffset(1564)] public bool bPlaying;
        [FieldOffset(1568)] public float AccumulatedTime;
        [FieldOffset(1572)] public int CachedFrameIndex;
        [FieldOffset(1576)] public LinearColor SpriteColor;
        [FieldOffset(1592)]  public IntPtr  CachedBodySetup;
        [FieldOffset(1600)] byte OnFinishedPlaying; //TODO: multicast delegate FFlipbookFinishedPlaySignature OnFinishedPlaying
    }
    internal unsafe struct PaperFlipbookComponent_methods {
        internal struct GetFlipbook_method {
            static internal IntPtr GetFlipbook_ptr;
            static GetFlipbook_method() {
                GetFlipbook_ptr = Main.GetMethodUFunction(PaperFlipbookComponent.StaticClass, "GetFlipbook");
            }

            internal static unsafe PaperFlipbook Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetFlipbook_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
        internal struct GetFlipbookFramerate_method {
            static internal IntPtr GetFlipbookFramerate_ptr;
            static GetFlipbookFramerate_method() {
                GetFlipbookFramerate_ptr = Main.GetMethodUFunction(PaperFlipbookComponent.StaticClass, "GetFlipbookFramerate");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetFlipbookFramerate_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetFlipbookLength_method {
            static internal IntPtr GetFlipbookLength_ptr;
            static GetFlipbookLength_method() {
                GetFlipbookLength_ptr = Main.GetMethodUFunction(PaperFlipbookComponent.StaticClass, "GetFlipbookLength");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetFlipbookLength_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetFlipbookLengthInFrames_method {
            static internal IntPtr GetFlipbookLengthInFrames_ptr;
            static GetFlipbookLengthInFrames_method() {
                GetFlipbookLengthInFrames_ptr = Main.GetMethodUFunction(PaperFlipbookComponent.StaticClass, "GetFlipbookLengthInFrames");
            }

            internal static unsafe int Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetFlipbookLengthInFrames_ptr, new IntPtr(p)); ;
                return *((int*)(b+0));
            }
        }
        internal struct GetPlaybackPosition_method {
            static internal IntPtr GetPlaybackPosition_ptr;
            static GetPlaybackPosition_method() {
                GetPlaybackPosition_ptr = Main.GetMethodUFunction(PaperFlipbookComponent.StaticClass, "GetPlaybackPosition");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetPlaybackPosition_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetPlaybackPositionInFrames_method {
            static internal IntPtr GetPlaybackPositionInFrames_ptr;
            static GetPlaybackPositionInFrames_method() {
                GetPlaybackPositionInFrames_ptr = Main.GetMethodUFunction(PaperFlipbookComponent.StaticClass, "GetPlaybackPositionInFrames");
            }

            internal static unsafe int Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetPlaybackPositionInFrames_ptr, new IntPtr(p)); ;
                return *((int*)(b+0));
            }
        }
        internal struct GetPlayRate_method {
            static internal IntPtr GetPlayRate_ptr;
            static GetPlayRate_method() {
                GetPlayRate_ptr = Main.GetMethodUFunction(PaperFlipbookComponent.StaticClass, "GetPlayRate");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetPlayRate_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct IsLooping_method {
            static internal IntPtr IsLooping_ptr;
            static IsLooping_method() {
                IsLooping_ptr = Main.GetMethodUFunction(PaperFlipbookComponent.StaticClass, "IsLooping");
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
                IsPlaying_ptr = Main.GetMethodUFunction(PaperFlipbookComponent.StaticClass, "IsPlaying");
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
                IsReversing_ptr = Main.GetMethodUFunction(PaperFlipbookComponent.StaticClass, "IsReversing");
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
                Play_ptr = Main.GetMethodUFunction(PaperFlipbookComponent.StaticClass, "Play");
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
                PlayFromStart_ptr = Main.GetMethodUFunction(PaperFlipbookComponent.StaticClass, "PlayFromStart");
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
                Reverse_ptr = Main.GetMethodUFunction(PaperFlipbookComponent.StaticClass, "Reverse");
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
                ReverseFromEnd_ptr = Main.GetMethodUFunction(PaperFlipbookComponent.StaticClass, "ReverseFromEnd");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, ReverseFromEnd_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetFlipbook_method {
            static internal IntPtr SetFlipbook_ptr;
            static SetFlipbook_method() {
                SetFlipbook_ptr = Main.GetMethodUFunction(PaperFlipbookComponent.StaticClass, "SetFlipbook");
            }

            internal static unsafe bool Invoke(IntPtr obj, PaperFlipbook NewFlipbook) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = NewFlipbook;
                Main.GetProcessEvent(obj, SetFlipbook_ptr, new IntPtr(p)); ;
                return *((bool*)(b+8));
            }
        }
        internal struct SetLooping_method {
            static internal IntPtr SetLooping_ptr;
            static SetLooping_method() {
                SetLooping_ptr = Main.GetMethodUFunction(PaperFlipbookComponent.StaticClass, "SetLooping");
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
                SetNewTime_ptr = Main.GetMethodUFunction(PaperFlipbookComponent.StaticClass, "SetNewTime");
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
                SetPlaybackPosition_ptr = Main.GetMethodUFunction(PaperFlipbookComponent.StaticClass, "SetPlaybackPosition");
            }

            internal static unsafe void Invoke(IntPtr obj, float NewPosition, bool bFireEvents) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = NewPosition;
                *((bool*)(b+4)) = bFireEvents;
                Main.GetProcessEvent(obj, SetPlaybackPosition_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetPlaybackPositionInFrames_method {
            static internal IntPtr SetPlaybackPositionInFrames_ptr;
            static SetPlaybackPositionInFrames_method() {
                SetPlaybackPositionInFrames_ptr = Main.GetMethodUFunction(PaperFlipbookComponent.StaticClass, "SetPlaybackPositionInFrames");
            }

            internal static unsafe void Invoke(IntPtr obj, int NewFramePosition, bool bFireEvents) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = NewFramePosition;
                *((bool*)(b+4)) = bFireEvents;
                Main.GetProcessEvent(obj, SetPlaybackPositionInFrames_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetPlayRate_method {
            static internal IntPtr SetPlayRate_ptr;
            static SetPlayRate_method() {
                SetPlayRate_ptr = Main.GetMethodUFunction(PaperFlipbookComponent.StaticClass, "SetPlayRate");
            }

            internal static unsafe void Invoke(IntPtr obj, float NewRate) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = NewRate;
                Main.GetProcessEvent(obj, SetPlayRate_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetSpriteColor_method {
            static internal IntPtr SetSpriteColor_ptr;
            static SetSpriteColor_method() {
                SetSpriteColor_ptr = Main.GetMethodUFunction(PaperFlipbookComponent.StaticClass, "SetSpriteColor");
            }

            internal static unsafe void Invoke(IntPtr obj, LinearColor NewColor) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((LinearColor*)(b+0)) = NewColor;
                Main.GetProcessEvent(obj, SetSpriteColor_ptr, new IntPtr(p)); ;
            }
        }
        internal struct Stop_method {
            static internal IntPtr Stop_ptr;
            static Stop_method() {
                Stop_ptr = Main.GetMethodUFunction(PaperFlipbookComponent.StaticClass, "Stop");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, Stop_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct PaperFlipbookComponent_events {
    }
}
