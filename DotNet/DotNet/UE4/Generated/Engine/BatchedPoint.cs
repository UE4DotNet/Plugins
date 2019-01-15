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
        ///<summary>Batched Point</summary>
        [StructLayout( LayoutKind.Explicit, Size=40 )]
        public unsafe struct BatchedPoint {
            ///<summary>Position</summary>
            [FieldOffset(0)] Vector Position;

            ///<summary>Color</summary>
            [FieldOffset(12)] LinearColor Color;

            [FieldOffset(28)] public float PointSize;

            [FieldOffset(32)] public float RemainingLifeTime;

            [FieldOffset(36)] public byte DepthPriority;

        }
}
