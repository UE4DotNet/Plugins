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
        ///<summary>Struct that represents an expression's output.</summary>
        [StructLayout( LayoutKind.Explicit, Size=32 )]
        public unsafe struct ExpressionOutput {
            [FieldOffset(0)] public Name OutputName;

            [FieldOffset(12)] public int Mask;

            [FieldOffset(16)] public int MaskR;

            [FieldOffset(20)] public int MaskG;

            [FieldOffset(24)] public int MaskB;

            [FieldOffset(28)] public int MaskA;

        }
}
