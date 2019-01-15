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
        ///<summary>Editable vector parameter.</summary>
        [StructLayout( LayoutKind.Explicit, Size=64 )]
        public unsafe struct VectorParameterValue {
            ///<summary>Parameter Info</summary>
            [FieldOffset(12)] MaterialParameterInfo ParameterInfo;

            ///<summary>Parameter Value</summary>
            [FieldOffset(32)] LinearColor ParameterValue;

            ///<summary>Expression GUID</summary>
            [FieldOffset(48)] FGuid ExpressionGUID;

        }
}
