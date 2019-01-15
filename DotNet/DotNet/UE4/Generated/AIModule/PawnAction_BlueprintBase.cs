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
using UE4.AIModule.Native;
using UE4.Engine;

namespace UE4.AIModule {
    ///<summary>Pawn Action Blueprint Base</summary>
    public unsafe partial class PawnAction_BlueprintBase : PawnAction  {

        ///<summary>Action Finished</summary>
        public event ActionFinished_delegate ActionFinished;
        public delegate void ActionFinished_delegate(Pawn ControlledPawn, byte WithResult);
        internal void on_ActionFinished(Pawn ControlledPawn, byte WithResult) =>
            ActionFinished?.Invoke(ControlledPawn, WithResult);


        ///<summary>Action Pause</summary>
        public event ActionPause_delegate ActionPause;
        public delegate void ActionPause_delegate(Pawn ControlledPawn);
        internal void on_ActionPause(Pawn ControlledPawn) =>
            ActionPause?.Invoke(ControlledPawn);


        ///<summary>Action Resume</summary>
        public event ActionResume_delegate ActionResume;
        public delegate void ActionResume_delegate(Pawn ControlledPawn);
        internal void on_ActionResume(Pawn ControlledPawn) =>
            ActionResume?.Invoke(ControlledPawn);


        ///<summary>Blueprint interface</summary>
        public event ActionStart_delegate ActionStart;
        public delegate void ActionStart_delegate(Pawn ControlledPawn);
        internal void on_ActionStart(Pawn ControlledPawn) =>
            ActionStart?.Invoke(ControlledPawn);


        ///<summary>Action Tick</summary>
        public event ActionTick_delegate ActionTick;
        public delegate void ActionTick_delegate(Pawn ControlledPawn, float DeltaSeconds);
        internal void on_ActionTick(Pawn ControlledPawn, float DeltaSeconds) =>
            ActionTick?.Invoke(ControlledPawn, DeltaSeconds);

        static PawnAction_BlueprintBase() {
            StaticClass = Main.GetClass("PawnAction_BlueprintBase");
            PawnAction_BlueprintBase_events.ActionFinished_event.Setup();
            PawnAction_BlueprintBase_events.ActionPause_event.Setup();
            PawnAction_BlueprintBase_events.ActionResume_event.Setup();
            PawnAction_BlueprintBase_events.ActionStart_event.Setup();
            PawnAction_BlueprintBase_events.ActionTick_event.Setup();
        }
        internal unsafe PawnAction_BlueprintBase_fields* PawnAction_BlueprintBase_ptr => (PawnAction_BlueprintBase_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PawnAction_BlueprintBase(IntPtr p) => UObject.Make<PawnAction_BlueprintBase>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PawnAction_BlueprintBase DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PawnAction_BlueprintBase New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
