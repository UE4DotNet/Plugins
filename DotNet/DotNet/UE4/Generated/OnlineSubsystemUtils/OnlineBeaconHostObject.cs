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
    ///Base class for any unique beacon connectivity, paired with an AOnlineBeaconClient implementation
    ///By defining a beacon type and implementing the ability to spawn unique AOnlineBeaconClients, any two instances of the engine
    ///</summary>
    ///<remarks>can communicate with each other without officially connecting through normal Unreal networking</remarks>
    public unsafe partial class OnlineBeaconHostObject : Actor  {
         //TODO: string FString BeaconTypeName
        ///<summary>Class reference for spawning client beacon actor</summary>
        public unsafe SubclassOf<OnlineBeaconClient> ClientBeaconActorClass {
            get {return OnlineBeaconHostObject_ptr->ClientBeaconActorClass;}
            set {OnlineBeaconHostObject_ptr->ClientBeaconActorClass = value;}
        }
        ///<summary>List of all client beacon actors with active connections</summary>
        public ObjectArrayField<OnlineBeaconClient> ClientActors{ get {
            if(ClientActors_store == null) ClientActors_store = new ObjectArrayField<OnlineBeaconClient> (&OnlineBeaconHostObject_ptr->ClientActors);
            return ClientActors_store;
        } }
        private ObjectArrayField<OnlineBeaconClient> ClientActors_store;

        static OnlineBeaconHostObject() {
            StaticClass = Main.GetClass("OnlineBeaconHostObject");
        }
        internal unsafe OnlineBeaconHostObject_fields* OnlineBeaconHostObject_ptr => (OnlineBeaconHostObject_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator OnlineBeaconHostObject(IntPtr p) => UObject.Make<OnlineBeaconHostObject>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static OnlineBeaconHostObject DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static OnlineBeaconHostObject New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
