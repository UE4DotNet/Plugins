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
        ///<summary>Defines FRotator oscillation.</summary>
        [StructLayout( LayoutKind.Explicit, Size=36 )]
        public unsafe struct ROscillator {
            ///<summary>Pitch oscillation.</summary>
            [FieldOffset(0)] FOscillator Pitch;

            ///<summary>Yaw oscillation.</summary>
            [FieldOffset(12)] FOscillator Yaw;

            ///<summary>Roll oscillation.</summary>
            [FieldOffset(24)] FOscillator Roll;

        }
}
