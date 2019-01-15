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


namespace UE4.Engine.Native {
    [StructLayout( LayoutKind.Explicit, Size=264 )]
    internal unsafe struct AvoidanceManager_fields {
        [FieldOffset(64)] public float DefaultTimeToLive;
        [FieldOffset(68)] public float LockTimeAfterAvoid;
        [FieldOffset(72)] public float LockTimeAfterClean;
        [FieldOffset(76)] public float DeltaTimeToPredict;
        [FieldOffset(80)] public float ArtificialRadiusExpansion;
        [FieldOffset(88)] public float HeightCheckMargin;
    }
    internal unsafe struct AvoidanceManager_methods {
        internal struct GetAvoidanceVelocityForComponent_method {
            static internal IntPtr GetAvoidanceVelocityForComponent_ptr;
            static GetAvoidanceVelocityForComponent_method() {
                GetAvoidanceVelocityForComponent_ptr = Main.GetMethodUFunction(AvoidanceManager.StaticClass, "GetAvoidanceVelocityForComponent");
            }

            internal static unsafe Vector Invoke(IntPtr obj, MovementComponent MovementComp) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = MovementComp;
                Main.GetProcessEvent(obj, GetAvoidanceVelocityForComponent_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+8));
            }
        }
        internal struct GetNewAvoidanceUID_method {
            static internal IntPtr GetNewAvoidanceUID_ptr;
            static GetNewAvoidanceUID_method() {
                GetNewAvoidanceUID_ptr = Main.GetMethodUFunction(AvoidanceManager.StaticClass, "GetNewAvoidanceUID");
            }

            internal static unsafe int Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetNewAvoidanceUID_ptr, new IntPtr(p)); ;
                return *((int*)(b+0));
            }
        }
        internal struct GetObjectCount_method {
            static internal IntPtr GetObjectCount_ptr;
            static GetObjectCount_method() {
                GetObjectCount_ptr = Main.GetMethodUFunction(AvoidanceManager.StaticClass, "GetObjectCount");
            }

            internal static unsafe int Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetObjectCount_ptr, new IntPtr(p)); ;
                return *((int*)(b+0));
            }
        }
        internal struct RegisterMovementComponent_method {
            static internal IntPtr RegisterMovementComponent_ptr;
            static RegisterMovementComponent_method() {
                RegisterMovementComponent_ptr = Main.GetMethodUFunction(AvoidanceManager.StaticClass, "RegisterMovementComponent");
            }

            internal static unsafe bool Invoke(IntPtr obj, MovementComponent MovementComp, float AvoidanceWeight) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = MovementComp;
                *((float*)(b+8)) = AvoidanceWeight;
                Main.GetProcessEvent(obj, RegisterMovementComponent_ptr, new IntPtr(p)); ;
                return *((bool*)(b+12));
            }
        }
    }
    internal unsafe struct AvoidanceManager_events {
    }
}
