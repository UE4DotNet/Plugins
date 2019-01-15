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
    ///<summary>A channel for exchanging actor and its subobject's properties and RPCs.</summary>
    ///<remarks>
    ///ActorChannel manages the creation and lifetime of a replicated actor. Actual replication of properties and RPCs
    ///actually happens in FObjectReplicator now (see DataReplication.h).
    ///
    ///An ActorChannel bunch looks like this:
    ///
    ///+----------------------+---------------------------------------------------------------------------+
    ///| SpawnInfo            | (Spawn Info) Initial bunch only                                           |
    ///|  -Actor Class        |   -Created by ActorChannel                                                |
    ///|  -Spawn Loc/Rot      |                                                                           |
    ///| NetGUID assigns      |                                                                           |
    ///|  -Actor NetGUID      |                                                                           |
    ///|  -Component NetGUIDs |                                                                           |
    ///+----------------------+---------------------------------------------------------------------------+
    ///|                      |                                                                           |
    ///+----------------------+---------------------------------------------------------------------------+
    ///| NetGUID ObjRef       | (Content chunks) x number of replicating objects (Actor + any components) |
    ///|                      |   -Each chunk created by its own FObjectReplicator instance.              |
    ///+----------------------+---------------------------------------------------------------------------+
    ///|                      |                                                                           |
    ///| Properties...        |                                                                           |
    ///|                      |                                                                           |
    ///| RPCs...              |                                                                           |
    ///|                      |                                                                           |
    ///+----------------------+---------------------------------------------------------------------------+
    ///| </End Tag>           |                                                                           |
    ///+----------------------+---------------------------------------------------------------------------+
    ///</remarks>
    public unsafe partial class ActorChannel : Channel  {
        ///<summary>Variables.</summary>
        public unsafe Actor Actor {
            get {return ActorChannel_ptr->Actor;}
            set {ActorChannel_ptr->Actor = value;}
        }
        ///<summary>These guids are waiting for their resolves, we need to queue up bunches until these are resolved</summary>
        public ObjectArrayField<UObject> CreateSubObjects{ get {
            if(CreateSubObjects_store == null) CreateSubObjects_store = new ObjectArrayField<UObject> (&ActorChannel_ptr->CreateSubObjects);
            return CreateSubObjects_store;
        } }
        private ObjectArrayField<UObject> CreateSubObjects_store;

        static ActorChannel() {
            StaticClass = Main.GetClass("ActorChannel");
        }
        internal unsafe ActorChannel_fields* ActorChannel_ptr => (ActorChannel_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ActorChannel(IntPtr p) => UObject.Make<ActorChannel>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ActorChannel DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ActorChannel New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
