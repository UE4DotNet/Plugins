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
    ///<summary>AISense Blueprint</summary>
    public unsafe partial class AISense_Blueprint : AISense  {

        ///<summary>called when sense's instance gets notified about new pawn that has just been spawned</summary>
        public event K2_OnNewPawn_delegate K2_OnNewPawn;
        public delegate void K2_OnNewPawn_delegate(Pawn NewPawn);
        internal void on_K2_OnNewPawn(Pawn NewPawn) =>
            K2_OnNewPawn?.Invoke(NewPawn);


        ///<summary>@param PerceptionComponent is ActorListener's AIPerceptionComponent instance</summary>
        public event OnListenerRegistered_delegate OnListenerRegistered;
        public delegate void OnListenerRegistered_delegate(Actor ActorListener, AIPerceptionComponent PerceptionComponent);
        internal void on_OnListenerRegistered(Actor ActorListener, AIPerceptionComponent PerceptionComponent) =>
            OnListenerRegistered?.Invoke(ActorListener, PerceptionComponent);


        ///<summary>called when a listener unregistered from this sense.</summary>
        ///<remarks>
        ///Most often this is called due to actor's death
        ///    @param PerceptionComponent is ActorListener's AIPerceptionComponent instance
        ///</remarks>
        public event OnListenerUnregistered_delegate OnListenerUnregistered;
        public delegate void OnListenerUnregistered_delegate(Actor ActorListener, AIPerceptionComponent PerceptionComponent);
        internal void on_OnListenerUnregistered(Actor ActorListener, AIPerceptionComponent PerceptionComponent) =>
            OnListenerUnregistered?.Invoke(ActorListener, PerceptionComponent);


        ///<summary>@param PerceptionComponent is ActorListener's AIPerceptionComponent instance</summary>
        public event OnListenerUpdated_delegate OnListenerUpdated;
        public delegate void OnListenerUpdated_delegate(Actor ActorListener, AIPerceptionComponent PerceptionComponent);
        internal void on_OnListenerUpdated(Actor ActorListener, AIPerceptionComponent PerceptionComponent) =>
            OnListenerUpdated?.Invoke(ActorListener, PerceptionComponent);

        //TODO: class_event: event with array parameter OnUpdate

        ///<summary>Get All Listener Actors</summary>
        public IReadOnlyCollection<Actor> GetAllListenerActors()  => 
            AISense_Blueprint_methods.GetAllListenerActors_method.Invoke(ObjPointer);

        ///<summary>Get All Listener Components</summary>
        public IReadOnlyCollection<AIPerceptionComponent> GetAllListenerComponents()  => 
            AISense_Blueprint_methods.GetAllListenerComponents_method.Invoke(ObjPointer);
        ///<summary>Listener Data Type</summary>
        public unsafe SubclassOf<UserDefinedStruct> ListenerDataType {
            get {return AISense_Blueprint_ptr->ListenerDataType;}
            set {AISense_Blueprint_ptr->ListenerDataType = value;}
        }
        ///<summary>Listener Container</summary>
        public ObjectArrayField<AIPerceptionComponent> ListenerContainer{ get {
            if(ListenerContainer_store == null) ListenerContainer_store = new ObjectArrayField<AIPerceptionComponent> (&AISense_Blueprint_ptr->ListenerContainer);
            return ListenerContainer_store;
        } }
        private ObjectArrayField<AIPerceptionComponent> ListenerContainer_store;

        ///<summary>Unprocessed Events</summary>
        public ObjectArrayField<AISenseEvent> UnprocessedEvents{ get {
            if(UnprocessedEvents_store == null) UnprocessedEvents_store = new ObjectArrayField<AISenseEvent> (&AISense_Blueprint_ptr->UnprocessedEvents);
            return UnprocessedEvents_store;
        } }
        private ObjectArrayField<AISenseEvent> UnprocessedEvents_store;

        static AISense_Blueprint() {
            StaticClass = Main.GetClass("AISense_Blueprint");
            AISense_Blueprint_events.K2_OnNewPawn_event.Setup();
            AISense_Blueprint_events.OnListenerRegistered_event.Setup();
            AISense_Blueprint_events.OnListenerUnregistered_event.Setup();
            AISense_Blueprint_events.OnListenerUpdated_event.Setup();
            //TODO: call_event_setup: event with array parameter: OnUpdate
        }
        internal unsafe AISense_Blueprint_fields* AISense_Blueprint_ptr => (AISense_Blueprint_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AISense_Blueprint(IntPtr p) => UObject.Make<AISense_Blueprint>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AISense_Blueprint DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AISense_Blueprint New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
