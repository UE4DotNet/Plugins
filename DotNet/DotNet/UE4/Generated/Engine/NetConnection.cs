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
    ///<summary>Delegates</summary>
    public unsafe partial class NetConnection : Player  {
        ///<summary>child connections for secondary viewports</summary>
        public ObjectArrayField<ChildConnection> Children{ get {
            if(Children_store == null) Children_store = new ObjectArrayField<ChildConnection> (&NetConnection_ptr->Children);
            return Children_store;
        } }
        private ObjectArrayField<ChildConnection> Children_store;

        ///<summary>Owning net driver</summary>
        public unsafe NetDriver Driver {
            get {return NetConnection_ptr->Driver;}
            set {NetConnection_ptr->Driver = value;}
        }
        ///<summary>The class name for the PackageMap to be loaded</summary>
        public unsafe SubclassOf<PackageMap> PackageMapClass {
            get {return NetConnection_ptr->PackageMapClass;}
            set {NetConnection_ptr->PackageMapClass = value;}
        }
        ///<summary>Package map between local and remote. (negotiates net serialization)</summary>
        public unsafe PackageMap PackageMap {
            get {return NetConnection_ptr->PackageMap;}
            set {NetConnection_ptr->PackageMap = value;}
        }
        ///<summary>@todo document</summary>
        public ObjectArrayField<Channel> OpenChannels{ get {
            if(OpenChannels_store == null) OpenChannels_store = new ObjectArrayField<Channel> (&NetConnection_ptr->OpenChannels);
            return OpenChannels_store;
        } }
        private ObjectArrayField<Channel> OpenChannels_store;

        ///<summary>This actor is bNetTemporary, which means it should never be replicated after it's initial packet is complete</summary>
        public ObjectArrayField<Actor> SentTemporaries{ get {
            if(SentTemporaries_store == null) SentTemporaries_store = new ObjectArrayField<Actor> (&NetConnection_ptr->SentTemporaries);
            return SentTemporaries_store;
        } }
        private ObjectArrayField<Actor> SentTemporaries_store;

        ///<summary>The actor that is currently being viewed/controlled by the owning controller</summary>
        public unsafe Actor ViewTarget {
            get {return NetConnection_ptr->ViewTarget;}
            set {NetConnection_ptr->ViewTarget = value;}
        }
        ///<summary>Reference to controlling actor (usually PlayerController)</summary>
        public unsafe Actor OwningActor {
            get {return NetConnection_ptr->OwningActor;}
            set {NetConnection_ptr->OwningActor = value;}
        }
        ///<summary>Max Packet</summary>
        public unsafe int MaxPacket {
            get {return NetConnection_ptr->MaxPacket;}
            set {NetConnection_ptr->MaxPacket = value;}
        }
        public bool InternalAck {
            get {return Main.GetGetBoolPropertyByName(this, "InternalAck"); }
            set {Main.SetGetBoolPropertyByName(this, "InternalAck", value); }
        }
        ///<summary>Net id of remote player on this connection. Only valid on client connections (server side).</summary>
        public unsafe UniqueNetIdRepl PlayerId {
            get {return NetConnection_ptr->PlayerId;}
            set {NetConnection_ptr->PlayerId = value;}
        }
        ///<summary>Internal.</summary>
        public unsafe double LastReceiveTime {
            get {return NetConnection_ptr->LastReceiveTime;}
            set {NetConnection_ptr->LastReceiveTime = value;}
        }
        ///<summary>The channels that need ticking.</summary>
        ///<remarks>
        ///This will be a subset of OpenChannels, only including
        ///channels that need to process either dormancy or queued bunches. Should be a significant
        ///optimization over ticking and calling virtual functions on the potentially hundreds of
        ///OpenChannels every frame.
        ///</remarks>
        public ObjectArrayField<Channel> ChannelsToTick{ get {
            if(ChannelsToTick_store == null) ChannelsToTick_store = new ObjectArrayField<Channel> (&NetConnection_ptr->ChannelsToTick);
            return ChannelsToTick_store;
        } }
        private ObjectArrayField<Channel> ChannelsToTick_store;

        static NetConnection() {
            StaticClass = Main.GetClass("NetConnection");
        }
        internal unsafe NetConnection_fields* NetConnection_ptr => (NetConnection_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator NetConnection(IntPtr p) => UObject.Make<NetConnection>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static NetConnection DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static NetConnection New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
