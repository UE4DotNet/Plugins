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
        ///<summary>Struct that contains one entry for each vector interpolation performed by the timeline</summary>
        [StructLayout( LayoutKind.Explicit, Size=80 )]
        public unsafe struct TimelineFloatTrack {
            [FieldOffset(0)] 
            private IntPtr  FloatCurve_field;
            ///<summary>Float curve to be evaluated</summary>
            public CurveFloat FloatCurve {
                get {return FloatCurve_field;}
                set {FloatCurve_field = value;}
            }

            [FieldOffset(8)] byte InterpFunc; //TODO: delegate FOnTimelineFloat InterpFunc

            [FieldOffset(28)] public Name TrackName;

            [FieldOffset(40)] public Name FloatPropertyName;

            [FieldOffset(56)] 
            private IntPtr  FloatProperty_field;
            ///<summary>Cached float property pointer</summary>
            public FloatProperty FloatProperty {
                get {return FloatProperty_field;}
                set {FloatProperty_field = value;}
            }

        }
}
