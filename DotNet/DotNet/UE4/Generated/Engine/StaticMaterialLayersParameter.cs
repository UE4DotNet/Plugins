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
        ///<summary>Holds the information for a static material layers parameter</summary>
        [StructLayout( LayoutKind.Explicit, Size=160 )]
        public unsafe struct StaticMaterialLayersParameter {
            ///<summary>Parameter Info</summary>
            [FieldOffset(0)] MaterialParameterInfo ParameterInfo;

            ///<summary>Value</summary>
            [FieldOffset(24)] MaterialLayersFunctions Value;

            [FieldOffset(136)] public bool bOverride;

            ///<summary>Expression GUID</summary>
            [FieldOffset(140)] FGuid ExpressionGUID;

        }
}
