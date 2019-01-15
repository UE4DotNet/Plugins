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
        ///<summary>Properties from the base material that can be overridden in material instances.</summary>
        [StructLayout( LayoutKind.Explicit, Size=20 )]
        public unsafe struct MaterialInstanceBasePropertyOverrides {
            [FieldOffset(0)] public bool bOverride_OpacityMaskClipValue;

            [FieldOffset(1)] public bool bOverride_BlendMode;

            [FieldOffset(2)] public bool bOverride_ShadingModel;

            [FieldOffset(3)] public bool bOverride_DitheredLODTransition;

            [FieldOffset(4)] public bool bOverride_CastDynamicShadowAsMasked;

            [FieldOffset(5)] public bool bOverride_TwoSided;

            [FieldOffset(8)] public float OpacityMaskClipValue;

            [FieldOffset(12)] public byte BlendMode;

            [FieldOffset(13)] public byte ShadingModel;

            [FieldOffset(16)] public bool TwoSided;

            [FieldOffset(16)] public bool DitheredLODTransition;

            [FieldOffset(16)] public bool bCastDynamicShadowAsMasked;

        }
}
