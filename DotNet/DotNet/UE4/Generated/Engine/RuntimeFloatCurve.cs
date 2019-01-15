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
        ///<summary>Runtime Float Curve</summary>
        [StructLayout( LayoutKind.Explicit, Size=120 )]
        public unsafe struct RuntimeFloatCurve {
            ///<summary>Editor Curve Data</summary>
            [FieldOffset(0)] RichCurve EditorCurveData;

            [FieldOffset(112)] 
            private IntPtr  ExternalCurve_field;
            ///<summary>External Curve</summary>
            public CurveFloat ExternalCurve {
                get {return ExternalCurve_field;}
                set {ExternalCurve_field = value;}
            }

        }
}
