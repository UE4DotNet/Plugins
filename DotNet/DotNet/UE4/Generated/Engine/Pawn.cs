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
    ///<summary>Pawn is the base class of all actors that can be possessed by players or AI.</summary>
    ///<remarks>
    ///They are the physical representations of players and creatures in a level.
    ///
    ///@see https://docs.unrealengine.com/latest/INT/Gameplay/Framework/Pawn/
    ///</remarks>
    public unsafe partial class Pawn : Actor  {

        ///<summary>Event called when the Pawn is possessed by a Controller (normally only occurs on the server/standalone).</summary>
        public event ReceivePossessed_delegate ReceivePossessed;
        public delegate void ReceivePossessed_delegate(Controller NewController);
        internal void on_ReceivePossessed(Controller NewController) =>
            ReceivePossessed?.Invoke(NewController);


        ///<summary>Event called when the Pawn is no longer possessed by a Controller.</summary>
        public event ReceiveUnpossessed_delegate ReceiveUnpossessed;
        public delegate void ReceiveUnpossessed_delegate(Controller OldController);
        internal void on_ReceiveUnpossessed(Controller OldController) =>
            ReceiveUnpossessed?.Invoke(OldController);


        ///<summary>Add input (affecting Pitch) to the Controller's ControlRotation, if it is a local PlayerController.</summary>
        ///<remarks>
        ///This value is multiplied by the PlayerController's InputPitchScale value.
        ///@param Val Amount to add to Pitch. This value is multiplied by the PlayerController's InputPitchScale value.
        ///@see PlayerController::InputPitchScale
        ///</remarks>
        public void AddControllerPitchInput(float Val)  => 
            Pawn_methods.AddControllerPitchInput_method.Invoke(ObjPointer, Val);

        ///<summary>Add input (affecting Roll) to the Controller's ControlRotation, if it is a local PlayerController.</summary>
        ///<remarks>
        ///This value is multiplied by the PlayerController's InputRollScale value.
        ///@param Val Amount to add to Roll. This value is multiplied by the PlayerController's InputRollScale value.
        ///@see PlayerController::InputRollScale
        ///</remarks>
        public void AddControllerRollInput(float Val)  => 
            Pawn_methods.AddControllerRollInput_method.Invoke(ObjPointer, Val);

        ///<summary>Add input (affecting Yaw) to the Controller's ControlRotation, if it is a local PlayerController.</summary>
        ///<remarks>
        ///This value is multiplied by the PlayerController's InputYawScale value.
        ///@param Val Amount to add to Yaw. This value is multiplied by the PlayerController's InputYawScale value.
        ///@see PlayerController::InputYawScale
        ///</remarks>
        public void AddControllerYawInput(float Val)  => 
            Pawn_methods.AddControllerYawInput_method.Invoke(ObjPointer, Val);

        ///<summary>Add movement input along the given world direction vector (usually normalized) scaled by 'ScaleValue'.</summary>
        ///<remarks>
        ///If ScaleValue < 0, movement will be in the opposite direction.
        ///Base Pawn classes won't automatically apply movement, it's up to the user to do so in a Tick event. Subclasses such as Character and DefaultPawn automatically handle this input and move.
        ///
        ///@param WorldDirection        Direction in world space to apply input
        ///@param ScaleValue            Scale to apply to input. This can be used for analog input, ie a value of 0.5 applies half the normal value, while -1.0 would reverse the direction.
        ///@param bForce                        If true always add the input, ignoring the result of IsMoveInputIgnored().
        ///@see GetPendingMovementInputVector(), GetLastMovementInputVector(), ConsumeMovementInputVector()
        ///</remarks>
        public void AddMovementInput(Vector WorldDirection, float ScaleValue, bool bForce)  => 
            Pawn_methods.AddMovementInput_method.Invoke(ObjPointer, WorldDirection, ScaleValue, bForce);

        ///<summary>Returns the pending input vector and resets it to zero.</summary>
        ///<remarks>
        ///This should be used during a movement update (by the Pawn or PawnMovementComponent) to prevent accumulation of control input between frames.
        ///Copies the pending input vector to the saved input vector (GetLastMovementInputVector()).
        ///@return The pending input vector.
        ///</remarks>
        public Vector ConsumeMovementInputVector()  => 
            Pawn_methods.ConsumeMovementInputVector_method.Invoke(ObjPointer);

        ///<summary>Call this function to detach safely pawn from its controller, knowing that we will be destroyed soon.</summary>
        public void DetachFromControllerPendingDestroy()  => 
            Pawn_methods.DetachFromControllerPendingDestroy_method.Invoke(ObjPointer);

        ///<summary>Return the aim rotation for the Pawn.</summary>
        ///<remarks>
        ///If we have a controller, by default we aim at the player's 'eyes' direction
        ///that is by default the Pawn rotation for AI, and camera (crosshair) rotation for human players.
        ///</remarks>
        public Rotator GetBaseAimRotation()  => 
            Pawn_methods.GetBaseAimRotation_method.Invoke(ObjPointer);

        ///<summary>Returns controller for this actor.</summary>
        public Controller GetController()  => 
            Pawn_methods.GetController_method.Invoke(ObjPointer);

        ///<summary>Get the rotation of the Controller, often the 'view' rotation of this Pawn.</summary>
        public Rotator GetControlRotation()  => 
            Pawn_methods.GetControlRotation_method.Invoke(ObjPointer);

        ///<summary>Return the last input vector in world space that was processed by ConsumeMovementInputVector(), which is usually done by the Pawn or PawnMovementComponent.</summary>
        ///<remarks>
        ///Any user that needs to know about the input that last affected movement should use this function.
        ///For example an animation update would want to use this, since by default the order of updates in a frame is:
        ///PlayerController (device input) -> MovementComponent -> Pawn -> Mesh (animations)
        ///
        ///@return The last input vector in world space that was processed by ConsumeMovementInputVector().
        ///@see AddMovementInput(), GetPendingMovementInputVector(), ConsumeMovementInputVector()
        ///</remarks>
        public Vector GetLastMovementInputVector()  => 
            Pawn_methods.GetLastMovementInputVector_method.Invoke(ObjPointer);

        ///<summary>Gets the owning actor of the Movement Base Component on which the pawn is standing.</summary>
        public static Actor GetMovementBaseActor(Pawn Pawn)  => 
            Pawn_methods.GetMovementBaseActor_method.Invoke(Pawn);

        ///<summary>Return our PawnMovementComponent, if we have one.</summary>
        public PawnMovementComponent GetMovementComponent()  => 
            Pawn_methods.GetMovementComponent_method.Invoke(ObjPointer);

        ///<summary>Basically retrieved pawn's location on navmesh</summary>
        public Vector GetNavAgentLocation()  => 
            Pawn_methods.GetNavAgentLocation_method.Invoke(ObjPointer);

        ///<summary>Return the pending input vector in world space.</summary>
        ///<remarks>
        ///This is the most up-to-date value of the input vector, pending ConsumeMovementInputVector() which clears it,
        ///Usually only a PawnMovementComponent will want to read this value, or the Pawn itself if it is responsible for movement.
        ///
        ///@return The pending input vector in world space.
        ///@see AddMovementInput(), GetLastMovementInputVector(), ConsumeMovementInputVector()
        ///</remarks>
        public Vector GetPendingMovementInputVector()  => 
            Pawn_methods.GetPendingMovementInputVector_method.Invoke(ObjPointer);

        ///<summary>See if this actor is currently being controlled</summary>
        public bool IsControlled()  => 
            Pawn_methods.IsControlled_method.Invoke(ObjPointer);

        ///<summary>@return true if controlled by a local (not network) Controller.</summary>
        public bool IsLocallyControlled()  => 
            Pawn_methods.IsLocallyControlled_method.Invoke(ObjPointer);

        ///<summary>Helper to see if move input is ignored. If our controller is a PlayerController, checks Controller->IsMoveInputIgnored().</summary>
        public bool IsMoveInputIgnored()  => 
            Pawn_methods.IsMoveInputIgnored_method.Invoke(ObjPointer);

        ///<summary>@return true if controlled by a human player (possessed by a PlayerController).</summary>
        public bool IsPlayerControlled()  => 
            Pawn_methods.IsPlayerControlled_method.Invoke(ObjPointer);

        ///<summary>(Deprecated) Return the input vector in world space.</summary>
        public Vector K2_GetMovementInputVector()  => 
            Pawn_methods.K2_GetMovementInputVector_method.Invoke(ObjPointer);

        ///<summary>Launch Pawn</summary>
        public void LaunchPawn(Vector LaunchVelocity, bool bXYOverride, bool bZOverride)  => 
            Pawn_methods.LaunchPawn_method.Invoke(ObjPointer, LaunchVelocity, bXYOverride, bZOverride);

        ///<summary>
        ///Inform AIControllers that you've made a noise they might hear (they are sent a HearNoise message if they have bHearNoises==true)
        ///The instigator of this sound is the pawn which is used to call MakeNoise.
        ///</summary>
        ///<remarks>
        ///@param Loudness - is the relative loudness of this noise (range 0.0 to 1.0).  Directly affects the hearing range specified by the AI's HearingThreshold.
        ///@param NoiseLocation - Position of noise source.  If zero vector, use the actor's location.
        ///@param bUseNoiseMakerLocation - If true, use the location of the NoiseMaker rather than NoiseLocation.  If false, use NoiseLocation.
        ///@param NoiseMaker - Which actor is the source of the noise.  Not to be confused with the Noise Instigator, which is responsible for the noise (and is the pawn on which this function is called).  If not specified, the pawn instigating the noise will be used as the NoiseMaker
        ///</remarks>
        public void PawnMakeNoise(float Loudness, Vector NoiseLocation, bool bUseNoiseMakerLocation, Actor NoiseMaker)  => 
            Pawn_methods.PawnMakeNoise_method.Invoke(ObjPointer, Loudness, NoiseLocation, bUseNoiseMakerLocation, NoiseMaker);

        ///<summary>Use SetCanAffectNavigationGeneration to change this value at runtime.</summary>
        ///<remarks>Note that calling this function at runtime will result in any navigation change only if runtime navigation generation is enabled.</remarks>
        public void SetCanAffectNavigationGeneration(bool bNewValue, bool bForceUpdate)  => 
            Pawn_methods.SetCanAffectNavigationGeneration_method.Invoke(ObjPointer, bNewValue, bForceUpdate);

        ///<summary>Spawn default controller for this Pawn, and get possessed by it.</summary>
        public void SpawnDefaultController()  => 
            Pawn_methods.SpawnDefaultController_method.Invoke(ObjPointer);
        public bool bUseControllerRotationPitch {
            get {return Main.GetGetBoolPropertyByName(this, "bUseControllerRotationPitch"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseControllerRotationPitch", value); }
        }
        public bool bUseControllerRotationYaw {
            get {return Main.GetGetBoolPropertyByName(this, "bUseControllerRotationYaw"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseControllerRotationYaw", value); }
        }
        public bool bUseControllerRotationRoll {
            get {return Main.GetGetBoolPropertyByName(this, "bUseControllerRotationRoll"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseControllerRotationRoll", value); }
        }
        public bool bCanAffectNavigationGeneration {
            get {return Main.GetGetBoolPropertyByName(this, "bCanAffectNavigationGeneration"); }
        }
        ///<summary>Base eye height above collision center.</summary>
        public unsafe float BaseEyeHeight {
            get {return Pawn_ptr->BaseEyeHeight;}
            set {Pawn_ptr->BaseEyeHeight = value;}
        }
        ///<summary>Determines which PlayerController, if any, should automatically possess the pawn when the level starts or when the pawn is spawned.</summary>
        ///<remarks>
        ///@see AutoPossessAI
        ///</remarks>
        public unsafe byte AutoPossessPlayer {
            get {return Pawn_ptr->AutoPossessPlayer;}
            set {Pawn_ptr->AutoPossessPlayer = value;}
        }
         //TODO: enum EAutoPossessAI AutoPossessAI
        ///<summary>Replicated so we can see where remote clients are looking.</summary>
        public unsafe byte RemoteViewPitch {
            get {return Pawn_ptr->RemoteViewPitch;}
            set {Pawn_ptr->RemoteViewPitch = value;}
        }
        ///<summary>Default class to use when pawn is controlled by AI.</summary>
        public unsafe SubclassOf<Controller> AIControllerClass {
            get {return Pawn_ptr->AIControllerClass;}
            set {Pawn_ptr->AIControllerClass = value;}
        }
        ///<summary>If Pawn is possessed by a player, points to its Player State.  Needed for network play as controllers are not replicated to clients.</summary>
        public unsafe PlayerState PlayerState {
            get {return Pawn_ptr->PlayerState;}
        }
        ///<summary>Controller of the last Actor that caused us damage.</summary>
        public unsafe Controller LastHitBy {
            get {return Pawn_ptr->LastHitBy;}
        }
        ///<summary>Controller currently possessing this Actor</summary>
        public unsafe Controller Controller {
            get {return Pawn_ptr->Controller;}
            set {Pawn_ptr->Controller = value;}
        }
        ///<summary>Accumulated control input vector, stored in world space.</summary>
        ///<remarks>
        ///This is the pending input, which is cleared (zeroed) once consumed.
        ///@see GetPendingMovementInputVector(), AddMovementInput()
        ///</remarks>
        public unsafe Vector ControlInputVector {
            get {return Pawn_ptr->ControlInputVector;}
            set {Pawn_ptr->ControlInputVector = value;}
        }
        ///<summary>The last control input vector that was processed by ConsumeMovementInputVector().</summary>
        ///<remarks>
        ///@see GetLastMovementInputVector()
        ///</remarks>
        public unsafe Vector LastControlInputVector {
            get {return Pawn_ptr->LastControlInputVector;}
            set {Pawn_ptr->LastControlInputVector = value;}
        }
        static Pawn() {
            StaticClass = Main.GetClass("Pawn");
            Pawn_events.ReceivePossessed_event.Setup();
            Pawn_events.ReceiveUnpossessed_event.Setup();
        }
        internal unsafe Pawn_fields* Pawn_ptr => (Pawn_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator Pawn(IntPtr p) => UObject.Make<Pawn>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static Pawn DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static Pawn New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
