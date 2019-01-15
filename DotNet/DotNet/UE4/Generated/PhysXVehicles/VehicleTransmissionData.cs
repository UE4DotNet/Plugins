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
        ///<summary>Vehicle Transmission Data</summary>
        [StructLayout( LayoutKind.Explicit, Size=48 )]
        public unsafe struct VehicleTransmissionData {
            [FieldOffset(0)] public bool bUseGearAutoBox;

            [FieldOffset(4)] public float GearSwitchTime;

            [FieldOffset(8)] public float GearAutoBoxLatency;

            [FieldOffset(12)] public float FinalRatio;

            [FieldOffset(16)] byte ForwardGears; //TODO: array TArray ForwardGears

            [FieldOffset(32)] public float ReverseGearRatio;

            [FieldOffset(36)] public float NeutralGearUpRatio;

            [FieldOffset(40)] public float ClutchStrength;

        }
}
