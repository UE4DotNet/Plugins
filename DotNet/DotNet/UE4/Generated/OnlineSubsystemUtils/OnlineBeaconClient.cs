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
using UE4.Engine;

namespace UE4.OnlineSubsystemUtils {
    ///<summary>
    ///Base class for any unique beacon connectivity, paired with an AOnlineBeaconHostObject implementation
    ///This is the actual actor that replicates across client/server and where all RPCs occur
    ///On the host, the life cycle is managed by an AOnlineBeaconHostObject
    ///</summary>
    ///<remarks>On the client, the life cycle is managed by the game</remarks>
    public unsafe partial class OnlineBeaconClient : OnlineBeacon  {
        ///<summary>Owning beacon host of this beacon actor (server only)</summary>
        public unsafe OnlineBeaconHostObject BeaconOwner {
            get {return OnlineBeaconClient_ptr->BeaconOwner;}
            set {OnlineBeaconClient_ptr->BeaconOwner = value;}
        }
        ///<summary>Network connection associated with this beacon client instance</summary>
        public unsafe NetConnection BeaconConnection {
            get {return OnlineBeaconClient_ptr->BeaconConnection;}
            set {OnlineBeaconClient_ptr->BeaconConnection = value;}
        }
         //TODO: enum EBeaconConnectionState ConnectionState
        static OnlineBeaconClient() {
            StaticClass = Main.GetClass("OnlineBeaconClient");
        }
        internal unsafe OnlineBeaconClient_fields* OnlineBeaconClient_ptr => (OnlineBeaconClient_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator OnlineBeaconClient(IntPtr p) => UObject.Make<OnlineBeaconClient>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static OnlineBeaconClient DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static OnlineBeaconClient New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
