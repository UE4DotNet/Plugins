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


namespace UE4.LocationServicesBPLibrary{
        ///<summary>Struct to hold relevant location data retrieved from the mobile implementation's Location Service</summary>
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        public unsafe struct LocationServicesData {
            [FieldOffset(0)] public float Timestamp;

            [FieldOffset(4)] public float Longitude;

            [FieldOffset(8)] public float Latitude;

            [FieldOffset(12)] public float HorizontalAccuracy;

            [FieldOffset(16)] public float VerticalAccuracy;

            [FieldOffset(20)] public float Altitude;

        }
}
