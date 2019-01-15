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


namespace UE4.OnlineSubsystemUtils.Native {
    [StructLayout( LayoutKind.Explicit, Size=1304 )]
    internal unsafe struct PartyBeaconClient_fields {
        [FieldOffset(1176)] byte DestSessionId; //TODO: string FString DestSessionId
        [FieldOffset(1192)] public PartyReservation PendingReservation;
        [FieldOffset(1256)] byte RequestType; //TODO: enum EClientRequestType RequestType
        [FieldOffset(1257)] public bool bPendingReservationSent;
        [FieldOffset(1258)] public bool bCancelReservation;
    }
    internal unsafe struct PartyBeaconClient_methods {
    }
    internal unsafe struct PartyBeaconClient_events {
    }
}
