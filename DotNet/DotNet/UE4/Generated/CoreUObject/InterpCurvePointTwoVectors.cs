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


namespace UE4.CoreUObject{
        ///<summary>Interp Curve Point Two Vectors</summary>
        [StructLayout( LayoutKind.Explicit, Size=80 )]
        public unsafe struct InterpCurvePointTwoVectors {
            [FieldOffset(0)] public float InVal;

            ///<summary>Out Val</summary>
            [FieldOffset(4)] TwoVectors OutVal;

            ///<summary>Arrive Tangent</summary>
            [FieldOffset(28)] TwoVectors ArriveTangent;

            ///<summary>Leave Tangent</summary>
            [FieldOffset(52)] TwoVectors LeaveTangent;

            [FieldOffset(76)] public byte InterpMode;

        }
}
