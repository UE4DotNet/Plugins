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
    [StructLayout( LayoutKind.Explicit, Size=408 )]
    internal unsafe struct NavMovementComponent_fields {
        [FieldOffset(328)] public NavAgentProperties NavAgentProps;
        [FieldOffset(384)] public float FixedPathBrakingDistance;
        [FieldOffset(388)] public bool bUpdateNavAgentWithOwnersCollision;
        [FieldOffset(388)] public bool bUseAccelerationForPaths;
        [FieldOffset(388)] public bool bUseFixedBrakingDistanceForPaths;
        [FieldOffset(392)]  public IntPtr  PathFollowingComp;
        [FieldOffset(400)] public MovementProperties MovementState;
    }
    internal unsafe struct NavMovementComponent_methods {
        internal struct IsCrouching_method {
            static internal IntPtr IsCrouching_ptr;
            static IsCrouching_method() {
                IsCrouching_ptr = Main.GetMethodUFunction(NavMovementComponent.StaticClass, "IsCrouching");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsCrouching_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsFalling_method {
            static internal IntPtr IsFalling_ptr;
            static IsFalling_method() {
                IsFalling_ptr = Main.GetMethodUFunction(NavMovementComponent.StaticClass, "IsFalling");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsFalling_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsFlying_method {
            static internal IntPtr IsFlying_ptr;
            static IsFlying_method() {
                IsFlying_ptr = Main.GetMethodUFunction(NavMovementComponent.StaticClass, "IsFlying");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsFlying_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsMovingOnGround_method {
            static internal IntPtr IsMovingOnGround_ptr;
            static IsMovingOnGround_method() {
                IsMovingOnGround_ptr = Main.GetMethodUFunction(NavMovementComponent.StaticClass, "IsMovingOnGround");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsMovingOnGround_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsSwimming_method {
            static internal IntPtr IsSwimming_ptr;
            static IsSwimming_method() {
                IsSwimming_ptr = Main.GetMethodUFunction(NavMovementComponent.StaticClass, "IsSwimming");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsSwimming_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct StopActiveMovement_method {
            static internal IntPtr StopActiveMovement_ptr;
            static StopActiveMovement_method() {
                StopActiveMovement_ptr = Main.GetMethodUFunction(NavMovementComponent.StaticClass, "StopActiveMovement");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, StopActiveMovement_ptr, new IntPtr(p)); ;
            }
        }
        internal struct StopMovementKeepPathing_method {
            static internal IntPtr StopMovementKeepPathing_ptr;
            static StopMovementKeepPathing_method() {
                StopMovementKeepPathing_ptr = Main.GetMethodUFunction(NavMovementComponent.StaticClass, "StopMovementKeepPathing");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, StopMovementKeepPathing_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct NavMovementComponent_events {
    }
}
