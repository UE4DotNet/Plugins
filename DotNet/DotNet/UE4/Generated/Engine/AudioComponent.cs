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

#pragma warning disable CS0108
using UE4.Engine.Native;

namespace UE4.Engine {
    ///<summary>
    ///AudioComponent is used to play a Sound
    ///@
    ///</summary>
    ///<remarks>
    ///see https://docs.unrealengine.com/latest/INT/Audio/Overview/index.html
    ///@see USoundBase
    ///</remarks>
    public unsafe partial class AudioComponent : SceneComponent  {

        ///<summary>Modify the attenuation settings of the audio component</summary>
        public void AdjustAttenuation(SoundAttenuationSettings InAttenuationSettings)  => 
            AudioComponent_methods.AdjustAttenuation_method.Invoke(ObjPointer, InAttenuationSettings);

        ///<summary>This will allow one to adjust the volume of an AudioComponent on the fly</summary>
        public void AdjustVolume(float AdjustVolumeDuration, float AdjustVolumeLevel)  => 
            AudioComponent_methods.AdjustVolume_method.Invoke(ObjPointer, AdjustVolumeDuration, AdjustVolumeLevel);

        ///<summary>BP Get Attenuation Settings to Apply</summary>
        public (SoundAttenuationSettings, bool) BP_GetAttenuationSettingsToApply()  => 
            AudioComponent_methods.BP_GetAttenuationSettingsToApply_method.Invoke(ObjPointer);

        ///<summary>This can be used in place of "play" when it is desired to fade in the sound over time.</summary>
        ///<remarks>
        ///If FadeTime is 0.0, the change in volume is instant.
        ///If FadeTime is > 0.0, the multiplier will be increased from 0 to FadeVolumeLevel over FadeIn seconds.
        ///
        ///@param FadeInDuration how long it should take to reach the FadeVolumeLevel
        ///@param FadeVolumeLevel the percentage of the AudioComponents's calculated volume to fade to
        ///</remarks>
        public void FadeIn(float FadeInDuration, float FadeVolumeLevel, float StartTime)  => 
            AudioComponent_methods.FadeIn_method.Invoke(ObjPointer, FadeInDuration, FadeVolumeLevel, StartTime);

        ///<summary>This is used in place of "stop" when it is desired to fade the volume of the sound before stopping.</summary>
        ///<remarks>
        ///If FadeTime is 0.0, this is the same as calling Stop().
        ///If FadeTime is > 0.0, this will adjust the volume multiplier to FadeVolumeLevel over FadeInTime seconds
        ///and then stop the sound.
        ///
        ///@param FadeOutDuration how long it should take to reach the FadeVolumeLevel
        ///@param FadeVolumeLevel the percentage of the AudioComponents's calculated volume in which to fade to
        ///</remarks>
        public void FadeOut(float FadeOutDuration, float FadeVolumeLevel)  => 
            AudioComponent_methods.FadeOut_method.Invoke(ObjPointer, FadeOutDuration, FadeVolumeLevel);

        ///<summary>@return true if this component is currently playing a SoundCue.</summary>
        public bool IsPlaying()  => 
            AudioComponent_methods.IsPlaying_method.Invoke(ObjPointer);

        ///<summary>Start a sound playing on an audio component</summary>
        public void Play(float StartTime)  => 
            AudioComponent_methods.Play_method.Invoke(ObjPointer, StartTime);

        ///<summary>Set a boolean instance parameter for use in sound cues played by this audio component</summary>
        public void SetBoolParameter(Name InName, bool InBool)  => 
            AudioComponent_methods.SetBoolParameter_method.Invoke(ObjPointer, InName, InBool);

        ///<summary>Set a float instance parameter for use in sound cues played by this audio component</summary>
        public void SetFloatParameter(Name InName, float InFloat)  => 
            AudioComponent_methods.SetFloatParameter_method.Invoke(ObjPointer, InName, InFloat);

        ///<summary>Set an integer instance parameter for use in sound cues played by this audio component</summary>
        public void SetIntParameter(Name InName, int InInt)  => 
            AudioComponent_methods.SetIntParameter_method.Invoke(ObjPointer, InName, InInt);

        ///<summary>Sets whether or not the low pass filter is enabled on the audio component.</summary>
        public void SetLowPassFilterEnabled(bool InLowPassFilterEnabled)  => 
            AudioComponent_methods.SetLowPassFilterEnabled_method.Invoke(ObjPointer, InLowPassFilterEnabled);

        ///<summary>Sets lowpass filter frequency of the audio component.</summary>
        public void SetLowPassFilterFrequency(float InLowPassFilterFrequency)  => 
            AudioComponent_methods.SetLowPassFilterFrequency_method.Invoke(ObjPointer, InLowPassFilterFrequency);

        ///<summary>Pause an audio component playing its sound cue, issue any delegates if needed</summary>
        public void SetPaused(bool bPause)  => 
            AudioComponent_methods.SetPaused_method.Invoke(ObjPointer, bPause);

        ///<summary>Set a new pitch multiplier</summary>
        public void SetPitchMultiplier(float NewPitchMultiplier)  => 
            AudioComponent_methods.SetPitchMultiplier_method.Invoke(ObjPointer, NewPitchMultiplier);

        ///<summary>Set what sound is played by this component</summary>
        public void SetSound(SoundBase NewSound)  => 
            AudioComponent_methods.SetSound_method.Invoke(ObjPointer, NewSound);

        ///<summary>Sets how much audio the sound should send to the given submix.</summary>
        public void SetSubmixSend(SoundSubmix Submix, float SendLevel)  => 
            AudioComponent_methods.SetSubmixSend_method.Invoke(ObjPointer, Submix, SendLevel);

        ///<summary>Set whether sounds generated by this audio component should be considered UI sounds</summary>
        public void SetUISound(bool bInUISound)  => 
            AudioComponent_methods.SetUISound_method.Invoke(ObjPointer, bInUISound);

        ///<summary>Set a new volume multiplier</summary>
        public void SetVolumeMultiplier(float NewVolumeMultiplier)  => 
            AudioComponent_methods.SetVolumeMultiplier_method.Invoke(ObjPointer, NewVolumeMultiplier);

        ///<summary>Set a sound wave instance parameter for use in sound cues played by this audio component</summary>
        public void SetWaveParameter(Name InName, SoundWave InWave)  => 
            AudioComponent_methods.SetWaveParameter_method.Invoke(ObjPointer, InName, InWave);

        ///<summary>Stop an audio component playing its sound cue, issue any delegates if needed</summary>
        public void Stop()  => 
            AudioComponent_methods.Stop_method.Invoke(ObjPointer);
        ///<summary>The sound to be played</summary>
        public unsafe SoundBase Sound {
            get {return AudioComponent_ptr->Sound;}
            set {AudioComponent_ptr->Sound = value;}
        }
         //TODO: array not UObject TArray InstanceParameters
        ///<summary>Optional sound group this AudioComponent belongs to</summary>
        public unsafe SoundClass SoundClassOverride {
            get {return AudioComponent_ptr->SoundClassOverride;}
            set {AudioComponent_ptr->SoundClassOverride = value;}
        }
        public bool bAutoDestroy {
            get {return Main.GetGetBoolPropertyByName(this, "bAutoDestroy"); }
            set {Main.SetGetBoolPropertyByName(this, "bAutoDestroy", value); }
        }
        public bool bStopWhenOwnerDestroyed {
            get {return Main.GetGetBoolPropertyByName(this, "bStopWhenOwnerDestroyed"); }
            set {Main.SetGetBoolPropertyByName(this, "bStopWhenOwnerDestroyed", value); }
        }
        public bool bShouldRemainActiveIfDropped {
            get {return Main.GetGetBoolPropertyByName(this, "bShouldRemainActiveIfDropped"); }
            set {Main.SetGetBoolPropertyByName(this, "bShouldRemainActiveIfDropped", value); }
        }
        public bool bAllowSpatialization {
            get {return Main.GetGetBoolPropertyByName(this, "bAllowSpatialization"); }
            set {Main.SetGetBoolPropertyByName(this, "bAllowSpatialization", value); }
        }
        public bool bOverrideAttenuation {
            get {return Main.GetGetBoolPropertyByName(this, "bOverrideAttenuation"); }
            set {Main.SetGetBoolPropertyByName(this, "bOverrideAttenuation", value); }
        }
        public bool bOverrideSubtitlePriority {
            get {return Main.GetGetBoolPropertyByName(this, "bOverrideSubtitlePriority"); }
            set {Main.SetGetBoolPropertyByName(this, "bOverrideSubtitlePriority", value); }
        }
        public bool bIsUISound {
            get {return Main.GetGetBoolPropertyByName(this, "bIsUISound"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsUISound", value); }
        }
        public bool bEnableLowPassFilter {
            get {return Main.GetGetBoolPropertyByName(this, "bEnableLowPassFilter"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnableLowPassFilter", value); }
        }
        public bool bOverridePriority {
            get {return Main.GetGetBoolPropertyByName(this, "bOverridePriority"); }
            set {Main.SetGetBoolPropertyByName(this, "bOverridePriority", value); }
        }
        public bool bSuppressSubtitles {
            get {return Main.GetGetBoolPropertyByName(this, "bSuppressSubtitles"); }
            set {Main.SetGetBoolPropertyByName(this, "bSuppressSubtitles", value); }
        }
        public bool bAutoManageAttachment {
            get {return Main.GetGetBoolPropertyByName(this, "bAutoManageAttachment"); }
        }
        ///<summary>Configurable, serialized ID for audio plugins</summary>
        public unsafe Name AudioComponentUserID {
            get {return AudioComponent_ptr->AudioComponentUserID;}
            set {AudioComponent_ptr->AudioComponentUserID = value;}
        }
        ///<summary>The lower bound to use when randomly determining a pitch multiplier</summary>
        public unsafe float PitchModulationMin {
            get {return AudioComponent_ptr->PitchModulationMin;}
            set {AudioComponent_ptr->PitchModulationMin = value;}
        }
        ///<summary>The upper bound to use when randomly determining a pitch multiplier</summary>
        public unsafe float PitchModulationMax {
            get {return AudioComponent_ptr->PitchModulationMax;}
            set {AudioComponent_ptr->PitchModulationMax = value;}
        }
        ///<summary>The lower bound to use when randomly determining a volume multiplier</summary>
        public unsafe float VolumeModulationMin {
            get {return AudioComponent_ptr->VolumeModulationMin;}
            set {AudioComponent_ptr->VolumeModulationMin = value;}
        }
        ///<summary>The upper bound to use when randomly determining a volume multiplier</summary>
        public unsafe float VolumeModulationMax {
            get {return AudioComponent_ptr->VolumeModulationMax;}
            set {AudioComponent_ptr->VolumeModulationMax = value;}
        }
        ///<summary>A volume multiplier to apply to sounds generated by this component</summary>
        public unsafe float VolumeMultiplier {
            get {return AudioComponent_ptr->VolumeMultiplier;}
            set {AudioComponent_ptr->VolumeMultiplier = value;}
        }
        ///<summary>The attack time in milliseconds for the envelope follower. Delegate callbacks can be registered to get the envelope value of sounds played with this audio component. Only used in audio mixer.</summary>
        public unsafe int EnvelopeFollowerAttackTime {
            get {return AudioComponent_ptr->EnvelopeFollowerAttackTime;}
            set {AudioComponent_ptr->EnvelopeFollowerAttackTime = value;}
        }
        ///<summary>The release time in milliseconds for the envelope follower. Delegate callbacks can be registered to get the envelope value of sounds played with this audio component. Only used in audio mixer.</summary>
        public unsafe int EnvelopeFollowerReleaseTime {
            get {return AudioComponent_ptr->EnvelopeFollowerReleaseTime;}
            set {AudioComponent_ptr->EnvelopeFollowerReleaseTime = value;}
        }
        ///<summary>A priority value that is used for sounds that play on this component that scales against final output volume.</summary>
        public unsafe float Priority {
            get {return AudioComponent_ptr->Priority;}
            set {AudioComponent_ptr->Priority = value;}
        }
        ///<summary>Used by the subtitle manager to prioritize subtitles wave instances spawned by this component.</summary>
        public unsafe float SubtitlePriority {
            get {return AudioComponent_ptr->SubtitlePriority;}
            set {AudioComponent_ptr->SubtitlePriority = value;}
        }
        ///<summary>A pitch multiplier to apply to sounds generated by this component</summary>
        public unsafe float PitchMultiplier {
            get {return AudioComponent_ptr->PitchMultiplier;}
            set {AudioComponent_ptr->PitchMultiplier = value;}
        }
        ///<summary>The frequency of the lowpass filter (in hertz) to apply to this voice. A frequency of 0.0 is the device sample rate and will bypass the filter.</summary>
        public unsafe float LowPassFilterFrequency {
            get {return AudioComponent_ptr->LowPassFilterFrequency;}
            set {AudioComponent_ptr->LowPassFilterFrequency = value;}
        }
        ///<summary>If bOverrideSettings is false, the asset to use to determine attenuation properties for sounds generated by this component</summary>
        public unsafe SoundAttenuation AttenuationSettings {
            get {return AudioComponent_ptr->AttenuationSettings;}
            set {AudioComponent_ptr->AttenuationSettings = value;}
        }
        ///<summary>If bOverrideSettings is true, the attenuation properties to use for sounds generated by this component</summary>
        public unsafe SoundAttenuationSettings AttenuationOverrides {
            get {return AudioComponent_ptr->AttenuationOverrides;}
            set {AudioComponent_ptr->AttenuationOverrides = value;}
        }
        ///<summary>What sound concurrency to use for sounds generated by this audio component</summary>
        public unsafe SoundConcurrency ConcurrencySettings {
            get {return AudioComponent_ptr->ConcurrencySettings;}
            set {AudioComponent_ptr->ConcurrencySettings = value;}
        }
         //TODO: enum EAttachmentRule AutoAttachLocationRule
         //TODO: enum EAttachmentRule AutoAttachRotationRule
         //TODO: enum EAttachmentRule AutoAttachScaleRule
         //TODO: multicast delegate FOnAudioFinished OnAudioFinished
         //TODO: multicast delegate FOnAudioPlaybackPercent OnAudioPlaybackPercent
         //TODO: multicast delegate FOnAudioSingleEnvelopeValue OnAudioSingleEnvelopeValue
         //TODO: multicast delegate FOnAudioMultiEnvelopeValue OnAudioMultiEnvelopeValue
         //TODO: delegate FOnQueueSubtitles OnQueueSubtitles
         //TODO: weak object TWeakObjectPtr<USceneComponent> AutoAttachParent
        ///<summary>Socket we automatically attach to on the AutoAttachParent, if bAutoManageAttachment is true.</summary>
        ///<remarks>
        ///@see bAutoManageAttachment
        ///</remarks>
        public unsafe Name AutoAttachSocketName {
            get {return AudioComponent_ptr->AutoAttachSocketName;}
            set {AudioComponent_ptr->AutoAttachSocketName = value;}
        }
        static AudioComponent() {
            StaticClass = Main.GetClass("AudioComponent");
        }
        internal unsafe AudioComponent_fields* AudioComponent_ptr => (AudioComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AudioComponent(IntPtr p) => UObject.Make<AudioComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AudioComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AudioComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
