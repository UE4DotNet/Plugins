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

namespace UE4.AudioMixer.Native {
    [StructLayout( LayoutKind.Explicit, Size=1568 )]
    internal unsafe struct SynthComponent_fields {
        [FieldOffset(624)] public bool bAutoDestroy;
        [FieldOffset(624)] public bool bStopWhenOwnerDestroyed;
        [FieldOffset(624)] public bool bAllowSpatialization;
        [FieldOffset(624)] public bool bOverrideAttenuation;
        [FieldOffset(628)] public bool bOutputToBusOnly;
        [FieldOffset(632)]  public IntPtr  AttenuationSettings;
        [FieldOffset(640)] public SoundAttenuationSettings AttenuationOverrides;
        [FieldOffset(1360)]  public IntPtr  ConcurrencySettings;
        [FieldOffset(1368)]  public IntPtr  SoundClass;
        [FieldOffset(1376)]  public IntPtr  SourceEffectChain;
        [FieldOffset(1384)]  public IntPtr  SoundSubmix;
        [FieldOffset(1392)] public NativeArray SoundSubmixSends;
        [FieldOffset(1408)] public NativeArray BusSends;
        [FieldOffset(1424)] public NativeArray PreEffectBusSends;
        [FieldOffset(1440)] public bool bIsUISound;
        [FieldOffset(1440)] public bool bIsPreviewSound;
        [FieldOffset(1444)] public int EnvelopeFollowerAttackTime;
        [FieldOffset(1448)] public int EnvelopeFollowerReleaseTime;
        [FieldOffset(1456)] byte OnAudioEnvelopeValue; //TODO: multicast delegate FOnSynthEnvelopeValue OnAudioEnvelopeValue
        [FieldOffset(1504)]  public IntPtr  Synth;
        [FieldOffset(1512)]  public IntPtr  AudioComponent;
    }
    internal unsafe struct SynthComponent_methods {
        internal struct IsPlaying_method {
            static internal IntPtr IsPlaying_ptr;
            static IsPlaying_method() {
                IsPlaying_ptr = Main.GetMethodUFunction(SynthComponent.StaticClass, "IsPlaying");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsPlaying_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct SetSubmixSend_method {
            static internal IntPtr SetSubmixSend_ptr;
            static SetSubmixSend_method() {
                SetSubmixSend_ptr = Main.GetMethodUFunction(SynthComponent.StaticClass, "SetSubmixSend");
            }

            internal static unsafe void Invoke(IntPtr obj, SoundSubmix Submix, float SendLevel) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Submix;
                *((float*)(b+8)) = SendLevel;
                Main.GetProcessEvent(obj, SetSubmixSend_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetVolumeMultiplier_method {
            static internal IntPtr SetVolumeMultiplier_ptr;
            static SetVolumeMultiplier_method() {
                SetVolumeMultiplier_ptr = Main.GetMethodUFunction(SynthComponent.StaticClass, "SetVolumeMultiplier");
            }

            internal static unsafe void Invoke(IntPtr obj, float VolumeMultiplier) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = VolumeMultiplier;
                Main.GetProcessEvent(obj, SetVolumeMultiplier_ptr, new IntPtr(p)); ;
            }
        }
        internal struct Start_method {
            static internal IntPtr Start_ptr;
            static Start_method() {
                Start_ptr = Main.GetMethodUFunction(SynthComponent.StaticClass, "Start");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, Start_ptr, new IntPtr(p)); ;
            }
        }
        internal struct Stop_method {
            static internal IntPtr Stop_ptr;
            static Stop_method() {
                Stop_ptr = Main.GetMethodUFunction(SynthComponent.StaticClass, "Stop");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, Stop_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct SynthComponent_events {
    }
}
