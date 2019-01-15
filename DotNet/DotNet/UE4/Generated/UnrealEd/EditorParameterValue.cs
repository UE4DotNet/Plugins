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

namespace UE4.UnrealEd{
        ///<summary>Editor Parameter Value</summary>
        [StructLayout( LayoutKind.Explicit, Size=40 )]
        public unsafe struct EditorParameterValue {
            [FieldOffset(0)] public bool bOverride;

            ///<summary>Parameter Info</summary>
            [FieldOffset(4)] MaterialParameterInfo ParameterInfo;

            ///<summary>Expression Id</summary>
            [FieldOffset(24)] FGuid ExpressionId;

        }
}
