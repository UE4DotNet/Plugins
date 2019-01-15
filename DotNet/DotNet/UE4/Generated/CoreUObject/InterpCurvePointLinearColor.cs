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
        ///<summary>Interp Curve Point Linear Color</summary>
        [StructLayout( LayoutKind.Explicit, Size=56 )]
        public unsafe struct InterpCurvePointLinearColor {
            [FieldOffset(0)] public float InVal;

            ///<summary>Out Val</summary>
            [FieldOffset(4)] LinearColor OutVal;

            ///<summary>Arrive Tangent</summary>
            [FieldOffset(20)] LinearColor ArriveTangent;

            ///<summary>Leave Tangent</summary>
            [FieldOffset(36)] LinearColor LeaveTangent;

            [FieldOffset(52)] public byte InterpMode;

        }
}
