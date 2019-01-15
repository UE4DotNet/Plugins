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
        ///<summary>Lightmass World Info Settings</summary>
        [StructLayout( LayoutKind.Explicit, Size=84 )]
        public unsafe struct LightmassWorldInfoSettings {
            [FieldOffset(0)] public float StaticLightingLevelScale;

            [FieldOffset(4)] public int NumIndirectLightingBounces;

            [FieldOffset(8)] public int NumSkyLightingBounces;

            [FieldOffset(12)] public float IndirectLightingQuality;

            [FieldOffset(16)] public float IndirectLightingSmoothness;

            ///<summary>Represents a constant color light surrounding the upper hemisphere of the level, like a sky.</summary>
            ///<remarks>This light source currently does not get bounced as indirect lighting and causes reflection capture brightness to be incorrect.  Prefer using a Static Skylight instead.</remarks>
            [FieldOffset(20)] Color EnvironmentColor;

            [FieldOffset(24)] public float EnvironmentIntensity;

            [FieldOffset(28)] public float EmissiveBoost;

            [FieldOffset(32)] public float DiffuseBoost;

            [FieldOffset(36)] public byte VolumeLightingMethod;

            [FieldOffset(40)] public float VolumetricLightmapDetailCellSize;

            [FieldOffset(44)] public float VolumetricLightmapMaximumBrickMemoryMb;

            [FieldOffset(48)] public float VolumetricLightmapSphericalHarmonicSmoothing;

            [FieldOffset(52)] public float VolumeLightSamplePlacementScale;

            [FieldOffset(56)] public bool bUseAmbientOcclusion;

            [FieldOffset(56)] public bool bGenerateAmbientOcclusionMaterialMask;

            [FieldOffset(60)] public float DirectIlluminationOcclusionFraction;

            [FieldOffset(64)] public float IndirectIlluminationOcclusionFraction;

            [FieldOffset(68)] public float OcclusionExponent;

            [FieldOffset(72)] public float FullyOccludedSamplesFraction;

            [FieldOffset(76)] public float MaxOcclusionDistance;

            [FieldOffset(80)] public bool bVisualizeMaterialDiffuse;

            [FieldOffset(80)] public bool bVisualizeAmbientOcclusion;

            [FieldOffset(80)] public bool bCompressLightmaps;

        }
}
