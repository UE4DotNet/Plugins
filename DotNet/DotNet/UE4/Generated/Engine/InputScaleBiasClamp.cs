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
        ///<summary>Input Scale Bias Clamp</summary>
        [StructLayout( LayoutKind.Explicit, Size=48 )]
        public unsafe struct InputScaleBiasClamp {
            [FieldOffset(0)] public bool bMapRange;

            [FieldOffset(1)] public bool bClampResult;

            [FieldOffset(2)] public bool bInterpResult;

            [FieldOffset(3)] public bool bInitialized;

            ///<summary>In Range</summary>
            [FieldOffset(4)] InputRange InRange;

            ///<summary>Out Range</summary>
            [FieldOffset(12)] InputRange OutRange;

            [FieldOffset(20)] public float Scale;

            [FieldOffset(24)] public float Bias;

            [FieldOffset(28)] public float ClampMin;

            [FieldOffset(32)] public float ClampMax;

            [FieldOffset(36)] public float InterpSpeedIncreasing;

            [FieldOffset(40)] public float InterpSpeedDecreasing;

            [FieldOffset(44)] public float InterpolatedResult;

        }
}
