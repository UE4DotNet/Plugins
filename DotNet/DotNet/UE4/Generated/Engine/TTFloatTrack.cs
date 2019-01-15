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
        ///<summary>Structure storing information about one float interpolation track</summary>
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        public unsafe struct TTFloatTrack {
            [FieldOffset(16)] 
            private IntPtr  CurveFloat_field;
            ///<summary>Curve object used to define float value over time</summary>
            public CurveFloat CurveFloat {
                get {return CurveFloat_field;}
                set {CurveFloat_field = value;}
            }

        }
}
