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
        ///<summary>Material Parameter Info</summary>
        [StructLayout( LayoutKind.Explicit, Size=20 )]
        public unsafe struct MaterialParameterInfo {
            [FieldOffset(0)] public Name Name;

            [FieldOffset(12)] public byte Association;

            [FieldOffset(16)] public int Index;

        }
}
