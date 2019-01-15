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
using UE4.MovieScene;

namespace UE4.MovieSceneTracks{
        ///<summary>Movie Scene Audio Section Template Data</summary>
        [StructLayout( LayoutKind.Explicit, Size=416 )]
        public unsafe struct MovieSceneAudioSectionTemplateData {
            [FieldOffset(0)] 
            private IntPtr  Sound_field;
            ///<summary>The sound cue or wave that this template plays. Not to be dereferenced on a background thread</summary>
            public SoundBase Sound {
                get {return Sound_field;}
                set {Sound_field = value;}
            }

            [FieldOffset(8)] public float AudioStartOffset;

            [FieldOffset(16)] public double SectionStartTimeSeconds;

            ///<summary>The amount which this audio is time dilated by</summary>
            [FieldOffset(24)] MovieSceneFloatChannel AudioPitchMultiplierCurve;

            ///<summary>The volume the sound will be played with.</summary>
            [FieldOffset(184)] MovieSceneFloatChannel AudioVolumeCurve;

            [FieldOffset(344)] public int RowIndex;

            [FieldOffset(348)] public bool bOverrideAttenuation;

            [FieldOffset(352)] 
            private IntPtr  AttenuationSettings_field;
            ///<summary>The attenuation settings</summary>
            public SoundAttenuation AttenuationSettings {
                get {return AttenuationSettings_field;}
                set {AttenuationSettings_field = value;}
            }

            [FieldOffset(360)] byte OnQueueSubtitles; //TODO: delegate FOnQueueSubtitles OnQueueSubtitles

            [FieldOffset(384)] byte OnAudioFinished; //TODO: multicast_delegate FOnAudioFinished OnAudioFinished

            [FieldOffset(400)] byte OnAudioPlaybackPercent; //TODO: multicast_delegate FOnAudioPlaybackPercent OnAudioPlaybackPercent

        }
}
