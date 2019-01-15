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
        ///<summary>A named color</summary>
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        public unsafe struct NamedColor {
            ///<summary>Value</summary>
            [FieldOffset(0)] Color Value;

            [FieldOffset(4)] public Name Name;

        }
}
