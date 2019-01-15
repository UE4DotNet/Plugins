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

using UE4.Engine;

namespace UE4.Landscape{
        ///<summary>Layer Blend Input</summary>
        [StructLayout( LayoutKind.Explicit, Size=152 )]
        public unsafe struct LayerBlendInput {
            [FieldOffset(0)] public Name LayerName;

            [FieldOffset(12)] public byte BlendType;

            ///<summary>Defaults to 'ConstLayerInput' if not specified</summary>
            [FieldOffset(16)] ExpressionInput LayerInput;

            ///<summary>Defaults to 'ConstHeightInput' if not specified</summary>
            [FieldOffset(72)] ExpressionInput HeightInput;

            [FieldOffset(128)] public float PreviewWeight;

            ///<summary>only used if LayerInput is not hooked up</summary>
            [FieldOffset(132)] Vector ConstLayerInput;

            [FieldOffset(144)] public float ConstHeightInput;

        }
}
