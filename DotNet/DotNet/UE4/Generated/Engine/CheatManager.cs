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
    ///<summary>Cheat Manager is a central blueprint to implement test and debug code and actions that are not to ship with the game.</summary>
    ///<remarks>As the Cheat Manager is not instanced in shipping builds, it is for debugging purposes only</remarks>
    public unsafe partial class CheatManager : UObject  {

        ///<summary>This is the End Play event for the CheatManager</summary>
        public event ReceiveEndPlay_delegate ReceiveEndPlay;
        public delegate void ReceiveEndPlay_delegate();
        internal void on_ReceiveEndPlay() =>
            ReceiveEndPlay?.Invoke();


        ///<summary>BP implementable event for when CheatManager is created to allow any needed initialization.</summary>
        public event ReceiveInitCheatManager_delegate ReceiveInitCheatManager;
        public delegate void ReceiveInitCheatManager_delegate();
        internal void on_ReceiveInitCheatManager() =>
            ReceiveInitCheatManager?.Invoke();


        ///<summary>Scale the player's size to be F * default size.</summary>
        public void ChangeSize(float F)  => 
            CheatManager_methods.ChangeSize_method.Invoke(ObjPointer, F);

        ///<summary>Damage the actor you're looking at (sourced from the player).</summary>
        public void DamageTarget(float DamageAmount)  => 
            CheatManager_methods.DamageTarget_method.Invoke(ObjPointer, DamageAmount);

        ///<summary>Destroy the actor you're looking at.</summary>
        public void DestroyTarget()  => 
            CheatManager_methods.DestroyTarget_method.Invoke(ObjPointer);

        ///<summary>Switch controller from debug camera back to normal controller</summary>
        public void DisableDebugCamera()  => 
            CheatManager_methods.DisableDebugCamera_method.Invoke(ObjPointer);

        ///<summary>Switch controller to debug camera without locking gameplay and with locking local player controller input</summary>
        public void EnableDebugCamera()  => 
            CheatManager_methods.EnableDebugCamera_method.Invoke(ObjPointer);

        ///<summary>Pawn can fly.</summary>
        public void Fly()  => 
            CheatManager_methods.Fly_method.Invoke(ObjPointer);

        ///<summary>Pause the game for Delay seconds.</summary>
        public void FreezeFrame(float Delay)  => 
            CheatManager_methods.FreezeFrame_method.Invoke(ObjPointer, Delay);

        ///<summary>Pawn no longer collides with the world, and can fly</summary>
        public void Ghost()  => 
            CheatManager_methods.Ghost_method.Invoke(ObjPointer);

        ///<summary>Invulnerability cheat.</summary>
        public void God()  => 
            CheatManager_methods.God_method.Invoke(ObjPointer);

        ///<summary>Freeze everything in the level except for players.</summary>
        public void PlayersOnly()  => 
            CheatManager_methods.PlayersOnly_method.Invoke(ObjPointer);

        ///<summary>Modify time dilation to change apparent speed of passage of time. e.g. "Slomo 0.1" makes everything move very slowly, while "Slomo 10" makes everything move very fast.</summary>
        public void Slomo(float NewTimeDilation)  => 
            CheatManager_methods.Slomo_method.Invoke(ObjPointer, NewTimeDilation);

        ///<summary>Teleport to surface player is looking at.</summary>
        public void Teleport()  => 
            CheatManager_methods.Teleport_method.Invoke(ObjPointer);

        ///<summary>Return to walking movement mode from Fly or Ghost cheat.</summary>
        public void Walk()  => 
            CheatManager_methods.Walk_method.Invoke(ObjPointer);
        ///<summary>Debug camera - used to have independent camera without stopping gameplay</summary>
        public unsafe DebugCameraController DebugCameraControllerRef {
            get {return CheatManager_ptr->DebugCameraControllerRef;}
            set {CheatManager_ptr->DebugCameraControllerRef = value;}
        }
        ///<summary>Debug camera - used to have independent camera without stopping gameplay</summary>
        public unsafe SubclassOf<DebugCameraController> DebugCameraControllerClass {
            get {return CheatManager_ptr->DebugCameraControllerClass;}
        }
        static CheatManager() {
            StaticClass = Main.GetClass("CheatManager");
            CheatManager_events.ReceiveEndPlay_event.Setup();
            CheatManager_events.ReceiveInitCheatManager_event.Setup();
        }
        internal unsafe CheatManager_fields* CheatManager_ptr => (CheatManager_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator CheatManager(IntPtr p) => UObject.Make<CheatManager>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static CheatManager DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static CheatManager New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
