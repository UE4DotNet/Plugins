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
    public unsafe partial class PartyBeaconHost : OnlineBeaconHostObject  {
        ///<summary>State of the beacon</summary>
        public unsafe PartyBeaconState State {
            get {return PartyBeaconHost_ptr->State;}
            set {PartyBeaconHost_ptr->State = value;}
        }
        public bool bLogoutOnSessionTimeout {
            get {return Main.GetGetBoolPropertyByName(this, "bLogoutOnSessionTimeout"); }
            set {Main.SetGetBoolPropertyByName(this, "bLogoutOnSessionTimeout", value); }
        }
        ///<summary>Seconds that can elapse before a reservation is removed due to player not being registered with the session</summary>
        public unsafe float SessionTimeoutSecs {
            get {return PartyBeaconHost_ptr->SessionTimeoutSecs;}
            set {PartyBeaconHost_ptr->SessionTimeoutSecs = value;}
        }
        ///<summary>Seconds that can elapse before a reservation is removed due to player not being registered with the session during a travel</summary>
        public unsafe float TravelSessionTimeoutSecs {
            get {return PartyBeaconHost_ptr->TravelSessionTimeoutSecs;}
            set {PartyBeaconHost_ptr->TravelSessionTimeoutSecs = value;}
        }
        static PartyBeaconHost() {
            StaticClass = Main.GetClass("PartyBeaconHost");
        }
        internal unsafe PartyBeaconHost_fields* PartyBeaconHost_ptr => (PartyBeaconHost_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PartyBeaconHost(IntPtr p) => UObject.Make<PartyBeaconHost>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PartyBeaconHost DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PartyBeaconHost New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
