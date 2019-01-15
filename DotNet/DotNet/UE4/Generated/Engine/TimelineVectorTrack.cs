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
        public unsafe struct TimelineVectorTrack {
            [FieldOffset(0)] 
            private IntPtr  VectorCurve_field;
            ///<summary>Vector curve to be evaluated</summary>
            public CurveVector VectorCurve {
                get {return VectorCurve_field;}
                set {VectorCurve_field = value;}
            }

            [FieldOffset(8)] byte InterpFunc; //TODO: delegate FOnTimelineVector InterpFunc

            [FieldOffset(28)] public Name TrackName;

            [FieldOffset(40)] public Name VectorPropertyName;

            [FieldOffset(56)] 
            private IntPtr  VectorProperty_field;
            ///<summary>Cached vector struct property pointer</summary>
            public StructProperty VectorProperty {
                get {return VectorProperty_field;}
                set {VectorProperty_field = value;}
            }

        }
}
