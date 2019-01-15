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
    ///<summary>
    ///Main actor that listens for side channel communication from another Unreal Engine application
    ///The AOnlineBeaconHost listens for connections to route to a registered AOnlineBeaconHostObject
    ///The AOnlineBeaconHostObject is responsible for spawning the server version of the AOnlineBeaconClient
    ///</summary>
    ///<remarks>The AOnlineBeaconHost pairs the two client actors, verifies the validity of the exchange, and accepts/continues the connection</remarks>
    public unsafe partial class OnlineBeaconHost : OnlineBeacon  {
        ///<summary>Configured listen port for this beacon host</summary>
        public unsafe int ListenPort {
            get {return OnlineBeaconHost_ptr->ListenPort;}
            set {OnlineBeaconHost_ptr->ListenPort = value;}
        }
        ///<summary>List of all client beacon actors with active connections</summary>
        public ObjectArrayField<OnlineBeaconClient> ClientActors{ get {
            if(ClientActors_store == null) ClientActors_store = new ObjectArrayField<OnlineBeaconClient> (&OnlineBeaconHost_ptr->ClientActors);
            return ClientActors_store;
        } }
        private ObjectArrayField<OnlineBeaconClient> ClientActors_store;

        static OnlineBeaconHost() {
            StaticClass = Main.GetClass("OnlineBeaconHost");
        }
        internal unsafe OnlineBeaconHost_fields* OnlineBeaconHost_ptr => (OnlineBeaconHost_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator OnlineBeaconHost(IntPtr p) => UObject.Make<OnlineBeaconHost>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static OnlineBeaconHost DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static OnlineBeaconHost New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
