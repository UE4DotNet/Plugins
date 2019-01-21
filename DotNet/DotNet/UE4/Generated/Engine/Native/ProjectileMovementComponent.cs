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
    [StructLayout( LayoutKind.Explicit, Size=512 )]
    internal unsafe struct ProjectileMovementComponent_fields {
        [FieldOffset(320)] public float InitialSpeed;
        [FieldOffset(324)] public float MaxSpeed;
        [FieldOffset(328)] public bool bRotationFollowsVelocity;
        [FieldOffset(328)] public bool bShouldBounce;
        [FieldOffset(328)] public bool bInitialVelocityInLocalSpace;
        [FieldOffset(328)] public bool bForceSubStepping;
        [FieldOffset(328)] public bool bSimulationEnabled;
        [FieldOffset(328)] public bool bSweepCollision;
        [FieldOffset(328)] public bool bIsHomingProjectile;
        [FieldOffset(328)] public bool bBounceAngleAffectsFriction;
        [FieldOffset(329)] public bool bIsSliding;
        [FieldOffset(329)] public bool bInterpMovement;
        [FieldOffset(329)] public bool bInterpRotation;
        [FieldOffset(332)] public float PreviousHitTime;
        [FieldOffset(336)] public Vector PreviousHitNormal;
        [FieldOffset(348)] public float ProjectileGravityScale;
        [FieldOffset(352)] public float Buoyancy;
        [FieldOffset(356)] public float Bounciness;
        [FieldOffset(360)] public float Friction;
        [FieldOffset(364)] public float BounceVelocityStopSimulatingThreshold;
        [FieldOffset(368)] public float MinFrictionFraction;
        [FieldOffset(376)] byte OnProjectileBounce; //TODO: multicast delegate FOnProjectileBounceDelegate OnProjectileBounce
        [FieldOffset(392)] byte OnProjectileStop; //TODO: multicast delegate FOnProjectileStopDelegate OnProjectileStop
        [FieldOffset(408)] public float HomingAccelerationMagnitude;
        [FieldOffset(412)] byte HomingTargetComponent; //TODO: weak object TWeakObjectPtr<USceneComponent> HomingTargetComponent
        [FieldOffset(420)] public float MaxSimulationTimeStep;
        [FieldOffset(424)] public int MaxSimulationIterations;
        [FieldOffset(428)] public int BounceAdditionalIterations;
        [FieldOffset(432)] public float InterpLocationTime;
        [FieldOffset(436)] public float InterpRotationTime;
        [FieldOffset(440)] public float InterpLocationMaxLagDistance;
        [FieldOffset(444)] public float InterpLocationSnapToTargetDistance;
    }
    internal unsafe struct ProjectileMovementComponent_methods {
        internal struct IsInterpolationComplete_method {
            static internal IntPtr IsInterpolationComplete_ptr;
            static IsInterpolationComplete_method() {
                IsInterpolationComplete_ptr = Main.GetMethodUFunction(ProjectileMovementComponent.StaticClass, "IsInterpolationComplete");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsInterpolationComplete_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsVelocityUnderSimulationThreshold_method {
            static internal IntPtr IsVelocityUnderSimulationThreshold_ptr;
            static IsVelocityUnderSimulationThreshold_method() {
                IsVelocityUnderSimulationThreshold_ptr = Main.GetMethodUFunction(ProjectileMovementComponent.StaticClass, "IsVelocityUnderSimulationThreshold");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsVelocityUnderSimulationThreshold_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct LimitVelocity_method {
            static internal IntPtr LimitVelocity_ptr;
            static LimitVelocity_method() {
                LimitVelocity_ptr = Main.GetMethodUFunction(ProjectileMovementComponent.StaticClass, "LimitVelocity");
            }

            internal static unsafe Vector Invoke(IntPtr obj, Vector NewVelocity) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = NewVelocity;
                Main.GetProcessEvent(obj, LimitVelocity_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+12));
            }
        }
        internal struct MoveInterpolationTarget_method {
            static internal IntPtr MoveInterpolationTarget_ptr;
            static MoveInterpolationTarget_method() {
                MoveInterpolationTarget_ptr = Main.GetMethodUFunction(ProjectileMovementComponent.StaticClass, "MoveInterpolationTarget");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector NewLocation, Rotator NewRotation) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = NewLocation;
                *((Rotator*)(b+12)) = NewRotation;
                Main.GetProcessEvent(obj, MoveInterpolationTarget_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ResetInterpolation_method {
            static internal IntPtr ResetInterpolation_ptr;
            static ResetInterpolation_method() {
                ResetInterpolation_ptr = Main.GetMethodUFunction(ProjectileMovementComponent.StaticClass, "ResetInterpolation");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, ResetInterpolation_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetInterpolatedComponent_method {
            static internal IntPtr SetInterpolatedComponent_ptr;
            static SetInterpolatedComponent_method() {
                SetInterpolatedComponent_ptr = Main.GetMethodUFunction(ProjectileMovementComponent.StaticClass, "SetInterpolatedComponent");
            }

            internal static unsafe void Invoke(IntPtr obj, SceneComponent Component) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Component;
                Main.GetProcessEvent(obj, SetInterpolatedComponent_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetVelocityInLocalSpace_method {
            static internal IntPtr SetVelocityInLocalSpace_ptr;
            static SetVelocityInLocalSpace_method() {
                SetVelocityInLocalSpace_ptr = Main.GetMethodUFunction(ProjectileMovementComponent.StaticClass, "SetVelocityInLocalSpace");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector NewVelocity) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = NewVelocity;
                Main.GetProcessEvent(obj, SetVelocityInLocalSpace_ptr, new IntPtr(p)); ;
            }
        }
        internal struct StopSimulating_method {
            static internal IntPtr StopSimulating_ptr;
            static StopSimulating_method() {
                StopSimulating_ptr = Main.GetMethodUFunction(ProjectileMovementComponent.StaticClass, "StopSimulating");
            }

            internal static unsafe void Invoke(IntPtr obj, HitResult HitResult) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((HitResult*)(b+0)) = HitResult;
                Main.GetProcessEvent(obj, StopSimulating_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct ProjectileMovementComponent_events {
    }
}
