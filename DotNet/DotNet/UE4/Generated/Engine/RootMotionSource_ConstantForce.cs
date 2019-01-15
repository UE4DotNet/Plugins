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
        ///<summary>ConstantForce applies a fixed force to the target</summary>
        [StructLayout( LayoutKind.Explicit, Size=176 )]
        public unsafe struct RootMotionSource_ConstantForce {
            ///<summary>Force</summary>
            [FieldOffset(152)] Vector Force;

            [FieldOffset(168)] 
            private IntPtr  StrengthOverTime_field;
            ///<summary>Strength Over Time</summary>
            public CurveFloat StrengthOverTime {
                get {return StrengthOverTime_field;}
                set {StrengthOverTime_field = value;}
            }

        }
}
