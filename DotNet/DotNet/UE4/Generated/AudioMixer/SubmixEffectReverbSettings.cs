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


namespace UE4.AudioMixer{
        ///<summary>Submix Effect Reverb Settings</summary>
        [StructLayout( LayoutKind.Explicit, Size=52 )]
        public unsafe struct SubmixEffectReverbSettings {
            [FieldOffset(0)] public float Density;

            [FieldOffset(4)] public float Diffusion;

            [FieldOffset(8)] public float Gain;

            [FieldOffset(12)] public float GainHF;

            [FieldOffset(16)] public float DecayTime;

            [FieldOffset(20)] public float DecayHFRatio;

            [FieldOffset(24)] public float ReflectionsGain;

            [FieldOffset(28)] public float ReflectionsDelay;

            [FieldOffset(32)] public float LateGain;

            [FieldOffset(36)] public float LateDelay;

            [FieldOffset(40)] public float AirAbsorptionGainHF;

            [FieldOffset(44)] public float WetLevel;

            [FieldOffset(48)] public float DryLevel;

        }
}
