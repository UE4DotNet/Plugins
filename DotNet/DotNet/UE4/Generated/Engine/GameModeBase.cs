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
    ///<summary>The GameModeBase defines the game being played.</summary>
    ///<remarks>
    ///It governs the game rules, scoring, what actors
    ///are allowed to exist in this game type, and who may enter the game.
    ///
    ///It is only instanced on the server and will never exist on the client.
    ///
    ///A GameModeBase actor is instantiated when the level is initialized for gameplay in
    ///C++ UGameEngine::LoadMap().
    ///
    ///The class of this GameMode actor is determined by (in order) either the URL ?game=xxx,
    ///the GameMode Override value set in the World Settings, or the DefaultGameMode entry set
    ///in the game's Project Settings.
    ///
    ///@see https://docs.unrealengine.com/latest/INT/Gameplay/Framework/GameMode/index.html
    ///</remarks>
    public unsafe partial class GameModeBase : Info  {

        ///<summary>
        ///Overridable event for GameMode blueprint to respond to a change name call
        ///@
        ///</summary>
        ///<remarks>
        ///param Controller    The controller of the player to change the name of
        ///@param NewName               The name to set the player to
        ///@param bNameChange   Whether the name is changing or if this is the first time it has been set
        ///</remarks>
        public event K2_OnChangeName_delegate K2_OnChangeName;
        public delegate void K2_OnChangeName_delegate(Controller Other, string NewName, bool bNameChange);
        internal void on_K2_OnChangeName(Controller Other, string NewName, bool bNameChange) =>
            K2_OnChangeName?.Invoke(Other, NewName, bNameChange);


        ///<summary>Implementable event when a Controller with a PlayerState leaves the game.</summary>
        public event K2_OnLogout_delegate K2_OnLogout;
        public delegate void K2_OnLogout_delegate(Controller ExitingController);
        internal void on_K2_OnLogout(Controller ExitingController) =>
            K2_OnLogout?.Invoke(ExitingController);


        ///<summary>Implementable event called at the end of RestartPlayer</summary>
        public event K2_OnRestartPlayer_delegate K2_OnRestartPlayer;
        public delegate void K2_OnRestartPlayer_delegate(Controller NewPlayer);
        internal void on_K2_OnRestartPlayer(Controller NewPlayer) =>
            K2_OnRestartPlayer?.Invoke(NewPlayer);


        ///<summary>Called when a PlayerController is swapped to a new one during seamless travel</summary>
        public event K2_OnSwapPlayerControllers_delegate K2_OnSwapPlayerControllers;
        public delegate void K2_OnSwapPlayerControllers_delegate(PlayerController OldPC, PlayerController NewPC);
        internal void on_K2_OnSwapPlayerControllers(PlayerController OldPC, PlayerController NewPC) =>
            K2_OnSwapPlayerControllers?.Invoke(OldPC, NewPC);


        ///<summary>Notification that a player has successfully logged in, and has been given a player controller</summary>
        public event K2_PostLogin_delegate K2_PostLogin;
        public delegate void K2_PostLogin_delegate(PlayerController NewPlayer);
        internal void on_K2_PostLogin(PlayerController NewPlayer) =>
            K2_PostLogin?.Invoke(NewPlayer);


        ///<summary>Return whether Viewer is allowed to spectate from the point of view of ViewTarget.</summary>
        public event CanSpectate_delegate CanSpectate;
        public delegate bool CanSpectate_delegate(PlayerController Viewer, PlayerState ViewTarget, bool ReturnValue);
        internal bool on_CanSpectate(PlayerController Viewer, PlayerState ViewTarget, bool ReturnValue) =>
            CanSpectate != null ? CanSpectate(Viewer, ViewTarget, ReturnValue) : ReturnValue;


        ///<summary>
        ///Return the 'best' player start for this player to spawn from
        ///Default implementation looks for a random unoccupied spot
        ///@
        ///</summary>
        ///<remarks>
        ///param Player is the controller for whom we are choosing a playerstart
        ///@returns AActor chosen as player start (usually a PlayerStart)
        ///</remarks>
        public event ChoosePlayerStart_delegate ChoosePlayerStart;
        public delegate Actor ChoosePlayerStart_delegate(Controller Player, Actor ReturnValue);
        internal Actor on_ChoosePlayerStart(Controller Player, Actor ReturnValue) =>
            ChoosePlayerStart != null ? ChoosePlayerStart(Player, ReturnValue) : ReturnValue;


        ///<summary>
        ///Return the specific player start actor that should be used for the next spawn
        ///This will either use a previously saved startactor, or calls ChoosePlayerStart
        ///@
        ///</summary>
        ///<remarks>
        ///param Player The AController for whom we are choosing a Player Start
        ///@param IncomingName Specifies the tag of a Player Start to use
        ///@returns Actor chosen as player start (usually a PlayerStart)
        ///</remarks>
        public event FindPlayerStart_delegate FindPlayerStart;
        public delegate Actor FindPlayerStart_delegate(Controller Player, string IncomingName, Actor ReturnValue);
        internal Actor on_FindPlayerStart(Controller Player, string IncomingName, Actor ReturnValue) =>
            FindPlayerStart != null ? FindPlayerStart(Player, IncomingName, ReturnValue) : ReturnValue;


        ///<summary>Returns default pawn class for given controller</summary>
        public event GetDefaultPawnClassForController_delegate GetDefaultPawnClassForController;
        public delegate SubclassOf<UObject> GetDefaultPawnClassForController_delegate(Controller InController, SubclassOf<UObject> ReturnValue);
        internal SubclassOf<UObject> on_GetDefaultPawnClassForController(Controller InController, SubclassOf<UObject> ReturnValue) =>
            GetDefaultPawnClassForController != null ? GetDefaultPawnClassForController(InController, ReturnValue) : ReturnValue;


        ///<summary>Signals that a player is ready to enter the game, which may start it up</summary>
        public event HandleStartingNewPlayer_delegate HandleStartingNewPlayer;
        public delegate void HandleStartingNewPlayer_delegate(PlayerController NewPlayer);
        internal void on_HandleStartingNewPlayer(PlayerController NewPlayer) =>
            HandleStartingNewPlayer?.Invoke(NewPlayer);


        ///<summary>Initialize the AHUD object for a player. Games can override this to do something different</summary>
        public event InitializeHUDForPlayer_delegate InitializeHUDForPlayer;
        public delegate void InitializeHUDForPlayer_delegate(PlayerController NewPlayer);
        internal void on_InitializeHUDForPlayer(PlayerController NewPlayer) =>
            InitializeHUDForPlayer?.Invoke(NewPlayer);


        ///<summary>Called from RestartPlayerAtPlayerStart, can be used to initialize the start spawn actor</summary>
        public event InitStartSpot_delegate InitStartSpot;
        public delegate void InitStartSpot_delegate(Actor StartSpot, Controller NewPlayer);
        internal void on_InitStartSpot(Actor StartSpot, Controller NewPlayer) =>
            InitStartSpot?.Invoke(StartSpot, NewPlayer);


        ///<summary>Returns true if NewPlayerController may only join the server as a spectator.</summary>
        public event MustSpectate_delegate MustSpectate;
        public delegate bool MustSpectate_delegate(PlayerController NewPlayerController, bool ReturnValue);
        internal bool on_MustSpectate(PlayerController NewPlayerController, bool ReturnValue) =>
            MustSpectate != null ? MustSpectate(NewPlayerController, ReturnValue) : ReturnValue;


        ///<summary>Returns true if it's valid to call RestartPlayer. By default will call Player->CanRestartPlayer</summary>
        public event PlayerCanRestart_delegate PlayerCanRestart;
        public delegate bool PlayerCanRestart_delegate(PlayerController Player, bool ReturnValue);
        internal bool on_PlayerCanRestart(PlayerController Player, bool ReturnValue) =>
            PlayerCanRestart != null ? PlayerCanRestart(Player, ReturnValue) : ReturnValue;


        ///<summary>Overridable function to determine whether an Actor should have Reset called when the game has Reset called on it.</summary>
        ///<remarks>
        ///Default implementation returns true
        ///@param ActorToReset The actor to make a determination for
        ///@return true if ActorToReset should have Reset() called on it while restarting the game,
        ///                false if the GameMode will manually reset it or if the actor does not need to be reset
        ///</remarks>
        public event ShouldReset_delegate ShouldReset;
        public delegate bool ShouldReset_delegate(Actor ActorToReset, bool ReturnValue);
        internal bool on_ShouldReset(Actor ActorToReset, bool ReturnValue) =>
            ShouldReset != null ? ShouldReset(ActorToReset, ReturnValue) : ReturnValue;

        //TODO: class_event: event with struct parameter SpawnDefaultPawnAtTransform

        ///<summary>
        ///Called during RestartPlayer to actually spawn the player's pawn, when using a start spot
        ///@
        ///</summary>
        ///<remarks>
        ///param       NewPlayer - Controller for whom this pawn is spawned
        ///@param       StartSpot - Actor at which to spawn pawn
        ///@return      a pawn of the default pawn class
        ///</remarks>
        public event SpawnDefaultPawnFor_delegate SpawnDefaultPawnFor;
        public delegate Pawn SpawnDefaultPawnFor_delegate(Controller NewPlayer, Actor StartSpot, Pawn ReturnValue);
        internal Pawn on_SpawnDefaultPawnFor(Controller NewPlayer, Actor StartSpot, Pawn ReturnValue) =>
            SpawnDefaultPawnFor != null ? SpawnDefaultPawnFor(NewPlayer, StartSpot, ReturnValue) : ReturnValue;


        ///<summary>
        ///Sets the name for a controller
        ///@
        ///</summary>
        ///<remarks>
        ///param Controller    The controller of the player to change the name of
        ///@param NewName               The name to set the player to
        ///@param bNameChange   Whether the name is changing or if this is the first time it has been set
        ///</remarks>
        public void ChangeName(Controller Controller, string NewName, bool bNameChange)  => 
            GameModeBase_methods.ChangeName_method.Invoke(ObjPointer, Controller, NewName, bNameChange);

        ///<summary>Returns number of active human players, excluding spectators</summary>
        public int GetNumPlayers()  => 
            GameModeBase_methods.GetNumPlayers_method.Invoke(ObjPointer);

        ///<summary>Returns number of human players currently spectating</summary>
        public int GetNumSpectators()  => 
            GameModeBase_methods.GetNumSpectators_method.Invoke(ObjPointer);

        ///<summary>Returns true if the match start callbacks have been called</summary>
        public bool HasMatchStarted()  => 
            GameModeBase_methods.HasMatchStarted_method.Invoke(ObjPointer);

        ///<summary>
        ///Return the specific player start actor that should be used for the next spawn
        ///This will either use a previously saved startactor, or calls ChoosePlayerStart
        ///@
        ///</summary>
        ///<remarks>
        ///param Player The AController for whom we are choosing a Player Start
        ///@param IncomingName Specifies the tag of a Player Start to use
        ///@returns Actor chosen as player start (usually a PlayerStart)
        ///</remarks>
        public Actor K2_FindPlayerStart(Controller Player, string IncomingName)  => 
            GameModeBase_methods.K2_FindPlayerStart_method.Invoke(ObjPointer, Player, IncomingName);

        ///<summary>Overridable function called when resetting level.</summary>
        ///<remarks>
        ///This is used to reset the game state while staying in the same map
        ///Default implementation calls Reset() on all actors except GameMode and Controllers
        ///</remarks>
        public void ResetLevel()  => 
            GameModeBase_methods.ResetLevel_method.Invoke(ObjPointer);

        ///<summary>Tries to spawn the player's pawn, at the location returned by FindPlayerStart</summary>
        public void RestartPlayer(Controller NewPlayer)  => 
            GameModeBase_methods.RestartPlayer_method.Invoke(ObjPointer, NewPlayer);

        ///<summary>Tries to spawn the player's pawn at the specified actor's location</summary>
        public void RestartPlayerAtPlayerStart(Controller NewPlayer, Actor StartSpot)  => 
            GameModeBase_methods.RestartPlayerAtPlayerStart_method.Invoke(ObjPointer, NewPlayer, StartSpot);

        ///<summary>Tries to spawn the player's pawn at a specific location</summary>
        public void RestartPlayerAtTransform(Controller NewPlayer, Transform SpawnTransform)  => 
            GameModeBase_methods.RestartPlayerAtTransform_method.Invoke(ObjPointer, NewPlayer, SpawnTransform);

        ///<summary>Return to main menu, and disconnect any players</summary>
        public void ReturnToMainMenuHost()  => 
            GameModeBase_methods.ReturnToMainMenuHost_method.Invoke(ObjPointer);

        ///<summary>Transitions to calls BeginPlay on actors.</summary>
        public void StartPlay()  => 
            GameModeBase_methods.StartPlay_method.Invoke(ObjPointer);
         //TODO: string FString OptionsString
        ///<summary>Class of GameSession, which handles login approval and online game interface</summary>
        public unsafe SubclassOf<GameSession> GameSessionClass {
            get {return GameModeBase_ptr->GameSessionClass;}
            set {GameModeBase_ptr->GameSessionClass = value;}
        }
        ///<summary>Class of GameState associated with this GameMode.</summary>
        public unsafe SubclassOf<GameStateBase> GameStateClass {
            get {return GameModeBase_ptr->GameStateClass;}
        }
        ///<summary>The class of PlayerController to spawn for players logging in.</summary>
        public unsafe SubclassOf<PlayerController> PlayerControllerClass {
            get {return GameModeBase_ptr->PlayerControllerClass;}
        }
        ///<summary>A PlayerState of this class will be associated with every player to replicate relevant player information to all clients.</summary>
        public unsafe SubclassOf<PlayerState> PlayerStateClass {
            get {return GameModeBase_ptr->PlayerStateClass;}
        }
        ///<summary>HUD class this game uses.</summary>
        public unsafe SubclassOf<HUD> HUDClass {
            get {return GameModeBase_ptr->HUDClass;}
            set {GameModeBase_ptr->HUDClass = value;}
        }
        ///<summary>The default pawn class used by players.</summary>
        public unsafe SubclassOf<Pawn> DefaultPawnClass {
            get {return GameModeBase_ptr->DefaultPawnClass;}
            set {GameModeBase_ptr->DefaultPawnClass = value;}
        }
        ///<summary>The pawn class used by the PlayerController for players when spectating.</summary>
        public unsafe SubclassOf<SpectatorPawn> SpectatorClass {
            get {return GameModeBase_ptr->SpectatorClass;}
        }
        ///<summary>The PlayerController class used when spectating a network replay.</summary>
        public unsafe SubclassOf<PlayerController> ReplaySpectatorPlayerControllerClass {
            get {return GameModeBase_ptr->ReplaySpectatorPlayerControllerClass;}
        }
        ///<summary>Server Stat Replicator Class</summary>
        public unsafe SubclassOf<ServerStatReplicator> ServerStatReplicatorClass {
            get {return GameModeBase_ptr->ServerStatReplicatorClass;}
        }
        ///<summary>Game Session handles login approval, arbitration, online game interface</summary>
        public unsafe GameSession GameSession {
            get {return GameModeBase_ptr->GameSession;}
            set {GameModeBase_ptr->GameSession = value;}
        }
        ///<summary>GameState is used to replicate game state relevant properties to all clients.</summary>
        public unsafe GameStateBase GameState {
            get {return GameModeBase_ptr->GameState;}
            set {GameModeBase_ptr->GameState = value;}
        }
        ///<summary>Server Stat Replicator</summary>
        public unsafe ServerStatReplicator ServerStatReplicator {
            get {return GameModeBase_ptr->ServerStatReplicator;}
            set {GameModeBase_ptr->ServerStatReplicator = value;}
        }
         //TODO: text FText DefaultPlayerName
        public bool bUseSeamlessTravel {
            get {return Main.GetGetBoolPropertyByName(this, "bUseSeamlessTravel"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseSeamlessTravel", value); }
        }
        public bool bStartPlayersAsSpectators {
            get {return Main.GetGetBoolPropertyByName(this, "bStartPlayersAsSpectators"); }
        }
        public bool bPauseable {
            get {return Main.GetGetBoolPropertyByName(this, "bPauseable"); }
            set {Main.SetGetBoolPropertyByName(this, "bPauseable", value); }
        }
        static GameModeBase() {
            StaticClass = Main.GetClass("GameModeBase");
            GameModeBase_events.K2_OnChangeName_event.Setup();
            GameModeBase_events.K2_OnLogout_event.Setup();
            GameModeBase_events.K2_OnRestartPlayer_event.Setup();
            GameModeBase_events.K2_OnSwapPlayerControllers_event.Setup();
            GameModeBase_events.K2_PostLogin_event.Setup();
            GameModeBase_events.CanSpectate_event.Setup();
            GameModeBase_events.ChoosePlayerStart_event.Setup();
            GameModeBase_events.FindPlayerStart_event.Setup();
            GameModeBase_events.GetDefaultPawnClassForController_event.Setup();
            GameModeBase_events.HandleStartingNewPlayer_event.Setup();
            GameModeBase_events.InitializeHUDForPlayer_event.Setup();
            GameModeBase_events.InitStartSpot_event.Setup();
            GameModeBase_events.MustSpectate_event.Setup();
            GameModeBase_events.PlayerCanRestart_event.Setup();
            GameModeBase_events.ShouldReset_event.Setup();
            //TODO: call_event_setup: event with struct parameter SpawnDefaultPawnAtTransform
            GameModeBase_events.SpawnDefaultPawnFor_event.Setup();
        }
        internal unsafe GameModeBase_fields* GameModeBase_ptr => (GameModeBase_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator GameModeBase(IntPtr p) => UObject.Make<GameModeBase>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static GameModeBase DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static GameModeBase New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
