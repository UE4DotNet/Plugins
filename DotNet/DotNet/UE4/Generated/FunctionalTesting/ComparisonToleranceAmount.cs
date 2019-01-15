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


namespace UE4.FunctionalTesting{
        ///<summary>Comparison Tolerance Amount</summary>
        [StructLayout( LayoutKind.Explicit, Size=6 )]
        public unsafe struct ComparisonToleranceAmount {
            [FieldOffset(0)] public byte Red;

            [FieldOffset(1)] public byte Green;

            [FieldOffset(2)] public byte Blue;

            [FieldOffset(3)] public byte Alpha;

            [FieldOffset(4)] public byte MinBrightness;

            [FieldOffset(5)] public byte MaxBrightness;

        }
}
