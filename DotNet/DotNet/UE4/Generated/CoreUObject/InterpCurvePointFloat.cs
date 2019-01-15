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
        ///<summary>Interp Curve Point Float</summary>
        [StructLayout( LayoutKind.Explicit, Size=20 )]
        public unsafe struct InterpCurvePointFloat {
            [FieldOffset(0)] public float InVal;

            [FieldOffset(4)] public float OutVal;

            [FieldOffset(8)] public float ArriveTangent;

            [FieldOffset(12)] public float LeaveTangent;

            [FieldOffset(16)] public byte InterpMode;

        }
}
