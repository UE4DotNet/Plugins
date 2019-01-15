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
    ///<summary>A PlayerState is created for every player on a server (or in a standalone game).</summary>
    ///<remarks>PlayerStates are replicated to all clients, and contain network game relevant information about the player, such as playername, score, etc.</remarks>
    public unsafe partial class PlayerState : Info  {

        ///<summary>
        ///* Can be implemented in Blueprint Child to move more properties from old to new PlayerState when traveling to a new level
        ///*
        ///* @
        ///</summary>
        ///<remarks>param NewPlayerState         New PlayerState, which we fill with the current properties</remarks>
        public event ReceiveCopyProperties_delegate ReceiveCopyProperties;
        public delegate void ReceiveCopyProperties_delegate(PlayerState NewPlayerState);
        internal void on_ReceiveCopyProperties(PlayerState NewPlayerState) =>
            ReceiveCopyProperties?.Invoke(NewPlayerState);


        ///<summary>
        ///* Can be implemented in Blueprint Child to move more properties from old to new PlayerState when reconnecting
        ///*
        ///* @
        ///</summary>
        ///<remarks>param OldPlayerState         Old PlayerState, which we use to fill the new one with</remarks>
        public event ReceiveOverrideWith_delegate ReceiveOverrideWith;
        public delegate void ReceiveOverrideWith_delegate(PlayerState OldPlayerState);
        internal void on_ReceiveOverrideWith(PlayerState OldPlayerState) =>
            ReceiveOverrideWith?.Invoke(OldPlayerState);


        ///<summary>returns current player name</summary>
        public string GetPlayerName()  => 
            PlayerState_methods.GetPlayerName_method.Invoke(ObjPointer);
        ///<summary>Player's current score.</summary>
        public unsafe float Score {
            get {return PlayerState_ptr->Score;}
        }
        ///<summary>Replicated compressed ping for this player (holds ping in msec divided by 4)</summary>
        public unsafe byte Ping {
            get {return PlayerState_ptr->Ping;}
        }
         //TODO: string FString PlayerName
        ///<summary>Unique net id number. Actual value varies based on current online subsystem, use it only as a guaranteed unique number per player.</summary>
        public unsafe int PlayerId {
            get {return PlayerState_ptr->PlayerId;}
        }
        public bool bIsSpectator {
            get {return Main.GetGetBoolPropertyByName(this, "bIsSpectator"); }
        }
        public bool bOnlySpectator {
            get {return Main.GetGetBoolPropertyByName(this, "bOnlySpectator"); }
            set {Main.SetGetBoolPropertyByName(this, "bOnlySpectator", value); }
        }
        public bool bIsABot {
            get {return Main.GetGetBoolPropertyByName(this, "bIsABot"); }
        }
        public bool bIsInactive {
            get {return Main.GetGetBoolPropertyByName(this, "bIsInactive"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsInactive", value); }
        }
        public bool bFromPreviousLevel {
            get {return Main.GetGetBoolPropertyByName(this, "bFromPreviousLevel"); }
            set {Main.SetGetBoolPropertyByName(this, "bFromPreviousLevel", value); }
        }
        ///<summary>Elapsed time on server when this PlayerState was first created.</summary>
        public unsafe int StartTime {
            get {return PlayerState_ptr->StartTime;}
            set {PlayerState_ptr->StartTime = value;}
        }
        ///<summary>This is used for sending game agnostic messages that can be localized</summary>
        public unsafe SubclassOf<LocalMessage> EngineMessageClass {
            get {return PlayerState_ptr->EngineMessageClass;}
            set {PlayerState_ptr->EngineMessageClass = value;}
        }
         //TODO: string FString SavedNetworkAddress
        ///<summary>The id used by the network to uniquely identify a player.</summary>
        ///<remarks>
        ///NOTE: the internals of this property should *never* be exposed to the player as it's transient
        ///and opaque in meaning (ie it might mean date/time followed by something else).
        ///It is OK to use and pass around this property, though.
        ///</remarks>
        public unsafe UniqueNetIdRepl UniqueId {
            get {return PlayerState_ptr->UniqueId;}
            set {PlayerState_ptr->UniqueId = value;}
        }
         //TODO: string FString PlayerNamePrivate
        public bool bShouldUpdateReplicatedPing {
            get {return Main.GetGetBoolPropertyByName(this, "bShouldUpdateReplicatedPing"); }
            set {Main.SetGetBoolPropertyByName(this, "bShouldUpdateReplicatedPing", value); }
        }
        static PlayerState() {
            StaticClass = Main.GetClass("PlayerState");
            PlayerState_events.ReceiveCopyProperties_event.Setup();
            PlayerState_events.ReceiveOverrideWith_event.Setup();
        }
        internal unsafe PlayerState_fields* PlayerState_ptr => (PlayerState_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PlayerState(IntPtr p) => UObject.Make<PlayerState>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PlayerState DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PlayerState New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
