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
    ///<summary>Base class for blueprint based task nodes.</summary>
    ///<remarks>
    ///Do NOT use it for creating native c++ classes!
    ///
    ///When task receives Abort event, all latent actions associated this instance are being removed.
    ///This prevents from resuming activity started by Execute, but does not handle external events.
    ///Please use them safely (unregister at abort) and call IsTaskExecuting() when in doubt.
    ///</remarks>
    public unsafe partial class BTTask_BlueprintBase : BTTaskNode  {

        ///<summary>
        ///if blueprint graph contains this event, task will stay active until FinishAbort is called
        ///    @
        ///</summary>
        ///<remarks>
        ///Note that if both generic and AI event versions are implemented only the more
        ///    suitable one will be called, meaning the AI version if called for AI, generic one otherwise
        ///</remarks>
        public event ReceiveAbort_delegate ReceiveAbort;
        public delegate void ReceiveAbort_delegate(Actor OwnerActor);
        internal void on_ReceiveAbort(Actor OwnerActor) =>
            ReceiveAbort?.Invoke(OwnerActor);


        ///<summary>
        ///Alternative AI version of ReceiveAbort
        ///    @
        ///</summary>
        ///<remarks>
        ///see ReceiveAbort for more details
        ///    @Note that if both generic and AI event versions are implemented only the more
        ///    suitable one will be called, meaning the AI version if called for AI, generic one otherwise
        ///</remarks>
        public event ReceiveAbortAI_delegate ReceiveAbortAI;
        public delegate void ReceiveAbortAI_delegate(AIController OwnerController, Pawn ControlledPawn);
        internal void on_ReceiveAbortAI(AIController OwnerController, Pawn ControlledPawn) =>
            ReceiveAbortAI?.Invoke(OwnerController, ControlledPawn);


        ///<summary>entry point, task will stay active until FinishExecute is called.</summary>
        ///<remarks>
        ///@Note that if both generic and AI event versions are implemented only the more
        ///    suitable one will be called, meaning the AI version if called for AI, generic one otherwise
        ///</remarks>
        public event ReceiveExecute_delegate ReceiveExecute;
        public delegate void ReceiveExecute_delegate(Actor OwnerActor);
        internal void on_ReceiveExecute(Actor OwnerActor) =>
            ReceiveExecute?.Invoke(OwnerActor);


        ///<summary>
        ///Alternative AI version of ReceiveExecute
        ///     @
        ///</summary>
        ///<remarks>
        ///see ReceiveExecute for more details
        ///    @Note that if both generic and AI event versions are implemented only the more
        ///    suitable one will be called, meaning the AI version if called for AI, generic one otherwise
        ///</remarks>
        public event ReceiveExecuteAI_delegate ReceiveExecuteAI;
        public delegate void ReceiveExecuteAI_delegate(AIController OwnerController, Pawn ControlledPawn);
        internal void on_ReceiveExecuteAI(AIController OwnerController, Pawn ControlledPawn) =>
            ReceiveExecuteAI?.Invoke(OwnerController, ControlledPawn);


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


        ///<summary>Alternative AI version of tick function.</summary>
        ///<remarks>
        ///@see ReceiveTick for more details
        ///    @Note that if both generic and AI event versions are implemented only the more
        ///    suitable one will be called, meaning the AI version if called for AI, generic one otherwise
        ///</remarks>
        public event ReceiveTickAI_delegate ReceiveTickAI;
        public delegate void ReceiveTickAI_delegate(AIController OwnerController, Pawn ControlledPawn, float DeltaSeconds);
        internal void on_ReceiveTickAI(AIController OwnerController, Pawn ControlledPawn, float DeltaSeconds) =>
            ReceiveTickAI?.Invoke(OwnerController, ControlledPawn, DeltaSeconds);


        ///<summary>aborts task execution</summary>
        public void FinishAbort()  => 
            BTTask_BlueprintBase_methods.FinishAbort_method.Invoke(ObjPointer);

        ///<summary>finishes task execution with Success or Fail result</summary>
        public void FinishExecute(bool bSuccess)  => 
            BTTask_BlueprintBase_methods.FinishExecute_method.Invoke(ObjPointer, bSuccess);

        ///<summary>check if task is currently being aborted</summary>
        public bool IsTaskAborting()  => 
            BTTask_BlueprintBase_methods.IsTaskAborting_method.Invoke(ObjPointer);

        ///<summary>check if task is currently being executed</summary>
        public bool IsTaskExecuting()  => 
            BTTask_BlueprintBase_methods.IsTaskExecuting_method.Invoke(ObjPointer);

        ///<summary>task execution will be finished (with result 'Success') after receiving specified message</summary>
        public void SetFinishOnMessage(Name MessageName)  => 
            BTTask_BlueprintBase_methods.SetFinishOnMessage_method.Invoke(ObjPointer, MessageName);

        ///<summary>task execution will be finished (with result 'Success') after receiving specified message with indicated ID</summary>
        public void SetFinishOnMessageWithId(Name MessageName, int RequestID)  => 
            BTTask_BlueprintBase_methods.SetFinishOnMessageWithId_method.Invoke(ObjPointer, MessageName, RequestID);
        ///<summary>Cached AIController owner of BehaviorTreeComponent.</summary>
        public unsafe AIController AIOwner {
            get {return BTTask_BlueprintBase_ptr->AIOwner;}
            set {BTTask_BlueprintBase_ptr->AIOwner = value;}
        }
        ///<summary>Cached actor owner of BehaviorTreeComponent.</summary>
        public unsafe Actor ActorOwner {
            get {return BTTask_BlueprintBase_ptr->ActorOwner;}
            set {BTTask_BlueprintBase_ptr->ActorOwner = value;}
        }
        public bool bShowPropertyDetails {
            get {return Main.GetGetBoolPropertyByName(this, "bShowPropertyDetails"); }
            set {Main.SetGetBoolPropertyByName(this, "bShowPropertyDetails", value); }
        }
        static BTTask_BlueprintBase() {
            StaticClass = Main.GetClass("BTTask_BlueprintBase");
            BTTask_BlueprintBase_events.ReceiveAbort_event.Setup();
            BTTask_BlueprintBase_events.ReceiveAbortAI_event.Setup();
            BTTask_BlueprintBase_events.ReceiveExecute_event.Setup();
            BTTask_BlueprintBase_events.ReceiveExecuteAI_event.Setup();
            BTTask_BlueprintBase_events.ReceiveTick_event.Setup();
            BTTask_BlueprintBase_events.ReceiveTickAI_event.Setup();
        }
        internal unsafe BTTask_BlueprintBase_fields* BTTask_BlueprintBase_ptr => (BTTask_BlueprintBase_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BTTask_BlueprintBase(IntPtr p) => UObject.Make<BTTask_BlueprintBase>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BTTask_BlueprintBase DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BTTask_BlueprintBase New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
