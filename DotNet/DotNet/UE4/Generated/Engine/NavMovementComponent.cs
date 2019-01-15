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
    ///<summary>NavMovementComponent defines base functionality for MovementComponents that move any 'agent' that may be involved in AI pathfinding.</summary>
    public unsafe partial class NavMovementComponent : MovementComponent  {

        ///<summary>@return true if currently crouching</summary>
        public bool IsCrouching()  => 
            NavMovementComponent_methods.IsCrouching_method.Invoke(ObjPointer);

        ///<summary>@return true if currently falling (not flying, in a non-fluid volume, and not on the ground)</summary>
        public bool IsFalling()  => 
            NavMovementComponent_methods.IsFalling_method.Invoke(ObjPointer);

        ///<summary>@return true if currently flying (moving through a non-fluid volume without resting on the ground)</summary>
        public bool IsFlying()  => 
            NavMovementComponent_methods.IsFlying_method.Invoke(ObjPointer);

        ///<summary>@return true if currently moving on the ground (e.g. walking or driving)</summary>
        public bool IsMovingOnGround()  => 
            NavMovementComponent_methods.IsMovingOnGround_method.Invoke(ObjPointer);

        ///<summary>@return true if currently swimming (moving through a fluid volume)</summary>
        public bool IsSwimming()  => 
            NavMovementComponent_methods.IsSwimming_method.Invoke(ObjPointer);

        ///<summary>Stops applying further movement (usually zeros acceleration).</summary>
        public void StopActiveMovement()  => 
            NavMovementComponent_methods.StopActiveMovement_method.Invoke(ObjPointer);

        ///<summary>Stops movement immediately (reset velocity) but keeps following current path</summary>
        public void StopMovementKeepPathing()  => 
            NavMovementComponent_methods.StopMovementKeepPathing_method.Invoke(ObjPointer);
        ///<summary>Properties that define how the component can move.</summary>
        public unsafe NavAgentProperties NavAgentProps {
            get {return NavMovementComponent_ptr->NavAgentProps;}
            set {NavMovementComponent_ptr->NavAgentProps = value;}
        }
        ///<summary>Braking distance override used with acceleration driven path following (bUseAccelerationForPaths)</summary>
        public unsafe float FixedPathBrakingDistance {
            get {return NavMovementComponent_ptr->FixedPathBrakingDistance;}
            set {NavMovementComponent_ptr->FixedPathBrakingDistance = value;}
        }
        public bool bUpdateNavAgentWithOwnersCollision {
            get {return Main.GetGetBoolPropertyByName(this, "bUpdateNavAgentWithOwnersCollision"); }
            set {Main.SetGetBoolPropertyByName(this, "bUpdateNavAgentWithOwnersCollision", value); }
        }
        public bool bUseAccelerationForPaths {
            get {return Main.GetGetBoolPropertyByName(this, "bUseAccelerationForPaths"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseAccelerationForPaths", value); }
        }
        public bool bUseFixedBrakingDistanceForPaths {
            get {return Main.GetGetBoolPropertyByName(this, "bUseFixedBrakingDistanceForPaths"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseFixedBrakingDistanceForPaths", value); }
        }
        ///<summary>object implementing IPathFollowingAgentInterface.</summary>
        ///<remarks>
        ///Is private to control access to it.
        ///    @see SetPathFollowingAgent, GetPathFollowingAgent
        ///</remarks>
        public unsafe UObject PathFollowingComp {
            get {return NavMovementComponent_ptr->PathFollowingComp;}
            set {NavMovementComponent_ptr->PathFollowingComp = value;}
        }
        ///<summary>Expresses runtime state of character's movement. Put all temporal changes to movement properties here</summary>
        public unsafe MovementProperties MovementState {
            get {return NavMovementComponent_ptr->MovementState;}
            set {NavMovementComponent_ptr->MovementState = value;}
        }
        static NavMovementComponent() {
            StaticClass = Main.GetClass("NavMovementComponent");
        }
        internal unsafe NavMovementComponent_fields* NavMovementComponent_ptr => (NavMovementComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator NavMovementComponent(IntPtr p) => UObject.Make<NavMovementComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static NavMovementComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static NavMovementComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
