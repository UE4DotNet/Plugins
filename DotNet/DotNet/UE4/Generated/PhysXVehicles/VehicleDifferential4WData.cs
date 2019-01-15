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


namespace UE4.PhysXVehicles{
        ///<summary>Vehicle Differential 4WData</summary>
        [StructLayout( LayoutKind.Explicit, Size=28 )]
        public unsafe struct VehicleDifferential4WData {
            [FieldOffset(0)] public byte DifferentialType;

            [FieldOffset(4)] public float FrontRearSplit;

            [FieldOffset(8)] public float FrontLeftRightSplit;

            [FieldOffset(12)] public float RearLeftRightSplit;

            [FieldOffset(16)] public float CentreBias;

            [FieldOffset(20)] public float FrontBias;

            [FieldOffset(24)] public float RearBias;

        }
}
