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
using UE4.MovieSceneTracks.Native;
using UE4.MovieScene;
using UE4.Engine;

namespace UE4.MovieSceneTracks {
    ///<summary>Audio section, for use in the master audio, or by attached audio objects</summary>
    public unsafe partial class MovieSceneAudioSection : MovieSceneSection  {
        ///<summary>The sound cue or wave that this section plays</summary>
        public unsafe SoundBase Sound {
            get {return MovieSceneAudioSection_ptr->Sound;}
            set {MovieSceneAudioSection_ptr->Sound = value;}
        }
        ///<summary>The offset into the beginning of the audio clip</summary>
        public unsafe float StartOffset {
            get {return MovieSceneAudioSection_ptr->StartOffset;}
            set {MovieSceneAudioSection_ptr->StartOffset = value;}
        }
        ///<summary>The volume the sound will be played with.</summary>
        public unsafe MovieSceneFloatChannel SoundVolume {
            get {return MovieSceneAudioSection_ptr->SoundVolume;}
            set {MovieSceneAudioSection_ptr->SoundVolume = value;}
        }
        ///<summary>The pitch multiplier the sound will be played with.</summary>
        public unsafe MovieSceneFloatChannel PitchMultiplier {
            get {return MovieSceneAudioSection_ptr->PitchMultiplier;}
            set {MovieSceneAudioSection_ptr->PitchMultiplier = value;}
        }
        public bool bSuppressSubtitles {
            get {return Main.GetGetBoolPropertyByName(this, "bSuppressSubtitles"); }
            set {Main.SetGetBoolPropertyByName(this, "bSuppressSubtitles", value); }
        }
        public bool bOverrideAttenuation {
            get {return Main.GetGetBoolPropertyByName(this, "bOverrideAttenuation"); }
            set {Main.SetGetBoolPropertyByName(this, "bOverrideAttenuation", value); }
        }
        ///<summary>The attenuation settings to use.</summary>
        public unsafe SoundAttenuation AttenuationSettings {
            get {return MovieSceneAudioSection_ptr->AttenuationSettings;}
            set {MovieSceneAudioSection_ptr->AttenuationSettings = value;}
        }
         //TODO: delegate FOnQueueSubtitles OnQueueSubtitles
         //TODO: multicast delegate FOnAudioFinished OnAudioFinished
         //TODO: multicast delegate FOnAudioPlaybackPercent OnAudioPlaybackPercent
        static MovieSceneAudioSection() {
            StaticClass = Main.GetClass("MovieSceneAudioSection");
        }
        internal unsafe MovieSceneAudioSection_fields* MovieSceneAudioSection_ptr => (MovieSceneAudioSection_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MovieSceneAudioSection(IntPtr p) => UObject.Make<MovieSceneAudioSection>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MovieSceneAudioSection DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MovieSceneAudioSection New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
