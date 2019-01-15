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

using UE4.Engine;

namespace UE4.PhysXVehicles{
        ///<summary>Vehicle Engine Data</summary>
        [StructLayout( LayoutKind.Explicit, Size=144 )]
        public unsafe struct VehicleEngineData {
            ///<summary>Torque (Nm) at a given RPM</summary>
            [FieldOffset(0)] RuntimeFloatCurve TorqueCurve;

            [FieldOffset(120)] public float MaxRPM;

            [FieldOffset(124)] public float MOI;

            [FieldOffset(128)] public float DampingRateFullThrottle;

            [FieldOffset(132)] public float DampingRateZeroThrottleClutchEngaged;

            [FieldOffset(136)] public float DampingRateZeroThrottleClutchDisengaged;

        }
}
