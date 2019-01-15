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


namespace UE4.AnimationCore{
        ///<summary>A description of how to apply aim constraint</summary>
        [StructLayout( LayoutKind.Explicit, Size=64 )]
        public unsafe struct AimConstraintDescription {
            ///<summary>Look at Axis</summary>
            [FieldOffset(16)] Axis LookAt_Axis;

            ///<summary>Look Up Axis</summary>
            [FieldOffset(32)] Axis LookUp_Axis;

            [FieldOffset(48)] public bool bUseLookUp;

            ///<summary>Look Up Target</summary>
            [FieldOffset(52)] Vector LookUpTarget;

        }
}
