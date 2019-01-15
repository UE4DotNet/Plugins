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


namespace UE4.ClothingSystemRuntimeInterface.Native {
    [StructLayout( LayoutKind.Explicit, Size=64 )]
    internal unsafe struct ClothingSimulationInteractor_fields {
    }
    internal unsafe struct ClothingSimulationInteractor_methods {
        internal struct ClothConfigUpdated_method {
            static internal IntPtr ClothConfigUpdated_ptr;
            static ClothConfigUpdated_method() {
                ClothConfigUpdated_ptr = Main.GetMethodUFunction(ClothingSimulationInteractor.StaticClass, "ClothConfigUpdated");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, ClothConfigUpdated_ptr, new IntPtr(p)); ;
            }
        }
        internal struct PhysicsAssetUpdated_method {
            static internal IntPtr PhysicsAssetUpdated_ptr;
            static PhysicsAssetUpdated_method() {
                PhysicsAssetUpdated_ptr = Main.GetMethodUFunction(ClothingSimulationInteractor.StaticClass, "PhysicsAssetUpdated");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, PhysicsAssetUpdated_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct ClothingSimulationInteractor_events {
    }
}
