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
using UE4.OnlineSubsystemUtils.Native;

namespace UE4.OnlineSubsystemUtils {
    ///<summary>A beacon host used for taking reservations for an existing game session</summary>
    public unsafe partial class PartyBeaconState : UObject  {
        ///<summary>Session tied to the beacon</summary>
        public unsafe Name SessionName {
            get {return PartyBeaconState_ptr->SessionName;}
            set {PartyBeaconState_ptr->SessionName = value;}
        }
        ///<summary>Number of currently consumed reservations</summary>
        public unsafe int NumConsumedReservations {
            get {return PartyBeaconState_ptr->NumConsumedReservations;}
            set {PartyBeaconState_ptr->NumConsumedReservations = value;}
        }
        ///<summary>Maximum allowed reservations</summary>
        public unsafe int MaxReservations {
            get {return PartyBeaconState_ptr->MaxReservations;}
            set {PartyBeaconState_ptr->MaxReservations = value;}
        }
        ///<summary>Number of teams in the game</summary>
        public unsafe int NumTeams {
            get {return PartyBeaconState_ptr->NumTeams;}
            set {PartyBeaconState_ptr->NumTeams = value;}
        }
        ///<summary>Number of players on each team for balancing</summary>
        public unsafe int NumPlayersPerTeam {
            get {return PartyBeaconState_ptr->NumPlayersPerTeam;}
            set {PartyBeaconState_ptr->NumPlayersPerTeam = value;}
        }
        ///<summary>Team assignment method</summary>
        public unsafe Name TeamAssignmentMethod {
            get {return PartyBeaconState_ptr->TeamAssignmentMethod;}
            set {PartyBeaconState_ptr->TeamAssignmentMethod = value;}
        }
        ///<summary>Team that the host has been assigned to</summary>
        public unsafe int ReservedHostTeamNum {
            get {return PartyBeaconState_ptr->ReservedHostTeamNum;}
            set {PartyBeaconState_ptr->ReservedHostTeamNum = value;}
        }
        ///<summary>Team that everyone is forced to in single team games</summary>
        public unsafe int ForceTeamNum {
            get {return PartyBeaconState_ptr->ForceTeamNum;}
            set {PartyBeaconState_ptr->ForceTeamNum = value;}
        }
        public bool bRestrictCrossConsole {
            get {return Main.GetGetBoolPropertyByName(this, "bRestrictCrossConsole"); }
            set {Main.SetGetBoolPropertyByName(this, "bRestrictCrossConsole", value); }
        }
         //TODO: array not UObject TArray Reservations
        static PartyBeaconState() {
            StaticClass = Main.GetClass("PartyBeaconState");
        }
        internal unsafe PartyBeaconState_fields* PartyBeaconState_ptr => (PartyBeaconState_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PartyBeaconState(IntPtr p) => UObject.Make<PartyBeaconState>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PartyBeaconState DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PartyBeaconState New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
