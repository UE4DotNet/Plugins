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
        ///<summary>Simulated Root Motion Replicated Move</summary>
        [StructLayout( LayoutKind.Explicit, Size=360 )]
        public unsafe struct SimulatedRootMotionReplicatedMove {
            [FieldOffset(0)] public float Time;

            ///<summary>Root Motion information</summary>
            [FieldOffset(8)] RepRootMotionMontage RootMotion;

        }
}
