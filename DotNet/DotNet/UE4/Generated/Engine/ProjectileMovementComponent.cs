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

#pragma warning disable CS0108
using UE4.Engine.Native;

namespace UE4.Engine {
    ///<summary>ProjectileMovementComponent updates the position of another component during its tick.</summary>
    ///<remarks>
    ///Behavior such as bouncing after impacts and homing toward a target are supported.
    ///
    ///Normally the root component of the owning actor is moved, however another component may be selected (see SetUpdatedComponent()).
    ///If the updated component is simulating physics, only the initial launch parameters (when initial velocity is non-zero)
    ///will affect the projectile, and the physics sim will take over from there.
    ///
    ///@see UMovementComponent
    ///</remarks>
    public unsafe partial class ProjectileMovementComponent : MovementComponent  {

        ///<summary>Don't allow velocity magnitude to exceed MaxSpeed, if MaxSpeed is non-zero.</summary>
        public Vector LimitVelocity(Vector NewVelocity)  => 
            ProjectileMovementComponent_methods.LimitVelocity_method.Invoke(ObjPointer, NewVelocity);

        ///<summary>Sets the velocity to the new value, rotated into Actor space.</summary>
        public void SetVelocityInLocalSpace(Vector NewVelocity)  => 
            ProjectileMovementComponent_methods.SetVelocityInLocalSpace_method.Invoke(ObjPointer, NewVelocity);

        ///<summary>Clears the reference to UpdatedComponent, fires stop event (OnProjectileStop), and stops ticking (if bAutoUpdateTickRegistration is true).</summary>
        public void StopSimulating(HitResult HitResult)  => 
            ProjectileMovementComponent_methods.StopSimulating_method.Invoke(ObjPointer, HitResult);
        ///<summary>Initial speed of projectile. If greater than zero, this will override the initial Velocity value and instead treat Velocity as a direction.</summary>
        public unsafe float InitialSpeed {
            get {return ProjectileMovementComponent_ptr->InitialSpeed;}
            set {ProjectileMovementComponent_ptr->InitialSpeed = value;}
        }
        ///<summary>Limit on speed of projectile (0 means no limit).</summary>
        public unsafe float MaxSpeed {
            get {return ProjectileMovementComponent_ptr->MaxSpeed;}
            set {ProjectileMovementComponent_ptr->MaxSpeed = value;}
        }
        public bool bRotationFollowsVelocity {
            get {return Main.GetGetBoolPropertyByName(this, "bRotationFollowsVelocity"); }
            set {Main.SetGetBoolPropertyByName(this, "bRotationFollowsVelocity", value); }
        }
        public bool bShouldBounce {
            get {return Main.GetGetBoolPropertyByName(this, "bShouldBounce"); }
            set {Main.SetGetBoolPropertyByName(this, "bShouldBounce", value); }
        }
        public bool bInitialVelocityInLocalSpace {
            get {return Main.GetGetBoolPropertyByName(this, "bInitialVelocityInLocalSpace"); }
            set {Main.SetGetBoolPropertyByName(this, "bInitialVelocityInLocalSpace", value); }
        }
        public bool bForceSubStepping {
            get {return Main.GetGetBoolPropertyByName(this, "bForceSubStepping"); }
            set {Main.SetGetBoolPropertyByName(this, "bForceSubStepping", value); }
        }
        public bool bIsHomingProjectile {
            get {return Main.GetGetBoolPropertyByName(this, "bIsHomingProjectile"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsHomingProjectile", value); }
        }
        public bool bBounceAngleAffectsFriction {
            get {return Main.GetGetBoolPropertyByName(this, "bBounceAngleAffectsFriction"); }
            set {Main.SetGetBoolPropertyByName(this, "bBounceAngleAffectsFriction", value); }
        }
        public bool bIsSliding {
            get {return Main.GetGetBoolPropertyByName(this, "bIsSliding"); }
        }
        ///<summary>Saved HitResult Time (0 to 1) from previous simulation step. Equal to 1.0 when there was no impact.</summary>
        public unsafe float PreviousHitTime {
            get {return ProjectileMovementComponent_ptr->PreviousHitTime;}
        }
        ///<summary>Saved HitResult Normal from previous simulation step that resulted in an impact. If PreviousHitTime is 1.0, then the hit was not in the last step.</summary>
        public unsafe Vector PreviousHitNormal {
            get {return ProjectileMovementComponent_ptr->PreviousHitNormal;}
        }
        ///<summary>Custom gravity scale for this projectile. Set to 0 for no gravity.</summary>
        public unsafe float ProjectileGravityScale {
            get {return ProjectileMovementComponent_ptr->ProjectileGravityScale;}
            set {ProjectileMovementComponent_ptr->ProjectileGravityScale = value;}
        }
        ///<summary>Buoyancy of UpdatedComponent in fluid. 0.0=sinks as fast as in air, 1.0=neutral buoyancy</summary>
        public unsafe float Buoyancy {
            get {return ProjectileMovementComponent_ptr->Buoyancy;}
            set {ProjectileMovementComponent_ptr->Buoyancy = value;}
        }
        ///<summary>Percentage of velocity maintained after the bounce in the direction of the normal of impact (coefficient of restitution).</summary>
        ///<remarks>1.0 = no velocity lost, 0.0 = no bounce. Ignored if bShouldBounce is false.</remarks>
        public unsafe float Bounciness {
            get {return ProjectileMovementComponent_ptr->Bounciness;}
            set {ProjectileMovementComponent_ptr->Bounciness = value;}
        }
        ///<summary>Coefficient of friction, affecting the resistance to sliding along a surface.</summary>
        ///<remarks>
        ///Normal range is [0,1] : 0.0 = no friction, 1.0+ = very high friction.
        ///Also affects the percentage of velocity maintained after the bounce in the direction tangent to the normal of impact.
        ///Ignored if bShouldBounce is false.
        ///@see bBounceAngleAffectsFriction
        ///</remarks>
        public unsafe float Friction {
            get {return ProjectileMovementComponent_ptr->Friction;}
            set {ProjectileMovementComponent_ptr->Friction = value;}
        }
        ///<summary>If velocity is below this threshold after a bounce, stops simulating and triggers the OnProjectileStop event.</summary>
        ///<remarks>
        ///Ignored if bShouldBounce is false, in which case the projectile stops simulating on the first impact.
        ///@see StopSimulating(), OnProjectileStop
        ///</remarks>
        public unsafe float BounceVelocityStopSimulatingThreshold {
            get {return ProjectileMovementComponent_ptr->BounceVelocityStopSimulatingThreshold;}
            set {ProjectileMovementComponent_ptr->BounceVelocityStopSimulatingThreshold = value;}
        }
         //TODO: multicast delegate FOnProjectileBounceDelegate OnProjectileBounce
         //TODO: multicast delegate FOnProjectileStopDelegate OnProjectileStop
        ///<summary>The magnitude of our acceleration towards the homing target. Overall velocity magnitude will still be limited by MaxSpeed.</summary>
        public unsafe float HomingAccelerationMagnitude {
            get {return ProjectileMovementComponent_ptr->HomingAccelerationMagnitude;}
            set {ProjectileMovementComponent_ptr->HomingAccelerationMagnitude = value;}
        }
         //TODO: weak object TWeakObjectPtr<USceneComponent> HomingTargetComponent
        ///<summary>Max time delta for each discrete simulation step.</summary>
        ///<remarks>
        ///Lowering this value can address precision issues with fast-moving objects or complex collision scenarios, at the cost of performance.
        ///
        ///WARNING: if (MaxSimulationTimeStep * MaxSimulationIterations) is too low for the min framerate, the last simulation step may exceed MaxSimulationTimeStep to complete the simulation.
        ///@see MaxSimulationIterations, bForceSubStepping
        ///</remarks>
        public unsafe float MaxSimulationTimeStep {
            get {return ProjectileMovementComponent_ptr->MaxSimulationTimeStep;}
            set {ProjectileMovementComponent_ptr->MaxSimulationTimeStep = value;}
        }
        ///<summary>Max number of iterations used for each discrete simulation step.</summary>
        ///<remarks>
        ///Increasing this value can address precision issues with fast-moving objects or complex collision scenarios, at the cost of performance.
        ///
        ///WARNING: if (MaxSimulationTimeStep * MaxSimulationIterations) is too low for the min framerate, the last simulation step may exceed MaxSimulationTimeStep to complete the simulation.
        ///@see MaxSimulationTimeStep, bForceSubStepping
        ///</remarks>
        public unsafe int MaxSimulationIterations {
            get {return ProjectileMovementComponent_ptr->MaxSimulationIterations;}
            set {ProjectileMovementComponent_ptr->MaxSimulationIterations = value;}
        }
        ///<summary>On the first few bounces (up to this amount), allow extra iterations over MaxSimulationIterations if necessary.</summary>
        public unsafe int BounceAdditionalIterations {
            get {return ProjectileMovementComponent_ptr->BounceAdditionalIterations;}
            set {ProjectileMovementComponent_ptr->BounceAdditionalIterations = value;}
        }
        static ProjectileMovementComponent() {
            StaticClass = Main.GetClass("ProjectileMovementComponent");
        }
        internal unsafe ProjectileMovementComponent_fields* ProjectileMovementComponent_ptr => (ProjectileMovementComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ProjectileMovementComponent(IntPtr p) => UObject.Make<ProjectileMovementComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ProjectileMovementComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ProjectileMovementComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
