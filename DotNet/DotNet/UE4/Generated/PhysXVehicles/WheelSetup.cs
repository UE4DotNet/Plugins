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
        ///<summary>Vehicle-specific wheel setup</summary>
        [StructLayout( LayoutKind.Explicit, Size=40 )]
        public unsafe struct WheelSetup {
            ///<summary>The wheel class to use</summary>
            public SubclassOf<VehicleWheel> WheelClass {
                get {return WheelClass_class; }
                set {WheelClass_class = value; }
            }
            [FieldOffset(0)] private IntPtr WheelClass_class;

            [FieldOffset(8)] public Name BoneName;

            ///<summary>Additional offset to give the wheels for this axle.</summary>
            [FieldOffset(20)] Vector AdditionalOffset;

            [FieldOffset(32)] public bool bDisableSteering;

        }
}
