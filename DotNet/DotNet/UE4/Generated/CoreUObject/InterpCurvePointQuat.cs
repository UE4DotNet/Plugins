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
        ///<summary>Interp Curve Point Quat</summary>
        [StructLayout( LayoutKind.Explicit, Size=80 )]
        public unsafe struct InterpCurvePointQuat {
            [FieldOffset(0)] public float InVal;

            ///<summary>Out Val</summary>
            [FieldOffset(16)] Quat OutVal;

            ///<summary>Arrive Tangent</summary>
            [FieldOffset(32)] Quat ArriveTangent;

            ///<summary>Leave Tangent</summary>
            [FieldOffset(48)] Quat LeaveTangent;

            [FieldOffset(64)] public byte InterpMode;

        }
}
