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


namespace UE4.Landscape{
        ///<summary>Landscape Spline Connection</summary>
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        public unsafe struct LandscapeSplineConnection {
            [FieldOffset(0)] 
            private IntPtr  Segment_field;
            ///<summary>Segment connected to this control point</summary>
            public LandscapeSplineSegment Segment {
                get {return Segment_field;}
                set {Segment_field = value;}
            }

            [FieldOffset(8)] public bool End;

        }
}
