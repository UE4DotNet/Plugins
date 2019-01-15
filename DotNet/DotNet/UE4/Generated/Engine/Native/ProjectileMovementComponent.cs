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
    [StructLayout( LayoutKind.Explicit, Size=432 )]
    internal unsafe struct ProjectileMovementComponent_fields {
        [FieldOffset(328)] public float InitialSpeed;
        [FieldOffset(332)] public float MaxSpeed;
        [FieldOffset(336)] public bool bRotationFollowsVelocity;
        [FieldOffset(336)] public bool bShouldBounce;
        [FieldOffset(336)] public bool bInitialVelocityInLocalSpace;
        [FieldOffset(336)] public bool bForceSubStepping;
        [FieldOffset(336)] public bool bIsHomingProjectile;
        [FieldOffset(336)] public bool bBounceAngleAffectsFriction;
        [FieldOffset(336)] public bool bIsSliding;
        [FieldOffset(340)] public float PreviousHitTime;
        [FieldOffset(344)] public Vector PreviousHitNormal;
        [FieldOffset(356)] public float ProjectileGravityScale;
        [FieldOffset(360)] public float Buoyancy;
        [FieldOffset(364)] public float Bounciness;
        [FieldOffset(368)] public float Friction;
        [FieldOffset(372)] public float BounceVelocityStopSimulatingThreshold;
        [FieldOffset(376)] byte OnProjectileBounce; //TODO: multicast delegate FOnProjectileBounceDelegate OnProjectileBounce
        [FieldOffset(392)] byte OnProjectileStop; //TODO: multicast delegate FOnProjectileStopDelegate OnProjectileStop
        [FieldOffset(408)] public float HomingAccelerationMagnitude;
        [FieldOffset(412)] byte HomingTargetComponent; //TODO: weak object TWeakObjectPtr<USceneComponent> HomingTargetComponent
        [FieldOffset(420)] public float MaxSimulationTimeStep;
        [FieldOffset(424)] public int MaxSimulationIterations;
        [FieldOffset(428)] public int BounceAdditionalIterations;
    }
    internal unsafe struct ProjectileMovementComponent_methods {
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
