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
    ///<summary>A beacon client used for making reservations with an existing game session</summary>
    public unsafe partial class PartyBeaconClient : OnlineBeaconClient  {
         //TODO: string FString DestSessionId
        ///<summary>Pending reservation that will be sent upon connection with the intended host</summary>
        public unsafe PartyReservation PendingReservation {
            get {return PartyBeaconClient_ptr->PendingReservation;}
            set {PartyBeaconClient_ptr->PendingReservation = value;}
        }
         //TODO: enum EClientRequestType RequestType
        public bool bPendingReservationSent {
            get {return Main.GetGetBoolPropertyByName(this, "bPendingReservationSent"); }
            set {Main.SetGetBoolPropertyByName(this, "bPendingReservationSent", value); }
        }
        public bool bCancelReservation {
            get {return Main.GetGetBoolPropertyByName(this, "bCancelReservation"); }
            set {Main.SetGetBoolPropertyByName(this, "bCancelReservation", value); }
        }
        static PartyBeaconClient() {
            StaticClass = Main.GetClass("PartyBeaconClient");
        }
        internal unsafe PartyBeaconClient_fields* PartyBeaconClient_ptr => (PartyBeaconClient_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PartyBeaconClient(IntPtr p) => UObject.Make<PartyBeaconClient>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PartyBeaconClient DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PartyBeaconClient New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
