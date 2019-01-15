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
    [StructLayout( LayoutKind.Explicit, Size=144 )]
    internal unsafe struct PartyBeaconState_fields {
        [FieldOffset(56)] public Name SessionName;
        [FieldOffset(68)] public int NumConsumedReservations;
        [FieldOffset(72)] public int MaxReservations;
        [FieldOffset(76)] public int NumTeams;
        [FieldOffset(80)] public int NumPlayersPerTeam;
        [FieldOffset(84)] public Name TeamAssignmentMethod;
        [FieldOffset(96)] public int ReservedHostTeamNum;
        [FieldOffset(100)] public int ForceTeamNum;
        [FieldOffset(104)] public bool bRestrictCrossConsole;
        [FieldOffset(112)] public NativeArray Reservations;
    }
    internal unsafe struct PartyBeaconState_methods {
    }
    internal unsafe struct PartyBeaconState_events {
    }
}
