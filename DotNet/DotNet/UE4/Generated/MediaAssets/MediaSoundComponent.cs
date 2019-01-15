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
using UE4.MediaAssets.Native;
using UE4.Engine;
using UE4.AudioMixer;

namespace UE4.MediaAssets {
    ///<summary>Implements a sound component for playing a media player's audio output.</summary>
    public unsafe partial class MediaSoundComponent : SynthComponent  {

        ///<summary>Get the attenuation settings based on the current component settings.</summary>
        ///<remarks>
        ///@param OutAttenuationSettings Will contain the attenuation settings, if available.
        ///@return true if attenuation settings were returned, false if attenuation is disabled.
        ///</remarks>
        public (SoundAttenuationSettings, bool) BP_GetAttenuationSettingsToApply()  => 
            MediaSoundComponent_methods.BP_GetAttenuationSettingsToApply_method.Invoke(ObjPointer);

        ///<summary>Get the media player that provides the audio samples.</summary>
        ///<remarks>
        ///@return The component's media player, or nullptr if not set.
        ///@see SetMediaPlayer
        ///</remarks>
        public MediaPlayer GetMediaPlayer()  => 
            MediaSoundComponent_methods.GetMediaPlayer_method.Invoke(ObjPointer);

        ///<summary>Set the media player that provides the audio samples.</summary>
        ///<remarks>
        ///@param NewMediaPlayer The player to set.
        ///@see GetMediaPlayer
        ///</remarks>
        public void SetMediaPlayer(MediaPlayer NewMediaPlayer)  => 
            MediaSoundComponent_methods.SetMediaPlayer_method.Invoke(ObjPointer, NewMediaPlayer);
         //TODO: enum EMediaSoundChannels Channels
        public bool DynamicRateAdjustment {
            get {return Main.GetGetBoolPropertyByName(this, "DynamicRateAdjustment"); }
            set {Main.SetGetBoolPropertyByName(this, "DynamicRateAdjustment", value); }
        }
        ///<summary>Factor for calculating the sample rate adjustment.</summary>
        ///<remarks>
        ///If dynamic rate adjustment is enabled, this number is multiplied with the drift
        ///between the audio and media clock (in 100ns ticks) to determine the adjustment.
        ///that is to be multiplied into the current playrate.
        ///</remarks>
        public unsafe float RateAdjustmentFactor {
            get {return MediaSoundComponent_ptr->RateAdjustmentFactor;}
            set {MediaSoundComponent_ptr->RateAdjustmentFactor = value;}
        }
        ///<summary>The allowed range of dynamic rate adjustment.</summary>
        ///<remarks>
        ///If dynamic rate adjustment is enabled, and the necessary adjustment
        ///falls outside of this range, audio samples will be dropped.
        ///</remarks>
        public unsafe FloatRange RateAdjustmentRange {
            get {return MediaSoundComponent_ptr->RateAdjustmentRange;}
            set {MediaSoundComponent_ptr->RateAdjustmentRange = value;}
        }
        ///<summary>The media player asset associated with this component.</summary>
        ///<remarks>
        ///This property is meant for design-time convenience. To change the
        ///associated media player at run-time, use the SetMediaPlayer method.
        ///
        ///@see SetMediaPlayer
        ///</remarks>
        public unsafe MediaPlayer MediaPlayer {
            get {return MediaSoundComponent_ptr->MediaPlayer;}
            set {MediaSoundComponent_ptr->MediaPlayer = value;}
        }
        static MediaSoundComponent() {
            StaticClass = Main.GetClass("MediaSoundComponent");
        }
        internal unsafe MediaSoundComponent_fields* MediaSoundComponent_ptr => (MediaSoundComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MediaSoundComponent(IntPtr p) => UObject.Make<MediaSoundComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MediaSoundComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MediaSoundComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
