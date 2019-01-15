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
    [StructLayout( LayoutKind.Explicit, Size=96 )]
    internal unsafe struct PaperFlipbook_fields {
        [FieldOffset(56)] public float FramesPerSecond;
        [FieldOffset(64)] public NativeArray KeyFrames;
        [FieldOffset(80)]  public IntPtr  DefaultMaterial;
        [FieldOffset(88)] public byte CollisionSource;
    }
    internal unsafe struct PaperFlipbook_methods {
        internal struct GetKeyFrameIndexAtTime_method {
            static internal IntPtr GetKeyFrameIndexAtTime_ptr;
            static GetKeyFrameIndexAtTime_method() {
                GetKeyFrameIndexAtTime_ptr = Main.GetMethodUFunction(PaperFlipbook.StaticClass, "GetKeyFrameIndexAtTime");
            }

            internal static unsafe int Invoke(IntPtr obj, float Time, bool bClampToEnds) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Time;
                *((bool*)(b+4)) = bClampToEnds;
                Main.GetProcessEvent(obj, GetKeyFrameIndexAtTime_ptr, new IntPtr(p)); ;
                return *((int*)(b+8));
            }
        }
        internal struct GetNumFrames_method {
            static internal IntPtr GetNumFrames_ptr;
            static GetNumFrames_method() {
                GetNumFrames_ptr = Main.GetMethodUFunction(PaperFlipbook.StaticClass, "GetNumFrames");
            }

            internal static unsafe int Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetNumFrames_ptr, new IntPtr(p)); ;
                return *((int*)(b+0));
            }
        }
        internal struct GetNumKeyFrames_method {
            static internal IntPtr GetNumKeyFrames_ptr;
            static GetNumKeyFrames_method() {
                GetNumKeyFrames_ptr = Main.GetMethodUFunction(PaperFlipbook.StaticClass, "GetNumKeyFrames");
            }

            internal static unsafe int Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetNumKeyFrames_ptr, new IntPtr(p)); ;
                return *((int*)(b+0));
            }
        }
        internal struct GetSpriteAtFrame_method {
            static internal IntPtr GetSpriteAtFrame_ptr;
            static GetSpriteAtFrame_method() {
                GetSpriteAtFrame_ptr = Main.GetMethodUFunction(PaperFlipbook.StaticClass, "GetSpriteAtFrame");
            }

            internal static unsafe PaperSprite Invoke(IntPtr obj, int FrameIndex) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = FrameIndex;
                Main.GetProcessEvent(obj, GetSpriteAtFrame_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+8));
            }
        }
        internal struct GetSpriteAtTime_method {
            static internal IntPtr GetSpriteAtTime_ptr;
            static GetSpriteAtTime_method() {
                GetSpriteAtTime_ptr = Main.GetMethodUFunction(PaperFlipbook.StaticClass, "GetSpriteAtTime");
            }

            internal static unsafe PaperSprite Invoke(IntPtr obj, float Time, bool bClampToEnds) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Time;
                *((bool*)(b+4)) = bClampToEnds;
                Main.GetProcessEvent(obj, GetSpriteAtTime_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+8));
            }
        }
        internal struct GetTotalDuration_method {
            static internal IntPtr GetTotalDuration_ptr;
            static GetTotalDuration_method() {
                GetTotalDuration_ptr = Main.GetMethodUFunction(PaperFlipbook.StaticClass, "GetTotalDuration");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetTotalDuration_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct IsValidKeyFrameIndex_method {
            static internal IntPtr IsValidKeyFrameIndex_ptr;
            static IsValidKeyFrameIndex_method() {
                IsValidKeyFrameIndex_ptr = Main.GetMethodUFunction(PaperFlipbook.StaticClass, "IsValidKeyFrameIndex");
            }

            internal static unsafe bool Invoke(IntPtr obj, int Index) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = Index;
                Main.GetProcessEvent(obj, IsValidKeyFrameIndex_ptr, new IntPtr(p)); ;
                return *((bool*)(b+4));
            }
        }
    }
    internal unsafe struct PaperFlipbook_events {
    }
}
