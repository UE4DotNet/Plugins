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

namespace UE4.PhysXVehicles.Native {
    [StructLayout( LayoutKind.Explicit, Size=1128 )]
    internal unsafe struct WheeledVehicleMovementComponent4W_fields {
        [FieldOffset(776)] public VehicleEngineData EngineSetup;
        [FieldOffset(920)] public VehicleDifferential4WData DifferentialSetup;
        [FieldOffset(952)] public VehicleTransmissionData TransmissionSetup;
        [FieldOffset(1000)] public RuntimeFloatCurve SteeringCurve;
        [FieldOffset(1120)] public float AckermannAccuracy;
    }
    internal unsafe struct WheeledVehicleMovementComponent4W_methods {
    }
    internal unsafe struct WheeledVehicleMovementComponent4W_events {
    }
}
