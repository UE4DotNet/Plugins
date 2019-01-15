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
        ///<summary>JumpForce moves the target in a jump-like manner (ends when landing, applied force is relative)</summary>
        [StructLayout( LayoutKind.Explicit, Size=208 )]
        public unsafe struct RootMotionSource_JumpForce {
            ///<summary>Rotation</summary>
            [FieldOffset(152)] Rotator Rotation;

            [FieldOffset(164)] public float Distance;

            [FieldOffset(168)] public float Height;

            [FieldOffset(172)] public bool bDisableTimeout;

            [FieldOffset(176)] 
            private IntPtr  PathOffsetCurve_field;
            ///<summary>Path Offset Curve</summary>
            public CurveVector PathOffsetCurve {
                get {return PathOffsetCurve_field;}
                set {PathOffsetCurve_field = value;}
            }

            [FieldOffset(184)] 
            private IntPtr  TimeMappingCurve_field;
            ///<summary>Time Mapping Curve</summary>
            public CurveFloat TimeMappingCurve {
                get {return TimeMappingCurve_field;}
                set {TimeMappingCurve_field = value;}
            }

        }
}
