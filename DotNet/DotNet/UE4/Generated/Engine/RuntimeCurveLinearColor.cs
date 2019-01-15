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
        ///<summary>Runtime Curve Linear Color</summary>
        [StructLayout( LayoutKind.Explicit, Size=456 )]
        public unsafe struct RuntimeCurveLinearColor {
            ///<summary>Color Curves</summary>
            [FieldOffset(0)] RichCurve ColorCurves;

            [FieldOffset(448)] 
            private IntPtr  ExternalCurve_field;
            ///<summary>External Curve</summary>
            public CurveLinearColor ExternalCurve {
                get {return ExternalCurve_field;}
                set {ExternalCurve_field = value;}
            }

        }
}
