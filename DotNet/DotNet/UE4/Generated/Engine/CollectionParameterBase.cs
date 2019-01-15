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
        ///<summary>Base struct for collection parameters</summary>
        [StructLayout( LayoutKind.Explicit, Size=28 )]
        public unsafe struct CollectionParameterBase {
            [FieldOffset(0)] public Name ParameterName;

            ///<summary>Uniquely identifies the parameter, used for fixing up materials that reference this parameter when renaming.</summary>
            [FieldOffset(12)] FGuid Id;

        }
}
