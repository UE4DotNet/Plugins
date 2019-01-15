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
        ///<summary>MoveToDynamicForce moves the target to a given location in world space over the duration, where the end location</summary>
        ///<remarks>is dynamic and can change during the move (meant to be used for things like moving to a moving target)</remarks>
        [StructLayout( LayoutKind.Explicit, Size=208 )]
        public unsafe struct RootMotionSource_MoveToDynamicForce {
            ///<summary>Start Location</summary>
            [FieldOffset(152)] Vector StartLocation;

            ///<summary>Initial Target Location</summary>
            [FieldOffset(164)] Vector InitialTargetLocation;

            ///<summary>Target Location</summary>
            [FieldOffset(176)] Vector TargetLocation;

            [FieldOffset(188)] public bool bRestrictSpeedToExpected;

            [FieldOffset(192)] 
            private IntPtr  PathOffsetCurve_field;
            ///<summary>Path Offset Curve</summary>
            public CurveVector PathOffsetCurve {
                get {return PathOffsetCurve_field;}
                set {PathOffsetCurve_field = value;}
            }

            [FieldOffset(200)] 
            private IntPtr  TimeMappingCurve_field;
            ///<summary>Time Mapping Curve</summary>
            public CurveFloat TimeMappingCurve {
                get {return TimeMappingCurve_field;}
                set {TimeMappingCurve_field = value;}
            }

        }
}
