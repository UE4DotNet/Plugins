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
    ///<summary>Audio settings.</summary>
    public unsafe partial class AudioSettings : DeveloperSettings  {
        ///<summary>The SoundClass assigned to newly created sounds</summary>
        public unsafe SoftObjectPath DefaultSoundClassName {
            get {return AudioSettings_ptr->DefaultSoundClassName;}
            set {AudioSettings_ptr->DefaultSoundClassName = value;}
        }
        ///<summary>The SoundClass assigned to media player assets</summary>
        public unsafe SoftObjectPath DefaultMediaSoundClassName {
            get {return AudioSettings_ptr->DefaultMediaSoundClassName;}
            set {AudioSettings_ptr->DefaultMediaSoundClassName = value;}
        }
        ///<summary>The SoundConcurrency assigned to newly created sounds</summary>
        public unsafe SoftObjectPath DefaultSoundConcurrencyName {
            get {return AudioSettings_ptr->DefaultSoundConcurrencyName;}
            set {AudioSettings_ptr->DefaultSoundConcurrencyName = value;}
        }
        ///<summary>The SoundMix to use as base when no other system has speciicefied a Base SoundMix</summary>
        public unsafe SoftObjectPath DefaultBaseSoundMix {
            get {return AudioSettings_ptr->DefaultBaseSoundMix;}
            set {AudioSettings_ptr->DefaultBaseSoundMix = value;}
        }
        ///<summary>Sound class to be used for the VOIP audio component</summary>
        public unsafe SoftObjectPath VoiPSoundClass {
            get {return AudioSettings_ptr->VoiPSoundClass;}
            set {AudioSettings_ptr->VoiPSoundClass = value;}
        }
         //TODO: enum EVoiceSampleRate VoiPSampleRate
        ///<summary>The amount of time to buffer incoming voice audio for ahead of time. Increasing this value can help avoid jitter on slower network connections.</summary>
        public unsafe float VoipBufferingDelay {
            get {return AudioSettings_ptr->VoipBufferingDelay;}
            set {AudioSettings_ptr->VoipBufferingDelay = value;}
        }
        ///<summary>The amount of audio to send to reverb submixes if no reverb send is setup for the source through attenuation settings. Only used in audio mixer.</summary>
        public unsafe float DefaultReverbSendLevel {
            get {return AudioSettings_ptr->DefaultReverbSendLevel;}
            set {AudioSettings_ptr->DefaultReverbSendLevel = value;}
        }
        ///<summary>How many streaming sounds can be played at the same time (if more are played they will be sorted by priority)</summary>
        public unsafe int MaximumConcurrentStreams {
            get {return AudioSettings_ptr->MaximumConcurrentStreams;}
            set {AudioSettings_ptr->MaximumConcurrentStreams = value;}
        }
         //TODO: array not UObject TArray QualityLevels
        public bool bAllowVirtualizedSounds {
            get {return Main.GetGetBoolPropertyByName(this, "bAllowVirtualizedSounds"); }
            set {Main.SetGetBoolPropertyByName(this, "bAllowVirtualizedSounds", value); }
        }
        public bool bDisableMasterEQ {
            get {return Main.GetGetBoolPropertyByName(this, "bDisableMasterEQ"); }
            set {Main.SetGetBoolPropertyByName(this, "bDisableMasterEQ", value); }
        }
        public bool bAllowCenterChannel3DPanning {
            get {return Main.GetGetBoolPropertyByName(this, "bAllowCenterChannel3DPanning"); }
            set {Main.SetGetBoolPropertyByName(this, "bAllowCenterChannel3DPanning", value); }
        }
         //TODO: numeric uint32 MaxWaveInstances
         //TODO: numeric uint32 NumStoppingSources
         //TODO: enum EPanningMethod PanningMethod
         //TODO: enum EMonoChannelUpmixMethod MonoChannelUpmixMethod
         //TODO: string FString DialogueFilenameFormat
        static AudioSettings() {
            StaticClass = Main.GetClass("AudioSettings");
        }
        internal unsafe AudioSettings_fields* AudioSettings_ptr => (AudioSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AudioSettings(IntPtr p) => UObject.Make<AudioSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AudioSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AudioSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
