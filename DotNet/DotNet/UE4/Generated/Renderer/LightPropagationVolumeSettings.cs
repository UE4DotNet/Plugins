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


namespace UE4.Renderer{
        ///<summary>Light Propagation Volume Settings</summary>
        [StructLayout( LayoutKind.Explicit, Size=64 )]
        public unsafe struct LightPropagationVolumeSettings {
            [FieldOffset(0)] public bool bOverride_LPVIntensity;

            [FieldOffset(0)] public bool bOverride_LPVDirectionalOcclusionIntensity;

            [FieldOffset(0)] public bool bOverride_LPVDirectionalOcclusionRadius;

            [FieldOffset(0)] public bool bOverride_LPVDiffuseOcclusionExponent;

            [FieldOffset(0)] public bool bOverride_LPVSpecularOcclusionExponent;

            [FieldOffset(0)] public bool bOverride_LPVDiffuseOcclusionIntensity;

            [FieldOffset(0)] public bool bOverride_LPVSpecularOcclusionIntensity;

            [FieldOffset(0)] public bool bOverride_LPVSize;

            [FieldOffset(1)] public bool bOverride_LPVSecondaryOcclusionIntensity;

            [FieldOffset(1)] public bool bOverride_LPVSecondaryBounceIntensity;

            [FieldOffset(1)] public bool bOverride_LPVGeometryVolumeBias;

            [FieldOffset(1)] public bool bOverride_LPVVplInjectionBias;

            [FieldOffset(1)] public bool bOverride_LPVEmissiveInjectionIntensity;

            [FieldOffset(4)] public float LPVIntensity;

            [FieldOffset(8)] public float LPVVplInjectionBias;

            [FieldOffset(12)] public float LPVSize;

            [FieldOffset(16)] public float LPVSecondaryOcclusionIntensity;

            [FieldOffset(20)] public float LPVSecondaryBounceIntensity;

            [FieldOffset(24)] public float LPVGeometryVolumeBias;

            [FieldOffset(28)] public float LPVEmissiveInjectionIntensity;

            [FieldOffset(32)] public float LPVDirectionalOcclusionIntensity;

            [FieldOffset(36)] public float LPVDirectionalOcclusionRadius;

            [FieldOffset(40)] public float LPVDiffuseOcclusionExponent;

            [FieldOffset(44)] public float LPVSpecularOcclusionExponent;

            [FieldOffset(48)] public float LPVDiffuseOcclusionIntensity;

            [FieldOffset(52)] public float LPVSpecularOcclusionIntensity;

            [FieldOffset(56)] public float LPVFadeRange;

            [FieldOffset(60)] public float LPVDirectionalOcclusionFadeRange;

        }
}
