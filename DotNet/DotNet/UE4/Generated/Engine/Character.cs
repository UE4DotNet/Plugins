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
    ///<summary>Characters are Pawns that have a mesh, collision, and built-in movement logic.</summary>
    ///<remarks>
    ///They are responsible for all physical interaction between the player or AI and the world, and also implement basic networking and input models.
    ///They are designed for a vertically-oriented player representation that can walk, jump, fly, and swim through the world using CharacterMovementComponent.
    ///
    ///@see APawn, UCharacterMovementComponent
    ///@see https://docs.unrealengine.com/latest/INT/Gameplay/Framework/Pawn/Character/
    ///</remarks>
    public unsafe partial class Character : Pawn  {

        ///<summary>Event when Character stops crouching.</summary>
        ///<remarks>
        ///@param       HalfHeightAdjust                difference between default collision half-height, and actual crouched capsule half-height.
        ///@param       ScaledHalfHeightAdjust  difference after component scale is taken in to account.
        ///</remarks>
        public event K2_OnEndCrouch_delegate K2_OnEndCrouch;
        public delegate void K2_OnEndCrouch_delegate(float HalfHeightAdjust, float ScaledHalfHeightAdjust);
        internal void on_K2_OnEndCrouch(float HalfHeightAdjust, float ScaledHalfHeightAdjust) =>
            K2_OnEndCrouch?.Invoke(HalfHeightAdjust, ScaledHalfHeightAdjust);


        ///<summary>Called from CharacterMovementComponent to notify the character that the movement mode has changed.</summary>
        ///<remarks>
        ///@param       PrevMovementMode        Movement mode before the change
        ///@param       NewMovementMode         New movement mode
        ///@param       PrevCustomMode          Custom mode before the change (applicable if PrevMovementMode is Custom)
        ///@param       NewCustomMode           New custom mode (applicable if NewMovementMode is Custom)
        ///</remarks>
        public event K2_OnMovementModeChanged_delegate K2_OnMovementModeChanged;
        public delegate void K2_OnMovementModeChanged_delegate(byte PrevMovementMode, byte NewMovementMode, byte PrevCustomMode, byte NewCustomMode);
        internal void on_K2_OnMovementModeChanged(byte PrevMovementMode, byte NewMovementMode, byte PrevCustomMode, byte NewCustomMode) =>
            K2_OnMovementModeChanged?.Invoke(PrevMovementMode, NewMovementMode, PrevCustomMode, NewCustomMode);


        ///<summary>Event when Character crouches.</summary>
        ///<remarks>
        ///@param       HalfHeightAdjust                difference between default collision half-height, and actual crouched capsule half-height.
        ///@param       ScaledHalfHeightAdjust  difference after component scale is taken in to account.
        ///</remarks>
        public event K2_OnStartCrouch_delegate K2_OnStartCrouch;
        public delegate void K2_OnStartCrouch_delegate(float HalfHeightAdjust, float ScaledHalfHeightAdjust);
        internal void on_K2_OnStartCrouch(float HalfHeightAdjust, float ScaledHalfHeightAdjust) =>
            K2_OnStartCrouch?.Invoke(HalfHeightAdjust, ScaledHalfHeightAdjust);


        ///<summary>Event for implementing custom character movement mode.</summary>
        ///<remarks>
        ///Called by CharacterMovement if MovementMode is set to Custom.
        ///@note C++ code should override UCharacterMovementComponent::PhysCustom() instead.
        ///@see UCharacterMovementComponent::PhysCustom()
        ///</remarks>
        public event K2_UpdateCustomMovement_delegate K2_UpdateCustomMovement;
        public delegate void K2_UpdateCustomMovement_delegate(float DeltaTime);
        internal void on_K2_UpdateCustomMovement(float DeltaTime) =>
            K2_UpdateCustomMovement?.Invoke(DeltaTime);


        ///<summary>Called upon landing when falling, to perform actions based on the Hit result.</summary>
        ///<remarks>
        ///Note that movement mode is still "Falling" during this event. Current Velocity value is the velocity at the time of landing.
        ///Consider OnMovementModeChanged() as well, as that can be used once the movement mode changes to the new mode (most likely Walking).
        ///
        ///@param Hit Result describing the landing that resulted in a valid landing spot.
        ///@see OnMovementModeChanged()
        ///</remarks>
        public event OnLanded_delegate OnLanded;
        public delegate HitResult OnLanded_delegate(HitResult Hit);
        internal HitResult on_OnLanded(HitResult Hit) =>
            OnLanded != null ? OnLanded(Hit) : Hit;


        ///<summary>Let blueprint know that we were launched</summary>
        public event OnLaunched_delegate OnLaunched;
        public delegate void OnLaunched_delegate(Vector LaunchVelocity, bool bXYOverride, bool bZOverride);
        internal void on_OnLaunched(Vector LaunchVelocity, bool bXYOverride, bool bZOverride) =>
            OnLaunched?.Invoke(LaunchVelocity, bXYOverride, bZOverride);


        ///<summary>Customizable event to check if the character can jump in the current state.</summary>
        ///<remarks>
        ///Default implementation returns true if the character is on the ground and not crouching,
        ///has a valid CharacterMovementComponent and CanEverJump() returns true.
        ///Default implementation also allows for 'hold to jump higher' functionality:
        ///As well as returning true when on the ground, it also returns true when GetMaxJumpTime is more
        ///than zero and IsJumping returns true.
        ///
        ///
        ///@Return Whether the character can jump in the current state.
        ///</remarks>
        public event CanJumpInternal_delegate CanJumpInternal;
        public delegate bool CanJumpInternal_delegate(bool ReturnValue);
        internal bool on_CanJumpInternal(bool ReturnValue) =>
            CanJumpInternal != null ? CanJumpInternal(ReturnValue) : ReturnValue;


        ///<summary>Event fired when the character has just started jumping</summary>
        public event OnJumped_delegate OnJumped;
        public delegate void OnJumped_delegate();
        internal void on_OnJumped() =>
            OnJumped?.Invoke();


        ///<summary>Event fired when the Character is walking off a surface and is about to fall because CharacterMovement->CurrentFloor became unwalkable.</summary>
        ///<remarks>
        ///If CharacterMovement->MovementMode does not change during this event then the character will automatically start falling afterwards.
        ///@note Z velocity is zero during walking movement, and will be here as well. Another velocity can be computed here if desired and will be used when starting to fall.
        ///
        ///@param  PreviousFloorImpactNormal Normal of the previous walkable floor.
        ///@param  PreviousFloorContactNormal Normal of the contact with the previous walkable floor.
        ///@param  PreviousLocation     Previous character location before movement off the ledge.
        ///@param  TimeTick     Time delta of movement update resulting in moving off the ledge.
        ///</remarks>
        public event OnWalkingOffLedge_delegate OnWalkingOffLedge;
        public delegate (Vector, Vector, Vector) OnWalkingOffLedge_delegate(Vector PreviousFloorImpactNormal, Vector PreviousFloorContactNormal, Vector PreviousLocation, float TimeDelta);
        internal (Vector, Vector, Vector) on_OnWalkingOffLedge(Vector PreviousFloorImpactNormal, Vector PreviousFloorContactNormal, Vector PreviousLocation, float TimeDelta) =>
            OnWalkingOffLedge != null ? OnWalkingOffLedge(PreviousFloorImpactNormal, PreviousFloorContactNormal, PreviousLocation, TimeDelta) : (PreviousFloorImpactNormal, PreviousFloorContactNormal, PreviousLocation);


        ///<summary>Cache mesh offset from capsule.</summary>
        ///<remarks>
        ///This is used as the target for network smoothing interpolation, when the mesh is offset with lagged smoothing.
        ///This is automatically called during initialization; call this at runtime if you intend to change the default mesh offset from the capsule.
        ///@see GetBaseTranslationOffset(), GetBaseRotationOffset()
        ///</remarks>
        public void CacheInitialMeshOffset(Vector MeshRelativeLocation, Rotator MeshRelativeRotation)  => 
            Character_methods.CacheInitialMeshOffset_method.Invoke(ObjPointer, MeshRelativeLocation, MeshRelativeRotation);

        ///<summary>Check if the character can jump in the current state.</summary>
        ///<remarks>
        ///The default implementation may be overridden or extended by implementing the custom CanJump event in Blueprints.
        ///
        ///@Return Whether the character can jump in the current state.
        ///</remarks>
        public bool CanJump()  => 
            Character_methods.CanJump_method.Invoke(ObjPointer);

        ///<summary>Request the character to start crouching.</summary>
        ///<remarks>
        ///The request is processed on the next update of the CharacterMovementComponent.
        ///@see OnStartCrouch
        ///@see IsCrouched
        ///@see CharacterMovement->WantsToCrouch
        ///</remarks>
        public void Crouch(bool bClientSimulation)  => 
            Character_methods.Crouch_method.Invoke(ObjPointer, bClientSimulation);

        ///<summary>Returns current value of AnimRootMotionScale</summary>
        public float GetAnimRootMotionTranslationScale()  => 
            Character_methods.GetAnimRootMotionTranslationScale_method.Invoke(ObjPointer);

        ///<summary>Get the saved rotation offset of mesh. This is how much extra rotation is applied from the capsule rotation.</summary>
        public Rotator GetBaseRotationOffsetRotator()  => 
            Character_methods.GetBaseRotationOffsetRotator_method.Invoke(ObjPointer);

        ///<summary>Get the saved translation offset of mesh. This is how much extra offset is applied from the center of the capsule.</summary>
        public Vector GetBaseTranslationOffset()  => 
            Character_methods.GetBaseTranslationOffset_method.Invoke(ObjPointer);

        ///<summary>Return current playing Montage *</summary>
        public AnimMontage GetCurrentMontage()  => 
            Character_methods.GetCurrentMontage_method.Invoke(ObjPointer);

        ///<summary>True if jump is actively providing a force, such as when the jump key is held and the time it has been held is less than JumpMaxHoldTime.</summary>
        ///<remarks>
        ///@see CharacterMovement->IsFalling
        ///</remarks>
        public bool IsJumpProvidingForce()  => 
            Character_methods.IsJumpProvidingForce_method.Invoke(ObjPointer);

        ///<summary>True if we are playing Root Motion right now, through a Montage with RootMotionMode == ERootMotionMode::RootMotionFromMontagesOnly.</summary>
        ///<remarks>This means code path for networked root motion is enabled.</remarks>
        public bool IsPlayingNetworkedRootMotionMontage()  => 
            Character_methods.IsPlayingNetworkedRootMotionMontage_method.Invoke(ObjPointer);

        ///<summary>True if we are playing Root Motion right now</summary>
        public bool IsPlayingRootMotion()  => 
            Character_methods.IsPlayingRootMotion_method.Invoke(ObjPointer);

        ///<summary>Make the character jump on the next update.</summary>
        ///<remarks>
        ///If you want your character to jump according to the time that the jump key is held,
        ///then you can set JumpKeyHoldTime to some non-zero value. Make sure in this case to
        ///call StopJumping() when you want the jump's z-velocity to stop being applied (such
        ///as on a button up event), otherwise the character will carry on receiving the
        ///velocity until JumpKeyHoldTime is reached.
        ///</remarks>
        public void Jump()  => 
            Character_methods.Jump_method.Invoke(ObjPointer);

        ///<summary>Set a pending launch velocity on the Character.</summary>
        ///<remarks>
        ///This velocity will be processed on the next CharacterMovementComponent tick,
        ///and will set it to the "falling" state. Triggers the OnLaunched event.
        ///@PARAM LaunchVelocity is the velocity to impart to the Character
        ///@PARAM bXYOverride if true replace the XY part of the Character's velocity instead of adding to it.
        ///@PARAM bZOverride if true replace the Z component of the Character's velocity instead of adding to it.
        ///</remarks>
        public void LaunchCharacter(Vector LaunchVelocity, bool bXYOverride, bool bZOverride)  => 
            Character_methods.LaunchCharacter_method.Invoke(ObjPointer, LaunchVelocity, bXYOverride, bZOverride);

        ///<summary>Play Animation Montage on the character mesh *</summary>
        public float PlayAnimMontage(AnimMontage AnimMontage, float InPlayRate, Name StartSectionName)  => 
            Character_methods.PlayAnimMontage_method.Invoke(ObjPointer, AnimMontage, InPlayRate, StartSectionName);

        ///<summary>Stop Animation Montage. If nullptr, it will stop what's currently active. The Blend Out Time is taken from the montage asset that is being stopped. *</summary>
        public void StopAnimMontage(AnimMontage AnimMontage)  => 
            Character_methods.StopAnimMontage_method.Invoke(ObjPointer, AnimMontage);

        ///<summary>Stop the character from jumping on the next update.</summary>
        ///<remarks>
        ///Call this from an input event (such as a button 'up' event) to cease applying
        ///jump Z-velocity. If this is not called, then jump z-velocity will be applied
        ///until JumpMaxHoldTime is reached.
        ///</remarks>
        public void StopJumping()  => 
            Character_methods.StopJumping_method.Invoke(ObjPointer);

        ///<summary>Request the character to stop crouching.</summary>
        ///<remarks>
        ///The request is processed on the next update of the CharacterMovementComponent.
        ///@see OnEndCrouch
        ///@see IsCrouched
        ///@see CharacterMovement->WantsToCrouch
        ///</remarks>
        public void UnCrouch(bool bClientSimulation)  => 
            Character_methods.UnCrouch_method.Invoke(ObjPointer, bClientSimulation);
        ///<summary>The main skeletal mesh associated with this Character (optional sub-object).</summary>
        public unsafe SkeletalMeshComponent Mesh {
            get {return Character_ptr->Mesh;}
        }
        ///<summary>Movement component used for movement logic in various movement modes (walking, falling, etc), containing relevant settings and functions to control movement.</summary>
        public unsafe CharacterMovementComponent CharacterMovement {
            get {return Character_ptr->CharacterMovement;}
        }
        ///<summary>The CapsuleComponent being used for movement collision (by CharacterMovement). Always treated as being vertically aligned in simple collision check functions.</summary>
        public unsafe CapsuleComponent CapsuleComponent {
            get {return Character_ptr->CapsuleComponent;}
        }
        ///<summary>Component shown in the editor only to indicate character facing</summary>
        public unsafe ArrowComponent ArrowComponent {
            get {return Character_ptr->ArrowComponent;}
            set {Character_ptr->ArrowComponent = value;}
        }
        ///<summary>Info about our current movement base (object we are standing on).</summary>
        public unsafe BasedMovementInfo BasedMovement {
            get {return Character_ptr->BasedMovement;}
            set {Character_ptr->BasedMovement = value;}
        }
        ///<summary>Replicated version of relative movement. Read-only on simulated proxies!</summary>
        public unsafe BasedMovementInfo ReplicatedBasedMovement {
            get {return Character_ptr->ReplicatedBasedMovement;}
            set {Character_ptr->ReplicatedBasedMovement = value;}
        }
        ///<summary>Scale to apply to root motion translation on this Character</summary>
        public unsafe float AnimRootMotionTranslationScale {
            get {return Character_ptr->AnimRootMotionTranslationScale;}
            set {Character_ptr->AnimRootMotionTranslationScale = value;}
        }
        ///<summary>Saved translation offset of mesh.</summary>
        public unsafe Vector BaseTranslationOffset {
            get {return Character_ptr->BaseTranslationOffset;}
            set {Character_ptr->BaseTranslationOffset = value;}
        }
        ///<summary>Saved rotation offset of mesh.</summary>
        public unsafe Quat BaseRotationOffset {
            get {return Character_ptr->BaseRotationOffset;}
            set {Character_ptr->BaseRotationOffset = value;}
        }
        ///<summary>CharacterMovement ServerLastTransformUpdateTimeStamp value, replicated to simulated proxies.</summary>
        public unsafe float ReplicatedServerLastTransformUpdateTimeStamp {
            get {return Character_ptr->ReplicatedServerLastTransformUpdateTimeStamp;}
            set {Character_ptr->ReplicatedServerLastTransformUpdateTimeStamp = value;}
        }
        ///<summary>Replay Last Transform Update Time Stamp</summary>
        public unsafe float ReplayLastTransformUpdateTimeStamp {
            get {return Character_ptr->ReplayLastTransformUpdateTimeStamp;}
            set {Character_ptr->ReplayLastTransformUpdateTimeStamp = value;}
        }
        ///<summary>CharacterMovement MovementMode (and custom mode) replicated for simulated proxies. Use CharacterMovementComponent::UnpackNetworkMovementMode() to translate it.</summary>
        public unsafe byte ReplicatedMovementMode {
            get {return Character_ptr->ReplicatedMovementMode;}
            set {Character_ptr->ReplicatedMovementMode = value;}
        }
        public bool bInBaseReplication {
            get {return Main.GetGetBoolPropertyByName(this, "bInBaseReplication"); }
            set {Main.SetGetBoolPropertyByName(this, "bInBaseReplication", value); }
        }
        ///<summary>Default crouched eye height</summary>
        public unsafe float CrouchedEyeHeight {
            get {return Character_ptr->CrouchedEyeHeight;}
            set {Character_ptr->CrouchedEyeHeight = value;}
        }
        public bool bIsCrouched {
            get {return Main.GetGetBoolPropertyByName(this, "bIsCrouched"); }
        }
        public bool bProxyIsJumpForceApplied {
            get {return Main.GetGetBoolPropertyByName(this, "bProxyIsJumpForceApplied"); }
            set {Main.SetGetBoolPropertyByName(this, "bProxyIsJumpForceApplied", value); }
        }
        public bool bPressedJump {
            get {return Main.GetGetBoolPropertyByName(this, "bPressedJump"); }
        }
        public bool bClientUpdating {
            get {return Main.GetGetBoolPropertyByName(this, "bClientUpdating"); }
            set {Main.SetGetBoolPropertyByName(this, "bClientUpdating", value); }
        }
        public bool bClientWasFalling {
            get {return Main.GetGetBoolPropertyByName(this, "bClientWasFalling"); }
            set {Main.SetGetBoolPropertyByName(this, "bClientWasFalling", value); }
        }
        public bool bClientResimulateRootMotion {
            get {return Main.GetGetBoolPropertyByName(this, "bClientResimulateRootMotion"); }
            set {Main.SetGetBoolPropertyByName(this, "bClientResimulateRootMotion", value); }
        }
        public bool bClientResimulateRootMotionSources {
            get {return Main.GetGetBoolPropertyByName(this, "bClientResimulateRootMotionSources"); }
            set {Main.SetGetBoolPropertyByName(this, "bClientResimulateRootMotionSources", value); }
        }
        public bool bSimGravityDisabled {
            get {return Main.GetGetBoolPropertyByName(this, "bSimGravityDisabled"); }
            set {Main.SetGetBoolPropertyByName(this, "bSimGravityDisabled", value); }
        }
        public bool bClientCheckEncroachmentOnNetUpdate {
            get {return Main.GetGetBoolPropertyByName(this, "bClientCheckEncroachmentOnNetUpdate"); }
            set {Main.SetGetBoolPropertyByName(this, "bClientCheckEncroachmentOnNetUpdate", value); }
        }
        public bool bServerMoveIgnoreRootMotion {
            get {return Main.GetGetBoolPropertyByName(this, "bServerMoveIgnoreRootMotion"); }
            set {Main.SetGetBoolPropertyByName(this, "bServerMoveIgnoreRootMotion", value); }
        }
        public bool bWasJumping {
            get {return Main.GetGetBoolPropertyByName(this, "bWasJumping"); }
        }
        ///<summary>Jump key Held Time.</summary>
        ///<remarks>This is the time that the player has held the jump key, in seconds.</remarks>
        public unsafe float JumpKeyHoldTime {
            get {return Character_ptr->JumpKeyHoldTime;}
        }
        ///<summary>Amount of jump force time remaining, if JumpMaxHoldTime > 0.</summary>
        public unsafe float JumpForceTimeRemaining {
            get {return Character_ptr->JumpForceTimeRemaining;}
        }
        ///<summary>Track last time a jump force started for a proxy.</summary>
        public unsafe float ProxyJumpForceStartedTime {
            get {return Character_ptr->ProxyJumpForceStartedTime;}
        }
        ///<summary>The max time the jump key can be held.</summary>
        ///<remarks>
        ///Note that if StopJumping() is not called before the max jump hold time is reached,
        ///then the character will carry on receiving vertical velocity. Therefore it is usually
        ///best to call StopJumping() when jump input has ceased (such as a button up event).
        ///</remarks>
        public unsafe float JumpMaxHoldTime {
            get {return Character_ptr->JumpMaxHoldTime;}
            set {Character_ptr->JumpMaxHoldTime = value;}
        }
        ///<summary>The max number of jumps the character can perform.</summary>
        ///<remarks>
        ///Note that if JumpMaxHoldTime is non zero and StopJumping is not called, the player
        ///may be able to perform and unlimited number of jumps. Therefore it is usually
        ///best to call StopJumping() when jump input has ceased (such as a button up event).
        ///</remarks>
        public unsafe int JumpMaxCount {
            get {return Character_ptr->JumpMaxCount;}
            set {Character_ptr->JumpMaxCount = value;}
        }
        ///<summary>Tracks the current number of jumps performed.</summary>
        ///<remarks>
        ///This is incremented in CheckJumpInput, used in CanJump_Implementation, and reset in OnMovementModeChanged.
        ///When providing overrides for these methods, it's recommended to either manually
        ///increment / reset this value, or call the Super:: method.
        ///</remarks>
        public unsafe int JumpCurrentCount {
            get {return Character_ptr->JumpCurrentCount;}
        }
         //TODO: multicast delegate FCharacterReachedApexSignature OnReachedJumpApex
         //TODO: multicast delegate FMovementModeChangedSignature MovementModeChangedDelegate
         //TODO: multicast delegate FCharacterMovementUpdatedSignature OnCharacterMovementUpdated
        ///<summary>For LocallyControlled Autonomous clients.</summary>
        ///<remarks>
        ///During a PerformMovement() after root motion is prepared, we save it off into this and
        ///then record it into our SavedMoves.
        ///During SavedMove playback we use it as our "Previous Move" SavedRootMotion which includes
        ///last received root motion from the Server
        ///</remarks>
        public unsafe RootMotionSourceGroup SavedRootMotion {
            get {return Character_ptr->SavedRootMotion;}
            set {Character_ptr->SavedRootMotion = value;}
        }
        ///<summary>For LocallyControlled Autonomous clients. Saved root motion data to be used by SavedMoves.</summary>
        public unsafe RootMotionMovementParams ClientRootMotionParams {
            get {return Character_ptr->ClientRootMotionParams;}
            set {Character_ptr->ClientRootMotionParams = value;}
        }
         //TODO: array not UObject TArray RootMotionRepMoves
        ///<summary>Replicated Root Motion montage</summary>
        public unsafe RepRootMotionMontage RepRootMotion {
            get {return Character_ptr->RepRootMotion;}
            set {Character_ptr->RepRootMotion = value;}
        }
        static Character() {
            StaticClass = Main.GetClass("Character");
            Character_events.K2_OnEndCrouch_event.Setup();
            Character_events.K2_OnMovementModeChanged_event.Setup();
            Character_events.K2_OnStartCrouch_event.Setup();
            Character_events.K2_UpdateCustomMovement_event.Setup();
            Character_events.OnLanded_event.Setup();
            Character_events.OnLaunched_event.Setup();
            Character_events.CanJumpInternal_event.Setup();
            Character_events.OnJumped_event.Setup();
            Character_events.OnWalkingOffLedge_event.Setup();
        }
        internal unsafe Character_fields* Character_ptr => (Character_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator Character(IntPtr p) => UObject.Make<Character>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static Character DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static Character New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
