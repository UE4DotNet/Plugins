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


namespace UE4.MediaAssets.Native {
    [StructLayout( LayoutKind.Explicit, Size=672 )]
    internal unsafe struct MediaTexture_fields {
        [FieldOffset(520)] public byte AddressX;
        [FieldOffset(521)] public byte AddressY;
        [FieldOffset(522)] public bool AutoClear;
        [FieldOffset(524)] public LinearColor ClearColor;
        [FieldOffset(544)]  public IntPtr  MediaPlayer;
    }
    internal unsafe struct MediaTexture_methods {
        internal struct GetAspectRatio_method {
            static internal IntPtr GetAspectRatio_ptr;
            static GetAspectRatio_method() {
                GetAspectRatio_ptr = Main.GetMethodUFunction(MediaTexture.StaticClass, "GetAspectRatio");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetAspectRatio_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetHeight_method {
            static internal IntPtr GetHeight_ptr;
            static GetHeight_method() {
                GetHeight_ptr = Main.GetMethodUFunction(MediaTexture.StaticClass, "GetHeight");
            }

            internal static unsafe int Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetHeight_ptr, new IntPtr(p)); ;
                return *((int*)(b+0));
            }
        }
        internal struct GetMediaPlayer_method {
            static internal IntPtr GetMediaPlayer_ptr;
            static GetMediaPlayer_method() {
                GetMediaPlayer_ptr = Main.GetMethodUFunction(MediaTexture.StaticClass, "GetMediaPlayer");
            }

            internal static unsafe MediaPlayer Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetMediaPlayer_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
        internal struct GetWidth_method {
            static internal IntPtr GetWidth_ptr;
            static GetWidth_method() {
                GetWidth_ptr = Main.GetMethodUFunction(MediaTexture.StaticClass, "GetWidth");
            }

            internal static unsafe int Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetWidth_ptr, new IntPtr(p)); ;
                return *((int*)(b+0));
            }
        }
        internal struct SetMediaPlayer_method {
            static internal IntPtr SetMediaPlayer_ptr;
            static SetMediaPlayer_method() {
                SetMediaPlayer_ptr = Main.GetMethodUFunction(MediaTexture.StaticClass, "SetMediaPlayer");
            }

            internal static unsafe void Invoke(IntPtr obj, MediaPlayer NewMediaPlayer) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = NewMediaPlayer;
                Main.GetProcessEvent(obj, SetMediaPlayer_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct MediaTexture_events {
    }
}
