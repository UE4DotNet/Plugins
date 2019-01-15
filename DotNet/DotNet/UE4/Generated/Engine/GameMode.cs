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
    ///<summary>GameMode is a subclass of GameModeBase that behaves like a multiplayer match-based game.</summary>
    ///<remarks>
    ///It has default behavior for picking spawn points and match state.
    ///If you want a simpler base, inherit from GameModeBase instead.
    ///</remarks>
    public unsafe partial class GameMode : GameModeBase  {

        ///<summary>Implementable event to respond to match state changes</summary>
        public event K2_OnSetMatchState_delegate K2_OnSetMatchState;
        public delegate void K2_OnSetMatchState_delegate(Name NewState);
        internal void on_K2_OnSetMatchState(Name NewState) =>
            K2_OnSetMatchState?.Invoke(NewState);


        ///<summary>@return true if ready to End Match. Games should override this</summary>
        public event ReadyToEndMatch_delegate ReadyToEndMatch;
        public delegate bool ReadyToEndMatch_delegate(bool ReturnValue);
        internal bool on_ReadyToEndMatch(bool ReturnValue) =>
            ReadyToEndMatch != null ? ReadyToEndMatch(ReturnValue) : ReturnValue;


        ///<summary>@return True if ready to Start Match. Games should override this</summary>
        public event ReadyToStartMatch_delegate ReadyToStartMatch;
        public delegate bool ReadyToStartMatch_delegate(bool ReturnValue);
        internal bool on_ReadyToStartMatch(bool ReturnValue) =>
            ReadyToStartMatch != null ? ReadyToStartMatch(ReturnValue) : ReturnValue;


        ///<summary>Report that a match has failed due to unrecoverable error</summary>
        public void AbortMatch()  => 
            GameMode_methods.AbortMatch_method.Invoke(ObjPointer);

        ///<summary>Transition from InProgress to WaitingPostMatch. You can call this manually, will also get called if ReadyToEndMatch returns true</summary>
        public void EndMatch()  => 
            GameMode_methods.EndMatch_method.Invoke(ObjPointer);

        ///<summary>Returns the current match state, this is an accessor to protect the state machine flow</summary>
        public Name GetMatchState()  => 
            GameMode_methods.GetMatchState_method.Invoke(ObjPointer);

        ///<summary>Returns true if the match state is WaitingPostMatch or later</summary>
        public bool HasMatchEnded()  => 
            GameMode_methods.HasMatchEnded_method.Invoke(ObjPointer);

        ///<summary>Returns true if the match state is InProgress or other gameplay state</summary>
        public bool IsMatchInProgress()  => 
            GameMode_methods.IsMatchInProgress_method.Invoke(ObjPointer);

        ///<summary>Restart the game, by default travel to the current map</summary>
        public void RestartGame()  => 
            GameMode_methods.RestartGame_method.Invoke(ObjPointer);

        ///<summary>Exec command to broadcast a string to all players</summary>
        public void Say(string Msg)  => 
            GameMode_methods.Say_method.Invoke(ObjPointer, Msg);

        ///<summary>Transition from WaitingToStart to InProgress. You can call this manually, will also get called if ReadyToStartMatch returns true</summary>
        public void StartMatch()  => 
            GameMode_methods.StartMatch_method.Invoke(ObjPointer);
        ///<summary>What match state we are currently in</summary>
        public unsafe Name MatchState {
            get {return GameMode_ptr->MatchState;}
            set {GameMode_ptr->MatchState = value;}
        }
        public bool bDelayedStart {
            get {return Main.GetGetBoolPropertyByName(this, "bDelayedStart"); }
        }
        ///<summary>Current number of spectators.</summary>
        public unsafe int NumSpectators {
            get {return GameMode_ptr->NumSpectators;}
        }
        ///<summary>Current number of human players.</summary>
        public unsafe int NumPlayers {
            get {return GameMode_ptr->NumPlayers;}
        }
        ///<summary>number of non-human players (AI controlled but participating as a player).</summary>
        public unsafe int NumBots {
            get {return GameMode_ptr->NumBots;}
        }
        ///<summary>Minimum time before player can respawn after dying.</summary>
        public unsafe float MinRespawnDelay {
            get {return GameMode_ptr->MinRespawnDelay;}
        }
        ///<summary>Number of players that are still traveling from a previous map</summary>
        public unsafe int NumTravellingPlayers {
            get {return GameMode_ptr->NumTravellingPlayers;}
        }
        ///<summary>Contains strings describing localized game agnostic messages.</summary>
        public unsafe SubclassOf<LocalMessage> EngineMessageClass {
            get {return GameMode_ptr->EngineMessageClass;}
            set {GameMode_ptr->EngineMessageClass = value;}
        }
        ///<summary>PlayerStates of players who have disconnected from the server (saved in case they reconnect)</summary>
        public ObjectArrayField<PlayerState> InactivePlayerArray{ get {
            if(InactivePlayerArray_store == null) InactivePlayerArray_store = new ObjectArrayField<PlayerState> (&GameMode_ptr->InactivePlayerArray);
            return InactivePlayerArray_store;
        } }
        private ObjectArrayField<PlayerState> InactivePlayerArray_store;

        ///<summary>Time a playerstate will stick around in an inactive state after a player logout</summary>
        public unsafe float InactivePlayerStateLifeSpan {
            get {return GameMode_ptr->InactivePlayerStateLifeSpan;}
            set {GameMode_ptr->InactivePlayerStateLifeSpan = value;}
        }
        ///<summary>The maximum number of inactive players before we kick the oldest ones out</summary>
        public unsafe int MaxInactivePlayers {
            get {return GameMode_ptr->MaxInactivePlayers;}
            set {GameMode_ptr->MaxInactivePlayers = value;}
        }
        public bool bHandleDedicatedServerReplays {
            get {return Main.GetGetBoolPropertyByName(this, "bHandleDedicatedServerReplays"); }
            set {Main.SetGetBoolPropertyByName(this, "bHandleDedicatedServerReplays", value); }
        }
        static GameMode() {
            StaticClass = Main.GetClass("GameMode");
            GameMode_events.K2_OnSetMatchState_event.Setup();
            GameMode_events.ReadyToEndMatch_event.Setup();
            GameMode_events.ReadyToStartMatch_event.Setup();
        }
        internal unsafe GameMode_fields* GameMode_ptr => (GameMode_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator GameMode(IntPtr p) => UObject.Make<GameMode>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static GameMode DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static GameMode New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
