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
    ///<summary>Base class for blueprint based decorator nodes.</summary>
    ///<remarks>
    ///Do NOT use it for creating native c++ classes!
    ///
    ///Unlike task and services, decorator have two execution chains:
    /// ExecutionStart-ExecutionFinish and ObserverActivated-ObserverDeactivated
    ///which makes automatic latent action cleanup impossible. Keep in mind, that
    ///you HAVE TO verify is given chain is still active after resuming from any
    ///latent action (like Delay, Timelines, etc).
    ///
    ///Helper functions:
    ///- IsDecoratorExecutionActive (true after ExecutionStart, until ExecutionFinish)
    ///- IsDecoratorObserverActive (true after ObserverActivated, until ObserverDeactivated)
    ///</remarks>
    public unsafe partial class BTDecorator_BlueprintBase : BTDecorator  {

        ///<summary>
        ///called when testing if underlying node can be executed, must call FinishConditionCheck
        ///    @
        ///</summary>
        ///<remarks>
        ///Note that if both generic and AI event versions are implemented only the more
        ///    suitable one will be called, meaning the AI version if called for AI, generic one otherwise
        ///</remarks>
        public event PerformConditionCheck_delegate PerformConditionCheck;
        public delegate bool PerformConditionCheck_delegate(Actor OwnerActor, bool ReturnValue);
        internal bool on_PerformConditionCheck(Actor OwnerActor, bool ReturnValue) =>
            PerformConditionCheck != null ? PerformConditionCheck(OwnerActor, ReturnValue) : ReturnValue;


        ///<summary>
        ///Alternative AI version of ReceiveConditionCheck
        ///    @
        ///</summary>
        ///<remarks>
        ///see ReceiveConditionCheck for more details
        ///    @Note that if both generic and AI event versions are implemented only the more
        ///    suitable one will be called, meaning the AI version if called for AI, generic one otherwise
        ///</remarks>
        public event PerformConditionCheckAI_delegate PerformConditionCheckAI;
        public delegate bool PerformConditionCheckAI_delegate(AIController OwnerController, Pawn ControlledPawn, bool ReturnValue);
        internal bool on_PerformConditionCheckAI(AIController OwnerController, Pawn ControlledPawn, bool ReturnValue) =>
            PerformConditionCheckAI != null ? PerformConditionCheckAI(OwnerController, ControlledPawn, ReturnValue) : ReturnValue;


        ///<summary>
        ///called when execution of underlying node is finished
        ///    @
        ///</summary>
        ///<remarks>
        ///Note that if both generic and AI event versions are implemented only the more
        ///    suitable one will be called, meaning the AI version if called for AI, generic one otherwise
        ///</remarks>
        public event ReceiveExecutionFinish_delegate ReceiveExecutionFinish;
        public delegate void ReceiveExecutionFinish_delegate(Actor OwnerActor, byte NodeResult);
        internal void on_ReceiveExecutionFinish(Actor OwnerActor, byte NodeResult) =>
            ReceiveExecutionFinish?.Invoke(OwnerActor, NodeResult);


        ///<summary>
        ///Alternative AI version of ReceiveExecutionFinish
        ///    @
        ///</summary>
        ///<remarks>
        ///see ReceiveExecutionFinish for more details
        ///    @Note that if both generic and AI event versions are implemented only the more
        ///    suitable one will be called, meaning the AI version if called for AI, generic one otherwise
        ///</remarks>
        public event ReceiveExecutionFinishAI_delegate ReceiveExecutionFinishAI;
        public delegate void ReceiveExecutionFinishAI_delegate(AIController OwnerController, Pawn ControlledPawn, byte NodeResult);
        internal void on_ReceiveExecutionFinishAI(AIController OwnerController, Pawn ControlledPawn, byte NodeResult) =>
            ReceiveExecutionFinishAI?.Invoke(OwnerController, ControlledPawn, NodeResult);


        ///<summary>
        ///called on execution of underlying node
        ///    @
        ///</summary>
        ///<remarks>
        ///Note that if both generic and AI event versions are implemented only the more
        ///    suitable one will be called, meaning the AI version if called for AI, generic one otherwise
        ///</remarks>
        public event ReceiveExecutionStart_delegate ReceiveExecutionStart;
        public delegate void ReceiveExecutionStart_delegate(Actor OwnerActor);
        internal void on_ReceiveExecutionStart(Actor OwnerActor) =>
            ReceiveExecutionStart?.Invoke(OwnerActor);


        ///<summary>
        ///Alternative AI version of ReceiveExecutionStart
        ///    @
        ///</summary>
        ///<remarks>
        ///see ReceiveExecutionStart for more details
        ///    @Note that if both generic and AI event versions are implemented only the more
        ///    suitable one will be called, meaning the AI version if called for AI, generic one otherwise
        ///</remarks>
        public event ReceiveExecutionStartAI_delegate ReceiveExecutionStartAI;
        public delegate void ReceiveExecutionStartAI_delegate(AIController OwnerController, Pawn ControlledPawn);
        internal void on_ReceiveExecutionStartAI(AIController OwnerController, Pawn ControlledPawn) =>
            ReceiveExecutionStartAI?.Invoke(OwnerController, ControlledPawn);


        ///<summary>
        ///called when observer is activated (flow controller)
        ///    @
        ///</summary>
        ///<remarks>
        ///Note that if both generic and AI event versions are implemented only the more
        ///    suitable one will be called, meaning the AI version if called for AI, generic one otherwise
        ///</remarks>
        public event ReceiveObserverActivated_delegate ReceiveObserverActivated;
        public delegate void ReceiveObserverActivated_delegate(Actor OwnerActor);
        internal void on_ReceiveObserverActivated(Actor OwnerActor) =>
            ReceiveObserverActivated?.Invoke(OwnerActor);


        ///<summary>
        ///Alternative AI version of ReceiveObserverActivated
        ///    @
        ///</summary>
        ///<remarks>
        ///see ReceiveObserverActivated for more details
        ///    @Note that if both generic and AI event versions are implemented only the more
        ///    suitable one will be called, meaning the AI version if called for AI, generic one otherwise
        ///</remarks>
        public event ReceiveObserverActivatedAI_delegate ReceiveObserverActivatedAI;
        public delegate void ReceiveObserverActivatedAI_delegate(AIController OwnerController, Pawn ControlledPawn);
        internal void on_ReceiveObserverActivatedAI(AIController OwnerController, Pawn ControlledPawn) =>
            ReceiveObserverActivatedAI?.Invoke(OwnerController, ControlledPawn);


        ///<summary>
        ///called when observer is deactivated (flow controller)
        ///    @
        ///</summary>
        ///<remarks>
        ///Note that if both generic and AI event versions are implemented only the more
        ///    suitable one will be called, meaning the AI version if called for AI, generic one otherwise
        ///</remarks>
        public event ReceiveObserverDeactivated_delegate ReceiveObserverDeactivated;
        public delegate void ReceiveObserverDeactivated_delegate(Actor OwnerActor);
        internal void on_ReceiveObserverDeactivated(Actor OwnerActor) =>
            ReceiveObserverDeactivated?.Invoke(OwnerActor);


        ///<summary>
        ///Alternative AI version of ReceiveObserverDeactivated
        ///    @
        ///</summary>
        ///<remarks>
        ///see ReceiveObserverDeactivated for more details
        ///    @Note that if both generic and AI event versions are implemented only the more
        ///    suitable one will be called, meaning the AI version if called for AI, generic one otherwise
        ///</remarks>
        public event ReceiveObserverDeactivatedAI_delegate ReceiveObserverDeactivatedAI;
        public delegate void ReceiveObserverDeactivatedAI_delegate(AIController OwnerController, Pawn ControlledPawn);
        internal void on_ReceiveObserverDeactivatedAI(AIController OwnerController, Pawn ControlledPawn) =>
            ReceiveObserverDeactivatedAI?.Invoke(OwnerController, ControlledPawn);


        ///<summary>
        ///tick function
        ///    @
        ///</summary>
        ///<remarks>
        ///Note that if both generic and AI event versions are implemented only the more
        ///    suitable one will be called, meaning the AI version if called for AI, generic one otherwise
        ///</remarks>
        public event ReceiveTick_delegate ReceiveTick;
        public delegate void ReceiveTick_delegate(Actor OwnerActor, float DeltaSeconds);
        internal void on_ReceiveTick(Actor OwnerActor, float DeltaSeconds) =>
            ReceiveTick?.Invoke(OwnerActor, DeltaSeconds);


        ///<summary>
        ///Alternative AI version of ReceiveTick
        ///    @
        ///</summary>
        ///<remarks>
        ///see ReceiveTick for more details
        ///    @Note that if both generic and AI event versions are implemented only the more
        ///    suitable one will be called, meaning the AI version if called for AI, generic one otherwise
        ///</remarks>
        public event ReceiveTickAI_delegate ReceiveTickAI;
        public delegate void ReceiveTickAI_delegate(AIController OwnerController, Pawn ControlledPawn, float DeltaSeconds);
        internal void on_ReceiveTickAI(AIController OwnerController, Pawn ControlledPawn, float DeltaSeconds) =>
            ReceiveTickAI?.Invoke(OwnerController, ControlledPawn, DeltaSeconds);


        ///<summary>check if decorator is part of currently active branch</summary>
        public bool IsDecoratorExecutionActive()  => 
            BTDecorator_BlueprintBase_methods.IsDecoratorExecutionActive_method.Invoke(ObjPointer);

        ///<summary>check if decorator's observer is currently active</summary>
        public bool IsDecoratorObserverActive()  => 
            BTDecorator_BlueprintBase_methods.IsDecoratorObserverActive_method.Invoke(ObjPointer);
        ///<summary>Cached AIController owner of BehaviorTreeComponent.</summary>
        public unsafe AIController AIOwner {
            get {return BTDecorator_BlueprintBase_ptr->AIOwner;}
            set {BTDecorator_BlueprintBase_ptr->AIOwner = value;}
        }
        ///<summary>Cached AIController owner of BehaviorTreeComponent.</summary>
        public unsafe Actor ActorOwner {
            get {return BTDecorator_BlueprintBase_ptr->ActorOwner;}
            set {BTDecorator_BlueprintBase_ptr->ActorOwner = value;}
        }
         //TODO: array not UObject TArray ObservedKeyNames
        public bool bShowPropertyDetails {
            get {return Main.GetGetBoolPropertyByName(this, "bShowPropertyDetails"); }
            set {Main.SetGetBoolPropertyByName(this, "bShowPropertyDetails", value); }
        }
        public bool bCheckConditionOnlyBlackBoardChanges {
            get {return Main.GetGetBoolPropertyByName(this, "bCheckConditionOnlyBlackBoardChanges"); }
            set {Main.SetGetBoolPropertyByName(this, "bCheckConditionOnlyBlackBoardChanges", value); }
        }
        public bool bIsObservingBB {
            get {return Main.GetGetBoolPropertyByName(this, "bIsObservingBB"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsObservingBB", value); }
        }
        static BTDecorator_BlueprintBase() {
            StaticClass = Main.GetClass("BTDecorator_BlueprintBase");
            BTDecorator_BlueprintBase_events.PerformConditionCheck_event.Setup();
            BTDecorator_BlueprintBase_events.PerformConditionCheckAI_event.Setup();
            BTDecorator_BlueprintBase_events.ReceiveExecutionFinish_event.Setup();
            BTDecorator_BlueprintBase_events.ReceiveExecutionFinishAI_event.Setup();
            BTDecorator_BlueprintBase_events.ReceiveExecutionStart_event.Setup();
            BTDecorator_BlueprintBase_events.ReceiveExecutionStartAI_event.Setup();
            BTDecorator_BlueprintBase_events.ReceiveObserverActivated_event.Setup();
            BTDecorator_BlueprintBase_events.ReceiveObserverActivatedAI_event.Setup();
            BTDecorator_BlueprintBase_events.ReceiveObserverDeactivated_event.Setup();
            BTDecorator_BlueprintBase_events.ReceiveObserverDeactivatedAI_event.Setup();
            BTDecorator_BlueprintBase_events.ReceiveTick_event.Setup();
            BTDecorator_BlueprintBase_events.ReceiveTickAI_event.Setup();
        }
        internal unsafe BTDecorator_BlueprintBase_fields* BTDecorator_BlueprintBase_ptr => (BTDecorator_BlueprintBase_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BTDecorator_BlueprintBase(IntPtr p) => UObject.Make<BTDecorator_BlueprintBase>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BTDecorator_BlueprintBase DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BTDecorator_BlueprintBase New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
