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
        ///<summary>One key in a rich, editable float curve</summary>
        [StructLayout( LayoutKind.Explicit, Size=28 )]
        public unsafe struct RichCurveKey {
            [FieldOffset(0)] public byte InterpMode;

            [FieldOffset(1)] public byte TangentMode;

            [FieldOffset(2)] public byte TangentWeightMode;

            [FieldOffset(4)] public float Time;

            [FieldOffset(8)] public float Value;

            [FieldOffset(12)] public float ArriveTangent;

            [FieldOffset(16)] public float ArriveTangentWeight;

            [FieldOffset(20)] public float LeaveTangent;

            [FieldOffset(24)] public float LeaveTangentWeight;

        }
}
