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
using UE4.AudioMixer.Native;
using UE4.Engine;

namespace UE4.AudioMixer {
    ///<summary>Synth Component</summary>
    public unsafe partial class SynthComponent : SceneComponent  {

        ///<summary>Returns true if this component is currently playing.</summary>
        public bool IsPlaying()  => 
            SynthComponent_methods.IsPlaying_method.Invoke(ObjPointer);

        ///<summary>Sets how much audio the sound should send to the given submix.</summary>
        public void SetSubmixSend(SoundSubmix Submix, float SendLevel)  => 
            SynthComponent_methods.SetSubmixSend_method.Invoke(ObjPointer, Submix, SendLevel);

        ///<summary>Sets how much audio the sound should send to the given submix.</summary>
        public void SetVolumeMultiplier(float VolumeMultiplier)  => 
            SynthComponent_methods.SetVolumeMultiplier_method.Invoke(ObjPointer, VolumeMultiplier);

        ///<summary>Starts the synth generating audio.</summary>
        public void Start()  => 
            SynthComponent_methods.Start_method.Invoke(ObjPointer);

        ///<summary>Stops the synth generating audio.</summary>
        public void Stop()  => 
            SynthComponent_methods.Stop_method.Invoke(ObjPointer);
        public bool bAutoDestroy {
            get {return Main.GetGetBoolPropertyByName(this, "bAutoDestroy"); }
            set {Main.SetGetBoolPropertyByName(this, "bAutoDestroy", value); }
        }
        public bool bStopWhenOwnerDestroyed {
            get {return Main.GetGetBoolPropertyByName(this, "bStopWhenOwnerDestroyed"); }
            set {Main.SetGetBoolPropertyByName(this, "bStopWhenOwnerDestroyed", value); }
        }
        public bool bAllowSpatialization {
            get {return Main.GetGetBoolPropertyByName(this, "bAllowSpatialization"); }
            set {Main.SetGetBoolPropertyByName(this, "bAllowSpatialization", value); }
        }
        public bool bOverrideAttenuation {
            get {return Main.GetGetBoolPropertyByName(this, "bOverrideAttenuation"); }
            set {Main.SetGetBoolPropertyByName(this, "bOverrideAttenuation", value); }
        }
        public bool bOutputToBusOnly {
            get {return Main.GetGetBoolPropertyByName(this, "bOutputToBusOnly"); }
            set {Main.SetGetBoolPropertyByName(this, "bOutputToBusOnly", value); }
        }
        ///<summary>If bOverrideSettings is false, the asset to use to determine attenuation properties for sounds generated by this component</summary>
        public unsafe SoundAttenuation AttenuationSettings {
            get {return SynthComponent_ptr->AttenuationSettings;}
            set {SynthComponent_ptr->AttenuationSettings = value;}
        }
        ///<summary>If bOverrideSettings is true, the attenuation properties to use for sounds generated by this component</summary>
        public unsafe SoundAttenuationSettings AttenuationOverrides {
            get {return SynthComponent_ptr->AttenuationOverrides;}
            set {SynthComponent_ptr->AttenuationOverrides = value;}
        }
        ///<summary>What sound concurrency to use for sounds generated by this audio component</summary>
        public unsafe SoundConcurrency ConcurrencySettings {
            get {return SynthComponent_ptr->ConcurrencySettings;}
            set {SynthComponent_ptr->ConcurrencySettings = value;}
        }
        ///<summary>Sound class this sound belongs to</summary>
        public unsafe SoundClass SoundClass {
            get {return SynthComponent_ptr->SoundClass;}
            set {SynthComponent_ptr->SoundClass = value;}
        }
        ///<summary>The source effect chain to use for this sound.</summary>
        public unsafe SoundEffectSourcePresetChain SourceEffectChain {
            get {return SynthComponent_ptr->SourceEffectChain;}
            set {SynthComponent_ptr->SourceEffectChain = value;}
        }
        ///<summary>Submix this sound belongs to</summary>
        public unsafe SoundSubmix SoundSubmix {
            get {return SynthComponent_ptr->SoundSubmix;}
            set {SynthComponent_ptr->SoundSubmix = value;}
        }
         //TODO: array not UObject TArray SoundSubmixSends
         //TODO: array not UObject TArray BusSends
         //TODO: array not UObject TArray PreEffectBusSends
        public bool bIsUISound {
            get {return Main.GetGetBoolPropertyByName(this, "bIsUISound"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsUISound", value); }
        }
        public bool bIsPreviewSound {
            get {return Main.GetGetBoolPropertyByName(this, "bIsPreviewSound"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsPreviewSound", value); }
        }
        ///<summary>The attack time in milliseconds for the envelope follower. Delegate callbacks can be registered to get the envelope value of sounds played with this audio component. Only used in audio mixer.</summary>
        public unsafe int EnvelopeFollowerAttackTime {
            get {return SynthComponent_ptr->EnvelopeFollowerAttackTime;}
            set {SynthComponent_ptr->EnvelopeFollowerAttackTime = value;}
        }
        ///<summary>The release time in milliseconds for the envelope follower. Delegate callbacks can be registered to get the envelope value of sounds played with this audio component. Only used in audio mixer.</summary>
        public unsafe int EnvelopeFollowerReleaseTime {
            get {return SynthComponent_ptr->EnvelopeFollowerReleaseTime;}
            set {SynthComponent_ptr->EnvelopeFollowerReleaseTime = value;}
        }
         //TODO: multicast delegate FOnSynthEnvelopeValue OnAudioEnvelopeValue
        ///<summary>Synth</summary>
        public unsafe SynthSound Synth {
            get {return SynthComponent_ptr->Synth;}
            set {SynthComponent_ptr->Synth = value;}
        }
        ///<summary>Audio Component</summary>
        public unsafe AudioComponent AudioComponent {
            get {return SynthComponent_ptr->AudioComponent;}
            set {SynthComponent_ptr->AudioComponent = value;}
        }
        static SynthComponent() {
            StaticClass = Main.GetClass("SynthComponent");
        }
        internal unsafe SynthComponent_fields* SynthComponent_ptr => (SynthComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SynthComponent(IntPtr p) => UObject.Make<SynthComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SynthComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SynthComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
