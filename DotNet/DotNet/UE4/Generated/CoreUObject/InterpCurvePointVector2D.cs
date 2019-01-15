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
        ///<summary>Interp Curve Point Vector 2D</summary>
        [StructLayout( LayoutKind.Explicit, Size=32 )]
        public unsafe struct InterpCurvePointVector2D {
            [FieldOffset(0)] public float InVal;

            ///<summary>Out Val</summary>
            [FieldOffset(4)] Vector2D OutVal;

            ///<summary>Arrive Tangent</summary>
            [FieldOffset(12)] Vector2D ArriveTangent;

            ///<summary>Leave Tangent</summary>
            [FieldOffset(20)] Vector2D LeaveTangent;

            [FieldOffset(28)] public byte InterpMode;

        }
}
