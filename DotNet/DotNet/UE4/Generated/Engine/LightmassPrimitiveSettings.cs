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
        ///<summary>Per-object settings for Lightmass</summary>
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        public unsafe struct LightmassPrimitiveSettings {
            [FieldOffset(0)] public bool bUseTwoSidedLighting;

            [FieldOffset(0)] public bool bShadowIndirectOnly;

            [FieldOffset(0)] public bool bUseEmissiveForStaticLighting;

            [FieldOffset(0)] public bool bUseVertexNormalForHemisphereGather;

            [FieldOffset(4)] public float EmissiveLightFalloffExponent;

            [FieldOffset(8)] public float EmissiveLightExplicitInfluenceRadius;

            [FieldOffset(12)] public float EmissiveBoost;

            [FieldOffset(16)] public float DiffuseBoost;

            [FieldOffset(20)] public float FullyOccludedSamplesFraction;

        }
}
