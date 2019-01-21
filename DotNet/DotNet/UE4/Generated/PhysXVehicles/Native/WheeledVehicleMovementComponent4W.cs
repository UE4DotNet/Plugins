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
    [StructLayout( LayoutKind.Explicit, Size=1088 )]
    internal unsafe struct WheeledVehicleMovementComponent4W_fields {
        [FieldOffset(744)] public VehicleEngineData EngineSetup;
        [FieldOffset(888)] public VehicleDifferential4WData DifferentialSetup;
        [FieldOffset(916)] public float AckermannAccuracy;
        [FieldOffset(920)] public VehicleTransmissionData TransmissionSetup;
        [FieldOffset(968)] public RuntimeFloatCurve SteeringCurve;
    }
    internal unsafe struct WheeledVehicleMovementComponent4W_methods {
    }
    internal unsafe struct WheeledVehicleMovementComponent4W_events {
    }
}
