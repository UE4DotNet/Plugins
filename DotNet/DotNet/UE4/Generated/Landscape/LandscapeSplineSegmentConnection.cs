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
        ///<summary>Landscape Spline Segment Connection</summary>
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        public unsafe struct LandscapeSplineSegmentConnection {
            [FieldOffset(0)] 
            private IntPtr  ControlPoint_field;
            ///<summary>Control point connected to this end of the segment</summary>
            public LandscapeSplineControlPoint ControlPoint {
                get {return ControlPoint_field;}
                set {ControlPoint_field = value;}
            }

            [FieldOffset(8)] public float TangentLen;

            [FieldOffset(12)] public Name SocketName;

        }
}
