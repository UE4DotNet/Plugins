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
        ///<summary>Post Process Settings</summary>
        [StructLayout( LayoutKind.Explicit, Size=1280 )]
        public unsafe struct PostProcessSettings {
            [FieldOffset(0)] public bool bOverride_WhiteTemp;

            [FieldOffset(0)] public bool bOverride_WhiteTint;

            [FieldOffset(0)] public bool bOverride_ColorSaturation;

            [FieldOffset(0)] public bool bOverride_ColorContrast;

            [FieldOffset(0)] public bool bOverride_ColorGamma;

            [FieldOffset(0)] public bool bOverride_ColorGain;

            [FieldOffset(0)] public bool bOverride_ColorOffset;

            [FieldOffset(0)] public bool bOverride_ColorSaturationShadows;

            [FieldOffset(1)] public bool bOverride_ColorContrastShadows;

            [FieldOffset(1)] public bool bOverride_ColorGammaShadows;

            [FieldOffset(1)] public bool bOverride_ColorGainShadows;

            [FieldOffset(1)] public bool bOverride_ColorOffsetShadows;

            [FieldOffset(1)] public bool bOverride_ColorSaturationMidtones;

            [FieldOffset(1)] public bool bOverride_ColorContrastMidtones;

            [FieldOffset(1)] public bool bOverride_ColorGammaMidtones;

            [FieldOffset(1)] public bool bOverride_ColorGainMidtones;

            [FieldOffset(2)] public bool bOverride_ColorOffsetMidtones;

            [FieldOffset(2)] public bool bOverride_ColorSaturationHighlights;

            [FieldOffset(2)] public bool bOverride_ColorContrastHighlights;

            [FieldOffset(2)] public bool bOverride_ColorGammaHighlights;

            [FieldOffset(2)] public bool bOverride_ColorGainHighlights;

            [FieldOffset(2)] public bool bOverride_ColorOffsetHighlights;

            [FieldOffset(2)] public bool bOverride_ColorCorrectionShadowsMax;

            [FieldOffset(2)] public bool bOverride_ColorCorrectionHighlightsMin;

            [FieldOffset(3)] public bool bOverride_BlueCorrection;

            [FieldOffset(3)] public bool bOverride_ExpandGamut;

            [FieldOffset(3)] public bool bOverride_FilmWhitePoint;

            [FieldOffset(3)] public bool bOverride_FilmSaturation;

            [FieldOffset(3)] public bool bOverride_FilmChannelMixerRed;

            [FieldOffset(3)] public bool bOverride_FilmChannelMixerGreen;

            [FieldOffset(3)] public bool bOverride_FilmChannelMixerBlue;

            [FieldOffset(3)] public bool bOverride_FilmContrast;

            [FieldOffset(4)] public bool bOverride_FilmDynamicRange;

            [FieldOffset(4)] public bool bOverride_FilmHealAmount;

            [FieldOffset(4)] public bool bOverride_FilmToeAmount;

            [FieldOffset(4)] public bool bOverride_FilmShadowTint;

            [FieldOffset(4)] public bool bOverride_FilmShadowTintBlend;

            [FieldOffset(4)] public bool bOverride_FilmShadowTintAmount;

            [FieldOffset(4)] public bool bOverride_FilmSlope;

            [FieldOffset(4)] public bool bOverride_FilmToe;

            [FieldOffset(5)] public bool bOverride_FilmShoulder;

            [FieldOffset(5)] public bool bOverride_FilmBlackClip;

            [FieldOffset(5)] public bool bOverride_FilmWhiteClip;

            [FieldOffset(5)] public bool bOverride_SceneColorTint;

            [FieldOffset(5)] public bool bOverride_SceneFringeIntensity;

            [FieldOffset(5)] public bool bOverride_ChromaticAberrationStartOffset;

            [FieldOffset(5)] public bool bOverride_AmbientCubemapTint;

            [FieldOffset(5)] public bool bOverride_AmbientCubemapIntensity;

            [FieldOffset(6)] public bool bOverride_BloomMethod;

            [FieldOffset(6)] public bool bOverride_BloomIntensity;

            [FieldOffset(6)] public bool bOverride_BloomThreshold;

            [FieldOffset(6)] public bool bOverride_Bloom1Tint;

            [FieldOffset(6)] public bool bOverride_Bloom1Size;

            [FieldOffset(6)] public bool bOverride_Bloom2Size;

            [FieldOffset(6)] public bool bOverride_Bloom2Tint;

            [FieldOffset(6)] public bool bOverride_Bloom3Tint;

            [FieldOffset(7)] public bool bOverride_Bloom3Size;

            [FieldOffset(7)] public bool bOverride_Bloom4Tint;

            [FieldOffset(7)] public bool bOverride_Bloom4Size;

            [FieldOffset(7)] public bool bOverride_Bloom5Tint;

            [FieldOffset(7)] public bool bOverride_Bloom5Size;

            [FieldOffset(7)] public bool bOverride_Bloom6Tint;

            [FieldOffset(7)] public bool bOverride_Bloom6Size;

            [FieldOffset(7)] public bool bOverride_BloomSizeScale;

            [FieldOffset(8)] public bool bOverride_BloomConvolutionTexture;

            [FieldOffset(8)] public bool bOverride_BloomConvolutionSize;

            [FieldOffset(8)] public bool bOverride_BloomConvolutionCenterUV;

            [FieldOffset(8)] public bool bOverride_BloomConvolutionPreFilterMin;

            [FieldOffset(8)] public bool bOverride_BloomConvolutionPreFilterMax;

            [FieldOffset(8)] public bool bOverride_BloomConvolutionPreFilterMult;

            [FieldOffset(8)] public bool bOverride_BloomConvolutionBufferScale;

            [FieldOffset(9)] public bool bOverride_BloomDirtMaskIntensity;

            [FieldOffset(9)] public bool bOverride_BloomDirtMaskTint;

            [FieldOffset(9)] public bool bOverride_BloomDirtMask;

            [FieldOffset(9)] public bool bOverride_CameraShutterSpeed;

            [FieldOffset(9)] public bool bOverride_CameraISO;

            [FieldOffset(9)] public bool bOverride_AutoExposureMethod;

            [FieldOffset(9)] public bool bOverride_AutoExposureLowPercent;

            [FieldOffset(9)] public bool bOverride_AutoExposureHighPercent;

            [FieldOffset(10)] public bool bOverride_AutoExposureMinBrightness;

            [FieldOffset(10)] public bool bOverride_AutoExposureMaxBrightness;

            [FieldOffset(10)] public bool bOverride_AutoExposureCalibrationConstant;

            [FieldOffset(10)] public bool bOverride_AutoExposureSpeedUp;

            [FieldOffset(10)] public bool bOverride_AutoExposureSpeedDown;

            [FieldOffset(10)] public bool bOverride_AutoExposureBias;

            [FieldOffset(10)] public bool bOverride_HistogramLogMin;

            [FieldOffset(10)] public bool bOverride_HistogramLogMax;

            [FieldOffset(11)] public bool bOverride_LensFlareIntensity;

            [FieldOffset(11)] public bool bOverride_LensFlareTint;

            [FieldOffset(11)] public bool bOverride_LensFlareTints;

            [FieldOffset(11)] public bool bOverride_LensFlareBokehSize;

            [FieldOffset(11)] public bool bOverride_LensFlareBokehShape;

            [FieldOffset(11)] public bool bOverride_LensFlareThreshold;

            [FieldOffset(11)] public bool bOverride_VignetteIntensity;

            [FieldOffset(11)] public bool bOverride_GrainIntensity;

            [FieldOffset(12)] public bool bOverride_GrainJitter;

            [FieldOffset(12)] public bool bOverride_AmbientOcclusionIntensity;

            [FieldOffset(12)] public bool bOverride_AmbientOcclusionStaticFraction;

            [FieldOffset(12)] public bool bOverride_AmbientOcclusionRadius;

            [FieldOffset(12)] public bool bOverride_AmbientOcclusionFadeDistance;

            [FieldOffset(12)] public bool bOverride_AmbientOcclusionFadeRadius;

            [FieldOffset(12)] public bool bOverride_AmbientOcclusionRadiusInWS;

            [FieldOffset(13)] public bool bOverride_AmbientOcclusionPower;

            [FieldOffset(13)] public bool bOverride_AmbientOcclusionBias;

            [FieldOffset(13)] public bool bOverride_AmbientOcclusionQuality;

            [FieldOffset(13)] public bool bOverride_AmbientOcclusionMipBlend;

            [FieldOffset(13)] public bool bOverride_AmbientOcclusionMipScale;

            [FieldOffset(13)] public bool bOverride_AmbientOcclusionMipThreshold;

            [FieldOffset(13)] public bool bOverride_LPVIntensity;

            [FieldOffset(13)] public bool bOverride_LPVDirectionalOcclusionIntensity;

            [FieldOffset(14)] public bool bOverride_LPVDirectionalOcclusionRadius;

            [FieldOffset(14)] public bool bOverride_LPVDiffuseOcclusionExponent;

            [FieldOffset(14)] public bool bOverride_LPVSpecularOcclusionExponent;

            [FieldOffset(14)] public bool bOverride_LPVDiffuseOcclusionIntensity;

            [FieldOffset(14)] public bool bOverride_LPVSpecularOcclusionIntensity;

            [FieldOffset(14)] public bool bOverride_LPVSize;

            [FieldOffset(14)] public bool bOverride_LPVSecondaryOcclusionIntensity;

            [FieldOffset(14)] public bool bOverride_LPVSecondaryBounceIntensity;

            [FieldOffset(15)] public bool bOverride_LPVGeometryVolumeBias;

            [FieldOffset(15)] public bool bOverride_LPVVplInjectionBias;

            [FieldOffset(15)] public bool bOverride_LPVEmissiveInjectionIntensity;

            [FieldOffset(15)] public bool bOverride_LPVFadeRange;

            [FieldOffset(15)] public bool bOverride_LPVDirectionalOcclusionFadeRange;

            [FieldOffset(15)] public bool bOverride_IndirectLightingColor;

            [FieldOffset(15)] public bool bOverride_IndirectLightingIntensity;

            [FieldOffset(15)] public bool bOverride_ColorGradingIntensity;

            [FieldOffset(16)] public bool bOverride_ColorGradingLUT;

            [FieldOffset(16)] public bool bOverride_DepthOfFieldFocalDistance;

            [FieldOffset(16)] public bool bOverride_DepthOfFieldFstop;

            [FieldOffset(16)] public bool bOverride_DepthOfFieldMinFstop;

            [FieldOffset(16)] public bool bOverride_DepthOfFieldBladeCount;

            [FieldOffset(16)] public bool bOverride_DepthOfFieldSensorWidth;

            [FieldOffset(16)] public bool bOverride_DepthOfFieldDepthBlurRadius;

            [FieldOffset(16)] public bool bOverride_DepthOfFieldDepthBlurAmount;

            [FieldOffset(17)] public bool bOverride_DepthOfFieldFocalRegion;

            [FieldOffset(17)] public bool bOverride_DepthOfFieldNearTransitionRegion;

            [FieldOffset(17)] public bool bOverride_DepthOfFieldFarTransitionRegion;

            [FieldOffset(17)] public bool bOverride_DepthOfFieldScale;

            [FieldOffset(17)] public bool bOverride_DepthOfFieldMaxBokehSize;

            [FieldOffset(17)] public bool bOverride_DepthOfFieldNearBlurSize;

            [FieldOffset(17)] public bool bOverride_DepthOfFieldFarBlurSize;

            [FieldOffset(17)] public bool bOverride_DepthOfFieldMethod;

            [FieldOffset(18)] public bool bOverride_MobileHQGaussian;

            [FieldOffset(18)] public bool bOverride_DepthOfFieldBokehShape;

            [FieldOffset(18)] public bool bOverride_DepthOfFieldOcclusion;

            [FieldOffset(18)] public bool bOverride_DepthOfFieldColorThreshold;

            [FieldOffset(18)] public bool bOverride_DepthOfFieldSizeThreshold;

            [FieldOffset(18)] public bool bOverride_DepthOfFieldSkyFocusDistance;

            [FieldOffset(18)] public bool bOverride_DepthOfFieldVignetteSize;

            [FieldOffset(18)] public bool bOverride_MotionBlurAmount;

            [FieldOffset(19)] public bool bOverride_MotionBlurMax;

            [FieldOffset(19)] public bool bOverride_MotionBlurPerObjectSize;

            [FieldOffset(19)] public bool bOverride_ScreenPercentage;

            [FieldOffset(19)] public bool bOverride_ScreenSpaceReflectionIntensity;

            [FieldOffset(19)] public bool bOverride_ScreenSpaceReflectionQuality;

            [FieldOffset(19)] public bool bOverride_ScreenSpaceReflectionMaxRoughness;

            [FieldOffset(19)] public bool bOverride_ScreenSpaceReflectionRoughnessScale;

            [FieldOffset(19)] public bool bMobileHQGaussian;

            [FieldOffset(20)] public byte BloomMethod;

            [FieldOffset(21)] public byte AutoExposureMethod;

            [FieldOffset(22)] public byte DepthOfFieldMethod;

            [FieldOffset(24)] public float WhiteTemp;

            [FieldOffset(28)] public float WhiteTint;

            ///<summary>Color Correction controls</summary>
            [FieldOffset(32)] Vector4 ColorSaturation;

            ///<summary>Color Contrast</summary>
            [FieldOffset(48)] Vector4 ColorContrast;

            ///<summary>Color Gamma</summary>
            [FieldOffset(64)] Vector4 ColorGamma;

            ///<summary>Color Gain</summary>
            [FieldOffset(80)] Vector4 ColorGain;

            ///<summary>Color Offset</summary>
            [FieldOffset(96)] Vector4 ColorOffset;

            ///<summary>Color Saturation Shadows</summary>
            [FieldOffset(112)] Vector4 ColorSaturationShadows;

            ///<summary>Color Contrast Shadows</summary>
            [FieldOffset(128)] Vector4 ColorContrastShadows;

            ///<summary>Color Gamma Shadows</summary>
            [FieldOffset(144)] Vector4 ColorGammaShadows;

            ///<summary>Color Gain Shadows</summary>
            [FieldOffset(160)] Vector4 ColorGainShadows;

            ///<summary>Color Offset Shadows</summary>
            [FieldOffset(176)] Vector4 ColorOffsetShadows;

            ///<summary>Color Saturation Midtones</summary>
            [FieldOffset(192)] Vector4 ColorSaturationMidtones;

            ///<summary>Color Contrast Midtones</summary>
            [FieldOffset(208)] Vector4 ColorContrastMidtones;

            ///<summary>Color Gamma Midtones</summary>
            [FieldOffset(224)] Vector4 ColorGammaMidtones;

            ///<summary>Color Gain Midtones</summary>
            [FieldOffset(240)] Vector4 ColorGainMidtones;

            ///<summary>Color Offset Midtones</summary>
            [FieldOffset(256)] Vector4 ColorOffsetMidtones;

            ///<summary>Color Saturation Highlights</summary>
            [FieldOffset(272)] Vector4 ColorSaturationHighlights;

            ///<summary>Color Contrast Highlights</summary>
            [FieldOffset(288)] Vector4 ColorContrastHighlights;

            ///<summary>Color Gamma Highlights</summary>
            [FieldOffset(304)] Vector4 ColorGammaHighlights;

            ///<summary>Color Gain Highlights</summary>
            [FieldOffset(320)] Vector4 ColorGainHighlights;

            ///<summary>Color Offset Highlights</summary>
            [FieldOffset(336)] Vector4 ColorOffsetHighlights;

            [FieldOffset(352)] public float ColorCorrectionHighlightsMin;

            [FieldOffset(356)] public float ColorCorrectionShadowsMax;

            [FieldOffset(360)] public float BlueCorrection;

            [FieldOffset(364)] public float ExpandGamut;

            [FieldOffset(368)] public float FilmSlope;

            [FieldOffset(372)] public float FilmToe;

            [FieldOffset(376)] public float FilmShoulder;

            [FieldOffset(380)] public float FilmBlackClip;

            [FieldOffset(384)] public float FilmWhiteClip;

            ///<summary>Film White Point</summary>
            [FieldOffset(388)] LinearColor FilmWhitePoint;

            ///<summary>Film Shadow Tint</summary>
            [FieldOffset(404)] LinearColor FilmShadowTint;

            [FieldOffset(420)] public float FilmShadowTintBlend;

            [FieldOffset(424)] public float FilmShadowTintAmount;

            [FieldOffset(428)] public float FilmSaturation;

            ///<summary>Film Channel Mixer Red</summary>
            [FieldOffset(432)] LinearColor FilmChannelMixerRed;

            ///<summary>Film Channel Mixer Green</summary>
            [FieldOffset(448)] LinearColor FilmChannelMixerGreen;

            ///<summary>Film Channel Mixer Blue</summary>
            [FieldOffset(464)] LinearColor FilmChannelMixerBlue;

            [FieldOffset(480)] public float FilmContrast;

            [FieldOffset(484)] public float FilmToeAmount;

            [FieldOffset(488)] public float FilmHealAmount;

            [FieldOffset(492)] public float FilmDynamicRange;

            ///<summary>Scene tint color</summary>
            [FieldOffset(496)] LinearColor SceneColorTint;

            [FieldOffset(512)] public float SceneFringeIntensity;

            [FieldOffset(516)] public float ChromaticAberrationStartOffset;

            [FieldOffset(520)] public float BloomIntensity;

            [FieldOffset(524)] public float BloomThreshold;

            [FieldOffset(528)] public float BloomSizeScale;

            [FieldOffset(532)] public float Bloom1Size;

            [FieldOffset(536)] public float Bloom2Size;

            [FieldOffset(540)] public float Bloom3Size;

            [FieldOffset(544)] public float Bloom4Size;

            [FieldOffset(548)] public float Bloom5Size;

            [FieldOffset(552)] public float Bloom6Size;

            ///<summary>Bloom1 tint color</summary>
            [FieldOffset(556)] LinearColor Bloom1Tint;

            ///<summary>Bloom2 tint color</summary>
            [FieldOffset(572)] LinearColor Bloom2Tint;

            ///<summary>Bloom3 tint color</summary>
            [FieldOffset(588)] LinearColor Bloom3Tint;

            ///<summary>Bloom4 tint color</summary>
            [FieldOffset(604)] LinearColor Bloom4Tint;

            ///<summary>Bloom5 tint color</summary>
            [FieldOffset(620)] LinearColor Bloom5Tint;

            ///<summary>Bloom6 tint color</summary>
            [FieldOffset(636)] LinearColor Bloom6Tint;

            [FieldOffset(652)] public float BloomConvolutionSize;

            [FieldOffset(656)] 
            private IntPtr  BloomConvolutionTexture_field;
            ///<summary>Texture to replace default convolution bloom kernel</summary>
            public Texture2D BloomConvolutionTexture {
                get {return BloomConvolutionTexture_field;}
                set {BloomConvolutionTexture_field = value;}
            }

            ///<summary>The UV location of the center of the kernel.  Should be very close to (.5,.5)</summary>
            [FieldOffset(664)] Vector2D BloomConvolutionCenterUV;

            [FieldOffset(684)] public float BloomConvolutionPreFilterMin;

            [FieldOffset(688)] public float BloomConvolutionPreFilterMax;

            [FieldOffset(692)] public float BloomConvolutionPreFilterMult;

            [FieldOffset(696)] public float BloomConvolutionBufferScale;

            [FieldOffset(704)] 
            private IntPtr  BloomDirtMask_field;
            ///<summary>Texture that defines the dirt on the camera lens where the light of very bright objects is scattered.</summary>
            public Texture BloomDirtMask {
                get {return BloomDirtMask_field;}
                set {BloomDirtMask_field = value;}
            }

            [FieldOffset(712)] public float BloomDirtMaskIntensity;

            ///<summary>BloomDirtMask tint color</summary>
            [FieldOffset(716)] LinearColor BloomDirtMaskTint;

            ///<summary>AmbientCubemap tint color</summary>
            [FieldOffset(732)] LinearColor AmbientCubemapTint;

            [FieldOffset(748)] public float AmbientCubemapIntensity;

            [FieldOffset(752)] 
            private IntPtr  AmbientCubemap_field;
            ///<summary>The Ambient cubemap (Affects diffuse and specular shading), blends additively which if different from all other settings here</summary>
            public TextureCube AmbientCubemap {
                get {return AmbientCubemap_field;}
                set {AmbientCubemap_field = value;}
            }

            [FieldOffset(760)] public float CameraShutterSpeed;

            [FieldOffset(764)] public float CameraISO;

            [FieldOffset(768)] public float DepthOfFieldFstop;

            [FieldOffset(772)] public float DepthOfFieldMinFstop;

            [FieldOffset(776)] public int DepthOfFieldBladeCount;

            [FieldOffset(780)] public float AutoExposureBias;

            [FieldOffset(784)] public float AutoExposureLowPercent;

            [FieldOffset(788)] public float AutoExposureHighPercent;

            [FieldOffset(792)] public float AutoExposureMinBrightness;

            [FieldOffset(796)] public float AutoExposureMaxBrightness;

            [FieldOffset(800)] public float AutoExposureSpeedUp;

            [FieldOffset(804)] public float AutoExposureSpeedDown;

            [FieldOffset(808)] public float HistogramLogMin;

            [FieldOffset(812)] public float HistogramLogMax;

            [FieldOffset(816)] public float AutoExposureCalibrationConstant;

            [FieldOffset(820)] public float LensFlareIntensity;

            ///<summary>Tint color for the image based lens flares.</summary>
            [FieldOffset(824)] LinearColor LensFlareTint;

            [FieldOffset(840)] public float LensFlareBokehSize;

            [FieldOffset(844)] public float LensFlareThreshold;

            [FieldOffset(848)] 
            private IntPtr  LensFlareBokehShape_field;
            ///<summary>Defines the shape of the Bokeh when the image base lens flares are blurred, cannot be blended</summary>
            public Texture LensFlareBokehShape {
                get {return LensFlareBokehShape_field;}
                set {LensFlareBokehShape_field = value;}
            }

            ///<summary>RGB defines the lens flare color, A it's position. This is a temporary solution.</summary>
            [FieldOffset(856)] LinearColor LensFlareTints;

            [FieldOffset(984)] public float VignetteIntensity;

            [FieldOffset(988)] public float GrainJitter;

            [FieldOffset(992)] public float GrainIntensity;

            [FieldOffset(996)] public float AmbientOcclusionIntensity;

            [FieldOffset(1000)] public float AmbientOcclusionStaticFraction;

            [FieldOffset(1004)] public float AmbientOcclusionRadius;

            [FieldOffset(1008)] public bool AmbientOcclusionRadiusInWS;

            [FieldOffset(1012)] public float AmbientOcclusionFadeDistance;

            [FieldOffset(1016)] public float AmbientOcclusionFadeRadius;

            [FieldOffset(1024)] public float AmbientOcclusionPower;

            [FieldOffset(1028)] public float AmbientOcclusionBias;

            [FieldOffset(1032)] public float AmbientOcclusionQuality;

            [FieldOffset(1036)] public float AmbientOcclusionMipBlend;

            [FieldOffset(1040)] public float AmbientOcclusionMipScale;

            [FieldOffset(1044)] public float AmbientOcclusionMipThreshold;

            ///<summary>Adjusts indirect lighting color. (1,1,1) is default. (0,0,0) to disable GI. The show flag 'Global Illumination' must be enabled to use this property.</summary>
            [FieldOffset(1048)] LinearColor IndirectLightingColor;

            [FieldOffset(1064)] public float IndirectLightingIntensity;

            [FieldOffset(1068)] public float ColorGradingIntensity;

            [FieldOffset(1072)] 
            private IntPtr  ColorGradingLUT_field;
            ///<summary>Look up table texture to use or none of not used</summary>
            public Texture ColorGradingLUT {
                get {return ColorGradingLUT_field;}
                set {ColorGradingLUT_field = value;}
            }

            [FieldOffset(1080)] public float DepthOfFieldSensorWidth;

            [FieldOffset(1084)] public float DepthOfFieldFocalDistance;

            [FieldOffset(1088)] public float DepthOfFieldDepthBlurAmount;

            [FieldOffset(1092)] public float DepthOfFieldDepthBlurRadius;

            [FieldOffset(1096)] public float DepthOfFieldFocalRegion;

            [FieldOffset(1100)] public float DepthOfFieldNearTransitionRegion;

            [FieldOffset(1104)] public float DepthOfFieldFarTransitionRegion;

            [FieldOffset(1108)] public float DepthOfFieldScale;

            [FieldOffset(1112)] public float DepthOfFieldMaxBokehSize;

            [FieldOffset(1116)] public float DepthOfFieldNearBlurSize;

            [FieldOffset(1120)] public float DepthOfFieldFarBlurSize;

            [FieldOffset(1124)] public float DepthOfFieldOcclusion;

            [FieldOffset(1128)] 
            private IntPtr  DepthOfFieldBokehShape_field;
            ///<summary>Depth Of Field Bokeh Shape</summary>
            public Texture DepthOfFieldBokehShape {
                get {return DepthOfFieldBokehShape_field;}
                set {DepthOfFieldBokehShape_field = value;}
            }

            [FieldOffset(1136)] public float DepthOfFieldColorThreshold;

            [FieldOffset(1140)] public float DepthOfFieldSizeThreshold;

            [FieldOffset(1144)] public float DepthOfFieldSkyFocusDistance;

            [FieldOffset(1148)] public float DepthOfFieldVignetteSize;

            [FieldOffset(1152)] public float MotionBlurAmount;

            [FieldOffset(1156)] public float MotionBlurMax;

            [FieldOffset(1160)] public float MotionBlurPerObjectSize;

            [FieldOffset(1164)] public float LPVIntensity;

            [FieldOffset(1168)] public float LPVVplInjectionBias;

            [FieldOffset(1172)] public float LPVSize;

            [FieldOffset(1176)] public float LPVSecondaryOcclusionIntensity;

            [FieldOffset(1180)] public float LPVSecondaryBounceIntensity;

            [FieldOffset(1184)] public float LPVGeometryVolumeBias;

            [FieldOffset(1188)] public float LPVEmissiveInjectionIntensity;

            [FieldOffset(1192)] public float LPVDirectionalOcclusionIntensity;

            [FieldOffset(1196)] public float LPVDirectionalOcclusionRadius;

            [FieldOffset(1200)] public float LPVDiffuseOcclusionExponent;

            [FieldOffset(1204)] public float LPVSpecularOcclusionExponent;

            [FieldOffset(1208)] public float LPVDiffuseOcclusionIntensity;

            [FieldOffset(1212)] public float LPVSpecularOcclusionIntensity;

            [FieldOffset(1216)] public float ScreenSpaceReflectionIntensity;

            [FieldOffset(1220)] public float ScreenSpaceReflectionQuality;

            [FieldOffset(1224)] public float ScreenSpaceReflectionMaxRoughness;

            [FieldOffset(1228)] public float LPVFadeRange;

            [FieldOffset(1232)] public float LPVDirectionalOcclusionFadeRange;

            [FieldOffset(1236)] public float ScreenPercentage;

            ///<summary>Allows custom post process materials to be defined, using a MaterialInstance with the same Material as its parent to allow blending.</summary>
            ///<remarks>For materials this needs to be the "PostProcess" domain type. This can be used for any UObject object implementing the IBlendableInterface (e.g. could be used to fade weather settings).</remarks>
            [FieldOffset(1240)] WeightedBlendables WeightedBlendables;

        }
}
