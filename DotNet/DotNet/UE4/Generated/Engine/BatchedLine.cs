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
        ///<summary>Batched Line</summary>
        [StructLayout( LayoutKind.Explicit, Size=52 )]
        public unsafe struct BatchedLine {
            ///<summary>Start</summary>
            [FieldOffset(0)] Vector Start;

            ///<summary>End</summary>
            [FieldOffset(12)] Vector End;

            ///<summary>Color</summary>
            [FieldOffset(24)] LinearColor Color;

            [FieldOffset(40)] public float Thickness;

            [FieldOffset(44)] public float RemainingLifeTime;

            [FieldOffset(48)] public byte DepthPriority;

        }
}
