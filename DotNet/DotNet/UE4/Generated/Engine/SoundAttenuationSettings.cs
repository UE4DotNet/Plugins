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


namespace UE4.Engine{
        ///<summary>The settings for attenuating.</summary>
        [StructLayout( LayoutKind.Explicit, Size=720 )]
        public unsafe struct SoundAttenuationSettings {
            [FieldOffset(160)] public bool bAttenuate;

            [FieldOffset(160)] public bool bSpatialize;

            [FieldOffset(160)] public bool bAttenuateWithLPF;

            [FieldOffset(160)] public bool bEnableListenerFocus;

            [FieldOffset(160)] public bool bEnableFocusInterpolation;

            [FieldOffset(160)] public bool bEnableOcclusion;

            [FieldOffset(160)] public bool bUseComplexCollisionForOcclusion;

            [FieldOffset(160)] public bool bEnableReverbSend;

            [FieldOffset(161)] public bool bApplyNormalizationToStereoSounds;

            [FieldOffset(161)] public bool bEnableLogFrequencyScaling;

            [FieldOffset(162)] public byte SpatializationAlgorithm;

            [FieldOffset(163)] byte AbsorptionMethod; //TODO: enum EAirAbsorptionMethod AbsorptionMethod

            [FieldOffset(164)] public byte OcclusionTraceChannel;

            [FieldOffset(165)] byte ReverbSendMethod; //TODO: enum EReverbSendMethod ReverbSendMethod

            [FieldOffset(168)] public float OmniRadius;

            [FieldOffset(172)] public float StereoSpread;

            [FieldOffset(192)] public float LPFRadiusMin;

            [FieldOffset(196)] public float LPFRadiusMax;

            ///<summary>The normalized custom curve to use for the air absorption lowpass frequency values. Does a mapping from defined distance values (x-axis) and defined frequency values (y-axis)</summary>
            [FieldOffset(200)] RuntimeFloatCurve CustomLowpassAirAbsorptionCurve;

            ///<summary>The normalized custom curve to use for the air absorption highpass frequency values. Does a mapping from defined distance values (x-axis) and defined frequency values (y-axis)</summary>
            [FieldOffset(320)] RuntimeFloatCurve CustomHighpassAirAbsorptionCurve;

            [FieldOffset(440)] public float LPFFrequencyAtMin;

            [FieldOffset(444)] public float LPFFrequencyAtMax;

            [FieldOffset(448)] public float HPFFrequencyAtMin;

            [FieldOffset(452)] public float HPFFrequencyAtMax;

            [FieldOffset(456)] public float FocusAzimuth;

            [FieldOffset(460)] public float NonFocusAzimuth;

            [FieldOffset(464)] public float FocusDistanceScale;

            [FieldOffset(468)] public float NonFocusDistanceScale;

            [FieldOffset(472)] public float FocusPriorityScale;

            [FieldOffset(476)] public float NonFocusPriorityScale;

            [FieldOffset(480)] public float FocusVolumeAttenuation;

            [FieldOffset(484)] public float NonFocusVolumeAttenuation;

            [FieldOffset(488)] public float FocusAttackInterpSpeed;

            [FieldOffset(492)] public float FocusReleaseInterpSpeed;

            [FieldOffset(496)] public float OcclusionLowPassFilterFrequency;

            [FieldOffset(500)] public float OcclusionVolumeAttenuation;

            [FieldOffset(504)] public float OcclusionInterpolationTime;

            [FieldOffset(528)] public float ReverbWetLevelMin;

            [FieldOffset(532)] public float ReverbWetLevelMax;

            [FieldOffset(536)] public float ReverbDistanceMin;

            [FieldOffset(540)] public float ReverbDistanceMax;

            [FieldOffset(544)] public float ManualReverbSendLevel;

            ///<summary>The custom reverb send curve to use for distance-based send level.</summary>
            [FieldOffset(552)] RuntimeFloatCurve CustomReverbSendCurve;

            ///<summary>Sound attenuation plugin settings to use with sounds that play with this attenuation setting.</summary>
            [FieldOffset(672)] SoundAttenuationPluginSettings PluginSettings;

        }
}
