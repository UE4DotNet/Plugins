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
        ///<summary>Spline Curves</summary>
        [StructLayout( LayoutKind.Explicit, Size=96 )]
        public unsafe struct SplineCurves {
            ///<summary>Spline built from position data.</summary>
            [FieldOffset(0)] InterpCurveVector Position;

            ///<summary>Spline built from rotation data.</summary>
            [FieldOffset(24)] InterpCurveQuat Rotation;

            ///<summary>Spline built from scale data.</summary>
            [FieldOffset(48)] InterpCurveVector Scale;

            ///<summary>Input: distance along curve, output: parameter that puts you there.</summary>
            [FieldOffset(72)] InterpCurveFloat ReparamTable;

        }
}
