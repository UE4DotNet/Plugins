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


namespace UE4.ClothingSystemRuntime.Native {
    [StructLayout( LayoutKind.Explicit, Size=80 )]
    internal unsafe struct ClothingSimulationInteractorNv_fields {
    }
    internal unsafe struct ClothingSimulationInteractorNv_methods {
        internal struct DisableGravityOverride_method {
            static internal IntPtr DisableGravityOverride_ptr;
            static DisableGravityOverride_method() {
                DisableGravityOverride_ptr = Main.GetMethodUFunction(ClothingSimulationInteractorNv.StaticClass, "DisableGravityOverride");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, DisableGravityOverride_ptr, new IntPtr(p)); ;
            }
        }
        internal struct EnableGravityOverride_method {
            static internal IntPtr EnableGravityOverride_ptr;
            static EnableGravityOverride_method() {
                EnableGravityOverride_ptr = Main.GetMethodUFunction(ClothingSimulationInteractorNv.StaticClass, "EnableGravityOverride");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector InVector) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = InVector;
                Main.GetProcessEvent(obj, EnableGravityOverride_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetAnimDriveDamperStiffness_method {
            static internal IntPtr SetAnimDriveDamperStiffness_ptr;
            static SetAnimDriveDamperStiffness_method() {
                SetAnimDriveDamperStiffness_ptr = Main.GetMethodUFunction(ClothingSimulationInteractorNv.StaticClass, "SetAnimDriveDamperStiffness");
            }

            internal static unsafe void Invoke(IntPtr obj, float InStiffness) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = InStiffness;
                Main.GetProcessEvent(obj, SetAnimDriveDamperStiffness_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetAnimDriveSpringStiffness_method {
            static internal IntPtr SetAnimDriveSpringStiffness_ptr;
            static SetAnimDriveSpringStiffness_method() {
                SetAnimDriveSpringStiffness_ptr = Main.GetMethodUFunction(ClothingSimulationInteractorNv.StaticClass, "SetAnimDriveSpringStiffness");
            }

            internal static unsafe void Invoke(IntPtr obj, float InStiffness) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = InStiffness;
                Main.GetProcessEvent(obj, SetAnimDriveSpringStiffness_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct ClothingSimulationInteractorNv_events {
    }
}
