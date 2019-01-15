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
    ///<summary>GameStateBase is a class that manages the game's global state, and is spawned by GameModeBase.</summary>
    ///<remarks>It exists on both the client and the server and is fully replicated.</remarks>
    public unsafe partial class GameStateBase : Info  {

        ///<summary>Returns how much time needs to be spent before a player can respawn</summary>
        public float GetPlayerRespawnDelay(Controller Controller)  => 
            GameStateBase_methods.GetPlayerRespawnDelay_method.Invoke(ObjPointer, Controller);

        ///<summary>Returns the time that should be used as when a player started</summary>
        public float GetPlayerStartTime(Controller Controller)  => 
            GameStateBase_methods.GetPlayerStartTime_method.Invoke(ObjPointer, Controller);

        ///<summary>Returns the simulated TimeSeconds on the server, will be synchronized on client and server</summary>
        public float GetServerWorldTimeSeconds()  => 
            GameStateBase_methods.GetServerWorldTimeSeconds_method.Invoke(ObjPointer);

        ///<summary>Returns true if the world has started play (called BeginPlay on actors)</summary>
        public bool HasBegunPlay()  => 
            GameStateBase_methods.HasBegunPlay_method.Invoke(ObjPointer);

        ///<summary>Returns true if the world has started match (called MatchStarted callbacks)</summary>
        public bool HasMatchStarted()  => 
            GameStateBase_methods.HasMatchStarted_method.Invoke(ObjPointer);
        ///<summary>Class of the server's game mode, assigned by GameModeBase.</summary>
        public unsafe SubclassOf<GameModeBase> GameModeClass {
            get {return GameStateBase_ptr->GameModeClass;}
        }
        ///<summary>Instance of the current game mode, exists only on the server. For non-authority clients, this will be NULL.</summary>
        public unsafe GameModeBase AuthorityGameMode {
            get {return GameStateBase_ptr->AuthorityGameMode;}
        }
        ///<summary>Class used by spectators, assigned by GameModeBase.</summary>
        public unsafe SubclassOf<SpectatorPawn> SpectatorClass {
            get {return GameStateBase_ptr->SpectatorClass;}
        }
        ///<summary>Array of all PlayerStates, maintained on both server and clients (PlayerStates are always relevant)</summary>
        public ObjectArrayField<PlayerState> PlayerArray{ get {
            if(PlayerArray_store == null) PlayerArray_store = new ObjectArrayField<PlayerState> (&GameStateBase_ptr->PlayerArray);
            return PlayerArray_store;
        } }
        private ObjectArrayField<PlayerState> PlayerArray_store;

        public bool bReplicatedHasBegunPlay {
            get {return Main.GetGetBoolPropertyByName(this, "bReplicatedHasBegunPlay"); }
            set {Main.SetGetBoolPropertyByName(this, "bReplicatedHasBegunPlay", value); }
        }
        ///<summary>Server TimeSeconds. Useful for syncing up animation and gameplay.</summary>
        public unsafe float ReplicatedWorldTimeSeconds {
            get {return GameStateBase_ptr->ReplicatedWorldTimeSeconds;}
            set {GameStateBase_ptr->ReplicatedWorldTimeSeconds = value;}
        }
        ///<summary>The difference from the local world's TimeSeconds and the server world's TimeSeconds.</summary>
        public unsafe float ServerWorldTimeSecondsDelta {
            get {return GameStateBase_ptr->ServerWorldTimeSecondsDelta;}
            set {GameStateBase_ptr->ServerWorldTimeSecondsDelta = value;}
        }
        ///<summary>Frequency that the server updates the replicated TimeSeconds from the world. Set to zero to disable periodic updates.</summary>
        public unsafe float ServerWorldTimeSecondsUpdateFrequency {
            get {return GameStateBase_ptr->ServerWorldTimeSecondsUpdateFrequency;}
            set {GameStateBase_ptr->ServerWorldTimeSecondsUpdateFrequency = value;}
        }
        static GameStateBase() {
            StaticClass = Main.GetClass("GameStateBase");
        }
        internal unsafe GameStateBase_fields* GameStateBase_ptr => (GameStateBase_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator GameStateBase(IntPtr p) => UObject.Make<GameStateBase>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static GameStateBase DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static GameStateBase New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
