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
    ///<summary>Net Driver</summary>
    public unsafe partial class NetDriver : UObject  {
         //TODO: string FString NetConnectionClassName
         //TODO: string FString ReplicationDriverClassName
        ///<summary>@todo document</summary>
        public unsafe int MaxDownloadSize {
            get {return NetDriver_ptr->MaxDownloadSize;}
            set {NetDriver_ptr->MaxDownloadSize = value;}
        }
        public bool bClampListenServerTickRate {
            get {return Main.GetGetBoolPropertyByName(this, "bClampListenServerTickRate"); }
            set {Main.SetGetBoolPropertyByName(this, "bClampListenServerTickRate", value); }
        }
        ///<summary>@todo document</summary>
        public unsafe int NetServerMaxTickRate {
            get {return NetDriver_ptr->NetServerMaxTickRate;}
            set {NetDriver_ptr->NetServerMaxTickRate = value;}
        }
        ///<summary>@todo document</summary>
        public unsafe int MaxInternetClientRate {
            get {return NetDriver_ptr->MaxInternetClientRate;}
            set {NetDriver_ptr->MaxInternetClientRate = value;}
        }
        ///<summary>@todo document</summary>
        public unsafe int MaxClientRate {
            get {return NetDriver_ptr->MaxClientRate;}
            set {NetDriver_ptr->MaxClientRate = value;}
        }
        ///<summary>Amount of time a server will wait before traveling to next map, gives clients time to receive final RPCs on existing level @see NextSwitchCountdown</summary>
        public unsafe float ServerTravelPause {
            get {return NetDriver_ptr->ServerTravelPause;}
            set {NetDriver_ptr->ServerTravelPause = value;}
        }
        ///<summary>@todo document</summary>
        public unsafe float SpawnPrioritySeconds {
            get {return NetDriver_ptr->SpawnPrioritySeconds;}
            set {NetDriver_ptr->SpawnPrioritySeconds = value;}
        }
        ///<summary>@todo document</summary>
        public unsafe float RelevantTimeout {
            get {return NetDriver_ptr->RelevantTimeout;}
            set {NetDriver_ptr->RelevantTimeout = value;}
        }
        ///<summary>@todo document</summary>
        public unsafe float KeepAliveTime {
            get {return NetDriver_ptr->KeepAliveTime;}
            set {NetDriver_ptr->KeepAliveTime = value;}
        }
        ///<summary>Amount of time to wait for a new net connection to be established before destroying the connection</summary>
        public unsafe float InitialConnectTimeout {
            get {return NetDriver_ptr->InitialConnectTimeout;}
            set {NetDriver_ptr->InitialConnectTimeout = value;}
        }
        ///<summary>Amount of time to wait before considering an established connection timed out.</summary>
        ///<remarks>
        ///Typically shorter than the time to wait on a new connection because this connection
        ///should already have been setup and any interruption should be trapped quicker.
        ///</remarks>
        public unsafe float ConnectionTimeout {
            get {return NetDriver_ptr->ConnectionTimeout;}
            set {NetDriver_ptr->ConnectionTimeout = value;}
        }
        ///<summary>
        ///A multiplier that is applied to the above values when we are running with unoptimized builds (debug)
        ///or data (uncooked).
        ///</summary>
        ///<remarks>
        ///This allows us to retain normal timeout behavior while debugging without resorting
        ///to the nuclear 'notimeouts' option or bumping the values above. If ==0 multiplier = 1
        ///</remarks>
        public unsafe float TimeoutMultiplierForUnoptimizedBuilds {
            get {return NetDriver_ptr->TimeoutMultiplierForUnoptimizedBuilds;}
            set {NetDriver_ptr->TimeoutMultiplierForUnoptimizedBuilds = value;}
        }
        public bool bNoTimeouts {
            get {return Main.GetGetBoolPropertyByName(this, "bNoTimeouts"); }
            set {Main.SetGetBoolPropertyByName(this, "bNoTimeouts", value); }
        }
        ///<summary>Connection to the server (this net driver is a client)</summary>
        public unsafe NetConnection ServerConnection {
            get {return NetDriver_ptr->ServerConnection;}
            set {NetDriver_ptr->ServerConnection = value;}
        }
        ///<summary>Array of connections to clients (this net driver is a host)</summary>
        public ObjectArrayField<NetConnection> ClientConnections{ get {
            if(ClientConnections_store == null) ClientConnections_store = new ObjectArrayField<NetConnection> (&NetDriver_ptr->ClientConnections);
            return ClientConnections_store;
        } }
        private ObjectArrayField<NetConnection> ClientConnections_store;

        ///<summary>World this net driver is associated with</summary>
        public unsafe World World {
            get {return NetDriver_ptr->World;}
            set {NetDriver_ptr->World = value;}
        }
        ///<summary>World Package</summary>
        public unsafe Package WorldPackage {
            get {return NetDriver_ptr->WorldPackage;}
            set {NetDriver_ptr->WorldPackage = value;}
        }
        ///<summary>The loaded UClass of the net connection type to use</summary>
        public unsafe SubclassOf<UObject> NetConnectionClass {
            get {return NetDriver_ptr->NetConnectionClass;}
            set {NetDriver_ptr->NetConnectionClass = value;}
        }
        ///<summary>Replication Driver Class</summary>
        public unsafe SubclassOf<UObject> ReplicationDriverClass {
            get {return NetDriver_ptr->ReplicationDriverClass;}
            set {NetDriver_ptr->ReplicationDriverClass = value;}
        }
        ///<summary>@todo document</summary>
        public unsafe Property RoleProperty {
            get {return NetDriver_ptr->RoleProperty;}
            set {NetDriver_ptr->RoleProperty = value;}
        }
        ///<summary>@todo document</summary>
        public unsafe Property RemoteRoleProperty {
            get {return NetDriver_ptr->RemoteRoleProperty;}
            set {NetDriver_ptr->RemoteRoleProperty = value;}
        }
        ///<summary>Used to specify the net driver to filter actors with (NAME_None || NAME_GameNetDriver is the default net driver)</summary>
        public unsafe Name NetDriverName {
            get {return NetDriver_ptr->NetDriverName;}
            set {NetDriver_ptr->NetDriverName = value;}
        }
        ///<summary>Accumulated time for the net driver, updated by Tick</summary>
        public unsafe float Time {
            get {return NetDriver_ptr->Time;}
            set {NetDriver_ptr->Time = value;}
        }
        ///<summary>Replication Driver</summary>
        public unsafe ReplicationDriver ReplicationDriver {
            get {return NetDriver_ptr->ReplicationDriver;}
            set {NetDriver_ptr->ReplicationDriver = value;}
        }
        static NetDriver() {
            StaticClass = Main.GetClass("NetDriver");
        }
        internal unsafe NetDriver_fields* NetDriver_ptr => (NetDriver_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator NetDriver(IntPtr p) => UObject.Make<NetDriver>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static NetDriver DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static NetDriver New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
