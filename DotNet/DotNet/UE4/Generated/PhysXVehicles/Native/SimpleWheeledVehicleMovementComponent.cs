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
    [StructLayout( LayoutKind.Explicit, Size=744 )]
    internal unsafe struct SimpleWheeledVehicleMovementComponent_fields {
    }
    internal unsafe struct SimpleWheeledVehicleMovementComponent_methods {
        internal struct SetBrakeTorque_method {
            static internal IntPtr SetBrakeTorque_ptr;
            static SetBrakeTorque_method() {
                SetBrakeTorque_ptr = Main.GetMethodUFunction(SimpleWheeledVehicleMovementComponent.StaticClass, "SetBrakeTorque");
            }

            internal static unsafe void Invoke(IntPtr obj, float BrakeTorque, int WheelIndex) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = BrakeTorque;
                *((int*)(b+4)) = WheelIndex;
                Main.GetProcessEvent(obj, SetBrakeTorque_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetDriveTorque_method {
            static internal IntPtr SetDriveTorque_ptr;
            static SetDriveTorque_method() {
                SetDriveTorque_ptr = Main.GetMethodUFunction(SimpleWheeledVehicleMovementComponent.StaticClass, "SetDriveTorque");
            }

            internal static unsafe void Invoke(IntPtr obj, float DriveTorque, int WheelIndex) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = DriveTorque;
                *((int*)(b+4)) = WheelIndex;
                Main.GetProcessEvent(obj, SetDriveTorque_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetSteerAngle_method {
            static internal IntPtr SetSteerAngle_ptr;
            static SetSteerAngle_method() {
                SetSteerAngle_ptr = Main.GetMethodUFunction(SimpleWheeledVehicleMovementComponent.StaticClass, "SetSteerAngle");
            }

            internal static unsafe void Invoke(IntPtr obj, float SteerAngle, int WheelIndex) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = SteerAngle;
                *((int*)(b+4)) = WheelIndex;
                Main.GetProcessEvent(obj, SetSteerAngle_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct SimpleWheeledVehicleMovementComponent_events {
    }
}
