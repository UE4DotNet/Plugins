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
        ///<summary>Structure storing information about one color interpolation track</summary>
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        public unsafe struct TTLinearColorTrack {
            [FieldOffset(16)] 
            private IntPtr  CurveLinearColor_field;
            ///<summary>Curve object used to define color value over time</summary>
            public CurveLinearColor CurveLinearColor {
                get {return CurveLinearColor_field;}
                set {CurveLinearColor_field = value;}
            }

        }
}
