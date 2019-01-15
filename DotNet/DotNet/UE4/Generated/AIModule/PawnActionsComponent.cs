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
    ///<summary>Pawn Actions Component</summary>
    public unsafe partial class PawnActionsComponent : ActorComponent  {

        ///<summary>Aborts given action instance</summary>
        public byte K2_AbortAction(PawnAction ActionToAbort)  => 
            PawnActionsComponent_methods.K2_AbortAction_method.Invoke(ObjPointer, ActionToAbort);

        ///<summary>Aborts given action instance</summary>
        public byte K2_ForceAbortAction(PawnAction ActionToAbort)  => 
            PawnActionsComponent_methods.K2_ForceAbortAction_method.Invoke(ObjPointer, ActionToAbort);

        ///<summary>blueprint interface</summary>
        public static bool K2_PerformAction(Pawn Pawn, PawnAction Action, byte Priority)  => 
            PawnActionsComponent_methods.K2_PerformAction_method.Invoke(Pawn, Action, Priority);

        ///<summary>K2 Push Action</summary>
        public bool K2_PushAction(PawnAction NewAction, byte Priority, UObject Instigator)  => 
            PawnActionsComponent_methods.K2_PushAction_method.Invoke(ObjPointer, NewAction, Priority, Instigator);
        ///<summary>Controlled Pawn</summary>
        public unsafe Pawn ControlledPawn {
            get {return PawnActionsComponent_ptr->ControlledPawn;}
        }
         //TODO: array not UObject TArray ActionStacks
         //TODO: array not UObject TArray ActionEvents
        ///<summary>Current Action</summary>
        public unsafe PawnAction CurrentAction {
            get {return PawnActionsComponent_ptr->CurrentAction;}
            set {PawnActionsComponent_ptr->CurrentAction = value;}
        }
        static PawnActionsComponent() {
            StaticClass = Main.GetClass("PawnActionsComponent");
        }
        internal unsafe PawnActionsComponent_fields* PawnActionsComponent_ptr => (PawnActionsComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PawnActionsComponent(IntPtr p) => UObject.Make<PawnActionsComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PawnActionsComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PawnActionsComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
