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


namespace UE4.PhysXVehicles.Native {
    [StructLayout( LayoutKind.Explicit, Size=2544 )]
    internal unsafe struct VehicleAnimInstance_fields {
        [FieldOffset(2528)]  public IntPtr  WheeledVehicleMovementComponent;
    }
    internal unsafe struct VehicleAnimInstance_methods {
        internal struct GetVehicle_method {
            static internal IntPtr GetVehicle_ptr;
            static GetVehicle_method() {
                GetVehicle_ptr = Main.GetMethodUFunction(VehicleAnimInstance.StaticClass, "GetVehicle");
            }

            internal static unsafe WheeledVehicle Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetVehicle_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
    }
    internal unsafe struct VehicleAnimInstance_events {
    }
}
