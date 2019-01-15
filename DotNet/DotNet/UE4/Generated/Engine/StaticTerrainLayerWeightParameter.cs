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
        ///<summary>Holds the information for a static switch parameter</summary>
        [StructLayout( LayoutKind.Explicit, Size=48 )]
        public unsafe struct StaticTerrainLayerWeightParameter {
            ///<summary>Parameter Info</summary>
            [FieldOffset(0)] MaterialParameterInfo ParameterInfo;

            [FieldOffset(20)] public bool bOverride;

            ///<summary>Expression GUID</summary>
            [FieldOffset(24)] FGuid ExpressionGUID;

            [FieldOffset(40)] public int WeightmapIndex;

            [FieldOffset(44)] public bool bWeightBasedBlend;

        }
}
