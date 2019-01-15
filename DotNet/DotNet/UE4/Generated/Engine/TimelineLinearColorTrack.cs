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
        ///<summary>Struct that contains one entry for each linear color interpolation performed by the timeline</summary>
        [StructLayout( LayoutKind.Explicit, Size=80 )]
        public unsafe struct TimelineLinearColorTrack {
            [FieldOffset(0)] 
            private IntPtr  LinearColorCurve_field;
            ///<summary>Float curve to be evaluated</summary>
            public CurveLinearColor LinearColorCurve {
                get {return LinearColorCurve_field;}
                set {LinearColorCurve_field = value;}
            }

            [FieldOffset(8)] byte InterpFunc; //TODO: delegate FOnTimelineLinearColor InterpFunc

            [FieldOffset(28)] public Name TrackName;

            [FieldOffset(40)] public Name LinearColorPropertyName;

            [FieldOffset(56)] 
            private IntPtr  LinearColorProperty_field;
            ///<summary>Cached linear color struct property pointer</summary>
            public StructProperty LinearColorProperty {
                get {return LinearColorProperty_field;}
                set {LinearColorProperty_field = value;}
            }

        }
}
