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
    ///<summary>Base class for blueprint based service nodes.</summary>
    ///<remarks>
    ///Do NOT use it for creating native c++ classes!
    ///
    ///When service receives Deactivation event, all latent actions associated this instance are being removed.
    ///This prevents from resuming activity started by Activation, but does not handle external events.
    ///Please use them safely (unregister at abort) and call IsServiceActive() when in doubt.
    ///</remarks>
    public unsafe partial class BTService_BlueprintBase : BTService  {

        ///<summary>
        ///service became active
        ///    @
        ///</summary>
        ///<remarks>
        ///Note that if both generic and AI event versions are implemented only the more
        ///    suitable one will be called, meaning the AI version if called for AI, generic one otherwise
        ///</remarks>
        public event ReceiveActivation_delegate ReceiveActivation;
        public delegate void ReceiveActivation_delegate(Actor OwnerActor);
        internal void on_ReceiveActivation(Actor OwnerActor) =>
            ReceiveActivation?.Invoke(OwnerActor);


        ///<summary>Alternative AI version of ReceiveActivation function.</summary>
        ///<remarks>
        ///@see ReceiveActivation for more details
        ///    @Note that if both generic and AI event versions are implemented only the more
        ///    suitable one will be called, meaning the AI version if called for AI, generic one otherwise
        ///</remarks>
        public event ReceiveActivationAI_delegate ReceiveActivationAI;
        public delegate void ReceiveActivationAI_delegate(AIController OwnerController, Pawn ControlledPawn);
        internal void on_ReceiveActivationAI(AIController OwnerController, Pawn ControlledPawn) =>
            ReceiveActivationAI?.Invoke(OwnerController, ControlledPawn);


        ///<summary>
        ///service became inactive
        ///    @
        ///</summary>
        ///<remarks>
        ///Note that if both generic and AI event versions are implemented only the more
        ///    suitable one will be called, meaning the AI version if called for AI, generic one otherwise
        ///</remarks>
        public event ReceiveDeactivation_delegate ReceiveDeactivation;
        public delegate void ReceiveDeactivation_delegate(Actor OwnerActor);
        internal void on_ReceiveDeactivation(Actor OwnerActor) =>
            ReceiveDeactivation?.Invoke(OwnerActor);


        ///<summary>Alternative AI version of ReceiveDeactivation function.</summary>
        ///<remarks>
        ///@see ReceiveDeactivation for more details
        ///    @Note that if both generic and AI event versions are implemented only the more
        ///    suitable one will be called, meaning the AI version if called for AI, generic one otherwise
        ///</remarks>
        public event ReceiveDeactivationAI_delegate ReceiveDeactivationAI;
        public delegate void ReceiveDeactivationAI_delegate(AIController OwnerController, Pawn ControlledPawn);
        internal void on_ReceiveDeactivationAI(AIController OwnerController, Pawn ControlledPawn) =>
            ReceiveDeactivationAI?.Invoke(OwnerController, ControlledPawn);


        ///<summary>
        ///task search enters branch of tree
        ///    @
        ///</summary>
        ///<remarks>
        ///Note that if both generic and AI event versions are implemented only the more
        ///    suitable one will be called, meaning the AI version if called for AI, generic one otherwise
        ///</remarks>
        public event ReceiveSearchStart_delegate ReceiveSearchStart;
        public delegate void ReceiveSearchStart_delegate(Actor OwnerActor);
        internal void on_ReceiveSearchStart(Actor OwnerActor) =>
            ReceiveSearchStart?.Invoke(OwnerActor);


        ///<summary>Alternative AI version of ReceiveSearchStart function.</summary>
        ///<remarks>
        ///@see ReceiveSearchStart for more details
        ///    @Note that if both generic and AI event versions are implemented only the more
        ///    suitable one will be called, meaning the AI version if called for AI, generic one otherwise
        ///</remarks>
        public event ReceiveSearchStartAI_delegate ReceiveSearchStartAI;
        public delegate void ReceiveSearchStartAI_delegate(AIController OwnerController, Pawn ControlledPawn);
        internal void on_ReceiveSearchStartAI(AIController OwnerController, Pawn ControlledPawn) =>
            ReceiveSearchStartAI?.Invoke(OwnerController, ControlledPawn);


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


        ///<summary>Alternative AI version of ReceiveTick function.</summary>
        ///<remarks>
        ///@see ReceiveTick for more details
        ///    @Note that if both generic and AI event versions are implemented only the more
        ///    suitable one will be called, meaning the AI version if called for AI, generic one otherwise
        ///</remarks>
        public event ReceiveTickAI_delegate ReceiveTickAI;
        public delegate void ReceiveTickAI_delegate(AIController OwnerController, Pawn ControlledPawn, float DeltaSeconds);
        internal void on_ReceiveTickAI(AIController OwnerController, Pawn ControlledPawn, float DeltaSeconds) =>
            ReceiveTickAI?.Invoke(OwnerController, ControlledPawn, DeltaSeconds);


        ///<summary>check if service is currently being active</summary>
        public bool IsServiceActive()  => 
            BTService_BlueprintBase_methods.IsServiceActive_method.Invoke(ObjPointer);
        ///<summary>Cached AIController owner of BehaviorTreeComponent.</summary>
        public unsafe AIController AIOwner {
            get {return BTService_BlueprintBase_ptr->AIOwner;}
            set {BTService_BlueprintBase_ptr->AIOwner = value;}
        }
        ///<summary>Cached actor owner of BehaviorTreeComponent.</summary>
        public unsafe Actor ActorOwner {
            get {return BTService_BlueprintBase_ptr->ActorOwner;}
            set {BTService_BlueprintBase_ptr->ActorOwner = value;}
        }
        public bool bShowPropertyDetails {
            get {return Main.GetGetBoolPropertyByName(this, "bShowPropertyDetails"); }
            set {Main.SetGetBoolPropertyByName(this, "bShowPropertyDetails", value); }
        }
        public bool bShowEventDetails {
            get {return Main.GetGetBoolPropertyByName(this, "bShowEventDetails"); }
            set {Main.SetGetBoolPropertyByName(this, "bShowEventDetails", value); }
        }
        static BTService_BlueprintBase() {
            StaticClass = Main.GetClass("BTService_BlueprintBase");
            BTService_BlueprintBase_events.ReceiveActivation_event.Setup();
            BTService_BlueprintBase_events.ReceiveActivationAI_event.Setup();
            BTService_BlueprintBase_events.ReceiveDeactivation_event.Setup();
            BTService_BlueprintBase_events.ReceiveDeactivationAI_event.Setup();
            BTService_BlueprintBase_events.ReceiveSearchStart_event.Setup();
            BTService_BlueprintBase_events.ReceiveSearchStartAI_event.Setup();
            BTService_BlueprintBase_events.ReceiveTick_event.Setup();
            BTService_BlueprintBase_events.ReceiveTickAI_event.Setup();
        }
        internal unsafe BTService_BlueprintBase_fields* BTService_BlueprintBase_ptr => (BTService_BlueprintBase_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BTService_BlueprintBase(IntPtr p) => UObject.Make<BTService_BlueprintBase>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BTService_BlueprintBase DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BTService_BlueprintBase New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
