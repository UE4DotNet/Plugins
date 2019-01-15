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
        ///<summary>MoveToForce moves the target to a given fixed location in world space over the duration</summary>
        [StructLayout( LayoutKind.Explicit, Size=192 )]
        public unsafe struct RootMotionSource_MoveToForce {
            ///<summary>Start Location</summary>
            [FieldOffset(152)] Vector StartLocation;

            ///<summary>Target Location</summary>
            [FieldOffset(164)] Vector TargetLocation;

            [FieldOffset(176)] public bool bRestrictSpeedToExpected;

            [FieldOffset(184)] 
            private IntPtr  PathOffsetCurve_field;
            ///<summary>Path Offset Curve</summary>
            public CurveVector PathOffsetCurve {
                get {return PathOffsetCurve_field;}
                set {PathOffsetCurve_field = value;}
            }

        }
}
