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
    [StructLayout( LayoutKind.Explicit, Size=1728 )]
    internal unsafe struct AudioComponent_fields {
        [FieldOffset(624)]  public IntPtr  Sound;
        [FieldOffset(632)] public NativeArray InstanceParameters;
        [FieldOffset(648)]  public IntPtr  SoundClassOverride;
        [FieldOffset(656)] public bool bAutoDestroy;
        [FieldOffset(656)] public bool bStopWhenOwnerDestroyed;
        [FieldOffset(656)] public bool bShouldRemainActiveIfDropped;
        [FieldOffset(656)] public bool bAllowSpatialization;
        [FieldOffset(656)] public bool bOverrideAttenuation;
        [FieldOffset(656)] public bool bOverrideSubtitlePriority;
        [FieldOffset(656)] public bool bIsUISound;
        [FieldOffset(656)] public bool bEnableLowPassFilter;
        [FieldOffset(657)] public bool bOverridePriority;
        [FieldOffset(657)] public bool bSuppressSubtitles;
        [FieldOffset(658)] public bool bAutoManageAttachment;
        [FieldOffset(664)] public Name AudioComponentUserID;
        [FieldOffset(676)] public float PitchModulationMin;
        [FieldOffset(680)] public float PitchModulationMax;
        [FieldOffset(684)] public float VolumeModulationMin;
        [FieldOffset(688)] public float VolumeModulationMax;
        [FieldOffset(692)] public float VolumeMultiplier;
        [FieldOffset(696)] public int EnvelopeFollowerAttackTime;
        [FieldOffset(700)] public int EnvelopeFollowerReleaseTime;
        [FieldOffset(704)] public float Priority;
        [FieldOffset(708)] public float SubtitlePriority;
        [FieldOffset(720)] public float PitchMultiplier;
        [FieldOffset(724)] public float LowPassFilterFrequency;
        [FieldOffset(736)]  public IntPtr  AttenuationSettings;
        [FieldOffset(744)] public SoundAttenuationSettings AttenuationOverrides;
        [FieldOffset(1464)]  public IntPtr  ConcurrencySettings;
        [FieldOffset(1476)] byte AutoAttachLocationRule; //TODO: enum EAttachmentRule AutoAttachLocationRule
        [FieldOffset(1477)] byte AutoAttachRotationRule; //TODO: enum EAttachmentRule AutoAttachRotationRule
        [FieldOffset(1478)] byte AutoAttachScaleRule; //TODO: enum EAttachmentRule AutoAttachScaleRule
        [FieldOffset(1480)] byte OnAudioFinished; //TODO: multicast delegate FOnAudioFinished OnAudioFinished
        [FieldOffset(1520)] byte OnAudioPlaybackPercent; //TODO: multicast delegate FOnAudioPlaybackPercent OnAudioPlaybackPercent
        [FieldOffset(1560)] byte OnAudioSingleEnvelopeValue; //TODO: multicast delegate FOnAudioSingleEnvelopeValue OnAudioSingleEnvelopeValue
        [FieldOffset(1600)] byte OnAudioMultiEnvelopeValue; //TODO: multicast delegate FOnAudioMultiEnvelopeValue OnAudioMultiEnvelopeValue
        [FieldOffset(1640)] byte OnQueueSubtitles; //TODO: delegate FOnQueueSubtitles OnQueueSubtitles
        [FieldOffset(1660)] byte AutoAttachParent; //TODO: weak object TWeakObjectPtr<USceneComponent> AutoAttachParent
        [FieldOffset(1668)] public Name AutoAttachSocketName;
    }
    internal unsafe struct AudioComponent_methods {
        internal struct AdjustAttenuation_method {
            static internal IntPtr AdjustAttenuation_ptr;
            static AdjustAttenuation_method() {
                AdjustAttenuation_ptr = Main.GetMethodUFunction(AudioComponent.StaticClass, "AdjustAttenuation");
            }

            internal static unsafe void Invoke(IntPtr obj, SoundAttenuationSettings InAttenuationSettings) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((SoundAttenuationSettings*)(b+0)) = InAttenuationSettings;
                Main.GetProcessEvent(obj, AdjustAttenuation_ptr, new IntPtr(p)); ;
            }
        }
        internal struct AdjustVolume_method {
            static internal IntPtr AdjustVolume_ptr;
            static AdjustVolume_method() {
                AdjustVolume_ptr = Main.GetMethodUFunction(AudioComponent.StaticClass, "AdjustVolume");
            }

            internal static unsafe void Invoke(IntPtr obj, float AdjustVolumeDuration, float AdjustVolumeLevel) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = AdjustVolumeDuration;
                *((float*)(b+4)) = AdjustVolumeLevel;
                Main.GetProcessEvent(obj, AdjustVolume_ptr, new IntPtr(p)); ;
            }
        }
        internal struct BP_GetAttenuationSettingsToApply_method {
            static internal IntPtr BP_GetAttenuationSettingsToApply_ptr;
            static BP_GetAttenuationSettingsToApply_method() {
                BP_GetAttenuationSettingsToApply_ptr = Main.GetMethodUFunction(AudioComponent.StaticClass, "BP_GetAttenuationSettingsToApply");
            }

            internal static unsafe (SoundAttenuationSettings, bool) Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, BP_GetAttenuationSettingsToApply_ptr, new IntPtr(p)); ;
                return (*((SoundAttenuationSettings*)(b+0)),*((bool*)(b+720)));
            }
        }
        internal struct FadeIn_method {
            static internal IntPtr FadeIn_ptr;
            static FadeIn_method() {
                FadeIn_ptr = Main.GetMethodUFunction(AudioComponent.StaticClass, "FadeIn");
            }

            internal static unsafe void Invoke(IntPtr obj, float FadeInDuration, float FadeVolumeLevel, float StartTime) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = FadeInDuration;
                *((float*)(b+4)) = FadeVolumeLevel;
                *((float*)(b+8)) = StartTime;
                Main.GetProcessEvent(obj, FadeIn_ptr, new IntPtr(p)); ;
            }
        }
        internal struct FadeOut_method {
            static internal IntPtr FadeOut_ptr;
            static FadeOut_method() {
                FadeOut_ptr = Main.GetMethodUFunction(AudioComponent.StaticClass, "FadeOut");
            }

            internal static unsafe void Invoke(IntPtr obj, float FadeOutDuration, float FadeVolumeLevel) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = FadeOutDuration;
                *((float*)(b+4)) = FadeVolumeLevel;
                Main.GetProcessEvent(obj, FadeOut_ptr, new IntPtr(p)); ;
            }
        }
        internal struct IsPlaying_method {
            static internal IntPtr IsPlaying_ptr;
            static IsPlaying_method() {
                IsPlaying_ptr = Main.GetMethodUFunction(AudioComponent.StaticClass, "IsPlaying");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsPlaying_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct Play_method {
            static internal IntPtr Play_ptr;
            static Play_method() {
                Play_ptr = Main.GetMethodUFunction(AudioComponent.StaticClass, "Play");
            }

            internal static unsafe void Invoke(IntPtr obj, float StartTime) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = StartTime;
                Main.GetProcessEvent(obj, Play_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetBoolParameter_method {
            static internal IntPtr SetBoolParameter_ptr;
            static SetBoolParameter_method() {
                SetBoolParameter_ptr = Main.GetMethodUFunction(AudioComponent.StaticClass, "SetBoolParameter");
            }

            internal static unsafe void Invoke(IntPtr obj, Name InName, bool InBool) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = InName;
                *((bool*)(b+12)) = InBool;
                Main.GetProcessEvent(obj, SetBoolParameter_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetFloatParameter_method {
            static internal IntPtr SetFloatParameter_ptr;
            static SetFloatParameter_method() {
                SetFloatParameter_ptr = Main.GetMethodUFunction(AudioComponent.StaticClass, "SetFloatParameter");
            }

            internal static unsafe void Invoke(IntPtr obj, Name InName, float InFloat) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = InName;
                *((float*)(b+12)) = InFloat;
                Main.GetProcessEvent(obj, SetFloatParameter_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetIntParameter_method {
            static internal IntPtr SetIntParameter_ptr;
            static SetIntParameter_method() {
                SetIntParameter_ptr = Main.GetMethodUFunction(AudioComponent.StaticClass, "SetIntParameter");
            }

            internal static unsafe void Invoke(IntPtr obj, Name InName, int InInt) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = InName;
                *((int*)(b+12)) = InInt;
                Main.GetProcessEvent(obj, SetIntParameter_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetLowPassFilterEnabled_method {
            static internal IntPtr SetLowPassFilterEnabled_ptr;
            static SetLowPassFilterEnabled_method() {
                SetLowPassFilterEnabled_ptr = Main.GetMethodUFunction(AudioComponent.StaticClass, "SetLowPassFilterEnabled");
            }

            internal static unsafe void Invoke(IntPtr obj, bool InLowPassFilterEnabled) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = InLowPassFilterEnabled;
                Main.GetProcessEvent(obj, SetLowPassFilterEnabled_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetLowPassFilterFrequency_method {
            static internal IntPtr SetLowPassFilterFrequency_ptr;
            static SetLowPassFilterFrequency_method() {
                SetLowPassFilterFrequency_ptr = Main.GetMethodUFunction(AudioComponent.StaticClass, "SetLowPassFilterFrequency");
            }

            internal static unsafe void Invoke(IntPtr obj, float InLowPassFilterFrequency) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = InLowPassFilterFrequency;
                Main.GetProcessEvent(obj, SetLowPassFilterFrequency_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetPaused_method {
            static internal IntPtr SetPaused_ptr;
            static SetPaused_method() {
                SetPaused_ptr = Main.GetMethodUFunction(AudioComponent.StaticClass, "SetPaused");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bPause) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bPause;
                Main.GetProcessEvent(obj, SetPaused_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetPitchMultiplier_method {
            static internal IntPtr SetPitchMultiplier_ptr;
            static SetPitchMultiplier_method() {
                SetPitchMultiplier_ptr = Main.GetMethodUFunction(AudioComponent.StaticClass, "SetPitchMultiplier");
            }

            internal static unsafe void Invoke(IntPtr obj, float NewPitchMultiplier) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = NewPitchMultiplier;
                Main.GetProcessEvent(obj, SetPitchMultiplier_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetSound_method {
            static internal IntPtr SetSound_ptr;
            static SetSound_method() {
                SetSound_ptr = Main.GetMethodUFunction(AudioComponent.StaticClass, "SetSound");
            }

            internal static unsafe void Invoke(IntPtr obj, SoundBase NewSound) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = NewSound;
                Main.GetProcessEvent(obj, SetSound_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetSubmixSend_method {
            static internal IntPtr SetSubmixSend_ptr;
            static SetSubmixSend_method() {
                SetSubmixSend_ptr = Main.GetMethodUFunction(AudioComponent.StaticClass, "SetSubmixSend");
            }

            internal static unsafe void Invoke(IntPtr obj, SoundSubmix Submix, float SendLevel) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Submix;
                *((float*)(b+8)) = SendLevel;
                Main.GetProcessEvent(obj, SetSubmixSend_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetUISound_method {
            static internal IntPtr SetUISound_ptr;
            static SetUISound_method() {
                SetUISound_ptr = Main.GetMethodUFunction(AudioComponent.StaticClass, "SetUISound");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bInUISound) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bInUISound;
                Main.GetProcessEvent(obj, SetUISound_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetVolumeMultiplier_method {
            static internal IntPtr SetVolumeMultiplier_ptr;
            static SetVolumeMultiplier_method() {
                SetVolumeMultiplier_ptr = Main.GetMethodUFunction(AudioComponent.StaticClass, "SetVolumeMultiplier");
            }

            internal static unsafe void Invoke(IntPtr obj, float NewVolumeMultiplier) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = NewVolumeMultiplier;
                Main.GetProcessEvent(obj, SetVolumeMultiplier_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetWaveParameter_method {
            static internal IntPtr SetWaveParameter_ptr;
            static SetWaveParameter_method() {
                SetWaveParameter_ptr = Main.GetMethodUFunction(AudioComponent.StaticClass, "SetWaveParameter");
            }

            internal static unsafe void Invoke(IntPtr obj, Name InName, SoundWave InWave) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = InName;
                *((IntPtr*)(b+16)) = InWave;
                Main.GetProcessEvent(obj, SetWaveParameter_ptr, new IntPtr(p)); ;
            }
        }
        internal struct Stop_method {
            static internal IntPtr Stop_ptr;
            static Stop_method() {
                Stop_ptr = Main.GetMethodUFunction(AudioComponent.StaticClass, "Stop");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, Stop_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct AudioComponent_events {
    }
}
