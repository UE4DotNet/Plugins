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
        ///<summary>The source data for runtime resources.</summary>
        [StructLayout( LayoutKind.Explicit, Size=352 )]
        public unsafe struct GPUSpriteResourceData {
            [FieldOffset(0)] byte QuantizedColorSamples; //TODO: array TArray QuantizedColorSamples

            [FieldOffset(16)] byte QuantizedMiscSamples; //TODO: array TArray QuantizedMiscSamples

            [FieldOffset(32)] byte QuantizedSimulationAttrSamples; //TODO: array TArray QuantizedSimulationAttrSamples

            ///<summary>Scale and bias to be applied to the color of sprites.</summary>
            [FieldOffset(48)] Vector4 ColorScale;

            ///<summary>Color Bias</summary>
            [FieldOffset(64)] Vector4 ColorBias;

            ///<summary>Scale and bias to be applied to the misc curve.</summary>
            [FieldOffset(80)] Vector4 MiscScale;

            ///<summary>Misc Bias</summary>
            [FieldOffset(96)] Vector4 MiscBias;

            ///<summary>Scale and bias to be applied to the simulation attribute curves.</summary>
            [FieldOffset(112)] Vector4 SimulationAttrCurveScale;

            ///<summary>Simulation Attr Curve Bias</summary>
            [FieldOffset(128)] Vector4 SimulationAttrCurveBias;

            ///<summary>Size of subimages. X:SubImageCountH Y:SubImageCountV Z:1/SubImageCountH W:1/SubImageCountV</summary>
            [FieldOffset(144)] Vector4 SubImageSize;

            ///<summary>SizeBySpeed parameters. XY=SpeedScale ZW=MaxSpeedScale.</summary>
            [FieldOffset(160)] Vector4 SizeBySpeed;

            ///<summary>Constant acceleration to apply to particles.</summary>
            [FieldOffset(176)] Vector ConstantAcceleration;

            ///<summary>Offset at which to orbit.</summary>
            [FieldOffset(188)] Vector OrbitOffsetBase;

            ///<summary>Orbit Offset Range</summary>
            [FieldOffset(200)] Vector OrbitOffsetRange;

            ///<summary>Frequency at which the particle orbits around each axis.</summary>
            [FieldOffset(212)] Vector OrbitFrequencyBase;

            ///<summary>Orbit Frequency Range</summary>
            [FieldOffset(224)] Vector OrbitFrequencyRange;

            ///<summary>Phase offset of orbit around each axis.</summary>
            [FieldOffset(236)] Vector OrbitPhaseBase;

            ///<summary>Orbit Phase Range</summary>
            [FieldOffset(248)] Vector OrbitPhaseRange;

            [FieldOffset(260)] public float GlobalVectorFieldScale;

            [FieldOffset(264)] public float GlobalVectorFieldTightness;

            [FieldOffset(268)] public float PerParticleVectorFieldScale;

            [FieldOffset(272)] public float PerParticleVectorFieldBias;

            [FieldOffset(276)] public float DragCoefficientScale;

            [FieldOffset(280)] public float DragCoefficientBias;

            [FieldOffset(284)] public float ResilienceScale;

            [FieldOffset(288)] public float ResilienceBias;

            [FieldOffset(292)] public float CollisionRadiusScale;

            [FieldOffset(296)] public float CollisionRadiusBias;

            [FieldOffset(300)] public float CollisionTimeBias;

            [FieldOffset(304)] public float CollisionRandomSpread;

            [FieldOffset(308)] public float CollisionRandomDistribution;

            [FieldOffset(312)] public float OneMinusFriction;

            [FieldOffset(316)] public float RotationRateScale;

            [FieldOffset(320)] public float CameraMotionBlurAmount;

            [FieldOffset(324)] public byte ScreenAlignment;

            [FieldOffset(325)] public byte LockAxisFlag;

            ///<summary>Pivot offset in UV space for placing the verts of each particle.</summary>
            [FieldOffset(328)] Vector2D PivotOffset;

            [FieldOffset(336)] public bool bRemoveHMDRoll;

            [FieldOffset(340)] public float MinFacingCameraBlendDistance;

            [FieldOffset(344)] public float MaxFacingCameraBlendDistance;

        }
}
