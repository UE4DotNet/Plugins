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
    ///<summary>Class used to replicate server "stat net" data over.</summary>
    ///<remarks>
    ///For server only values, the client data is
    ///is overwritten when bUpdateStatNet == true. For data that both the client and server set, the server
    ///data will only overwrite if bUpdateStatNet == true && bOverwriteClientStats == true.
    ///</remarks>
    public unsafe partial class ServerStatReplicator : Info  {
        public bool bUpdateStatNet {
            get {return Main.GetGetBoolPropertyByName(this, "bUpdateStatNet"); }
            set {Main.SetGetBoolPropertyByName(this, "bUpdateStatNet", value); }
        }
        public bool bOverwriteClientStats {
            get {return Main.GetGetBoolPropertyByName(this, "bOverwriteClientStats"); }
            set {Main.SetGetBoolPropertyByName(this, "bOverwriteClientStats", value); }
        }
         //TODO: numeric uint32 Channels
         //TODO: numeric uint32 InRate
         //TODO: numeric uint32 OutRate
         //TODO: numeric uint32 OutSaturation
         //TODO: numeric uint32 MaxPacketOverhead
         //TODO: numeric uint32 InRateClientMax
         //TODO: numeric uint32 InRateClientMin
         //TODO: numeric uint32 InRateClientAvg
         //TODO: numeric uint32 InPacketsClientMax
         //TODO: numeric uint32 InPacketsClientMin
         //TODO: numeric uint32 InPacketsClientAvg
         //TODO: numeric uint32 OutRateClientMax
         //TODO: numeric uint32 OutRateClientMin
         //TODO: numeric uint32 OutRateClientAvg
         //TODO: numeric uint32 OutPacketsClientMax
         //TODO: numeric uint32 OutPacketsClientMin
         //TODO: numeric uint32 OutPacketsClientAvg
         //TODO: numeric uint32 NetNumClients
         //TODO: numeric uint32 InPackets
         //TODO: numeric uint32 OutPackets
         //TODO: numeric uint32 InBunches
         //TODO: numeric uint32 OutBunches
         //TODO: numeric uint32 OutLoss
         //TODO: numeric uint32 InLoss
         //TODO: numeric uint32 VoiceBytesSent
         //TODO: numeric uint32 VoiceBytesRecv
         //TODO: numeric uint32 VoicePacketsSent
         //TODO: numeric uint32 VoicePacketsRecv
         //TODO: numeric uint32 PercentInVoice
         //TODO: numeric uint32 PercentOutVoice
         //TODO: numeric uint32 NumActorChannels
         //TODO: numeric uint32 NumConsideredActors
         //TODO: numeric uint32 PrioritizedActors
         //TODO: numeric uint32 NumRelevantActors
         //TODO: numeric uint32 NumRelevantDeletedActors
         //TODO: numeric uint32 NumReplicatedActorAttempts
         //TODO: numeric uint32 NumReplicatedActors
         //TODO: numeric uint32 NumActors
         //TODO: numeric uint32 NumNetActors
         //TODO: numeric uint32 NumDormantActors
         //TODO: numeric uint32 NumInitiallyDormantActors
         //TODO: numeric uint32 NumNetGUIDsAckd
         //TODO: numeric uint32 NumNetGUIDsPending
         //TODO: numeric uint32 NumNetGUIDsUnAckd
         //TODO: numeric uint32 ObjPathBytes
         //TODO: numeric uint32 NetGUIDOutRate
         //TODO: numeric uint32 NetGUIDInRate
         //TODO: numeric uint32 NetSaturated
        static ServerStatReplicator() {
            StaticClass = Main.GetClass("ServerStatReplicator");
        }
        internal unsafe ServerStatReplicator_fields* ServerStatReplicator_ptr => (ServerStatReplicator_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ServerStatReplicator(IntPtr p) => UObject.Make<ServerStatReplicator>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ServerStatReplicator DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ServerStatReplicator New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
