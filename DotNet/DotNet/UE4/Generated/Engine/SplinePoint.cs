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
        ///<summary>Spline Point</summary>
        [StructLayout( LayoutKind.Explicit, Size=68 )]
        public unsafe struct SplinePoint {
            [FieldOffset(0)] public float InputKey;

            ///<summary>Position</summary>
            [FieldOffset(4)] Vector Position;

            ///<summary>Arrive Tangent</summary>
            [FieldOffset(16)] Vector ArriveTangent;

            ///<summary>Leave Tangent</summary>
            [FieldOffset(28)] Vector LeaveTangent;

            ///<summary>Rotation</summary>
            [FieldOffset(40)] Rotator Rotation;

            ///<summary>Scale</summary>
            [FieldOffset(52)] Vector Scale;

            [FieldOffset(64)] public byte Type;

        }
}
