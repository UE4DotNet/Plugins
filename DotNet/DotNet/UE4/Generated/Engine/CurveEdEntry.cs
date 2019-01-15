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
        ///<summary>Information about a particule curve being viewed.</summary>
        ///<remarks>Property could be an FInterpCurve, a DistributionFloat or a DistributionVector</remarks>
        [StructLayout( LayoutKind.Explicit, Size=56 )]
        public unsafe struct CurveEdEntry {
            [FieldOffset(0)] 
            private IntPtr  CurveObject_field;
            ///<summary>Curve Object</summary>
            public UObject CurveObject {
                get {return CurveObject_field;}
                set {CurveObject_field = value;}
            }

            ///<summary>Curve Color</summary>
            [FieldOffset(8)] Color CurveColor;

            [FieldOffset(16)] byte CurveName; //TODO: string FString CurveName

            [FieldOffset(32)] public int bHideCurve;

            [FieldOffset(36)] public int bColorCurve;

            [FieldOffset(40)] public int bFloatingPointColorCurve;

            [FieldOffset(44)] public int bClamp;

            [FieldOffset(48)] public float ClampLow;

            [FieldOffset(52)] public float ClampHigh;

        }
}
