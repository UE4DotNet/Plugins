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


namespace UE4.Engine.Native {
    [StructLayout( LayoutKind.Explicit, Size=1216 )]
    internal unsafe struct ServerStatReplicator_fields {
        [FieldOffset(1016)] public bool bUpdateStatNet;
        [FieldOffset(1017)] public bool bOverwriteClientStats;
        [FieldOffset(1020)] byte Channels; //TODO: numeric uint32 Channels
        [FieldOffset(1024)] byte InRate; //TODO: numeric uint32 InRate
        [FieldOffset(1028)] byte OutRate; //TODO: numeric uint32 OutRate
        [FieldOffset(1032)] byte OutSaturation; //TODO: numeric uint32 OutSaturation
        [FieldOffset(1036)] byte MaxPacketOverhead; //TODO: numeric uint32 MaxPacketOverhead
        [FieldOffset(1040)] byte InRateClientMax; //TODO: numeric uint32 InRateClientMax
        [FieldOffset(1044)] byte InRateClientMin; //TODO: numeric uint32 InRateClientMin
        [FieldOffset(1048)] byte InRateClientAvg; //TODO: numeric uint32 InRateClientAvg
        [FieldOffset(1052)] byte InPacketsClientMax; //TODO: numeric uint32 InPacketsClientMax
        [FieldOffset(1056)] byte InPacketsClientMin; //TODO: numeric uint32 InPacketsClientMin
        [FieldOffset(1060)] byte InPacketsClientAvg; //TODO: numeric uint32 InPacketsClientAvg
        [FieldOffset(1064)] byte OutRateClientMax; //TODO: numeric uint32 OutRateClientMax
        [FieldOffset(1068)] byte OutRateClientMin; //TODO: numeric uint32 OutRateClientMin
        [FieldOffset(1072)] byte OutRateClientAvg; //TODO: numeric uint32 OutRateClientAvg
        [FieldOffset(1076)] byte OutPacketsClientMax; //TODO: numeric uint32 OutPacketsClientMax
        [FieldOffset(1080)] byte OutPacketsClientMin; //TODO: numeric uint32 OutPacketsClientMin
        [FieldOffset(1084)] byte OutPacketsClientAvg; //TODO: numeric uint32 OutPacketsClientAvg
        [FieldOffset(1088)] byte NetNumClients; //TODO: numeric uint32 NetNumClients
        [FieldOffset(1092)] byte InPackets; //TODO: numeric uint32 InPackets
        [FieldOffset(1096)] byte OutPackets; //TODO: numeric uint32 OutPackets
        [FieldOffset(1100)] byte InBunches; //TODO: numeric uint32 InBunches
        [FieldOffset(1104)] byte OutBunches; //TODO: numeric uint32 OutBunches
        [FieldOffset(1108)] byte OutLoss; //TODO: numeric uint32 OutLoss
        [FieldOffset(1112)] byte InLoss; //TODO: numeric uint32 InLoss
        [FieldOffset(1116)] byte VoiceBytesSent; //TODO: numeric uint32 VoiceBytesSent
        [FieldOffset(1120)] byte VoiceBytesRecv; //TODO: numeric uint32 VoiceBytesRecv
        [FieldOffset(1124)] byte VoicePacketsSent; //TODO: numeric uint32 VoicePacketsSent
        [FieldOffset(1128)] byte VoicePacketsRecv; //TODO: numeric uint32 VoicePacketsRecv
        [FieldOffset(1132)] byte PercentInVoice; //TODO: numeric uint32 PercentInVoice
        [FieldOffset(1136)] byte PercentOutVoice; //TODO: numeric uint32 PercentOutVoice
        [FieldOffset(1140)] byte NumActorChannels; //TODO: numeric uint32 NumActorChannels
        [FieldOffset(1144)] byte NumConsideredActors; //TODO: numeric uint32 NumConsideredActors
        [FieldOffset(1148)] byte PrioritizedActors; //TODO: numeric uint32 PrioritizedActors
        [FieldOffset(1152)] byte NumRelevantActors; //TODO: numeric uint32 NumRelevantActors
        [FieldOffset(1156)] byte NumRelevantDeletedActors; //TODO: numeric uint32 NumRelevantDeletedActors
        [FieldOffset(1160)] byte NumReplicatedActorAttempts; //TODO: numeric uint32 NumReplicatedActorAttempts
        [FieldOffset(1164)] byte NumReplicatedActors; //TODO: numeric uint32 NumReplicatedActors
        [FieldOffset(1168)] byte NumActors; //TODO: numeric uint32 NumActors
        [FieldOffset(1172)] byte NumNetActors; //TODO: numeric uint32 NumNetActors
        [FieldOffset(1176)] byte NumDormantActors; //TODO: numeric uint32 NumDormantActors
        [FieldOffset(1180)] byte NumInitiallyDormantActors; //TODO: numeric uint32 NumInitiallyDormantActors
        [FieldOffset(1184)] byte NumNetGUIDsAckd; //TODO: numeric uint32 NumNetGUIDsAckd
        [FieldOffset(1188)] byte NumNetGUIDsPending; //TODO: numeric uint32 NumNetGUIDsPending
        [FieldOffset(1192)] byte NumNetGUIDsUnAckd; //TODO: numeric uint32 NumNetGUIDsUnAckd
        [FieldOffset(1196)] byte ObjPathBytes; //TODO: numeric uint32 ObjPathBytes
        [FieldOffset(1200)] byte NetGUIDOutRate; //TODO: numeric uint32 NetGUIDOutRate
        [FieldOffset(1204)] byte NetGUIDInRate; //TODO: numeric uint32 NetGUIDInRate
        [FieldOffset(1208)] byte NetSaturated; //TODO: numeric uint32 NetSaturated
    }
    internal unsafe struct ServerStatReplicator_methods {
    }
    internal unsafe struct ServerStatReplicator_events {
    }
}
