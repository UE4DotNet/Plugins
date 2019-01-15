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
    ///<summary>GameInstance: high-level manager object for an instance of the running game.</summary>
    ///<remarks>
    ///Spawned at game creation and not destroyed until game instance is shut down.
    ///Running as a standalone game, there will be one of these.
    ///Running in PIE (play-in-editor) will generate one of these per PIE instance.
    ///</remarks>
    public unsafe partial class GameInstance : UObject  {

        ///<summary>Opportunity for blueprints to handle network errors.</summary>
        public event HandleNetworkError_delegate HandleNetworkError;
        public delegate void HandleNetworkError_delegate(byte FailureType, bool bIsServer);
        internal void on_HandleNetworkError(byte FailureType, bool bIsServer) =>
            HandleNetworkError?.Invoke(FailureType, bIsServer);


        ///<summary>Opportunity for blueprints to handle travel errors.</summary>
        public event HandleTravelError_delegate HandleTravelError;
        public delegate void HandleTravelError_delegate(byte FailureType);
        internal void on_HandleTravelError(byte FailureType) =>
            HandleTravelError?.Invoke(FailureType);


        ///<summary>Opportunity for blueprints to handle the game instance being initialized.</summary>
        public event ReceiveInit_delegate ReceiveInit;
        public delegate void ReceiveInit_delegate();
        internal void on_ReceiveInit() =>
            ReceiveInit?.Invoke();


        ///<summary>Opportunity for blueprints to handle the game instance being shutdown.</summary>
        public event ReceiveShutdown_delegate ReceiveShutdown;
        public delegate void ReceiveShutdown_delegate();
        internal void on_ReceiveShutdown() =>
            ReceiveShutdown?.Invoke();

        ///<summary>List of locally participating players in this game instance</summary>
        public ObjectArrayField<LocalPlayer> LocalPlayers{ get {
            if(LocalPlayers_store == null) LocalPlayers_store = new ObjectArrayField<LocalPlayer> (&GameInstance_ptr->LocalPlayers);
            return LocalPlayers_store;
        } }
        private ObjectArrayField<LocalPlayer> LocalPlayers_store;

        ///<summary>Class to manage online services</summary>
        public unsafe OnlineSession OnlineSession {
            get {return GameInstance_ptr->OnlineSession;}
            set {GameInstance_ptr->OnlineSession = value;}
        }
        ///<summary>List of objects that are being kept alive by this game instance. Stored as array for fast iteration, should not be modified every frame</summary>
        public ObjectArrayField<UObject> ReferencedObjects{ get {
            if(ReferencedObjects_store == null) ReferencedObjects_store = new ObjectArrayField<UObject> (&GameInstance_ptr->ReferencedObjects);
            return ReferencedObjects_store;
        } }
        private ObjectArrayField<UObject> ReferencedObjects_store;

        static GameInstance() {
            StaticClass = Main.GetClass("GameInstance");
            GameInstance_events.HandleNetworkError_event.Setup();
            GameInstance_events.HandleTravelError_event.Setup();
            GameInstance_events.ReceiveInit_event.Setup();
            GameInstance_events.ReceiveShutdown_event.Setup();
        }
        internal unsafe GameInstance_fields* GameInstance_ptr => (GameInstance_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator GameInstance(IntPtr p) => UObject.Make<GameInstance>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static GameInstance DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static GameInstance New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
