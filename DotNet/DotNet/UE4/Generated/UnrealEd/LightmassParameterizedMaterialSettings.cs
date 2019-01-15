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


namespace UE4.UnrealEd{
        ///<summary>Structure for 'parameterized' Lightmass settings</summary>
        [StructLayout( LayoutKind.Explicit, Size=32 )]
        public unsafe struct LightmassParameterizedMaterialSettings {
            ///<summary>If true, forces translucency to cast static shadows as if the material were masked.</summary>
            [FieldOffset(0)] LightmassBooleanParameterValue CastShadowAsMasked;

            ///<summary>Scales the emissive contribution of this material to static lighting.</summary>
            [FieldOffset(8)] LightmassScalarParameterValue EmissiveBoost;

            ///<summary>Scales the diffuse contribution of this material to static lighting.</summary>
            [FieldOffset(16)] LightmassScalarParameterValue DiffuseBoost;

            ///<summary>Scales the resolution that this material's attributes were exported at.</summary>
            ///<remarks>This is useful for increasing material resolution when details are needed.</remarks>
            [FieldOffset(24)] LightmassScalarParameterValue ExportResolutionScale;

        }
}
