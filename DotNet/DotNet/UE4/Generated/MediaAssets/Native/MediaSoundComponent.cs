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

using UE4.Engine;

namespace UE4.MediaAssets.Native {
    [StructLayout( LayoutKind.Explicit, Size=1728 )]
    internal unsafe struct MediaSoundComponent_fields {
        [FieldOffset(1568)] byte Channels; //TODO: enum EMediaSoundChannels Channels
        [FieldOffset(1572)] public bool DynamicRateAdjustment;
        [FieldOffset(1576)] public float RateAdjustmentFactor;
        [FieldOffset(1580)] public FloatRange RateAdjustmentRange;
        [FieldOffset(1600)]  public IntPtr  MediaPlayer;
    }
    internal unsafe struct MediaSoundComponent_methods {
        internal struct BP_GetAttenuationSettingsToApply_method {
            static internal IntPtr BP_GetAttenuationSettingsToApply_ptr;
            static BP_GetAttenuationSettingsToApply_method() {
                BP_GetAttenuationSettingsToApply_ptr = Main.GetMethodUFunction(MediaSoundComponent.StaticClass, "BP_GetAttenuationSettingsToApply");
            }

            internal static unsafe (SoundAttenuationSettings, bool) Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, BP_GetAttenuationSettingsToApply_ptr, new IntPtr(p)); ;
                return (*((SoundAttenuationSettings*)(b+0)),*((bool*)(b+720)));
            }
        }
        internal struct GetMediaPlayer_method {
            static internal IntPtr GetMediaPlayer_ptr;
            static GetMediaPlayer_method() {
                GetMediaPlayer_ptr = Main.GetMethodUFunction(MediaSoundComponent.StaticClass, "GetMediaPlayer");
            }

            internal static unsafe MediaPlayer Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetMediaPlayer_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
        internal struct SetMediaPlayer_method {
            static internal IntPtr SetMediaPlayer_ptr;
            static SetMediaPlayer_method() {
                SetMediaPlayer_ptr = Main.GetMethodUFunction(MediaSoundComponent.StaticClass, "SetMediaPlayer");
            }

            internal static unsafe void Invoke(IntPtr obj, MediaPlayer NewMediaPlayer) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = NewMediaPlayer;
                Main.GetProcessEvent(obj, SetMediaPlayer_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct MediaSoundComponent_events {
    }
}
