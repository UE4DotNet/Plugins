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
        ///<summary>Holds the information for a static component mask parameter</summary>
        [StructLayout( LayoutKind.Explicit, Size=44 )]
        public unsafe struct StaticComponentMaskParameter {
            ///<summary>Parameter Info</summary>
            [FieldOffset(0)] MaterialParameterInfo ParameterInfo;

            [FieldOffset(20)] public bool R;

            [FieldOffset(21)] public bool G;

            [FieldOffset(22)] public bool B;

            [FieldOffset(23)] public bool A;

            [FieldOffset(24)] public bool bOverride;

            ///<summary>Expression GUID</summary>
            [FieldOffset(28)] FGuid ExpressionGUID;

        }
}
