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
    ///<summary>CharacterMovementComponent handles movement logic for the associated Character owner.</summary>
    ///<remarks>
    ///It supports various movement modes including: walking, falling, swimming, flying, custom.
    ///
    ///Movement is affected primarily by current Velocity and Acceleration. Acceleration is updated each frame
    ///based on the input vector accumulated thus far (see UPawnMovementComponent::GetPendingInputVector()).
    ///
    ///Networking is fully implemented, with server-client correction and prediction included.
    ///
    ///@see ACharacter, UPawnMovementComponent
    ///@see https://docs.unrealengine.com/latest/INT/Gameplay/Framework/Pawn/Character/
    ///</remarks>
    public unsafe partial class CharacterMovementComponent : PawnMovementComponent  {

        ///<summary>Add force to character.</summary>
        ///<remarks>
        ///Forces are accumulated each tick and applied together
        ///so multiple calls to this function will accumulate.
        ///Forces are scaled depending on timestep, so they can be applied each frame. If you want an
        ///instantaneous force, use AddImpulse.
        ///Adding a force always takes the actor's mass into account.
        ///Note that changing the momentum of characters like this can change the movement mode.
        ///
        ///@param       Force                   Force to apply.
        ///</remarks>
        public void AddForce(Vector Force)  => 
            CharacterMovementComponent_methods.AddForce_method.Invoke(ObjPointer, Force);

        ///<summary>Add impulse to character.</summary>
        ///<remarks>
        ///Impulses are accumulated each tick and applied together
        ///so multiple calls to this function will accumulate.
        ///An impulse is an instantaneous force, usually applied once. If you want to continually apply
        ///forces each frame, use AddForce().
        ///Note that changing the momentum of characters like this can change the movement mode.
        ///
        ///@param       Impulse                         Impulse to apply.
        ///@param       bVelocityChange         Whether or not the impulse is relative to mass.
        ///</remarks>
        public void AddImpulse(Vector Impulse, bool bVelocityChange)  => 
            CharacterMovementComponent_methods.AddImpulse_method.Invoke(ObjPointer, Impulse, bVelocityChange);

        ///<summary>Updates Velocity and Acceleration based on the current state, applying the effects of friction and acceleration or deceleration.</summary>
        ///<remarks>
        ///Does not apply gravity.
        ///This is used internally during movement updates. Normally you don't need to call this from outside code, but you might want to use it for custom movement modes.
        ///
        ///@param       DeltaTime                                               time elapsed since last frame.
        ///@param       Friction                                                coefficient of friction when not accelerating, or in the direction opposite acceleration.
        ///@param       bFluid                                                  true if moving through a fluid, causing Friction to always be applied regardless of acceleration.
        ///@param       BrakingDeceleration                             deceleration applied when not accelerating, or when exceeding max velocity.
        ///</remarks>
        public void CalcVelocity(float DeltaTime, float Friction, bool bFluid, float BrakingDeceleration)  => 
            CharacterMovementComponent_methods.CalcVelocity_method.Invoke(ObjPointer, DeltaTime, Friction, bFluid, BrakingDeceleration);

        ///<summary>Clears forces accumulated through AddImpulse() and AddForce(), and also pending launch velocity.</summary>
        public void ClearAccumulatedForces()  => 
            CharacterMovementComponent_methods.ClearAccumulatedForces_method.Invoke(ObjPointer);

        ///<summary>Make movement impossible (sets movement mode to MOVE_None).</summary>
        public void DisableMovement()  => 
            CharacterMovementComponent_methods.DisableMovement_method.Invoke(ObjPointer);

        ///<summary>@return Modifier [0..1] based on the magnitude of the last input vector, which is used to modify the acceleration and max speed during movement.</summary>
        public float GetAnalogInputModifier()  => 
            CharacterMovementComponent_methods.GetAnalogInputModifier_method.Invoke(ObjPointer);

        ///<summary>Get the Character that owns UpdatedComponent.</summary>
        public Character GetCharacterOwner()  => 
            CharacterMovementComponent_methods.GetCharacterOwner_method.Invoke(ObjPointer);

        ///<summary>@return Current acceleration, computed from input vector each update.</summary>
        public Vector GetCurrentAcceleration()  => 
            CharacterMovementComponent_methods.GetCurrentAcceleration_method.Invoke(ObjPointer);

        ///<summary>If we have a movement base, get the velocity that should be imparted by that base, usually when jumping off of it.</summary>
        ///<remarks>Only applies the components of the velocity enabled by bImpartBaseVelocityX, bImpartBaseVelocityY, bImpartBaseVelocityZ.</remarks>
        public Vector GetImpartedMovementBaseVelocity()  => 
            CharacterMovementComponent_methods.GetImpartedMovementBaseVelocity_method.Invoke(ObjPointer);

        ///<summary>@return Maximum acceleration for the current state.</summary>
        public float GetMaxAcceleration()  => 
            CharacterMovementComponent_methods.GetMaxAcceleration_method.Invoke(ObjPointer);

        ///<summary>@return Maximum deceleration for the current state when braking (ie when there is no acceleration).</summary>
        public float GetMaxBrakingDeceleration()  => 
            CharacterMovementComponent_methods.GetMaxBrakingDeceleration_method.Invoke(ObjPointer);

        ///<summary>Compute the max jump height based on the JumpZVelocity velocity and gravity.</summary>
        ///<remarks>This does not take into account the CharacterOwner's MaxJumpHoldTime.</remarks>
        public float GetMaxJumpHeight()  => 
            CharacterMovementComponent_methods.GetMaxJumpHeight_method.Invoke(ObjPointer);

        ///<summary>Compute the max jump height based on the JumpZVelocity velocity and gravity.</summary>
        ///<remarks>This does take into account the CharacterOwner's MaxJumpHoldTime.</remarks>
        public float GetMaxJumpHeightWithJumpTime()  => 
            CharacterMovementComponent_methods.GetMaxJumpHeightWithJumpTime_method.Invoke(ObjPointer);

        ///<summary>@return Maximum acceleration for the current state.</summary>
        public float GetMinAnalogSpeed()  => 
            CharacterMovementComponent_methods.GetMinAnalogSpeed_method.Invoke(ObjPointer);

        ///<summary>Return PrimitiveComponent we are based on (standing and walking on).</summary>
        public PrimitiveComponent GetMovementBase()  => 
            CharacterMovementComponent_methods.GetMovementBase_method.Invoke(ObjPointer);

        ///<summary>@return The distance from the edge of the capsule within which we don't allow the character to perch on the edge of a surface.</summary>
        public float GetPerchRadiusThreshold()  => 
            CharacterMovementComponent_methods.GetPerchRadiusThreshold_method.Invoke(ObjPointer);

        ///<summary>Returns the radius within which we can stand on the edge of a surface without falling (if this is a walkable surface).</summary>
        ///<remarks>Simply computed as the capsule radius minus the result of GetPerchRadiusThreshold().</remarks>
        public float GetValidPerchRadius()  => 
            CharacterMovementComponent_methods.GetValidPerchRadius_method.Invoke(ObjPointer);

        ///<summary>Return true if the hit result should be considered a walkable surface for the character.</summary>
        public bool IsWalkable(HitResult Hit)  => 
            CharacterMovementComponent_methods.IsWalkable_method.Invoke(ObjPointer, Hit);

        ///<summary>@return true if the character is in the 'Walking' movement mode.</summary>
        public bool IsWalking()  => 
            CharacterMovementComponent_methods.IsWalking_method.Invoke(ObjPointer);

        ///<summary>Compute distance to the floor from bottom sphere of capsule and store the result in FloorResult.</summary>
        ///<remarks>
        ///This distance is the swept distance of the capsule to the first point impacted by the lower hemisphere, or distance from the bottom of the capsule in the case of a line trace.
        ///This function does not care if collision is disabled on the capsule (unlike FindFloor).
        ///
        ///@param CapsuleLocation                Location where the capsule sweep should originate
        ///@param LineDistance                   If non-zero, max distance to test for a simple line check from the capsule base. Used only if the sweep test fails to find a walkable floor, and only returns a valid result if the impact normal is a walkable normal.
        ///@param SweepDistance                  If non-zero, max distance to use when sweeping a capsule downwards for the test. MUST be greater than or equal to the line distance.
        ///@param SweepRadius                    The radius to use for sweep tests. Should be <= capsule radius.
        ///@param FloorResult                    Result of the floor check
        ///</remarks>
        public FindFloorResult K2_ComputeFloorDist(Vector CapsuleLocation, float LineDistance, float SweepDistance, float SweepRadius)  => 
            CharacterMovementComponent_methods.K2_ComputeFloorDist_method.Invoke(ObjPointer, CapsuleLocation, LineDistance, SweepDistance, SweepRadius);

        ///<summary>Sweeps a vertical trace to find the floor for the capsule at the given location.</summary>
        ///<remarks>
        ///Will attempt to perch if ShouldComputePerchResult() returns true for the downward sweep result.
        ///No floor will be found if collision is disabled on the capsule!
        ///
        ///@param CapsuleLocation                Location where the capsule sweep should originate
        ///@param FloorResult                    Result of the floor check
        ///</remarks>
        public FindFloorResult K2_FindFloor(Vector CapsuleLocation)  => 
            CharacterMovementComponent_methods.K2_FindFloor_method.Invoke(ObjPointer, CapsuleLocation);

        ///<summary>@return Maximum acceleration for the current state, based on MaxAcceleration and any additional modifiers.</summary>
        public float K2_GetModifiedMaxAcceleration()  => 
            CharacterMovementComponent_methods.K2_GetModifiedMaxAcceleration_method.Invoke(ObjPointer);

        ///<summary>Get the max angle in degrees of a walkable surface for the character.</summary>
        public float K2_GetWalkableFloorAngle()  => 
            CharacterMovementComponent_methods.K2_GetWalkableFloorAngle_method.Invoke(ObjPointer);

        ///<summary>Get the Z component of the normal of the steepest walkable surface for the character. Any lower than this and it is not walkable.</summary>
        public float K2_GetWalkableFloorZ()  => 
            CharacterMovementComponent_methods.K2_GetWalkableFloorZ_method.Invoke(ObjPointer);

        ///<summary>Change avoidance state and registers in RVO manager if needed</summary>
        public void SetAvoidanceEnabled(bool bEnable)  => 
            CharacterMovementComponent_methods.SetAvoidanceEnabled_method.Invoke(ObjPointer, bEnable);

        ///<summary>Set Avoidance Group</summary>
        public void SetAvoidanceGroup(int GroupFlags)  => 
            CharacterMovementComponent_methods.SetAvoidanceGroup_method.Invoke(ObjPointer, GroupFlags);

        ///<summary>Set Avoidance Group Mask</summary>
        public void SetAvoidanceGroupMask(NavAvoidanceMask GroupMask)  => 
            CharacterMovementComponent_methods.SetAvoidanceGroupMask_method.Invoke(ObjPointer, GroupMask);

        ///<summary>Set Groups to Avoid</summary>
        public void SetGroupsToAvoid(int GroupFlags)  => 
            CharacterMovementComponent_methods.SetGroupsToAvoid_method.Invoke(ObjPointer, GroupFlags);

        ///<summary>Set Groups to Avoid Mask</summary>
        public void SetGroupsToAvoidMask(NavAvoidanceMask GroupMask)  => 
            CharacterMovementComponent_methods.SetGroupsToAvoidMask_method.Invoke(ObjPointer, GroupMask);

        ///<summary>Set Groups to Ignore</summary>
        public void SetGroupsToIgnore(int GroupFlags)  => 
            CharacterMovementComponent_methods.SetGroupsToIgnore_method.Invoke(ObjPointer, GroupFlags);

        ///<summary>Set Groups to Ignore Mask</summary>
        public void SetGroupsToIgnoreMask(NavAvoidanceMask GroupMask)  => 
            CharacterMovementComponent_methods.SetGroupsToIgnoreMask_method.Invoke(ObjPointer, GroupMask);

        ///<summary>Change movement mode.</summary>
        ///<remarks>
        ///@param NewMovementMode       The new movement mode
        ///@param NewCustomMode         The new custom sub-mode, only applicable if NewMovementMode is Custom.
        ///</remarks>
        public void SetMovementMode(byte NewMovementMode, byte NewCustomMode)  => 
            CharacterMovementComponent_methods.SetMovementMode_method.Invoke(ObjPointer, NewMovementMode, NewCustomMode);

        ///<summary>Set the max angle in degrees of a walkable surface for the character. Also computes WalkableFloorZ.</summary>
        public void SetWalkableFloorAngle(float InWalkableFloorAngle)  => 
            CharacterMovementComponent_methods.SetWalkableFloorAngle_method.Invoke(ObjPointer, InWalkableFloorAngle);

        ///<summary>Set the Z component of the normal of the steepest walkable surface for the character. Also computes WalkableFloorAngle.</summary>
        public void SetWalkableFloorZ(float InWalkableFloorZ)  => 
            CharacterMovementComponent_methods.SetWalkableFloorZ_method.Invoke(ObjPointer, InWalkableFloorZ);
        ///<summary>Character movement component belongs to</summary>
        public unsafe Character CharacterOwner {
            get {return CharacterMovementComponent_ptr->CharacterOwner;}
            set {CharacterMovementComponent_ptr->CharacterOwner = value;}
        }
        public bool bApplyGravityWhileJumping {
            get {return Main.GetGetBoolPropertyByName(this, "bApplyGravityWhileJumping"); }
            set {Main.SetGetBoolPropertyByName(this, "bApplyGravityWhileJumping", value); }
        }
        ///<summary>Custom gravity scale. Gravity is multiplied by this amount for the character.</summary>
        public unsafe float GravityScale {
            get {return CharacterMovementComponent_ptr->GravityScale;}
            set {CharacterMovementComponent_ptr->GravityScale = value;}
        }
        ///<summary>Maximum height character can step up</summary>
        public unsafe float MaxStepHeight {
            get {return CharacterMovementComponent_ptr->MaxStepHeight;}
            set {CharacterMovementComponent_ptr->MaxStepHeight = value;}
        }
        ///<summary>Initial velocity (instantaneous vertical acceleration) when jumping.</summary>
        public unsafe float JumpZVelocity {
            get {return CharacterMovementComponent_ptr->JumpZVelocity;}
            set {CharacterMovementComponent_ptr->JumpZVelocity = value;}
        }
        ///<summary>Fraction of JumpZVelocity to use when automatically "jumping off" of a base actor that's not allowed to be a base for a character. (For example, if you're not allowed to stand on other players.)</summary>
        public unsafe float JumpOffJumpZFactor {
            get {return CharacterMovementComponent_ptr->JumpOffJumpZFactor;}
            set {CharacterMovementComponent_ptr->JumpOffJumpZFactor = value;}
        }
        ///<summary>Max angle in degrees of a walkable surface. Any greater than this and it is too steep to be walkable.</summary>
        public unsafe float WalkableFloorAngle {
            get {return CharacterMovementComponent_ptr->WalkableFloorAngle;}
            set {CharacterMovementComponent_ptr->WalkableFloorAngle = value;}
        }
        ///<summary>Minimum Z value for floor normal. If less, not a walkable surface. Computed from WalkableFloorAngle.</summary>
        public unsafe float WalkableFloorZ {
            get {return CharacterMovementComponent_ptr->WalkableFloorZ;}
            set {CharacterMovementComponent_ptr->WalkableFloorZ = value;}
        }
        ///<summary>Actor's current movement mode (walking, falling, etc).</summary>
        ///<remarks>
        ///- walking:  Walking on a surface, under the effects of friction, and able to "step up" barriers. Vertical velocity is zero.
        ///   - falling:  Falling under the effects of gravity, after jumping or walking off the edge of a surface.
        ///   - flying:   Flying, ignoring the effects of gravity.
        ///   - swimming: Swimming through a fluid volume, under the effects of gravity and buoyancy.
        ///   - custom:   User-defined custom movement mode, including many possible sub-modes.
        ///This is automatically replicated through the Character owner and for client-server movement functions.
        ///@see SetMovementMode(), CustomMovementMode
        ///</remarks>
        public unsafe byte MovementMode {
            get {return CharacterMovementComponent_ptr->MovementMode;}
        }
        ///<summary>Current custom sub-mode if MovementMode is set to Custom.</summary>
        ///<remarks>
        ///This is automatically replicated through the Character owner and for client-server movement functions.
        ///@see SetMovementMode()
        ///</remarks>
        public unsafe byte CustomMovementMode {
            get {return CharacterMovementComponent_ptr->CustomMovementMode;}
        }
        ///<summary>Setting that affects movement control.</summary>
        ///<remarks>
        ///Higher values allow faster changes in direction.
        ///If bUseSeparateBrakingFriction is false, also affects the ability to stop more quickly when braking (whenever Acceleration is zero), where it is multiplied by BrakingFrictionFactor.
        ///When braking, this property allows you to control how much friction is applied when moving across the ground, applying an opposing force that scales with current velocity.
        ///This can be used to simulate slippery surfaces such as ice or oil by changing the value (possibly based on the material pawn is standing on).
        ///@see BrakingDecelerationWalking, BrakingFriction, bUseSeparateBrakingFriction, BrakingFrictionFactor
        ///</remarks>
        public unsafe float GroundFriction {
            get {return CharacterMovementComponent_ptr->GroundFriction;}
            set {CharacterMovementComponent_ptr->GroundFriction = value;}
        }
        ///<summary>The maximum ground speed when walking. Also determines maximum lateral speed when falling.</summary>
        public unsafe float MaxWalkSpeed {
            get {return CharacterMovementComponent_ptr->MaxWalkSpeed;}
            set {CharacterMovementComponent_ptr->MaxWalkSpeed = value;}
        }
        ///<summary>The maximum ground speed when walking and crouched.</summary>
        public unsafe float MaxWalkSpeedCrouched {
            get {return CharacterMovementComponent_ptr->MaxWalkSpeedCrouched;}
            set {CharacterMovementComponent_ptr->MaxWalkSpeedCrouched = value;}
        }
        ///<summary>The maximum swimming speed.</summary>
        public unsafe float MaxSwimSpeed {
            get {return CharacterMovementComponent_ptr->MaxSwimSpeed;}
            set {CharacterMovementComponent_ptr->MaxSwimSpeed = value;}
        }
        ///<summary>The maximum flying speed.</summary>
        public unsafe float MaxFlySpeed {
            get {return CharacterMovementComponent_ptr->MaxFlySpeed;}
            set {CharacterMovementComponent_ptr->MaxFlySpeed = value;}
        }
        ///<summary>The maximum speed when using Custom movement mode.</summary>
        public unsafe float MaxCustomMovementSpeed {
            get {return CharacterMovementComponent_ptr->MaxCustomMovementSpeed;}
            set {CharacterMovementComponent_ptr->MaxCustomMovementSpeed = value;}
        }
        ///<summary>Max Acceleration (rate of change of velocity)</summary>
        public unsafe float MaxAcceleration {
            get {return CharacterMovementComponent_ptr->MaxAcceleration;}
            set {CharacterMovementComponent_ptr->MaxAcceleration = value;}
        }
        ///<summary>The ground speed that we should accelerate up to when walking at minimum analog stick tilt</summary>
        public unsafe float MinAnalogWalkSpeed {
            get {return CharacterMovementComponent_ptr->MinAnalogWalkSpeed;}
            set {CharacterMovementComponent_ptr->MinAnalogWalkSpeed = value;}
        }
        ///<summary>Factor used to multiply actual value of friction used when braking.</summary>
        ///<remarks>
        ///This applies to any friction value that is currently used, which may depend on bUseSeparateBrakingFriction.
        ///@note This is 2 by default for historical reasons, a value of 1 gives the true drag equation.
        ///@see bUseSeparateBrakingFriction, GroundFriction, BrakingFriction
        ///</remarks>
        public unsafe float BrakingFrictionFactor {
            get {return CharacterMovementComponent_ptr->BrakingFrictionFactor;}
            set {CharacterMovementComponent_ptr->BrakingFrictionFactor = value;}
        }
        ///<summary>Friction (drag) coefficient applied when braking (whenever Acceleration = 0, or if character is exceeding max speed); actual value used is this multiplied by BrakingFrictionFactor.</summary>
        ///<remarks>
        ///When braking, this property allows you to control how much friction is applied when moving across the ground, applying an opposing force that scales with current velocity.
        ///Braking is composed of friction (velocity-dependent drag) and constant deceleration.
        ///This is the current value, used in all movement modes; if this is not desired, override it or bUseSeparateBrakingFriction when movement mode changes.
        ///@note Only used if bUseSeparateBrakingFriction setting is true, otherwise current friction such as GroundFriction is used.
        ///@see bUseSeparateBrakingFriction, BrakingFrictionFactor, GroundFriction, BrakingDecelerationWalking
        ///</remarks>
        public unsafe float BrakingFriction {
            get {return CharacterMovementComponent_ptr->BrakingFriction;}
            set {CharacterMovementComponent_ptr->BrakingFriction = value;}
        }
        public bool bUseSeparateBrakingFriction {
            get {return Main.GetGetBoolPropertyByName(this, "bUseSeparateBrakingFriction"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseSeparateBrakingFriction", value); }
        }
        ///<summary>Deceleration when walking and not applying acceleration.</summary>
        ///<remarks>
        ///This is a constant opposing force that directly lowers velocity by a constant value.
        ///@see GroundFriction, MaxAcceleration
        ///</remarks>
        public unsafe float BrakingDecelerationWalking {
            get {return CharacterMovementComponent_ptr->BrakingDecelerationWalking;}
            set {CharacterMovementComponent_ptr->BrakingDecelerationWalking = value;}
        }
        ///<summary>Lateral deceleration when falling and not applying acceleration.</summary>
        ///<remarks>
        ///@see MaxAcceleration
        ///</remarks>
        public unsafe float BrakingDecelerationFalling {
            get {return CharacterMovementComponent_ptr->BrakingDecelerationFalling;}
            set {CharacterMovementComponent_ptr->BrakingDecelerationFalling = value;}
        }
        ///<summary>Deceleration when swimming and not applying acceleration.</summary>
        ///<remarks>
        ///@see MaxAcceleration
        ///</remarks>
        public unsafe float BrakingDecelerationSwimming {
            get {return CharacterMovementComponent_ptr->BrakingDecelerationSwimming;}
            set {CharacterMovementComponent_ptr->BrakingDecelerationSwimming = value;}
        }
        ///<summary>Deceleration when flying and not applying acceleration.</summary>
        ///<remarks>
        ///@see MaxAcceleration
        ///</remarks>
        public unsafe float BrakingDecelerationFlying {
            get {return CharacterMovementComponent_ptr->BrakingDecelerationFlying;}
            set {CharacterMovementComponent_ptr->BrakingDecelerationFlying = value;}
        }
        ///<summary>When falling, amount of lateral movement control available to the character.</summary>
        ///<remarks>0 = no control, 1 = full control at max speed of MaxWalkSpeed.</remarks>
        public unsafe float AirControl {
            get {return CharacterMovementComponent_ptr->AirControl;}
            set {CharacterMovementComponent_ptr->AirControl = value;}
        }
        ///<summary>When falling, multiplier applied to AirControl when lateral velocity is less than AirControlBoostVelocityThreshold.</summary>
        ///<remarks>Setting this to zero will disable air control boosting. Final result is clamped at 1.</remarks>
        public unsafe float AirControlBoostMultiplier {
            get {return CharacterMovementComponent_ptr->AirControlBoostMultiplier;}
            set {CharacterMovementComponent_ptr->AirControlBoostMultiplier = value;}
        }
        ///<summary>When falling, if lateral velocity magnitude is less than this value, AirControl is multiplied by AirControlBoostMultiplier.</summary>
        ///<remarks>Setting this to zero will disable air control boosting.</remarks>
        public unsafe float AirControlBoostVelocityThreshold {
            get {return CharacterMovementComponent_ptr->AirControlBoostVelocityThreshold;}
            set {CharacterMovementComponent_ptr->AirControlBoostVelocityThreshold = value;}
        }
        ///<summary>Friction to apply to lateral air movement when falling.</summary>
        ///<remarks>
        ///If bUseSeparateBrakingFriction is false, also affects the ability to stop more quickly when braking (whenever Acceleration is zero).
        ///@see BrakingFriction, bUseSeparateBrakingFriction
        ///</remarks>
        public unsafe float FallingLateralFriction {
            get {return CharacterMovementComponent_ptr->FallingLateralFriction;}
            set {CharacterMovementComponent_ptr->FallingLateralFriction = value;}
        }
        ///<summary>Collision half-height when crouching (component scale is applied separately)</summary>
        public unsafe float CrouchedHalfHeight {
            get {return CharacterMovementComponent_ptr->CrouchedHalfHeight;}
        }
        ///<summary>Water buoyancy. A ratio (1.0 = neutral buoyancy, 0.0 = no buoyancy)</summary>
        public unsafe float Buoyancy {
            get {return CharacterMovementComponent_ptr->Buoyancy;}
            set {CharacterMovementComponent_ptr->Buoyancy = value;}
        }
        ///<summary>Don't allow the character to perch on the edge of a surface if the contact is this close to the edge of the capsule.</summary>
        ///<remarks>Note that characters will not fall off if they are within MaxStepHeight of a walkable surface below.</remarks>
        public unsafe float PerchRadiusThreshold {
            get {return CharacterMovementComponent_ptr->PerchRadiusThreshold;}
            set {CharacterMovementComponent_ptr->PerchRadiusThreshold = value;}
        }
        ///<summary>When perching on a ledge, add this additional distance to MaxStepHeight when determining how high above a walkable floor we can perch.</summary>
        ///<remarks>
        ///Note that we still enforce MaxStepHeight to start the step up; this just allows the character to hang off the edge or step slightly higher off the floor.
        ///(@see PerchRadiusThreshold)
        ///</remarks>
        public unsafe float PerchAdditionalHeight {
            get {return CharacterMovementComponent_ptr->PerchAdditionalHeight;}
            set {CharacterMovementComponent_ptr->PerchAdditionalHeight = value;}
        }
        ///<summary>Change in rotation per second, used when UseControllerDesiredRotation or OrientRotationToMovement are true. Set a negative value for infinite rotation rate and instant turns.</summary>
        public unsafe Rotator RotationRate {
            get {return CharacterMovementComponent_ptr->RotationRate;}
            set {CharacterMovementComponent_ptr->RotationRate = value;}
        }
        public bool bUseControllerDesiredRotation {
            get {return Main.GetGetBoolPropertyByName(this, "bUseControllerDesiredRotation"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseControllerDesiredRotation", value); }
        }
        public bool bOrientRotationToMovement {
            get {return Main.GetGetBoolPropertyByName(this, "bOrientRotationToMovement"); }
            set {Main.SetGetBoolPropertyByName(this, "bOrientRotationToMovement", value); }
        }
        public bool bSweepWhileNavWalking {
            get {return Main.GetGetBoolPropertyByName(this, "bSweepWhileNavWalking"); }
            set {Main.SetGetBoolPropertyByName(this, "bSweepWhileNavWalking", value); }
        }
        public bool bMovementInProgress {
            get {return Main.GetGetBoolPropertyByName(this, "bMovementInProgress"); }
            set {Main.SetGetBoolPropertyByName(this, "bMovementInProgress", value); }
        }
        public bool bEnableScopedMovementUpdates {
            get {return Main.GetGetBoolPropertyByName(this, "bEnableScopedMovementUpdates"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnableScopedMovementUpdates", value); }
        }
        public bool bForceMaxAccel {
            get {return Main.GetGetBoolPropertyByName(this, "bForceMaxAccel"); }
            set {Main.SetGetBoolPropertyByName(this, "bForceMaxAccel", value); }
        }
        public bool bRunPhysicsWithNoController {
            get {return Main.GetGetBoolPropertyByName(this, "bRunPhysicsWithNoController"); }
            set {Main.SetGetBoolPropertyByName(this, "bRunPhysicsWithNoController", value); }
        }
        public bool bForceNextFloorCheck {
            get {return Main.GetGetBoolPropertyByName(this, "bForceNextFloorCheck"); }
            set {Main.SetGetBoolPropertyByName(this, "bForceNextFloorCheck", value); }
        }
        public bool bShrinkProxyCapsule {
            get {return Main.GetGetBoolPropertyByName(this, "bShrinkProxyCapsule"); }
            set {Main.SetGetBoolPropertyByName(this, "bShrinkProxyCapsule", value); }
        }
        public bool bCanWalkOffLedges {
            get {return Main.GetGetBoolPropertyByName(this, "bCanWalkOffLedges"); }
            set {Main.SetGetBoolPropertyByName(this, "bCanWalkOffLedges", value); }
        }
        public bool bCanWalkOffLedgesWhenCrouching {
            get {return Main.GetGetBoolPropertyByName(this, "bCanWalkOffLedgesWhenCrouching"); }
            set {Main.SetGetBoolPropertyByName(this, "bCanWalkOffLedgesWhenCrouching", value); }
        }
        public bool bNetworkSkipProxyPredictionOnNetUpdate {
            get {return Main.GetGetBoolPropertyByName(this, "bNetworkSkipProxyPredictionOnNetUpdate"); }
            set {Main.SetGetBoolPropertyByName(this, "bNetworkSkipProxyPredictionOnNetUpdate", value); }
        }
        public bool bNetworkAlwaysReplicateTransformUpdateTimestamp {
            get {return Main.GetGetBoolPropertyByName(this, "bNetworkAlwaysReplicateTransformUpdateTimestamp"); }
            set {Main.SetGetBoolPropertyByName(this, "bNetworkAlwaysReplicateTransformUpdateTimestamp", value); }
        }
        public bool bDeferUpdateMoveComponent {
            get {return Main.GetGetBoolPropertyByName(this, "bDeferUpdateMoveComponent"); }
            set {Main.SetGetBoolPropertyByName(this, "bDeferUpdateMoveComponent", value); }
        }
        ///<summary>What to update CharacterOwner and UpdatedComponent after movement ends</summary>
        public unsafe SceneComponent DeferredUpdatedMoveComponent {
            get {return CharacterMovementComponent_ptr->DeferredUpdatedMoveComponent;}
            set {CharacterMovementComponent_ptr->DeferredUpdatedMoveComponent = value;}
        }
        ///<summary>Maximum step height for getting out of water</summary>
        public unsafe float MaxOutOfWaterStepHeight {
            get {return CharacterMovementComponent_ptr->MaxOutOfWaterStepHeight;}
            set {CharacterMovementComponent_ptr->MaxOutOfWaterStepHeight = value;}
        }
        ///<summary>Z velocity applied when pawn tries to get out of water</summary>
        public unsafe float OutofWaterZ {
            get {return CharacterMovementComponent_ptr->OutofWaterZ;}
            set {CharacterMovementComponent_ptr->OutofWaterZ = value;}
        }
        ///<summary>Mass of pawn (for when momentum is imparted to it).</summary>
        public unsafe float Mass {
            get {return CharacterMovementComponent_ptr->Mass;}
            set {CharacterMovementComponent_ptr->Mass = value;}
        }
        public bool bEnablePhysicsInteraction {
            get {return Main.GetGetBoolPropertyByName(this, "bEnablePhysicsInteraction"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnablePhysicsInteraction", value); }
        }
        public bool bTouchForceScaledToMass {
            get {return Main.GetGetBoolPropertyByName(this, "bTouchForceScaledToMass"); }
            set {Main.SetGetBoolPropertyByName(this, "bTouchForceScaledToMass", value); }
        }
        public bool bPushForceScaledToMass {
            get {return Main.GetGetBoolPropertyByName(this, "bPushForceScaledToMass"); }
            set {Main.SetGetBoolPropertyByName(this, "bPushForceScaledToMass", value); }
        }
        public bool bPushForceUsingZOffset {
            get {return Main.GetGetBoolPropertyByName(this, "bPushForceUsingZOffset"); }
            set {Main.SetGetBoolPropertyByName(this, "bPushForceUsingZOffset", value); }
        }
        public bool bScalePushForceToVelocity {
            get {return Main.GetGetBoolPropertyByName(this, "bScalePushForceToVelocity"); }
            set {Main.SetGetBoolPropertyByName(this, "bScalePushForceToVelocity", value); }
        }
        ///<summary>Force applied to objects we stand on (due to Mass and Gravity) is scaled by this amount.</summary>
        public unsafe float StandingDownwardForceScale {
            get {return CharacterMovementComponent_ptr->StandingDownwardForceScale;}
            set {CharacterMovementComponent_ptr->StandingDownwardForceScale = value;}
        }
        ///<summary>Initial impulse force to apply when the player bounces into a blocking physics object.</summary>
        public unsafe float InitialPushForceFactor {
            get {return CharacterMovementComponent_ptr->InitialPushForceFactor;}
            set {CharacterMovementComponent_ptr->InitialPushForceFactor = value;}
        }
        ///<summary>Force to apply when the player collides with a blocking physics object.</summary>
        public unsafe float PushForceFactor {
            get {return CharacterMovementComponent_ptr->PushForceFactor;}
            set {CharacterMovementComponent_ptr->PushForceFactor = value;}
        }
        ///<summary>Z-Offset for the position the force is applied to. 0.0f is the center of the physics object, 1.0f is the top and -1.0f is the bottom of the object.</summary>
        public unsafe float PushForcePointZOffsetFactor {
            get {return CharacterMovementComponent_ptr->PushForcePointZOffsetFactor;}
            set {CharacterMovementComponent_ptr->PushForcePointZOffsetFactor = value;}
        }
        ///<summary>Force to apply to physics objects that are touched by the player.</summary>
        public unsafe float TouchForceFactor {
            get {return CharacterMovementComponent_ptr->TouchForceFactor;}
            set {CharacterMovementComponent_ptr->TouchForceFactor = value;}
        }
        ///<summary>Minimum Force applied to touched physics objects. If < 0.0f, there is no minimum.</summary>
        public unsafe float MinTouchForce {
            get {return CharacterMovementComponent_ptr->MinTouchForce;}
            set {CharacterMovementComponent_ptr->MinTouchForce = value;}
        }
        ///<summary>Maximum force applied to touched physics objects. If < 0.0f, there is no maximum.</summary>
        public unsafe float MaxTouchForce {
            get {return CharacterMovementComponent_ptr->MaxTouchForce;}
            set {CharacterMovementComponent_ptr->MaxTouchForce = value;}
        }
        ///<summary>Force per kg applied constantly to all overlapping components.</summary>
        public unsafe float RepulsionForce {
            get {return CharacterMovementComponent_ptr->RepulsionForce;}
            set {CharacterMovementComponent_ptr->RepulsionForce = value;}
        }
        ///<summary>Current acceleration vector (with magnitude).</summary>
        ///<remarks>This is calculated each update based on the input vector and the constraints of MaxAcceleration and the current movement mode.</remarks>
        public unsafe Vector Acceleration {
            get {return CharacterMovementComponent_ptr->Acceleration;}
            set {CharacterMovementComponent_ptr->Acceleration = value;}
        }
        ///<summary>Location after last PerformMovement or SimulateMovement update. Used internally to detect changes in position from outside character movement to try to validate the current floor.</summary>
        public unsafe Vector LastUpdateLocation {
            get {return CharacterMovementComponent_ptr->LastUpdateLocation;}
            set {CharacterMovementComponent_ptr->LastUpdateLocation = value;}
        }
        ///<summary>Rotation after last PerformMovement or SimulateMovement update.</summary>
        public unsafe Quat LastUpdateRotation {
            get {return CharacterMovementComponent_ptr->LastUpdateRotation;}
            set {CharacterMovementComponent_ptr->LastUpdateRotation = value;}
        }
        ///<summary>Velocity after last PerformMovement or SimulateMovement update. Used internally to detect changes in velocity from external sources.</summary>
        public unsafe Vector LastUpdateVelocity {
            get {return CharacterMovementComponent_ptr->LastUpdateVelocity;}
            set {CharacterMovementComponent_ptr->LastUpdateVelocity = value;}
        }
        ///<summary>Timestamp when location or rotation last changed during an update. Only valid on the server.</summary>
        public unsafe float ServerLastTransformUpdateTimeStamp {
            get {return CharacterMovementComponent_ptr->ServerLastTransformUpdateTimeStamp;}
            set {CharacterMovementComponent_ptr->ServerLastTransformUpdateTimeStamp = value;}
        }
        ///<summary>Timestamp of last client adjustment sent. See NetworkMinTimeBetweenClientAdjustments.</summary>
        public unsafe float ServerLastClientGoodMoveAckTime {
            get {return CharacterMovementComponent_ptr->ServerLastClientGoodMoveAckTime;}
            set {CharacterMovementComponent_ptr->ServerLastClientGoodMoveAckTime = value;}
        }
        ///<summary>Timestamp of last client adjustment sent. See NetworkMinTimeBetweenClientAdjustments.</summary>
        public unsafe float ServerLastClientAdjustmentTime {
            get {return CharacterMovementComponent_ptr->ServerLastClientAdjustmentTime;}
            set {CharacterMovementComponent_ptr->ServerLastClientAdjustmentTime = value;}
        }
        ///<summary>Accumulated impulse to be added next tick.</summary>
        public unsafe Vector PendingImpulseToApply {
            get {return CharacterMovementComponent_ptr->PendingImpulseToApply;}
            set {CharacterMovementComponent_ptr->PendingImpulseToApply = value;}
        }
        ///<summary>Accumulated force to be added next tick.</summary>
        public unsafe Vector PendingForceToApply {
            get {return CharacterMovementComponent_ptr->PendingForceToApply;}
            set {CharacterMovementComponent_ptr->PendingForceToApply = value;}
        }
        ///<summary>Modifier to applied to values such as acceleration and max speed due to analog input.</summary>
        public unsafe float AnalogInputModifier {
            get {return CharacterMovementComponent_ptr->AnalogInputModifier;}
            set {CharacterMovementComponent_ptr->AnalogInputModifier = value;}
        }
        ///<summary>Max time delta for each discrete simulation step.</summary>
        ///<remarks>
        ///Used primarily in the the more advanced movement modes that break up larger time steps (usually those applying gravity such as falling and walking).
        ///Lowering this value can address issues with fast-moving objects or complex collision scenarios, at the cost of performance.
        ///
        ///WARNING: if (MaxSimulationTimeStep * MaxSimulationIterations) is too low for the min framerate, the last simulation step may exceed MaxSimulationTimeStep to complete the simulation.
        ///@see MaxSimulationIterations
        ///</remarks>
        public unsafe float MaxSimulationTimeStep {
            get {return CharacterMovementComponent_ptr->MaxSimulationTimeStep;}
            set {CharacterMovementComponent_ptr->MaxSimulationTimeStep = value;}
        }
        ///<summary>Max number of iterations used for each discrete simulation step.</summary>
        ///<remarks>
        ///Used primarily in the the more advanced movement modes that break up larger time steps (usually those applying gravity such as falling and walking).
        ///Increasing this value can address issues with fast-moving objects or complex collision scenarios, at the cost of performance.
        ///
        ///WARNING: if (MaxSimulationTimeStep * MaxSimulationIterations) is too low for the min framerate, the last simulation step may exceed MaxSimulationTimeStep to complete the simulation.
        ///@see MaxSimulationTimeStep
        ///</remarks>
        public unsafe int MaxSimulationIterations {
            get {return CharacterMovementComponent_ptr->MaxSimulationIterations;}
            set {CharacterMovementComponent_ptr->MaxSimulationIterations = value;}
        }
        ///<summary>Max distance we allow simulated proxies to depenetrate when moving out of anything but Pawns.</summary>
        ///<remarks>
        ///This is generally more tolerant than with Pawns, because other geometry is either not moving, or is moving predictably with a bit of delay compared to on the server.
        ///@see MaxDepenetrationWithGeometryAsProxy, MaxDepenetrationWithPawn, MaxDepenetrationWithPawnAsProxy
        ///</remarks>
        public unsafe float MaxDepenetrationWithGeometry {
            get {return CharacterMovementComponent_ptr->MaxDepenetrationWithGeometry;}
            set {CharacterMovementComponent_ptr->MaxDepenetrationWithGeometry = value;}
        }
        ///<summary>Max distance we allow simulated proxies to depenetrate when moving out of anything but Pawns.</summary>
        ///<remarks>
        ///This is generally more tolerant than with Pawns, because other geometry is either not moving, or is moving predictably with a bit of delay compared to on the server.
        ///@see MaxDepenetrationWithGeometry, MaxDepenetrationWithPawn, MaxDepenetrationWithPawnAsProxy
        ///</remarks>
        public unsafe float MaxDepenetrationWithGeometryAsProxy {
            get {return CharacterMovementComponent_ptr->MaxDepenetrationWithGeometryAsProxy;}
            set {CharacterMovementComponent_ptr->MaxDepenetrationWithGeometryAsProxy = value;}
        }
        ///<summary>Max distance we are allowed to depenetrate when moving out of other Pawns.</summary>
        ///<remarks>
        ///@see MaxDepenetrationWithGeometry, MaxDepenetrationWithGeometryAsProxy, MaxDepenetrationWithPawnAsProxy
        ///</remarks>
        public unsafe float MaxDepenetrationWithPawn {
            get {return CharacterMovementComponent_ptr->MaxDepenetrationWithPawn;}
            set {CharacterMovementComponent_ptr->MaxDepenetrationWithPawn = value;}
        }
        ///<summary>Max distance we allow simulated proxies to depenetrate when moving out of other Pawns.</summary>
        ///<remarks>
        ///Typically we don't want a large value, because we receive a server authoritative position that we should not then ignore by pushing them out of the local player.
        ///@see MaxDepenetrationWithGeometry, MaxDepenetrationWithGeometryAsProxy, MaxDepenetrationWithPawn
        ///</remarks>
        public unsafe float MaxDepenetrationWithPawnAsProxy {
            get {return CharacterMovementComponent_ptr->MaxDepenetrationWithPawnAsProxy;}
            set {CharacterMovementComponent_ptr->MaxDepenetrationWithPawnAsProxy = value;}
        }
        ///<summary>How long to take to smoothly interpolate from the old pawn position on the client to the corrected one sent by the server. Not used by Linear smoothing.</summary>
        public unsafe float NetworkSimulatedSmoothLocationTime {
            get {return CharacterMovementComponent_ptr->NetworkSimulatedSmoothLocationTime;}
            set {CharacterMovementComponent_ptr->NetworkSimulatedSmoothLocationTime = value;}
        }
        ///<summary>How long to take to smoothly interpolate from the old pawn rotation on the client to the corrected one sent by the server. Not used by Linear smoothing.</summary>
        public unsafe float NetworkSimulatedSmoothRotationTime {
            get {return CharacterMovementComponent_ptr->NetworkSimulatedSmoothRotationTime;}
            set {CharacterMovementComponent_ptr->NetworkSimulatedSmoothRotationTime = value;}
        }
        ///<summary>Similar setting as NetworkSimulatedSmoothLocationTime but only used on Listen servers.</summary>
        public unsafe float ListenServerNetworkSimulatedSmoothLocationTime {
            get {return CharacterMovementComponent_ptr->ListenServerNetworkSimulatedSmoothLocationTime;}
            set {CharacterMovementComponent_ptr->ListenServerNetworkSimulatedSmoothLocationTime = value;}
        }
        ///<summary>Similar setting as NetworkSimulatedSmoothRotationTime but only used on Listen servers.</summary>
        public unsafe float ListenServerNetworkSimulatedSmoothRotationTime {
            get {return CharacterMovementComponent_ptr->ListenServerNetworkSimulatedSmoothRotationTime;}
            set {CharacterMovementComponent_ptr->ListenServerNetworkSimulatedSmoothRotationTime = value;}
        }
        ///<summary>Shrink simulated proxy capsule radius by this amount, to account for network rounding that may cause encroachment.</summary>
        ///<remarks>
        ///Changing during gameplay is not supported.
        ///@see AdjustProxyCapsuleSize()
        ///</remarks>
        public unsafe float NetProxyShrinkRadius {
            get {return CharacterMovementComponent_ptr->NetProxyShrinkRadius;}
            set {CharacterMovementComponent_ptr->NetProxyShrinkRadius = value;}
        }
        ///<summary>Shrink simulated proxy capsule half height by this amount, to account for network rounding that may cause encroachment.</summary>
        ///<remarks>
        ///Changing during gameplay is not supported.
        ///@see AdjustProxyCapsuleSize()
        ///</remarks>
        public unsafe float NetProxyShrinkHalfHeight {
            get {return CharacterMovementComponent_ptr->NetProxyShrinkHalfHeight;}
            set {CharacterMovementComponent_ptr->NetProxyShrinkHalfHeight = value;}
        }
        ///<summary>Maximum distance character is allowed to lag behind server location when interpolating between updates.</summary>
        public unsafe float NetworkMaxSmoothUpdateDistance {
            get {return CharacterMovementComponent_ptr->NetworkMaxSmoothUpdateDistance;}
            set {CharacterMovementComponent_ptr->NetworkMaxSmoothUpdateDistance = value;}
        }
        ///<summary>Maximum distance beyond which character is teleported to the new server location without any smoothing.</summary>
        public unsafe float NetworkNoSmoothUpdateDistance {
            get {return CharacterMovementComponent_ptr->NetworkNoSmoothUpdateDistance;}
            set {CharacterMovementComponent_ptr->NetworkNoSmoothUpdateDistance = value;}
        }
         //TODO: enum ENetworkSmoothingMode NetworkSmoothingMode
        ///<summary>Minimum time on the server between acknowledging good client moves. This can save on bandwidth. Set to 0 to disable throttling.</summary>
        public unsafe float NetworkMinTimeBetweenClientAckGoodMoves {
            get {return CharacterMovementComponent_ptr->NetworkMinTimeBetweenClientAckGoodMoves;}
            set {CharacterMovementComponent_ptr->NetworkMinTimeBetweenClientAckGoodMoves = value;}
        }
        ///<summary>Minimum time on the server between sending client adjustments when client has exceeded allowable position error.</summary>
        ///<remarks>
        ///Should be >= NetworkMinTimeBetweenClientAdjustmentsLargeCorrection (the larger value is used regardless).
        ///This can save on bandwidth. Set to 0 to disable throttling.
        ///@see ServerLastClientAdjustmentTime
        ///</remarks>
        public unsafe float NetworkMinTimeBetweenClientAdjustments {
            get {return CharacterMovementComponent_ptr->NetworkMinTimeBetweenClientAdjustments;}
            set {CharacterMovementComponent_ptr->NetworkMinTimeBetweenClientAdjustments = value;}
        }
        ///<summary>Minimum time on the server between sending client adjustments when client has exceeded allowable position error by a large amount (NetworkLargeClientCorrectionDistance).</summary>
        ///<remarks>
        ///Should be <= NetworkMinTimeBetweenClientAdjustments (the smaller value is used regardless).
        ///@see NetworkMinTimeBetweenClientAdjustments
        ///</remarks>
        public unsafe float NetworkMinTimeBetweenClientAdjustmentsLargeCorrection {
            get {return CharacterMovementComponent_ptr->NetworkMinTimeBetweenClientAdjustmentsLargeCorrection;}
            set {CharacterMovementComponent_ptr->NetworkMinTimeBetweenClientAdjustmentsLargeCorrection = value;}
        }
        ///<summary>If client error is larger than this, sets bNetworkLargeClientCorrection to reduce delay between client adjustments.</summary>
        ///<remarks>
        ///@see NetworkMinTimeBetweenClientAdjustments, NetworkMinTimeBetweenClientAdjustmentsLargeCorrection
        ///</remarks>
        public unsafe float NetworkLargeClientCorrectionDistance {
            get {return CharacterMovementComponent_ptr->NetworkLargeClientCorrectionDistance;}
            set {CharacterMovementComponent_ptr->NetworkLargeClientCorrectionDistance = value;}
        }
        ///<summary>Used in determining if pawn is going off ledge.  If the ledge is "shorter" than this value then the pawn will be able to walk off it. *</summary>
        public unsafe float LedgeCheckThreshold {
            get {return CharacterMovementComponent_ptr->LedgeCheckThreshold;}
            set {CharacterMovementComponent_ptr->LedgeCheckThreshold = value;}
        }
        ///<summary>When exiting water, jump if control pitch angle is this high or above.</summary>
        public unsafe float JumpOutOfWaterPitch {
            get {return CharacterMovementComponent_ptr->JumpOutOfWaterPitch;}
            set {CharacterMovementComponent_ptr->JumpOutOfWaterPitch = value;}
        }
        ///<summary>Information about the floor the Character is standing on (updated only during walking movement).</summary>
        public unsafe FindFloorResult CurrentFloor {
            get {return CharacterMovementComponent_ptr->CurrentFloor;}
        }
        ///<summary>Default movement mode when not in water.</summary>
        ///<remarks>
        ///Used at player startup or when teleported.
        ///@see DefaultWaterMovementMode
        ///@see bRunPhysicsWithNoController
        ///</remarks>
        public unsafe byte DefaultLandMovementMode {
            get {return CharacterMovementComponent_ptr->DefaultLandMovementMode;}
            set {CharacterMovementComponent_ptr->DefaultLandMovementMode = value;}
        }
        ///<summary>Default movement mode when in water.</summary>
        ///<remarks>
        ///Used at player startup or when teleported.
        ///@see DefaultLandMovementMode
        ///@see bRunPhysicsWithNoController
        ///</remarks>
        public unsafe byte DefaultWaterMovementMode {
            get {return CharacterMovementComponent_ptr->DefaultWaterMovementMode;}
            set {CharacterMovementComponent_ptr->DefaultWaterMovementMode = value;}
        }
        ///<summary>Ground movement mode to switch to after falling and resuming ground movement.</summary>
        ///<remarks>
        ///Only allowed values are: MOVE_Walking, MOVE_NavWalking.
        ///@see SetGroundMovementMode(), GetGroundMovementMode()
        ///</remarks>
        public unsafe byte GroundMovementMode {
            get {return CharacterMovementComponent_ptr->GroundMovementMode;}
            set {CharacterMovementComponent_ptr->GroundMovementMode = value;}
        }
        public bool bMaintainHorizontalGroundVelocity {
            get {return Main.GetGetBoolPropertyByName(this, "bMaintainHorizontalGroundVelocity"); }
            set {Main.SetGetBoolPropertyByName(this, "bMaintainHorizontalGroundVelocity", value); }
        }
        public bool bImpartBaseVelocityX {
            get {return Main.GetGetBoolPropertyByName(this, "bImpartBaseVelocityX"); }
            set {Main.SetGetBoolPropertyByName(this, "bImpartBaseVelocityX", value); }
        }
        public bool bImpartBaseVelocityY {
            get {return Main.GetGetBoolPropertyByName(this, "bImpartBaseVelocityY"); }
            set {Main.SetGetBoolPropertyByName(this, "bImpartBaseVelocityY", value); }
        }
        public bool bImpartBaseVelocityZ {
            get {return Main.GetGetBoolPropertyByName(this, "bImpartBaseVelocityZ"); }
            set {Main.SetGetBoolPropertyByName(this, "bImpartBaseVelocityZ", value); }
        }
        public bool bImpartBaseAngularVelocity {
            get {return Main.GetGetBoolPropertyByName(this, "bImpartBaseAngularVelocity"); }
            set {Main.SetGetBoolPropertyByName(this, "bImpartBaseAngularVelocity", value); }
        }
        public bool bJustTeleported {
            get {return Main.GetGetBoolPropertyByName(this, "bJustTeleported"); }
            set {Main.SetGetBoolPropertyByName(this, "bJustTeleported", value); }
        }
        public bool bNetworkUpdateReceived {
            get {return Main.GetGetBoolPropertyByName(this, "bNetworkUpdateReceived"); }
            set {Main.SetGetBoolPropertyByName(this, "bNetworkUpdateReceived", value); }
        }
        public bool bNetworkMovementModeChanged {
            get {return Main.GetGetBoolPropertyByName(this, "bNetworkMovementModeChanged"); }
            set {Main.SetGetBoolPropertyByName(this, "bNetworkMovementModeChanged", value); }
        }
        public bool bIgnoreClientMovementErrorChecksAndCorrection {
            get {return Main.GetGetBoolPropertyByName(this, "bIgnoreClientMovementErrorChecksAndCorrection"); }
            set {Main.SetGetBoolPropertyByName(this, "bIgnoreClientMovementErrorChecksAndCorrection", value); }
        }
        public bool bNotifyApex {
            get {return Main.GetGetBoolPropertyByName(this, "bNotifyApex"); }
            set {Main.SetGetBoolPropertyByName(this, "bNotifyApex", value); }
        }
        public bool bCheatFlying {
            get {return Main.GetGetBoolPropertyByName(this, "bCheatFlying"); }
            set {Main.SetGetBoolPropertyByName(this, "bCheatFlying", value); }
        }
        public bool bWantsToCrouch {
            get {return Main.GetGetBoolPropertyByName(this, "bWantsToCrouch"); }
        }
        public bool bCrouchMaintainsBaseLocation {
            get {return Main.GetGetBoolPropertyByName(this, "bCrouchMaintainsBaseLocation"); }
            set {Main.SetGetBoolPropertyByName(this, "bCrouchMaintainsBaseLocation", value); }
        }
        public bool bIgnoreBaseRotation {
            get {return Main.GetGetBoolPropertyByName(this, "bIgnoreBaseRotation"); }
            set {Main.SetGetBoolPropertyByName(this, "bIgnoreBaseRotation", value); }
        }
        public bool bFastAttachedMove {
            get {return Main.GetGetBoolPropertyByName(this, "bFastAttachedMove"); }
            set {Main.SetGetBoolPropertyByName(this, "bFastAttachedMove", value); }
        }
        public bool bAlwaysCheckFloor {
            get {return Main.GetGetBoolPropertyByName(this, "bAlwaysCheckFloor"); }
            set {Main.SetGetBoolPropertyByName(this, "bAlwaysCheckFloor", value); }
        }
        public bool bUseFlatBaseForFloorChecks {
            get {return Main.GetGetBoolPropertyByName(this, "bUseFlatBaseForFloorChecks"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseFlatBaseForFloorChecks", value); }
        }
        public bool bPerformingJumpOff {
            get {return Main.GetGetBoolPropertyByName(this, "bPerformingJumpOff"); }
            set {Main.SetGetBoolPropertyByName(this, "bPerformingJumpOff", value); }
        }
        public bool bWantsToLeaveNavWalking {
            get {return Main.GetGetBoolPropertyByName(this, "bWantsToLeaveNavWalking"); }
            set {Main.SetGetBoolPropertyByName(this, "bWantsToLeaveNavWalking", value); }
        }
        public bool bUseRVOAvoidance {
            get {return Main.GetGetBoolPropertyByName(this, "bUseRVOAvoidance"); }
        }
        public bool bRequestedMoveUseAcceleration {
            get {return Main.GetGetBoolPropertyByName(this, "bRequestedMoveUseAcceleration"); }
            set {Main.SetGetBoolPropertyByName(this, "bRequestedMoveUseAcceleration", value); }
        }
        public bool bHasRequestedVelocity {
            get {return Main.GetGetBoolPropertyByName(this, "bHasRequestedVelocity"); }
            set {Main.SetGetBoolPropertyByName(this, "bHasRequestedVelocity", value); }
        }
        public bool bRequestedMoveWithMaxSpeed {
            get {return Main.GetGetBoolPropertyByName(this, "bRequestedMoveWithMaxSpeed"); }
            set {Main.SetGetBoolPropertyByName(this, "bRequestedMoveWithMaxSpeed", value); }
        }
        public bool bWasAvoidanceUpdated {
            get {return Main.GetGetBoolPropertyByName(this, "bWasAvoidanceUpdated"); }
            set {Main.SetGetBoolPropertyByName(this, "bWasAvoidanceUpdated", value); }
        }
        public bool bProjectNavMeshWalking {
            get {return Main.GetGetBoolPropertyByName(this, "bProjectNavMeshWalking"); }
        }
        public bool bProjectNavMeshOnBothWorldChannels {
            get {return Main.GetGetBoolPropertyByName(this, "bProjectNavMeshOnBothWorldChannels"); }
        }
        ///<summary>Avoidance Consideration Radius</summary>
        public unsafe float AvoidanceConsiderationRadius {
            get {return CharacterMovementComponent_ptr->AvoidanceConsiderationRadius;}
        }
        ///<summary>Velocity requested by path following.</summary>
        ///<remarks>
        ///@see RequestDirectMove()
        ///</remarks>
        public unsafe Vector RequestedVelocity {
            get {return CharacterMovementComponent_ptr->RequestedVelocity;}
            set {CharacterMovementComponent_ptr->RequestedVelocity = value;}
        }
        ///<summary>No default value, for now it's assumed to be valid if GetAvoidanceManager() returns non-NULL.</summary>
        public unsafe int AvoidanceUID {
            get {return CharacterMovementComponent_ptr->AvoidanceUID;}
        }
        ///<summary>Moving actor's group mask</summary>
        public unsafe NavAvoidanceMask AvoidanceGroup {
            get {return CharacterMovementComponent_ptr->AvoidanceGroup;}
        }
        ///<summary>Will avoid other agents if they are in one of specified groups</summary>
        public unsafe NavAvoidanceMask GroupsToAvoid {
            get {return CharacterMovementComponent_ptr->GroupsToAvoid;}
        }
        ///<summary>Will NOT avoid other agents if they are in one of specified groups, higher priority than GroupsToAvoid</summary>
        public unsafe NavAvoidanceMask GroupsToIgnore {
            get {return CharacterMovementComponent_ptr->GroupsToIgnore;}
        }
        ///<summary>De facto default value 0.5 (due to that being the default in the avoidance registration function), indicates RVO behavior.</summary>
        public unsafe float AvoidanceWeight {
            get {return CharacterMovementComponent_ptr->AvoidanceWeight;}
        }
        ///<summary>Temporarily holds launch velocity when pawn is to be launched so it happens at end of movement.</summary>
        public unsafe Vector PendingLaunchVelocity {
            get {return CharacterMovementComponent_ptr->PendingLaunchVelocity;}
            set {CharacterMovementComponent_ptr->PendingLaunchVelocity = value;}
        }
        ///<summary>How often we should raycast to project from navmesh to underlying geometry</summary>
        public unsafe float NavMeshProjectionInterval {
            get {return CharacterMovementComponent_ptr->NavMeshProjectionInterval;}
            set {CharacterMovementComponent_ptr->NavMeshProjectionInterval = value;}
        }
        ///<summary>Nav Mesh Projection Timer</summary>
        public unsafe float NavMeshProjectionTimer {
            get {return CharacterMovementComponent_ptr->NavMeshProjectionTimer;}
            set {CharacterMovementComponent_ptr->NavMeshProjectionTimer = value;}
        }
        ///<summary>Speed at which to interpolate agent navmesh offset between traces. 0: Instant (no interp) > 0: Interp speed")</summary>
        public unsafe float NavMeshProjectionInterpSpeed {
            get {return CharacterMovementComponent_ptr->NavMeshProjectionInterpSpeed;}
            set {CharacterMovementComponent_ptr->NavMeshProjectionInterpSpeed = value;}
        }
        ///<summary>Scale of the total capsule height to use for projection from navmesh to underlying geometry in the upward direction.</summary>
        ///<remarks>In other words, start the trace at [CapsuleHeight * NavMeshProjectionHeightScaleUp] above nav mesh.</remarks>
        public unsafe float NavMeshProjectionHeightScaleUp {
            get {return CharacterMovementComponent_ptr->NavMeshProjectionHeightScaleUp;}
            set {CharacterMovementComponent_ptr->NavMeshProjectionHeightScaleUp = value;}
        }
        ///<summary>Scale of the total capsule height to use for projection from navmesh to underlying geometry in the downward direction.</summary>
        ///<remarks>In other words, trace down to [CapsuleHeight * NavMeshProjectionHeightScaleDown] below nav mesh.</remarks>
        public unsafe float NavMeshProjectionHeightScaleDown {
            get {return CharacterMovementComponent_ptr->NavMeshProjectionHeightScaleDown;}
            set {CharacterMovementComponent_ptr->NavMeshProjectionHeightScaleDown = value;}
        }
        ///<summary>Ignore small differences in ground height between server and client data during NavWalking mode</summary>
        public unsafe float NavWalkingFloorDistTolerance {
            get {return CharacterMovementComponent_ptr->NavWalkingFloorDistTolerance;}
            set {CharacterMovementComponent_ptr->NavWalkingFloorDistTolerance = value;}
        }
        ///<summary>Post-physics tick function for this character</summary>
        public unsafe CharacterMovementComponentPostPhysicsTickFunction PostPhysicsTickFunction {
            get {return CharacterMovementComponent_ptr->PostPhysicsTickFunction;}
            set {CharacterMovementComponent_ptr->PostPhysicsTickFunction = value;}
        }
        ///<summary>Minimum time between client TimeStamp resets.</summary>
        ///<remarks>
        ///!! This has to be large enough so that we don't confuse the server if the client can stall or timeout.
        ///       We do this as we use floats for TimeStamps, and server derives DeltaTime from two TimeStamps.
        ///       As time goes on, accuracy decreases from those floating point numbers.
        ///       So we trigger a TimeStamp reset at regular intervals to maintain a high level of accuracy.
        ///</remarks>
        public unsafe float MinTimeBetweenTimeStampResets {
            get {return CharacterMovementComponent_ptr->MinTimeBetweenTimeStampResets;}
            set {CharacterMovementComponent_ptr->MinTimeBetweenTimeStampResets = value;}
        }
        ///<summary>Root Motion Group containing active root motion sources being applied to movement</summary>
        public unsafe RootMotionSourceGroup CurrentRootMotion {
            get {return CharacterMovementComponent_ptr->CurrentRootMotion;}
            set {CharacterMovementComponent_ptr->CurrentRootMotion = value;}
        }
        ///<summary>Root Motion movement params.</summary>
        ///<remarks>
        ///Holds result of anim montage root motion during PerformMovement(), and is overridden
        /// during autonomous move playback to force historical root motion for MoveAutonomous() calls
        ///</remarks>
        public unsafe RootMotionMovementParams RootMotionParams {
            get {return CharacterMovementComponent_ptr->RootMotionParams;}
            set {CharacterMovementComponent_ptr->RootMotionParams = value;}
        }
        ///<summary>Velocity extracted from RootMotionParams when there is anim root motion active. Invalid to use when HasAnimRootMotion() returns false.</summary>
        public unsafe Vector AnimRootMotionVelocity {
            get {return CharacterMovementComponent_ptr->AnimRootMotionVelocity;}
            set {CharacterMovementComponent_ptr->AnimRootMotionVelocity = value;}
        }
        public bool bWasSimulatingRootMotion {
            get {return Main.GetGetBoolPropertyByName(this, "bWasSimulatingRootMotion"); }
            set {Main.SetGetBoolPropertyByName(this, "bWasSimulatingRootMotion", value); }
        }
        public bool bAllowPhysicsRotationDuringAnimRootMotion {
            get {return Main.GetGetBoolPropertyByName(this, "bAllowPhysicsRotationDuringAnimRootMotion"); }
            set {Main.SetGetBoolPropertyByName(this, "bAllowPhysicsRotationDuringAnimRootMotion", value); }
        }
        static CharacterMovementComponent() {
            StaticClass = Main.GetClass("CharacterMovementComponent");
        }
        internal unsafe CharacterMovementComponent_fields* CharacterMovementComponent_ptr => (CharacterMovementComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator CharacterMovementComponent(IntPtr p) => UObject.Make<CharacterMovementComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static CharacterMovementComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static CharacterMovementComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
