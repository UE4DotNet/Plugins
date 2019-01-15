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
        ///<summary>struct with all the settings we want in USubsurfaceProfile, separate to make it easer to pass this data around in the engine.</summary>
        [StructLayout( LayoutKind.Explicit, Size=80 )]
        public unsafe struct SubsurfaceProfileStruct {
            [FieldOffset(0)] public float ScatterRadius;

            ///<summary>
            ///Specifies the how much of the diffuse light gets into the material,
            ///can be seen as a per-channel mix factor between the original image,
            ///and the SSS-filtered image (called "strength" in SeparableSSS, default there: 0.
            ///</summary>
            ///<remarks>48, 0.41, 0.28)</remarks>
            [FieldOffset(4)] LinearColor SubsurfaceColor;

            ///<summary>
            ///defines the per-channel falloff of the gradients
            ///produced by the subsurface scattering events, can be used to fine tune the color of the gradients
            ///(called "falloff" in SeparableSSS, default there: 1, 0.
            ///</summary>
            ///<remarks>37, 0.3)</remarks>
            [FieldOffset(20)] LinearColor FalloffColor;

            ///<summary>Boundary Color Bleed</summary>
            [FieldOffset(36)] LinearColor BoundaryColorBleed;

            [FieldOffset(52)] public float ExtinctionScale;

            [FieldOffset(56)] public float NormalScale;

            [FieldOffset(60)] public float ScatteringDistribution;

            [FieldOffset(64)] public float IOR;

            [FieldOffset(68)] public float Roughness0;

            [FieldOffset(72)] public float Roughness1;

            [FieldOffset(76)] public float LobeMix;

        }
}
