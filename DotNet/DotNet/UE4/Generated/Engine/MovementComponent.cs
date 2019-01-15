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
    ///<summary>MovementComponent is an abstract component class that defines functionality for moving a PrimitiveComponent (our UpdatedComponent) each tick.</summary>
    ///<remarks>
    ///Base functionality includes:
    ///   - Restricting movement to a plane or axis.
    ///   - Utility functions for special handling of collision results (SlideAlongSurface(), ComputeSlideVector(), TwoWallAdjust()).
    ///   - Utility functions for moving when there may be initial penetration (SafeMoveUpdatedComponent(), ResolvePenetration()).
    ///   - Automatically registering the component tick and finding a component to move on the owning Actor.
    ///Normally the root component of the owning actor is moved, however another component may be selected (see SetUpdatedComponent()).
    ///During swept (non-teleporting) movement only collision of UpdatedComponent is considered, attached components will teleport to the end location ignoring collision.
    ///</remarks>
    public unsafe partial class MovementComponent : ActorComponent  {

        ///<summary>Constrain a direction vector to the plane constraint, if enabled.</summary>
        ///<remarks>
        ///@see SetPlaneConstraint
        ///</remarks>
        public Vector ConstrainDirectionToPlane(Vector Direction)  => 
            MovementComponent_methods.ConstrainDirectionToPlane_method.Invoke(ObjPointer, Direction);

        ///<summary>Constrain a position vector to the plane constraint, if enabled.</summary>
        public Vector ConstrainLocationToPlane(Vector Location)  => 
            MovementComponent_methods.ConstrainLocationToPlane_method.Invoke(ObjPointer, Location);

        ///<summary>Constrain a normal vector (of unit length) to the plane constraint, if enabled.</summary>
        public Vector ConstrainNormalToPlane(Vector Normal)  => 
            MovementComponent_methods.ConstrainNormalToPlane_method.Invoke(ObjPointer, Normal);

        ///<summary>@return gravity that affects this component</summary>
        public float GetGravityZ()  => 
            MovementComponent_methods.GetGravityZ_method.Invoke(ObjPointer);

        ///<summary>@return Maximum speed of component in current movement mode.</summary>
        public float GetMaxSpeed()  => 
            MovementComponent_methods.GetMaxSpeed_method.Invoke(ObjPointer);

        ///<summary>@return PhysicsVolume this MovementComponent is using, or the world's default physics volume if none. *</summary>
        public PhysicsVolume GetPhysicsVolume()  => 
            MovementComponent_methods.GetPhysicsVolume_method.Invoke(ObjPointer);

        ///<summary>Get the plane constraint axis setting.</summary>
        public EPlaneConstraintAxisSetting GetPlaneConstraintAxisSetting()  => 
            MovementComponent_methods.GetPlaneConstraintAxisSetting_method.Invoke(ObjPointer);

        ///<summary>@return The normal of the plane that constrains movement, enforced if the plane constraint is enabled.</summary>
        public void GetPlaneConstraintNormal(Vector ReturnValue)  => 
            MovementComponent_methods.GetPlaneConstraintNormal_method.Invoke(ObjPointer, ReturnValue);

        ///<summary>Get the plane constraint origin.</summary>
        ///<remarks>
        ///This defines the behavior of snapping a position to the plane, such as by SnapUpdatedComponentToPlane().
        ///@return The origin of the plane that constrains movement, if the plane constraint is enabled.
        ///</remarks>
        public void GetPlaneConstraintOrigin(Vector ReturnValue)  => 
            MovementComponent_methods.GetPlaneConstraintOrigin_method.Invoke(ObjPointer, ReturnValue);

        ///<summary>Returns true if the current velocity is exceeding the given max speed (usually the result of GetMaxSpeed()), within a small error tolerance.</summary>
        ///<remarks>
        ///Note that under normal circumstances updates cause by acceleration will not cause this to be true, however external forces or changes in the max speed limit
        ///can cause the max speed to be violated.
        ///</remarks>
        public bool IsExceedingMaxSpeed(float MaxSpeed)  => 
            MovementComponent_methods.IsExceedingMaxSpeed_method.Invoke(ObjPointer, MaxSpeed);

        ///<summary>@return a scalar applied to the maximum velocity that the component can currently move.</summary>
        public float K2_GetMaxSpeedModifier()  => 
            MovementComponent_methods.K2_GetMaxSpeedModifier_method.Invoke(ObjPointer);

        ///<summary>@return the result of GetMaxSpeed() * GetMaxSpeedModifier().</summary>
        public float K2_GetModifiedMaxSpeed()  => 
            MovementComponent_methods.K2_GetModifiedMaxSpeed_method.Invoke(ObjPointer);

        ///<summary>Moves our UpdatedComponent by the given Delta, and sets rotation to NewRotation.</summary>
        ///<remarks>
        ///Respects the plane constraint, if enabled.
        ///@return True if some movement occurred, false if no movement occurred. Result of any impact will be stored in OutHit.
        ///</remarks>
        public (HitResult, bool) K2_MoveUpdatedComponent(Vector Delta, Rotator NewRotation, bool bSweep, bool bTeleport)  => 
            MovementComponent_methods.K2_MoveUpdatedComponent_method.Invoke(ObjPointer, Delta, NewRotation, bSweep, bTeleport);

        ///<summary>Set the plane constraint axis setting.</summary>
        ///<remarks>
        ///Changing this setting will modify the current value of PlaneConstraintNormal.
        ///
        ///@param  NewAxisSetting New plane constraint axis setting.
        ///</remarks>
        public void SetPlaneConstraintAxisSetting(EPlaneConstraintAxisSetting NewAxisSetting)  => 
            MovementComponent_methods.SetPlaneConstraintAxisSetting_method.Invoke(ObjPointer, NewAxisSetting);

        ///<summary>Sets whether or not the plane constraint is enabled.</summary>
        public void SetPlaneConstraintEnabled(bool bEnabled)  => 
            MovementComponent_methods.SetPlaneConstraintEnabled_method.Invoke(ObjPointer, bEnabled);

        ///<summary>Uses the Forward and Up vectors to compute the plane that constrains movement, enforced if the plane constraint is enabled.</summary>
        public void SetPlaneConstraintFromVectors(Vector Forward, Vector Up)  => 
            MovementComponent_methods.SetPlaneConstraintFromVectors_method.Invoke(ObjPointer, Forward, Up);

        ///<summary>Sets the normal of the plane that constrains movement, enforced if the plane constraint is enabled.</summary>
        ///<remarks>
        ///Changing the normal automatically sets PlaneConstraintAxisSetting to "Custom".
        ///
        ///@param PlaneNormal   The normal of the plane. If non-zero in length, it will be normalized.
        ///</remarks>
        public void SetPlaneConstraintNormal(Vector PlaneNormal)  => 
            MovementComponent_methods.SetPlaneConstraintNormal_method.Invoke(ObjPointer, PlaneNormal);

        ///<summary>Sets the origin of the plane that constrains movement, enforced if the plane constraint is enabled.</summary>
        public void SetPlaneConstraintOrigin(Vector PlaneOrigin)  => 
            MovementComponent_methods.SetPlaneConstraintOrigin_method.Invoke(ObjPointer, PlaneOrigin);

        ///<summary>Assign the component we move and update.</summary>
        public void SetUpdatedComponent(SceneComponent NewUpdatedComponent)  => 
            MovementComponent_methods.SetUpdatedComponent_method.Invoke(ObjPointer, NewUpdatedComponent);

        ///<summary>Snap the updated component to the plane constraint, if enabled.</summary>
        public void SnapUpdatedComponentToPlane()  => 
            MovementComponent_methods.SnapUpdatedComponentToPlane_method.Invoke(ObjPointer);

        ///<summary>Stops movement immediately (zeroes velocity, usually zeros acceleration for components with acceleration).</summary>
        public void StopMovementImmediately()  => 
            MovementComponent_methods.StopMovementImmediately_method.Invoke(ObjPointer);
        ///<summary>The component we move and update.</summary>
        ///<remarks>
        ///If this is null at startup and bAutoRegisterUpdatedComponent is true, the owning Actor's root component will automatically be set as our UpdatedComponent at startup.
        ///@see bAutoRegisterUpdatedComponent, SetUpdatedComponent(), UpdatedPrimitive
        ///</remarks>
        public unsafe SceneComponent UpdatedComponent {
            get {return MovementComponent_ptr->UpdatedComponent;}
        }
        ///<summary>UpdatedComponent, cast as a UPrimitiveComponent. May be invalid if UpdatedComponent was null or not a UPrimitiveComponent.</summary>
        public unsafe PrimitiveComponent UpdatedPrimitive {
            get {return MovementComponent_ptr->UpdatedPrimitive;}
        }
        ///<summary>Current velocity of updated component.</summary>
        public unsafe Vector Velocity {
            get {return MovementComponent_ptr->Velocity;}
            set {MovementComponent_ptr->Velocity = value;}
        }
        public bool bConstrainToPlane {
            get {return Main.GetGetBoolPropertyByName(this, "bConstrainToPlane"); }
        }
        public bool bSnapToPlaneAtStart {
            get {return Main.GetGetBoolPropertyByName(this, "bSnapToPlaneAtStart"); }
        }
         //TODO: enum EPlaneConstraintAxisSetting PlaneConstraintAxisSetting
        ///<summary>The normal or axis of the plane that constrains movement, if bConstrainToPlane is enabled.</summary>
        ///<remarks>
        ///If for example you wanted to constrain movement to the X-Z plane (so that Y cannot change), the normal would be set to X=0 Y=1 Z=0.
        ///This is recalculated whenever PlaneConstraintAxisSetting changes. It is normalized once the component is registered with the game world.
        ///@see bConstrainToPlane, SetPlaneConstraintNormal(), SetPlaneConstraintFromVectors()
        ///</remarks>
        public unsafe Vector PlaneConstraintNormal {
            get {return MovementComponent_ptr->PlaneConstraintNormal;}
        }
        ///<summary>The origin of the plane that constrains movement, if plane constraint is enabled.</summary>
        ///<remarks>
        ///This defines the behavior of snapping a position to the plane, such as by SnapUpdatedComponentToPlane().
        ///@see bConstrainToPlane, SetPlaneConstraintOrigin().
        ///</remarks>
        public unsafe Vector PlaneConstraintOrigin {
            get {return MovementComponent_ptr->PlaneConstraintOrigin;}
        }
        public bool bUpdateOnlyIfRendered {
            get {return Main.GetGetBoolPropertyByName(this, "bUpdateOnlyIfRendered"); }
            set {Main.SetGetBoolPropertyByName(this, "bUpdateOnlyIfRendered", value); }
        }
        public bool bAutoUpdateTickRegistration {
            get {return Main.GetGetBoolPropertyByName(this, "bAutoUpdateTickRegistration"); }
        }
        public bool bTickBeforeOwner {
            get {return Main.GetGetBoolPropertyByName(this, "bTickBeforeOwner"); }
        }
        public bool bAutoRegisterUpdatedComponent {
            get {return Main.GetGetBoolPropertyByName(this, "bAutoRegisterUpdatedComponent"); }
        }
        static MovementComponent() {
            StaticClass = Main.GetClass("MovementComponent");
        }
        internal unsafe MovementComponent_fields* MovementComponent_ptr => (MovementComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MovementComponent(IntPtr p) => UObject.Make<MovementComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MovementComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MovementComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
