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
    ///<summary>Camera controller that allows you to fly around a level mostly unrestricted by normal movement rules.</summary>
    ///<remarks>
    ///To turn it on, please press Alt+C or both (left and right) analogs on XBox pad,
    ///or use the "ToggleDebugCamera" console command. Check the debug camera bindings
    ///in DefaultPawn.cpp for the camera controls.
    ///</remarks>
    public unsafe partial class DebugCameraController : PlayerController  {

        ///<summary>Function called on activation of debug camera controller.</summary>
        ///<remarks>
        ///@param OriginalPC The active player controller before this debug camera controller was possessed by the player.
        ///</remarks>
        public event ReceiveOnActivate_delegate ReceiveOnActivate;
        public delegate void ReceiveOnActivate_delegate(PlayerController OriginalPC);
        internal void on_ReceiveOnActivate(PlayerController OriginalPC) =>
            ReceiveOnActivate?.Invoke(OriginalPC);


        ///<summary>Called when an actor has been selected with the primary key (e.</summary>
        ///<remarks>
        ///g. left mouse button).
        ///
        ///The selection trace starts from the center of the debug camera's view.
        ///
        ///@param SelectHitLocation The exact world-space location where the selection trace hit the New Selected Actor.
        ///@param SelectHitNormal The world-space surface normal of the New Selected Actor at the hit location.
        ///</remarks>
        public event ReceiveOnActorSelected_delegate ReceiveOnActorSelected;
        public delegate (Vector, Vector, HitResult) ReceiveOnActorSelected_delegate(Actor NewSelectedActor, Vector SelectHitLocation, Vector SelectHitNormal, HitResult Hit);
        internal (Vector, Vector, HitResult) on_ReceiveOnActorSelected(Actor NewSelectedActor, Vector SelectHitLocation, Vector SelectHitNormal, HitResult Hit) =>
            ReceiveOnActorSelected != null ? ReceiveOnActorSelected(NewSelectedActor, SelectHitLocation, SelectHitNormal, Hit) : (SelectHitLocation, SelectHitNormal, Hit);


        ///<summary>Function called on deactivation of debug camera controller.</summary>
        ///<remarks>
        ///@param RestoredPC The Player Controller that the player input is being returned to.
        ///</remarks>
        public event ReceiveOnDeactivate_delegate ReceiveOnDeactivate;
        public delegate void ReceiveOnDeactivate_delegate(PlayerController RestoredPC);
        internal void on_ReceiveOnDeactivate(PlayerController RestoredPC) =>
            ReceiveOnDeactivate?.Invoke(RestoredPC);


        ///<summary>Get Selected Actor</summary>
        public Actor GetSelectedActor()  => 
            DebugCameraController_methods.GetSelectedActor_method.Invoke(ObjPointer);

        ///<summary>Sets the pawn movement speed scale.</summary>
        public void SetPawnMovementSpeedScale(float NewSpeedScale)  => 
            DebugCameraController_methods.SetPawnMovementSpeedScale_method.Invoke(ObjPointer, NewSpeedScale);

        ///<summary>Toggles the display of debug info and input commands for the Debug Camera.</summary>
        public void ToggleDisplay()  => 
            DebugCameraController_methods.ToggleDisplay_method.Invoke(ObjPointer);
        public bool bShowSelectedInfo {
            get {return Main.GetGetBoolPropertyByName(this, "bShowSelectedInfo"); }
            set {Main.SetGetBoolPropertyByName(this, "bShowSelectedInfo", value); }
        }
        public bool bIsFrozenRendering {
            get {return Main.GetGetBoolPropertyByName(this, "bIsFrozenRendering"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsFrozenRendering", value); }
        }
        ///<summary>@todo document</summary>
        public unsafe DrawFrustumComponent DrawFrustum {
            get {return DebugCameraController_ptr->DrawFrustum;}
            set {DebugCameraController_ptr->DrawFrustum = value;}
        }
        ///<summary>Allows control over the speed of the spectator pawn. This scales the speed based on the InitialMaxSpeed. Use Set Pawn Movement Speed Scale during runtime</summary>
        public unsafe float SpeedScale {
            get {return DebugCameraController_ptr->SpeedScale;}
        }
        ///<summary>Initial max speed of the spectator pawn when we start possession.</summary>
        public unsafe float InitialMaxSpeed {
            get {return DebugCameraController_ptr->InitialMaxSpeed;}
        }
        ///<summary>Initial acceleration of the spectator pawn when we start possession.</summary>
        public unsafe float InitialAccel {
            get {return DebugCameraController_ptr->InitialAccel;}
        }
        ///<summary>Initial deceleration of the spectator pawn when we start possession.</summary>
        public unsafe float InitialDecel {
            get {return DebugCameraController_ptr->InitialDecel;}
        }
        static DebugCameraController() {
            StaticClass = Main.GetClass("DebugCameraController");
            DebugCameraController_events.ReceiveOnActivate_event.Setup();
            DebugCameraController_events.ReceiveOnActorSelected_event.Setup();
            DebugCameraController_events.ReceiveOnDeactivate_event.Setup();
        }
        internal unsafe DebugCameraController_fields* DebugCameraController_ptr => (DebugCameraController_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator DebugCameraController(IntPtr p) => UObject.Make<DebugCameraController>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static DebugCameraController DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static DebugCameraController New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
