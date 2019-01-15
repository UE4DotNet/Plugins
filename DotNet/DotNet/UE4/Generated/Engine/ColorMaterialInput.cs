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
        ///<summary>Color Material Input</summary>
        [StructLayout( LayoutKind.Explicit, Size=64 )]
        public unsafe struct ColorMaterialInput {
            [FieldOffset(56)] public bool UseConstant;

            ///<summary>Constant</summary>
            [FieldOffset(60)] Color Constant;

        }
}
