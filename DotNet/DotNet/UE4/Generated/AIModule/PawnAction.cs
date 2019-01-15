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

namespace UE4.AIModule {
    ///<summary>Things to remember:</summary>
    ///<remarks>* Actions are created paused</remarks>
    public unsafe partial class PawnAction : UObject  {

        ///<summary>Create Action Instance</summary>
        public static PawnAction CreateActionInstance(UObject WorldContextObject, SubclassOf<PawnAction> ActionClass)  => 
            PawnAction_methods.CreateActionInstance_method.Invoke(WorldContextObject, ActionClass);

        ///<summary>Finish</summary>
        public void Finish(byte WithResult)  => 
            PawnAction_methods.Finish_method.Invoke(ObjPointer, WithResult);

        ///<summary>Blueprint interface</summary>
        public byte GetActionPriority()  => 
            PawnAction_methods.GetActionPriority_method.Invoke(ObjPointer);
        ///<summary>Current child node executing on top of this Action</summary>
        public unsafe PawnAction ChildAction {
            get {return PawnAction_ptr->ChildAction;}
            set {PawnAction_ptr->ChildAction = value;}
        }
        ///<summary>Parent Action</summary>
        public unsafe PawnAction ParentAction {
            get {return PawnAction_ptr->ParentAction;}
            set {PawnAction_ptr->ParentAction = value;}
        }
        ///<summary>Extra reference to the component this action is being governed by</summary>
        public unsafe PawnActionsComponent OwnerComponent {
            get {return PawnAction_ptr->OwnerComponent;}
            set {PawnAction_ptr->OwnerComponent = value;}
        }
        ///<summary>indicates an object that caused this action.</summary>
        ///<remarks>
        ///Used for mass removal of actions
        ///    by specific object
        ///</remarks>
        public unsafe UObject Instigator {
            get {return PawnAction_ptr->Instigator;}
            set {PawnAction_ptr->Instigator = value;}
        }
        ///<summary>@Note: THIS IS HERE _ONLY_ BECAUSE OF THE WAY AI MESSAGING IS CURRENTLY IMPLEMENTED. WILL GO AWAY!</summary>
        public unsafe BrainComponent BrainComp {
            get {return PawnAction_ptr->BrainComp;}
            set {PawnAction_ptr->BrainComp = value;}
        }
        public bool bAllowNewSameClassInstance {
            get {return Main.GetGetBoolPropertyByName(this, "bAllowNewSameClassInstance"); }
        }
        public bool bReplaceActiveSameClassInstance {
            get {return Main.GetGetBoolPropertyByName(this, "bReplaceActiveSameClassInstance"); }
            set {Main.SetGetBoolPropertyByName(this, "bReplaceActiveSameClassInstance", value); }
        }
        public bool bShouldPauseMovement {
            get {return Main.GetGetBoolPropertyByName(this, "bShouldPauseMovement"); }
            set {Main.SetGetBoolPropertyByName(this, "bShouldPauseMovement", value); }
        }
        public bool bAlwaysNotifyOnFinished {
            get {return Main.GetGetBoolPropertyByName(this, "bAlwaysNotifyOnFinished"); }
            set {Main.SetGetBoolPropertyByName(this, "bAlwaysNotifyOnFinished", value); }
        }
        static PawnAction() {
            StaticClass = Main.GetClass("PawnAction");
        }
        internal unsafe PawnAction_fields* PawnAction_ptr => (PawnAction_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PawnAction(IntPtr p) => UObject.Make<PawnAction>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PawnAction DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PawnAction New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
