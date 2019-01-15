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
        ///<summary>Scalar Parameter Value</summary>
        [StructLayout( LayoutKind.Explicit, Size=160 )]
        public unsafe struct ScalarParameterValue {
            ///<summary>Atlas Data</summary>
            [FieldOffset(16)] ScalarParameterAtlasInstanceData AtlasData;

            ///<summary>Parameter Info</summary>
            [FieldOffset(120)] MaterialParameterInfo ParameterInfo;

            [FieldOffset(140)] public float ParameterValue;

            ///<summary>Expression GUID</summary>
            [FieldOffset(144)] FGuid ExpressionGUID;

        }
}
