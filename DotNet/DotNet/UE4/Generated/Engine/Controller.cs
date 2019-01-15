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
    ///<summary>
    ///Controllers are non-physical actors that can possess a Pawn to control
    ///its actions.
    ///</summary>
    ///<remarks>
    ///PlayerControllers are used by human players to control pawns, while
    ///AIControllers implement the artificial intelligence for the pawns they control.
    ///Controllers take control of a pawn using their Possess() method, and relinquish
    ///control of the pawn by calling UnPossess().
    ///
    ///Controllers receive notifications for many of the events occurring for the Pawn they
    ///are controlling.  This gives the controller the opportunity to implement the behavior
    ///in response to this event, intercepting the event and superseding the Pawn's default
    ///behavior.
    ///
    ///ControlRotation (accessed via GetControlRotation()), determines the viewing/aiming
    ///direction of the controlled Pawn and is affected by input such as from a mouse or gamepad.
    ///
    ///@see https://docs.unrealengine.com/latest/INT/Gameplay/Framework/Controller/
    ///</remarks>
    public unsafe partial class Controller : Actor  {

        ///<summary>Event when this controller instigates ANY damage</summary>
        public event ReceiveInstigatedAnyDamage_delegate ReceiveInstigatedAnyDamage;
        public delegate void ReceiveInstigatedAnyDamage_delegate(float Damage, DamageType DamageType, Actor DamagedActor, Actor DamageCauser);
        internal void on_ReceiveInstigatedAnyDamage(float Damage, DamageType DamageType, Actor DamagedActor, Actor DamageCauser) =>
            ReceiveInstigatedAnyDamage?.Invoke(Damage, DamageType, DamagedActor, DamageCauser);


        ///<summary>Cast to Player Controller</summary>
        public PlayerController CastToPlayerController()  => 
            Controller_methods.CastToPlayerController_method.Invoke(ObjPointer);

        ///<summary>Get the control rotation.</summary>
        ///<remarks>
        ///This is the full aim rotation, which may be different than a camera orientation (for example in a third person view),
        ///and may differ from the rotation of the controlled Pawn (which may choose not to visually pitch or roll, for example).
        ///</remarks>
        public Rotator GetControlRotation()  => 
            Controller_methods.GetControlRotation_method.Invoke(ObjPointer);

        ///<summary>Get the desired pawn target rotation</summary>
        public Rotator GetDesiredRotation()  => 
            Controller_methods.GetDesiredRotation_method.Invoke(ObjPointer);

        ///<summary>Get the actor the controller is looking at</summary>
        public Actor GetViewTarget()  => 
            Controller_methods.GetViewTarget_method.Invoke(ObjPointer);

        ///<summary>Returns whether this Controller is a local controller.</summary>
        public bool IsLocalController()  => 
            Controller_methods.IsLocalController_method.Invoke(ObjPointer);

        ///<summary>Returns whether this Controller is a locally controlled PlayerController.</summary>
        public bool IsLocalPlayerController()  => 
            Controller_methods.IsLocalPlayerController_method.Invoke(ObjPointer);

        ///<summary>Returns true if look input is ignored.</summary>
        public bool IsLookInputIgnored()  => 
            Controller_methods.IsLookInputIgnored_method.Invoke(ObjPointer);

        ///<summary>Returns true if movement input is ignored.</summary>
        public bool IsMoveInputIgnored()  => 
            Controller_methods.IsMoveInputIgnored_method.Invoke(ObjPointer);

        ///<summary>Returns whether this Controller is a PlayerController.</summary>
        public bool IsPlayerController()  => 
            Controller_methods.IsPlayerController_method.Invoke(ObjPointer);

        ///<summary>Return the Pawn that is currently 'controlled' by this PlayerController</summary>
        public Pawn K2_GetPawn()  => 
            Controller_methods.K2_GetPawn_method.Invoke(ObjPointer);

        ///<summary>
        ///Checks line to center and top of other actor
        ///@
        ///</summary>
        ///<remarks>
        ///param Other is the actor whose visibility is being checked.
        ///@param ViewPoint is eye position visibility is being checked from.  If vect(0,0,0) passed in, uses current viewtarget's eye position.
        ///@param bAlternateChecks used only in AIController implementation
        ///@return true if controller's pawn can see Other actor.
        ///</remarks>
        public bool LineOfSightTo(Actor Other, Vector ViewPoint, bool bAlternateChecks)  => 
            Controller_methods.LineOfSightTo_method.Invoke(ObjPointer, Other, ViewPoint, bAlternateChecks);

        ///<summary>Handles attaching this controller to the specified pawn.</summary>
        ///<remarks>
        ///Only runs on the network authority (where HasAuthority() returns true).
        ///@param InPawn The Pawn to be possessed.
        ///@see HasAuthority()
        ///</remarks>
        public void Possess(Pawn InPawn)  => 
            Controller_methods.Possess_method.Invoke(ObjPointer, InPawn);

        ///<summary>Reset move and look input ignore flags.</summary>
        public void ResetIgnoreInputFlags()  => 
            Controller_methods.ResetIgnoreInputFlags_method.Invoke(ObjPointer);

        ///<summary>Stops ignoring look input by resetting the ignore look input state.</summary>
        public void ResetIgnoreLookInput()  => 
            Controller_methods.ResetIgnoreLookInput_method.Invoke(ObjPointer);

        ///<summary>Stops ignoring move input by resetting the ignore move input state.</summary>
        public void ResetIgnoreMoveInput()  => 
            Controller_methods.ResetIgnoreMoveInput_method.Invoke(ObjPointer);

        ///<summary>Set the control rotation.</summary>
        public void SetControlRotation(Rotator NewRotation)  => 
            Controller_methods.SetControlRotation_method.Invoke(ObjPointer, NewRotation);

        ///<summary>Locks or unlocks look input, consecutive calls stack up and require the same amount of calls to undo, or can all be undone using ResetIgnoreLookInput.</summary>
        ///<remarks>
        ///@param bNewLookInput  If true, look input is ignored. If false, input is not ignored.
        ///</remarks>
        public void SetIgnoreLookInput(bool bNewLookInput)  => 
            Controller_methods.SetIgnoreLookInput_method.Invoke(ObjPointer, bNewLookInput);

        ///<summary>Locks or unlocks movement input, consecutive calls stack up and require the same amount of calls to undo, or can all be undone using ResetIgnoreMoveInput.</summary>
        ///<remarks>
        ///@param bNewMoveInput If true, move input is ignored. If false, input is not ignored.
        ///</remarks>
        public void SetIgnoreMoveInput(bool bNewMoveInput)  => 
            Controller_methods.SetIgnoreMoveInput_method.Invoke(ObjPointer, bNewMoveInput);

        ///<summary>Set the initial location and rotation of the controller, as well as the control rotation. Typically used when the controller is first created.</summary>
        public void SetInitialLocationAndRotation(Vector NewLocation, Rotator NewRotation)  => 
            Controller_methods.SetInitialLocationAndRotation_method.Invoke(ObjPointer, NewLocation, NewRotation);

        ///<summary>Aborts the move the controller is currently performing</summary>
        public void StopMovement()  => 
            Controller_methods.StopMovement_method.Invoke(ObjPointer);

        ///<summary>Called to unpossess our pawn for any reason that is not the pawn being destroyed (destruction handled by PawnDestroyed()).</summary>
        public void UnPossess()  => 
            Controller_methods.UnPossess_method.Invoke(ObjPointer);
        ///<summary>PlayerState containing replicated information about the player using this controller (only exists for players, not NPCs).</summary>
        public unsafe PlayerState PlayerState {
            get {return Controller_ptr->PlayerState;}
        }
         //TODO: multicast delegate FInstigatedAnyDamageSignature OnInstigatedAnyDamage
        ///<summary>Current gameplay state this controller is in</summary>
        public unsafe Name StateName {
            get {return Controller_ptr->StateName;}
            set {Controller_ptr->StateName = value;}
        }
        ///<summary>Pawn currently being controlled by this controller.  Use Pawn.Possess() to take control of a pawn</summary>
        public unsafe Pawn Pawn {
            get {return Controller_ptr->Pawn;}
            set {Controller_ptr->Pawn = value;}
        }
        ///<summary>Character currently being controlled by this controller.  Value is same as Pawn if the controlled pawn is a character, otherwise nullptr</summary>
        public unsafe Character Character {
            get {return Controller_ptr->Character;}
            set {Controller_ptr->Character = value;}
        }
        ///<summary>Component to give controllers a transform and enable attachment if desired.</summary>
        public unsafe SceneComponent TransformComponent {
            get {return Controller_ptr->TransformComponent;}
            set {Controller_ptr->TransformComponent = value;}
        }
        ///<summary>The control rotation of the Controller. See GetControlRotation.</summary>
        public unsafe Rotator ControlRotation {
            get {return Controller_ptr->ControlRotation;}
            set {Controller_ptr->ControlRotation = value;}
        }
        public bool bAttachToPawn {
            get {return Main.GetGetBoolPropertyByName(this, "bAttachToPawn"); }
            set {Main.SetGetBoolPropertyByName(this, "bAttachToPawn", value); }
        }
        public bool bIsPlayerController {
            get {return Main.GetGetBoolPropertyByName(this, "bIsPlayerController"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsPlayerController", value); }
        }
        static Controller() {
            StaticClass = Main.GetClass("Controller");
            Controller_events.ReceiveInstigatedAnyDamage_event.Setup();
        }
        internal unsafe Controller_fields* Controller_ptr => (Controller_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator Controller(IntPtr p) => UObject.Make<Controller>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static Controller DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static Controller New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
